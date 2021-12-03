using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents
{
    /// <summary>
    /// 串口包装器
    /// </summary>
    public interface ISerialPortWarper
    {
        /// <summary>
        /// 获取被包装的串口
        /// </summary>
        /// <returns></returns>
        System.IO.Ports.SerialPort GetSerialPort();
    }
}
