using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Utils.Schedule
{
    /// <summary>
    /// Job的必要信息
    /// </summary>
    public interface IJob<T>
    {
        int EnableBit { get; set; }
        String Identity { get; set; }
        T Content { get; set; }
    }
    /// <summary>
    /// 默认Job
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DefaultJob<T>:IJob<T>
    {

        #region IJob<T> 成员

        /// <summary>
        /// 启用位
        /// </summary>
        public int EnableBit { get; set; }

        /// <summary>
        /// 标识符
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public T Content { get; set; }

        #endregion
    }
}
