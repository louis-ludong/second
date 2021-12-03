using SerialPortsUtils.Agents.Models;
using SerialPortsUtils.Utils.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents
{
    /// <summary>
    /// 异步串口代理
    /// </summary>
    public class AgentAsync : IDisposable, IAgent
    {
        /// <summary>
        /// 预定义动作 发送
        /// </summary>
        public static readonly String Action_Send = "Send";
        /// <summary>
        /// 预定义动作 读取
        /// </summary>
        public static readonly String Action_Read = "Read";
        /// <summary>
        /// 预定义动作 发送并读取
        /// </summary>
        public static readonly String Action_SendAndRead = "SendAndRead";
        /// <summary>
        /// 获取所有还未处理的结果
        /// </summary>
        /// <returns></returns>
        public AgentTaskResult[] GetResults()
        {
            if (ResultQueue == null) throw new InvalidOperationException();
            return ResultQueue.ToArrayAndClear();
        }

        #region Task创建
        /// <summary>
        /// 添加自定义任务
        /// </summary>
        /// <param name="identity">标识符</param>
        /// <param name="enableBit">占用位</param>
        /// <param name="task">任务</param>
        public void AddCustomTask(String identity,int enableBit,AgentTask task)
        {
            Job4Agent job = new Job4Agent(identity, enableBit, task);
            Scheduler.AddJob(job);
        }
        /// <summary>
        /// 创建一个读写报文任务
        /// </summary>
        /// <param name="identity">标识符</param>
        /// <param name="enableBit">占用位</param>
        /// <param name="packet">报文</param>
        /// <param name="filter">要使用的筛选器</param>
        /// <param name="context">要传递的上下文</param>
        public void SendAndRead(string identity, int enableBit, byte[] packet, IReadFilter filter,object context=null)
        {
            Job4Agent job = new Job4Agent( identity, enableBit
                , new AgentTask(packet, filter, Action_SendAndRead, context));
            Scheduler.AddJob(job);
        }
        /// <summary>
        /// 创建一个读取报文任务
        /// </summary>
        /// <param name="identity">标识符</param>
        /// <param name="enableBit">占用位</param>
        /// <param name="filter">筛选器</param>
        /// <param name="context">要传递的上下文</param>
        public void Read(string identity, int enableBit, IReadFilter filter,object context=null)
        {
            Job4Agent job = new Job4Agent(identity, enableBit
                , new AgentTask(null, filter, Action_Read, context));
            Scheduler.AddJob(job);
        }
        
        /// <summary>
        /// 创建一个写入报文任务
        /// </summary>
        /// <param name="identity">标识符</param>
        /// <param name="enableBit">占用位</param>
        /// <param name="packet">筛选器</param>
        /// <param name="context">要传递的上下文</param>
        public void Send(string identity, int enableBit, byte[] packet,object context=null)
        {
            Job4Agent job = new Job4Agent(identity, enableBit
                , new AgentTask(packet, null, Action_Send, context));
            Scheduler.AddJob(job);
        }
        #endregion


        protected void ExecueJob(Job4Agent job)
        {
            var result = new AgentTaskResult(job.Identity);
            result.Action = job.Content.Action;
            try
            {
                switch (job.Content.Action)
                {
                    case "Send":
                        this.IOAgent.Send(job.Content.SendPacket);
                        result.Successed = true;
                        break;
                    case "Read":
                        result.ExecuteResult = this.IOAgent.Read(job.Content.ReadFilter,0x00);
                        result.Successed = true;
                        break;
                    case "SendAndRead":
                        result.ExecuteResult= this.IOAgent.SendAndRead(job.Content.SendPacket,job.Content.ReadFilter);
                        result.Successed = true;
                        break;
                    default:
                        if (CustomActionExecute != null)
                        {
                            CustomActionContext caContext = new CustomActionContext();
                            caContext.Agent = this;
                            caContext.IO = this.IOAgent;
                            caContext.Job = job;
                            result.ExecuteResult = CustomActionExecute(caContext);
                            result.Successed = true;
                        }
                        else
                        {
                            result.Exception = new ArgumentException("未能识别的Action");
                            result.Successed = false;
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("Exception Catch On AgentAsync.ExecueJob");
                System.Diagnostics.Debug.WriteLine(String.Format("{0}:{1}", e.GetType(), e.Message));
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
                result.Exception = e;
                result.Successed = false;
            }
            result.Context = job.Content.Context;
            if (Scheduler.ScheduleState != ScheduleStates.Running) return;
            ResultGot(result);
            if(EnableResultQueue)
                ResultQueue.Enqueue(result);
        }



        #region Job Enable\Disable
        /// <summary>
        /// 设置指定占用位的状态
        /// </summary>
        /// <param name="bit"></param>
        /// <param name="enable"></param>
        public void SetBitState(int bit,bool enable)
        {
            Scheduler.ChangeBitState(bit, enable);
        }

        /// <summary>
        /// 设置所有占用位的状态
        /// </summary>
        /// <param name="enable"></param>
        public void SetAllBitState(bool enable) { Scheduler.ChangeAllBit(enable); }
        #endregion


        #region Ctor
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="sp">要代理的串口对象</param>
        /// <param name="customactionExecute">用于执行非预定义动作(预定动作见Action开头的静态变量)的Action</param>
        public AgentAsync(System.IO.Ports.SerialPort sp,CustomActionExecuteDelegate customactionExecute)
        {
            IOAgent = new Agent(sp);
            Scheduler = new JobScheduler<Job4Agent, AgentTask>(ExecueJob);
            ResultQueue = new Utils.SyncQueue<AgentTaskResult>();
            this.CustomActionExecute = customactionExecute;
            Scheduler.Start();
        }
        public AgentAsync(System.IO.Ports.SerialPort sp) : this(sp, null) { }
        #endregion

        #region Dispose
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            if (Scheduler != null) Scheduler.Stop();
            if (ResultQueue != null) ResultQueue.Clear();
            if (IOAgent != null) IOAgent.Dispose();
        }

        /// <summary>
        /// 等待直到资源被释放
        /// </summary>
        public void WaitDispose()
        {
            if (Scheduler != null) Scheduler.StopWait();
            if (ResultQueue != null) ResultQueue.Clear();
            if (IOAgent != null) IOAgent.Dispose();
        }
        #endregion

        public CustomActionExecuteDelegate CustomActionExecute;
        public bool EnableResultQueue=false;

        /// <summary>
        /// 事件 当结果到达
        /// </summary>
        public event ResultGotDelegate ResultGot;

        Agent IOAgent;
        JobScheduler<Job4Agent,AgentTask> Scheduler;
        Utils.SyncQueue<AgentTaskResult> ResultQueue;
        #region IAgent 成员

        #region Port
        public void ChangePort(string portName)
        {
            IOAgent.ChangePort(portName);
        }

        public void ClosePort()
        {
            IOAgent.ClosePort();
        }
        public void OpenPort()
        {
            IOAgent.OpenPort();
        }
        public bool PortIsOpen
        {
            get { return IOAgent.PortIsOpen; }
        }
        public string PortName { get { return IOAgent.PortName; } }
        #endregion

        #endregion
        /// <summary>
        /// 用于执行非预定义动作的委托类型
        /// </summary>
        /// <param name="context">执行上下文</param>
        /// <returns>执行的原始结果</returns>
        public delegate byte[] CustomActionExecuteDelegate(CustomActionContext context);
        public delegate void ResultGotDelegate(AgentTaskResult result);
    }
}
