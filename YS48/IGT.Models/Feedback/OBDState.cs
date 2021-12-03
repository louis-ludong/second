using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// OBD状态
    /// </summary>
    public class OBDState
    {
        /// <summary>
        /// 连接状态
        /// </summary>
        public Enums.OBDConnectState ConnectState { get; set; }

        /// <summary>
        /// 故障码数量
        /// </summary>
        public int FailuresCount { get; set; }

        /// <summary>
        /// Bank1的短期修正
        /// </summary>
        public float Bank1ShortCorrection { get; set; }
        /// <summary>
        /// Bank1的长期修正
        /// </summary>
        public float Bank1LongCorrection { get; set; }
        /// <summary>
        /// Bank2的短期修正
        /// </summary>
        public float Bank2ShortCorrection { get; set; }
        /// <summary>
        /// Bank2的长期修正
        /// </summary>
        public float Bank2LongCorrection { get; set; }
        /// <summary>
        /// Bank1的后氧传感器
        /// </summary>
        public float Bank1Oxygen { get; set; }
        /// <summary>
        /// 燃气修正
        /// </summary>
        public SByte GasCorrection { get; set; }

    }

    /// <summary>
    /// 自适应状态
    /// </summary>
    public class AdaptiveState
    {
        /// <summary>
        /// 短期修正值
        /// </summary>
        public int ShortCorrection { get; set; }

        /// <summary>
        /// 偏离值
        /// </summary>
        public int Offset { get; set; }
    }
}
