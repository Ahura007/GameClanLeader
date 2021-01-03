using System;
using System.IO;
using Newtonsoft.Json;

namespace App.SettingShc
{
    public class Setting
    {
        public int CompressDelay { get; set; }
        public int FlagDelay { get; set; }
        public int DelayS { get; set; }
        public string Rules { get; set; }
        public int MouseSpeed { get; set; }
    }


    public enum ControlMode
    {
        PikeSin,
        Kn
    }


    public class SettingService
    {
        public static void Initialize()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\Setting.txt"))
            {
                var temp = File.Create(Environment.CurrentDirectory + "\\Setting.txt");
                temp.Close();
            } 
            
            
            if (!File.Exists(Environment.CurrentDirectory + "\\Pattern.txt"))
            {
                var temp = File.Create(Environment.CurrentDirectory + "\\Pattern.txt");
                temp.Close();
            
            }
        }

        public static Setting GetSetting()
        {
            var pattern = File.ReadAllText(Environment.CurrentDirectory + "\\Setting.txt");
            var setting = JsonConvert.DeserializeObject<Setting>(pattern);
            return setting;
        }


         
    }


}
