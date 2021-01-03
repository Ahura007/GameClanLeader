using System;
using System.Windows.Forms;
 
namespace App.Service.KeyBoard.HokManager
{
    public class HotKeyInfo
    {
        public Keys Key { get; private set; }
        public Modifiers Modifiers { get; private set; }

        private HotKeyInfo(IntPtr lParam)
        {
            var lpInt = (int)lParam;
            Key = (Keys)((lpInt >> 16) & 0xFFFF);
            Modifiers = (Modifiers)(lpInt & 0xFFFF);
        }

        public static HotKeyInfo GetFromMessage(Message m)
        {
            return !IsHotkeyMessage(m) ? null : new HotKeyInfo(m.LParam);
        }

        public static bool IsHotkeyMessage(Message m)
        {
            return m.Msg == Win32.WM_HOTKEY_MSG_ID;
        }
    }
}
