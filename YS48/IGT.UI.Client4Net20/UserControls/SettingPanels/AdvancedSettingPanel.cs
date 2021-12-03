using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class AdvancedSettingPanel : UserControl, ISettingPanel, Service.Language.IMultLang
    {
        public AdvancedSettingPanel()
        {
            InitializeComponent();
            ApplyLang();
            gboxadp.Visible = Services.Device.DeviceInfo.HardInof.AutoAdaptive;
            gboxODB.Visible = Services.Device.DeviceInfo.HardInof.OBDEn;
        }
        private void AdvancedSettingPanel_Load(object sender, EventArgs e)
        {
            Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetAdditionalInfo);
            Services.Device.AdditionalInfoGot += Device_AdditionalInfoGot;
            this.Disposed += AdditionalSettingsPanel_Disposed;
        }
        void AdditionalSettingsPanel_Disposed(object sender, EventArgs e)
        {
            Services.Device.AdditionalInfoGot -= Device_AdditionalInfoGot;
        }

        void Device_AdditionalInfoGot(object sender, Service.PLC.ModelGotEventArg<Models.Feedback.AdditionalInfo> e)
        {
            if (IsInit == false && IsDisposed == false)
            {
                try { this.Invoke(new UIHelper.UIINvkoeParam1<Models.Feedback.AdditionalInfo>(ShowAdditionalInfo), e.Data); }
                catch (Exception) { }
            }
        }
        private void ShowAdditionalInfo(Models.Feedback.AdditionalInfo model)
        {
            labMRTime.Text = string.Format("{0} H   {1} M", model.MaintainTime.Hours.ToString(), model.MaintainTime.Minutes.ToString());
        }
        private void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var ddl = sender as ComboBox;
            switch (ddl.Name)
            {
                case "ddlOBDClear":
                    var temp = (Models.Enums.ErroClearLevels)Enum.Parse(typeof(Models.Enums.ErroClearLevels), ddl.SelectedValue.ToString());
                    Services.Stroe.ECUSetting.ODBErrorAutoClear = temp;
                    break;
                case "ddlMRType":
                    Services.Stroe.Additional.MaintainRemind = (Models.Enums.MaintainRemindTypes)
                        Enum.Parse(typeof(Models.Enums.MaintainRemindTypes), ddlMRType.SelectedValue.ToString());
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();
        }
        //private void trackBarSen_Scroll(object sender, EventArgs e)
        //{
        //    if (IsInit) return;
        //    var tb = sender as TrackBar;
        //    switch (tb.Name)
        //    {
        //        case "tBarSpeedThicken":
        //            Services.Stroe.ECUSetting.SpeedThicken = tb.Value;
        //            break;
        //        default:
        //            return;
        //    }
        //    Services.Stroe.SaveChanges();
        //}
        public void cb_Checked(object sender, EventArgs e)
        {
            if (IsInit) return;
            var cb = sender as CheckBox;
            switch (cb.Name)
            {
                case "cbAutoAdaptive":
                case "cbODBOpen":
                    Services.Stroe.ECUSetting.AutoAdaptive = cb.Checked;
                    break;
                case "cbAdaptiveAssist":
                    Services.Stroe.ECUSetting.AdaptiveAssist = cb.Checked;
                    break;
                case "cbAutoStopAdaptive":
                    Services.Stroe.ECUSetting.AutoStopAdaptive = cb.Checked;
                    break;
                case "cbODBReverseAssist":
                    Services.Stroe.ECUSetting.ODBReverseAssist = cb.Checked;
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();
        }
        private void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var ddl = sender as ComboBox;
            switch (ddl.Name)
            {
                case "ddlMRType":
                    Services.Stroe.Additional.MaintainRemind = (Models.Enums.MaintainRemindTypes)
                        Enum.Parse(typeof(Models.Enums.MaintainRemindTypes), ddlMRType.SelectedValue.ToString());
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();
        }
        public void numu_ValueChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {
                case "numuAdaptiveRange":
                    Services.Stroe.ECUSetting.AdaptiveRange = Convert.ToInt32(numu.Value);
                    break;
                case "numuODBAdaptRange":
                    Services.Stroe.ECUSetting.ODBAdaptRange = Convert.ToInt32(numu.Value);
                    break;
                case "numuODBBank1Correct":
                    Services.Stroe.ECUSetting.ODBBank1Correct = Convert.ToSByte(numu.Value);
                    break;
                case "numuODBBank2Correct":
                    Services.Stroe.ECUSetting.ODBBank2Correct = Convert.ToSByte(numu.Value);
                    break;
                case "numuWeak":
                    Services.Stroe.ECUSetting.Weak = Convert.ToInt32(numu.Value);
                    break;
                case "numuIdentTime":
                    Services.Stroe.ECUSetting.ExtraInjectionIdentTime = Convert.ToSingle(numu.Value);
                    break;
                default:
                    break;
            }
            Services.Stroe.SaveChanges();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (IsInit) return;
            var btn = sender as VistaButton;
            switch (btn.Name)
            {
                case "btnMREnter":
                    int time = 0;
                    try
                    {
                        int p1 = int.Parse(ddlMRKM.SelectedItem.ToString());
                        int p2 = int.Parse(txtMRKM.Text);
                        time = p1 / p2 * 60;
                    }
                    catch (Exception)
                    {
                        return;
                    }
                    Services.Stroe.Additional.MaintainTime = new TimeSpan(0, time, 0);
                    break;
                default:
                    break;
            }
            Services.Stroe.SaveChanges();
        }
        #region ISettingPanel 成员
        public void ShowData()
        {
            IsInit = true;
            FixOverData();
            if (!Services.Device.DeviceInfo.HardInof.OBDEn)
            {
                cbODBOpen.Enabled = false;
                cbODBReverseAssist.Enabled = false;
                numuODBAdaptRange.Enabled = false;
                numuODBBank1Correct.Enabled = false;
                numuODBBank2Correct.Enabled = false;
            }
            if(!Services.Device.DeviceInfo.HardInof.AutoAdaptive)
            {
                cbAdaptiveAssist.Enabled = false;
                cbAutoAdaptive.Enabled = false;
                cbAutoStopAdaptive.Enabled = false;
                numuAdaptiveRange.Enabled = false;
            }
            cbAdaptiveAssist.Checked = Services.Stroe.ECUSetting.AdaptiveAssist;
            cbAutoAdaptive.Checked = Services.Stroe.ECUSetting.AutoAdaptive;
            cbAutoStopAdaptive.Checked = Services.Stroe.ECUSetting.AutoStopAdaptive;
            cbODBOpen.Checked = Services.Stroe.ECUSetting.AutoAdaptive;
            cbODBReverseAssist.Checked = Services.Stroe.ECUSetting.ODBReverseAssist;
            numuAdaptiveRange.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.AdaptiveRange);
            numuODBAdaptRange.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.ODBAdaptRange);
            numuODBBank1Correct.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.ODBBank1Correct);
            numuODBBank2Correct.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.ODBBank2Correct);
            //tBarSpeedThicken.Value = Services.Stroe.ECUSetting.SpeedThicken;
            ddlOBDClear.SelectedValue = Services.Stroe.ECUSetting.ODBErrorAutoClear.ToString();
            ddlMRType.SelectedValue = Services.Stroe.Additional.MaintainRemind.ToString();
            IsInit = false;
        }
        public void FixOverData()
        {
            bool change = Services.Stroe.ECUSetting.AdaptiveRange > Convert.ToInt32(numuAdaptiveRange.Maximum) || Services.Stroe.ECUSetting.AdaptiveRange < Convert.ToInt32(numuAdaptiveRange.Minimum) ||
            Services.Stroe.ECUSetting.ODBAdaptRange > Convert.ToInt32(numuODBAdaptRange.Maximum) || Services.Stroe.ECUSetting.ODBAdaptRange < Convert.ToInt32(numuODBAdaptRange.Minimum) ||
            Services.Stroe.ECUSetting.ODBBank1Correct > Convert.ToSByte(numuODBBank1Correct.Maximum) || Services.Stroe.ECUSetting.ODBBank1Correct < Convert.ToSByte(numuODBBank1Correct.Minimum) ||
            Services.Stroe.ECUSetting.ODBBank2Correct > Convert.ToSByte(numuODBBank2Correct.Maximum) || Services.Stroe.ECUSetting.ODBBank2Correct < Convert.ToSByte(numuODBBank2Correct.Minimum);
            if (Services.Stroe.ECUSetting.AdaptiveRange > Convert.ToInt32(numuAdaptiveRange.Maximum))
                Services.Stroe.ECUSetting.AdaptiveRange = Convert.ToInt32(numuAdaptiveRange.Maximum);
            if (Services.Stroe.ECUSetting.AdaptiveRange < Convert.ToInt32(numuAdaptiveRange.Minimum))
                Services.Stroe.ECUSetting.AdaptiveRange = Convert.ToInt32(numuAdaptiveRange.Minimum);
            if (Services.Stroe.ECUSetting.ODBAdaptRange > Convert.ToInt32(numuODBAdaptRange.Maximum))
                Services.Stroe.ECUSetting.ODBAdaptRange = Convert.ToInt32(numuODBAdaptRange.Maximum);
            if (Services.Stroe.ECUSetting.ODBAdaptRange < Convert.ToInt32(numuODBAdaptRange.Minimum))
                Services.Stroe.ECUSetting.ODBAdaptRange = Convert.ToInt32(numuODBAdaptRange.Minimum);
            if (Services.Stroe.ECUSetting.ODBBank1Correct > Convert.ToSByte(numuODBBank1Correct.Maximum))
                Services.Stroe.ECUSetting.ODBBank1Correct = Convert.ToSByte(numuODBBank1Correct.Maximum);
            if (Services.Stroe.ECUSetting.ODBBank1Correct < Convert.ToSByte(numuODBBank1Correct.Minimum))
                Services.Stroe.ECUSetting.ODBBank1Correct = Convert.ToSByte(numuODBBank1Correct.Minimum);
            if (Services.Stroe.ECUSetting.ODBBank2Correct > Convert.ToSByte(numuODBBank2Correct.Maximum))
                Services.Stroe.ECUSetting.ODBBank2Correct = Convert.ToSByte(numuODBBank2Correct.Maximum);
            if (Services.Stroe.ECUSetting.ODBBank2Correct < Convert.ToSByte(numuODBBank2Correct.Minimum))
                Services.Stroe.ECUSetting.ODBBank2Correct = Convert.ToSByte(numuODBBank2Correct.Minimum);
            if (change)
                Services.Stroe.SaveChanges();
        }
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }

        #endregion

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
            gboxadp.Font = new Font(fontFamily, gboxadp.Font.Size);
            gboxODB.Font = new Font(fontFamily, gboxODB.Font.Size);
            labAdaptiveRange.Font = new Font(fontFamily, labAdaptiveRange.Font.Size);
            labODBAdaptRange.Font = new Font(fontFamily, labODBAdaptRange.Font.Size);
            labODBBank1Correct.Font = new Font(fontFamily, labODBBank1Correct.Font.Size);
            labODBBank2Correct.Font = new Font(fontFamily, labODBBank2Correct.Font.Size);
            cbAdaptiveAssist.Font = new Font(fontFamily, cbAdaptiveAssist.Font.Size);
            cbAutoAdaptive.Font = new Font(fontFamily, cbAutoAdaptive.Font.Size);
            cbAutoStopAdaptive.Font = new Font(fontFamily, cbAutoStopAdaptive.Font.Size);
            cbODBOpen.Font = new Font(fontFamily, cbODBOpen.Font.Size);
            cbODBReverseAssist.Font = new Font(fontFamily, cbODBReverseAssist.Font.Size);
            labOBDClear.Font = new Font(fontFamily, labOBDClear.Font.Size);
            ddlOBDClear.Font = new Font(fontFamily, ddlOBDClear.Font.Size);
            gboxMaintainRemind.Font = new Font(fontFamily, gboxMaintainRemind.Font.Size);
            labMRType.Font = new Font(fontFamily, labMRType.Font.Size);
            labMRNextTime.Font = new Font(fontFamily, labMRNextTime.Font.Size);
            labMRTimeLabel.Font = new Font(fontFamily, labMRTimeLabel.Font.Size);
            ddlMRType.Font = new Font(fontFamily, ddlMRType.Font.Size);
            ddlMRKM.Font = new Font(fontFamily, ddlMRKM.Font.Size);
            btnMREnter.Font = new Font(fontFamily, btnMREnter.Font.Size);

            var word = Services.Lang.CurrentWords;
            btnMREnter.ButtonText = word["106"];
            gboxMaintainRemind.Text = word["325_5"];
            labMRType.Text = word["325_6"];
            labMRNextTime.Text = word["325_7"];
            labMRTimeLabel.Text = word["325_8"];
            KeyValuePair<String, string>[] ds = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string,string>(word["325_10"],Models.Enums.MaintainRemindTypes.Off.ToString()),
                new KeyValuePair<string,string>(word["325_11"],Models.Enums.MaintainRemindTypes.Sound.ToString()),
                new KeyValuePair<string,string>(word["325_12"],Models.Enums.MaintainRemindTypes.Forbid.ToString())
            };
            ddlMRType.ValueMember = "Value";
            ddlMRType.DisplayMember = "Key";
            ddlMRType.DataSource = ds;

            for (int i = 500; i <= 5000; i += 500)
            {
                ddlMRKM.Items.Add(i.ToString());
            }
            ddlMRKM.SelectedIndex = 1;
            gboxadp.Text = word["309_2"];
            gboxODB.Text = word["309_1"];
            labAdaptiveRange.Text = word["309_4"];
            labODBAdaptRange.Text = word["309_8"];
            labODBBank1Correct.Text = word["309_9"];
            labODBBank2Correct.Text = word["309_10"];
            cbAdaptiveAssist.Text = word["309_6"];
            cbAutoAdaptive.Text = word["309_11"];
            cbAutoStopAdaptive.Text = word["309_5"];
            cbODBOpen.Text = word["309_3"];
            cbODBReverseAssist.Text = word["309_7"];

            labOBDClear.Text = word["309_18"];
            ddlOBDClear.Items.Clear();
            ddlOBDClear.DisplayMember = "Key";
            ddlOBDClear.ValueMember = "Value";
            KeyValuePair<String, String>[] ds1 = {
                new KeyValuePair<String,String>(word["309_19"],Models.Enums.ErroClearLevels.Not.ToString()),
                new KeyValuePair<String,String>(word["309_20"],Models.Enums.ErroClearLevels.Choice.ToString()),
                new KeyValuePair<String,String>(word["309_21"],Models.Enums.ErroClearLevels.Full.ToString())
            };
            ddlOBDClear.DataSource = ds1;
            IsInit = false;
        }

        #endregion
        bool IsInit = false;
    }
}
