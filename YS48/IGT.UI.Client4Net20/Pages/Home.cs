using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.Pages
{
    /// <summary>
    /// 主页
    /// </summary>
    public partial class Home : UserControl,IPage
    {
        public Home()
        {
            IsReadly = false;
            InitializeComponent();
            ApplyLang();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).MainMenu.ShowAllMenus();
            (this.ParentForm as MainForm).MainMenu.ShowGraphMenuButton = false;
        }

        void Button_Click(object sender,EventArgs e)
        {
            var button = sender as Label;
            switch (button.Name)
            {
                case "labMCar":
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUSetting);//等待参数加载完毕
                    (this.ParentForm as MainForm).NagivateTo(new CarSetting());
                    break;
                case "labMAutoCalibration":
                    (this.ParentForm as MainForm).NagivateTo(new AutoCalibration());
                    break;
                case "labMRealyData":
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.MAPCalibrationParams);
                    (this.ParentForm as MainForm).NagivateTo(new RealyTimeData());
                    break;
                case "labMDiagnostics":
                    (this.ParentForm as MainForm).NagivateTo(new Diagnosis());
                    break;
                case "labMSave":
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PCLSetting|*.xml";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Services.Stroe.SaveToFile(sfd.FileName);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "labMLoad":
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "PCLSetting|*.xml";
                    if(ofd.ShowDialog()== DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Services.Stroe.LoadFromFile(ofd.FileName);
                        this.Cursor = Cursors.Default;
                    }
                    break;
                case "labMUpdate":
                    UIHelper.ShowUpECUForm(this.ParentForm);
                    break;
                case "labMExit":
                    this.ParentForm.Close();
                    break;
            }
        }
        #region MainMenu
        private void mainMenuButton_MouseEnter(object sender, EventArgs e)
        {

            labMAutoCalibration.Image = Properties.Resources.MainMenu_AutoCalibration;
            labMCar.Image = Properties.Resources.MainMenu_Car;
            labMDiagnostics.Image = Properties.Resources.MainMenu_Diagnostics;
            labMExit.Image = Properties.Resources.MainMenu_Exit;
            labMLoad.Image = Properties.Resources.MainMenu_Load;
            labMRealyData.Image = Properties.Resources.MainMenu_RealyData;
            labMSave.Image = Properties.Resources.MainMenu_Save;
            labMUpdate.Image = Properties.Resources.MainMenu_Update;
            var labM = sender as Label;
            switch (labM.Name)
            {
                case "labMAutoCalibration":
                    labM.Image=Properties.Resources.MainMenu_AutoCalibration2; break;
                case "labMCar":
                    labM.Image=Properties.Resources.MainMenu_Car2; break;
                case "labMDiagnostics":
                    labM.Image=Properties.Resources.MainMenu_Diagnostics2; break;
                case "labMExit":
                    labM.Image=Properties.Resources.MainMenu_Exit2; break;
                case "labMLoad":
                    labM.Image=Properties.Resources.MainMenu_Load2; break;
                case "labMRealyData":
                    labM.Image=Properties.Resources.MainMenu_RealyData2; break;
                case "labMSave":
                    labM.Image=Properties.Resources.MainMenu_Save2; break;
                case "labMUpdate":
                    labM.Image=Properties.Resources.MainMenu_Update2; break;
            }
        }

        private void mainMenuButton_MouseLeave(object sender, EventArgs e)
        {
            var labM = sender as Label;
            switch (labM.Name)
            {
                case "labMAutoCalibration":
                    labM.Image = Properties.Resources.MainMenu_AutoCalibration; break;
                case "labMCar":
                    labM.Image = Properties.Resources.MainMenu_Car; break;
                case "labMDiagnostics":
                    labM.Image = Properties.Resources.MainMenu_Diagnostics; break;
                case "labMExit":
                    labM.Image = Properties.Resources.MainMenu_Exit; break;
                case "labMLoad":
                    labM.Image = Properties.Resources.MainMenu_Load; break;
                case "labMRealyData":
                    labM.Image = Properties.Resources.MainMenu_RealyData; break;
                case "labMSave":
                    labM.Image = Properties.Resources.MainMenu_Save; break;
                case "labMUpdate":
                    labM.Image = Properties.Resources.MainMenu_Update; break;
            }
        }
        #endregion
        void ShowDeviceInfo()
        {
            labConnectState.Text = Connict.IsConnected ?
                Words["210"] : Words["211"];
            labConnectState.ForeColor = Connict.IsConnected ?
                Color.Black : Color.FromArgb (245,130,31);

            labSerialNumber.Text ="SerialNumber:"+ Device.DeviceInfo.SerialNumber;

            if (Device.Connect.IsConnected&&Device.DeviceInfo != null)
            {
                labFirmWare.Text = String.Format("{0}:V{1}", Words["213"], Device.DeviceInfo.FirmwareInfo);
                labHardWareVer.Text = String.Format("{0}:V{1}", Words["212"], Device.DeviceInfo.HardInof.PCBVer);
            }
            else
            {
                labFirmWare.Text = String.Empty;
                labHardWareVer.Text = String.Empty;
            }
        }

        #region GDI+

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen hPen = new Pen(new SolidBrush(Color.FromArgb(255, 221, 221, 221)), 3);
            e.Graphics.DrawLine(hPen, 0, this.ClientSize.Height - 54, this.ClientSize.Width, this.ClientSize.Height - 54);
            base.OnPaint(e);
        }
        #endregion

        #region IPage 成员
        public bool IsReadly { get; private set; }
        public void LoadPage()
        {
            //this.Show();
            IsReadly = true;
        }
        public void UnLoadPage()
        {
            IsReadly = false;
            this.Dispose();
        }
        public void Change4Connect()
        {
            ShowDeviceInfo();
        }
        public void ProcessRealyTimeData(Models.Feedback.RealTimeData model) { }
        public void ProcessAutoCalbrationDetails(Models.Feedback.AutoCalibrationDetails model) { }
        public void ProcessDiagnosisDetails(Models.Feedback.DiagnosisDetails model) { }
        public Control AsControl
        {
            get { return this; }
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
            this.Font = new Font(fontFamily, this.Font.Size);
            labMCar.Font = new Font(fontFamily, labMCar.Font.Size);
            labMSave.Font = new Font(fontFamily, labMSave.Font.Size);
            labMLoad.Font = new Font(fontFamily, labMLoad.Font.Size);
            labMExit.Font = new Font(fontFamily, labMExit.Font.Size);
            labMRealyData.Font = new Font(fontFamily, labMRealyData.Font.Size);
            labMUpdate.Font = new Font(fontFamily, labMUpdate.Font.Size);
            labMDiagnostics.Font = new Font(fontFamily, labMDiagnostics.Font.Size);
            labMAutoCalibration.Font = new Font(fontFamily, labMAutoCalibration.Font.Size);

            this.Text = Words["201"]+"\n";
            labMCar.Text = Words["202"] + "\n";
            labMSave.Text = Words["203"] + "\n";
            labMLoad.Text = Words["205"] + "\n";
            labMExit.Text = Words["209"] + "\n";
            labMRealyData.Text = Words["204"] + "\n";
            labMUpdate.Text = Words["207"] + "\n";
            labMDiagnostics.Text = Words["206"] + "\n";
            labMAutoCalibration.Text = Words["208"] + "\n";
            ShowDeviceInfo();
        }
        Dictionary<String, String> Words
        {
            get { return Services.Lang.CurrentWords; }
        }
        #endregion

        #region 属性和字段
        Service.PLC.Device Device{get { return Services.Device; }}
        Service.PLC.Device.Connection Connict{get { return Services.Device.Connect; }}
        Service.Language.LangService Lang{get { return Services.Lang; }}
        #endregion

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Device.DeviceInfo.SerialNumber);
        }
    }
}
