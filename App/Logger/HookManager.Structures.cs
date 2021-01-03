using System.Runtime.InteropServices;

namespace App.Service.Logger
{
    public static partial class HookManager
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct Point
        {
            public readonly int X;

            public readonly int Y;
        }


        [StructLayout(LayoutKind.Sequential)]
        private struct MouseLlHookStruct
        {
            public readonly Point Point;

            public readonly int MouseData;

            public readonly int Flags;

            public readonly int Time;

            public readonly int ExtraInfo;
        }


        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;

            public readonly int ScanCode;

            public readonly int Flags;

            public readonly int Time;

            public readonly int ExtraInfo;
        }
    }
}