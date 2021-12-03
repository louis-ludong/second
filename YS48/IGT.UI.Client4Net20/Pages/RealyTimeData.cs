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
    /// 实时数据页
    /// </summary>
    public partial class RealyTimeData : UserControl, IPage
    {
        public RealyTimeData()
        {
            IsReadly = false;
            InitializeComponent();
           // gboxODB.Visible = Services.Device.DeviceInfo.HardInof.ODB;
           // gBoxAdp.Visible = Services.Device.DeviceInfo.HardInof.AutoAdaptive;
            rtlGas.BackColor = Color.Transparent;
            rtlGasPress.BackColor = Color.Transparent;
            rtlLambda1.BackColor = Color.Transparent;
            rtlLambda2.BackColor = Color.Transparent;
            rtlMapPress.BackColor = Color.Transparent;
            rtlPetrol.BackColor = Color.Transparent;
            rtdlAAdaptiveC.BackColor = Color.Transparent;
            rtdlAdaptiveOffset.BackColor = Color.Transparent;
            rtdlOBDBank1Long.BackColor = Color.Transparent;
            rtdlOBDBank1Short.BackColor = Color.Transparent;
            rtdlGasCorrection.BackColor = Color.Transparent;
            rtdlBank1Oxygen.BackColor = Color.Transparent;
            ApplyLang();
        }

        public void RealyTimeData_Load(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).MainMenu.HideAllMenus();
          //  (this.ParentForm as MainForm).MainMenu.ShowGraphMenuButton = true;//导出按钮不显示

            Services.Device.GotSelfAdaptationOR_ODBState += Device_GotSelfAdaptationOR_ODBState;
        }
        private void tpbSwitchKey_Click(object sender, EventArgs e)
        {
            Services.Device.SendAndRead("RealyTimeDataPage", UIHelper.CancelBit_RealyTimeDataPage, Service.PLC.InstructionSet.SetKeySwitch);
            //if (!SharedValueHelper.KeySwitchState.HasValue)
            //    SharedValueHelper.KeySwitchState = true;
            //SharedValueHelper.KeySwitchState = !SharedValueHelper.KeySwitchState.Value;
            //tpbSwitchKey.Toggle(SharedValueHelper.KeySwitchState.Value);
        }
        void Device_GotSelfAdaptationOR_ODBState(SerialPortsUtils.Agents.Models.AgentTaskResult result)
        {
            if (result.Successed && IsReadly)
            {
                try
                {
                    if (Services.Device.DeviceInfo.HardInof.OBDEn)
                    {
                        this.Invoke(new UIHelper.UIINvkoeParam1<Models.Feedback.OBDState>(ProcessODBState)
                            , Service.PLC.DTOUitils.ToODBState(result.ExecuteResult));
                    }
                    if (Services.Device.DeviceInfo.HardInof.AutoAdaptive)
                    {
                        this.Invoke(new UIHelper.UIINvkoeParam1<Models.Feedback.AdaptiveState>(ProcessAdaptiveState)
                            , Service.PLC.DTOUitils.ToAdaptiveState(result.ExecuteResult));
                    }
                }
                catch (Exception) { }
            }
        }
        private void ProcessODBState(Models.Feedback.OBDState model)
        {
            switch (model.ConnectState)
            {
                case IGT.Models.Enums.OBDConnectState.Init:
                    labOBDConnectValue.Text = LangWords["419"]; break;
                case IGT.Models.Enums.OBDConnectState.Connecting:
                    labOBDConnectValue.Text = LangWords["420"]; break;
                case IGT.Models.Enums.OBDConnectState.Connected:
                    labOBDConnectValue.Text = LangWords["421"]; break;
                case IGT.Models.Enums.OBDConnectState.NoConnect:
                    labOBDConnectValue.Text = LangWords["422"]; break;
                case IGT.Models.Enums.OBDConnectState.Error:
                    labOBDConnectValue.Text = LangWords["423"]; break;
            }
            labOBDErrorValue.Text = model.FailuresCount == 0 ? LangWords["426"] : LangWords["425"];
            rtdlOBDBank1Short.ValueText = model.Bank1ShortCorrection.ToString();
            rtdlOBDBank1Long.ValueText = model.Bank1LongCorrection.ToString();
            rtdlBank1Oxygen.ValueText = model.Bank1Oxygen.ToString();
            rtdlGasCorrection.ValueText = model.GasCorrection.ToString();
        }
        private void ProcessAdaptiveState(Models.Feedback.AdaptiveState model)
        {
            rtdlAAdaptiveC.ValueText = model.ShortCorrection.ToString();
            rtdlAdaptiveOffset.ValueText = model.Offset.ToString();
        }

        #region IPage 成员
        public bool IsReadly { get; private set; }
        public void LoadPage()
        {
            Services.RealyDataPre.End();
            if (Services.RealyDataPre.RealData != null)
                HandleRealyTimeData(Services.RealyDataPre.RealData);
            Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetSelfAdaptationOR_ODBState);
            IsReadly = true;
        }

        public void UnLoadPage()
        {
            IsReadly = false;
            Services.Device.GotSelfAdaptationOR_ODBState -= Device_GotSelfAdaptationOR_ODBState;
            Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetSelfAdaptationOR_ODBState);
            Services.RealyDataPre.Begin();
            this.Dispose();
        }
        public void ProcessRealyTimeData(Models.Feedback.RealTimeData model)
        {
            if(IsReadly)
                HandleRealyTimeData(model);
        }
        public void ProcessAutoCalbrationDetails(Models.Feedback.AutoCalibrationDetails model) { }
        public void ProcessDiagnosisDetails(Models.Feedback.DiagnosisDetails model) { }
        public void Change4Connect()
        {
            tpbSwitchKey.Enabled = Services.Device.Connect.IsConnected;
        }

        public Control AsControl { get { return this; } }

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
            labLambda1.Font = new Font(fontFamily, labLambda1.Font.Size);
            labLambda2.Font = new Font(fontFamily, labLambda2.Font.Size);
            gBoxAdp.Font = new Font(fontFamily, gBoxAdp.Font.Size);
            gboxODB.Font = new Font(fontFamily, gboxODB.Font.Size);
            labAC.Font = new Font(fontFamily, labAC.Font.Size);
            labAOffset.Font = new Font(fontFamily, labAOffset.Font.Size);
            labOBDConnect.Font = new Font(fontFamily, labOBDConnect.Font.Size);
            labODBError.Font = new Font(fontFamily, labODBError.Font.Size);
            labODBBank1Short.Font = new Font(fontFamily, labODBBank1Short.Font.Size);
            labOBDBank1Long.Font = new Font(fontFamily, labOBDBank1Long.Font.Size);
            labLambdaPost.Font = new Font(fontFamily, labLambdaPost.Font.Size);
            labGasCorrection.Font = new Font(fontFamily, labGasCorrection.Font.Size);
            labOBDErrorValue.Font = new Font(fontFamily, labOBDErrorValue.Font.Size);
            labOBDConnectValue.Font = new Font(fontFamily, labOBDConnectValue.Font.Size);

            this.Text = LangWords["401"];
            labGas1.Text = LangWords["403"];
            labPetrol1.Text = LangWords["402"];
            labGasPress.Text = LangWords["404"];
            labMapPress.Text = LangWords["405"];
            labGas.Text = LangWords["407"];
            labRed.Text = LangWords["406"];
            labeInje.Text = LangWords["408"];
            labCorrect.Text = LangWords["411"];
            labTooBig.Text = LangWords["409"];
            labTooSmall.Text = LangWords["410"];
            labLambda1.Text = String.Format(LangWords["412"], "1");
            labLambda2.Text = String.Format(LangWords["412"], "2");
            gBoxAdp.Text = LangWords["414"];
            gboxODB.Text = LangWords["415"];
            labAC.Text = LangWords["416"];
            labAOffset.Text = LangWords["417"];
            labOBDConnect.Text = LangWords["418"];
            labODBError.Text = LangWords["424"];
            labODBBank1Short.Text = LangWords["427"];
            labOBDBank1Long.Text = LangWords["428"];
            labLambdaPost.Text = LangWords["432"];
            labGasCorrection.Text = LangWords["433"];
            textBox2.Text = LangWords["641"];
            labOBDErrorValue.Text = LangWords["413"];
            labOBDConnectValue.Text = LangWords["413"];
            int temp = 0;
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                {
                    temp += Store.MAPCalibrationParams.MAPValues[i][j];
                }
            temp = temp / 144;
            injectorsMeasurement1.Value = temp;
        }
        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }
        #endregion

        #region Show


        void HandleRealyTimeData(Models.Feedback.RealTimeData model)
        {
            dasTempGasTemp.Value = model.TempGas;
            dasTempRedTemp.Value = model.TempRed;
            dasTempRedTemp.Value = model.TempRed;
            dasTempGasTemp.Value = model.TempGas;
            daSCGRPM.Value = model.RPM ;
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color .FromArgb (245,130,31)), 6);
            e.Graphics.DrawLine(redPen, 0, this.ClientSize.Height - 149, this.ClientSize.Width, this.ClientSize.Height - 149);
            redPen.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LangWords["641"] = textBox2.Text;
        }
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }
    }
}
