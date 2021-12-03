using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Models.Enums
{
    /// <summary>
    /// ODB连接状态
    /// </summary>
    public enum OBDConnectState
    {
        /// <summary>
        /// 初始化
        /// </summary>
        Init,
        /// <summary>
        /// 等待连接
        /// </summary>
        Waitting,
        /// <summary>
        /// 正在连接
        /// </summary>
        Connecting,
        /// <summary>
        /// 已连接
        /// </summary>
        Connected,
        /// <summary>
        /// 无连接
        /// </summary>
        NoConnect,
        /// <summary>
        /// 错误
        /// </summary>
        Error
    }
}
