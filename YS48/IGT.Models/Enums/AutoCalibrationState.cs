using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 自动标定状态
    /// </summary>
    public enum AutoCalibrationState
    {
        /// <summary>
        /// 没有进入自动标定
        /// </summary>
        NotEnter,
        /// <summary>
        /// 等待发动机启动
        /// </summary>
        WaitEngineStart,
        /// <summary>
        /// 等待减压器温度达到50℃
        /// </summary>
        WaitRedArrive50,
        /// <summary>
        /// 喷嘴参数传送
        /// </summary>
        InjectorParamSend,
        /// <summary>
        /// 标定出错
        /// </summary>
        Error,
        /// <summary>
        /// 结束
        /// </summary>
        Finished
    }
}
