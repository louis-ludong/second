using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using IGT.Service;
namespace IGT.UI.Client.Pages
{
    /// <summary>
    /// 诊断页
    /// </summary>
    public partial class Diagnosis : UserControl, IPage
    {
        //public Diagnosis()
        //{
        //    IsReadly = false;
        //    InitializeComponent();
        //    btnResetErrors.BackColor = Color .FromArgb (245,130,31);
        //    btnOBDErrors.BackColor = Color.FromArgb(245, 130, 31);
        //    OnOffSet = new Models.Feedback.Bank<bool[]>[2];
        //    OnOffSet[0] = new Models.Feedback.Bank<bool[]>() { Name = "Bank1" };
        //    OnOffSet[0].Data = new bool[] { true, true, true, true, true, true, true, true };
        //    OnOffSet[1] = new Models.Feedback.Bank<bool[]>() { Name = "Bank2" };
        //    OnOffSet[1].Data = new bool[] { true, true, true, true, true, true, true, true };
        //    GasDiaLines = new List<UserControls.DiaLine>(){
        //        diaLine1,diaLine2,diaLine3,diaLine4,diaLine5,diaLine6,diaLine7,diaLine8
        //    };
        //    PertrolDiaLInes = new List<UserControls.DiaLine>(){
        //        diaLine9,diaLine10,diaLine11,diaLine12,diaLine13,diaLine14,diaLine15,diaLine16
        //    };
        //    if (!Services.Device.DeviceInfo.HardInof.ECUExtension)
        //        ddlBank.Items.RemoveAt(1);
        //    ddlBank.SelectedIndex = 0;
        //    ApplyLang();
        //    Services.Stroe.WaitReadyIfPLC(Service.Storage.SettingItems.ECUSetting);
        //    foreach (var item in GasDiaLines.Skip(Services.Stroe.ECUSetting.Cylinders))
        //        item.Visible = false;
        //    foreach (var item in PertrolDiaLInes.Skip(Services.Stroe.ECUSetting.Cylinders))
        //        item.Visible = false;
        //}


        public Diagnosis()
        {
            IsReadly = false;
            InitializeComponent();
            //  btnResetErrors.BackColor = Color .FromArgb (245,130,31);
            //btnOBDErrors.BackColor = Color.FromArgb(245, 130, 31);
            OnOffSet = new Models.Feedback.Bank<bool[]>[2];
            OnOffSet[0] = new Models.Feedback.Bank<bool[]>() { Name = "Bank1" };
            OnOffSet[0].Data = new bool[] { true, true, true, true, true, true, true, true };
            OnOffSet[1] = new Models.Feedback.Bank<bool[]>() { Name = "Bank2" };
            OnOffSet[1].Data = new bool[] { true, true, true, true, true, true, true, true };
            GasDiaLines = new List<UserControls.DiaLine>(){
                diaLine1,diaLine2,diaLine3,diaLine4,diaLine5,diaLine6,diaLine7,diaLine8
            };
            PertrolDiaLInes = new List<UserControls.DiaLine>(){
                diaLine9,diaLine10,diaLine11,diaLine12,diaLine13,diaLine14,diaLine15,diaLine16
            };
            if (!Services.Device.DeviceInfo.HardInof.ECUExtension)
                ddlBank.Items.RemoveAt(1);
            ddlBank.SelectedIndex = 0;
            // btnResetErrors.Visible = Services.Device.DeviceInfo.HardInof.ODB;
            ApplyLang();
            Services.Stroe.WaitReadyIfPLC(Service.Storage.SettingItems.ECUSetting);
            foreach (var item in GasDiaLines)
                item.Visible = false;
            foreach (var item in PertrolDiaLInes)
                item.Visible = false;
            int a = 0;
            int b = 0;
            switch (Services.Stroe.ECUSetting.Cylinders)
            {
                case 2:
                    a = 2;
                    b = 0;
                    break;
                case 3:
                    a = 3;
                    b = 0;
                    break;
                case 4:
                    a = 4;
                    b = 0;
                    break;
                case 5:
                    a = 3;
                    b = 2;
                    break;
                case 6:
                    a = 3;
                    b = 3;
                    break;
                case 8:
                    a = 4;
                    b = 4;
                    break;
            }
            for (int i = 0; i < a; i++)
            {
                GasDiaLines[i].Visible = true;
                PertrolDiaLInes[i].Visible = true;
            }
            for (int i = 4; i < 4 + b; i++)
            {
                GasDiaLines[i].Visible = true;
                PertrolDiaLInes[i].Visible = true;
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).MainMenu.HideAllMenus();
            //cbAutoDiagnosis.Checked = Services.Stroe.ECUSetting.AutoDiagnosis;
        }

