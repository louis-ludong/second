using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// 附加设置
    /// </summary>
    public class AdditionalSettings
    {
        /// <summary>
        /// 是否允许紧急启动
        /// </summary>
        public bool EmergencyStartAllowed { get; set; }
        /// <summary>
        /// 可紧急启动次数
        /// </summary>
        public int EmergencyStatsPerformed { get; set; }

        /// <summary>
        /// 燃气保养提醒设置
        /// </summary>
        public Enums.MaintainRemindTypes MaintainRemind { get; set; }

        /// <summary>
        /// 保养时间
        /// </summary>
        public TimeSpan MaintainTime { get; set; }
    }
}
