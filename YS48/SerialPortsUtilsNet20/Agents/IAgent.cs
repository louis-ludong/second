using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents
{
    /// <summary>
    /// 表示一个串口IO代理
    /// </summary>
    public interface IAgent
    {

        #region Port
        /// <summary>
        /// 改变端口
        /// </summary>
        /// <param name="portName"></param>
        void ChangePort(string portName);

        /// <summary>
        /// 关闭端口
        /// </summary>
        void ClosePort();
        /// <summary>
        /// 打开端口
        /// </summary>
        void OpenPort();
        /// <summary>
        /// 端口是否打开
        /// </summary>
        bool PortIsOpen { get; }
        #endregion
    }
}
