using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 喷射模式
    /// </summary>
    [Serializable]
    public enum InjectionModes
    {
        /// <summary>
        /// 顺序
        /// </summary>
        Sequential,
        /// <summary>
        /// 分组
        /// </summary>
        SemiSequential,
        /// <summary>
        /// 同时
        /// </summary>
        FullGroup
    }
}
