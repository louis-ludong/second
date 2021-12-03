using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 转速信号源
    /// 转速信号类型
    /// </summary>
    [Serializable]
    public enum RPMSources
    {
        ///// <summary>//LDCrpm
        ///// 喷油嘴
        ///// </summary>
        //Injector,
        ///// <summary>
        ///// 点火线圈
        ///// </summary>
        //Coil,
        ///// <summary>
        ///// 曲轴传感器
        ///// </summary>
        //CamshaftSensor,
        ///// <summary>
        ///// 自动识别
        ///// </summary>
        //Auto,
        ///// <summary>
        ///// 喷油嘴
        ///// </summary>
        OneCoil,
        /// <summary>
        /// 点火线圈
        /// </summary>
        TwoCoils,
        /// <summary>
        /// 曲轴传感器
        /// </summary>
        RPMSensor,
        /// <summary>
        /// 自动识别
        /// </summary>
        RPMSensor2,
    }
}
