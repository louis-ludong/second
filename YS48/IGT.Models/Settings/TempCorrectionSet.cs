using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// 温度修正
    /// </summary>
    [Serializable]
    public class TempCorrectionSet
    {
        /// <summary>
        /// 数据
        /// </summary>
        public sbyte[] Items { get; set; }
        /// <summary>
        /// 百分比
        /// </summary>
        public int[] Corrections { get; set; }

        public int Over { get { return Corrections[Corrections.Length-1]; } }
    }
}
