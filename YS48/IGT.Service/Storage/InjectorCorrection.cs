using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using IGT.Service.PLC;

namespace IGT.Service.Storage
{
    /// <summary>
    /// 喷轨修正参数
    /// </summary>
    public class InjectorCorrection : IStorageModel<Models.Settings.InjectorCorrectionSetting>
    {
        /// <summary>
        /// 实例化 喷轨修正参数
        /// </summary>
        /// <param name="model">喷轨修正参数</param>
        public InjectorCorrection(Models.Settings.InjectorCorrectionSetting model)
        {
            this._CorrectionTime = model.CorrectionTime;
            this._InjectEmptyScale = model.InjectEmptyScale;
            this._MinOpenTime = model.MinOpenTime;
            this._OpenKeepTime = model.OpenKeepTime;
            this._CorrectionValues = new NotityArray<int>(model.CorrectionValues);
            this._CorrectionValues.ItemChanged += _CorrectionValues_ItemChanged;
            this._MaxOpenTime = model.MaxOpenTime;

        }

        void _CorrectionValues_ItemChanged(object sender, ItemChangedEventArgs e)
        {
            ChangedFlag = true;
        }
        #region IStorageModel<InjectorCorrectionSetting> 成员

        public Models.Settings.InjectorCorrectionSetting Detaching()
        {
            var model = new Models.Settings.InjectorCorrectionSetting();
            model.CorrectionValues = this.CorrectionValues.ToArray();
            model.MinOpenTime = this.MinOpenTime;
            model.CorrectionTime = this.CorrectionTime;
            model.OpenKeepTime = this.OpenKeepTime;
            model.InjectEmptyScale = this.InjectEmptyScale;
            model.MaxOpenTime = this.MaxOpenTime;
            return model;
        }

        #endregion

        #region IStorageModel 成员
        public void Attach(Models.Settings.InjectorCorrectionSetting model)
        {
            for (int i = 0; i < this.CorrectionValues.Count; i++)
            {
                this.CorrectionValues[i] = model.CorrectionValues[i];
            }
            this.MinOpenTime = model.MinOpenTime;
            this.CorrectionTime = model.CorrectionTime;
            this.OpenKeepTime = model.OpenKeepTime;
            this.InjectEmptyScale = model.InjectEmptyScale;
            this.MaxOpenTime = model.MaxOpenTime;

        }
        public void CancelChanges()
        {
            ChangedFlag = false;
        }
        public void SaveChanges(SerialPortsUtils.Agents.Agent io)
        {
            System.Diagnostics.Debug.WriteLine("Begin apply modify on InjectorCorrection");
            if (ChangedFlag == true)
            {
                byte[] data = new byte[25];
                for (int i = 0; i < 16; i++)
                {
                    data[i] = (byte)this.CorrectionValues[i];
                }
                var temp1 = ValueConvert.TwoBitTimeByusValue(this.MinOpenTime);
                data[16] = temp1[0];
                data[17] = temp1[1];
                var temp2 = ValueConvert.TwoBitTimeByusValue(this.CorrectionTime);
                data[18] = temp2[0];
                data[19] = temp2[1];
                var temp3 = ValueConvert.TwoBitTimeByusValue(this.OpenKeepTime);
                data[20] = temp3[0];
                data[21] = temp3[1];
                data[22] = Convert.ToByte(this._InjectEmptyScale);
                var temp4 = ValueConvert.TwoBitTimeByusValue(this.MaxOpenTime);
                data[23] = temp4[0];
                data[24] = temp4[1];
                io.SendAndRead(InstructionSet.SetInjectorCorrectionSetting, data);
            }
            System.Diagnostics.Debug.WriteLine("End apply modify on InjectorCorrection");
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            this._CorrectionValues.ItemChanged += _CorrectionValues_ItemChanged;
        }

        #endregion
        bool ChangedFlag = false;
        #region Model属性

        /// <summary>
        /// 喷轨修正比例
        /// </summary>
        public NotityArray<Int32> CorrectionValues { get { return _CorrectionValues; } }

        /// <summary>
        /// 喷轨最小开启时间
        /// </summary>
        public Single MinOpenTime
        {
            get { return _MinOpenTime; }
            set
            {
                if (_MinOpenTime != value)
                {
                    _MinOpenTime = value;
                    ChangedFlag = true;
                }
            }
        }

        /// <summary>
        /// 喷轨修正时间
        /// </summary>
        public Single CorrectionTime
        {
            get { return _CorrectionTime; }
            set
            {
                if (_CorrectionTime != value)
                {
                    _CorrectionTime = value;
                    ChangedFlag = true;

                }
            }
        }

        /// <summary>
        /// 喷轨全开保持时间
        /// </summary>
        public Single OpenKeepTime
        {
            get { return _OpenKeepTime; }
            set
            {
                if (_OpenKeepTime != value)
                {
                    _OpenKeepTime = value;
                    ChangedFlag = true;

                }
            }
        }

        /// <summary>
        /// 喷轨输出占空比
        /// </summary>
        public Int32 InjectEmptyScale
        {
            get { return _InjectEmptyScale; }
            set
            {
                if (_InjectEmptyScale != value)
                {
                    _InjectEmptyScale = value;
                    ChangedFlag = true;

                }
            }
        }
        /// <summary>
        /// 喷轨最大开启时间
        /// </summary>
        public float MaxOpenTime
        {
            get { return _MaxOpenTime; }
            set
            {
                if (_MaxOpenTime != value)
                {
                    _MaxOpenTime = value;
                    ChangedFlag = true;
                }
            }
        }


        private float _MinOpenTime;
        private float _CorrectionTime;
        private float _OpenKeepTime;
        private int _InjectEmptyScale;
        private float _MaxOpenTime;
        private NotityArray<int> _CorrectionValues;
        #endregion


    }
}
