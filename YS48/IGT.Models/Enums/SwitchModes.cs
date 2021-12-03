using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 切换方式
    /// </summary>
    [Serializable]
    public enum SwitchModes
    {
        /// <summary>
        /// 加速切换
        /// </summary>
        InAcceleration,
        /// <summary>
        /// 减速切换
        /// </summary>
        InDecelertion,
        StartOnGas
    }
}
