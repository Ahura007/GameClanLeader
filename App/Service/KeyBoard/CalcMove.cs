using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.KeyBoard
{
    public class CalcMove
    {
        public static List<int> PikeSin { get; set; }
        public static List<int> Kn { get; set; }
        public static void SetPikeSin()
        {
            Kn.Clear();
            PikeSin.Clear();
            PikeSin.Add(0);
            PikeSin.Add(3);
            PikeSin.Add(4);
            PikeSin.Add(5);
            PikeSin.Add(6);
            PikeSin.Add(7);
            PikeSin.Add(8);
            PikeSin.Add(9);
        }

        public static void SetKn(List<int> knList)
        {
            foreach (var i in knList.Distinct().ToList())
            {
                Kn.Add(i);
            }
        }

        public static void Sort()
        {
            PikeSin.Sort();
            Kn.Sort();
        }

}
}
