using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// 附加信息
    /// </summary>
    public class AdditionalInfo
    {
        /// <summary>
        /// 保养时间
        /// </summary>
        public TimeSpan MaintainTime { get; set; }
        /// <summary>
        /// 紧急启动次数
        /// </summary>
        public int EmergencyStatsPerformed { get; set; }
    }
}
