using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using App.Service.Logger;

namespace App.Forms
{
    public partial class FrmFormStatic : Form
    {

        public List<Point> PositionClick;

        public FrmFormStatic()
        {
            InitializeComponent();
            HookManager.PositionClick = new List<Point>();
            HookManager.MouseClick += HookManager_MouseClick;
            PositionClick = new List<Point>();
            this.DialogResult = DialogResult.No;
        
            RegisterHotKey(Handle, (int)Keys.F11, 0, (int)Keys.F11);
            var screen = Screen.AllScreens.Length;
            this.Location = Screen.AllScreens[screen - 1].WorkingArea.Location;
        }



        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message xMessage)
        {
            //if (xMessage.Msg == 0x0312 && xMessage.WParam.ToInt32() == (int)Keys.F10)
            //{
            //    if (checkBoxOnMouseClick.Checked)
            //        checkBoxOnMouseClick.Checked = false;
            //    else
            //        checkBoxOnMouseClick.Checked = true;
            //}

            if (xMessage.Msg == 0x0312 && xMessage.WParam.ToInt32() == (int)Keys.F11)
            {
                //if (checkBoxOnMouseClick.Checked)
                //{
                //    MessageBox.Show("Uncheck mouse and this pattern maybe not work correctly");
                //    return;
                //}
                PositionClick = HookManager.PositionClick;
                this.DialogResult = DialogResult.OK;
            }
            base.WndProc(ref xMessage);
        }



        //##################################################################
        #region Check boxes to set or remove particular event handlers.

        private void checkBoxOnMouseClick_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseClick.Checked)
            {
                HookManager.PositionClick = new List<Point>();
                HookManager.MouseClick += HookManager_MouseClick;
            }
            else
            {
                PositionClick = HookManager.PositionClick;
                HookManager.MouseClick -= HookManager_MouseClick;
            }
        }

        private void checkBoxOnMouseMove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseMove.Checked)
            {
                HookManager.MouseMove += HookManager_MouseMove;
            }
            else
            {
                HookManager.MouseMove -= HookManager_MouseMove;
            }
        }

        private void checkBoxOnMouseUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseUp.Checked)
            {
                HookManager.MouseUp += HookManager_MouseUp;
            }
            else
            {
                HookManager.MouseUp -= HookManager_MouseUp;
            }
        }

        private void checkBoxOnMouseDown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseDown.Checked)
            {
                HookManager.MouseDown += HookManager_MouseDown;
            }
            else
            {
                HookManager.MouseDown -= HookManager_MouseDown;
            }
        }

        private void checkBoxMouseDoubleClick_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMouseDoubleClick.Checked)
            {
                HookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
            }
            else
            {
                HookManager.MouseDoubleClick -= HookManager_MouseDoubleClick;
            }
        }

        private void checkBoxMouseWheel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMouseWheel.Checked)
            {
                HookManager.MouseWheel += HookManager_MouseWheel;
            }
            else
            {
                HookManager.MouseWheel -= HookManager_MouseWheel;
            }
        }

        private void checkBoxKeyDown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeyDown.Checked)
            {
                HookManager.KeyDown += HookManager_KeyDown;
            }
            else
            {
                HookManager.KeyDown -= HookManager_KeyDown;
            }
        }

        private void checkBoxKeyUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeyUp.Checked)
            {
                HookManager.KeyUp += HookManager_KeyUp;
            }
            else
            {
                HookManager.KeyUp -= HookManager_KeyUp;
            }
        }

        private void checkBoxKeyPress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeyPress.Checked)
            {
                HookManager.KeyPress += HookManager_KeyPress;
            }
            else
            {
                HookManager.KeyPress -= HookManager_KeyPress;
            }
        }

        #endregion

        //##################################################################
        #region Event handlers of particular events. They will be activated when an appropriate checkbox is checked.

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxLog.AppendText(string.Format("KeyDown - {0}\n", e.KeyCode));
            textBoxLog.ScrollToCaret();
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxLog.AppendText(string.Format("KeyUp - {0}\n", e.KeyCode));
            textBoxLog.ScrollToCaret();
        }


        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxLog.AppendText(string.Format("KeyPress - {0}\n", e.KeyChar));
            textBoxLog.ScrollToCaret();
        }


        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePosition.Text = string.Format("x={0:0000}; y={1:0000}", e.X, e.Y);
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLog.AppendText(string.Format("MouseClick - {0}\n", e.Button + "    Mouse Click Location  X = " + e.X + "  Y = " + e.Y));

            textBoxLog.ScrollToCaret();
        }


        private void HookManager_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxLog.AppendText(string.Format("MouseUp - {0}\n", e.Button));
            textBoxLog.ScrollToCaret();
        }


        private void HookManager_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxLog.AppendText(string.Format("MouseDown - {0}\n", e.Button));
            textBoxLog.ScrollToCaret();
        }


        private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxLog.AppendText(string.Format("MouseDoubleClick - {0}\n", e.Button));
            textBoxLog.ScrollToCaret();
        }


        private void HookManager_MouseWheel(object sender, MouseEventArgs e)
        {
            labelWheel.Text = string.Format("Wheel={0:000}", e.Delta);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxOnMouseClick.Checked)
            {
                MessageBox.Show("Uncheck mouse and this pattern maybe not work correctly");
                return;
            }
            PositionClick = HookManager.PositionClick;
            this.DialogResult = DialogResult.OK;
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}