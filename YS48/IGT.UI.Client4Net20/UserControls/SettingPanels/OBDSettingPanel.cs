using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IGT.Service;//LDC增加




namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class OBDSettingPanel : UserControl, ISettingPanel
    {
        public OBDSettingPanel()
        {
            InitializeComponent();
            ApplyLang();
        }
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }
        public void ShowData()
        {
            IsInit = true;
            var setting = Store.ECUSetting;
            ddlOBDType.SelectedValue = setting.OBDType.ToString();
            rbStandard.Checked = setting.OBDStandard == Models.Enums.OBDStandard.Standard;
            rbOpposite.Checked = setting.OBDStandard == Models.Enums.OBDStandard.Opposite;
            ckbAdaptivity.Checked = setting.AutoAdaptive;
            ckbCompleteErrors.Checked = setting.CompleteResetOfErrors;
            ckbSelectiveErrors.Checked = setting.SelectiveResetOfErrors;
            IsInit = false;
        
        
        }
        private void ddlOBDType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var ddl = sender as ComboBox;
            Store.ECUSetting.OBDType = (Models.Enums.OBDTypes)Enum.Parse(typeof(Models.Enums.OBDTypes), ddl.SelectedValue.ToString());
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
            labOBDType.Text = Words["326_1"];
            ckbAdaptivity.Text = Words["326_11"];
            labTypePetTim.Text = Words["326_12"];
            rbStandard.Text = Words["326_13"];
            label1.Text = Words["326_14"];
            rbOpposite.Text = Words["326_15"];
            label2.Text = Words["326_16"];
            ckbCompleteErrors.Text = Words["326_17"];
            ckbSelectiveErrors.Text = Words["326_18"];

            ddlOBDType.DisplayMember = "Key";
            ddlOBDType.ValueMember = "Value";
            KeyValuePair<String, String>[] data1 = new KeyValuePair<string, string>[9];
            data1[0] = new KeyValuePair<string, string>(Words["326_2"], Models.Enums.OBDTypes.Auto.ToString());
            data1[1] = new KeyValuePair<string, string>(Words["326_3"], Models.Enums.OBDTypes.ISO9141_2.ToString());
            data1[2] = new KeyValuePair<string, string>(Words["326_4"], Models.Enums.OBDTypes.KWP_2000FastInit.ToString());
            data1[3] = new KeyValuePair<string, string>(Words["326_5"], Models.Enums.OBDTypes.KWP_2000SlowInit.ToString());
            data1[4] = new KeyValuePair<string, string>(Words["326_6"], Models.Enums.OBDTypes.CANStandard250kbps.ToString());
            data1[5] = new KeyValuePair<string, string>(Words["326_7"], Models.Enums.OBDTypes.CANExtended250kbps.ToString());
            data1[6] = new KeyValuePair<string, string>(Words["326_8"], Models.Enums.OBDTypes.CANStandard500kbps.ToString());
            data1[7] = new KeyValuePair<string, string>(Words["326_9"], Models.Enums.OBDTypes.CANExtended500kbps.ToString());
            data1[8] = new KeyValuePair<string, string>(Words["326_10"], Models.Enums.OBDTypes.None.ToString());
            ddlOBDType.DataSource = data1;
            IsInit = false;
        }
        #endregion
        bool IsInit = false;
        Dictionary<String, String> Words { get { return Services.Lang.CurrentWords; } }
        public IGT.Service.PLC.Device Device { get { return Services.Device; } }
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }

        private void rbStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            Store.ECUSetting.OBDStandard = rbStandard.Checked ? Models.Enums.OBDStandard.Standard : Models.Enums.OBDStandard.Opposite;
            Store.SaveChanges();
        }
        private void ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var cb = sender as CheckBox;
            switch (cb.Name)
            {
                case "ckbAdaptivity":
                    Store.ECUSetting.AutoAdaptive = cb.Checked;
                    if (cb.Checked)
                        Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] | 0x80);
                    else
                        Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] & 0x7F);
                    break;
                case "ckbCompleteErrors":
                    Store.ECUSetting.CompleteResetOfErrors = cb.Checked;
                    if (cb.Checked)
                        Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] | 0x10);
                    else
                        Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] & 0xEF);
                    break;
                case "ckbSelectiveErrors":
                    Store.ECUSetting.SelectiveResetOfErrors = cb.Checked;
                    if (cb.Checked)
                        Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] | 0x80);
                    else
                        Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] & 0x7f);
                    break;
                default:
                    return;
            }
            Store.SaveChanges();
        }
    }
}
