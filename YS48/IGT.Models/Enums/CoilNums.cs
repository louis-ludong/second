using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 线圈数
    /// </summary>
    [Obsolete("可以删了")]
    [Serializable]
    public enum CoilNums
    {
        /// <summary>
        /// 单线圈
        /// </summary>
        OneCoil,
        /// <summary>
        /// 双线圈
        /// </summary>
        TwoCoils,
        /// <summary>
        /// 四线圈
        /// </summary>
        FourColis,
        /// <summary>
        /// 六线圈
        /// </summary>
        SixColis
    }
}
