using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
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


        public static bool CheckDate()
        {
            try
            {
                var currentDate = GetDateTime().CurrentDateTime;
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