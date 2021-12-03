using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Utils.Schedule
{
    /// <summary>
    /// 默认Job
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JobResult<T> : IJobResult<T>
    {
        public String Identity { get; set; }
        public Exception Exception { get; set; }
        public bool Successed { get; set; }
        public T ExecuteResult { get; set; }
    }
}
