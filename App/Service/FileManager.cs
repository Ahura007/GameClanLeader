using System;
using System.IO;
using System.Security.Policy;
using App.SettingShc;
using Newtonsoft.Json;

namespace App.Service
{
    public class FileManager
    {

        public static bool IsExistFile(string path)
        {
            if (File.Exists(path))
                return true;
            return false;
        }


        public static void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                var temp = File.Create(path);
                temp.Close();
            }
        }



        public static void WriteFile(string path , string content)
        {
            using (var sw = File.CreateText(path))
            {
                sw.WriteLine(content);
            }
        }


        public static T ReadFile<T>(string path)
        {
            var pattern = File.ReadAllText(path);
            var setting = JsonConvert.DeserializeObject<T>(pattern);
            return setting;
        }
    }
}