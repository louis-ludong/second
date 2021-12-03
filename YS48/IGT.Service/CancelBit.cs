using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service
{
    /// <summary>
    /// 用于取消的占用位常量
    /// </summary>
    public class CancelBit
    {
        /// <summary>
        /// 常规
        /// </summary>
        public const int Nomal=20;
        /// <summary>
        /// 存储相关
        /// </summary>
        public const int Storage=21;
        /// <summary>
        /// 连接相关
        /// </summary>
        public const int Connection = 22;
    }
}
