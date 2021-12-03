using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// OBD类型
    /// </summary>
    [Serializable]
    public enum OBDTypes
    {
        Auto,
        ISO9141_2,
        KWP_2000FastInit,
        KWP_2000SlowInit,
        CANStandard250kbps,
        CANExtended250kbps,
        CANStandard500kbps,
        CANExtended500kbps,
        None
    }
}
