using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using App.Service.Mouse;
using App.Service.ShieldMaker;
using App.SettingShc;

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


        public static void SendKey(int keyCode, Setting setting)
        {
            if (keyCode == (int)Keys.NumPad1)
            {
                for (var i = 1; i <= 2; i++)
                {
                    SendKeys.SendWait(i.ToString());
                    SendKeys.Flush();
                    Clicker.LeftClick(Cursor.Position.X, Cursor.Position.Y, setting.CompressDelay);
                    SendKeys.Flush();
                }
            }

            if (keyCode == (int)Keys.Add)
            {
                Clicker.RightClick(30);
                var temp = Cursor.Position;
                int x = 50;
                SendKeys.Send("2");
                Thread.Sleep(20);
                Clicker.LeftClick(180, 705, setting.DelayS);
                Thread.Sleep(x + 30);
                SendKeys.Send("1");
                Thread.Sleep(20);
                Clicker.LeftClick(180, 705, setting.DelayS);
                Thread.Sleep(x + 20);
                MouseOperations.SetCursorPosition(temp.X, temp.Y);
                Thread.Sleep(x + 10);
                Clicker.RightClick(20);
            }

            if (keyCode == (int)Keys.NumPad5)
                ShortcutManager.CtrlWith(Keys.N, setting.DelayS);

            if (keyCode == (int)Keys.N)
                ShortcutManager.CtrlWith(Keys.N, setting.DelayS);

            if (keyCode == (int)Keys.G)
                ShortcutManager.CtrlWith(Keys.G, setting.DelayS);

            if (keyCode == (int)Keys.M)
                ShortcutManager.CtrlWith(Keys.M, setting.DelayS);

            if (keyCode == (int)Keys.H)
                ShortcutManager.CtrlWith(Keys.H, setting.DelayS);

            if (keyCode == (int)Keys.B)
                ShortcutManager.CtrlWith(Keys.B, setting.DelayS);

            if (keyCode == (int)Keys.I)
                ShortcutManager.CtrlWith(Keys.I, setting.DelayS);

            if (keyCode == (int)Keys.E)
            {
                var pos = Cursor.Position;
                Clicker.LeftClick(pos.X, pos.Y, setting.DelayS);
                Clicker.LeftClick(586, 707, setting.DelayS);
                MouseOperations.SetCursorPosition(pos.X, pos.Y);
            }

            if (keyCode == (int)Keys.S)
                MoveDirection.Direction(Keys.Down, setting.Direction);

            if (keyCode == (int)Keys.W)
                MoveDirection.Direction(Keys.Up, setting.Direction);

            if (keyCode == (int)Keys.A)
                MoveDirection.Direction(Keys.Left, setting.Direction);

            if (keyCode == (int)Keys.D)
                MoveDirection.Direction(Keys.Right, setting.Direction);

            if (keyCode == (int)Keys.Q)
            {
                var corner = new List<Point>()
                {
                    new Point(159, 732),
                    new Point(192, 730),
                    new Point(162, 760),
                    new Point(192, 759),
                };
                var p = Pip.PointInPolygan(corner).FirstOrDefault();

                var current = new Point(Cursor.Position.X, Cursor.Position.Y);
               
                Clicker.LeftClick(10);
                MouseMoves.LinearSmoothMove(p, setting.MouseSpeed);
                Clicker.LeftClick(10);
                MouseMoves.LinearSmoothMove(current, setting.MouseSpeed);
            }




            //if (keyCode == (int)Keys.W)
            //{
            //    var p1 = Cursor.Position;
            //    int dddd = 100;
            //    Clicker.LeftClick(p1.X, p1.Y, delayNumber + dddd);
            //    Clicker.LeftClick((p1.X - 63), (p1.Y - 33), delayNumber + dddd);
            //    Clicker.LeftClick((p1.X + 66), (p1.Y - 33), delayNumber + dddd);
            //    Clicker.LeftClick((p1.X), (p1.Y - 66), delayNumber + dddd);
            //}
        }
    }
}