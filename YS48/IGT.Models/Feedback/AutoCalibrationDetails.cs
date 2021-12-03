using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// 自动标定信息
    /// </summary>
    public class AutoCalibrationDetails
    {
        /// <summary>
        /// 自动标定状态
        /// </summary>
        public byte State { get; set; }//Enums.AutoCalibrationState State----byte
        /// <summary>
        /// 自动标定结果
        /// </summary>
      //  public Enums.AutoCalibrationResult AutoCalibrationResult { get; set; }
        public byte AutoCalibrationResult { get; set; }
        /// <summary>
        /// 喷嘴大小
        /// </summary>
        public int InjectorBoreValue { get; set; }
    }
}
