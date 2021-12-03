using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// 车辆基本参数设定
    /// </summary>
    [Serializable]
    public class BaseSetting
    {
        /// <summary>
        /// ECU设定
        /// </summary>
        public ECUSetting ECUSetting { get; set; }
        /// <summary>
        /// MAP标定
        /// </summary>
        public MAPCalibrationParams MAPCalibration { get; set; }
        /// <summary>
        /// 校准
        /// </summary>
        public CorrectSetting CorrectSetting { get; set; }
        /// <summary>
        /// ECU修正比例
        /// </summary>
        public ECUCorrectionParams ECUCalibration { get; set; }
        /// <summary>
        /// 喷轨修正
        /// </summary>
        public InjectorCorrectionSetting InjectorCorrection { get; set; }
        /// <summary>
        /// 附加设定
        /// </summary>
        public AdditionalSettings Additional { get; set; }
    }
}
