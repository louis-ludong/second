using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    /// <summary>
    /// 燃气切换Panel
    /// </summary>
    public partial class SwitchSettingsPanel : UserControl, Service.Language.IMultLang, ISettingPanel
    {
        public SwitchSettingsPanel()
        {
            InitializeComponent();
            ApplyLang();
        }

        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }
        public void ShowData()
        {
            IsInit = true;
            FixOverData();
            numuPressError.Value = Store.ECUSetting.PressErrorTime;
            numuMiniGasTemp.Value = Store.ECUSetting.MiniGasTemp;
            numuMinimumPress.Value = Convert.ToDecimal(Store.ECUSetting.MinimumPress);
            numuOperationalPress.Value = Convert.ToDecimal(Store.ECUSetting.OperationalPress);
            cbInjetPositiveDrive.Checked = ((Store.ECUSetting.ExtraData[4] & 0x01) == 0x01);
            cbStartAndStop.Checked = Store.ECUSetting.StartAndStop;
            cbValvetronik.Checked = Store.ECUSetting.Valvetronik;
            cBStartOnGas.Checked = Store.ECUSetting.SwitchMode == Models.Enums.SwitchModes.StartOnGas;
            if (Store.ECUSetting.AnticipateInjSetting[0] != 0xf0)
                cBAnticipate.Checked = Store.ECUSetting.AnticipateInjSetting[0] == 0x01;
            else
                cBAnticipate.Checked = false;
            cbBackTransition.Checked = Store.ECUSetting.BackTransitionTm != 0;
            numBackTransitionTm.Enabled = cbBackTransition.Checked;
            if (Store.ECUSetting.BackTransitionTm == 0xf000)
            {
                cbBackTransition.Checked = false;
                cbBackTransition.Enabled = false;
                numBackTransitionTm.Enabled = false;
                labcbBackTransition.Enabled = false;
            }
            else
                numBackTransitionTm.Value = Store.ECUSetting.BackTransitionTm;
            if (Store.ECUSetting.GasFillTime != null)
                numGasFillTime.Value = (decimal)Store.ECUSetting.GasFillTime / 10;
            else
                numGasFillTime.Visible = false;
            IsInit = false;
        }
        void FixOverData()
        {
            bool change = Store.ECUSetting.PressErrorTime > Convert.ToInt32(numuPressError.Maximum) || Store.ECUSetting.PressErrorTime < Convert.ToInt32(numuPressError.Minimum) ||
            Store.ECUSetting.MiniGasTemp > Convert.ToSByte(numuMiniGasTemp.Maximum) || Store.ECUSetting.MiniGasTemp < Convert.ToSByte(numuMiniGasTemp.Minimum) ||
            Store.ECUSetting.MinimumPress > Convert.ToSingle(numuMinimumPress.Maximum) || Store.ECUSetting.MinimumPress < Convert.ToSingle(numuMinimumPress.Minimum) ||
            Store.ECUSetting.OperationalPress > Convert.ToSingle(numuOperationalPress.Maximum) || Store.ECUSetting.OperationalPress < Convert.ToSingle(numuOperationalPress.Minimum);
            if (Store.ECUSetting.PressErrorTime > Convert.ToInt32(numuPressError.Maximum))
                Store.ECUSetting.PressErrorTime = Convert.ToInt32(numuPressError.Maximum);
            if (Store.ECUSetting.PressErrorTime < Convert.ToInt32(numuPressError.Minimum))
                Store.ECUSetting.PressErrorTime = Convert.ToInt32(numuPressError.Minimum);
            if (Store.ECUSetting.MiniGasTemp > Convert.ToSByte(numuMiniGasTemp.Maximum))
                Store.ECUSetting.MiniGasTemp = Convert.ToSByte(numuMiniGasTemp.Maximum);
            if (Store.ECUSetting.MiniGasTemp < Convert.ToSByte(numuMiniGasTemp.Minimum))
                Store.ECUSetting.MiniGasTemp = Convert.ToSByte(numuMiniGasTemp.Minimum);
            if (Store.ECUSetting.MinimumPress > Convert.ToSingle(numuMinimumPress.Maximum))
                Store.ECUSetting.MinimumPress = Convert.ToSingle(numuMinimumPress.Maximum);
            if (Store.ECUSetting.MinimumPress < Convert.ToSingle(numuMinimumPress.Minimum))
                Store.ECUSetting.MinimumPress = Convert.ToSingle(numuMinimumPress.Minimum);
            if (Store.ECUSetting.OperationalPress > Convert.ToSingle(numuOperationalPress.Maximum))
                Store.ECUSetting.OperationalPress = Convert.ToSingle(numuOperationalPress.Maximum);
            if (Store.ECUSetting.OperationalPress < Convert.ToSingle(numuOperationalPress.Minimum))
                Store.ECUSetting.OperationalPress = Convert.ToSingle(numuOperationalPress.Minimum);
            if (change)
                Services.Stroe.SaveChanges();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (IsInit == true) return;
            var btn = sender as Button;
            switch (btn.Name)
            {
                case "btnInjectorParam":
                    InjectorSetForm form = new InjectorSetForm();
                    form.ShowDialog();
                    return;
                case "btnInjectorCorrection":
                    InjectorCorrectionForm icf = new InjectorCorrectionForm();
                    icf.ShowDialog();
                    return;
                default:
                    return;
            }
        }
      

        private void Numu_ValueChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {
                //case "numPressError"://numuPressError
                case "numuPressError"://LDC修改
                    Store.ECUSetting.PressErrorTime = Convert.ToInt32(numu.Value);
                    break;
                case "numuMiniGasTemp":
                    Store.ECUSetting.MiniGasTemp = Convert.ToSByte(numu.Value);
                    break;
                case "numuMinimumPress":
                    Store.ECUSetting.MinimumPress = Convert.ToSingle(numu.Value);
                    break;
                case "numuOperationalPress":
                    Store.ECUSetting.OperationalPress = Convert.ToSingle(numu.Value);
                    if (Store.ECUSetting.CorrectionSetting4UpdateGasPress == null)
                        Store.ECUSetting.CorrectionSetting4UpdateGasPress = Store.CorrectionSetting;
                    break;
                case "numuOrderDelay":
                    Store.ECUSetting.OrderDelay = Convert.ToInt32(numu.Value);
                    break;
                case "numuOverlapTimes":
                    Store.ECUSetting.OverlapTimes = Convert.ToSingle(numu.Value);
                    break;
                case "numuRunningRPM":
                    Store.ECUSetting.RunningRPM = Convert.ToInt32(numu.Value);
                    break;
                case "numuRunningTijiTime":
                    Store.ECUSetting.RunningTijiTime = Convert.ToSingle(numu.Value);
                    break;
                case "numuRunningOil":
                    Store.ECUSetting.RunningOilCompensation = Convert.ToSingle(numu.Value);
                    break;
                case "numBackTransitionTm":
                   Store.ECUSetting.BackTransitionTm = Convert.ToByte(numu.Value);
                   break;
                case "numGasFillTime":
                   Store.ECUSetting.GasFillTime = Convert.ToInt32(numu.Value * 10);
                   break;
                default:
                    return;
            }
            Store.SaveChanges();
        }
        #region IMultLang 成员

        public void ApplyLang()
        {
            IsInit = true;
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { } 
            labOperationalPress.Font = new Font(fontFamily, labOperationalPress.Font.Size);
            labMinimumPress.Font = new Font(fontFamily, labMinimumPress.Font.Size);
            labPressErrorTime.Font = new Font(fontFamily, labPressErrorTime.Font.Size);
            labMiniGasTemp.Font = new Font(fontFamily, labMiniGasTemp.Font.Size);
            labOperationalPress.Text = LangWords["303_8"];
            labMinimumPress.Text = LangWords["303_9"];
            labPressErrorTime.Text = LangWords["303_13"];
            labMiniGasTemp.Text = LangWords["303_14"];
            btnInjectorCorrection.Text = LangWords["303_35"];
            cbInjetPositiveDrive.Text = LangWords["303_43"];
            KeyValuePair<String, String>[] data1 = new KeyValuePair<string, string>[2];
            data1[0] = new KeyValuePair<string, string>(LangWords["303_10"], Models.Enums.SwitchModes.InAcceleration.ToString());
            data1[1] = new KeyValuePair<string, string>(LangWords["303_11"], Models.Enums.SwitchModes.InDecelertion.ToString());

            cbStartAndStop.Text = LangWords["303_46"];
            cBStartOnGas.Text = LangWords["303_44"];
            cBAnticipate.Text = LangWords["303_47"];
            labAnticipate.Text = LangWords["303_48"];
            cbBackTransition.Text = LangWords["303_51"];
            labcbBackTransition.Text = LangWords["303_52"];
            IsInit = false;
        }
        Dictionary<string, string> LangWords { get { return Services.Lang.CurrentWords; } }
        #endregion
        bool IsInit = true;
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cb_Checked(object sender, EventArgs e)
        {
            if (IsInit) return;
            var cb = sender as CheckBox;

            switch (cb.Name)
            {
                case "cbInjetPositiveDrive":
                      Store.ECUSetting.InjetPositiveDrive = cb.Checked;
                      if (cb.Checked)
                            Store.ECUSetting.ExtraData[4] = (byte)(Store.ECUSetting.ExtraData[4] | 0x01);
                      else
                            Store.ECUSetting.ExtraData[4] = (byte)(Store.ECUSetting.ExtraData[4] & 0xFE);
                      break;
                case "cbStartAndStop":
                    Store.ECUSetting.StartAndStop = cb.Checked;
                    if (cb.Checked)
                        Store.ECUSetting.ExtraData[1] = (byte)(Store.ECUSetting.ExtraData[1] | 0x10);
                    else
                        Store.ECUSetting.ExtraData[1] = (byte)(Store.ECUSetting.ExtraData[1] & 0xEF);
                    break;
                case "cbValvetronik":
                    Store.ECUSetting.Valvetronik = cb.Checked;
                    if (cb.Checked)
                        Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] | 0x04);
                    else
                        Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] & 0xfb);
                    break;
                case "cBStartOnGas":
                    if (cb.Checked)
                    {
                       // ddlSpeed.SelectedItem = "0";
                        Store.ECUSetting.SwitchRPM = 0;
                        Store.ECUSetting.SwitchMode = Models.Enums.SwitchModes.StartOnGas;
                      //  ddlSpeed.Enabled = false;
                        break;
                    }
                    Store.ECUSetting.SwitchRPM = 1600;
                    Store.ECUSetting.SwitchMode = Models.Enums.SwitchModes.InAcceleration;
                    break;
                case"cBAnticipate":
                    if (Store.ECUSetting.AnticipateInjSetting[0] == 0xf0)
                    {
             
                        //if (MessageBox.Show(LangWords["309_25"], LangWords["309_23"], MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)//LangWords["309_13"];
                        //{
                        //    Services.Device.ResetPLC("XXX");
                        //    Services.Stroe.LoadAuto();
                        //}
                        if(cb.Checked)
                            MessageBox.Show(LangWords["303_50"], LangWords["303_49"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb.Checked = false;
                        break;                   
                    }

                    if (cb.Checked)
                    {
                        Store.ECUSetting.AnticipateInjSetting[0] = 0x01;
                        Store.ECUSetting.AnticipateInjSetting[1] = 0x02;
                        Store.ECUSetting.AnticipateInjSetting[2] = 0x03;
                        Store.ECUSetting.AnticipateInjSetting[3] = 0x00;
                    }
                    else
                    {
                        Store.ECUSetting.AnticipateInjSetting[0] = 0x00;
                        Store.ECUSetting.AnticipateInjSetting[1] = 0x01;
                        Store.ECUSetting.AnticipateInjSetting[2] = 0x02;
                        Store.ECUSetting.AnticipateInjSetting[3] = 0x03;
                    }
                    break;
                case "cbBackTransition":
                    if (cb.Checked)
                    {
                        numBackTransitionTm.Enabled = true;
                        numBackTransitionTm.Value = 1;
                    }
                    else
                    {
                        Store.ECUSetting.BackTransitionTm = 0;
                        numBackTransitionTm.Value = 0;
                        numBackTransitionTm.Enabled = false;


                    }
                    break;


            }
            Store.SaveChanges();
        }

    }
}
