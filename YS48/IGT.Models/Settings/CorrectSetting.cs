using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// 修正设定
    /// </summary>
    public class CorrectSetting
    {
        /// <summary>
        /// 燃气温度修正
        /// </summary>
        public TempCorrectionSet GasTemp { get; set; }
        /// <summary>
        /// 减压器温度修正
        /// </summary>
        public TempCorrectionSet RedTemp { get; set; }
        /// <summary>
        /// 燃气压力修正
        /// </summary>
        public PressCorrectionSet GasPress { get; set; }
    }
}
