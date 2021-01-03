namespace App.Forms
{
    partial class FrmFormStatic {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelWheel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxKeyUp = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyPress = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyDown = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseWheel = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseDoubleClick = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseUp = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseDown = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseClick = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseMove = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMousePosition.Location = new System.Drawing.Point(315, 362);
            this.labelMousePosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(162, 16);
            this.labelMousePosition.TabIndex = 2;
            this.labelMousePosition.Text = "x={0:####}; y={1:####}";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 175);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(562, 407);
            this.textBoxLog.TabIndex = 5;
            this.textBoxLog.WordWrap = false;
            // 
            // labelWheel
            // 
            this.labelWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWheel.AutoSize = true;
            this.labelWheel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWheel.Location = new System.Drawing.Point(419, 298);
            this.labelWheel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWheel.Name = "labelWheel";
            this.labelWheel.Size = new System.Drawing.Size(106, 16);
            this.labelWheel.TabIndex = 6;
            this.labelWheel.Text = "Wheel={0:####}";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBoxKeyUp);
            this.groupBox2.Controls.Add(this.checkBoxKeyPress);
            this.groupBox2.Controls.Add(this.checkBoxKeyDown);
            this.groupBox2.Controls.Add(this.checkBoxMouseWheel);
            this.groupBox2.Controls.Add(this.checkBoxMouseDoubleClick);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseUp);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseDown);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseClick);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseMove);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(562, 175);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Other feature available for admin ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Finish Capture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxKeyUp
            // 
            this.checkBoxKeyUp.AutoSize = true;
            this.checkBoxKeyUp.Enabled = false;
            this.checkBoxKeyUp.Location = new System.Drawing.Point(295, 55);
            this.checkBoxKeyUp.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxKeyUp.Name = "checkBoxKeyUp";
            this.checkBoxKeyUp.Size = new System.Drawing.Size(66, 22);
            this.checkBoxKeyUp.TabIndex = 8;
            this.checkBoxKeyUp.Text = "KeyUp";
            this.checkBoxKeyUp.UseVisualStyleBackColor = true;
            this.checkBoxKeyUp.CheckedChanged += new System.EventHandler(this.checkBoxKeyUp_CheckedChanged);
            // 
            // checkBoxKeyPress
            // 
            this.checkBoxKeyPress.AutoSize = true;
            this.checkBoxKeyPress.Enabled = false;
            this.checkBoxKeyPress.Location = new System.Drawing.Point(152, 86);
            this.checkBoxKeyPress.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxKeyPress.Name = "checkBoxKeyPress";
            this.checkBoxKeyPress.Size = new System.Drawing.Size(81, 22);
            this.checkBoxKeyPress.TabIndex = 7;
            this.checkBoxKeyPress.Text = "KeyPress";
            this.checkBoxKeyPress.UseVisualStyleBackColor = true;
            this.checkBoxKeyPress.CheckedChanged += new System.EventHandler(this.checkBoxKeyPress_CheckedChanged);
            // 
            // checkBoxKeyDown
            // 
            this.checkBoxKeyDown.AutoSize = true;
            this.checkBoxKeyDown.Enabled = false;
            this.checkBoxKeyDown.Location = new System.Drawing.Point(295, 26);
            this.checkBoxKeyDown.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxKeyDown.Name = "checkBoxKeyDown";
            this.checkBoxKeyDown.Size = new System.Drawing.Size(82, 22);
            this.checkBoxKeyDown.TabIndex = 6;
            this.checkBoxKeyDown.Text = "KeyDown";
            this.checkBoxKeyDown.UseVisualStyleBackColor = true;
            this.checkBoxKeyDown.CheckedChanged += new System.EventHandler(this.checkBoxKeyDown_CheckedChanged);
            // 
            // checkBoxMouseWheel
            // 
            this.checkBoxMouseWheel.AutoSize = true;
            this.checkBoxMouseWheel.Enabled = false;
            this.checkBoxMouseWheel.Location = new System.Drawing.Point(152, 56);
            this.checkBoxMouseWheel.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMouseWheel.Name = "checkBoxMouseWheel";
            this.checkBoxMouseWheel.Size = new System.Drawing.Size(103, 22);
            this.checkBoxMouseWheel.TabIndex = 5;
            this.checkBoxMouseWheel.Text = "MouseWheel";
            this.checkBoxMouseWheel.UseVisualStyleBackColor = true;
            this.checkBoxMouseWheel.CheckedChanged += new System.EventHandler(this.checkBoxMouseWheel_CheckedChanged);
            // 
            // checkBoxMouseDoubleClick
            // 
            this.checkBoxMouseDoubleClick.AutoSize = true;
            this.checkBoxMouseDoubleClick.Enabled = false;
            this.checkBoxMouseDoubleClick.Location = new System.Drawing.Point(152, 26);
            this.checkBoxMouseDoubleClick.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMouseDoubleClick.Name = "checkBoxMouseDoubleClick";
            this.checkBoxMouseDoubleClick.Size = new System.Drawing.Size(137, 22);
            this.checkBoxMouseDoubleClick.TabIndex = 4;
            this.checkBoxMouseDoubleClick.Text = "MouseDoubleClick";
            this.checkBoxMouseDoubleClick.UseVisualStyleBackColor = true;
            this.checkBoxMouseDoubleClick.CheckedChanged += new System.EventHandler(this.checkBoxMouseDoubleClick_CheckedChanged);
            // 
            // checkBoxOnMouseUp
            // 
            this.checkBoxOnMouseUp.AutoSize = true;
            this.checkBoxOnMouseUp.Enabled = false;
            this.checkBoxOnMouseUp.Location = new System.Drawing.Point(16, 86);
            this.checkBoxOnMouseUp.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOnMouseUp.Name = "checkBoxOnMouseUp";
            this.checkBoxOnMouseUp.Size = new System.Drawing.Size(82, 22);
            this.checkBoxOnMouseUp.TabIndex = 3;
            this.checkBoxOnMouseUp.Text = "MouseUp";
            this.checkBoxOnMouseUp.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseUp.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseUp_CheckedChanged);
            // 
            // checkBoxOnMouseDown
            // 
            this.checkBoxOnMouseDown.AutoSize = true;
            this.checkBoxOnMouseDown.Enabled = false;
            this.checkBoxOnMouseDown.Location = new System.Drawing.Point(16, 56);
            this.checkBoxOnMouseDown.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOnMouseDown.Name = "checkBoxOnMouseDown";
            this.checkBoxOnMouseDown.Size = new System.Drawing.Size(98, 22);
            this.checkBoxOnMouseDown.TabIndex = 2;
            this.checkBoxOnMouseDown.Text = "MouseDown";
            this.checkBoxOnMouseDown.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseDown.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseDown_CheckedChanged);
            // 
            // checkBoxOnMouseClick
            // 
            this.checkBoxOnMouseClick.AutoSize = true;
            this.checkBoxOnMouseClick.Checked = true;
            this.checkBoxOnMouseClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnMouseClick.Location = new System.Drawing.Point(16, 26);
            this.checkBoxOnMouseClick.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOnMouseClick.Name = "checkBoxOnMouseClick";
            this.checkBoxOnMouseClick.Size = new System.Drawing.Size(95, 22);
            this.checkBoxOnMouseClick.TabIndex = 1;
            this.checkBoxOnMouseClick.Text = "MouseClick";
            this.checkBoxOnMouseClick.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseClick.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseClick_CheckedChanged);
            // 
            // checkBoxOnMouseMove
            // 
            this.checkBoxOnMouseMove.AutoSize = true;
            this.checkBoxOnMouseMove.Enabled = false;
            this.checkBoxOnMouseMove.Location = new System.Drawing.Point(295, 85);
            this.checkBoxOnMouseMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOnMouseMove.Name = "checkBoxOnMouseMove";
            this.checkBoxOnMouseMove.Size = new System.Drawing.Size(96, 22);
            this.checkBoxOnMouseMove.TabIndex = 0;
            this.checkBoxOnMouseMove.Text = "MouseMove";
            this.checkBoxOnMouseMove.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseMove.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseMove_CheckedChanged);
            // 
            // FrmRecordShieldPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 582);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelWheel);
            this.Controls.Add(this.labelMousePosition);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFormStatic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseOpration";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelWheel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxKeyUp;
        private System.Windows.Forms.CheckBox checkBoxKeyPress;
        private System.Windows.Forms.CheckBox checkBoxKeyDown;
        private System.Windows.Forms.CheckBox checkBoxMouseWheel;
        private System.Windows.Forms.CheckBox checkBoxMouseDoubleClick;
        private System.Windows.Forms.CheckBox checkBoxOnMouseUp;
        private System.Windows.Forms.CheckBox checkBoxOnMouseDown;
        private System.Windows.Forms.CheckBox checkBoxOnMouseClick;
        private System.Windows.Forms.CheckBox checkBoxOnMouseMove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}