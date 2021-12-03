using SerialPortsUtils.Utils.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents.Models
{
    public class AgentTaskResult : IJobResult<byte[]>
    {
        public AgentTaskResult(){}
        public AgentTaskResult(String identity)
        {
            this.Identity = identity;
        }

        public string Action { get; set; }
        public object Context { get; set; }

        #region IJobResult<AgentTaskResult> 成员

        public string Identity { get; set; }

        public Exception Exception { get; set; }

        public bool Successed { get; set; }

        public byte[] ExecuteResult { get; set; }

        #endregion
    }
}
