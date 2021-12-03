using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IGT.Service;//LDC增加



namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class CarParametersSettings : UserControl, ISettingPanel
    {
        public CarParametersSettings()
        {
            InitializeComponent();
            ApplyLang();
        }
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }

        void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var cb = sender as CheckBox;
            switch (cb.Name)
            {
                case "cbInjectorPositiveDriver":
                    Store.ECUSetting.InjectorPositiveDriver = cb.Checked;break;
                case "labRPMTyp":
                    if (cb.Checked)
                    {
                        ddlRPMSource.Enabled = true;
                        ddlSingalType.Enabled = true;

                    }
                    else
                    {
                        ddlRPMSource.Enabled = false;
                        ddlSingalType.Enabled = false;
                    }
                    Store.ECUSetting.RPMInjectionSelect = !cb.Checked;//LDC RPMInjectionSelect增加
                    break;
                //

                default:
                    return;
            }
            Store.SaveChanges();
        }
        void DDL_SelectIndexChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var ddl = sender as ComboBox;
            switch (ddl.Name)
            {
                case "ddlCylinders":
                    var temp = int.Parse(ddlCylinders.SelectedValue.ToString());
                    Store.ECUSetting.Cylinders = temp;
                    break;
                //case "ddlCoilNums"://LDC转速信号类型 删除 
                //    Store.ECUSetting.Coils = int.Parse(ddl.SelectedValue.ToString());//model.RevolutionSignalType
                //    break;//
                case "ddlInjectionModes":
                    Store.ECUSetting.InjectionMode = (Models.Enums.InjectionModes)Enum.Parse(typeof(Models.Enums.InjectionModes), ddl.SelectedValue.ToString());
                    switch (Store.ECUSetting.InjectionMode)
                    {
                        case IGT.Models.Enums.InjectionModes.Sequential:
                            Store.ECUSetting.BaseData[0] = (byte)(Store.ECUSetting.BaseData[0] & 0xBF);
                            Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] & 0xBF);
                            break;
                        case IGT.Models.Enums.InjectionModes.SemiSequential:
                            Store.ECUSetting.BaseData[0] = (byte)(Store.ECUSetting.BaseData[0] & 0xBF);
                            Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] | 0x40);
                            break;
                        case IGT.Models.Enums.InjectionModes.FullGroup:
                            Store.ECUSetting.BaseData[0] = (byte)(Store.ECUSetting.BaseData[0] | 0x40);
                            Store.ECUSetting.BaseData[3] = (byte)(Store.ECUSetting.BaseData[3] & 0xBF);
                            break;
                       default:
                           throw new ArgumentException();
                    }
                    break;
                case "ddlSingalType"://LDC转速信号类型 增加 
                    Store.ECUSetting.RevolutionSignalType = (Models.Enums.RevolutionSignalTypes)Enum.Parse(typeof(Models.Enums.RevolutionSignalTypes), ddl.SelectedValue.ToString());
                    break;
                case "ddlRPMSource":
                    Store.ECUSetting.RPMSource = (Models.Enums.RPMSources)Enum.Parse(typeof(Models.Enums.RPMSources), ddl.SelectedValue.ToString());
                    break;
                case "ddlEngineType":
                    Store.ECUSetting.EngineType = (Models.Enums.EngineTypes)Enum.Parse(typeof(Models.Enums.EngineTypes), ddlEngineType.SelectedValue.ToString());
                    break;
                case "ddlMode":
                    //Store.ECUSetting.SwitchMode =
                    //    (Models.Enums.SwitchModes)Enum.Parse(typeof(Models.Enums.SwitchModes), ddl.SelectedValue.ToString());
                    //Store.ECUSetting.SwitchRPM = int.Parse(ddlSpeed.SelectedItem.ToString());
                    //break;
                    Store.ECUSetting.SwitchMode =
                        (Models.Enums.SwitchModes)Enum.Parse(typeof(Models.Enums.SwitchModes), ddl.SelectedValue.ToString());
                    if (Store.ECUSetting.SwitchMode==Models.Enums.SwitchModes.StartOnGas)
                    {
                        ddlSpeed.SelectedItem = "0";
                        Store.ECUSetting.SwitchRPM = 0;
                        ddlSpeed.Enabled = false;
                        break;
                    }
                    ddlSpeed.Enabled = true;
                    ddlSpeed.SelectedItem = "1600";
                    Store.ECUSetting.SwitchRPM = int.Parse(ddlSpeed.SelectedItem.ToString());
                    break;
                case "ddlSpeed"://comboBox2.SelectedItem.ToString()
                    Store.ECUSetting.SwitchMode =
                        (Models.Enums.SwitchModes)Enum.Parse(typeof(Models.Enums.SwitchModes), ddlMode.SelectedValue.ToString());
                    Store.ECUSetting.SwitchRPM = int.Parse(ddl.SelectedItem.ToString());
                    break;
                case "ddlTemp":
                    Store.ECUSetting.SwitchTemp = Convert.ToSByte(ddl.SelectedItem.ToString());
                    break;
                case "ddlInject"://ddlInject
                    Store.ECUSetting.InjectorType = (Models.Enums.InjectorTypes)Enum.Parse(typeof(Models.Enums.InjectorTypes), ddl.SelectedValue.ToString());
                    enable4CustomInjector();
                    break;
                default:
                    return;
            }
            Store.SaveChanges();
        }
        private void enable4CustomInjector()
        {
            bool enable = Services.Stroe.ECUSetting.InjectorType == Models.Enums.InjectorTypes.Custom;
            btnInjectorParam.Visible = enable;
        }
        private void numuRPMVoltage_ValueChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {
                case "numuRPMVoltage":
                    Store.ECUSetting.RPMVoltage = Convert.ToSingle(numu.Value); break;
                case "numuIdentTime":
                    Store.ECUSetting.ExtraInjectionIdentTime = Convert.ToInt32(numu.Value); break;
                case "numuOrderDelay":
                    Store.ECUSetting.OrderDelay = Convert.ToInt32(numu.Value);
                    break;
                case "numuOverlapTimes":
                    Store.ECUSetting.OverlapTimes = Convert.ToSingle(numu.Value);
                    break;
                default:
                    return;
            }
            Store.SaveChanges();
        }
        public void ShowData()//标准设置界面 设置项的数据载入
        {
            IsInit = true;
            FixOverData();
            var setting = Store.ECUSetting;
            rbCNG.Checked = Store.ECUSetting.FuelType == Models.Enums.FuelTypes.CNG;
            rbLPG.Checked = Store.ECUSetting.FuelType == Models.Enums.FuelTypes.LPG;

            if (Store.ECUSetting.SwitchMode == Models.Enums.SwitchModes.StartOnGas)
            {
                // Store.ECUSetting.SwitchRPM = 0;
                ddlSpeed.Enabled = false;
                ddlMode.Enabled = false;
                ddlMode.SelectedValue = "";
                ddlSpeed.SelectedValue = "";
            }
            else
            {
                ddlMode.Enabled = true;
                ddlMode.SelectedValue = Store.ECUSetting.SwitchMode.ToString();
                ddlSpeed.Enabled = true;
            }


            ddlSpeed.SelectedItem = Store.ECUSetting.SwitchRPM.ToString();
            //ddlSpeed.SelectedItem = "2500";//
            ddlTemp.SelectedItem = Store.ECUSetting.SwitchTemp.ToString();
            numuOrderDelay.Value = Store.ECUSetting.OrderDelay;
            numuOverlapTimes.Value = Convert.ToDecimal(Store.ECUSetting.OverlapTimes);
            cbHotStart.Checked = Store.ECUSetting.HotStart;

            labRPMTyp.Checked = !Store.ECUSetting.RPMInjectionSelect;
            if (Store.ECUSetting.InjectorType == Models.Enums.InjectorTypes.Unknow)
                ddlInject.SelectedValue = "";
            else
                ddlInject.SelectedValue = Services.Stroe.ECUSetting.InjectorType.ToString();

            //if (ddlInject.SelectedIndex  ==3)
            //{
            //    btnInjectorParam.Visible = true;
            //}
            ddlCylinders.SelectedValue = setting.Cylinders.ToString();
            ddlSingalType.SelectedValue = setting.RevolutionSignalType.ToString();
            ddlInjectionModes.SelectedValue = setting.InjectionMode.ToString();
            ddlRPMSource.SelectedValue = setting.RPMSource.ToString();
            numuRPMVoltage.Value = (decimal)Store.ECUSetting.RPMVoltage;
            cbInjectorPositiveDriver.Checked = setting.InjectorPositiveDriver;
            ddlEngineType.SelectedValue = setting.EngineType.ToString();
            if (labRPMTyp.Checked)
            {
                ddlRPMSource.Enabled = true;
                ddlSingalType.Enabled = true;

            }
            else
            {
                ddlRPMSource.Enabled = false;
                ddlSingalType.Enabled = false;
            }
            IsInit = false;
        }
        void FixOverData()
        {
          bool change = Store.ECUSetting.RPMVoltage > Convert.ToSingle(numuRPMVoltage.Maximum) || Store.ECUSetting.RPMVoltage < Convert.ToSingle(numuRPMVoltage.Minimum)||
          Store.ECUSetting.OrderDelay > Convert.ToInt32(numuOrderDelay.Maximum) || Store.ECUSetting.OrderDelay < Convert.ToInt32(numuOrderDelay.Minimum) ||
          Store.ECUSetting.OverlapTimes > Convert.ToSingle(numuOverlapTimes.Maximum) || Store.ECUSetting.OverlapTimes < Convert.ToSingle(numuOverlapTimes.Minimum);
            if (Store.ECUSetting.OrderDelay > Convert.ToInt32(numuOrderDelay.Maximum))
                Store.ECUSetting.OrderDelay = Convert.ToInt32(numuOrderDelay.Maximum);
            if (Store.ECUSetting.OrderDelay < Convert.ToInt32(numuOrderDelay.Minimum))
                Store.ECUSetting.OrderDelay = Convert.ToInt32(numuOrderDelay.Minimum);
            if (Store.ECUSetting.OverlapTimes > Convert.ToSingle(numuOverlapTimes.Maximum))
                Store.ECUSetting.OverlapTimes = Convert.ToSingle(numuOverlapTimes.Maximum);
            if (Store.ECUSetting.OverlapTimes < Convert.ToSingle(numuOverlapTimes.Minimum))
                Store.ECUSetting.OverlapTimes = Convert.ToSingle(numuOverlapTimes.Minimum);
            if (Store.ECUSetting.RPMVoltage > Convert.ToSingle(numuRPMVoltage.Maximum))
                Store.ECUSetting.RPMVoltage = Convert.ToSingle(numuRPMVoltage.Maximum);
            if (Store.ECUSetting.RPMVoltage < Convert.ToSingle(numuRPMVoltage.Minimum))
                Store.ECUSetting.RPMVoltage = Convert.ToSingle(numuRPMVoltage.Minimum);
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
                default:
                    return;
            }
        }
        void RadioBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var temp = rbLPG.Checked ? Models.Enums.FuelTypes.LPG : Models.Enums.FuelTypes.CNG;
            Store.ECUSetting.FuelType = temp;
            if (temp == Models.Enums.FuelTypes.LPG)
            {
               Store.ECUSetting.BaseData[0] = (byte)(Store.ECUSetting.BaseData[0] & 0xFD);
               float[] Items = new float[] { 0.43f, 0.49f, 0.54f, 0.58f,0.62f,0.66f,0.70f,0.74f,0.78f,0.82f,0.86f,0.90f,0.95f,1.0f,1.1f };
               float[] Corrections = new float[] { 38.1f, 32.77f, 28.17f, 24.64f,21.25f,17.96f,14.75f,11.65f,8.63f,5.67f,2.81f,0,-3.43f,-6.75f,-13.18f };
            //   Store.CorrectionSetting.GasPress.Items = new NotityArray<float>(Items);//new float[] { }              
               for (int i = 0; i < 15;i++ )
               {
                   Store.CorrectionSetting.GasPress.Items[i] = Items[i];
               }
               for (int i = 0; i < 15; i++)
               {
                   Store.CorrectionSetting.GasPress.Corrections[i] = Corrections[i];
               }
                   //      Store.CorrectionSetting.GasPress.Corrections = new NotityArray<float>(Corrections);
                Store.ECUSetting.OperationalPress=0.95f;
                Store.ECUSetting.MinimumPress = 0.5f;
            }
            else
            {
                Store.ECUSetting.BaseData[0] = (byte)(Store.ECUSetting.BaseData[0] | 0x02);
                float[] Items = new float[] { 1.14f, 1.2f, 1.26f, 1.32f, 1.38f,1.44f, 1.50f, 1.56f, 1.62f, 1.68f, 1.74f, 1.8f, 1.90f, 2.0f, 2.1f };
                float[] Corrections = new float[] { 25.51f, 22.94f, 20.42f, 18.00f, 15.55f, 13.19f, 10.89f, 8.63f, 6.41f, 4.24f, 2.1f, 0, -3.43f, -6.75f, -10.01f };        
                for (int i = 0; i < 15; i++)
                {
                    Store.CorrectionSetting.GasPress.Items[i] = Items[i];
                }
                for (int i = 0; i < 15; i++)
                {
                    Store.CorrectionSetting.GasPress.Corrections[i] = Corrections[i];
                }
                Store.ECUSetting.OperationalPress = 1.8f;
                Store.ECUSetting.MinimumPress = 1.13f;
            }
            Store.SaveChanges();
            this.Cursor = Cursors.WaitCursor;//等待
            System.Threading.Thread.Sleep(1000);
            this.Cursor = Cursors.Default;//正常状态
          //  Store.CorrectionSetting.GasPress.Corrections.

        }
        private void cb_Checked(object sender, EventArgs e)
        {
            if (IsInit) return;
            var cb = sender as CheckBox;
            Store.ECUSetting.HotStart = cb.Checked;
            if (cb.Checked)
                Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] | 0x02);
            else
                Store.ECUSetting.ExtraData[0] = (byte)(Store.ECUSetting.ExtraData[0] & 0xFD);
            Store.SaveChanges();
        }
        private void ApplyLang()
        {
            IsInit = true;
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            //labCylinders.Font = new Font(fontFamily, labCylinders.Font.Size);
            labCoilNums.Font = new Font(fontFamily, labCoilNums.Font.Size);
            labInjectionModes.Font = new Font(fontFamily, labInjectionModes.Font.Size);
            //labRPMSource.Font = new Font(fontFamily, labRPMSource.Font.Size);
            labRPMTyp.Font = new Font(fontFamily, labRPMTyp.Font.Size);//LDC
            labRPMVoltage.Font = new Font(fontFamily, labRPMVoltage.Font.Size);
            labEngineType.Font = new Font(fontFamily, labEngineType.Font.Size);
            cbInjectorPositiveDriver.Font = new Font(fontFamily, cbInjectorPositiveDriver.Font.Size);
            ddlCylinders.Font = new Font(fontFamily, ddlCylinders.Font.Size);
            ddlSingalType.Font = new Font(fontFamily, ddlSingalType.Font.Size);
            ddlInjectionModes.Font = new Font(fontFamily, ddlInjectionModes.Font.Size);
            ddlRPMSource.Font = new Font(fontFamily, ddlRPMSource.Font.Size);
            ddlEngineType.Font = new Font(fontFamily, ddlEngineType.Font.Size);
            labFuelType.Text = Words["302_1"];
            labCoilNums.Text = Words["302_3"];
            labInjectionModes.Text = Words["302_8"];
            //labRPMSource.Text = Words["302_12"];
            labRPMTyp.Text = Words["302_12"];//LDC
            labRPMVoltage.Text = Words["302_17"];
            labEngineType.Text = Words["302_20"];
            cbInjectorPositiveDriver.Text = Words["302_18"];
            CylinderNumber.Text = Words["302_25"];
            ddlCylinders.DisplayMember = "Key";
            ddlCylinders.ValueMember = "Value";
            ddlSingalType.DisplayMember = "Key";
            ddlSingalType.ValueMember = "Value";
            ddlInjectionModes.DisplayMember = "Key";
            ddlInjectionModes.ValueMember = "Value";
            ddlRPMSource.DisplayMember = "Key";
            ddlRPMSource.ValueMember = "Value";
            ddlEngineType.DisplayMember = "Key";
            ddlEngineType.ValueMember = "Value";
            List<KeyValuePair<String, string>> ds1 = new List<KeyValuePair<string, string>>();
            if (Device.DeviceInfo.HardInof.SumCylinders >= 2) ds1.Add(new KeyValuePair<String, string>("2" + Words["302_2"], "2"));
            if (Device.DeviceInfo.HardInof.SumCylinders >= 3) ds1.Add(new KeyValuePair<String, string>("3" + Words["302_2"], "3"));
            if (Device.DeviceInfo.HardInof.SumCylinders >= 4) ds1.Add(new KeyValuePair<String, string>("4" + Words["302_2"], "4"));
            if (Device.DeviceInfo.HardInof.SumCylinders >= 5) ds1.Add(new KeyValuePair<String, string>("5" + Words["302_2"], "5"));
            if (Device.DeviceInfo.HardInof.SumCylinders >= 6) ds1.Add(new KeyValuePair<String, string>("6" + Words["302_2"], "6"));
            if (Device.DeviceInfo.HardInof.SumCylinders >= 8) ds1.Add(new KeyValuePair<String, string>("8" + Words["302_2"], "8"));
            //if (Device.DeviceInfo.HardInof.SumCylinders >= 6) ds1.Add(new KeyValuePair<string, string>("6" + Words["302_2"], "6"));//LDC
            //if (Device.DeviceInfo.HardInof.SumCylinders >= 8) ds1.Add(new KeyValuePair<string, string>("8" + Words["302_2"], "8"));
            ddlCylinders.DataSource = ds1.ToArray();
            //List<KeyValuePair<String, String>> ds2 = new List<KeyValuePair<string, String>>();
            //ds2.Add(new KeyValuePair<String, String>(Words["302_4"], "1"));
            //ds2.Add(new KeyValuePair<String, String>(Words["302_5"], "2"));
            //ds2.Add(new KeyValuePair<String, String>("3" + Words["302_6"], "3"));
            //ds2.Add(new KeyValuePair<String, String>("4" + Words["302_6"], "4"));
            //if (Device.DeviceInfo.HardInof.SumCylinders >= 6)
            //    ds2.Add(new KeyValuePair<String, String>("6" + Words["302_6"], "6"));//LDC转速信号类型 删除
            //if (Device.DeviceInfo.HardInof.SumCylinders >= 8)
            //    ds2.Add(new KeyValuePair<String, String>("8" + Words["302_6"], "8"));
            KeyValuePair<String, String>[] ds2 = new KeyValuePair<string, String>[2];
            ds2[0] = new KeyValuePair<String, String>(Words["302_23"], Models.Enums.RevolutionSignalTypes.Standard.ToString());
            ds2[1] = new KeyValuePair<String, String>(Words["302_24"], Models.Enums.RevolutionSignalTypes.Weak.ToString());
            ddlSingalType.DataSource = ds2;
            KeyValuePair<String, String>[] ds3 = new KeyValuePair<string, String>[3];
            ds3[0] = new KeyValuePair<String, String>(Words["302_9"], Models.Enums.InjectionModes.Sequential.ToString());
            ds3[1] = new KeyValuePair<String, String>(Words["302_10"], Models.Enums.InjectionModes.SemiSequential.ToString());
            ds3[2] = new KeyValuePair<String, String>(Words["302_11"], Models.Enums.InjectionModes.FullGroup.ToString());
            ddlInjectionModes.DataSource = ds3;
            KeyValuePair<String, String>[] ds4 = new KeyValuePair<string, String>[4];
            //ds4[0] = new KeyValuePair<String, String>(Words["302_14"], Models.Enums.RPMSources.Injector.ToString());
            //ds4[1] = new KeyValuePair<String, String>(Words["302_15"], Models.Enums.RPMSources.Coil.ToString());
            //ds4[2] = new KeyValuePair<String, String>(Words["302_13"], Models.Enums.RPMSources.CamshaftSensor.ToString());
            //ds4[3] = new KeyValuePair<String, String>(Words["302_16"], Models.Enums.RPMSources.Auto.ToString());
            ds4[0] = new KeyValuePair<String, String>(Words["302_13"], Models.Enums.RPMSources.OneCoil.ToString());
            ds4[1] = new KeyValuePair<String, String>(Words["302_14"], Models.Enums.RPMSources.TwoCoils.ToString());
            ds4[2] = new KeyValuePair<String, String>(Words["302_15"], Models.Enums.RPMSources.RPMSensor.ToString());
            ds4[3] = new KeyValuePair<String, String>(Words["302_16"], Models.Enums.RPMSources.RPMSensor2.ToString());
            ddlRPMSource.DataSource = ds4;
            KeyValuePair<String, String>[] ds5 = new KeyValuePair<string, String>[2];
            ds5[0] = new KeyValuePair<String, String>(Words["302_21"], Models.Enums.EngineTypes.Standard.ToString());
            ds5[1] = new KeyValuePair<String, String>(Words["302_22"], Models.Enums.EngineTypes.Turbo.ToString());
            ddlEngineType.DataSource = ds5;
            rbCNG.Font = new Font(fontFamily, rbCNG.Font.Size);
            rbLPG.Font = new Font(fontFamily, rbLPG.Font.Size);
            labTemp.Font = new Font(fontFamily, labTemp.Font.Size);
            labSpeed.Font = new Font(fontFamily, labSpeed.Font.Size);
            labMode.Font = new Font(fontFamily, labMode.Font.Size);
            labOverlapTimes.Font = new Font(fontFamily, labOverlapTimes.Font.Size);
            labOrderDelay.Font = new Font(fontFamily, labOrderDelay.Font.Size);
            cbHotStart.Font = new Font(fontFamily, cbHotStart.Font.Size);
            btnInjectorParam.Font = new Font(fontFamily, btnInjectorParam.Font.Size);
            labInject.Font = new Font(fontFamily, labInject.Font.Size);
            ddlMode.Font = new Font(fontFamily, ddlMode.Font.Size);
            ddlTemp.Font = new Font(fontFamily, ddlTemp.Font.Size);
            ddlInject.Font = new Font(fontFamily, ddlInject.Font.Size);

            rbCNG.Text = Words["303_3"];
            rbLPG.Text = Words["303_2"];
            labTemp.Text = Words["303_4"];
            labSpeed.Text = Words["303_5"];
            labMode.Text = Words["303_6"];
            labOverlapTimes.Text = Words["303_7"];
            labOrderDelay.Text = Words["303_12"];
            cbHotStart.Text = Words["303_16"];

            btnInjectorParam.Text =Words["303_34"];
            labInject.Text = Words["303_19"];

            ddlMode.DisplayMember = "Key";
            ddlMode.ValueMember = "Value";
            KeyValuePair<String, String>[] data1 = new KeyValuePair<string, string>[2];
            data1[0] = new KeyValuePair<string, string>(Words["303_10"], Models.Enums.SwitchModes.InAcceleration.ToString());
            data1[1] = new KeyValuePair<string, string>(Words["303_11"], Models.Enums.SwitchModes.InDecelertion.ToString());
       //     data1[2] = new KeyValuePair<string, string>(Words["303_44"], Models.Enums.SwitchModes.StartOnGas.ToString());
            ddlMode.DataSource = data1;
            KeyValuePair<String, String>[] data2 = new KeyValuePair<string, string>[3];
            data2[0] = new KeyValuePair<string, string>(Words["303_24"], Models.Enums.GasStrategies.KeepGas.ToString());
            data2[1] = new KeyValuePair<string, string>(Words["303_25"], Models.Enums.GasStrategies.SwitchOil.ToString());
            data2[2] = new KeyValuePair<string, string>(Words["303_26"], Models.Enums.GasStrategies.OilCompensation.ToString());
            for (int i = 0; i <= 90; i++)
            {
                ddlTemp.Items.Add(i.ToString());
            }
            for (int i = 600; i <= 3500; i = i + 100)
            {
                ddlSpeed.Items.Add(i.ToString());
            }
            ddlInject.DisplayMember = "Key";
            ddlInject.ValueMember = "Value";
            KeyValuePair<String, String>[] data3 = new KeyValuePair<string, string>[4];
            data3[0] = new KeyValuePair<string, string>("IGT", Models.Enums.InjectorTypes.IGT.ToString());
            data3[1] = new KeyValuePair<string, string>("Matrix", Models.Enums.InjectorTypes.Matrix.ToString());
            data3[2] = new KeyValuePair<string, string>("3ohm", Models.Enums.InjectorTypes.ThreeOhm.ToString());
            data3[3] = new KeyValuePair<string, string>("1ohm", Models.Enums.InjectorTypes.OneOhm.ToString());
   //       data3[3] = new KeyValuePair<string, string>(Words["303_27"], Models.Enums.InjectorTypes.Custom.ToString());
            ddlInject.DataSource = data3;
            IsInit = false;
        }
        Dictionary<String, String> Words { get { return Services.Lang.CurrentWords; } }
        public IGT.Service.PLC.Device Device { get { return Services.Device; } }
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }
        bool IsInit = true;
    }
}
