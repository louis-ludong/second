using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// 诊断详情
    /// </summary>
    public class DiagnosisDetails
    {
        /// <summary>
        /// 喷射时间
        /// </summary>
        public InjectTime[] InjectTimes { get; set; }
        /// <summary>
        /// ECU工作时间
        /// </summary>
        public ECUWorkTime ECUWorkTime { get; set; }

        public Bank<bool[]>[] InjectOnOffs { get; set; }
        public byte[] OnOffRaw { get; set; }
        public int ECUErrorStates { get; set; }
        public int ECUErrorStates_Store { get; set; } 
    }
}
