using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using App.Service.KeyBoard;
using App.Service.Mouse;

namespace App.Service
{
    public class AssassinFlag
    {
        public static void Move(int delay)
        {
            ShortcutManager.CtrlWith(Keys.N, delay);
            Thread.Sleep(delay);
            SendKeys.SendWait(4.ToString());
            Thread.Sleep(delay);
            Clicker.LeftClick(Cursor.Position.X, Cursor.Position.Y, delay);
            Thread.Sleep(delay);
            Clicker.RightClick(delay);
        }
    }
}