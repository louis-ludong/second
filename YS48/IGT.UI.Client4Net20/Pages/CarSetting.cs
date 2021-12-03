 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace IGT.UI.Client.Pages
{
    /// <summary>
    /// 车辆设置页
    /// </summary>
    public partial class CarSetting : UserControl, IPage
    {
        private Panel? StartPanel = null;
        public enum Panel { Diagram }
        public CarSetting(Panel? panel)
        {
            this.StartPanel = panel;
            IsReadly = false;
            InitializeComponent();
            rtlGas.BackColor = Color.Transparent;
            rtlGasLevel.BackColor = Color.Transparent;
            rtlGasPress.BackColor = Color.Transparent;
            rtlLambda1.BackColor = Color.Transparent;
            rtlLambda2.BackColor = Color.Transparent;
            rtlMapPress.BackColor = Color.Transparent;
            rtlPetrol.BackColor = Color.Transparent;
            rtlRPM.BackColor = Color.Transparent;
            rtlTempGas.BackColor = Color.Transparent;
            rtlTempRed.BackColor = Color.Transparent;

            ApplyLang();
        }
        public CarSetting() : this(null) { }

        private void CarSetting_Load(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).MainMenu.HideAllMenus();
            if (StartPanel == null)
                CMenu_Click(btn1, EventArgs.Empty);
            else
                CMenu_Click(MAPbtn, EventArgs.Empty);
        }
        private void CMenu_Click(object sender, EventArgs e)
        {
            var control = sender as VistaButton;
            SetMenuCurrent(control);
            var panel = GetPanelAndShow(control.Name);
            var tempPanel = CurrentSettingPanel as UserControls.SettingPanels.DiagramPanel;
            if (tempPanel != null) tempPanel.PanelLoad();
        }
        private void tpbSwitchKey_Click(object sender, EventArgs e)
        {
            Services.Device.SendAndRead("CarSettingPage", UIHelper.CancelBit_CarSettingPage, Service.PLC.InstructionSet.SetKeySwitch);
            //if (!SharedValueHelper.KeySwitchState.HasValue)
            //    SharedValueHelper.KeySwitchState = true;
            //SharedValueHelper.KeySwitchState = !SharedValueHelper.KeySwitchState.Value;
            //tpbSwitchKey.Toggle(SharedValueHelper.KeySwitchState.Value);
        }

        #region IPage 成员
        public bool IsReadly { get; private set; }
        public void LoadPage()
        {
            Change4Connect();
            Services.RealyDataPre.End();
            if (Services.RealyDataPre.RealData != null)
                ShowRealyData(Services.RealyDataPre.RealData);
            IsReadly = true;
        }

        public void UnLoadPage()
        {
            IsReadly = false;
            Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetAdditionalInfo);
            Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetTiji2DCurve);
            Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetTiji3DCurve);
            foreach (var item in SettingPanelsDic.Values)
            {
                var temp = item as UserControls.SettingPanels.DiagramPanel;
                if (temp != null)
                    temp.PanelUnLoad();
                item.Dispose();
            }
            SettingPanelsDic.Clear();
            Services.RealyDataPre.Begin();
            this.Dispose();
        }
        public void ProcessDiagnosisDetails(Models.Feedback.DiagnosisDetails model) { }
        public void Change4Connect()
        {
            tpbIgnitionStatus.Enabled = Services.Device.Connect.IsConnected;
        }
        public void ProcessRealyTimeData(Models.Feedback.RealTimeData model)
        {
            if (IsReadly)
                ShowRealyData(model);
        }
        public void ProcessAutoCalbrationDetails(Models.Feedback.AutoCalibrationDetails model) { }
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
            labPetrol1.Font = new Font(fontFamily, labPetrol1.Font.Size);
            labGas1.Font = new Font(fontFamily, labGas1.Font.Size);
            labGasPress.Font = new Font(fontFamily, labGasPress.Font.Size);
            labMapPress.Font = new Font(fontFamily, labMapPress.Font.Size);
            labTempRed.Font = new Font(fontFamily, labTempRed.Font.Size);
            labTempGas.Font = new Font(fontFamily, labTempGas.Font.Size);
            labRPM.Font = new Font(fontFamily, labRPM.Font.Size);
            labGasLevel.Font = new Font(fontFamily, labGasLevel.Font.Size);
            labRPMSource.Font = new Font(fontFamily, labRPMSource.Font.Size);
            labLambda1.Font = new Font(fontFamily, labLambda1.Font.Size);
            labLambda2.Font = new Font(fontFamily, labLambda2.Font.Size);
            this.Text = Words["301"];
            btn1.ButtonText = Words["302"];
            if (Services.Lang.CurrentLang.DisplayName == "Español")
            { 
                btn1.Font = new System.Drawing.Font(btn1.Font.SystemFontName, 13F, System.Drawing.FontStyle.Bold);
                btn2.Font = new System.Drawing.Font(btn1.Font.SystemFontName, 13F, System.Drawing.FontStyle.Bold);
            }
            OBDSETBtn.ButtonText = Words["328"];
            btn2.ButtonText = Words["303"];
            btn3.ButtonText = Words["304"];
            MAPbtn.ButtonText = Words["308"];
            btn7.ButtonText = Words["309"];
            btn8.ButtonText = Words["310"];
            btn9.ButtonText = Words["325"];
            labPetrol1.Text = Words["311"];
            labGas1.Text = Words["312"];
            labGasPress.Text = Words["313"];
            labMapPress.Text = Words["314"];
            labTempRed.Text = Words["315"];
            labTempGas.Text = Words["316"];
            labRPM.Text = Words["318"];
            labGasLevel.Text = Words["317"];
            labRPMSource.Text = Words["319"];
            labLambda1.Text = Words["324"] + "1";
            labLambda2.Text = Words["324"] + "2";
            OBDSETBtn.Visible = Services.Device.DeviceInfo.HardInof.OBDEn;
        }
        Dictionary<String, String> Words
        {
            get { return Services.Lang.CurrentWords; }
        }
        #endregion
      //  int xy=0;
        public void ShowRealyData(Models.Feedback.RealTimeData model)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Reset();
            //watch.Start();
            rtlGas.ValueText = model.GasesTime.ToString("N02");
            rtlGasLevel.ValueText = model.GasLevel.ToString("N02");
            rtlPetrol.ValueText = model.PetrolsTime.ToString("N02");
            rtlRPM.ValueText = model.RPM.ToString();//model.RPM.ToString()  (xy++).ToString()
            rtlTempRed.ValueText = model.TempRed.ToString();
            if (Services.Stroe.ECUSetting.Lambda1Type != Models.Enums.LambdaTypes.NoConnection)
                rtlLambda1.ValueText = model.Lambda[0].ToString("N02");//LDC
            else
                rtlLambda1.ValueText = "n.a.";
            if (Services.Stroe.ECUSetting.Lambda2Type != Models.Enums.LambdaTypes.NoConnection)
                 rtlLambda2.ValueText = model.Lambda[1].ToString("N02");
            else
                rtlLambda2.ValueText = "n.a.";
            if (model.TempGas == -128)
            {
                String str = "--";
                rtlTempGas.ValueText = str;
                rtlGasPress.ValueText = str;
                rtlMapPress.ValueText = str;
            }
            else
            {
                rtlTempGas.ValueText = model.TempGas.ToString();
                rtlGasPress.ValueText = model.GasPress.ToString("N02");
                rtlMapPress.ValueText = model.MAPPress.ToString("N02");

            }
            tpbLED1.Toggle(!model.LEDLight[0]);
            tpbLED2.Toggle(!model.LEDLight[1]);
            tpbLED3.Toggle(!model.LEDLight[2]);
            tpbLED4.Toggle(!model.LEDLight[3]);
            tpbLED5.Toggle(!model.LEDLight[4]);
            tpbLED6.Toggle(!model.LEDLight[5]);
            tpbLED7.Toggle(!model.LEDLight[6]);
            tpbIgnitionStatus.Toggle(!model.IgnitionStatus);
            tpbSolenoidValveStatus.Toggle(!model.SolenoidValveStatus);

            //switch (model.RPMSource)//LDC删除20160601
            //{

            //    case IGT.Models.Enums.RPMSources.Injector:
            //        labRPMSource.Text = Words["319"] + ": " + Words["320"];
            //        break;
            //    case IGT.Models.Enums.RPMSources.Coil:
            //        labRPMSource.Text = Words["319"] + ": " + Words["321"];
            //        break;
            //    case IGT.Models.Enums.RPMSources.CamshaftSensor:
            //        labRPMSource.Text = Words["319"] + ": " + Words["322"];
            //        break;
            //    case IGT.Models.Enums.RPMSources.Auto:
            //        labRPMSource.Text = Words["319"] + ": " + Words["323"];
            //        break;


            //    //case IGT.Models.Enums.RPMSources.OneCoil:
            //    //    labRPMSource.Text = Words["319"] + ": " + Words["320"];
            //    //    break;
            //    //case IGT.Models.Enums.RPMSources.TwoCoils:
            //    //    labRPMSource.Text = Words["319"] + ": " + Words["321"];
            //    //    break;
            //    //case IGT.Models.Enums.RPMSources.RPMSensor:
            //    //    labRPMSource.Text = Words["319"]+": " + Words["322"];
            //    //    break;
            //    //case IGT.Models.Enums.RPMSources.RPMSensor:
            //    //    labRPMSource.Text = Words["319"] + ": " + Words["323"];
            //        //break;
            //}


            //if (SharedValueHelper.KeySwitchState.HasValue)
            //{
            //    SharedValueHelper.KeySwitchState = !(model.GasesTime > 0);
            //    tpbSwitchKey.Toggle(SharedValueHelper.KeySwitchState.Value);
            //}
            SharedValueHelper.KeySwitchState =!( model.LEDLight[5] && !model.LEDLight[6]);
            tpbSwitchKey.Toggle(SharedValueHelper.KeySwitchState.Value);
            if (CurrentSettingPanel != null)
                CurrentSettingPanel.HandlerRealyTimeData(model);
            //watch.Stop();
            //Debug.WriteLine("time"+watch.ElapsedMilliseconds.ToString());
        }

        private UserControls.SettingPanels.ISettingPanel GetPanelAndShow(String name)
        {
            if (CurrentSettingPanel != null)
            {
                CurrentSettingPanel.Hide();
                var temp = CurrentSettingPanel as UserControls.SettingPanels.DiagramPanel;
                if (temp != null) temp.PanelUnLoad();
            }
            switch (name)
            {
                case "btn1":
                    btn2.BaseColor = Color.White;
                    btn2.ButtonColor = Color.White;
                    btn2.BackColor = Color.Transparent;
                    btn1.BackColor = Color.Transparent;  
                    btn1.BaseColor = Color.FromArgb(245,130,31);
                    btn1.ButtonColor = Color.FromArgb(245,130,31);
                    btn8.ForeColor = Color.FromArgb(245, 130, 31);
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUSetting);
                    break;
                case "btn2":
                    System.Diagnostics.Debug.WriteLine("高级设置");
                    btn1.BaseColor = Color.White;
                    btn1.ButtonColor = Color.White;
                    btn2.BackColor = Color.Transparent;
                    btn1.BackColor = Color.Transparent;
                    btn2.BaseColor = Color.FromArgb(245,130,31);
                    btn2.ButtonColor = Color.FromArgb(245,130,31);
                    btn8.ForeColor = Color.FromArgb(245, 130, 31);
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUSetting);
                 //   Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.InjectorCorrection);
                    break;
                case "btn3":
                    btn1.Visible = false;
                    btn2.Visible = false;
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUSetting);
                    break;
                case "btn4":
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.MAPCalibrationParams);
                    break;
                case "MAPbtn":
                    btn1.Visible = false;
                    btn2.Visible = false;
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.CorrectionSetting);//LDC MAP删除
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.MAPCalibrationParams);
                  //   Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUCorrectionParams);//LDC MAP删除
                    break;
                case "btn7":
                    btn1.Visible = false;
                    btn2.Visible = false;
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUSetting);
                    break;
                case "btn8":
                    btn1.Visible = true;
                    btn2.Visible = true;
                    btn2.BaseColor = Color.White;
                    btn2.ButtonColor = Color.White;
                    btn2.BackColor = Color.Transparent;
                    btn1.BackColor = Color.Transparent;
                    btn1.BaseColor = Color.FromArgb(245,130,31);
                    btn1.ButtonColor = Color.FromArgb(245,130,31);
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUSetting);
                    break;
                case "btn9"://附加设定
                    btn1.Visible = false;
                    btn2.Visible = false;
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.Additional);
                    break;
                case "OBDSETBtn":
                    btn1.Visible = false;
                    btn2.Visible = false;
                    //    AdvancedSETbtn.ForeColor = Color.FromArgb(46, 106, 179);
                    Services.Stroe.WaitReadyIfPLC(IGT.Service.Storage.SettingItems.ECUSetting);
                    break;
            }
            if (!SettingPanelsDic.ContainsKey(name))
            {
                switch (name)
                {
                    case "btn1":
                        CurrentSettingPanel = new UserControls.SettingPanels.CarParametersSettings();
                        break;
                    case "btn2":
                        CurrentSettingPanel = new UserControls.SettingPanels.SwitchSettingsPanel();
                        break;
                    case "btn3":
                        CurrentSettingPanel = new UserControls.SettingPanels.SensorsSettingsPanel();
                        break;
                    case "btn4":
                        CurrentSettingPanel = new UserControls.SettingPanels.MAPCalibrationSettingPanel();
                        break;
                    case "MAPbtn":
                        CurrentSettingPanel = new UserControls.SettingPanels.DiagramPanel();
                        break;
                    case "btn7":
                        CurrentSettingPanel = new UserControls.SettingPanels.AdvancedSettingPanel();
                        break;
                    case "btn8":
                         CurrentSettingPanel = new UserControls.SettingPanels.CarParametersSettings(); 
                        break;
                    case "btn9":
                        CurrentSettingPanel = new UserControls.SettingPanels.AdditionalSettingsPanel();
                        Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetAdditionalInfo);
                        break;
                    case "OBDSETBtn":
                        CurrentSettingPanel = new UserControls.SettingPanels.OBDSettingPanel();
                        break;

                    default:
                        throw new ArgumentException("name");
                }
                (CurrentSettingPanel as Control).Dock = DockStyle.Fill;
                SettingPanelsDic.Add(name, CurrentSettingPanel);
                panelSettings.Controls.Add(CurrentSettingPanel as Control);
            }
            else
                CurrentSettingPanel = SettingPanelsDic[name];
            CurrentSettingPanel.ShowData();
            CurrentSettingPanel.Show();
            return CurrentSettingPanel;
        }



        private void SetMenuCurrent(VistaButton curButton)
        {
            SetCMenuState(btn1);
            SetCMenuState(btn2);
            SetCMenuState(btn3);
            SetCMenuState(MAPbtn);
            SetCMenuState(btn7);
            SetCMenuState(btn8);
            SetCMenuState(btn9);
            SetCMenuState(OBDSETBtn);

            SetCMenuState(curButton, false);
        }
        private void SetCMenuState(VistaButton btn, bool nomalORCurrent = true)
        {
            if (nomalORCurrent)
            {
                btn.ForeColor = Color.Black;
                btn.Enabled = true;
            }
            else if (btn != btn1 && btn != btn2)
            {
                btn.ForeColor = Color.FromArgb(245, 130, 31);
            }


        }
        /// <summary>
        /// 画分割线
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 6);
            e.Graphics.DrawLine(redPen, 0, this.ClientSize.Height - 112, this.ClientSize.Width, this.ClientSize.Height - 112);
            redPen.Dispose();
        }
        UserControls.SettingPanels.ISettingPanel CurrentSettingPanel;
        Dictionary<String, UserControls.SettingPanels.ISettingPanel> SettingPanelsDic = new Dictionary<string, UserControls.SettingPanels.ISettingPanel>();

    }
}
