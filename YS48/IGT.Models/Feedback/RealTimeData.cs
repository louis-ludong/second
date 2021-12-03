using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// 实时数据
    /// </summary>
    public class RealTimeData
    {
        /// <summary>
        /// 喷油时间
        /// </summary>
        public float PetrolsTime { get; set; }
        /// <summary>
        /// 喷气时间
        /// </summary>
        public float GasesTime { get; set; }
        /// <summary>
        /// 燃气压力
        /// </summary>
        public float GasPress { get; set; }
        /// <summary>
        /// 真空压力
        /// </summary>
        public float MAPPress { get; set; }
        /// <summary>
        /// 减压器温度
        /// </summary>
        public int TempRed { get; set; }
        /// <summary>
        /// 燃气温度
        /// </summary>
        public int TempGas { get; set; }
        /// <summary>
        /// 液位传感器
        /// </summary>
        public float GasLevel { get; set; }
        /// <summary>
        /// 发动机转速
        /// </summary>
        public int RPM { get; set; }

        /// <summary>
        /// LED灯状态
        /// </summary>
        public bool[] LEDLight { get; set; }
        /// <summary>
        /// 电磁阀状态
        /// </summary>
        public bool SolenoidValveStatus { get; set; }

        /// <summary>
        /// 点火状态
        /// </summary>
        public bool IgnitionStatus { get;set; }
        /// <summary>
        /// 氧传感器电压
        /// </summary>
        public float[] Lambda { get; set; }
        /// <summary>
        /// 转速信号源
        /// </summary>
        public Enums.RPMSources RPMSource { get; set; }

    }
}
