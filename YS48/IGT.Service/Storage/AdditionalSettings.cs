using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service.Storage
{
    /// <summary>
    /// 附加设定
    /// </summary>
    public class AdditionalSettings:IStorageModel<Models.Settings.AdditionalSettings>
    {
        /// <summary>
        /// 实例化 附加设定
        /// </summary>
        /// <param name="model">附加设定</param>
        public AdditionalSettings(Models.Settings.AdditionalSettings model)
        {
            this._EmergencyStartAllowed = model.EmergencyStartAllowed;
            this._EmergencyStatsPerformed = model.EmergencyStatsPerformed;
            this._MaintainRemind = model.MaintainRemind;
            this._MaintainTime = model.MaintainTime;
        }
        #region IStorageModel<AdditionalSettings> 成员

        /// <summary>
        /// 分离 附加设定
        /// </summary>
        /// <returns>附加设定</returns>
        public Models.Settings.AdditionalSettings Detaching()
        {
            var model = new Models.Settings.AdditionalSettings();
            model.EmergencyStartAllowed = this.EmergencyStartAllowed;
            model.EmergencyStatsPerformed = this.EmergencyStatsPerformed;
            model.MaintainRemind = this.MaintainRemind;
            model.MaintainTime = this.MaintainTime;
            return model;
        }
        /// <summary>
        /// 附加 附加设定
        /// </summary>
        /// <param name="model">附加设定</param>
        public void Attach(Models.Settings.AdditionalSettings model)
        {
            this.EmergencyStartAllowed = model.EmergencyStartAllowed;
            this.EmergencyStatsPerformed = model.EmergencyStatsPerformed;
            this.MaintainRemind = model.MaintainRemind;
            this.MaintainTime = model.MaintainTime;
        }

        #endregion

        #region IStorageModel 成员

        public void SaveChanges(SerialPortsUtils.Agents.Agent io)
        {
            if(Changes[0]||Changes[1])
            {
                byte[] data = new byte[2];
                data[0] = (byte)(this.EmergencyStartAllowed ? 0x01 : 0x00);
                data[1] = Convert.ToByte(this.EmergencyStatsPerformed);
                io.SendAndRead(PLC.InstructionSet.SetEmergencyStats, data);
            }
            if(Changes[2]||Changes[3])
            {
                Console.WriteLine(Changes.Data);
                Console.WriteLine(Changes[2]);
                Console.WriteLine(Changes[3]);
                byte[] data = new byte[3];
                data[0] = PLC.ValueConvert.MaintainRemindTypesValue(this.MaintainRemind);
                var temp = PLC.ValueConvert.MaintainTimeValue(this.MaintainTime);
                data[1] = temp[0];
                data[2] = temp[1];
                io.SendAndRead(PLC.InstructionSet.SetMaintainRemind, data);
            }
            Changes.SetAll(false);
        }

        public void CancelChanges()
        {
            Changes.SetAll(false);
        }

        #endregion

        #region IDisposable 成员

        public void Dispose() { }

        #endregion

        /// <summary>
        /// 是否允许紧急启动
        /// </summary>
        public bool EmergencyStartAllowed
        {
            get { return _EmergencyStartAllowed; }
            set
            {
                if (_EmergencyStartAllowed != value)
                {
                    _EmergencyStartAllowed = value;
                    Changes[0] = true;
                }
            }
        }

        /// <summary>
        /// 可紧急启动次数
        /// </summary>
        public int EmergencyStatsPerformed
        {
            get { return _EmergencyStatsPerformed; }
            set {
                if (_EmergencyStatsPerformed != value)
                {
                    _EmergencyStatsPerformed = value;
                    Changes[1] = true;
                }
            }
        }

        /// <summary>
        /// 燃气保养提醒设置
        /// </summary>
        public Models.Enums.MaintainRemindTypes MaintainRemind
        {
            get { return _MaintainRemind; }
            set
            {
                if (_MaintainRemind != value)
                {
                    _MaintainRemind = value;
                    Changes[2] = true;
                }
            }
        }

        /// <summary>
        /// 燃气保养时间
        /// </summary>
        public TimeSpan MaintainTime
        {
            get { return _MaintainTime; }
            set
            {
                if (_MaintainTime != value)
                {
                    _MaintainTime = value;
                    Changes[3] = true;
                }
            }
        }
        Bit32Warper Changes = new Bit32Warper(Bit32Warper.Data_ALLFALSE);
        private bool _EmergencyStartAllowed;
        private int _EmergencyStatsPerformed;
        private Models.Enums.MaintainRemindTypes _MaintainRemind;
        private TimeSpan _MaintainTime;
    }
}
