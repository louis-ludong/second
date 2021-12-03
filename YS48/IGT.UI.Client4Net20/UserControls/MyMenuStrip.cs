using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls
{
    public partial class MyMenuStrip : UserControl
    {
        public MyMenuStrip()
        {
            InitializeComponent();
            if (!DesignMode) labTopGraph.Visible = false;
            this.BackColor = Services.Theme.FormBorderColor;
            foreach (var item in Services.Lang.LangList)//语言列表
            {
                var tsmi = new ToolStripMenuItem(item.DisplayName);
                tsmi.Tag = item.FileFullName;
                if (item.FileFullName == Services.Lang.CurrentLang.FileFullName) tsmi.Checked = true;
                tsmi.Click += tsmiLangs_Click;
                tsmiLang.DropDownItems.Add(tsmi);
            }
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
            flowLayoutPanel1.MouseUp += flowLayoutPanel1_MouseUp;
            flowLayoutPanel1.MouseMove += flowLayoutPanel1_MouseMove;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
        }
        public void ShowAllMenus()
        {
            labTopAbout.Show();
            labTopConnict.Show();
            labTopGraph.Show();
            labTopHelp.Show();
            labTopSetting.Show();
            pbTopAbout.Show();
            pbTopHelp.Show();
            pbTopSetting.Show();
        }
        public void HideAllMenus()
        {
            labTopAbout.Hide();
            labTopConnict.Hide();
            labTopGraph.Hide();
            labTopHelp.Hide();
            labTopSetting.Hide();
            pbTopAbout.Hide();
            pbTopHelp.Hide();
            pbTopSetting.Hide();
        }
        public bool ShowCloseButton{ get { return pbClose.Visible; } set { pbClose.Visible = value; } }
        public bool ShowMinButton { get { return pbMin.Visible; } set { pbMin.Visible = value; } }
        public bool ShowConnictMenuButton
        {
            get { return labTopConnict.Visible; }
            set { labTopConnict.Visible = value; }
        }
        public bool ShowGraphMenuButton
        {
            get { return labTopGraph.Visible; }
            set { labTopGraph.Visible = value; }
        }
        private void MyMenuStrip_Load(object sender, EventArgs e)
        {
            labTitle.Text = this.ParentForm.Text;
            this.ParentForm.TextChanged += ParentForm_TextChanged;
            if (!DesignMode)
            {
                foreach (var item in System.IO.Ports.SerialPort.GetPortNames())
                {
                    cmsConnict.Items.Add(new ToolStripMenuItem(item, null, tsmi_Click) { Tag = "COM" });
                }
                tsmiSearch.Checked = Services.Device.Connect.IsConnected;
                tsmiDisConnict.Checked = !Services.Device.Connect.IsConnected;
            }
        }
        private void TopBarSysButton_Click(object sender, EventArgs e)
        {
            switch ((sender as PictureBox).Name)
            {
                case "pbClose":
                    this.ParentForm.Close(); break;
                case "pbMin":
                    this.ParentForm.WindowState = FormWindowState.Minimized; break;
            }
        }

        private void TopBarMenu_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "labTopConnict":
                    labTopConnict.OpenContextMenu(cmsConnict, true);
                    break;
                case "pbTopSetting":
                case "labTopSetting":
                    pbTopSetting.OpenContextMenu(cmsSettings, true);
                    break;
                case "pbTopHelp":
                case "labTopHelp":
                    break;
                case "labTopAbout":
                case "pbTopAbout":
                    (new AboutForm()).ShowDialog();
                    break;
                case "labTopGraph":
                    labTopGraph.OpenContextMenu(cmsGraph, true);
                    break;
            }
        }
        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }
        void tsmi_Click(object sender, EventArgs e)
        {
            var tsmi = sender as ToolStripMenuItem;
            switch (tsmi.Name)
            {
                case "tsmiSearch":
                    SetChekct4Connect(tsmi);
                    var dialog1 = new DeviceSearchForm();
                        dialog1.ShowDialog();
                        if (dialog1.FirewareBreaken) ShowUpECUForm();
                    break;
                case "tsmiDisConnict":
                    SetChekct4Connect(tsmi);
                    Services.Device.Connect.Stop();
                    break;
                case "tsmiSetPassword":
                    (new SetPWDForm()).ShowDialog();
                    break;
                case "tsmiReset":
                    if (MessageBox.Show(LangWords["309_25"], LangWords["309_23"], MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//LangWords["309_13"];
                    { 
                        Services.Device.ResetPLC("XXX");
                        Services.Stroe.LoadAuto();
                    }
                    break;
                case "tsmi_G_Start":
                    this.RecoverWarper = new RecoverWarper();
                    this.RecoverWarper.Start();
                    break;
                case "tsmi_G_Stop":
                    this.RecoverWarper.End();
                    break;
                case "tsmi_G_Show":
                    RecoverWarper.ShowRecords();
                    break;
                default:
                    if (tsmi.Tag.ToString() == "COM")//菜单 连接ECU
                    {
                        SetChekct4Connect(tsmi);
                        var dialog2 = new DeviceSearchForm(tsmi.Text);
                        dialog2.ShowDialog();
                        if (dialog2.FirewareBreaken) ShowUpECUForm();
                    }
                    break;
            }
        }
        private void ShowUpECUForm()
        {
            MessageBox.Show(Services.Lang.CurrentWords["5"], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UIHelper.ShowUpECUForm(this.ParentForm, (sender, e) =>
            {
                Services.Device.Connect.InitConnecting(Services.Device.PortName);
                this.ParentForm.Show();
            });
        }
        void tsmiLangs_Click(object sender, EventArgs e)
        {
            var tsmi = sender as ToolStripMenuItem;
            foreach (ToolStripMenuItem item in tsmiLang.DropDownItems)
            {
                item.Checked = false;
            }
            tsmi.Checked = true;
            Services.Lang.SetCurrentWords(tsmi.Tag.ToString());
            Properties.Settings.Default.Language = tsmi.Tag.ToString();
            Properties.Settings.Default.Save();
            RequestApplyLangChange(this, EventArgs.Empty);
        }
        void SetChekct4Connect(ToolStripMenuItem tsmi)
        {
            foreach (var item in cmsConnict.Items)
            {
                var tt = item as ToolStripMenuItem;
                if (tt != null) tt.Checked = false;
            }
            tsmi.Checked = true;
        }
        void ParentForm_TextChanged(object sender, EventArgs e)
        {
            labTitle.Text = this.ParentForm.Text;
        }

        #region GDI+
        void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(this.ParentForm.Icon, new Rectangle(2, 2, 130, 48));
        }

        #endregion

        #region 窗体拖动
        Point mouseOff;
        void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Capture = false;
        }

        void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel1.Capture)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                this.ParentForm.Location = mouseSet;
            }
        }

        void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == System.Windows.Forms.MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                flowLayoutPanel1.Capture = true;
            }
        }
        #endregion

        #region IMultLang 成员

        public void ApplyLang()
        {
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            labTopAbout.Font = new Font(fontFamily, labTopAbout.Font.Size );
            labTopConnict.Font = new Font(fontFamily, labTopConnict.Font.Size );
            labTopHelp.Font = new Font(fontFamily, labTopHelp.Font.Size );
            labTopSetting.Font = new Font(fontFamily, labTopSetting.Font.Size);
            tsmiDisConnict.Font = new Font(fontFamily, tsmiDisConnict.Font.Size);
            tsmiSearch.Font = new Font(fontFamily, tsmiSearch.Font.Size);
            tsmiLang.Font = new Font(fontFamily, tsmiLang.Font.Size);
            tsmiSetPassword.Font = new Font(fontFamily, tsmiSetPassword.Font.Size);
            tsmiReset.Font = new Font(fontFamily, tsmiReset.Font.Size);
            labTopGraph.Font = new Font(fontFamily, labTopGraph.Font.Size);
            tsmi_G_Start.Font = new Font(fontFamily, tsmi_G_Start.Font.Size);
            tsmi_G_Stop.Font = new Font(fontFamily, tsmi_G_Stop.Font.Size);
            tsmi_G_Show.Font = new Font(fontFamily, tsmi_G_Show.Font.Size);

            labTopAbout.Text = Words["102"];
            labTopConnict.Text = Words["103"];
            labTopHelp.Text = Words["101"];
            labTopSetting.Text = Words["106"];
            tsmiDisConnict.Text = Words["105"];
            tsmiSearch.Text = Words["104"];
            tsmiLang.Text = Words["107"];
            tsmiSetPassword.Text = Words["109"];
            tsmiReset.Text = Words["108"];
            labTopGraph.Text = Words["111"];
            tsmi_G_Start.Text = Words["112"];
            tsmi_G_Stop.Text = Words["113"];
            tsmi_G_Show.Text = Words["114"];
        }
        Dictionary<String, String> Words
        {
            get { return Services.Lang.CurrentWords; }
        }
        #endregion
        public event EventHandler RequestApplyLangChange;

        private void cmsGraph_Opening(object sender, CancelEventArgs e)
        {
            if (this.RecoverWarper!=null&&this.RecoverWarper.IsRecording)
            {
                tsmi_G_Start.Enabled = false;
                tsmi_G_Stop.Enabled = true;
            }
            else
            {
                tsmi_G_Start.Enabled = true;
                tsmi_G_Stop.Enabled = false;
            }
            if(!Services.Device.Connect.IsConnected)
            {
                tsmi_G_Start.Enabled = false;
                tsmi_G_Stop.Enabled = false;
            }
        }
        RecoverWarper RecoverWarper;

        private void cmsSettings_Opening(object sender, CancelEventArgs e)
        {
            tsmiReset.Enabled = Services.Device.Connect.IsConnected;
            tsmiSetPassword.Enabled = Services.Device.Connect.IsConnected;
        }

        internal ConnectiontActionModes ConnictMode
        {
            get
            {
                if (tsmiSearch.Checked) return ConnectiontActionModes.Auto;
                else if (tsmiDisConnict.Checked) return ConnectiontActionModes.No;
                else return ConnectiontActionModes.COMAssign;
            }
        }
        internal void SelectDisConnect()
        {
            SetChekct4Connect(tsmiDisConnict);
        }
        public override Color BackColor
        {
            get
            {
                return flowLayoutPanel1.BackColor;
            }
            set
            {
                flowLayoutPanel1.BackColor = Color.FromArgb(245,130,31);
                pictureBox1.BackColor = Color.FromArgb(245, 130, 31);
                pictureBox2.BackColor = Color.FromArgb(245,130,31);
                pbClose.BackColor = Color.FromArgb(245, 130, 31);
                pbMin.BackColor = Color.FromArgb(245, 130, 31);
                pbTopAbout.BackColor = Color.FromArgb(245, 130, 31);
                pbTopHelp.BackColor = Color.FromArgb(245, 130, 31);
                pbTopSetting.BackColor = Color.FromArgb(245, 130, 31);
                labTopAbout.BackColor = Color.FromArgb(245, 130, 31);
                labTopConnict.BackColor = Color.FromArgb(245, 130, 31);
                labTopGraph.BackColor = Color.FromArgb(245, 130, 31);
                labTopHelp.BackColor = Color.FromArgb(245, 130, 31);
                labTopSetting.BackColor = Color.FromArgb(245, 130, 31);
            }
        }
    }
}
