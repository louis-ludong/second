

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IGT.Service.PLC;
using IGT.Service;//LDC OBD
namespace IGT.UI.Client
{
    public partial class LaunchForm : Form
    {
        public LaunchForm()
        {
            String bgFile = System.IO.Directory.GetCurrentDirectory() + "\\" + "Start.png";
            Image img;
            if (System.IO.File.Exists(bgFile))
                img = Image.FromFile(bgFile);
            else if (Services.Lang.CurrentLang.LCID == 1033)//默认语言
                img = Properties.Resources.Welcome_cn;
            else
                img = Properties.Resources.Welcome_en;

            this.DoubleBuffered = true;
            InitializeComponent();
            UI.Client.UIHelper.CommonSet(this);
            this.BackgroundImage = img;
            this.Size = this.BackgroundImage.Size;
        }
        string[] ports;
        int index;
        private void LaunchForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ports = System.IO.Ports.SerialPort.GetPortNames();
            //ports = new string[0];
            //ports = { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7" };
            index = 0;
            var cnnt = Services.Device.Connect;
            if (ports.Length > 0)
            {
                RequestPasswordBind(true);
                cnnt.InitConnictFinish += Connict_ConnictFinish;
                cnnt.InitConnecting(ports[index]);
            }
            else
            {
                System.Threading.Timer timer = new System.Threading.Timer(obj => this.BeginInvoke(new UIHelper.UIINvkoeParam1<bool>(GoMainForm), false));
                timer.Change(2000, 0);
            }
        }
        void Connict_ConnictFinish(object sender, ConnictFinishEventArgs e)
        {
            var cnnt = sender as Device.Connection;
            if (e.Reason == ConnectionFinishReasons.Bootloader)
            {
                RequestPasswordBind(false);
                cnnt.InitConnictFinish -= Connict_ConnictFinish;
                this.BeginInvoke(new UIHelper.UIInvoke(ShowUpECUForm));
            }
            else
            {
                if (cnnt.IsConnected)
                {
                    System.Diagnostics.Debug.WriteLine("连接成功");
                 //   IGT.Service.SSer.Device = Services.Device;
                    IGT.Service.SSer.Device = Services.Device;
                    RequestPasswordBind(false);
                    cnnt.InitConnictFinish -= Connict_ConnictFinish;
                    this.BeginInvoke(new UIHelper.UIINvkoeParam1<bool>(GoMainForm), false);
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
                        RequestPasswordBind(false);

                        cnnt.InitConnictFinish -= Connict_ConnictFinish;
                        this.BeginInvoke(new UIHelper.UIINvkoeParam1<bool>(GoMainForm), e.Reason == ConnectionFinishReasons.NoRespose);
                    }
                }
            }
        }
        private void GoMainForm(bool showTip=false)
        {
            if (Services.Device.Connect.IsConnected)
            {
                Services.RealyDataPre.Begin();
                Services.Device.BeginOnTimeTask(OnTimeTasks.GetRealyTimeData);
                System.Threading.Thread.Sleep(500);
            }
            Services.Stroe.LoadAuto();

            if (!Services.Device.Connect.IsConnected&&showTip)
                MessageBox.Show(Services.Lang.CurrentWords["1"]);
            RequestPasswordBind(false);
            MainForm m = new MainForm();
            m.FormClosed += (s, e) => this.Close();
            this.Cursor = Cursors.Default;
            this.Hide();
            m.Show();
        }
        private void ShowUpECUForm()
        {
            MessageBox.Show(Services.Lang.CurrentWords["5"],"",MessageBoxButtons.OKCancel ,MessageBoxIcon.Information);
            bool result= UIHelper.ShowUpECUForm(this, (sender, e) =>
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath,"wait-1500");
                this.Close();
            });
            if (result == false)
                GoMainForm(false);
        }

        void Connict_RequestPassword(object sender, RequestPWdEventArgs e)
        {
            e.Handeled = true;
            RequestPasswordBind(false);
            this.BeginInvoke(new UIHelper.UIInvoke(ShowPWDForm));
        }
        private void LaunchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Services.Stroe.Dispose();
            Services.Device.Dispose();
        }

        private void ShowPWDForm()
        {
            if (!this.Visible) return;
            var pwdForm = new PWDForm();
            pwdForm.FormClosed += pwdForm_FormClosed;
            pwdForm.ShowDialog();
        }

        void pwdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form=sender as PWDForm;
            if (this.Visible&&!form.IsCancel)
                RequestPasswordBind(true);
            form.FormClosed -= pwdForm_FormClosed;
        }
        private void RequestPasswordBind(bool bindorNot)
        {
            if(bindorNot){
                Services.Device.Connect.RequestPassword += Connict_RequestPassword;
            }
            else
            {
                Services.Device.Connect.RequestPassword -= Connict_RequestPassword;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.04;
            if (Opacity ==1)
            {
                timer1.Enabled = false;
            }
        }
    }
}
