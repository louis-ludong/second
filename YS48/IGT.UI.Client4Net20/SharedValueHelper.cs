using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.UI.Client
{
    /// <summary>
    /// 全局共享参数
    /// </summary>
    class SharedValueHelper
    {
        /// <summary>
        /// 按键切换命令的按键的状态
        /// （此命令只能设置，而不能从下位机获取，故而设置为全局共享）
        /// </summary>
        public static bool? KeySwitchState { get; set; }
    }
}
