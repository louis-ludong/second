using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// 硬件信息
    /// </summary>
    public class HardwareInfo
    {
        /// <summary>
        /// ECU版本
        /// </summary>
        public string ECUVer { get; set; }
        /// <summary>
        /// PCB版本
        /// </summary>
        public string PCBVer { get; set; }
        /// <summary>
        /// ODB支持
        /// </summary>
        public bool OBDEn { get; set; }
        /// <summary>
        /// 自动自适应支持
        /// </summary>
        public bool AutoAdaptive { get; set; }
        /// <summary>
        /// 氧仿真支持
        /// </summary>
        public bool OxygenSimulation { get; set; }
        /// <summary>
        /// 智能开关
        /// </summary>
        public bool SmartSwitch { get; set; }
        /// <summary>
        /// 燃气泄漏警报
        /// </summary>
        public bool GasAlert { get; set; }
        /// <summary>
        /// ECU扩展支持
        /// </summary>
        public bool ECUExtension { get; set; }
        /// <summary>
        /// MAP选择
        /// </summary>
        public bool MapChoose { get; set; }

        /// <summary>
        /// Bank1缸数
        /// </summary>
        public int Bank1Cylinders { get; set; }
        /// <summary>
        /// Bank2缸数
        /// </summary>
        public int Bank2Cylinders { get; set; }
        /// <summary>
        /// 总缸数
        /// </summary>
        public int SumCylinders
        {
            get
            {
                if (ECUExtension)
                    return Bank1Cylinders + Bank2Cylinders;
                else return Bank1Cylinders;
            }
        }
    }
}
