using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// 燃气压力修正
    /// </summary>
    public class PressCorrectionSet
    {
        /// <summary>
        /// 修正表数据
        /// </summary>
        public float[] Items { get; set; }
        /// <summary>
        /// 修正百分比
        /// </summary>
        public float[] Corrections { get; set; }//LDC INT >>>>folat
    }
}
