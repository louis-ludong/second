using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;
namespace IGT.Service
{
    /// <summary>
    /// 服务类
    /// </summary>
    public class SSer
    {
        /// <summary>
        /// 下位机设备
        /// </summary>
        public static Service.PLC.Device Device
        {
            get
            {
                if (_Device == null)
                {
                    _Device = new Service.PLC.Device();
                    _Device.ChangeTaskState(true);
                }
                return _Device;
            }
            set { _Device = value; }
        }
        public static Service.PLC.Device _Device;
    }
}