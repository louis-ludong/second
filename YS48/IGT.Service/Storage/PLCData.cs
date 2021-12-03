using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using System.Linq;



namespace IGT.Service.Storage
{
    /// <summary>
    /// 下位机数据
    /// </summary>
    public partial class PLCData : IDisposable
    {
        private string DefaulSettingPath;
        /// <summary>
        /// 实例化 下位机数据
        /// </summary>
        /// <param name="device">关联的设备</param>
        /// <param name="defaultSettingPath">默认配置路径</param>
        public PLCData(PLC.Device device, string defaultSettingPath)
        {
            this.Device = device;
            this.Device.ChangeTaskState(CancelBit.Storage, true);
            this.DefaulSettingPath = defaultSettingPath;
            this.SettingTask = new SettingTasks(this);
            this.Device.ResultGot4Custom += Device_ResultGot4Custom;
        }

        void Device_ResultGot4Custom(SerialPortsUtils.Agents.Models.AgentTaskResult result)
        {
            if (result.Identity == "PLCDataSave")
            {
                if (SaveChanged != null)
                    SaveChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 从下位机加载
        /// </summary>
        public void LoadFromPLC()
        {
            this.SettingTask.StartTasks();
        }

        /// <summary>
        /// 从文件加载
        /// </summary>
        /// <param name="fileName"></param>
        public void LoadFromFile(String fileName)//载入参数
        {
            Models.Settings.BaseSetting loadSetting = null;
            using (System.Xml.XmlReader reader = new System.Xml.XmlTextReader(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Models.Settings.BaseSetting));
                loadSetting = serializer.Deserialize(reader) as Models.Settings.BaseSetting;
            }
            if (Device.Connect.IsConnected)
            {
                WaitReadyIFPLC();
                this.ECUSetting.Attach(loadSetting.ECUSetting);
                this.MAPCalibrationParams.Attach(loadSetting.MAPCalibration);
             //   this.ECUCorrectionParams.Attach(loadSetting.ECUCalibration);
                this.CorrectionSetting.Attach(loadSetting.CorrectSetting);
              //  this.InjectorCorrection.Attach(loadSetting.InjectorCorrection);
               // this.Additional.Attach(loadSetting.Additional);
            }
            else
            {
                this.ECUSetting = new ECUSetting(loadSetting.ECUSetting,this);
                if (this.MAPCalibrationParams != null)
                    this.MAPCalibrationParams.UnRegisetCurveChange(Device);
             //   loadSetting.MAPCalibration.MAPValues = loadSetting.MAPCalibration.SMAPValues[1].Select(m => return (byte)m).ToArray();   //Convert.ToBytebyte(Convert.ToBytebyte(
                //byte[][] temp = new byte[12][];
                //temp[0] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[1] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[2] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[3] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[4] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[5] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[6] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[7] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[8] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[9] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[10] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //temp[11] = new byte[] { 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120, 120 };
                //loadSetting.MAPCalibration.MAPValues = temp;
                this.MAPCalibrationParams = new MAPCalibrationParams(loadSetting.MAPCalibration);
                this.ECUCorrectionParams = new Storage.ECUCorrectionParams(loadSetting.ECUCalibration);//暂时不能删
                this.CorrectionSetting = new Storage.CorrectionSetting(loadSetting.CorrectSetting);
                this.InjectorCorrection = new Storage.InjectorCorrection(loadSetting.InjectorCorrection);//暂时不能删
                this.Additional = new AdditionalSettings(loadSetting.Additional);
            }
            this.MAPCalibrationParams.RegisetCurveChange(this.Device);//暂时不能删
            this.SaveChanges();
        }

        /// <summary>
        /// 加载（自定选择来源）
        /// </summary>
        public void LoadAuto()
        {
            if (Device.Connect.IsConnected)
            {
                LoadFromPLC();
            }
            else
                LoadFromFile(this.DefaulSettingPath);//导入黙认参数
        }

        /// <summary>
        /// 加载并等待
        /// </summary>
        public void LoadAutoAndWait()
        {
            if (Device.Connect.IsConnected)
                WaitReadyIFPLC();
            else
                LoadFromFile(DefaulSettingPath);
        }

        /// <summary>
        /// 加载指定项
        /// </summary>
        /// <param name="item"></param>
        public void LoadItem(SettingItems item)
        {
            if (Device.Connect.IsConnected)
                this.SettingTask.StartTask(item);
        }
        /// <summary>
        /// 等待指定项从下位机加载完毕
        /// </summary>
        /// <param name="item">要等待的项目</param>
        public void WaitReadyIfPLC(SettingItems item)
        {
            if (Device.Connect.IsConnected)
                this.SettingTask.WaitOne(item);
        }
        /// <summary>
        /// 等待数据从下位机加载完毕
        /// </summary>
        public void WaitReadyIFPLC()
        {
            if (Device.Connect.IsConnected)
                this.SettingTask.WaitAll();
        }
        /// <summary>
        /// 保所所有变更到下位机
        /// </summary>
        public void SaveChanges()
        {
            if (!this.Device.Connect.IsConnected)
            {
                this.ECUSetting.CancelChanges();
                this.MAPCalibrationParams.CancelChanges();//异常
             //   this.ECUCorrectionParams.CancelChanges();
                this.CorrectionSetting.CancelChanges();
              //  this.InjectorCorrection.CancelChanges();
            //    this.Additional.CancelChanges();
                return;
            }
            //ALlSettingTask task = new ALlSettingTask(this.Device, new IStorageModel[] 
            //    { this.ECUSetting, this.MAPCalibrationParams, this.ECUCorrectionParams ,this.CorrectionSetting
            //        ,this.InjectorCorrection,this.Additional});
            ALlSettingTask task = new ALlSettingTask(this.Device, new IStorageModel[] 
                { this.ECUSetting, this.MAPCalibrationParams,this.CorrectionSetting
                    });//,this.Additional,this.InjectorCorrection, this.ECUCorrectionParams
            this.Device.AddCustomTask("PLCDataSave", CancelBit.Storage, task);

        }
        /// <summary>
        /// 保存当前数据到文件
        /// </summary>
        /// <param name="path">保存路径</param>
        public void SaveToFile(String path)
        {
            LoadAutoAndWait();
            Models.Settings.BaseSetting model = new Models.Settings.BaseSetting();
            model.ECUSetting = ECUSetting.Detaching();
            model.MAPCalibration = this.MAPCalibrationParams.Detaching();
       //     model.ECUCalibration = this.ECUCorrectionParams.Detaching();
            model.CorrectSetting = this.CorrectionSetting.Detaching();
          //  model.InjectorCorrection = this.InjectorCorrection.Detaching();
            model.Additional = this.Additional.Detaching();
            using (System.IO.StreamWriter stream = new StreamWriter(path))
            {
                System.Xml.Serialization.XmlSerializer xs = new XmlSerializer(typeof(Models.Settings.BaseSetting));
                xs.Serialize(stream, model);
            }
        }
        #region StorageModel
        public ECUSetting ECUSetting { get; private set; }
        public MAPCalibrationParams MAPCalibrationParams { get; private set; }
        public ECUCorrectionParams ECUCorrectionParams { get; private set; }
        public CorrectionSetting CorrectionSetting { get; private set; }
        public InjectorCorrection InjectorCorrection { get; private set; }
        public AdditionalSettings Additional { get; private set; }
        #endregion
        public event EventHandler SaveChanged;
        /// <summary>
        /// 关联的设备
        /// </summary>
        internal PLC.Device Device { get; set; }
        SettingTasks SettingTask;
        class SettingTasks : IDisposable
        {
            private PLCData Store;
            bool running = false;
            public SettingTasks(PLCData store)
            {
                wait = new System.Threading.EventWaitHandle[4];//LDC 6.....4
                for (int i = 0; i < wait.Length; i++)
                    wait[i] = new System.Threading.EventWaitHandle(true, System.Threading.EventResetMode.ManualReset);
                this.Store = store;
                this.Store.Device.ResultGot4Custom += Device_ResultGot4Custom;
            }
            void Device_ResultGot4Custom(SerialPortsUtils.Agents.Models.AgentTaskResult result)
            {
                System.Diagnostics.Debug.WriteLine("waitset");
                if (running==false ||result.Successed == false) 
                    return;
                switch (result.Identity)
                {
                    case "PLCDataLoad1"://OK
                        System.Diagnostics.Debug.WriteLine("wait set0");
                        this.Store.ECUSetting = new ECUSetting((result.Context as PLC.ICustomTask<Models.Settings.ECUSetting>).GetResult(),this.Store);
                        wait[0].Set();
                        break;
                    case "PLCDataLoad2"://OK
                        System.Diagnostics.Debug.WriteLine("wait set1");
                        if (this.Store.MAPCalibrationParams != null)
                            this.Store.MAPCalibrationParams.UnRegisetCurveChange(Store.Device);
                        this.Store.MAPCalibrationParams = new MAPCalibrationParams((result.Context as PLC.ICustomTask<Models.Settings.MAPCalibrationParams>).GetResult());
                        wait[1].Set();
                        this.Store.MAPCalibrationParams.RegisetCurveChange(Store.Device);
                        break;
                    //case "PLCDataLoad3":
                    //    System.Diagnostics.Debug.WriteLine("wait set3");
                    //    this.Store.ECUCorrectionParams = new ECUCorrectionParams((result.Context as PLC.ICustomTask<Models.Settings.ECUCorrectionParams>).GetResult());
                    //    wait[2].Set();
                    //    break;
                    case "PLCDataLoad4"://OK
                        System.Diagnostics.Debug.WriteLine("wait set4");
                        this.Store.CorrectionSetting = new CorrectionSetting((result.Context as PLC.ICustomTask<Models.Settings.CorrectSetting>).GetResult());
                        wait[2].Set();
                        break;
                    //case "PLCDataLoad5":
                    //    System.Diagnostics.Debug.WriteLine("wait set5");
                    //    this.Store.InjectorCorrection = new InjectorCorrection((result.Context as PLC.ICustomTask<Models.Settings.InjectorCorrectionSetting>).GetResult());
                    //    wait[4].Set();
                    //    break;
                    case "PLCDataLoad6"://OK
                        System.Diagnostics.Debug.WriteLine("wait set6");
                        this.Store.Additional = new AdditionalSettings((result.Context as PLC.ICustomTask<Models.Settings.AdditionalSettings>).GetResult());
                        wait[3].Set();
                        break;


                }
            }
            public void StartTasks()
            {
                foreach (var item in wait)
                    item.Reset();
                running = true;
                var ecutask = new ECUSettingTask();
                this.Store.Device.AddCustomTask("PLCDataLoad1", CancelBit.Storage, ecutask);
                var mTask = new MAPCalibrationParamsTask();
                this.Store.Device.AddCustomTask("PLCDataLoad2", CancelBit.Storage, mTask);
                //var ecorTask = new ECUCorrectionParamsTask();
                //this.Store.Device.AddCustomTask("PLCDataLoad3", CancelBit.Storage, ecorTask);
                var cTask = new CorrectSettingTask();
                this.Store.Device.AddCustomTask("PLCDataLoad4", CancelBit.Storage, cTask);
                //var injTask = new InjectorCorrectionSettingTask();
                //this.Store.Device.AddCustomTask("PLCDataLoad5", CancelBit.Storage, injTask);
                var additTask = new AdditionalSettingsTask();
                this.Store.Device.AddCustomTask("PLCDataLoad6", CancelBit.Storage, additTask);
            }
            public void StartTask(SettingItems item)
            {
                running = true;
                switch (item)
                {
                    case SettingItems.ECUSetting:
                        System.Diagnostics.Debug.WriteLine("wait reset0");
                        wait[0].Reset();
                        var ecutask = new ECUSettingTask();
                        this.Store.Device.AddCustomTask("PLCDataLoad1", CancelBit.Storage, ecutask); break;
                    case SettingItems.MAPCalibrationParams:
                        System.Diagnostics.Debug.WriteLine("wait reset1");
                        wait[1].Reset();
                        var mTask = new MAPCalibrationParamsTask();
                        this.Store.Device.AddCustomTask("PLCDataLoad2", CancelBit.Storage, mTask); break;
                    //case SettingItems.ECUCorrectionParams:
                    //    System.Diagnostics.Debug.WriteLine("wait reset2");
                    //    wait[2].Reset();
                    //    var ecorTask = new ECUCorrectionParamsTask();
                    //    this.Store.Device.AddCustomTask("PLCDataLoad3", CancelBit.Storage, ecorTask); break;
                    case SettingItems.CorrectionSetting:
                        System.Diagnostics.Debug.WriteLine("wait reset3");
                        wait[2].Reset();
                        var cTask = new CorrectSettingTask();
                        this.Store.Device.AddCustomTask("PLCDataLoad4", CancelBit.Storage, cTask); break;
                    //case SettingItems.InjectorCorrection:
                    //    System.Diagnostics.Debug.WriteLine("wait reset4");
                    //    wait[4].Reset();
                    //    var injTask = new InjectorCorrectionSettingTask();
                    //    this.Store.Device.AddCustomTask("PLCDataLoad5", CancelBit.Storage, injTask); break;
                    case SettingItems.Additional:
                        System.Diagnostics.Debug.WriteLine("wait reset5");
                        wait[3].Reset();
                        var additTask = new AdditionalSettingsTask();
                        this.Store.Device.AddCustomTask("PLCDataLoad6", CancelBit.Storage, additTask); break;
                    default:
                        break;
                }
            }
            System.Threading.EventWaitHandle[] wait;
            public void WaitOne(SettingItems task, int timeOut = -1)
            {
                switch (task)
                {
                    case SettingItems.ECUSetting:
                        System.Diagnostics.Debug.WriteLine("wait0");
                        wait[0].WaitOne(timeOut,false);
                        break;
                    case SettingItems.MAPCalibrationParams:
                        System.Diagnostics.Debug.WriteLine("wait1");
                        wait[1].WaitOne(timeOut, false); break;
                    //case SettingItems.ECUCorrectionParams:
                    //    System.Diagnostics.Debug.WriteLine("wait2");
                    //    wait[2].WaitOne(timeOut, false); break;
                    case SettingItems.CorrectionSetting:
                        System.Diagnostics.Debug.WriteLine("wait3");
                        wait[2].WaitOne(timeOut, false);
                        break;
                    //case SettingItems.InjectorCorrection:
                    //    System.Diagnostics.Debug.WriteLine("wait4");
                    //    wait[4].WaitOne(timeOut, false); break;
                    case SettingItems.Additional:
                        System.Diagnostics.Debug.WriteLine("wait5");
                        wait[3].WaitOne(timeOut, false); break;
                }
            }
            public void WaitAll()
            {
                foreach (var item in wait)
                    item.WaitOne();
            }

            #region IDisposable 成员

            public void Dispose()
            {
                this.Store.Device.ResultGot4Custom -= Device_ResultGot4Custom;
                running = false;
            }

            #endregion
        }
        #region IDisposable 成员

        public void Dispose()
        {
            this.Device.ResultGot4Custom -= Device_ResultGot4Custom;
        }

        #endregion
    }
    /// <summary>
    /// 设定项目枚举
    /// </summary>
    public enum SettingItems
    {
        ECUSetting, MAPCalibrationParams, ECUCorrectionParams, CorrectionSetting, InjectorCorrection,
        Additional
    }
    class ALlSettingTask : PLC.CanWaitCustom<bool>
    {
        public ALlSettingTask(PLC.Device device, IStorageModel[] models)
            : base(device)
        {
            this.models = models;
            this.Result = false;
        }
        protected override void ResultGotHandler(SerialPortsUtils.Agents.Models.AgentTaskResult result)
        {
            this.Result = true;
        }
        void Device_ResultGot4Custom(SerialPortsUtils.Agents.Models.AgentTaskResult result)
        {
            this.Result = result.Successed;
        }
        protected override byte[] ExecuteInner(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            System.Diagnostics.Debug.WriteLine("Begin Send PLC Setting modify");
            foreach (var model in models)
            {
                model.SaveChanges(context.IO);
            }
            System.Diagnostics.Debug.WriteLine("End Send PLC Setting modify");
            return null;
        }

        IStorageModel[] models;
    }

}
