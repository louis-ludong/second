using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    public partial class MainForm : Form, Service.Language.IMultLang
    {
        public MainForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            UIHelper.CommonSet(this);
            ApplyLang();
            IsNaving = true;
            CurrentPage = new Pages.Home();
            CurrentPage.AsControl.Location = new Point(6, 60);
            CurrentPage.AsControl.Width = this.ClientSize.Width - 12;
            CurrentPage.AsControl.Height = this.ClientSize.Height -60 - 6;
            this.Controls.Add(CurrentPage.AsControl);
            CurrentPage.LoadPage();
            this.Text = CurrentPage.Text;
            IsNaving = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            myMenuStrip1.RequestApplyLangChange += myMenuStrip1_RequestApplyLangChange;
            Connection.ConnectionStateChanged += Connection_ConnectionStateChanged;
            Device.RealyTimeDataGot += Device_RealyTimeDataGot;
            Device.AutoCalibrationDetailsGot += Device_AutoCalibrationDetailsGot;
            Device.DiagnosisDetailsGot += Device_DiagnosisDetailsGot;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.IsException || PageIsHome())
            {
                IsClosing = true;
                Device.AutoCalibrationDetailsGot -= Device_AutoCalibrationDetailsGot;
                Device.RealyTimeDataGot -= Device_RealyTimeDataGot;
                Connection.ConnectionStateChanged -= Connection_ConnectionStateChanged;
                myMenuStrip1.RequestApplyLangChange -= myMenuStrip1_RequestApplyLangChange;
                Device.DiagnosisDetailsGot -= Device_DiagnosisDetailsGot;
                FinishPage();
            }
            else
            {
                e.Cancel = true;
                if(Services.ActionMsg.Count==0)
                    NagivateToHome();
                else
                {
                    Services.ActionMsg.Dequeue();
                    NagivateTo(new Pages.CarSetting(Pages.CarSetting.Panel.Diagram));
                }
            }
        }

        void Connection_ConnectionStateChanged(object sender, EventArgs e)
        {
            if (!Services.Device.Connect.IsConnected)
                this.BeginInvoke(new UIHelper.UIInvoke(myMenuStrip1.SelectDisConnect));
            if (CanOpPage)
                this.BeginInvoke(new UIHelper.UIInvoke(CurrentPage.Change4Connect));
        }
        void Device_RealyTimeDataGot(object sender, Service.PLC.ModelGotEventArg<Models.Feedback.RealTimeData> e)
        {
            if (CanOpPage)
                this.BeginInvoke(new UIHelper.UIINvkoeParam1<Models.Feedback.RealTimeData>(CurrentPage.ProcessRealyTimeData),e.Data);
        }

        void Device_AutoCalibrationDetailsGot(object sender, Service.PLC.ModelGotEventArg<Models.Feedback.AutoCalibrationDetails> e)
        {
            if (CanOpPage)
                this.BeginInvoke(new UIHelper.UIINvkoeParam1<Models.Feedback.AutoCalibrationDetails>(CurrentPage.ProcessAutoCalbrationDetails), e.Data);
        }
        void Device_DiagnosisDetailsGot(object sender, Service.PLC.ModelGotEventArg<Models.Feedback.DiagnosisDetails> e)
        {
            if (CanOpPage)
                this.BeginInvoke(new UIHelper.UIINvkoeParam1<Models.Feedback.DiagnosisDetails>(CurrentPage.ProcessDiagnosisDetails), e.Data);
        }

        void myMenuStrip1_RequestApplyLangChange(object sender, EventArgs e)
        {
            this.ApplyLang();
        }
        #region Page
        public void NagivateToHome()
        {
            NagivateTo(new Pages.Home());
        }
        public bool PageIsHome()
        {
            return CurrentPage != null && CurrentPage.Name == "Home";
        }
        public void NagivateTo(IPage page)
        {
            IsNaving = true;
            if (this.Visible == true)
                this.Hide();
            if (CurrentPage != null)
            {
                this.Controls.Remove(CurrentPage.AsControl);
                CurrentPage.UnLoadPage();
            }
            CurrentPage = page;
            CurrentPage.AsControl.Location = new Point(6, 60);
            CurrentPage.AsControl.Width = this.ClientSize.Width - 12;
            CurrentPage.AsControl.Height = this.ClientSize.Height - 60 - 6;
            this.Controls.Add(CurrentPage.AsControl);
            CurrentPage.LoadPage();
            this.Text = page.Text;
            this.Show();
            IsNaving = false;
        }
        protected void FinishPage()
        {
            CurrentPage.UnLoadPage();
        }
        #endregion

        /// <summary>
        /// 应用语言
        /// </summary>
        public void ApplyLang()
        {
            if (this.CanOpPage)
            {
                CurrentPage.ApplyLang();
                this.Text = CurrentPage.Text;
            }
            myMenuStrip1.ApplyLang();
        }

        #region GDI+
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Services.Theme.DrawBorder(e);
        }
        #endregion
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region 属性和字段
        /// <summary>
        /// Page是否能接受操作
        /// </summary>
        public bool CanOpPage
        {
            get { return CurrentPage != null && IsNaving == false && CurrentPage.IsReadly && !this.IsClosing; }
        }
        public UserControls.MyMenuStrip MainMenu
        {
            get { return myMenuStrip1; }
        }
        bool IsClosing=false;
        bool IsNaving = false;
        IPage CurrentPage;
        Service.PLC.Device Device
        {
            get { return Services.Device; }
        }
        Service.PLC.Device.Connection Connection
        {
            get { return Services.Device.Connect; }
        }
        Service.Language.LangService Lang
        {
            get { return Services.Lang; }
        }
        #endregion

        private void myMenuStrip1_Load(object sender, EventArgs e)
        {

        }
    }
}
