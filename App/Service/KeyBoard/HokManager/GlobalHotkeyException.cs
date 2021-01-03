using System;

namespace App.Service.KeyBoard.HokManager
{
    public class GlobalHotKeyException : Exception
    {
        public GlobalHotKeyException(string message) : base(message) {}
        public GlobalHotKeyException(string message, Exception inner) : base(message, inner) {}
    }
}
