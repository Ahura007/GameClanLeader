using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace App.Service.Logger
{

    public static partial class HookManager
    {

       
        public static List<System.Drawing.Point> PositionClick = new List<System.Drawing.Point>();

        private delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        private static HookProc _sMouseDelegate;
        private static int _sMouseHookHandle;
        private static int _mOldX;
        private static int _mOldY;

        private static int MouseHookProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {

                MouseLlHookStruct mouseHookStruct = (MouseLlHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseLlHookStruct));

                MouseButtons button = MouseButtons.None;
                var mouseDelta = 0;
                var clickCount = 0;
                var mouseDown = false;
                var mouseUp = false;

                switch (wParam)
                {
                    case WM_LBUTTONDOWN:
                        mouseDown = true;
                        button = MouseButtons.Left;
                        clickCount = 1;
                        break;
                    //case WM_LBUTTONUP:
                    //    mouseUp = true;
                    //    button = MouseButtons.Left;
                    //    clickCount = 1;
                    //    break;
                    //case WM_LBUTTONDBLCLK:
                    //    button = MouseButtons.XButton1;
                    //    clickCount = 2;
                    //    break;
                    //case WM_RBUTTONDOWN:
                    //    mouseDown = true;
                    //    button = MouseButtons.Right;
                    //    clickCount = 1;
                    //    break;
                    //case WM_RBUTTONUP:
                    //    mouseUp = true;
                    //    button = MouseButtons.Right;
                    //    clickCount = 1;
                    //    break;
                    //case WM_RBUTTONDBLCLK:
                    //    button = MouseButtons.Right;
                    //    clickCount = 2;
                    //    break;
                    //case WM_MOUSEWHEEL:
                    //    mouseDelta = (short)((mouseHookStruct.MouseData >> 16) & 0xffff);
                    //    break;
                }


                var e = new MouseEventExtArgs(button, clickCount, mouseHookStruct.Point.X, mouseHookStruct.Point.Y, mouseDelta);

                if (e.Button == MouseButtons.Left)
                {
                    var point = new System.Drawing.Point();
                    point.X = mouseHookStruct.Point.X;
                    point.Y = mouseHookStruct.Point.Y;
                    PositionClick.Add(point);
                }





                if (SMouseUp != null && mouseUp)
                {
                    SMouseUp.Invoke(null, e);
                }


                if (SMouseDown != null && mouseDown)
                {
                    SMouseDown.Invoke(null, e);
                }


                if (SMouseClick != null && clickCount > 0)
                {
                    SMouseClick.Invoke(null, e);
                }


                if (SMouseClickExt != null && clickCount > 0)
                {
                    SMouseClickExt.Invoke(null, e);
                }


                if (SMouseDoubleClick != null && clickCount == 2)
                {
                    SMouseDoubleClick.Invoke(null, e);
                }

                if (SMouseWheel != null && mouseDelta != 0)
                {
                    SMouseWheel.Invoke(null, e);
                }

                if ((SMouseMove != null || SMouseMoveExt != null) && (_mOldX != mouseHookStruct.Point.X || _mOldY != mouseHookStruct.Point.Y))
                {
                    _mOldX = mouseHookStruct.Point.X;
                    _mOldY = mouseHookStruct.Point.Y;
                    SMouseMove?.Invoke(null, e);

                    SMouseMoveExt?.Invoke(null, e);
                }

                if (e.Handled)
                {
                    return -1;
                }
            }


            return CallNextHookEx(_sMouseHookHandle, nCode, wParam, lParam);
        }


        private static void EnsureSubscribedToGlobalMouseEvents()
        {
            if (_sMouseHookHandle == 0)
            {
                _sMouseDelegate = MouseHookProc;
                _sMouseHookHandle = SetWindowsHookEx(WH_MOUSE_LL, _sMouseDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
                if (_sMouseHookHandle == 0)
                {
                    int errorCode = Marshal.GetLastWin32Error();

                    throw new Win32Exception(errorCode);
                }
            }
        }

        private static void TryUnsubscribeFromGlobalMouseEvents()
        {
            if (SMouseClick == null && SMouseDown == null && SMouseMove == null && SMouseUp == null && SMouseClickExt == null && SMouseMoveExt == null && SMouseWheel == null)
            {
                ForceUnsunscribeFromGlobalMouseEvents();
            }
        }

        private static void ForceUnsunscribeFromGlobalMouseEvents()
        {
            if (_sMouseHookHandle != 0)
            {
                int result = UnhookWindowsHookEx(_sMouseHookHandle);
                _sMouseHookHandle = 0;
                _sMouseDelegate = null;
                if (result == 0)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }


        private static HookProc _sKeyboardDelegate;


        private static int _sKeyboardHookHandle;

        private static int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            bool handled = false;

            if (nCode >= 0)
            {
                KeyboardHookStruct myKeyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                if (SKeyDown != null && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                {
                    Keys keyData = (Keys)myKeyboardHookStruct.VirtualKeyCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    SKeyDown.Invoke(null, e);
                    handled = e.Handled;
                }


                if (SKeyPress != null && wParam == WM_KEYDOWN)
                {
                    bool isDownShift = ((GetKeyState(VK_SHIFT) & 0x80) == 0x80 ? true : false);
                    bool isDownCapslock = (GetKeyState(VK_CAPITAL) != 0 ? true : false);

                    byte[] keyState = new byte[256];
                    GetKeyboardState(keyState);
                    byte[] inBuffer = new byte[2];
                    if (ToAscii(myKeyboardHookStruct.VirtualKeyCode, myKeyboardHookStruct.ScanCode, keyState, inBuffer, myKeyboardHookStruct.Flags) == 1)
                    {
                        char key = (char)inBuffer[0];
                        if ((isDownCapslock ^ isDownShift) && Char.IsLetter(key)) key = Char.ToUpper(key);
                        KeyPressEventArgs e = new KeyPressEventArgs(key);
                        SKeyPress.Invoke(null, e);
                        handled = handled || e.Handled;
                    }
                }


                if (SKeyUp != null && (wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
                {
                    Keys keyData = (Keys)myKeyboardHookStruct.VirtualKeyCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    SKeyUp.Invoke(null, e);
                    handled = handled || e.Handled;
                }

            }

            if (handled)
                return -1;

            return CallNextHookEx(_sKeyboardHookHandle, nCode, wParam, lParam);
        }

        private static void EnsureSubscribedToGlobalKeyboardEvents()
        {
            if (_sKeyboardHookHandle == 0)
            {
                _sKeyboardDelegate = KeyboardHookProc;
                _sKeyboardHookHandle = SetWindowsHookEx(WH_KEYBOARD_LL, _sKeyboardDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
                if (_sKeyboardHookHandle == 0)
                {
                    int errorCode = Marshal.GetLastWin32Error();

                    throw new Win32Exception(errorCode);
                }
            }
        }

        private static void TryUnsubscribeFromGlobalKeyboardEvents()
        {
            if (SKeyDown == null && SKeyUp == null && SKeyPress == null)
            {
                ForceUnsunscribeFromGlobalKeyboardEvents();
            }
        }

        private static void ForceUnsunscribeFromGlobalKeyboardEvents()
        {
            if (_sKeyboardHookHandle != 0)
            {
                int result = UnhookWindowsHookEx(_sKeyboardHookHandle);
                _sKeyboardHookHandle = 0;
                _sKeyboardDelegate = null;
                if (result == 0)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }



    }
}
