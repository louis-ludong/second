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
    /// 自动标定页
    /// </summary>
    public partial class AutoCalibration : UserControl, IPage
    {
        public AutoCalibration()
        {
            IsReadly = false;
            InitializeComponent();
            rtlGas.BackColor = Color.Transparent;
            rtlGasPress.BackColor = Color.Transparent;
            rtlLambda1.BackColor = Color.Transparent;
            rtlLambda2.BackColor = Color.Transparent;
            rtlMapPress.BackColor = Color.Transparent;
            rtlPetrol.BackColor = Color.Transparent;
            btnStart.BackColor = Color.White ;
            btnStop.BackColor = Color.White ;
            ApplyLang();
        }
        private void AutoCalibration_Load(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).MainMenu.HideAllMenus();
        //    (this.ParentForm as MainForm).MainMenu.ShowGraphMenuButton = true;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            labTipCalibration.Text = LangWords["642"];//615=按"开始"自动标定
            WaitExit4CalbrationState = false;
            var model = cbAllWork.Checked ? Models.Enums.AutoCalibrationCMD.AutoFull : Models.Enums.AutoCalibrationCMD.Auto;
            Services.Device.SendAndRead("AutoCalibrationPage", UIHelper.CancelBit_AutoCalibPage, Service.PLC.InstructionSet.SetAutoCalibrationCMD
                , Service.PLC.ValueConvert.AutoCalibrationCMDValue(model));
            Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetAutoCalibrationDetails);
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            pBarCalibration.Value = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetAutoCalibrationDetails);
            Services.Device.SendAndRead("AutoCalibrationPage", UIHelper.CancelBit_AutoCalibPage, Service.PLC.InstructionSet.SetAutoCalibrationCMD
                , Service.PLC.ValueConvert.AutoCalibrationCMDValue(Models.Enums.AutoCalibrationCMD.Exit));
            btnStart.Enabled = true;
            pBarCalibration.Value = 0;
            labTipCalibration.Text = LangWords["615"];//615=按"开始"自动标定
        }

        private void tpbSwitchKey_Click(object sender, EventArgs e)
        {
            Services.Device.SendAndRead("AutoCalibrationPage", UIHelper.CancelBit_AutoCalibPage, Service.PLC.InstructionSet.SetKeySwitch);
            //if (!SharedValueHelper.KeySwitchState.HasValue)
            //    SharedValueHelper.KeySwitchState = true;
            //SharedValueHelper.KeySwitchState = !SharedValueHelper.KeySwitchState.Value;
            //tpbSwitchKey.Toggle(SharedValueHelper.KeySwitchState.Value);
        }
        #region IPage 成员
        public bool IsReadly { get; private set; }
        public void LoadPage()
        {
            Services.RealyDataPre.End();
            if (Services.RealyDataPre.RealData != null)
                HandleRealyTimeData(Services.RealyDataPre.RealData);
            IsReadly = true;
            Change4Connect();
        }

        public void UnLoadPage()
        {
            IsReadly = false;
            Services.RealyDataPre.Begin();
            Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetAutoCalibrationDetails);
            this.Dispose();
        }
        public void ProcessRealyTimeData(Models.Feedback.RealTimeData model)
        {
            if(IsReadly)
                HandleRealyTimeData(model);
        }
        public void ProcessAutoCalbrationDetails(Models.Feedback.AutoCalibrationDetails model)
        {
            if (IsReadly)
                HandleCalbrationState(model);
        }
        public void ProcessDiagnosisDetails(Models.Feedback.DiagnosisDetails model) { }
        public void Change4Connect()
        {
            if (!IsReadly) return;
            bool enable = Services.Device.Connect.IsConnected;
            btnStart.Enabled = enable;
            tpbSwitchKey.Enabled = enable;
        }

        public Control AsControl{get { return this; }}

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
            labGas1.Font = new Font(fontFamily, labGas1.Font.Size);
            labPetrol1.Font = new Font(fontFamily, labPetrol1.Font.Size);
            labGasPress.Font = new Font(fontFamily, labGasPress.Font.Size);
            labMapPress.Font = new Font(fontFamily, labMapPress.Font.Size);
            labGas.Font = new Font(fontFamily, labGas.Font.Size);
            labRed.Font = new Font(fontFamily, labRed.Font.Size);
            labeInje.Font = new Font(fontFamily, labeInje.Font.Size);
            labCorrect.Font = new Font(fontFamily, labCorrect.Font.Size);
            labTooBig.Font = new Font(fontFamily, labTooBig.Font.Size);
            labTooSmall.Font = new Font(fontFamily, labTooSmall.Font.Size);
            labTipCalibration.Font = new Font(fontFamily, labTipCalibration.Font.Size);
            btnStart.Font = new Font(fontFamily, btnStart.Font.Size);
            btnStop.Font = new Font(fontFamily, btnStop.Font.Size);
            cbAllWork.Font = new Font(fontFamily, cbAllWork.Font.Size);
            labLambda1.Font = new Font(fontFamily, labLambda1.Font.Size);
            labLambda2.Font = new Font(fontFamily, labLambda2.Font.Size);

            this.Text = LangWords["601"];
            labGas1.Text = LangWords["603"];
            labPetrol1.Text = LangWords["602"];
            labGasPress.Text = LangWords["604"];
            labMapPress.Text = LangWords["605"];
            labGas.Text = LangWords["607"];
            labRed.Text = LangWords["606"];
            labeInje.Text = LangWords["608"];
            labCorrect.Text = LangWords["613"];
            labTooBig.Text = LangWords["611"];
            labTooSmall.Text = LangWords["612"];
            labTipCalibration.Text = LangWords["615"];
            btnStart.Text = LangWords["610"];
            btnStop.Text = LangWords["609"];
            cbAllWork.Text = LangWords["614"];
            labLambda1.Text = String.Format(LangWords["633"], "1");
            labLambda2.Text = String.Format(LangWords["633"], "2");
            textBox1.Text = LangWords["640"];
            int temp=0;
            for(int i=0;i<12;i++)
                for (int j = 0; j < 12; j++)
                {
                    temp += Store.MAPCalibrationParams.MAPValues[i][j];
                }
            temp = temp / 144;
            injectorsMeasurement1.Value = temp;
        }

        #endregion

        #region Show
        bool WaitExit4CalbrationState = false;
        void HandleCalbrationState(Models.Feedback.AutoCalibrationDetails model)
        {
            if (btnStop.Enabled == false) return;
            //if (model.State == Models.Enums.AutoCalibrationState.Error)
            //    model.State = Models.Enums.AutoCalibrationState.Finished;
            switch (model.State)
            {
                //case IGT.Models.Enums.AutoCalibrationState.NotEnter:
                case 0x00://还没进入自动标定
                    if (WaitExit4CalbrationState == false)
                    {
                        pBarCalibration.Value = 0;
                     //   injectorsMeasurement1.Value = -10;
                        labTipCalibration.Text = LangWords["615"];//615=按"开始"自动标定
                    }
                    else
                    {
                        Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetAutoCalibrationDetails);
                        WaitExit4CalbrationState = false;
                        ShowCalibarationResult(model);
                     //   injectorsMeasurement1.Value = -10;
                        btnStop.Enabled = false;
                        btnStart.Enabled = true;
                        pBarCalibration.Value = 100;
                        MessageBox.Show(LangWords["632"], "");//632=标定出错
                    }
                    break;
                //case IGT.Models.Enums.AutoCalibrationState.WaitEngineStart:
                case 0x01:
                    pBarCalibration.Value = model.State*10;
                    labTipCalibration.Text = LangWords["616"];//616=请启动发动机
                    break;
                case 0x02:
                    pBarCalibration.Value = model.State * 10;
                    labTipCalibration.Text = LangWords["617"];//617=等待减压器温度达到50℃  加油到2500-3100转
                    break;
                case 0x05:
                    pBarCalibration.Value = model.State * 10;
                    labTipCalibration.Text = LangWords["619"];//619=正在自动标定，保持发动机转速在2500-3100转
                    break;
                //case IGT.Models.Enums.AutoCalibrationState.Error:
                //    if (WaitExit4CalbrationState == true) return;
                //    WaitExit4CalbrationState = true;
                //    var mode = cbAllWork.Checked ? Models.Enums.AutoCalibrationCMD.AutoFull : Models.Enums.AutoCalibrationCMD.Auto;
                //    Services.Device.SendAndRead("AutoCalibrationPage", UIHelper.CancelBit_AutoCalibPage, Service.PLC.InstructionSet.SetAutoCalibrationCMD
                //        , Service.PLC.ValueConvert.AutoCalibrationCMDValue(mode));
                //    break;
                case 0x0c:
                    if (WaitExit4CalbrationState == true) return;
                    WaitExit4CalbrationState = true;
                    btnStop.Enabled = false;
                    btnStart.Enabled = true;
                    //Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetAutoCalibrationDetails);
                    //var mode2 = cbAllWork.Checked ? Models.Enums.AutoCalibrationCMD.AutoFull : Models.Enums.AutoCalibrationCMD.Auto;
                    //Services.Device.SendAndRead("AutoCalibrationPage", UIHelper.CancelBit_AutoCalibPage, Service.PLC.InstructionSet.SetAutoCalibrationCMD
                    //    , Service.PLC.ValueConvert.AutoCalibrationCMDValue(mode2));
                    //Services.Stroe.LoadItem(Service.Storage.SettingItems.ECUCorrectionParams);
                    if (model.AutoCalibrationResult != 0)
                    {
                        ShowCalibarationResult(model);//标定结果
                        break;
                    }
                    Services.Stroe.LoadItem(Service.Storage.SettingItems.MAPCalibrationParams);
               //     injectorsMeasurement1.Value = -10;
                    int temp=0;
                    for(int i=0;i<12;i++)
                        for (int j = 0; j < 12; j++)
                        {
                            temp += Store.MAPCalibrationParams.MAPValues[i][j];
                        }
                    temp = temp / 144;
                    injectorsMeasurement1.Value = temp;
                    pBarCalibration.Value = 100;
                    ShowCalibarationResult(model);//标定结果
                    Services.ActionMsg.Enqueue(Actions.Goto);
                    MessageBox.Show(LangWords["631"]);
                    this.ParentForm.Close();
                    break;
                default: break;

            }
        }

        private void ShowCalibarationResult(Models.Feedback.AutoCalibrationDetails model)
        {

            if (model.AutoCalibrationResult == 0)
                labTipCalibration.Text = LangWords["631"];
            else if ((model.AutoCalibrationResult&0x01)==0x01)
                labTipCalibration.Text = LangWords["643"];
            else if ((model.AutoCalibrationResult & 0x02) == 0x02)
                labTipCalibration.Text = LangWords["644"];
            else if ((model.AutoCalibrationResult & 0x04) == 0x04)
                labTipCalibration.Text = LangWords["645"];
            else if ((model.AutoCalibrationResult & 0x08) == 0x08)
                labTipCalibration.Text = LangWords["623"];
            else if ((model.AutoCalibrationResult & 0x40) == 0x40)
                labTipCalibration.Text = LangWords["646"];
            else
                labTipCalibration.Text = LangWords["626"];
            //switch (model.AutoCalibrationResult)
            //{
            //    case IGT.Models.Enums.AutoCalibrationResult.Successed:
            //        if (model.InjectorBoreValue < -50)
            //            labTipCalibration.Text = LangWords["627"];
            //        else if (model.InjectorBoreValue < -20)
            //            labTipCalibration.Text = LangWords["628"];
            //        else if (model.InjectorBoreValue < 20)
            //            labTipCalibration.Text = LangWords["631"];
            //        else if (model.InjectorBoreValue < 50)
            //            labTipCalibration.Text = LangWords["629"];
            //        else
            //            labTipCalibration.Text = LangWords["630"];
            //        break;
            //    case IGT.Models.Enums.AutoCalibrationResult.NoMAPSensor:
            //        labTipCalibration.Text = LangWords["620"];
            //        break;
            //    case IGT.Models.Enums.AutoCalibrationResult.MAPPressLower:
            //        labTipCalibration.Text = LangWords["621"];
            //        break;
            //    case IGT.Models.Enums.AutoCalibrationResult.MAPPressHigher:
            //        labTipCalibration.Text = LangWords["622"];
            //        break;
            //    case Models.Enums.AutoCalibrationResult.RPMLower:
            //        labTipCalibration.Text = LangWords["623"];
            //        break;
            //    case Models.Enums.AutoCalibrationResult.RPMHigher:
            //        labTipCalibration.Text = LangWords["624"];
            //        break;
            //    case IGT.Models.Enums.AutoCalibrationResult.PertolSignalError:
            //        labTipCalibration.Text = LangWords["625"];
            //        break;
            //    case Models.Enums.AutoCalibrationResult.UnknowageError:
            //        labTipCalibration.Text = LangWords["626"];
            //        break;
            //}
        }

        void HandleRealyTimeData(Models.Feedback.RealTimeData model)
        {
            dasTempGasTemp.Value = model.TempGas;
            dasTempRedTemp.Value = model.TempRed;
            dasTempRedTemp.Value = model.TempRed;
            dasTempGasTemp.Value = model.TempGas;
            daSCGRPM.Value = model.RPM;
            rtlGas.ValueText = model.GasesTime.ToString("N02");
            rtlGasPress.ValueText = model.GasPress.ToString("N02");
            rtlMapPress.ValueText = model.MAPPress.ToString("N02");
            rtlPetrol.ValueText = model.PetrolsTime.ToString("N02");
            if (Services.Stroe.ECUSetting.Lambda1Type != Models.Enums.LambdaTypes.NoConnection)
                rtlLambda1.ValueText = model.Lambda[0].ToString("N02");//LDC
            else
                rtlLambda1.ValueText = "n.a.";
            if (Services.Stroe.ECUSetting.Lambda2Type != Models.Enums.LambdaTypes.NoConnection)
                rtlLambda2.ValueText = model.Lambda[1].ToString("N02");
            else
                rtlLambda2.ValueText = "n.a.";
            tpbLED1.Toggle(!model.LEDLight[0]);
            tpbLED2.Toggle(!model.LEDLight[1]);
            tpbLED3.Toggle(!model.LEDLight[2]);
            tpbLED4.Toggle(!model.LEDLight[3]);
            tpbLED5.Toggle(!model.LEDLight[4]);
            tpbLED6.Toggle(!model.LEDLight[5]);
            tpbLED7.Toggle(!model.LEDLight[6]);
            tpbIgnitionStatus.Toggle(!model.IgnitionStatus);
            tpbSolenoidValveStatus.Toggle(!model.SolenoidValveStatus);
            //if (!SharedValueHelper.KeySwitchState.HasValue)
            //{
            //    SharedValueHelper.KeySwitchState = !(model.GasesTime > 0);
            //    tpbSwitchKey.Toggle(SharedValueHelper.KeySwitchState.Value);
            //}
            SharedValueHelper.KeySwitchState = !(model.LEDLight[5] && !model.LEDLight[6]);
            tpbSwitchKey.Toggle(SharedValueHelper.KeySwitchState.Value);


        }
        #endregion
        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color .FromArgb (245,130,31)), 6);
            e.Graphics.DrawLine(redPen, 0, this.ClientSize.Height - 149, this.ClientSize.Width, this.ClientSize.Height - 149);
            redPen.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LangWords["640"] = textBox1.Text;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    injectorsMeasurement1.Value--;
        //    //label2.Text = injectorsMeasurement1.Value.ToString();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    injectorsMeasurement1.Value++;
        //  //  label2.Text = injectorsMeasurement1.Value.ToString();
        //}
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }
    }
}
