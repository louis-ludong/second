using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using spLib = SerialPortsUtils;
using System.Linq;
namespace IGT.Service.PLC
{
    /// <summary>
    /// 表示一个下位机设备
    /// </summary>
    public class Device : IDisposable
    {
        /// <summary>
        /// 端口名
        /// </summary>
        public String PortName { get { return Agent.PortName; } }
        
        /// <summary>
        /// 改变自定义任务状态
        /// </summary>
        /// <param name="enableOrCancel">启用或取消</param>
        public void ChangeTaskState(bool enableOrCancel)
        {
            this.Agent.SetAllBitState(enableOrCancel);
        }

        /// <summary>
        /// 改变指定的自定义任务状态，根据任务映射的Bit值选择
        /// </summary>
        /// <param name="bit"></param>
        /// <param name="enableOrCancel">启用或取消</param>
        public void ChangeTaskState(int bit, bool enableOrCancel)
        {
            this.Agent.SetBitState(bit, enableOrCancel);
        }
        
        /// <summary>
        /// 开始一个定时任务
        /// </summary>
        /// <param name="task">要开始的任务</param>
        public void BeginOnTimeTask(OnTimeTasks task)
        {
            this.OnTimerTask.BeginTask(task);
        }
        
        /// <summary>
        /// 结束一个定时任务
        /// </summary>
        /// <param name="task">要结束的任务</param>
        public void EndOnTimeTask(OnTimeTasks task)
        {
            this.OnTimerTask.EndTask(task);
        }

        /// <summary>
        /// 重置下位机
        /// </summary>
        /// <param name="identity">用于此次通讯的标识符</param>
        public void ResetPLC(String identity)
        {
            Agent.SendAndRead(identity, CancelBit.Nomal, PacketUtils.BuildSend(InstructionSet.SetECUReset), new ReadFilter(InstructionSet.SetECUReset));
        }
        /// <summary>
        /// 发送数据到下位机并读取返回值
        /// </summary>
        /// <param name="identity">用于此次通讯的标识符</param>
        /// <param name="cancelBit">用于取消的Bit值</param>
        /// <param name="cmd1">命令</param>
        /// <param name="cmd2">子命令</param>
        /// <param name="data">要发送到下位机的数据</param>
        /// <param name="context">在执行过程中携带的对象</param>
        public void SendAndRead(string identity, int cancelBit, byte cmd1, byte cmd2, byte[] data = null, object context = null)
        {
            Agent.SendAndRead(identity, cancelBit, PacketUtils.BuildSend(cmd1, cmd2, data), new ReadFilter(cmd1, cmd2), context);

        }
        /// <summary>
        /// 发送数据到下位机并读取返回值
        /// </summary>
        /// <param name="identity">用于此次通讯的标识符</param>
        /// <param name="cancelBit">用于取消的Bit值</param>
        /// <param name="cmd">命令</param>
        /// <param name="data">要发送到下位机的数据</param>
        /// <param name="context">在执行过程中携带的对象</param>
        public void SendAndRead(string identity, int cancelBit, byte cmd, byte[] data = null, object context = null)
        {
            Agent.SendAndRead(identity, cancelBit, PacketUtils.BuildSend(cmd, data), new ReadFilter(cmd), context);
        }
        /// <summary>
        /// 启动一个任务，用于获取附件信息
        /// </summary>
        internal void GetAdditionalInfo()
        {
            if (this.Connect.IsConnected)
                AddCustomTask("AdditionalInfo", CancelBit.Nomal, new GetAdditionalInfoTask(this));
        }
        /// <summary>
        /// 启动一个任务，用于获取诊断信息
        /// </summary>
        internal void GetDiagnosisDetails()
        {
            if (this.Connect.IsConnected)
                AddCustomTask("DiagnosisDetails", CancelBit.Nomal, new DiagnosisDetailsTask(this));
        }
        /// <summary>
        /// 启动一个任务，用于获取OBD状态或自适应状态
        /// </summary>
        internal void GetSelfAdaptationOR_OBDState()
        {
            if (this.Connect.IsConnected)
                Agent.SendAndRead("GetSelfAdaptationOR_OBDState", CancelBit.Nomal, PacketUtils.BuildSend(InstructionSet.GetSelfAdaptationOR_ODBState), new ReadFilter(InstructionSet.GetSelfAdaptationOR_ODBState));
        }
        /// <summary>
        /// 启动一个任务，用于获取实时数据
        /// </summary>
        internal void GetRealyTimeData()
        {
            if (this.Connect.IsConnected)
                Agent.SendAndRead("RealyTimeData", CancelBit.Nomal, PacketUtils.BuildSend(InstructionSet.RealyData), new ReadFilter(InstructionSet.RealyData));
        }
        /// <summary>
        /// 启动一个任务，用于获取标定信息
        /// </summary>
        internal void GetAutoCalibrationDetails()
        {
            if (this.Connect.IsConnected)
                Agent.SendAndRead("AutoCalibrationDetails", CancelBit.Nomal, PacketUtils.BuildSend(InstructionSet.GetAutoCalibrationState), new ReadFilter(InstructionSet.GetAutoCalibrationState));
        }
        /// <summary>
        /// 启动一个任务，用于设置使用数据
        /// </summary>
        //internal void SetUsingData()
        //{
        //    var now = DateTime.Now;
        //    byte[] data = {(byte)(now.Year-2000),
        //                  (byte)now.Month,
        //                  (byte)now.Day,
        //                  (byte)now.Hour,
        //                  (byte)now.Minute};
        //    Agent.SendAndRead("SetUsingData", CancelBit.Nomal, PacketUtils.BuildSend(InstructionSet.ReleaseDateWrite, data), new ReadFilter(InstructionSet.ReleaseDateWrite));
        //}
        internal void SetUsingData()
        {
            var now = DateTime.Now;
            byte[] data = {(byte)((byte)((now.Year-2014)<<4)|((byte)now.Month&0x0f)),
                          (byte)now.Day,
                          (byte)now.Hour,
                          (byte)now.Minute};
            Agent.SendAndRead("SetUsingData", CancelBit.Nomal, PacketUtils.BuildSend(InstructionSet.ReleaseDateWrite, data), new ReadFilter(InstructionSet.ReleaseDateWrite));
        }


