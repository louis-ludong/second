using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 燃气高速运行时
    /// </summary>
    public enum GasStrategies
    {
        /// <summary>
        /// 保持燃气
        /// </summary>
        KeepGas,
        /// <summary>
        /// 转换燃油
        /// </summary>
        SwitchOil,
        /// <summary>
        /// 燃油补偿
        /// </summary>
        OilCompensation
    }
}
