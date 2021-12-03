using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Utils.Schedule
{
    /// <summary>
    /// Job结果
    /// </summary>
    /// <typeparam name="T">结果类型</typeparam>
    public interface IJobResult<T>
    {
        /// <summary>
        /// Job标识符
        /// </summary>
        String Identity { get; set; }
        /// <summary>
        /// 执行期间的异常
        /// </summary>
        Exception Exception { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        bool Successed { get; set; }
        /// <summary>
        /// 执行结果
        /// </summary>
        T ExecuteResult { get; set; }
    }
}
