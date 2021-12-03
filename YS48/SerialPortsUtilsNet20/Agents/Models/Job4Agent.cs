using SerialPortsUtils.Utils.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents.Models
{
    /// <summary>
    /// Job4Agent的正文
    /// </summary>
    public class AgentTask
    {
        public AgentTask(){}
        public AgentTask(byte[] sendPacket,IReadFilter readFilter,string action,object context)
        {

            this.SendPacket = sendPacket;
            this.ReadFilter = readFilter;
            this.Action = action;
            this.Context = context;
        }
        public AgentTask(byte[] sendPacket, IReadFilter readFilter, string action):this(sendPacket,readFilter,action,null)
        {}

        /// <summary>
        /// 要发送的报文
        /// </summary>
        public byte[] SendPacket { get; set; }

        /// <summary>
        /// 要执行的动作
        /// 预定义值包括
        ///      Send 发送
        ///      Read 读取
        ///      SendAndRead 发送并读取
        /// </summary>
        public virtual String Action { get; set; }
        /// <summary>
        /// 用于获取响应报文的Filter
        /// </summary>
        public IReadFilter ReadFilter { get; set; }
        /// <summary>
        /// 携带的上下文
        /// </summary>
        public object Context { get; set; }
    }
    /// <summary>
    /// 用于Agent的Job
    /// </summary>
    public class Job4Agent : DefaultJob<AgentTask>
    {
        public Job4Agent(string identity,int enableBit,AgentTask context)
        {
            this.Identity = identity;
            this.EnableBit = enableBit;
            this.Content = context;
        }
    }
}
