﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace App.Service.Logger
{
    public class GlobalEventProvider : Component
    {
        protected override bool CanRaiseEvents => true;

        private event MouseEventHandler MMouseMove;


        public event MouseEventHandler MouseMove
        {
            add
            {
                if (MMouseMove == null) HookManager.MouseMove += HookManager_MouseMove;
                MMouseMove += value;
            }

            remove
            {
                MMouseMove -= value;
                if (MMouseMove == null) HookManager.MouseMove -= HookManager_MouseMove;
            }
        }

        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            MMouseMove?.Invoke(this, e);
        }

        private event MouseEventHandler MMouseClick;

        public event MouseEventHandler MouseClick
        {
            add
            {
                if (MMouseClick == null) HookManager.MouseClick += HookManager_MouseClick;
                MMouseClick += value;
            }

            remove
            {
                MMouseClick -= value;
                if (MMouseClick == null) HookManager.MouseClick -= HookManager_MouseClick;
            }
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            MMouseClick?.Invoke(this, e);
        }

        private event MouseEventHandler MMouseDown;

        public event MouseEventHandler MouseDown
        {
            add
            {
                if (MMouseDown == null) HookManager.MouseDown += HookManager_MouseDown;
                MMouseDown += value;
            }

            remove
            {
                MMouseDown -= value;
                if (MMouseDown == null) HookManager.MouseDown -= HookManager_MouseDown;
            }
        }

        private void HookManager_MouseDown(object sender, MouseEventArgs e)
        {
            MMouseDown?.Invoke(this, e);
        }


        private event MouseEventHandler MMouseUp;


        public event MouseEventHandler MouseUp
        {
            add
            {
                if (MMouseUp == null) HookManager.MouseUp += HookManager_MouseUp;
                MMouseUp += value;
            }

            remove
            {
                MMouseUp -= value;
                if (MMouseUp == null) HookManager.MouseUp -= HookManager_MouseUp;
            }
        }

        private void HookManager_MouseUp(object sender, MouseEventArgs e)
        {
            MMouseUp?.Invoke(this, e);
        }

        private event MouseEventHandler MMouseDoubleClick;


        public event MouseEventHandler MouseDoubleClick
        {
            add
            {
                if (MMouseDoubleClick == null) HookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
                MMouseDoubleClick += value;
            }

            remove
            {
                MMouseDoubleClick -= value;
                if (MMouseDoubleClick == null) HookManager.MouseDoubleClick -= HookManager_MouseDoubleClick;
            }
        }

        private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MMouseDoubleClick?.Invoke(this, e);
        }


        private event EventHandler<MouseEventExtArgs> MMouseMoveExt;


        public event EventHandler<MouseEventExtArgs> MouseMoveExt
        {
            add
            {
                if (MMouseMoveExt == null) HookManager.MouseMoveExt += HookManager_MouseMoveExt;
                MMouseMoveExt += value;
            }

            remove
            {
                MMouseMoveExt -= value;
                if (MMouseMoveExt == null) HookManager.MouseMoveExt -= HookManager_MouseMoveExt;
            }
        }

        private void HookManager_MouseMoveExt(object sender, MouseEventExtArgs e)
        {
            MMouseMoveExt?.Invoke(this, e);
        }

        private event EventHandler<MouseEventExtArgs> MMouseClickExt;


        public event EventHandler<MouseEventExtArgs> MouseClickExt
        {
            add
            {
                if (MMouseClickExt == null) HookManager.MouseClickExt += HookManager_MouseClickExt;
                MMouseClickExt += value;
            }

            remove
            {
                MMouseClickExt -= value;
                if (MMouseClickExt == null) HookManager.MouseClickExt -= HookManager_MouseClickExt;
            }
        }

        private void HookManager_MouseClickExt(object sender, MouseEventExtArgs e)
        {
            MMouseClickExt?.Invoke(this, e);
        }

        private event KeyPressEventHandler MKeyPress;

        public event KeyPressEventHandler KeyPress
        {
            add
            {
                if (MKeyPress == null) HookManager.KeyPress += HookManager_KeyPress;
                MKeyPress += value;
            }
            remove
            {
                MKeyPress -= value;
                if (MKeyPress == null) HookManager.KeyPress -= HookManager_KeyPress;
            }
        }

        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            MKeyPress?.Invoke(this, e);
        }

        private event KeyEventHandler MKeyUp;


        public event KeyEventHandler KeyUp
        {
            add
            {
                if (MKeyUp == null) HookManager.KeyUp += HookManager_KeyUp;
                MKeyUp += value;
            }
            remove
            {
                MKeyUp -= value;
                if (MKeyUp == null) HookManager.KeyUp -= HookManager_KeyUp;
            }
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            MKeyUp?.Invoke(this, e);
        }

        private event KeyEventHandler MKeyDown;


        public event KeyEventHandler KeyDown
        {
            add
            {
                if (MKeyDown == null) HookManager.KeyDown += HookManager_KeyDown;
                MKeyDown += value;
            }
            remove
            {
                MKeyDown -= value;
                if (MKeyDown == null) HookManager.KeyDown -= HookManager_KeyDown;
            }
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            MKeyDown?.Invoke(this, e);
        }
    }
}