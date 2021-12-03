using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service.PLC
{
    /// <summary>
    /// 连接结束原因
    /// </summary>
    public enum ConnectionFinishReasons
    {
        /// <summary>
        /// 成功
        /// </summary>
        Succeed,
        /// <summary>
        /// 无响应
        /// </summary>
        NoRespose, 
        /// <summary>
        /// 已取消
        /// </summary>
        Cancel,
        /// <summary>
        /// ECU等待升级中
        /// </summary>
        Bootloader
    }
    /// <summary>
    /// 连接状态
    /// </summary>
    public enum ConnectionState
    {
        /// <summary>
        /// 未开始
        /// </summary>
        NoBegin, 
        /// <summary>
        /// 初始化连接
        /// </summary>
        InitConnicting,
        /// <summary>
        /// 保持心跳
        /// </summary>
        KeepConnction
    }
    /// <summary>
    /// 密码状态
    /// </summary>
    public enum PasswordStatus
    {
        /// <summary>
        /// 位置
        /// </summary>
        Unkown,
        /// <summary>
        /// 需要
        /// </summary>
        Need, 
        /// <summary>
        /// 不需要
        /// </summary>
        NotNeed
    }
}
