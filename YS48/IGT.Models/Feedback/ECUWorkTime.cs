using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// ECU工作时间
    /// </summary>
    public class ECUWorkTime
    {
        /// <summary>
        /// 系统运行时间
        /// </summary>
        public TimeSpan System { get; set; }

        /// <summary>
        /// 燃气工作时间
        /// </summary>
        public TimeSpan Gas { get; set; }

        /// <summary>
        /// 系统工作时间
        /// </summary>
        public TimeSpan Red { get; set; }
    }
}
