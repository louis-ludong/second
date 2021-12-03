using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 自动标定结果
    /// </summary>
    public enum AutoCalibrationResult
    {
        /// <summary>
        /// 标定成功
        /// </summary>
        Successed,
        /// <summary>
        /// 没检测到MAP传感器
        /// </summary>
        NoMAPSensor,
        /// <summary>
        /// 真空压力过低
        /// </summary>
        MAPPressLower,
        /// <summary>
        /// 真空压力过高
        /// </summary>
        MAPPressHigher,
        /// <summary>
        /// 发动机转速过低
        /// </summary>
        RPMLower,
        /// <summary>
        /// 发动机转速过高
        /// </summary>
        RPMHigher,
        /// <summary>
        /// 喷油信号错误
        /// </summary>
        PertolSignalError,
        /// <summary>
        /// 未知错误
        /// </summary>
        UnknowageError,
    }
}
