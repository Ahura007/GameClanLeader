using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace App.Service.KeyBoard
{
    public static class ShortcutManager
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public static void CtrlWith(Keys key, int delay)
        {
            var keyEventKeydown = 0x0000;
            var keyEventKeyup = 0x0002;  
            keybd_event((byte)Keys.ControlKey, 0, keyEventKeydown, 0);
            Thread.Sleep(delay);
            keybd_event((byte)key, 0, keyEventKeydown, 0);
            keybd_event((byte)key, 0, keyEventKeyup, 0);
            Thread.Sleep(delay);
            keybd_event((byte)Keys.ControlKey, 0, keyEventKeyup, 0);
        }
 
    }



    public static class MoveDirection
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public static void Direction(Keys key, int delay)
        {
            var keyEventKeydown = 0x0000;
            var keyEventKeyup = 0x0002;

            keybd_event((byte)key, 0, keyEventKeydown, 0);
            Thread.Sleep(delay);
            keybd_event((byte)key, 0, keyEventKeyup, 0);


        }
    }
}
