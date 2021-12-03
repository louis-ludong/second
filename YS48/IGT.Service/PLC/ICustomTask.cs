using System;
using System.Collections.Generic;
using System.Text;
using SerialPortsUtils.Agents;
using SerialPortsUtils.Agents.Models;
namespace IGT.Service.PLC
{
    /// <summary>
    /// 表示一个与下位机通信的自定义任务
    /// </summary>
    public interface ICustomTask
    {
        /// <summary>
        /// 执行此自定义任务
        /// </summary>
        /// <param name="context">上下文</param>
        /// <returns>下位机返回的原始数据</returns>
        byte[] Execute(CustomActionContext context);
    }
    /// <summary>
    /// 表示一个与下位机通信的自定义任务
    /// </summary>
    /// <typeparam name="T">任务返回值的类型</typeparam>
    public interface ICustomTask<T>:ICustomTask
    {
        /// <summary>
        /// 获取任务返回值
        /// </summary>
        /// <returns></returns>
        T GetResult();
    }
    /// <summary>
    /// 表示一个与下位机通信的可等待的自定义任务
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal abstract class CanWaitCustom<T> : ICustomTask<T>
    {
        /// <summary>
        /// 创建任务对象
        /// </summary>
        /// <param name="device">关联的设备</param>
        public CanWaitCustom(Device device)
        {
            this.Device = device;
        }
        /// <summary>
        /// 等待返回结果
        /// </summary>
        /// <param name="timeout">等待超时毫秒数 默认-1不超时</param>
        /// <returns>任务返回值</returns>
        public T WaitResult(int timeout = -1)
        {
            try
            {
                if (!waitHandle.WaitOne(timeout,false))
                    throw new TimeoutException();
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Result; 
        }
        void device_ResultGot4Custom(AgentTaskResult result)
        {
            if (!Got&&result.Context.Equals(this))
            {
                Got = true;
                this.Device.ResultGot4Custom -= device_ResultGot4Custom;
                ResultGotHandler(result);
                result.Context = null;
                waitHandle.Set();
            }
        }
        /// <summary>
        /// 处理任务返回
        /// </summary>
        /// <param name="result"></param>
        protected virtual void ResultGotHandler(AgentTaskResult result) { }
        /// <summary>
        /// 任务实际执行方法
        /// </summary>
        /// <param name="context">上下文</param>
        /// <returns>下位机返回的原始数据</returns>
        protected abstract byte[] ExecuteInner(CustomActionContext context);
        #region ICustomTask 成员
        /// <summary>
        /// 执行此自定义任务
        /// 欲定义任务执行方法，请重写 ExecuteInner
        /// </summary>
        /// <param name="context">上下文</param>
        /// <returns>下位机返回的原始数据</returns>
        public byte[] Execute(CustomActionContext context)
        {
            this.Device.ResultGot4Custom += device_ResultGot4Custom;
            return ExecuteInner(context);
        }

        #endregion
        bool Got=false;
        protected T Result;
        protected Device Device;
        System.Threading.EventWaitHandle waitHandle = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.ManualReset);

        #region ICustomTask<T> 成员

        /// <summary>
        /// 获取任务返回值
        /// </summary>
        /// <returns></returns>
        public T GetResult()
        {
            return Result;
        }

        #endregion
    }
}
