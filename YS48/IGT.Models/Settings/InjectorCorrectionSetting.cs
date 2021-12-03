using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// 喷轨修正参数
    /// </summary>
    [Serializable]
    public class InjectorCorrectionSetting
    {
        /// <summary>
        /// 喷轨修正比例
        /// </summary>
        public int[] CorrectionValues { get; set; }
        /// <summary>
        /// 喷轨最小开启时间
        /// </summary>
        public float MinOpenTime { get; set; }
        /// <summary>
        /// 喷轨修正时间
        /// </summary>
        public float CorrectionTime { get; set; }
        /// <summary>
        /// 喷轨全开保持时间
        /// </summary>
        public float OpenKeepTime { get; set; }

        /// <summary>
        /// 喷轨输出占空比
        /// </summary>
        public int InjectEmptyScale { get; set; }

        /// <summary>
        /// 喷轨最大开启时间
        /// </summary>
        public float MaxOpenTime { get; set; }
    }
}