        /// <summary>
        /// 启动一个任务，用于获取2D喷射曲线
        /// </summary>
        public void GetTiji2DCurve()
        {
            if (this.Connect.IsConnected)
                AddCustomTask("GetTiji2DCurve", CancelBit.Nomal, new IGT.Service.Storage.Tiji2DCurveTask());
        }
        /// <summary>
        /// 启动一个任务，用于设置3d喷射曲线
        /// </summary>
        internal void GetTiji3DCurve()
        {
            if (this.Connect.IsConnected)
                AddCustomTask("GetTiji3DCurve", CancelBit.Nomal, new IGT.Service.Storage.Tiji3DCurveTask());
        }
        /// <summary>
        /// 添加一个自定任务
        /// </summary>
        /// <param name="identity">标识符</param>
        /// <param name="cancelBit">取消位</param>
        /// <param name="task">要添加的自定义任务</param>
        public void AddCustomTask(String identity, int cancelBit, ICustomTask task)
        {
            spLib.Agents.Models.AgentTask aTask = new spLib.Agents.Models.AgentTask();
            aTask.Context = task;
            aTask.Action = "CustomTask";
            Agent.AddCustomTask(identity, cancelBit, aTask);
        }
        public Device()
        {
            this.DeviceInfo = new Models.Feedback.DeviceStaticData();
            this.DeviceInfo.CopyRight = String.Empty;
            this.DeviceInfo.FirmwareInfo = String.Empty;
            this.DeviceInfo.FirstUsingDate = string.Empty;
            this.DeviceInfo.ReleaseDate = string.Empty;
            this.DeviceInfo.SerialNumber = string.Empty;
            this.DeviceInfo.HardInof = new Models.Feedback.HardwareInfo();
            this.DeviceInfo.HardInof.AutoAdaptive = true;
            this.DeviceInfo.HardInof.Bank1Cylinders = 4;
            this.DeviceInfo.HardInof.Bank2Cylinders = 4;
            this.DeviceInfo.HardInof.ECUExtension = true;
            this.DeviceInfo.HardInof.ECUVer = string.Empty;
            this.DeviceInfo.HardInof.GasAlert = true;
            this.DeviceInfo.HardInof.MapChoose = true;
            this.DeviceInfo.HardInof.OBDEn = true;
            this.DeviceInfo.HardInof.OxygenSimulation = true;
            this.DeviceInfo.HardInof.PCBVer = string.Empty;
            this.DeviceInfo.HardInof.SmartSwitch = true;
            System.IO.Ports.SerialPort port = new System.IO.Ports.SerialPort(
                "COM3", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
            port.WriteTimeout = 1000;
            port.ReadTimeout = 2000;
            Agent = new SerialPortsUtils.Agents.AgentAsync(port, CustomActionExectue);
            Agent.SetBitState(CancelBit.Connection, true);
            Agent.SetBitState(CancelBit.Nomal, true);
            Agent.ResultGot += Agent_ResultGot;
            Connect = new Connection(this);
            this.OnTimerTask = new OnTimeSchudle(this);
        }
        byte[] CustomActionExectue(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            var t = context.Job.Content.Context as ICustomTask;
            return t.Execute(context);
        }
        private void Agent_ResultGot(SerialPortsUtils.Agents.Models.AgentTaskResult result)
        {
            switch (result.Identity)
            {
                case "4Connict":
                    ResultGot4Connict(result);
                    break;
                case "AdditionalInfo":
                    if (result.Successed && AdditionalInfoGot != null)
                    {
                        var model = result.Context as Models.Feedback.AdditionalInfo;
                        AdditionalInfoGot(this, new ModelGotEventArg<Models.Feedback.AdditionalInfo>(model));
                    }
                    break;
                case "RealyTimeData":
                    if (result.Successed && RealyTimeDataGot != null)
                    {
                        var model = result.ExecuteResult.ToRealyTimeData();
                        RealyTimeDataGot(this, new ModelGotEventArg<Models.Feedback.RealTimeData>(model));
                    }
                    break;
                case "AutoCalibrationDetails":
                    if (result.Successed && AutoCalibrationDetailsGot != null)
                    {
                        var model = result.ExecuteResult.ToAutoCalibrationDetails();
                        AutoCalibrationDetailsGot(this, new ModelGotEventArg<Models.Feedback.AutoCalibrationDetails>(model));
                    }
                    break;
                case "DiagnosisDetails":
                    if (result.Successed && DiagnosisDetailsGot != null)
                    {
                        var model = result.Context as Models.Feedback.DiagnosisDetails;
                        DiagnosisDetailsGot(this, new ModelGotEventArg<Models.Feedback.DiagnosisDetails>(model));
                    }
                    break;
                case "GetSelfAdaptationOR_OBDState":
                    if (result.Successed && GotSelfAdaptationOR_ODBState != null)
                    {
                        GotSelfAdaptationOR_ODBState(result);
                    }
                    break;
                case "GetTiji2DCurve":
                    if (result.Successed && Tiji2DCurveGot != null)
                    {
                        var model = result.Context as Models.Feedback.Tiji2DCurve;
                        Tiji2DCurveGot(this, new ModelGotEventArg<Models.Feedback.Tiji2DCurve>(model));
                    }
                    break;
                case "GetTiji3DCurve":
                    if (result.Successed && Tiji3DCurveGot != null)
                    {
                        var model = result.Context as Models.Feedback.Tiji3DCurve;
                        Tiji3DCurveGot(this, new ModelGotEventArg<Models.Feedback.Tiji3DCurve>(model));
                    }
                    break;
                default:
                    if (ResultGot4Custom != null && result.Action == "CustomTask")
                        ResultGot4Custom(result);
                    else
                    {
                        if (ResultGot != null)
                            ResultGot(result);
                    } break;
            }
        }

        private void SendAndRead4Connict(byte cmd, byte[] data, object context)
        {
            Agent.SendAndRead("4Connict", CancelBit.Connection, PacketUtils.BuildSend(cmd, data), new ReadFilter(cmd), context);
        }
        private void Read4Connict(spLib.Agents.IReadFilter filter, object context)
        {
            Agent.Read("4Connict", CancelBit.Connection, filter, context);
        }
        public event SerialPortsUtils.Agents.AgentAsync.ResultGotDelegate GotSelfAdaptationOR_ODBState;
        public event SerialPortsUtils.Agents.AgentAsync.ResultGotDelegate ResultGot4Custom;
        public event EventHandler<ModelGotEventArg<Models.Feedback.AutoCalibrationDetails>> AutoCalibrationDetailsGot;
        public event EventHandler<ModelGotEventArg<Models.Feedback.RealTimeData>> RealyTimeDataGot;
        public event EventHandler<ModelGotEventArg<Models.Feedback.DiagnosisDetails>> DiagnosisDetailsGot;
        public event EventHandler<ModelGotEventArg<Models.Feedback.AdditionalInfo>> AdditionalInfoGot;
        public event EventHandler<ModelGotEventArg<Models.Feedback.Tiji2DCurve>> Tiji2DCurveGot;
        public event EventHandler<ModelGotEventArg<Models.Feedback.Tiji3DCurve>> Tiji3DCurveGot; 
        public event SerialPortsUtils.Agents.AgentAsync.ResultGotDelegate ResultGot;
        /// <summary>
        /// 设备信息
        /// </summary>
        public IGT.Models.Feedback.DeviceStaticData DeviceInfo { get; private set; }
        /// <summary>
        /// 连接对象
        /// </summary>
        public Connection Connect { get; private set; }
        SerialPortsUtils.Agents.AgentAsync Agent;
        event SerialPortsUtils.Agents.AgentAsync.ResultGotDelegate ResultGot4Connict;
        OnTimeSchudle OnTimerTask;
        #region IDisposable 成员

        /// <summary>
        /// 释放设备
        /// </summary>
        public void Dispose()
        {
            this.OnTimerTask.Dispose();
            this.Connect.Stop();
            if (Agent != null) Agent.Dispose();
        }
        #endregion
        /// <summary>
        /// 连接对象
        /// </summary>
        public class Connection
        {
            /// <summary>
            /// 停止连接
            /// </summary>
            public void Stop()
            {
                this.Status = ConnectionState.NoBegin;
                StopKeepALive();
                IsConnected = false;
                this.PLC.Agent.ClosePort();
                if (InitConnictFinish != null)
                    InitConnictFinish(this, new ConnictFinishEventArgs(ConnectionFinishReasons.Cancel));
            }
            /// <summary>
            /// 初始化连接
            /// </summary>
            /// <param name="portName">端口名称</param>
            public void InitConnecting(String portName)
            {
                StopKeepALive();
                IsConnected = false;
                this.Status = ConnectionState.InitConnicting;
                this.PasswordStatus = Service.PLC.PasswordStatus.Unkown;
                if (!HandShark(portName))
                {
                    Status = ConnectionState.NoBegin;
                    if (InitConnictFinish != null)
                        InitConnictFinish(this, new ConnictFinishEventArgs(ConnectionFinishReasons.NoRespose));
                }
            }
            /// <summary>
            /// 发送密码到下位机
            /// </summary>
            /// <param name="pwd"></param>
            public void SendPassword(String pwd)
            {
                PLC.SendAndRead4Connict(InstructionSet.HandShake, InstructionSet.DeviceCode, "NotHandler");
                var data = ValueConvert.PasswordValue(pwd);
                System.Diagnostics.Debug.WriteLine("发送密码");
                PLC.SendAndRead4Connict(InstructionSet.InputPassword, data, "SendPassword");
            }

            /// <summary>
            /// 构造器
            /// </summary>
            /// <param name="plc">关联的设备对象</param>
            public Connection(Device plc)
            {
                this.PLC = plc;
                this._IsConnicted = false;
                this.Status = ConnectionState.NoBegin;
                this.PasswordStatus = Service.PLC.PasswordStatus.Unkown;
                this.PLC.ResultGot4Connict += PacketHandler;
            }
            void KeepALive(object nothing)
            {
                PLC.SendAndRead4Connict(InstructionSet.HandShake, new byte[] { 0x38, 0x2B, 0x41 }, "KeepALive");
            }
            void StopKeepALive()
            {
                if (timer4Keep != null)
                    timer4Keep.Change(System.Threading.Timeout.Infinite, 3500);
            }
            private void GetSerialNumber()
            {               
                Debug.WriteLine("获取序列号 ");
                PLC.SendAndRead4Connict(InstructionSet.SerialNumber, null, "GetSerialNumber");              
            }
            void NeedPassword()
            {
                Debug.WriteLine("获取是否需要密码 ");
                PLC.SendAndRead4Connict(InstructionSet.PasswordIsSet, null, "NeedPassword");
            }
            void GetFirmWareVer()
            {
                Debug.WriteLine("获取固件信息 ");
                PLC.SendAndRead4Connict(InstructionSet.FireWareInfo, null, "GetFirmWareVer");
            }
            void GetHardInfo()
            {
                Debug.WriteLine("获取硬件信息 ");
                PLC.SendAndRead4Connict(InstructionSet.HardInfo, null, "GetHardInfo");
            }
            /// <summary>
            /// 握手
            /// </summary>
            /// <param name="portName">端口名称</param>
            /// <returns>串口能否打开</returns>
            bool HandShark(String portName)
            {
                Debug.WriteLine(portName, "HandShark ");
                try
                {
                    PLC.Agent.ChangePort(portName);
                //    PLC.Agent.ClosePort();
                    PLC.Agent.OpenPort();
                }
                catch (Exception)
                {
                    return false;
                }
                PLC.SendAndRead4Connict(InstructionSet.HandShake, InstructionSet.DeviceCode, "HandShake");
                //TryWaitBootloader();
                return true;
            }
            void TryWaitBootloader()
            {
                PLC.Read4Connict(new BootloaderReadFilter(4500), "TryWaitBootloader");
            }
            private void PacketHandler(SerialPortsUtils.Agents.Models.AgentTaskResult result)
            {
                if (result.Successed == false)
                {
                    IsConnected = false;
                }
                if (Status == ConnectionState.InitConnicting)
                {
                    if (result.Successed == false & result.Context.ToString() != "KeepALive" && result.Context.ToString() != "HandShake")
                    {
                        Status = ConnectionState.NoBegin;
                        if (InitConnictFinish != null)
                            InitConnictFinish(this, new ConnictFinishEventArgs(ConnectionFinishReasons.NoRespose));
                        return;
                    }
                    switch (result.Context.ToString())
                    {
                        case "TryWaitBootloader":
                            if (InitConnictFinish != null)
                                InitConnictFinish(this, new ConnictFinishEventArgs(ConnectionFinishReasons.Bootloader));
                            break;
                        case "HandShake":   
                            if (result.Successed)   
                                switch (Status)     
                                {   
                                    case ConnectionState.InitConnicting:    
                                        PLC.SetUsingData();
                                        GetSerialNumber();
                                    //    NeedPassword(); 
                                        break;      
                                    case ConnectionState.KeepConnction:     
                                        NeedPassword(); 
                                        break;      
                                }   
                            else
                                TryWaitBootloader();
                            break;
                        case "GetSerialNumber":
                            PLC.DeviceInfo = new Models.Feedback.DeviceStaticData();
                            PLC.DeviceInfo.SerialNumber = result.ExecuteResult.ToSerialNumberResult();
                            NeedPassword(); 
                            break;
                        case "NeedPassword":
                            if (result.ExecuteResult.ToPasswordNeed())
                            {
                                PasswordStatus = Service.PLC.PasswordStatus.Need;
                                RequestPassword(this, new RequestPWdEventArgs());
                            }
                            else
                            {
                                PasswordStatus = Service.PLC.PasswordStatus.NotNeed;
                                if (PasswordPass != null) PasswordPass(this, EventArgs.Empty);
                                GetFirmWareVer();
                            }
                            break;
                        case "SendPassword":
                            NeedPassword();
                            break;
                        case "GetFirmWareVer":
                         //   PLC.DeviceInfo = new Models.Feedback.DeviceStaticData();
                            PLC.DeviceInfo.FirmwareInfo = result.ExecuteResult.ToFireWareInfo();
                            GetHardInfo();
                            break;
                        case "GetHardInfo":
                            PLC.DeviceInfo.HardInof = result.ExecuteResult.ToHardwareInfo();
                            this.IsConnected = true;
                            this.Status = ConnectionState.KeepConnction;
                            if (timer4Keep == null)
                                timer4Keep = new System.Threading.Timer(KeepALive, null, 2000, 3500);
                            else
                                timer4Keep.Change(2000, 3500);
                            if (InitConnictFinish != null)
                                InitConnictFinish(this, new ConnictFinishEventArgs(ConnectionFinishReasons.Succeed));
                            break;
                    }
                }
            }


            public bool IsConnected
            {
                get { return _IsConnicted; }
                private set
                {
                    if (_IsConnicted != value)
                    {
                        _IsConnicted = value;
                        if (ConnectionStateChanged != null)
                            ConnectionStateChanged(this, EventArgs.Empty);
                    }
                }
            }
            public ConnectionState Status { get; private set; }
            public PasswordStatus PasswordStatus { get; private set; }
            public event EventHandler ConnectionStateChanged;
            public event EventHandler<ConnictFinishEventArgs> InitConnictFinish;
            public event EventHandler<RequestPWdEventArgs> RequestPassword;
            public event EventHandler PasswordPass;
            System.Threading.Timer timer4Keep;
            bool _IsConnicted = false;
            Device PLC;
        }

    }
    /// <summary>
    /// ECU升级任务
    /// </summary>
    public class ECUUpdateTask : ICustomTask
    {
        /// <summary>
        /// 当前步骤
        /// </summary>
        public Steps Step { get; private set; }
        private UpData UpdateDate;
        System.Threading.EventWaitHandle wait = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.AutoReset);
        public ECUUpdateTask(UpData data)
        {
            this.UpdateDate = data;
            this.Step = ECUUpdateTask.Steps.Bootloader;
        }
        public void Wait()
        {
            wait.WaitOne();
        }
        #region ICustomTask 成员

