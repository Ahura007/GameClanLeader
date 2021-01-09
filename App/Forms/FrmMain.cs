using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WindowsInput;
using App.Service;
using App.Service.KeyBoard;
using App.Service.KeyBoard.HokManager;
using App.Service.Logger;
using App.Service.Mouse;
using App.Service.ShieldMaker;
using App.Service.Voice;
using App.SettingShc;
using Newtonsoft.Json;



namespace App.Forms
{
    public partial class FrmMain : Form
    {
        public ControlMode ControlMode { get; set; } = ControlMode.PikeSin;
        public Setting Setting { get; set; }
        public List<Point> Corner { get; set; }

        private GlobalHotKey Rules { get; set; }
        private GlobalHotKey RemoveGroup { get; set; }
        private GlobalHotKey AddGroup { get; set; }
        private GlobalHotKey StartRecordPattern { get; set; }
        private GlobalHotKey EndRecordPattern { get; set; }
        public string PatternShieldAddress => Environment.CurrentDirectory + "\\Pattern\\";

        public FrmFormStatic FrmRecordShieldPattern = null;


        public FrmMain()
        {
            InitializeComponent();
            this.Text = Program.RemainDay.ToString();
            SettingService.Initialize();

            Setting = SettingService.GetSetting();
            UpdateUi(Setting);



            KeyPreview = true;

            RegisterKey();
            RegisterShortcutKey();

            CalcMove.Kn = new List<int>() { };
            CalcMove.PikeSin = new List<int>() { 0, 3, 4, 5, 6, 7, 8, 9 };
        }
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message xMessage)
        {
            var keyCode = xMessage.WParam.ToInt32();
            var hotKeyInfo = HotKeyInfo.GetFromMessage(xMessage);

            if (hotKeyInfo != null)
            {
                if (hotKeyInfo.Modifiers == Modifiers.Alt && hotKeyInfo.Key == Keys.NumPad9)
                {
                    int? maxPikeSin = CalcMove.PikeSin.OrderBy(n => n).Cast<int?>()
                        .FirstOrDefault(n => n >= 9);
                    if (maxPikeSin.HasValue)
                        CalcMove.PikeSin.Remove(maxPikeSin.Value);
                }

                if (keyCode == AddGroup.Id)
                {
                    int? maxPikeSin = CalcMove.PikeSin.OrderBy(n => n).Cast<int?>()
                        .FirstOrDefault(n => n >= 9);
                    if (!maxPikeSin.HasValue)
                        CalcMove.PikeSin.Add(9);
                }

                if (keyCode == Rules.Id)
                {
                    var sim = new InputSimulator();
                    sim.Keyboard.Sleep(1000)
                        .TextEntry(Setting.Rules)
                        .Sleep(1000);
                }

                if (keyCode == StartRecordPattern.Id)
                {
                    Voice.PlaySound("//Voice//Start.wav");
                    FrmRecordShieldPattern = new FrmFormStatic();
                    FrmRecordShieldPattern.ShowDialog();
                }

                if (keyCode == EndRecordPattern.Id)
                {
                    var allPositionClick = HookManager.PositionClick;
                    var stringData = JsonConvert.SerializeObject(allPositionClick);
                    var newPatternName = Guid.NewGuid();
                    var newPattern = PatternShieldAddress + newPatternName.ToString() + ".txt";
                    if (!File.Exists(newPattern))
                    {
                        var temp = File.Create(newPattern);
                        temp.Close();
                    }
                    File.AppendAllText(newPattern, stringData);
                    FrmRecordShieldPattern.DialogResult = DialogResult.OK;
                    Voice.PlaySound("//Voice//Ending.wav");
                }
            }

            if (keyCode == (int)Keys.S)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.W)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.A)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.D)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.Q)
                Key.SendKey(keyCode, Setting);




            if (keyCode == (int)Keys.F6)
            {
                var pattern = Directory.GetFiles(PatternShieldAddress).ToList();
                if (pattern.Count == 0)
                    return;
                var r = new Random();
                var choosePatternNumber = r.Next(0, pattern.Count - 1);
                var choosePattern = pattern[choosePatternNumber];
                var readPattern = File.ReadAllText(choosePattern);
                var containPattern = JsonConvert.DeserializeObject<List<Point>>(readPattern);
                var c = Cursor.Position;
                foreach (Point point in containPattern)
                {
                    Clicker.LeftClick(20);
                    MouseMoves.LinearSmoothMove(point, Setting.MouseSpeed);
                    Clicker.LeftClick(20);
                }
            }

            if (keyCode == (int)Keys.Decimal)
            {
                foreach (var i in CalcMove.PikeSin.Distinct())
                {
                    Key.MoveOne(i, Setting.CompressDelay);
                }
            }

            if (keyCode == (int)Keys.NumPad2)
            {
                if (ControlMode == ControlMode.Kn)
                {
                    foreach (var i in CalcMove.Kn.Distinct())
                    {
                        if (i == 1 || i == 2)
                            continue;
                        Key.MoveOne(i, Setting.CompressDelay);
                    }
                }
            }

            if (keyCode == (int)Keys.Divide)
            {
                if (ControlMode == ControlMode.PikeSin)
                {
                    ControlMode = ControlMode.Kn;
                    btnKn.Text = "KN";
                    Voice.PlaySound("//Voice//Knight_s6.wav");
                    CalcMove.SetKn(CalcMove.Kn);
                    CalcMove.Sort();
                }
                else
                {
                    ControlMode = ControlMode.PikeSin;
                    btnKn.Text = "PikeSin";
                    Voice.PlaySound("//Voice//Knight_Disband1.wav");
                    CalcMove.SetPikeSin();
                }
            }

            if (keyCode == (int)Keys.Subtract)
            {
                if (ControlMode == ControlMode.PikeSin)
                {
                    CalcMove.SetPikeSin();
                }
                else
                {
                    if (CalcMove.Kn.Count != 0)
                    {
                        var bigger = CalcMove.Kn.Max();
                        CalcMove.Kn.Remove(bigger);
                        CalcMove.PikeSin.Add(bigger);
                    }
                }
                CalcMove.Sort();
            }

            if (keyCode == (int)Keys.Multiply)
            {
                if (CalcMove.PikeSin.Count != 0)
                {
                    CalcMove.PikeSin.Sort();
                    int smaller = 0;
                    if (CalcMove.PikeSin.Count == 1)
                        smaller = CalcMove.PikeSin.Min();
                    else
                        smaller = CalcMove.PikeSin.Skip(1).Min();
                    CalcMove.PikeSin.Remove(smaller);
                    CalcMove.Kn.Add(smaller);
                }
                CalcMove.Sort();
            }

            if (keyCode == (int)Keys.NumPad1)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.Add)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.NumPad5)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.N)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.G)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.M)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.H)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.B)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.I)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.E)
                Key.SendKey(keyCode, Setting);

            if (keyCode == (int)Keys.NumPad3)
                AssassinFlag.Move(Setting.FlagDelay);

            if (keyCode == (int)Keys.Insert)
            {
                if (checkBox2.Checked == false)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + "//Voice//Engineer_catplt1.wav");
                    player.Load();
                    player.Play();
                    this.BackColor = Color.CornflowerBlue;
                    RegisterKey();
                    btnActive.Text = "Active ON (Insert)";
                    btnActive.ForeColor = Color.DodgerBlue;
                    checkBox2.Checked = true;
                    return;
                }

                if (checkBox2.Checked)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + "//Voice//AEngineer_Exit1.wav");
                    player.Load();
                    player.Play();
                    this.BackColor = Color.Coral;
                    UnRegisterKey();
                    btnActive.Text = "Active OFF (Insert)";
                    btnActive.ForeColor = Color.Crimson;
                    checkBox2.Checked = false;
                    return;
                }
            }

            if (keyCode == (int)Keys.F4)
            {
                var shieldPosition = new Point(Cursor.Position.X, Cursor.Position.Y);
                Clicker.LeftClick(130, 700, Setting.CompressDelay);
                Clicker.LeftClick(shieldPosition.X, shieldPosition.Y, Setting.CompressDelay);
            }

            if (keyCode == (int)Keys.F5)
            {
                var shieldPosition = new Point(Cursor.Position.X, Cursor.Position.Y);
                Clicker.LeftClick(173, 745, Setting.CompressDelay);
                Clicker.LeftClick(shieldPosition.X, shieldPosition.Y, Setting.CompressDelay);
            }

            if (keyCode == (int)Keys.End || keyCode == (int)Keys.PageDown)
            {
                //    var tc = new Random();
                //    var index = tc.Next(1, ValidPoint.Count - 1);
                //    MouseMoves.LinearSmoothMove(new Point(Cursor.Position.X, Cursor.Position.Y), int.Parse(textBox7.Text));
                //    MouseMoves.LinearSmoothMove(new Point(ValidPoint[index].X, ValidPoint[index].Y), int.Parse(textBox7.Text));
                //    Clicker.LeftClick(ValidPoint[index].X, ValidPoint[index].Y, Setting.CompressDelay);
            }

            base.WndProc(ref xMessage);
        }


        private void RegisterShortcutKey()
        {
            AddGroup = new GlobalHotKey(Modifiers.Ctrl | Modifiers.Alt, Keys.NumPad9, this, true);
            RemoveGroup = new GlobalHotKey(Modifiers.Alt, Keys.NumPad9, this, true);
            Rules = new GlobalHotKey(Modifiers.Ctrl | Modifiers.Shift, Keys.R, this, true);
            StartRecordPattern = new GlobalHotKey(Modifiers.Ctrl | Modifiers.Shift, Keys.S, this, true);
            EndRecordPattern = new GlobalHotKey(Modifiers.Ctrl | Modifiers.Shift, Keys.E, this, true);
        }
        private void RegisterKey()
        {
            var keys = RegisterKeys.GetKeys();

            foreach (var keyse in keys)
            {
                RegisterHotKey(Handle, (int)keyse, 0, (int)keyse);
            }
        }


        private void UnRegisterKey()
        {
            var keys = RegisterKeys.GetKeys();
            keys.Remove(Keys.Insert);
            foreach (var keyse in keys)
            {
                UnregisterHotKey(Handle, (int)keyse);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            s.CompressDelay = Convert.ToInt32(txtArmyCompressDelay.Text);
            s.DelayS = Convert.ToInt32(txtDelayS.Text);
            s.FlagDelay = Convert.ToInt32(txtFlagDelay.Text);
            //   s.Rules = txtRules.Text;
            s.MouseSpeed = Convert.ToInt32(txtMouseSpeed.Text);
            s.Direction = Convert.ToInt32(txtDirection.Text);

            var config = JsonConvert.SerializeObject(s);
            using (var sw = File.CreateText(Environment.CurrentDirectory + "\\Setting.txt"))
            {
                sw.WriteLine(config);
            }
            MessageBox.Show("Save Success");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Setting = new Setting();
            Setting = SettingService.GetSetting();
            UpdateUi(Setting);
        }
        private void UpdateUi(Setting s)
        {
            if (Setting != null)
            {
                txtArmyCompressDelay.Text = s.CompressDelay.ToString();
                txtFlagDelay.Text = s.FlagDelay.ToString();
                txtDelayS.Text = s.DelayS.ToString();
                //txtRules.Text = s.Rules?.ToString();
                txtMouseSpeed.Text = s.MouseSpeed.ToString();
            }
        }
        private void deletePatternToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var pattern = Directory.GetFiles(PatternShieldAddress).ToList();
            foreach (var address in pattern)
            {
                File.Delete(address);
            }
        }

        private void setRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSetRules setRules = new FrmSetRules();
            //setRules.ShowDialog();
        }
    }
}