        private void diaLine1_ClickON_OR_Off(object sender, bool on_or_off)
        {
            if (!IsReadly) return;
            var item = sender as UserControls.DiaLine;
            int index = GasDiaLines.IndexOf(item);
            lock (SyncRoot)
            {
                OnOffSet[ddlBank.SelectedIndex].Data[index] = on_or_off;
                //Services.Device.SendAndRead("Diagnosis", UIHelper.CancelBit_DiagnosisPage, Service.PLC.InstructionSet.SetInjectOnOff
                //    , new byte[]{ Service.PLC.ValueConvert.InjectOnOffValue(OnOffSet[0].Data)
                //,Service.PLC.ValueConvert.InjectOnOffValue(OnOffSet[1].Data)});
                Services.Device.SendAndRead("Diagnosis", UIHelper.CancelBit_DiagnosisPage, Service.PLC.InstructionSet.SetInjectOnOff
                    , new byte[]{ Service.PLC.ValueConvert.InjectOnOffValue(OnOffSet[0].Data)});
            }
        }

        #region IPage 成员

        public void LoadPage()
        {
            Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetDiagnosisDetails);
            IsReadly = true;
            Change4Connect();
        }

        public void UnLoadPage()
        {
            IsReadly = false;
            Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetDiagnosisDetails);
        }

        public void Change4Connect()
        {
            if (!Services.Device.Connect.IsConnected)
            {
                foreach (var item in GasDiaLines)
                {
                    item.MyEnable = false;
                }
            }
        }
        public void ProcessDiagnosisDetails(Models.Feedback.DiagnosisDetails model)
        {
            if (IsReadly) ShowDiagnosisDetails(model);
        }
        public void ProcessRealyTimeData(Models.Feedback.RealTimeData model) { }

        public void ProcessAutoCalbrationDetails(Models.Feedback.AutoCalibrationDetails model) { }

        public bool IsReadly { get; private set; }

        public Control AsControl { get { return this; } }

        #endregion
        #region Show

        //private void ShowDiagnosisDetails(Models.Feedback.DiagnosisDetails model)
        //{
        //    if (!IsReadly) return;
        //    int bank = Services.Device.DeviceInfo.HardInof.ECUExtension ? ddlBank.SelectedIndex : 0;
        //    labGasTime.Text = String.Format("{0}:{1}", (model.ECUWorkTime.Gas.Days * 24 + model.ECUWorkTime.Gas.Hours).ToString(),
        //         model.ECUWorkTime.Gas.Minutes >= 10 ? model.ECUWorkTime.Gas.Minutes.ToString() : "0" + model.ECUWorkTime.Gas.Minutes.ToString());
        //    labRedTime.Text = String.Format("{0}:{1}", (model.ECUWorkTime.Red.Days * 24 + model.ECUWorkTime.Red.Hours).ToString(),
        //        model.ECUWorkTime.Red.Minutes >= 10 ? model.ECUWorkTime.Red.Minutes.ToString() : "0" + model.ECUWorkTime.Red.Minutes.ToString());

        //    var temp = model.InjectOnOffs[ddlBank.SelectedIndex].Data;//喷轨测试状态
        //    var enable = model.InjectTimes[ddlBank.SelectedIndex].Gas.Any(m => m > 0);//有喷油时间就为真
        //    for (int i = 0; i < Services.Stroe.ECUSetting.Cylinders; i++)
        //    {
        //        GasDiaLines[i].RightLabel = model.InjectTimes[bank].Gas[i].ToString("N02");
        //        GasDiaLines[i].ON = temp[i]&&enable;
        //        PertrolDiaLInes[i].RightLabel = model.InjectTimes[bank].Pertrol[i].ToString("N02");
        //        PertrolDiaLInes[i].ON = model.InjectTimes[bank].Pertrol[i] > 0;
        //    }
        //    if(Raw==null)
        //    {
        //        lock (SyncRoot)//LDC
        //        {
        //            Raw = model.OnOffRaw;
        //            OnOffSet = model.InjectOnOffs;
        //        }
        //    }
        //    else
        //    {
        //        lock (SyncRoot)//LDC
        //        {
        //            if (Raw[0] != model.OnOffRaw[0])
        //            {
        //                Raw = model.OnOffRaw;
        //                OnOffSet = model.InjectOnOffs;
        //            }
        //        }
        //    }
        //    if(this.ECUErrors!=model.ECUErrorStates||this.ECUErrors_Store!=model.ECUErrorStates_Store)
        //    {
        //        this.ECUErrors = model.ECUErrorStates;
        //        this.ECUErrors_Store = model.ECUErrorStates_Store;
        //        SetErrorStateText();
        //    }
        //    cbAutoDiagnosis.Checked = Services.Stroe.ECUSetting.AutoDiagnosis;
        //}
        private void ShowDiagnosisDetails(Models.Feedback.DiagnosisDetails model)
        {
            if (!IsReadly) return;
            int a = 0;
            int b = 0;
            int bank = 0;//ddlBank.SelectedIndex   Services.Device.DeviceInfo.HardInof.ECUExtension ? 1 :
            labGasTime.Text = String.Format("{0}:{1}", (model.ECUWorkTime.Gas.Days * 24 + model.ECUWorkTime.Gas.Hours).ToString(),
                 model.ECUWorkTime.Gas.Minutes >= 10 ? model.ECUWorkTime.Gas.Minutes.ToString() : "0" + model.ECUWorkTime.Gas.Minutes.ToString());
            labRedTime.Text = String.Format("{0}:{1}", (model.ECUWorkTime.Red.Days * 24 + model.ECUWorkTime.Red.Hours).ToString(),
                model.ECUWorkTime.Red.Minutes >= 10 ? model.ECUWorkTime.Red.Minutes.ToString() : "0" + model.ECUWorkTime.Red.Minutes.ToString());
            var temp = model.InjectOnOffs[0].Data;//喷轨测试状态
            var enable = model.InjectTimes[0].Gas.Any(m => m > 0);//有喷油时间就为真
            switch (Services.Stroe.ECUSetting.Cylinders)
            {
                case 2:
                    a = 2;
                    b = 0;
                    break;
                case 3:
                    a = 3;
                    b = 0;
                    break;
                case 4:
                    a = 4;
                    b = 0;
                    break;
                case 5:
                    a = 3;
                    b = 2;
                    break;
                case 6:
                    a = 3;
                    b = 3;
                    break;
                case 8:
                    a = 4;
                    b = 4;
                    break;
            }
            for (int i = 0; i < a; i++)
            {
                GasDiaLines[i].RightLabel = model.InjectTimes[bank].Gas[i].ToString("N02");
                GasDiaLines[i].ON = temp[i] && enable;
                //    GasDiaLines[i].MyEnable = enable;//LDC删除      
                PertrolDiaLInes[i].RightLabel = model.InjectTimes[bank].Pertrol[i].ToString("N02");
                PertrolDiaLInes[i].ON = model.InjectTimes[bank].Pertrol[i] > 0;
            }
            for (int i = 4; i < 4 + b; i++)
            {
                GasDiaLines[i].RightLabel = model.InjectTimes[bank].Gas[i].ToString("N02");
                GasDiaLines[i].ON = temp[i] && enable;
                //    GasDiaLines[i].MyEnable = enable;//LDC删除      
                PertrolDiaLInes[i].RightLabel = model.InjectTimes[bank].Pertrol[i].ToString("N02");
                PertrolDiaLInes[i].ON = model.InjectTimes[bank].Pertrol[i] > 0;
            }
            if (Raw == null)
            {
                lock (SyncRoot)//LDC
                {
                    Raw = model.OnOffRaw;
                    OnOffSet = model.InjectOnOffs;
                }
            }
            else
            {
                lock (SyncRoot)//LDC
                {
                    //if(Raw[0]!=model.OnOffRaw[0]||Raw[1]!=model.OnOffRaw[1])
                    if (Raw[0] != model.OnOffRaw[0])
                    {
                        Raw = model.OnOffRaw;
                        OnOffSet = model.InjectOnOffs;
                    }
                }
            }
            if (this.ECUErrors != model.ECUErrorStates || this.ECUErrors_Store != model.ECUErrorStates_Store)
            {
                this.ECUErrors = model.ECUErrorStates;
                this.ECUErrors_Store = model.ECUErrorStates_Store;
                SetErrorStateText();
            }
            //if (model.OBDErrors != null)
            //    if (this.OBDErrorsCount != model.OBDErrors.Count())
            //    {
            //        this.OBDErrorsCount = model.OBDErrors.Count();
            //        this.Invoke(new UIHelper.UIINvkoeParam1<ParmWarper<Models.Feedback.OBDError[]>>(SetOBDErrorsList), new ParmWarper<Models.Feedback.OBDError[]>(model.OBDErrors));
            //    }
            cbAutoDiagnosis.Checked = Services.Stroe.ECUSetting.AutoDiagnosis;
        }
        private void SetErrorStateText()
        {
            var bitMap = new Bit32Warper(ECUErrors);//ECUErrors
      //      var bitMap2 = new Bit32Warper(ECUErrors_Store);
            int bitIndex = 0;
            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("01") == null)
                listvErrors.Items.Add(Item3("01", LangWords["513"]));
            else
                if (listvErrors.FindItemWithText("01") != null)
                    listvErrors.FindItemWithText("01").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("02") == null)
                    listvErrors.Items.Add(Item3("02", LangWords["514"]));
            else
                if (listvErrors.FindItemWithText("02") != null)
                    listvErrors.FindItemWithText("02").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("03") == null)
                 listvErrors.Items.Add(Item3("03", LangWords["515"]));
            else
                if (listvErrors.FindItemWithText("03") != null)
                    listvErrors.FindItemWithText("03").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("04") == null)
                 listvErrors.Items.Add(Item3("04", LangWords["516"]));
            else
                if (listvErrors.FindItemWithText("04") != null)
                    listvErrors.FindItemWithText("04").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("05") == null)
                 listvErrors.Items.Add(Item3("05", LangWords["517"]));
            else
                if (listvErrors.FindItemWithText("05") != null)
                    listvErrors.FindItemWithText("05").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("06") == null)
                listvErrors.Items.Add(Item3("06", LangWords["518"]));
            else
                if (listvErrors.FindItemWithText("06") != null)
                    listvErrors.FindItemWithText("06").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("07") == null)
                listvErrors.Items.Add(Item3("07", LangWords["519"]));
            else
                if (listvErrors.FindItemWithText("07") != null)
                    listvErrors.FindItemWithText("07").Remove();

            if (bitMap[bitIndex++]&&listvErrors.FindItemWithText("08") == null)
                listvErrors.Items.Add(Item3("08", LangWords["520"]));
            else
                if (listvErrors.FindItemWithText("08") != null)
                    listvErrors.FindItemWithText("08").Remove();

            if (bitMap[bitIndex++]&&listvErrors.FindItemWithText("09") == null)
                listvErrors.Items.Add(Item3("09", LangWords["533"]));
            else
                if (listvErrors.FindItemWithText("09") != null)
                    listvErrors.FindItemWithText("09").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("10") == null)
                listvErrors.Items.Add(Item3("10", LangWords["534"]));
            else
                if (listvErrors.FindItemWithText("10") != null)
                    listvErrors.FindItemWithText("10").Remove();

            if (bitMap[bitIndex++]&&listvErrors.FindItemWithText("11") == null)
                 listvErrors.Items.Add(Item3("11", LangWords["535"]));
            else
                if (listvErrors.FindItemWithText("11") != null)
                    listvErrors.FindItemWithText("11").Remove();

            if (bitMap[bitIndex++]&&listvErrors.FindItemWithText("12") == null)
                listvErrors.Items.Add(Item3("12", LangWords["536"]));
            else
                if (listvErrors.FindItemWithText("12") != null)
                    listvErrors.FindItemWithText("12").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("13") == null)
                listvErrors.Items.Add(Item3("13", LangWords["537"]));
            else
                if (listvErrors.FindItemWithText("13") != null)
                    listvErrors.FindItemWithText("13").Remove();

            if (bitMap[bitIndex++] && listvErrors.FindItemWithText("14") == null)
                listvErrors.Items.Add(Item3("14", LangWords["538"]));
            else
                if (listvErrors.FindItemWithText("14") != null)
                    listvErrors.FindItemWithText("14").Remove();

            if (bitMap[bitIndex++]&&listvErrors.FindItemWithText("15") == null)
                listvErrors.Items.Add(Item3("15", LangWords["539"]));
            else
                if (listvErrors.FindItemWithText("15") != null)
                    listvErrors.FindItemWithText("15").Remove();

            if (bitMap[bitIndex++]&&listvErrors.FindItemWithText("16") == null)
                listvErrors.Items.Add(Item3("16", LangWords["540"]));
            else
                if (listvErrors.FindItemWithText("16") != null)
                    listvErrors.FindItemWithText("16").Remove();

            if (bitMap[bitIndex++]&&listvErrors.FindItemWithText("17") == null)
                listvErrors.Items.Add(Item3("17", LangWords["543"]));
            else
                if (listvErrors.FindItemWithText("17") != null)
                    listvErrors.FindItemWithText("17").Remove();
           //  if(bitMap[bitIndex])

            //for (; bitIndex < StateControls.Length; bitIndex++)
            //{
            //    StateControls[bitIndex].SubItem.Text = bitMap[bitIndex] ? LangWords["512"] : LangWords["511"];
            //    StateControls[bitIndex].SubItem2.Text = bitMap2[bitIndex] ? LangWords["512"] : LangWords["511"];
            //}
            //for (int i = 0; i < Bank1State.Length; i++,bitIndex++)
            //{
            //    Bank1State[i].SubItem.Text = bitMap[bitIndex] ? LangWords["512"] : LangWords["511"];
            //    Bank1State[i].SubItem2.Text = bitMap2[bitIndex] ? LangWords["512"] : LangWords["511"];
            //}
            //if (Services.Device.DeviceInfo.HardInof.ECUExtension)
            //{
            //    int i = bitIndex;
            //    bitIndex = 16;
            //    for (; i <Bank2State.Length; i++, bitIndex++)
            //    {
            //        Bank2State[i].SubItem.Text = bitMap[bitIndex] ? LangWords["512"] : LangWords["511"];
            //        Bank2State[i].SubItem2.Text = bitMap2[bitIndex] ? LangWords["512"] : LangWords["511"]; 
            //    }
            //}
            //ListViewItem lvi = new ListViewItem();
            //lvi.ImageIndex = 2;     //通过与imageList绑定，显示imageList中第i项图标  
            //lvi.Text = "01";
            //lvi.SubItems.Add("开关");
            //lvi.SubItems.Add("故障");
          //  listvErrors.Items.Add(Item3("01", LangWords["512"]));//LangWords["512"]
            //ListViewItem item1 = listvErrors.FindItemWithText("01");
            //item1.Remove();
        }
        private ListViewItem Item3(string Text, string Item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.ImageIndex = 2;     //通过与imageList绑定，显示imageList中第i项图标  
            lvi.Text = Text;
            lvi.SubItems.Add(Item);
            lvi.SubItems.Add(LangWords["512"]);
            return lvi;
        }

            
        int ECUErrors=-1;
        int ECUErrors_Store = -1;
        LVIWarper[] StateControls,Bank1State,Bank2State;
        byte[] Raw;
        Models.Feedback.Bank<bool[]>[] OnOffSet;
        object SyncRoot = new object();
        List<UserControls.DiaLine> GasDiaLines,PertrolDiaLInes;
        #endregion

        #region IMultLang 成员

        private void InitErrorList()
        {
            StateControls = new LVIWarper[8];
            String subText=LangWords["510"];
            StateControls[0] = new LVIWarper(LangWords["513"], subText, subText, null);
            StateControls[1] = new LVIWarper(LangWords["514"], subText,subText, null);
            StateControls[2] = new LVIWarper(LangWords["515"], subText,subText, null);
            StateControls[3] = new LVIWarper(LangWords["516"], subText,subText, null);
            StateControls[4] = new LVIWarper(LangWords["517"], subText,subText, null);
            StateControls[5] = new LVIWarper(LangWords["518"], subText,subText, null);
            StateControls[6] = new LVIWarper(LangWords["519"], subText,subText, null);
            StateControls[7] = new LVIWarper(LangWords["520"], subText,subText, null);
            int index = 8;
            Bank1State = new LVIWarper[Services.Stroe.ECUSetting.Cylinders];
            for (int i = 0; i < Bank1State.Length; i++,index++)
            {
                string temp = String.Format(LangWords["521"], "1", (i+1).ToString());
                Bank1State[i] = new LVIWarper(temp, subText,subText, index.ToString());
            }
            if (Services.Device.DeviceInfo.HardInof.ECUExtension)
            {
                index = 16;
                Bank2State = new LVIWarper[Services.Stroe.ECUSetting.Cylinders];
                for (int i = 0; i < Bank2State.Length; i++, index++)
                {
                    string temp = String.Format(LangWords["521"], "2", (i+1).ToString());
                    Bank2State[i] = new LVIWarper(temp, subText,subText, index.ToString());
                }
            }
            listvErrors.Items.AddRange(StateControls.Select(m => m.Item).ToArray());
            listvErrors.Items.AddRange(Bank1State.Select(m => m.Item).ToArray());



            //listvErrors.Items[0].Remove();
            //listvErrors.Items[0].Remove();
            //listvErrors.Items[0].Remove();
            //listvErrors.Items[0].Remove();
            //listvErrors.Items.AddRange(new ListView.ListViewItemCollection());
            if(Bank2State!=null)
                listvErrors.Items.AddRange(Bank2State.Select(m => m.Item).ToArray());
        }
        private ListViewItem.ListViewSubItem AddItemReturnSub(String diagnosisText)
        {
            return AddItemReturnSub(diagnosisText, null);
        }
        private ListViewItem.ListViewSubItem AddItemReturnSub(String diagnosisText, object tag)
        {
            var item1 = new ListViewItem(diagnosisText);
            if (tag != null) item1.Tag = tag;
            var sub = item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, LangWords["510"]));
            listvErrors.Items.Add(item1);
            return sub;
        }
        public void ApplyLang()
        {
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            this.Font = new Font(fontFamily, this.Font.Size);
            labGasTitle.Font = new Font(fontFamily, labGasTitle.Font.Size);
            labPetrolTitle.Font = new Font(fontFamily, labPetrolTitle.Font.Size);
            labOpTime.Font = new Font(fontFamily, labOpTime.Font.Size);
            labOKTip.Font = new Font(fontFamily, labOKTip.Font.Size);
            labXTip.Font = new Font(fontFamily, labXTip.Font.Size);
            btnResetErrors.Font = new Font(fontFamily, btnResetErrors.Font.Size);
            listvErrors.Font = new Font(fontFamily, listvErrors.Font.Size);
            cbAutoDiagnosis.Font = new Font(fontFamily, cbAutoDiagnosis.Font.Size);
            btnResetErrors.Font = new Font(fontFamily, btnResetErrors.Font.Size);       
            this.Text = LangWords["501"];
            labGasTitle.Text = LangWords["503"];
            labPetrolTitle.Text = LangWords["502"];
            labOpTime.Text = LangWords["504"];
            labOKTip.Text = LangWords["505"];
            labXTip.Text = LangWords["506"];
            btnResetErrors.ButtonText  = LangWords["507"];
            listvErrors.Columns[0].Text = LangWords["508"];
            listvErrors.Columns[1].Text = LangWords["509"];
            listvErrors.Columns[2].Text = LangWords["524"];
          //  InitErrorList();
            cbAutoDiagnosis.Text = LangWords["522"];
            btnOBDErrors.ButtonText = LangWords["523"];
        }

        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }

        #endregion

        private void btnResetErrors_Click(object sender, EventArgs e)
        {
            //int data = 0;
            //foreach (ListViewItem item in this.listvErrors.CheckedItems)
            //{
            //    if (item.Index < 8)
            //        data = data | 1 << item.Index;
            //    else
            //        data = data | 1<<int.Parse(item.Tag.ToString());
            //}
            //if(data!=0)
            //    Services.Device.SendAndRead("Diagnosis", 25, Service.PLC.InstructionSet.SetECUErrorCodeClear,
            //        new byte[] { (byte)(data & 0xFF), (byte)(data & 0xFF00 >> 8), (byte)(data & 0xFF0000 >> 16),0,0,0,0 });
            Services.Device.SendAndRead("Diagnosis", 25, Service.PLC.InstructionSet.SetECUErrorCodeClear,
                               new byte[] { 0, 0, 0, 0, 0, 0, 0 });
        }// { (byte)(0xFF), (byte)(0xFF), (byte)(0xFF), (byte)(0xFF), (byte)(0xFF), (byte)(0xFF), (byte)(0xFF) });
        class LVIWarper
        {
            public LVIWarper(String itemText,string subItemText,string subItem2Text,object itemTag)
            {
                this.Item = new ListViewItem(itemText);
              //  this.Item.Checked = true;
                if (itemTag != null) this.Item.Tag = itemTag;
                this.SubItem= this.Item.SubItems.Add(new ListViewItem.ListViewSubItem(this.Item, subItemText));
                this.SubItem2 = this.Item.SubItems.Add(new ListViewItem.ListViewSubItem(this.Item, subItem2Text));
            }
            public ListViewItem Item { get; set; }
            public ListViewItem.ListViewSubItem SubItem { get; set; }
            public ListViewItem.ListViewSubItem SubItem2 { get; set; }
            public int Bit { get; set; }
        }

        private void btnOBDError_Click(object sender, EventArgs e)
        {
            IGT.UI.Client.UserControls.OBDErrorsForm form = new UserControls.OBDErrorsForm();
            form.ShowDialog();
        }

        private void ddlBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsReadly) return;
        }

        private void cbAutoDiagnosis_CheckedChanged(object sender, EventArgs e)
        {
            Services.Stroe.ECUSetting.AutoDiagnosis=cbAutoDiagnosis.Checked;
            if (cbAutoDiagnosis.Checked)
                Services.Stroe.ECUSetting.BaseData[2] = (byte)(Services.Stroe.ECUSetting.BaseData[3] | 0x08);
            else
                Services.Stroe.ECUSetting.BaseData[2] = (byte)(Services.Stroe.ECUSetting.BaseData[3] & 0xF7);
            Services.Stroe.SaveChanges();
        }
    }
}
