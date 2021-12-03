using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents.Models
{
    public class CustomActionContext
    {
        public AgentAsync Agent { get; set; }
        public Agent IO { get; set; }
        public Job4Agent Job { get; set; }

    }
}
