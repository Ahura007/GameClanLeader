
 

namespace App.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActive = new System.Windows.Forms.Button();
            this.btnKn = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArmyCompressDelay = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMouseSpeed = new System.Windows.Forms.TextBox();
            this.txtDelayS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlagDelay = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ramAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatternToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActive
            // 
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnActive.Location = new System.Drawing.Point(7, 33);
            this.btnActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(221, 63);
            this.btnActive.TabIndex = 42;
            this.btnActive.Text = "Active ON (Insert)";
            this.btnActive.UseVisualStyleBackColor = true;
            // 
            // btnKn
            // 
            this.btnKn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnKn.Location = new System.Drawing.Point(14, 24);
            this.btnKn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKn.Name = "btnKn";
            this.btnKn.Size = new System.Drawing.Size(181, 27);
            this.btnKn.TabIndex = 44;
            this.btnKn.Text = "PikeSin";
            this.btnKn.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(27, 56);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 29);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "Enable";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnKn);
            this.groupBox5.Location = new System.Drawing.Point(12, 356);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 58);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ControlMode Or Pike Sin";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Location = new System.Drawing.Point(12, 292);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(216, 58);
            this.groupBox7.TabIndex = 67;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Save Setting";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(118, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 27);
            this.button2.TabIndex = 45;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(14, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 44;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArmyCompressDelay
            // 
            this.txtArmyCompressDelay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArmyCompressDelay.Location = new System.Drawing.Point(156, 23);
            this.txtArmyCompressDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArmyCompressDelay.Name = "txtArmyCompressDelay";
            this.txtArmyCompressDelay.Size = new System.Drawing.Size(49, 26);
            this.txtArmyCompressDelay.TabIndex = 52;
            this.txtArmyCompressDelay.Text = "20";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDirection);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMouseSpeed);
            this.groupBox3.Controls.Add(this.txtDelayS);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFlagDelay);
            this.groupBox3.Controls.Add(this.txtArmyCompressDelay);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 180);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Direction Delay";
            // 
            // txtDirection
            // 
            this.txtDirection.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirection.Location = new System.Drawing.Point(156, 140);
            this.txtDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(49, 26);
            this.txtDirection.TabIndex = 60;
            this.txtDirection.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Mouse Speed";
            // 
            // txtMouseSpeed
            // 
            this.txtMouseSpeed.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMouseSpeed.Location = new System.Drawing.Point(156, 110);
            this.txtMouseSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMouseSpeed.Name = "txtMouseSpeed";
            this.txtMouseSpeed.Size = new System.Drawing.Size(49, 26);
            this.txtMouseSpeed.TabIndex = 58;
            this.txtMouseSpeed.Text = "20";
            // 
            // txtDelayS
            // 
            this.txtDelayS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelayS.Location = new System.Drawing.Point(156, 81);
            this.txtDelayS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDelayS.Name = "txtDelayS";
            this.txtDelayS.Size = new System.Drawing.Size(49, 26);
            this.txtDelayS.TabIndex = 57;
            this.txtDelayS.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Delay S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Flag Delay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Army Compress Delay";
            // 
            // txtFlagDelay
            // 
            this.txtFlagDelay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlagDelay.Location = new System.Drawing.Point(156, 52);
            this.txtFlagDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlagDelay.Name = "txtFlagDelay";
            this.txtFlagDelay.Size = new System.Drawing.Size(49, 26);
            this.txtFlagDelay.TabIndex = 53;
            this.txtFlagDelay.Text = "20";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(131, 56);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(41, 26);
            this.textBox3.TabIndex = 55;
            this.textBox3.Text = "2";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(27, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(28, 22);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ramAddressToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(240, 24);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ramAddressToolStripMenuItem
            // 
            this.ramAddressToolStripMenuItem.Name = "ramAddressToolStripMenuItem";
            this.ramAddressToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePatternToolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // deletePatternToolStripMenuItem1
            // 
            this.deletePatternToolStripMenuItem1.Name = "deletePatternToolStripMenuItem1";
            this.deletePatternToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.deletePatternToolStripMenuItem1.Text = "Delete Pattern";
            this.deletePatternToolStripMenuItem1.Click += new System.EventHandler(this.deletePatternToolStripMenuItem1_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRulesToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // setRulesToolStripMenuItem
            // 
            this.setRulesToolStripMenuItem.Name = "setRulesToolStripMenuItem";
            this.setRulesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.setRulesToolStripMenuItem.Text = "SetRules";
            this.setRulesToolStripMenuItem.Click += new System.EventHandler(this.setRulesToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(240, 422);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "???";
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnKn;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArmyCompressDelay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ramAddressToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFlagDelay;
        private System.Windows.Forms.TextBox txtDelayS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMouseSpeed;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatternToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRulesToolStripMenuItem;
    }
}

