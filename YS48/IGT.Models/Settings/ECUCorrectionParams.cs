using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// ECU修正比例
    /// </summary>
    [Serializable]
    public class ECUCorrectionParams
    {
        /// <summary>
        /// 0.0ms-25.5ms的修正比例
        /// </summary>
        public int[] CalibrationScale { get; set; }
        /// <summary>
        /// 10个坐标点的X
        /// </summary>
        public float[] LocationX { get; set; }
    }
}
