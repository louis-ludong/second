using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// ECU喷射时间
    /// </summary>
    public class InjectTime
    {
        /// <summary>
        /// 所属Bank
        /// </summary>
        public String Bank { get; set; }
        /// <summary>
        /// 喷油时间
        /// </summary>
        public float[] Pertrol { get; set; }
        /// <summary>
        /// 喷气时间
        /// </summary>
        public float[] Gas { get; set; }
    }
}
