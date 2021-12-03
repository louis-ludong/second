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
    /// 附加设置Panel
    /// </summary>
    public partial class AdditionalSettingsPanel : UserControl, ISettingPanel, Service.Language.IMultLang
    {
        public AdditionalSettingsPanel()
        {
            InitializeComponent();
            ApplyLang();
        }
        private void AdditionalSettingsPanel_Load(object sender, EventArgs e)
        {
            Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetAdditionalInfo);
            Services.Device.AdditionalInfoGot += Device_AdditionalInfoGot;
            this.Disposed += AdditionalSettingsPanel_Disposed;
        }
        //private void DDL_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (isInit) return;
        //    var ddl = sender as ComboBox;
        //    switch (ddl.Name)
        //    {
        //        case "ddlRunning":
        //            Store.ECUSetting.RunningGasStrategy = (Models.Enums.GasStrategies)Enum.Parse(typeof(Models.Enums.GasStrategies), ddl.SelectedValue.ToString());
        //            numuRunningOil.Enabled = Store.ECUSetting.RunningGasStrategy == Models.Enums.GasStrategies.OilCompensation; 
        //            numuRunningTijiTime.Enabled = Store.ECUSetting.RunningGasStrategy == Models.Enums.GasStrategies.OilCompensation; 
        //            numuRunningMaxRPM.Enabled = Store.ECUSetting.RunningGasStrategy != Models.Enums.GasStrategies.KeepGas;
        //            if (ddlRunning.SelectedIndex == 0)
        //            {
        //                rbHighRunningGas.Checked = true;
        //            }
        //            else if (ddlRunning.SelectedIndex == 1)
        //            {
        //                rbRunningTijiTime.Checked = true;
        //            }
        //            else
        //            {
        //                rbRunningOilInc.Checked = true;

        //            }
        //            break;
        //        default:
        //            return;
        //    }
        //    Store.SaveChanges();
        //}
        void AdditionalSettingsPanel_Disposed(object sender, EventArgs e)
        {
            Services.Device.AdditionalInfoGot -= Device_AdditionalInfoGot;
        }
        private void rbchecked(object sender, EventArgs e)
        {
            if (isInit) return;
            var rb = sender as RadioButton;
            switch (rb.Name )
            {
                case "rbHighRunningGas":
                    if (rbHighRunningGas .Checked ==true )
                    {
                        //ddlRunning.SelectedIndex = 0;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        labRunningOil.Visible = false;
                        labRunningTijiTime.Visible = false;
                        labRunningRPM.Visible = false;
                        numuRunningOil.Visible = false;
                        numuRunningMaxRPM.Visible = false;
                        numuRunningTijiTime.Visible = false;
                        FromLab.Visible = false;
                        numuRunningMinRPM.Visible = false;
                        label7.Visible = false;
                        ToLab.Visible = false;
                        Store.ECUSetting.RunningGasStrategy = Models.Enums.GasStrategies.KeepGas;
                        Store.ECUSetting.BaseData[2] = Store.ECUSetting.BaseData[2] & 0x7F;
                        Store.ECUSetting.RunningMinRPM = 8500;
                        Store.ECUSetting.RunningTijiTime = 30.00064f;
                        Store.ECUSetting.RunningOilCompensation = 0;
                    }
                    break;
                case "rbRunningTijiTime":
                    if (rbRunningTijiTime.Checked ==true )
                    {
                        //ddlRunning.SelectedIndex = 1;
                        labRunningOil.Visible = false;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = false;
                        numuRunningOil.Visible = false ;
                        labRunningTijiTime.Visible = true;
                        labRunningRPM.Visible = true;
                        numuRunningMaxRPM.Visible = true;
                        numuRunningTijiTime.Visible = true;
                        FromLab.Visible = true;
                        numuRunningMinRPM.Visible = true;
                        label7.Visible = true;
                        ToLab.Visible = true;
                        Store.ECUSetting.RunningGasStrategy = Models.Enums.GasStrategies.SwitchOil;
                        Store.ECUSetting.BaseData[2] = Store.ECUSetting.BaseData[2] & 0x7F;
                        Store.ECUSetting.RunningMinRPM = 4500;
                        numuRunningMinRPM.Value = 4500;
                        Store.ECUSetting.RunningRPM = 9000;
                        numuRunningMaxRPM.Value = 9000;
                        Store.ECUSetting.RunningTijiTime = 15f;
                        numuRunningTijiTime.Value = 15;
                        Store.ECUSetting.RunningOilCompensation = 0;
                    }
                    break ;
                case "rbRunningOilInc"://燃油补偿
                    if (rbRunningOilInc.Checked == true)
                    {
                        //ddlRunning.SelectedIndex = 2;
                        labRunningOil.Visible = true;
                        labRunningTijiTime.Visible = true;
                        labRunningRPM.Visible = true;
                        numuRunningOil.Visible = true;
                        numuRunningMaxRPM.Visible = true;
                        numuRunningTijiTime.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        FromLab.Visible = true;
                        numuRunningMinRPM.Visible = true;
                        label7.Visible = true;
                        ToLab.Visible = true;
                        Store.ECUSetting.RunningGasStrategy = Models.Enums.GasStrategies.OilCompensation;
                        Store.ECUSetting.BaseData[2] = Store.ECUSetting.BaseData[2] | 0x80;
                        Store.ECUSetting.RunningMinRPM = 4500;
                        numuRunningMinRPM.Value = 4500;
                        Store.ECUSetting.RunningRPM = 9000;
                        numuRunningMaxRPM.Value = 9000;
                        Store.ECUSetting.RunningTijiTime = 15f;
                        numuRunningTijiTime.Value = 15;
                        Store.ECUSetting.RunningOilCompensation = 2;
                        numuRunningOil.Value = 2;
                    }
                    break;
                case "rbRunningonlyGas"://最低转速用气
                    labMinGasRPM.Visible = false;
                    numuMinGasRPM.Visible = false;
                    numuMinGasRPM.Value = 0;
                    Store.ECUSetting.MinGasRPM = 0;
                    Store.ECUSetting.MinOilEn = false;
                    Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] & 0xFE);
                    label3.Visible = false;
                    break;
                case "rbRunningToOil"://转回燃油
                    labMinGasRPM.Visible = true;
                    numuMinGasRPM.Visible = true;
                    label3.Visible = true;
                    numuMinGasRPM.Value = 1100;
                    Store.ECUSetting.MinGasRPM = Convert.ToInt32(numuMinGasRPM.Value);
                    Store.ECUSetting.MinOilEn = false;
                    Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] & 0xFE);
                    break;
                case "rbRunningonlyTijiTime"://燃油 rbRunningonlyTijiTime
                    labMinGasRPM.Visible = true ;
                    numuMinGasRPM.Visible = true ;
                    label3.Visible =true ;
                    numuMinGasRPM.Value =1100;
                    Store.ECUSetting.MinGasRPM = Convert.ToInt32(numuMinGasRPM.Value);
                    Store.ECUSetting.MinOilEn = true;
                    Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] | 0x01);
                    break;
                default :
                    break;
            }
            Store.SaveChanges();
        }
        void Device_AdditionalInfoGot(object sender, Service.PLC.ModelGotEventArg<Models.Feedback.AdditionalInfo> e)
        {
            if (isInit == false && IsDisposed == false)
            {
                try{ this.Invoke(new UIHelper.UIINvkoeParam1<Models.Feedback.AdditionalInfo>(ShowAdditionalInfo),e.Data); }
                catch (Exception) { }
            }
        }

        private void ShowAdditionalInfo(Models.Feedback.AdditionalInfo model)
        {
            labESPerformedUsed.Text = model.EmergencyStatsPerformed.ToString();
        }
        private void cb_CheckedChanged(object sender,EventArgs e)
        {
            if (isInit) return;
            var cb = sender as CheckBox;
            switch (cb.Name)
            {
                case "cbESAllowed":
                    Services.Stroe.Additional.EmergencyStartAllowed = cb.Checked;
                    numuESPerformedSetting.Enabled = cb.Checked;
                    btnESClear.Enabled = cb.Checked;
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();

        }
        private void numu_ValueChanged(object sender, EventArgs e)
        {
            if (isInit) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {
                case "numuESPerformedSetting":
                    Services.Stroe.Additional.EmergencyStatsPerformed = Convert.ToInt32(numu.Value);
                    break;
                case "numuMinGasRPM":
                    Store.ECUSetting.MinGasRPM = Convert.ToInt32(numu.Value);
                    break;
                case "numuRunningMinRPM":
                    Store.ECUSetting.RunningMinRPM = Convert.ToInt32(numu.Value);
                    break;
                case "numuRunningMaxRPM":
                    Store.ECUSetting.RunningRPM = Convert.ToInt32(numu.Value);
                    break;
                case "numuRunningTijiTime":
                    Store.ECUSetting.RunningTijiTime = (float)(numu.Value);
                    break;
                case "numuRunningOil":
                    Store.ECUSetting.RunningOilCompensation = (float)(numu.Value);
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();
        }
        private void btn_Click(object sender,EventArgs e)
        {
            if (isInit) return;
            var btn = sender as Button;
            switch (btn.Name)
            {
                case "btnESClear":
                    Services.Stroe.Additional.EmergencyStatsPerformed = Services.Stroe.Additional.EmergencyStatsPerformed+1;
                    Services.Stroe.Additional.EmergencyStatsPerformed = Services.Stroe.Additional.EmergencyStatsPerformed-1;
                    break;
                default:
                    break;
            }
            Services.Stroe.SaveChanges();
        }
        #region ISettingPanel 成员

        public void ShowData()
        {
            isInit = true;
            FixOverData();
            cbESAllowed.Checked = Services.Stroe.Additional.EmergencyStartAllowed;
            //numuESPerformedSetting.Enabled = cbESAllowed.Checked;
            numuESPerformedSetting.Enabled = false;//LDC
            numuMinGasRPM.Value = Store.ECUSetting.MinGasRPM;
            //btnESClear.Enabled = cbESAllowed.Checked;
            btnESClear.Enabled = false;//LDC
            numuESPerformedSetting.Value = Services.Stroe.Additional.EmergencyStatsPerformed;
            numuRunningOil.Value = Convert.ToDecimal(Store.ECUSetting.RunningOilCompensation);
            numuRunningMaxRPM.Value = Convert.ToDecimal(Store.ECUSetting.RunningRPM);
            numuRunningMinRPM.Value = Convert.ToDecimal(Store.ECUSetting.RunningMinRPM);
            if (Store.ECUSetting.RunningTijiTime<=30)
                 numuRunningTijiTime.Value = Convert.ToDecimal(Store.ECUSetting.RunningTijiTime);//numuRunningTijiTime
            //ddlRunning.SelectedValue = Store.ECUSetting.RunningGasStrategy.ToString();
            if (numuMinGasRPM.Value == 0) //MinOilEn
            {
                rbRunningonlyGas.Checked = true;
                rbRunningonlyTijiTime.Checked = false;
                labMinGasRPM.Visible = false;
                numuMinGasRPM.Visible = false;
                label3.Visible = false;
                rbRunningToOil.Checked = false;
            }
            else if (Store.ECUSetting.MinOilEn)
            {
                rbRunningonlyGas.Checked = false;
                rbRunningonlyTijiTime.Checked = true;
                labMinGasRPM.Visible =true;
                numuMinGasRPM.Visible = true;
                label3.Visible = true;
                rbRunningToOil.Checked = false;
            }
            else
            {
                rbRunningonlyGas.Checked = false;
                rbRunningonlyTijiTime.Checked = true;
                labMinGasRPM.Visible = true;
                numuMinGasRPM.Visible = true;
                label3.Visible = true;
                rbRunningToOil.Checked = true;
            }
            switch(Store.ECUSetting.RunningGasStrategy)
            {
                case Models.Enums.GasStrategies.KeepGas:
                    rbHighRunningGas.Checked = true;
                    labRunningOil.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    labRunningTijiTime.Visible = false;
                    labRunningRPM.Visible = false;
                    numuRunningOil.Visible = false;
                    numuRunningMaxRPM.Visible = false;
                    numuRunningTijiTime.Visible = false;
                    FromLab.Visible = false;
                    numuRunningMinRPM.Visible = false;
                    label7.Visible = false;
                    ToLab.Visible = false;
                    break;
                case Models.Enums.GasStrategies.OilCompensation:
                    rbRunningOilInc.Checked = true;
                    labRunningOil.Visible = true;
                    label4.Visible = true ;
                    label5.Visible = true ;
                    label6.Visible =true ;
                    labRunningTijiTime.Visible = true;
                    labRunningRPM.Visible = true;
                    numuRunningOil.Visible = true;
                    numuRunningMaxRPM.Visible = true;
                    numuRunningTijiTime.Visible = true;
                    break;
                case Models.Enums.GasStrategies.SwitchOil:
                    rbRunningTijiTime.Checked = true;
                    label4.Visible =true;
                    label5.Visible = true;
                    label6.Visible = false;
                    labRunningOil.Visible = false;
                    numuRunningOil.Visible = false;
                    labRunningTijiTime.Visible = true;
                    labRunningRPM.Visible = true;
                    numuRunningMaxRPM.Visible = true;
                    numuRunningTijiTime.Visible = true;
                    FromLab.Visible = true;
                    numuRunningMinRPM.Visible = true;
                    label7.Visible = true;
                    ToLab.Visible = true;
                    break;
            }
            //if (rbHighRunningGas.Checked)
            //{
            //    rbHighRunningGas.Checked = true;
            //    labRunningOil.Visible = false;
            //    label4.Visible = false;
            //    label5.Visible = false;
            //    label6.Visible = false;
            //    labRunningTijiTime.Visible = false;
            //    labRunningRPM.Visible = false;
            //    numuRunningOil.Visible = false;
            //    numuRunningMaxRPM.Visible = false;
            //    numuRunningTijiTime.Visible = false;
            //}
            //if (ddlRunning .Text ==rbRunningTijiTime.Text  )
            //{
            //    rbRunningTijiTime.Checked = true;
            //    label4.Visible =true;
            //    label5.Visible = false;
            //    label6.Visible = false;
            //    labRunningOil.Visible = false;
            //    numuRunningOil.Visible = false;
            //    labRunningTijiTime.Visible = false;
            //    labRunningRPM.Visible = true;
            //    numuRunningMaxRPM.Visible = true;
            //    numuRunningTijiTime.Visible = false;
            //}
            //if (ddlRunning .Text ==rbRunningOilInc .Text )
            //{
            //    rbRunningOilInc.Checked = true;
            //    labRunningOil.Visible = true;
            //    label4.Visible = true ;
            //    label5.Visible = true ;
            //    label6.Visible =true ;
            //    labRunningTijiTime.Visible = true;
            //    labRunningRPM.Visible = true;
            //    numuRunningOil.Visible = true;
            //    numuRunningMaxRPM.Visible = true;
            //    numuRunningTijiTime.Visible = true;
            //}
            //numuRunningOil.Enabled = Store.ECUSetting.RunningGasStrategy == Models.Enums.GasStrategies.OilCompensation;
            //numuRunningTijiTime.Enabled = Store.ECUSetting.RunningGasStrategy == Models.Enums.GasStrategies.OilCompensation;
            //numuRunningMaxRPM.Enabled = Store.ECUSetting.RunningGasStrategy != Models.Enums.GasStrategies.KeepGas;
            isInit = false;
        }
        public void FixOverData()//LDC删除
        {
            //bool change = Services.Stroe.Additional.EmergencyStatsPerformed > Convert.ToInt32(numuESPerformedSetting.Maximum) || Services.Stroe.Additional.EmergencyStatsPerformed < Convert.ToInt32(numuESPerformedSetting.Minimum)||
            //Store.ECUSetting.RunningOilCompensation > Convert.ToSingle(numuRunningOil.Maximum) || Store.ECUSetting.MinGasRPM > Convert.ToInt32(numuMinGasRPM.Maximum) || Store.ECUSetting.MinGasRPM < Convert.ToInt32(numuMinGasRPM.Minimum) || Store.ECUSetting.RunningOilCompensation < Convert.ToSingle(numuRunningOil.Minimum) ||
            //Store.ECUSetting.RunningRPM > Convert.ToInt32(numuRunningRPM.Maximum) || Store.ECUSetting.RunningRPM < Convert.ToInt32(numuRunningRPM.Minimum) || Store.ECUSetting.RunningOilCompensation > Convert.ToSingle(numuRunningOil.Maximum) || Store.ECUSetting.RunningOilCompensation < Convert.ToSingle(numuRunningOil.Minimum) ||
            //Store.ECUSetting.RunningRPM > Convert.ToInt32(numuRunningRPM.Maximum) || Store.ECUSetting.RunningRPM < Convert.ToInt32(numuRunningRPM.Minimum) ||
            //Store.ECUSetting.RunningTijiTime > Convert.ToSingle(numuRunningTijiTime.Maximum) || Store.ECUSetting.RunningTijiTime < Convert.ToSingle(numuRunningTijiTime.Minimum)||
            //    Store.ECUSetting.RunningTijiTime > Convert.ToSingle(numuRunningTijiTime.Maximum) || Store.ECUSetting.RunningTijiTime < Convert.ToSingle(numuRunningTijiTime.Minimum);
            //if (Services.Stroe.Additional.EmergencyStatsPerformed > Convert.ToInt32(numuESPerformedSetting.Maximum))
            //    Services.Stroe.Additional.EmergencyStatsPerformed = Convert.ToInt32(numuESPerformedSetting.Maximum);
            //if (Services.Stroe.Additional.EmergencyStatsPerformed < Convert.ToInt32(numuESPerformedSetting.Minimum))
            //    Services.Stroe.Additional.EmergencyStatsPerformed = Convert.ToInt32(numuESPerformedSetting.Minimum);
            //if (Store.ECUSetting.MinGasRPM > Convert.ToInt32(numuMinGasRPM.Maximum))
            //    Store.ECUSetting.MinGasRPM = Convert.ToInt32(numuMinGasRPM.Maximum);
            //if (Store.ECUSetting.MinGasRPM < Convert.ToInt32(numuMinGasRPM.Minimum))
            //    Store.ECUSetting.MinGasRPM = Convert.ToInt32(numuMinGasRPM.Minimum);
            //if (Store.ECUSetting.RunningOilCompensation > Convert.ToSingle(numuRunningOil.Maximum))
            //    Store.ECUSetting.RunningOilCompensation = Convert.ToSingle(numuRunningOil.Maximum);
            //if (Store.ECUSetting.RunningOilCompensation < Convert.ToSingle(numuRunningOil.Minimum))
            //    Store.ECUSetting.RunningOilCompensation = Convert.ToSingle(numuRunningOil.Minimum);
            //if (Store.ECUSetting.RunningRPM > Convert.ToInt32(numuRunningRPM.Maximum))
            //    Store.ECUSetting.RunningRPM = Convert.ToInt32(numuRunningRPM.Maximum);
            //if (Store.ECUSetting.RunningRPM < Convert.ToInt32(numuRunningRPM.Minimum))
            //    Store.ECUSetting.RunningRPM = Convert.ToInt32(numuRunningRPM.Minimum);
            //if (Store.ECUSetting.RunningTijiTime > Convert.ToSingle(numuRunningTijiTime.Maximum))
            //    Store.ECUSetting.RunningTijiTime = Convert.ToSingle(numuRunningTijiTime.Maximum);
            //if (Store.ECUSetting.RunningTijiTime < Convert.ToSingle(numuRunningTijiTime.Minimum))
            //    Store.ECUSetting.RunningTijiTime = Convert.ToSingle(numuRunningTijiTime.Minimum);
            //if (change)
            //    Services.Stroe.SaveChanges();
        }
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }

        #endregion

        #region IMultLang 成员

        public void ApplyLang()
        {
            isInit = true;
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            gboxEmergencyStats.Font = new Font(fontFamily, gboxEmergencyStats.Font.Size);
            cbESAllowed.Font = new Font(fontFamily, cbESAllowed.Font.Size);
            labESPerformed.Font = new Font(fontFamily, labESPerformed.Font.Size);
            btnESClear.Font = new Font(fontFamily, btnESClear.Font.Size);
            labMinGasRPM.Font = new Font(fontFamily, labMinGasRPM.Font.Size);
            //gBoxRunningGasStrategy.Font = new Font(fontFamily, gBoxRunningGasStrategy.Font.Size);
            var word = Services.Lang.CurrentWords;
            labRunning.Font = new Font(fontFamily, labRunning.Font.Size);
            labRunningRPM.Font = new Font(fontFamily, labRunningRPM.Font.Size);
            labRunningTijiTime.Font = new Font(fontFamily, labRunningTijiTime.Font.Size);
            labRunningOil.Font = new Font(fontFamily, labRunningOil.Font.Size);
            //ddlRunning.Font = new Font(fontFamily, ddlRunning.Font.Size);
            //gBoxRunningGasStrategy.Text = word["303_20"];
            gboxEmergencyStats.Text = word["325_1"];
            cbESAllowed.Text = word["325_2"];
            labESPerformed.Text = word["325_3"];
            btnESClear.Text = word["325_4"];
            labRunning.Text = word["303_20"];
            labRunningRPM.Text = word["303_21"];
            labRunningTijiTime.Text = word["303_22"];
            labRunningOil.Text = word["303_23"];
            labMinGasRPM.Text = word["303_15"];
            labmarcha .Text =word ["303_37"];
            rbRunningonlyGas .Text =word ["303_38"];
            rbRunningonlyTijiTime .Text =word ["303_39"];
            rbHighRunningGas.Text = word["303_24"];
            rbRunningTijiTime.Text = word["303_25"];
            rbRunningOilInc .Text =word ["303_26"];

            FromLab.Text = word["303_40"];
            ToLab.Text = word["303_41"];
            rbRunningToOil.Text = word["303_42"];
            //ddlRunning.DisplayMember = "Key";
            //ddlRunning.ValueMember = "Value";
            //KeyValuePair<String, String>[] data2 = new KeyValuePair<string, string>[3];
            //data2[0] = new KeyValuePair<string, string>(word["303_24"], Models.Enums.GasStrategies.KeepGas.ToString());
            //data2[1] = new KeyValuePair<string, string>(word["303_25"], Models.Enums.GasStrategies.SwitchOil.ToString());
            //data2[2] = new KeyValuePair<string, string>(word["303_26"], Models.Enums.GasStrategies.OilCompensation.ToString());
            //ddlRunning.DataSource = data2;
            isInit = false;
        }
        #endregion
        bool isInit=false;
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }
    }
}
