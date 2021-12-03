using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// MAP标定参数
    /// </summary>
    [Serializable]
    public class MAPCalibrationParams
    {
        /// <summary>
        /// RPM转速
        /// </summary>
        public int[] RPMs { get; set; }
        /// <summary>
        /// 喷油时间
        /// </summary>
        public float[] Injection { get; set; }
        /// <summary>
        /// 标定值
        /// </summary>
        //public sbyte[][] SMAPValues { get; set; }
        public int[][] MAPValues { get; set; }//LDC MAP修改<Sbyte>改为<byte>// 使用byte 无法从文件读取数据 sbyte才可以

        /// <summary>
        /// 气体喷射曲线
        /// </summary>
        public float[][] GasCurve { get; set; }
        /// <summary>
        /// 汽油喷射曲线
        /// </summary>
        public float[][] PetrolCurve { get; set; }
        /// <summary>
        /// MAP标定数据锁定状态
        /// </summary>
        public bool[][] DataLockStatus { get; set; }
        /// <summary>
        /// 气体喷射曲线2D
        /// </summary>
        public float[] GasCurve2D { get; set; }
        /// <summary>
        /// 汽油喷射曲线2D
        /// </summary>
        public float[] PetrolCurve2D { get; set; }
    }
}
