using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Service.KeyBoard
{
    public class RegisterKeys
    {
        public static List<Keys> GetKeys()
        {
            var keyList = new List<Keys>();
      
            keyList.Add(Keys.E);
            keyList.Add(Keys.F4);
            keyList.Add(Keys.F5);
            keyList.Add(Keys.F6);
            keyList.Add(Keys.N);
            keyList.Add(Keys.G);
            keyList.Add(Keys.H);
            keyList.Add(Keys.M);
            keyList.Add(Keys.B);
            keyList.Add(Keys.I);

            keyList.Add(Keys.NumPad1);
            keyList.Add(Keys.NumPad2);
            keyList.Add(Keys.NumPad3);
            keyList.Add(Keys.NumPad5);
            keyList.Add(Keys.Decimal);
            keyList.Add(Keys.Insert);
            keyList.Add(Keys.Divide);
            keyList.Add(Keys.Multiply);
            keyList.Add(Keys.Add);
            keyList.Add(Keys.Subtract);

            keyList.Add(Keys.PageDown);
            keyList.Add(Keys.Delete);
            keyList.Add(Keys.End);



            keyList.Add(Keys.A);
            keyList.Add(Keys.W);
            keyList.Add(Keys.S);
            keyList.Add(Keys.D);
            keyList.Add(Keys.Q);







            return keyList;
        }

    }
}
 



