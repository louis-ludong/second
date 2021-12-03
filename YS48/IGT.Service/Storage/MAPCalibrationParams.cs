using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Linq;
namespace IGT.Service.Storage
{
    /// <summary>
    /// MAP标定参数
    /// </summary>
    public class MAPCalibrationParams : IStorageModel<Models.Settings.MAPCalibrationParams>
    {
        /// <summary>
        /// 实例化 MAP标定参数
        /// </summary>
        /// <param name="model">MAP标定参数</param>
        public MAPCalibrationParams(Models.Settings.MAPCalibrationParams model)
        {
            this.RPMs = new NotityArray<int>(model.RPMs, "RPMs");
            //this.DataLockStatus = model.DataLockStatus.Select((m, i) => new NotityArray<bool>(m, Tulpe.Create("DataLockStatus", i)))
            //    .ToArray().ToReadOnlyCollection();
            this.Injection = new NotityArray<float>(model.Injection, "Injection");
            this.MAPValues = model.MAPValues.Select((m, i) => new NotityArray<int>(m, Tulpe.Create("MAPValues", i))).ToArray().ToReadOnlyCollection();//LDC MAP修改<Sbyte>改为<byte>
            //this.Tiji3DCurve = new Models.Feedback.Tiji3DCurve() { GasCurve = model.GasCurve, PetrolCurve = model.PetrolCurve };
            //this.Tiji2DCurve = new Models.Feedback.Tiji2DCurve() { GasCurve2D = model.GasCurve2D, PetrolCurve2D = model.PetrolCurve2D };
            //LDC删除 MAP
            this.RPMs.ItemChangedCustomSender += RPMs_ItemChangedCustomSender;
            this.Injection.ItemChangedCustomSender += RPMs_ItemChangedCustomSender;
            foreach (var item in this.MAPValues)
                item.ItemChangedCustomSender += RPMs_ItemChangedCustomSender;
        }
        internal void RegisetCurveChange(PLC.Device device)
        {
            if (regiset == true) return;
            regiset = true;
            device.Tiji2DCurveGot += device_Tiji2DCurveGot;
            device.Tiji3DCurveGot += device_Tiji3DCurveGot;
        }
        internal void UnRegisetCurveChange(PLC.Device device)
        {
            if (regiset == false) return;
            device.Tiji2DCurveGot -= device_Tiji2DCurveGot;
            device.Tiji3DCurveGot -= device_Tiji3DCurveGot;
            regiset = false;
        }
        bool regiset = false;
        void device_Tiji3DCurveGot(object sender, PLC.ModelGotEventArg<Models.Feedback.Tiji3DCurve> e)
        {
            if (e.Data != null)
                this.Tiji3DCurve = e.Data;
        }
        void device_Tiji2DCurveGot(object sender, PLC.ModelGotEventArg<Models.Feedback.Tiji2DCurve> e)
        {
            if(e.Data!=null)
                this.Tiji2DCurve = e.Data;
        }
        void RPMs_ItemChangedCustomSender(object sender, ItemChangedEventArgs e)
        {
            switch (sender.ToString())
            {
                case "RPMs":
                    ChangedFlag_RPMs = true;
                    break;
                case "Injection":
                    ChangedFlag_Injection = true;
                    break;
                default:
                    var tu = sender as Tulpe<String, int>;
                    switch (tu.Item1)
                    {
                        case "DataLockStatus":
                            TryAddChanged("DataLockStatus", tu.Item2);
                            break;
                        case "GasCurve":
                            TryAddChanged("GasCurve", tu.Item2);
                            break;
                        case "MAPValues":
                            TryAddChanged("MAPValues", tu.Item2);
                            break;
                        case "PetrolCurve":
                            TryAddChanged("PetrolCurve", tu.Item2);
                            break;
                    }
                    break;
            }
        }
        private void TryAddChanged(String key, int index)
        {
            if (ChangedCollection.ContainsKey(key))
            {
                if (!ChangedCollection[key].Contains(index))
                    ChangedCollection[key].Add(index);
            }
            else
            {
                var list = new List<int>(); list.Add(index);
                ChangedCollection.Add(key, list);
            }
        }
        #region IStorageModel 成员
        public void Attach(Models.Settings.MAPCalibrationParams model)
        {
            for (int i = 0; i < this.RPMs.Count; i++)
                this.RPMs[i] = model.RPMs[i];
            for (int i = 0; i < this.Injection.Count; i++)
                this.Injection[i] = model.Injection[i];
            for (int i = 0; i < this.MAPValues.Count; i++)
            {
                var old = this.MAPValues[i];
                var thenew = model.MAPValues[i];
                for (int j = 0; j < old.Count; j++)
                    old[j] = thenew[j];
            }
            //this._Tiji3DCurve = new Models.Feedback.Tiji3DCurve() { GasCurve = model.GasCurve, PetrolCurve = model.PetrolCurve };
            //for (int i = 0; i < this.DataLockStatus.Count; i++)
            //{
            //    var old = this.DataLockStatus[i];
            //    var thenew = model.DataLockStatus[i];
            //    for (int j = 0; j < old.Count; j++)
            //        old[j] = thenew[j];
            //}
            //this._Tiji2DCurve = new Models.Feedback.Tiji2DCurve() { GasCurve2D = model.GasCurve2D, PetrolCurve2D = model.PetrolCurve2D };
        }
        public void CancelChanges()
        {
            ChangedCollection.Clear();
            ChangedFlag_Injection = false;
            ChangedFlag_RPMs = false;
        }
        public Models.Settings.MAPCalibrationParams Detaching()//保存参数相关
        {
            var model = new Models.Settings.MAPCalibrationParams();
            model.RPMs = this.RPMs.ToArray();
            model.Injection = this.Injection.ToArray();
            model.MAPValues = this.MAPValues.Select(m => m.ToArray()).ToArray();
            //model.GasCurve = this.Tiji3DCurve.GasCurve.Select(m => m.ToArray()).ToArray();//LDC删除
            //model.PetrolCurve = this.Tiji3DCurve.PetrolCurve.Select(m => m.ToArray()).ToArray();
            //model.DataLockStatus = this.DataLockStatus.Select(m => m.ToArray()).ToArray();
            //model.GasCurve2D = this.Tiji2DCurve.GasCurve2D.ToArray();
            //model.PetrolCurve2D = this.Tiji2DCurve.PetrolCurve2D.ToArray();
            return model;
        }
        public void SaveChanges(SerialPortsUtils.Agents.Agent io)
        {
            if (ChangedFlag_RPMs == true)
            {
                ChangedFlag_RPMs = false;

                //io.SendAndRead(PLC.InstructionSet.SetMAPCalibrationParamsPart1, PLC.InstructionSet.SetMAPCalibrationParamsPart2_12RPMs
                //    , this.RPMs.Select(m => PLC.ValueConvert.MapTableRPMValue(m)).ToArray());
                io.SendAndRead(PLC.InstructionSet.SetMAPCalibrationParamsPart1, PLC.InstructionSet.SetMAPCalibrationParamsPart2_12RPMs
                      , PLC.ValueConvert.MapTableRPMValue(this.RPMs.ToArray()));
            }
            if (ChangedFlag_Injection == true)
            {
                ChangedFlag_Injection = false;
                io.SendAndRead(PLC.InstructionSet.SetMAPCalibrationParamsPart1, PLC.InstructionSet.SetMAPCalibrationParamsPart2_12Tinj
                    , PLC.ValueConvert.MapTableInjectionValue(this.Injection.ToArray()));
            }
            foreach (var item in ChangedCollection)
            {
                switch (item.Key)
                {
                    case "DataLockStatus":
                        //foreach (var index in item.Value)
                        //{
                        //    io.SendAndRead(PLC.InstructionSet.SetMAPCalibrationParamsPart1, PLC.InstructionSet.SetMAPCalibrationParamsPart2_DataLockStatus[index]
                        //        , PLC.ValueConvert.DataLockStatusValue(this.DataLockStatus[index].ToArray()));
                        //}
                        break;
                    case "GasCurve":
                        //TODO 暂时不用写
                        break;
                    case "MAPValues":
                        foreach (var index in item.Value)
                        {
                            io.SendAndRead(PLC.InstructionSet.SetMAPCalibrationParamsPart1,
                                PLC.InstructionSet.SetMAPCalibrationParamsPart2_MAPValue[index]
                                , this.MAPValues[index].Select(m => (byte)m).ToArray());
                          //  System.Threading.Thread.Sleep(150);
                        }
                        item.Value.Clear();
                        break;
                    case "PetrolCurve":
                        //TODO 暂时不用写
                        break;
                }
            }
        }
        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            this.Injection.ItemChangedCustomSender -= RPMs_ItemChangedCustomSender;
            this.RPMs.ItemChangedCustomSender -= RPMs_ItemChangedCustomSender;
            foreach (var item in this.MAPValues)
                item.ItemChangedCustomSender -= RPMs_ItemChangedCustomSender;
        }

