using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 温度传感器类型
    /// </summary>
    [Serializable]
    public enum TempSensTypes
    {
        /// <summary>
        /// 10Kohm
        /// </summary>
        Ohm10K,
        /// <summary>
        /// 8K5ohm
        /// </summary>
        Ohm8K5,
        /// <summary>
        /// 5Kohm
        /// </summary>
        Ohm5K,
        /// <summary>
        /// 4K7Ohm
        /// </summary>
        Ohm4K7,
        /// <summary>
        /// 2K2ohm
        /// </summary>
        Ohm2K2,
        /// <summary>
        /// 2Kohm
        /// </summary>
        Ohm2K
    }
}