        public byte[] Execute(spLib.Agents.Models.CustomActionContext context)
        {
            Succesed = false;
            System.Diagnostics.Debug.WriteLine("Begin ECU Update");
            var sp = (context.IO as SerialPortsUtils.Agents.ISerialPortWarper).GetSerialPort();
            int timeOut = sp.ReadTimeout;
            sp.ReadTimeout = 10000;
            try
            {
                try
                {
                    context.IO.Read(new BootloaderReadFilter(4500),0x00);
                }
                catch (Exception)
                {
                    context.IO.SendAndRead(InstructionSet.HandShake, InstructionSet.DeviceCode);
                    context.IO.Send(PacketUtils.BuildSend(InstructionSet.ECURestart));
                }
                sp.Encoding = System.Text.Encoding.ASCII;
                System.Threading.Thread.Sleep(150);
                if (sp.BytesToRead > 0)
                {
                    string restartMsg = sp.ReadExisting();
                    Debug.WriteLine("RestartMessage:" + restartMsg);
                }
                //进入Bootloader
                Debug.WriteLine("B Send:$S");
                sp.Write("$L");//V3.8
                Debug.WriteLine("Send:$S");
                sp.ReadTo("WT");
                Debug.WriteLine("Recived:WT");
                if (ClearEEPROM(sp))
                    if (ClearFLASH(sp))
                        if (WriteData(sp))
                            Succesed = true;
                if (Succesed)
                {
                    this.ERROR = null;
                    //返回主程序
                    //sp.Write("g");
                    //Debug.WriteLine("g");
                    System.Threading.Thread.Sleep(100);
                    sp.Write("g");
                 //   System.Threading.Thread.Sleep(100);
                   // sp.BaudRate = 19200;
                    Debug.WriteLine("g");
                    System.Threading.Thread.Sleep(1000);
                //    string t= sp.ReadTo("G");//协议是GO，下位机重启导致指令只发出一半
                  //  Debug.WriteLine("Read:" + t);
                  //  sp.BaudRate = 9600;
                }
            }
            catch (TimeoutException)
            {
                this.ERROR = "Timeout";
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception On ECU Update");
                if (sp.BytesToRead > 0)
                {
                    Debug.WriteLine("Buffer Data:");
                    Debug.WriteLine(sp.ReadExisting());
                    Debug.WriteLine(String.Empty);
                }
                Debug.WriteLine(e.GetType() + ":" + e.Message);
                Debug.WriteLine(e.StackTrace);
            }
            sp.ReadTimeout = timeOut;
            System.Diagnostics.Debug.WriteLine("End ECU Update");
            this.Step = Steps.Finish;
            wait.Set();
            return null;
        }

