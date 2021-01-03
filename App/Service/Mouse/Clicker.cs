using System.Threading;

namespace App.Service.Mouse
{
    static class Clicker
    {

        public static void LeftClick(int x, int y, int delay)
        {
            MouseOperations.SetCursorPosition(x, y);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
            Thread.Sleep(delay);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
            Thread.Sleep(delay);
        }

        public static void LeftClick(int delay)
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
            Thread.Sleep(delay);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
            Thread.Sleep(delay);
        }


        public static void MiddleClick(int x, int y, int delay)
        {
            MouseOperations.SetCursorPosition(x, y);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
            Thread.Sleep(delay);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.MiddleUp);
            Thread.Sleep(delay);
        }


        public static void RightClick(int armyControllDelay)
        {
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightDown);
            Thread.Sleep(10);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.RightUp);
            Thread.Sleep(10);
        }
    }
}
