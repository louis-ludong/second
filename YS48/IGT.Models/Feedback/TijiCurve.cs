using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// 喷射2D曲线
    /// </summary>
    public class Tiji2DCurve
    {
        /// <summary>
        /// 喷气2D曲线
        /// </summary>
        public float[] GasCurve2D { get; set; }
        /// <summary>
        /// 喷油2D曲线
        /// </summary>
        public float[] PetrolCurve2D { get; set; }
    }

    /// <summary>
    /// 喷射3D曲线
    /// </summary>
    public class Tiji3DCurve
    {
        /// <summary>
        /// 气体喷射曲线
        /// </summary>
        public float[][] GasCurve { get; set; }
        /// <summary>
        /// 汽油喷射曲线
        /// </summary>
        public float[][] PetrolCurve { get; set; }
    }
}
