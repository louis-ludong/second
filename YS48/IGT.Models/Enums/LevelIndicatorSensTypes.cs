using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 液位传感器类型
    /// </summary>
    [Serializable]
    public enum LevelIndicatorSensTypes
    {
        /// <summary>
        /// IGT
        /// </summary>
        IGT,//LDC修改
        /// <summary>
        /// 非标准
        /// </summary>
        NotStandard,//LDC
        /// <summary>
        /// 非标准反向
        /// </summary>
        NotStandardInverted,
        /// <summary>
        ///Lovato
        /// </summary>
        Lovato,
        /// <summary>
        /// 0-90ohm
        /// </summary>
        ZeroTo90ohm,
        /// <summary>
        /// 0-110ohm
        /// </summary>
        ZeroTo110ohm,
        /// <summary>
        /// 100-10kohm
        /// </summary>
        HundredTo10Kohm,
        /// <summary>
        /// 0-90ohm_2
        /// </summary>
        ZeroTo90ohm_2,
        /// <summary>
        /// 90-0ohm
        /// </summary>
        NinetyTo0ohm,
        /// <summary>
        /// 110-0ohtm
        /// </summary>
        HundredTenTo0ohm,
        /// <summary>
        /// 10k-100ohm
        /// </summary>
        TenKTo100ohm,
        Unknow
    }
}
