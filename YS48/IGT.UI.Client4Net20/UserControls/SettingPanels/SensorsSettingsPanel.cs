using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class SensorsSettingsPanel : UserControl, Service.Language.IMultLang, ISettingPanel
    {
        public SensorsSettingsPanel()
        {
            InitializeComponent();
            ApplyLang();
            this.Store.SaveChanged += Store_SaveChanged;
        }
        bool LeveISensChanged = false;
        void Store_SaveChanged(object sender, EventArgs e)
        {
            if (LeveISensChanged)
            {
                LeveISensChanged = false;
                try
                {
                    this.BeginInvoke(new UIHelper.UIInvoke(ApplyGasLevel));
                }
                catch (Exception) { IsInit = false; }
            }
        }
        void ApplyGasLevel()
        {
            IsInit = true;
            //numuLV1.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[0]);
            //numuLV2.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[1]);
            //numuLV3.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[2]);
            //numuLV4.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[3]);LDC删除
          //  NumuLVShow();//LDC增加
            numuLV1.Enabled = true;
            numuLV2.Enabled = true;
            numuLV3.Enabled = true;
            numuLV4.Enabled = true;
            IsInit = false;
        }
        #region ISettingPanel 成员
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }
        public void ShowData()
        {
            IsInit = true;
            FixOverData();
            //numu1Hight.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda1HV);
            //numu1Low.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda1LV);
            //numu2Hight.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda2HV);
            //numu2Low.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda2LV);
            //numuDealy.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.LambdaDelay);
            //numuNumber.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.LambdaInjectNum);
            ddlReducerTempSens.SelectedValue = Store.ECUSetting.ReducerTempSens.ToString();
            ddlGasTempSens.SelectedValue = Store.ECUSetting.GasTempSens.ToString();
            ddlO2Number.SelectedValue = Store.ECUSetting.O2Numbers.ToString();
            ddlO2Type.SelectedValue = Store.ECUSetting.O2Type.ToString();
            if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.Unknow)
                ddlLevelIndicatorSens.SelectedValue = "";
            else
                ddlLevelIndicatorSens.SelectedValue = Store.ECUSetting.LevelIndicatorSens.ToString();
            NumuLVShow();
            ddlLambda1Type.SelectedValue = Services.Stroe.ECUSetting.Lambda1Type.ToString();
            ddlLambda2Type.SelectedValue = Services.Stroe.ECUSetting.Lambda2Type.ToString();
            IsInit = false;
        }
        private void NumuLVShow()
        {
            numuLV1.Visible = false;
            numuLV2.Visible = false;
            numuLV3.Visible = false;
            numuLV4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.NotStandard)
            {
                numuLV1.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[0]);
                numuLV2.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[1]);
                numuLV3.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[2]);
                numuLV4.Value = Convert.ToDecimal(Store.ECUSetting.GasLevel[3]);
                numuLV1.Visible = true;
                numuLV2.Visible = true;
                numuLV3.Visible = true;
                numuLV4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
            }
            if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.NotStandardInverted)
            {
                numuLV1.Value = Convert.ToDecimal(5 - Store.ECUSetting.GasLevel[0]);
                numuLV2.Value = Convert.ToDecimal(5 - Store.ECUSetting.GasLevel[1]);
                numuLV3.Value = Convert.ToDecimal(5 - Store.ECUSetting.GasLevel[2]);
                numuLV4.Value = Convert.ToDecimal(5 - Store.ECUSetting.GasLevel[3]);
                numuLV1.Visible = true;
                numuLV2.Visible = true;
                numuLV3.Visible = true;
                numuLV4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
            }
        }
        void FixOverData()
        {
            float max = Convert.ToSingle(numuLV1.Maximum);
            float mini = Convert.ToSingle(numuLV1.Minimum);
            //bool change = //Services.Stroe.ECUSetting.Lambda1HV > Convert.ToSingle(numu1Hight.Maximum) || Services.Stroe.ECUSetting.Lambda1HV < Convert.ToSingle(numu1Hight.Minimum) ||
            //Services.Stroe.ECUSetting.Lambda1LV > Convert.ToSingle(numu1Low.Maximum) || Services.Stroe.ECUSetting.Lambda1LV < Convert.ToSingle(numu1Low.Minimum) ||
            //Services.Stroe.ECUSetting.Lambda2HV > Convert.ToSingle(numu2Hight.Maximum) || Services.Stroe.ECUSetting.Lambda2HV < Convert.ToSingle(numu2Hight.Minimum) ||
            //Services.Stroe.ECUSetting.Lambda2LV > Convert.ToSingle(numu2Low.Maximum) || Services.Stroe.ECUSetting.Lambda2LV < Convert.ToSingle(numu2Low.Minimum) ||
            //Services.Stroe.ECUSetting.LambdaDelay > Convert.ToInt32(numuDealy.Maximum) || Services.Stroe.ECUSetting.LambdaDelay < Convert.ToInt32(numuDealy.Minimum) ||
            //Services.Stroe.ECUSetting.LambdaInjectNum > Convert.ToInt32(numuNumber.Maximum) || Services.Stroe.ECUSetting.LambdaInjectNum < Convert.ToInt32(numuNumber.Minimum);
            ////if (Services.Stroe.ECUSetting.Lambda1HV > Convert.ToSingle(numu1Hight.Maximum))
            ////    Services.Stroe.ECUSetting.Lambda1HV = Convert.ToSingle(numu1Hight.Maximum);
            ////if (Services.Stroe.ECUSetting.Lambda1HV < Convert.ToSingle(numu1Hight.Minimum))
            ////    Services.Stroe.ECUSetting.Lambda1HV = Convert.ToSingle(numu1Hight.Minimum);
            //if (Services.Stroe.ECUSetting.Lambda1LV > Convert.ToSingle(numu1Low.Maximum))
            //    Services.Stroe.ECUSetting.Lambda1LV = Convert.ToSingle(numu1Low.Maximum);
            //if (Services.Stroe.ECUSetting.Lambda1LV < Convert.ToSingle(numu1Low.Minimum))
            //    Services.Stroe.ECUSetting.Lambda1LV = Convert.ToSingle(numu1Low.Minimum);
            //if (Services.Stroe.ECUSetting.Lambda2HV > Convert.ToSingle(numu2Hight.Maximum))
            //    Services.Stroe.ECUSetting.Lambda2HV = Convert.ToSingle(numu2Hight.Maximum);
            //if (Services.Stroe.ECUSetting.Lambda2HV < Convert.ToSingle(numu2Hight.Minimum))
            //    Services.Stroe.ECUSetting.Lambda2HV = Convert.ToSingle(numu2Hight.Minimum);
            //if (Services.Stroe.ECUSetting.Lambda2LV > Convert.ToSingle(numu2Low.Maximum))
            //    Services.Stroe.ECUSetting.Lambda2LV = Convert.ToSingle(numu2Low.Maximum);
            //if (Services.Stroe.ECUSetting.Lambda2LV < Convert.ToSingle(numu2Low.Minimum))
            //    Services.Stroe.ECUSetting.Lambda2LV = Convert.ToSingle(numu2Low.Minimum);
            //if (Services.Stroe.ECUSetting.LambdaDelay > Convert.ToInt32(numuDealy.Maximum))
            //    Services.Stroe.ECUSetting.LambdaDelay = Convert.ToInt32(numuDealy.Maximum);
            //if (Services.Stroe.ECUSetting.LambdaDelay < Convert.ToInt32(numuDealy.Minimum))
            //    Services.Stroe.ECUSetting.LambdaDelay = Convert.ToInt32(numuDealy.Minimum);
            //if (Services.Stroe.ECUSetting.LambdaInjectNum > Convert.ToInt32(numuNumber.Maximum))
            //    Services.Stroe.ECUSetting.LambdaInjectNum = Convert.ToInt32(numuNumber.Maximum);
            //if (Services.Stroe.ECUSetting.LambdaInjectNum < Convert.ToInt32(numuNumber.Minimum))
            //    Services.Stroe.ECUSetting.LambdaInjectNum = Convert.ToInt32(numuNumber.Minimum);
            //if (change)
            //    Services.Stroe.SaveChanges();
            for (int i = 0; i < Store.ECUSetting.GasLevel.Count; i++)
            {
                if (Store.ECUSetting.GasLevel[i] > max) Store.ECUSetting.GasLevel[i] = max;
                if (Store.ECUSetting.GasLevel[i] < mini) Store.ECUSetting.GasLevel[i] = mini;
            }
            Services.Stroe.SaveChanges();
        }
        #endregion
        private void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var ddl = sender as ComboBox;
            switch (ddl.Name)
            {
                case "ddlGasTempSens":
                    Store.ECUSetting.GasTempSens = (Models.Enums.TempSensTypes)
                        Enum.Parse(typeof(Models.Enums.TempSensTypes), ddl.SelectedValue.ToString());
                    break;
                case "ddlInjectorType":
                    Store.ECUSetting.InjectorType = (Models.Enums.InjectorTypes)
                        Enum.Parse(typeof(Models.Enums.InjectorTypes), ddl.SelectedValue.ToString());
                    break;
                case "ddlLevelIndicatorSens":
                    //if (Services.Device.Connect.IsConnected)
                    //{
                    //    numuLV1.Enabled = false;
                    //    numuLV2.Enabled = false;
                    //    numuLV3.Enabled = false;
                    //    numuLV4.Enabled = false;
                    //}
                    Store.ECUSetting.LevelIndicatorSens = (Models.Enums.LevelIndicatorSensTypes)
                        Enum.Parse(typeof(Models.Enums.LevelIndicatorSensTypes), ddl.SelectedValue.ToString());
                    NumuLVShow();
                    ChangeLV();
                    LeveISensChanged = true;
                    break;
                case "ddlReducerTempSens":
                    Store.ECUSetting.ReducerTempSens = (Models.Enums.TempSensTypes)
                        Enum.Parse(typeof(Models.Enums.TempSensTypes), ddl.SelectedValue.ToString());
                    break;
                case "ddlO2Number":
                    Store.ECUSetting.O2Numbers = int.Parse(ddl.SelectedValue.ToString());
                    if (Store.ECUSetting.O2Numbers == 2)
                        Store.ECUSetting.BaseData[0] = (byte)(Store.ECUSetting.BaseData[0] & 0xFB);
                    else
                        Store.ECUSetting.BaseData[0] = (byte)(Store.ECUSetting.BaseData[0] |0x04);                
                    break;
                case "ddlO2Type":
                    Services.Stroe.ECUSetting.O2Type = (Models.Enums.LambdaTypes)
                        Enum.Parse(typeof(Models.Enums.LambdaTypes), ddl.SelectedValue.ToString());
                    //Services.Stroe.ECUSetting.Lambda1Type = (Models.Enums.LambdaTypes)
                    //    Enum.Parse(typeof(Models.Enums.LambdaTypes), ddlLambda1Type.SelectedValue.ToString());
                    //Services.Stroe.ECUSetting.Lambda2Type = (Models.Enums.LambdaTypes)
                    //    Enum.Parse(typeof(Models.Enums.LambdaTypes), ddlLambda2Type.SelectedValue.ToString());
                    break;
                case "ddlLambda1Type":
                    Services.Stroe.ECUSetting.Lambda1Type = (Models.Enums.LambdaTypes)
                        Enum.Parse(typeof(Models.Enums.LambdaTypes), ddl.SelectedValue.ToString());
                    break;
                case "ddlLambda2Type":
                    Services.Stroe.ECUSetting.Lambda2Type = (Models.Enums.LambdaTypes)
                        Enum.Parse(typeof(Models.Enums.LambdaTypes), ddl.SelectedValue.ToString());
                    break;
                default:
                    return;
            }
            Store.SaveChanges();
        }

        private void ChangeLV()
        {
            if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.IGT)
            {
                Store.ECUSetting.GasLevel[0] = 1.1f;
                Store.ECUSetting.GasLevel[1] = 2.3f;
                Store.ECUSetting.GasLevel[2] = 3.2f;
                Store.ECUSetting.GasLevel[3] = 4.2f;
            }
            if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.ZeroTo90ohm)
            {
                Store.ECUSetting.GasLevel[0] = 0.3f;
                Store.ECUSetting.GasLevel[1] = 0.9f;
                Store.ECUSetting.GasLevel[2] = 1.5f;
                Store.ECUSetting.GasLevel[3] = 2.0f;
            }
        }
        private void numu_ValueChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {
                case "numuLV1":
                    if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.NotStandard)
                        Store.ECUSetting.GasLevel[0] = Convert.ToSingle(numu.Value);
                    else
                        Store.ECUSetting.GasLevel[0] = Convert.ToSingle(5-numu.Value);
                    break;
                case "numuLV2":
                    if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.NotStandard)
                        Store.ECUSetting.GasLevel[1] = Convert.ToSingle(numu.Value);
                    else
                        Store.ECUSetting.GasLevel[1] = Convert.ToSingle(5-numu.Value);
                    break;
                case "numuLV3":
                    if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.NotStandard)
                        Store.ECUSetting.GasLevel[2] = Convert.ToSingle(numu.Value);
                    else
                        Store.ECUSetting.GasLevel[2] = Convert.ToSingle(5-numu.Value);
                    break;
                case "numuLV4":
                    if (Store.ECUSetting.LevelIndicatorSens == Models.Enums.LevelIndicatorSensTypes.NotStandard)
                        Store.ECUSetting.GasLevel[3] = Convert.ToSingle(numu.Value);
                    else
                        Store.ECUSetting.GasLevel[3] = Convert.ToSingle(5-numu.Value);
                    break;
                case "numu1Hight":
                    //Services.Stroe.ECUSetting.Lambda1HV = Convert.ToSingle(numu1Hight.Value);
                    break;
                case "numu1Low":
                    //Services.Stroe.ECUSetting.Lambda1LV = Convert.ToSingle(numu1Low.Value);
                    break;
                case "numu2Hight":
                    //Services.Stroe.ECUSetting.Lambda2HV = Convert.ToSingle(numu2Hight.Value);
                    break;
                case "numu2Low":
                    //Services.Stroe.ECUSetting.Lambda2LV = Convert.ToSingle(numu2Low.Value);
                    break;
                case "numuDealy":
                    //Services.Stroe.ECUSetting.LambdaDelay = Convert.ToInt32(numuDealy.Value);
                    break;
                case "numuNumber":
                    //Services.Stroe.ECUSetting.LambdaInjectNum = Convert.ToInt32(numuNumber.Value);
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
            labReducerTempSens.Font = new Font(fontFamily, labReducerTempSens.Font.Size);
            labGasTempSens.Font = new Font(fontFamily, labGasTempSens.Font.Size);
            labLevelIndicatorSens.Font = new Font(fontFamily, labLevelIndicatorSens.Font.Size);

          //  labGasLevel.Font = new Font(fontFamily, labGasLevel.Font.Size);
            labLambdaType.Font = new Font(fontFamily, labLambdaType.Font.Size);
            labLambda1Type.Font = new Font(fontFamily, labLambda1Type.Font.Size);
            label4.Font = new Font(fontFamily, label4.Font.Size);
            ddlReducerTempSens.Font = new Font(fontFamily, ddlReducerTempSens.Font.Size);
            ddlGasTempSens.Font = new Font(fontFamily, ddlGasTempSens.Font.Size);
            ddlLevelIndicatorSens.Font = new Font(fontFamily, ddlLevelIndicatorSens.Font.Size);
            ddlO2Number.Font = new Font(fontFamily, ddlO2Number.Font.Size);//LDC
            ddlO2Type.Font = new Font(fontFamily, ddlO2Number.Font.Size);//LDC
            ddlLambda1Type.Font = new Font(fontFamily, ddlLambda1Type.Font.Size);
            ddlLambda2Type.Font = new Font(fontFamily, ddlLambda2Type.Font.Size);
            labReducerTempSens.Text = LangWords["304_1"];
            labGasTempSens.Text = LangWords["304_2"];
            labLevelIndicatorSens.Text = LangWords["304_3"];
            //ddlO2Number.Text = LangWords["304_3"];//LDC
         //   labGasLevel.Text = LangWords["304_4"];
            //labLambdaType.Text = string.Format(LangWords["304_12"], "1");//304_12=氧传感器{0}类型
            labLambdaType.Text = LangWords["304_12"];
            //labLambda2Type.Text = string.Format(LangWords["304_12"], "2");
            labLambda1Type.Text=LangWords["304_50"];
            label4.Text = LangWords["304_51"];
            LambdaNum.Text = LangWords["304_60"];
            //lab1Hight.Font = new Font(fontFamily, lab1Hight.Font.Size);
            //lab1Low.Font = new Font(fontFamily, lab1Low.Font.Size);
            //lab2Hight.Font = new Font(fontFamily, lab2Hight.Font.Size);
            //lab2Low.Font = new Font(fontFamily, lab2Low.Font.Size);
            //labDealy.Font = new Font(fontFamily, labDealy.Font.Size);
            //labNumber.Font = new Font(fontFamily, labNumber.Font.Size);

            var word = Services.Lang.CurrentWords;
            //lab1Hight.Text = word["310_2"];
            //lab1Low.Text = word["310_3"];
            //lab2Hight.Text = word["310_2"];
            //lab2Low.Text = word["310_3"];
            //labDealy.Text = word["310_4"];
            //labNumber.Text = word["310_5"];
            ddlReducerTempSens.DisplayMember = "Key";
            ddlReducerTempSens.ValueMember = "Value";
            ddlGasTempSens.DisplayMember = "Key";
            ddlGasTempSens.ValueMember = "Value";
            ddlLevelIndicatorSens.DisplayMember = "Key";
            ddlLevelIndicatorSens.ValueMember = "Value";
            ddlO2Number.DisplayMember = "Key";
            ddlO2Number.ValueMember = "Value";
            ddlO2Type.DisplayMember = "Key";
            ddlO2Type.ValueMember = "Value";
            var ds1 = new KeyValuePair<String, String>[3]{
                new KeyValuePair<String, String>(LangWords["304_16"], Models.Enums.TempSensTypes.Ohm10K.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_17"], Models.Enums.TempSensTypes.Ohm8K5.ToString()),//LDC删除
                //new KeyValuePair<String, String>(LangWords["304_18"], Models.Enums.TempSensTypes.Ohm5K.ToString()),
                new KeyValuePair<String, String>(LangWords["304_19"] , Models.Enums.TempSensTypes.Ohm4K7.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_20"], Models.Enums.TempSensTypes.Ohm2K2.ToString()),
                new KeyValuePair<String, String>(LangWords["304_21"], Models.Enums.TempSensTypes.Ohm2K.ToString())
            };
            ddlReducerTempSens.DataSource = ds1;
            var ds2 = new KeyValuePair<String, String>[3]{
                new KeyValuePair<String, String>(LangWords["304_16"], Models.Enums.TempSensTypes.Ohm10K.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_17"], Models.Enums.TempSensTypes.Ohm8K5.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_18"], Models.Enums.TempSensTypes.Ohm5K.ToString()),
                new KeyValuePair<String, String>(LangWords["304_19"] , Models.Enums.TempSensTypes.Ohm4K7.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_20"], Models.Enums.TempSensTypes.Ohm2K2.ToString()),
                new KeyValuePair<String, String>(LangWords["304_21"], Models.Enums.TempSensTypes.Ohm2K.ToString())
            };
            ddlGasTempSens.DataSource = ds2;
            var ds3 = new KeyValuePair<String, String>[4]{
                new KeyValuePair<String, String>(LangWords["304_22"], Models.Enums.LevelIndicatorSensTypes.IGT.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_23"], Models.Enums.LevelIndicatorSensTypes.Lovato.ToString()),
                new KeyValuePair<String, String>(LangWords["304_24"], Models.Enums.LevelIndicatorSensTypes.ZeroTo90ohm.ToString()),
                new KeyValuePair<String, String>(LangWords["304_52"], Models.Enums.LevelIndicatorSensTypes.NotStandard.ToString()),
                new KeyValuePair<String, String>(LangWords["304_53"], Models.Enums.LevelIndicatorSensTypes.NotStandardInverted.ToString()),
           //     new KeyValuePair<String, String>("", Models.Enums.LevelIndicatorSensTypes.Unknow.ToString())
                //new KeyValuePair<String, String>(LangWords["304_25"], Models.Enums.LevelIndicatorSensTypes.ZeroTo110ohm.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_26"], Models.Enums.LevelIndicatorSensTypes.HundredTo10Kohm.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_27"], Models.Enums.LevelIndicatorSensTypes.ZeroTo90ohm_2.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_28"], Models.Enums.LevelIndicatorSensTypes.NinetyTo0ohm.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_29"], Models.Enums.LevelIndicatorSensTypes.HundredTenTo0ohm.ToString()),
                //new KeyValuePair<String, String>(LangWords["304_30"], Models.Enums.LevelIndicatorSensTypes.TenKTo100ohm.ToString())
            };
            ddlLevelIndicatorSens.DataSource = ds3;
            //var ds4 = new KeyValuePair<String, String>[2]{
            //    new KeyValuePair<String, String>(LangWords["304_22"], Models.O2Numbers.ToString()),
            //    new KeyValuePair<String, String>(LangWords["304_24"], Models.O2Numbers.ToString()),
            //};
            //ddlLevelIndicatorSens.DataSource = ds4;

            List<KeyValuePair<String, string>> ds4 = new List<KeyValuePair<string, string>>();
            ds4.Add(new KeyValuePair<String, string>("1","1"));
            ds4.Add(new KeyValuePair<String, string>("2","2"));
            //if (Device.DeviceInfo.HardInof.SumCylinders >= 6) ds1.Add(new KeyValuePair<string, string>("6" + Words["302_2"], "6"));//LDC
            //if (Device.DeviceInfo.HardInof.SumCylinders >= 8) ds1.Add(new KeyValuePair<string, string>("8" + Words["302_2"], "8"));
            ddlO2Number.DataSource = ds4.ToArray();





            ddlLambda1Type.DisplayMember = "Key";
            ddlLambda1Type.ValueMember = "Value";
            ddlLambda2Type.DisplayMember = "Key";
            ddlLambda2Type.ValueMember = "Value";
            var ds5 = new KeyValuePair<String, String>[]{
                //new KeyValuePair<String,String>(LangWords["304_9"], Models.Enums.LambdaTypes.Voltage.ToString()),
                //new KeyValuePair<String,String>(LangWords["304_10"], Models.Enums.LambdaTypes.Reverse.ToString()),
                //new KeyValuePair<String,String>(LangWords["304_11"], Models.Enums.LambdaTypes.UEGO.ToString()),
            new KeyValuePair<String, String>(LangWords["304_54"] , Models.Enums.LambdaTypes.Befor.ToString()),
            new KeyValuePair<String, String>(LangWords["304_55"] , Models.Enums.LambdaTypes.After.ToString()),
            new KeyValuePair<String, String>(LangWords["304_8"] , Models.Enums.LambdaTypes.NoConnection.ToString())
 
            };
            ddlLambda1Type.DataSource = ds5;
            ddlLambda2Type.DataSource = ds5.Clone();

            var ds6 = new KeyValuePair<String, String>[]{
            new KeyValuePair<String, String>(LangWords["304_56"] , Models.Enums.LambdaTypes.Volt0_1.ToString()),
            new KeyValuePair<String, String>(LangWords["304_57"] , Models.Enums.LambdaTypes.Volt0_5.ToString()),
            new KeyValuePair<String, String>(LangWords["304_58"] , Models.Enums.LambdaTypes.Volt5_0.ToString()),
             new KeyValuePair<String, String>(LangWords["304_59"] , Models.Enums.LambdaTypes.Volt08_16.ToString())
            };
            ddlO2Type.DataSource = ds6;



            IsInit = false;
        }
        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }

        #endregion
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }
        bool IsInit = true;

        private void labLambda1Type_Click(object sender, EventArgs e)
        {

        }

        private void labLambdaType_Click(object sender, EventArgs e)
        {

        }
        //public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }
        //bool Init = false;
    }
}
