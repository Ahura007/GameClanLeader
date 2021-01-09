using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;
using App.Forms;
using App.Service;

namespace App
{
    internal static class Program
    {
        public static int RemainDay = 0;
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var isExpired = CheckDate();
            if (isExpired)
                Application.Run(new FrmExpired());
            else
                Application.Run(new FrmMain());
        }


     


        public static DateTime GetNetworkTime(string ntpServer = "pool.ntp.org", int timeout = 3000)
        {
            var ntpData = new byte[48];
            ntpData[0] = 0x1B; //LeapIndicator = 0 (no warning), VersionNum = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;
            var ipEndPoint = new IPEndPoint(addresses[0], 123);

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);
                socket.ReceiveTimeout = timeout;
                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            var intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | (ulong)ntpData[43];
            var fractalPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | (ulong)ntpData[47];

            var milliseconds = (intPart * 1000) + (fractalPart * 1000 / (1L << 32));
            var utcDateTime = new DateTime(1900, 1, 1).AddMilliseconds((long)milliseconds);

            return utcDateTime.ToLocalTime();
        }

        public static bool CheckDate()
        {
            try
            {
                var currentDate = GetNetworkTime();
                var expiryDate = DateTime.Parse("05/05/2021");
                RemainDay = (expiryDate - currentDate).Days;

                if (RemainDay < 0)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return true;
            }
        }
        public static ExpiredDateTime GetDateTime()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("http://worldclockapi.com/api/json/utc/now").Result;
                if (response.IsSuccessStatusCode)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    var dt = response.Content.ReadAsAsync<ExpiredDateTime>().Result;
                    return dt;
                }
            }
            throw new Exception("expired !!");
        }
        public class ExpiredDateTime
        {
            public DateTime CurrentDateTime { get; set; }
        }
    }
}