        #endregion
        bool ChangedFlag_RPMs = false;
        bool ChangedFlag_Injection = false;
        Dictionary<String, List<int>> ChangedCollection = new Dictionary<String, List<int>>();
        #region Model属性

        /// <summary>
        /// RPM转速
        /// </summary>
        public NotityArray<int> RPMs { get; private set; }

        /// <summary>
        /// 喷油时间
        /// </summary>
        public NotityArray<Single> Injection { get; private set; }

        /// <summary>
        /// 标定值
        /// </summary>
      //  public ReadOnlyCollection<NotityArray<SByte>> MAPValues { get; private set; }////LDC MAP修改<Sbyte>改为<byte>
        public ReadOnlyCollection<NotityArray<int>> MAPValues { get; private set; }////LDC MAP修改<Sbyte>改为<byte>
        /// <summary>
        /// MAP标定数据锁定状态
        /// </summary>
        public ReadOnlyCollection<NotityArray<bool>> DataLockStatus { get; private set; }       
        /// <summary>
        /// 喷射曲线3D
        /// </summary>
        public Models.Feedback.Tiji3DCurve Tiji3DCurve
        {
            get { return _Tiji3DCurve; }
            set {
                if (_Tiji3DCurve != value)
                {
                    _Tiji3DCurve = value;
                    if (OnTiji3DCurveChanged != null)
                        OnTiji3DCurveChanged(value);
                }

            }
        }

        /// <summary>
        /// 喷射曲线2D
        /// </summary>
        public Models.Feedback.Tiji2DCurve Tiji2DCurve
        {
            get { return _Tiji2DCurve; }
            set {
                if (_Tiji2DCurve != value)
                {
                    _Tiji2DCurve = value;
                    if (OnTiji2DCurveChanged != null) OnTiji2DCurveChanged(value);
                }
            }
        }
        private Models.Feedback.Tiji2DCurve _Tiji2DCurve;
        private Models.Feedback.Tiji3DCurve _Tiji3DCurve;
        #endregion
        public event Action<Models.Feedback.Tiji3DCurve> OnTiji3DCurveChanged;
        public event Action<Models.Feedback.Tiji2DCurve> OnTiji2DCurveChanged;
    }
}
