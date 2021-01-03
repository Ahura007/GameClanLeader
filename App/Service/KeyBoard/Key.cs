using System.Threading;
using System.Windows.Forms;
using App.Service.Mouse;

namespace App.Service.KeyBoard
{
    public class Key
    {

        public static void MoveOne(int num, int delay)
        {
            var pos = MouseOperations.GetCursorPosition();
            SendKeys.Send(num.ToString());
            SendKeys.Flush();
            Clicker.LeftClick(pos.X, pos.Y, delay);
        }


        public static void SendKey(int keyCode, int delayNumber)
        {
            if (keyCode == (int) Keys.NumPad1)
            {
                for (var i = 1; i <= 2; i++)
                {
                    SendKeys.SendWait(i.ToString());
                    SendKeys.Flush();
                    Clicker.LeftClick(Cursor.Position.X, Cursor.Position.Y, delayNumber);
                    SendKeys.Flush();
                }
            }

            if (keyCode == (int) Keys.Add)
            {
                Clicker.RightClick(30);
                var temp = Cursor.Position;
                int x = 50;
                SendKeys.Send("2");
                Thread.Sleep(20);
                Clicker.LeftClick(180, 705, delayNumber);
                Thread.Sleep(x + 30);
                SendKeys.Send("1");
                Thread.Sleep(20);
                Clicker.LeftClick(180, 705, delayNumber);
                Thread.Sleep(x + 20);
                MouseOperations.SetCursorPosition(temp.X, temp.Y);
                Thread.Sleep(x + 10);
                Clicker.RightClick(20);
            }

            if (keyCode == (int) Keys.NumPad5)
                NormalChat.ShortCutKey(Keys.N, delayNumber);

            if (keyCode == (int) Keys.N)
                NormalChat.ShortCutKey(Keys.N, delayNumber);

            if (keyCode == (int) Keys.G)
                NormalChat.ShortCutKey(Keys.G, delayNumber);

            if (keyCode == (int) Keys.M)
                NormalChat.ShortCutKey(Keys.M, delayNumber);

            if (keyCode == (int) Keys.H)
                NormalChat.ShortCutKey(Keys.H, delayNumber);

            if (keyCode == (int) Keys.B)
                NormalChat.ShortCutKey(Keys.B, delayNumber);

            if (keyCode == (int) Keys.I)
                NormalChat.ShortCutKey(Keys.I, delayNumber);

            if (keyCode == (int) Keys.S)
            {
                var pos = Cursor.Position;
                Clicker.LeftClick(pos.X, pos.Y, delayNumber);
                Clicker.LeftClick(586, 707, delayNumber);
                MouseOperations.SetCursorPosition(pos.X, pos.Y);
            }

            if (keyCode == (int)Keys.W)
            {
                var p1 = Cursor.Position;
                int dddd = 100;
                Clicker.LeftClick(p1.X, p1.Y, delayNumber + dddd);
                Clicker.LeftClick((p1.X - 63), (p1.Y - 33), delayNumber + dddd);
                Clicker.LeftClick((p1.X + 66), (p1.Y - 33), delayNumber + dddd);
                Clicker.LeftClick((p1.X), (p1.Y - 66), delayNumber + dddd);
            }

            if (keyCode == (int)Keys.E)
            {
                int dddd = 100;
                var p1 = Cursor.Position;
                Clicker.LeftClick(p1.X, p1.Y, delayNumber + dddd);
                Clicker.LeftClick((p1.X + 63), (p1.Y - 33), delayNumber + dddd);
                Clicker.LeftClick((p1.X + 128), (p1.Y), delayNumber + dddd);
                Clicker.LeftClick((p1.X + 66), (p1.Y + 33), delayNumber + dddd);
            }

        }
    }
}