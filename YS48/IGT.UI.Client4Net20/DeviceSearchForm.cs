using IGT.Service.PLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    public partial class DeviceSearchForm : Form,Service.Language.IMultLang
    {
        public DeviceSearchForm(String portName)
        {
            InitializeComponent();
            ApplyLang();
            this.ports = new string[] { portName };
        }
        public DeviceSearchForm()
        {
            InitializeComponent();
            ApplyLang();
            this.ports = System.IO.Ports.SerialPort.GetPortNames();
        }

        private void DeviceSearchForm_Load(object sender, EventArgs e)
        {
            FirewareBreaken = false;
            this.Cursor = Cursors.WaitCursor;
            index = 0;
            var cnnt = Services.Device.Connect;
            cnnt.InitConnictFinish += Connict_ConnictFinish;
            cnnt.RequestPassword += Connict_RequestPassword;
            if (ports.Length > 0)
                cnnt.InitConnecting(ports[index]);
            else
                this.Close();
        }

        private void Connict_RequestPassword(object sender, RequestPWdEventArgs e)
        {
            if (e.Handeled == true||this.IsDisposed||!this.Created) return;
            Services.Device.Connect.RequestPassword -= Connict_RequestPassword;
            e.Handeled = true;
            this.BeginInvoke(new UIHelper.UIInvoke(ShowPWDForm));
        }

        private void ShowPWDForm()
        {
            var pwdForm = new PWDForm();
            pwdForm.FormClosed += pwdForm_FormClosed;
            pwdForm.ShowDialog();
        }

        void pwdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Services.Device.Connect.RequestPassword += Connict_RequestPassword;
            (sender as Form).FormClosed -= pwdForm_FormClosed;            
        }
        void Connict_ConnictFinish(object sender, ConnictFinishEventArgs e)
        {
            var cnnt = sender as Device.Connection;
            if (e.Reason == ConnectionFinishReasons.Bootloader)
            {
                this.BeginInvoke(new UIHelper.UIInvoke(SetFirewareState));
            }
            else
            {
                if (cnnt.IsConnected)
                {
                    System.Diagnostics.Debug.WriteLine("连接成功");
                    Services.RealyDataPre.Begin();
                    Services.Device.BeginOnTimeTask(OnTimeTasks.GetRealyTimeData);
                    System.Threading.Thread.Sleep(500);
                    Services.Stroe.LoadAuto();
                    this.BeginInvoke(new UIHelper.UIInvoke(this.Close));
                }
                else
                {
                    if (ports.Length > index + 1)
                    {
                        cnnt.InitConnecting(ports[++index]);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("连接失败");
                        Services.Stroe.LoadAuto();
                        this.BeginInvoke(new UIHelper.UIInvoke(this.Close));
                    }
                }
            }
        }
        private void SetFirewareState()
        {
            FirewareBreaken = true;
            this.Close();
        }
        string[] ports;
        int index;

        private void DeviceSearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var cnnt = Services.Device.Connect;
            cnnt.InitConnictFinish -= Connict_ConnictFinish;
            cnnt.RequestPassword -= Connict_RequestPassword;
            if (!cnnt.IsConnected&&!FirewareBreaken)
                MessageBox.Show(Services.Lang.CurrentWords["1"]);
        }
        public bool FirewareBreaken { get; private set; }

        #region GDI+
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 4);
            e.Graphics.DrawRectangle(redPen, 2, 2, this.ClientSize.Width - 4, this.ClientSize.Height - 4);
            //e.Graphics.DrawLine(redPen, 829, 0, 829, this.ClientSize.Height - 114);
            redPen.Dispose();
        }
        #endregion

        #region IMultLang 成员

        public void ApplyLang()
        {
            this.Text = Services.Lang.CurrentWords["2"];
            this.label1.Text = Services.Lang.CurrentWords["2"];
        }

        #endregion
    }
}
