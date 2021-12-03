using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// 设备数据和统计信息
    /// </summary>
    public class DeviceStaticData
    {
        /// <summary>
        /// 版权信息
        /// </summary>
        public String CopyRight { get; set; }
        /// <summary>
        /// 固件信息
        /// </summary>
        public String FirmwareInfo { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public String ReleaseDate { get; set; }
        /// <summary>
        /// 序列号
        /// </summary>
        public String SerialNumber { get; set; }
        /// <summary>
        /// 首次使用时间
        /// </summary>
        public String FirstUsingDate { get; set; }

        /// <summary>
        /// 硬件信息
        /// </summary>
        public HardwareInfo HardInof { get; set; }
    }
}