        #endregion

        private bool WriteData(System.IO.Ports.SerialPort sp)
        {
            System.Diagnostics.Debug.WriteLine("Update: Writing Data");
            this.Step = Steps.WriteData;
            wait.Set();
            var oldWTimeOut = sp.WriteTimeout;
            var oldRTimeOut = sp.ReadTimeout;
            sp.WriteTimeout = 1500;
            sp.ReadTimeout = 1000;
            bool result = true;
            //进入编程
            sp.Write("p");
            int errcnt = 0;
            for (int i = 0; i < this.UpdateDate.Data.Length; i++)
            {
                //System.Threading.Thread.Sleep(100);
                String item = this.UpdateDate.Data[i];
                wait.Set();
                System.Diagnostics.Debug.WriteLine("Send:" + item);
                try
                {
                    sp.Write(item);
                    System.Threading.Interlocked.Increment(ref _WriteCount);
                    if (WriteCount == this.UpdateDate.Data.Length)
                    {
                        String msg = sp.ReadTo("WT");//写入完成  返回FHWT
                        //string t = sp.ReadTo("FH");
                        if (!msg.StartsWith("FH"))
                        {
                            this.ERROR = msg.Replace("WT", String.Empty);
                            result = false;
                        }
                        else
                        {
                            //sp.Write("g");
                            //Debug.WriteLine("g");
                            result = true;
                        }
                    }
                    else
                    {
                        var feedback = sp.ReadChar();
                        if (feedback == '?')
                        {
                            System.Diagnostics.Debug.WriteLine("数据写入失败");
                            if (errcnt>=3)
                            {
                                errcnt = 0;
                                continue;
                             }
                            else
                            i--;
                            WriteCount--;
                            errcnt++;
                            continue;
                        }
                        else if (feedback == 'S')
                        {
                            continue;
                        }
                        else if (feedback != '*')
                        {
                            this.ERROR = "Unkown Error";
                            result = false;
                            break;
                        }
                    }
                }
                catch (TimeoutException e)
                {
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                    i--;
                    continue;
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                    result = false;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// 擦除FLASH
        /// </summary>
        private bool ClearFLASH(System.IO.Ports.SerialPort sp)
        {
            System.Diagnostics.Debug.WriteLine("Update: Erasing EEPROM");
            this.Step = Steps.ClearFLASH;
            wait.Set();
            sp.Write("f");
            var msg = sp.ReadTo("WT");
            if (!msg.StartsWith("CL"))
            {
                this.ERROR = msg.Replace("WT", String.Empty);
                return false;
            }
            else
                return true;
        }
        /// <summary>
        /// //擦除EEPROM
        /// </summary>
        private bool ClearEEPROM(System.IO.Ports.SerialPort sp)
        {
            System.Diagnostics.Debug.WriteLine("Update: Erasing FLASH");
            this.Step = Steps.ClearEEPROM;
            wait.Set();
            sp.Write("e");
            var msg = sp.ReadTo("WT");
            if (!msg.StartsWith("CL"))
            {
                this.ERROR = msg.Replace("WT", String.Empty);
                return false;
            }
            else
                return true;
        }
        private int _WriteCount = 0;

        /// <summary>
        /// 写入计数
        /// </summary>
        public int WriteCount
        {
            get { return _WriteCount; }
            set { _WriteCount = value; }
        }

        public string ERROR=String.Empty;
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Succesed { get; private set; }

        /// <summary>
        /// ECU升级步骤
        /// </summary>
        public enum Steps
        {
            /// <summary>
            /// Bootloader
            /// </summary>
            Bootloader,
            /// <summary>
            /// 擦出ROM
            /// </summary>
            ClearEEPROM,
            /// <summary>
            /// 擦除FLASH
            /// </summary>
            ClearFLASH, 
            /// <summary>
            /// 写入数据
            /// </summary>
            WriteData,
            /// <summary>
            /// 结束
            /// </summary>
            Finish
        }
    }
}
