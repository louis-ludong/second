using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// 喷轨类型
    /// </summary>
    [Serializable]
    public enum InjectorTypes
    {
        Matrix, ThreeOhm, OneOhm,
        /// <summary>
        /// 自定义
        /// </summary>
        Custom, Unknow,
        IGT
    }
}
