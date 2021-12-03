using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Utils.Schedule
{
    /// <summary>
    /// Job调度器
    /// </summary>
    /// <typeparam name="TJob">要调度的Job类型</typeparam>
    public class JobScheduler<TJob,TJobContext> : IDisposable
        where TJob : IJob<TJobContext>
    {
        public void AddJob(TJob job)
        {
            JobQueue.Enqueue(job);
            AddJobWaitHandle.Set();
        }

        #region CancelBits
        /// <summary>
        /// 设置占用位状态
        /// </summary>
        /// <param name="bit">要设置的位</param>
        /// <param name="enable">状态</param>
        public void ChangeBitState(int bit,bool enable)
        {
            CancelBits[bit] = !enable;
        }
        /// <summary>
        /// 设置所有用位状态
        /// </summary>
        /// <param name="enable">状态</param>
        public void ChangeAllBit(bool enable)
        {
            CancelBits.SetAll(!enable);
        }
        #endregion
        #region 状态控制
        void Loop(object nothing)
        {
            PreJobLoop();
            LoopWaitHandle.Reset();
            System.Threading.Interlocked.CompareExchange(ref StatusFlag, 1, 0);
            try
            {
                do
                {
                    if (JobQueue.Count > 0)
                    {
                        TJob job;
                        bool got = JobQueue.TryDequeue(out job);
                        if (got)
                            if (!CancelBits[job.EnableBit])
                                try
                                {
                                    ExecuteJobAction(job);
                                }
                                catch (Exception e)
                                {
                                    System.Diagnostics.Debug.WriteLine(String.Format("Job执行循环中发生未处理的异常"));
                                    System.Diagnostics.Debug.WriteLine(e.GetType() + " " + e.Message);
                                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
#if DEBUG
                                    throw e;
#endif
                                }
                    }
                    else
                        AddJobWaitHandle.WaitOne();
                } while (StatusFlag == 1);
            }
            finally
            {
                System.Diagnostics.Debug.WriteLine("等待Job执行线程上的循环已结束");
                PostJobLoop();
                LoopWaitHandle.Set();
                System.Diagnostics.Debug.WriteLine("Job执行线程已退出");
            }
        }
        /// <summary>
        /// 停止此调度器并等待其状态到达,如果在指定的时间内未到达停止状态，则引发System.TimeoutException
        /// </summary>
        /// <exception cref="System.TimeoutException" >未能在指定时间内完成停止</exception>
        /// <exception cref="System.InvalidOperationException">Stop在当前状态不可用</exception>
        /// <param name="waitTimeout">毫秒 -1时不等待，0时无限等待</param>
        public void Stop(int waitTimeout)
        {
            if (StatusFlag == -1) throw new InvalidOperationException("JobScheduler已释放");
            else if (StatusFlag == 2) throw new InvalidOperationException("正在停止中 请勿重复调用");
            System.Threading.Interlocked.Exchange(ref StatusFlag, 0);
            AddJobWaitHandle.Set();
            if (waitTimeout != -1)
            {
                System.Diagnostics.Debug.WriteLine("等待Job执行线程退出");
                if (waitTimeout == 0) LoopWaitHandle.WaitOne();
                else if (LoopWaitHandle.WaitOne(waitTimeout,false))
                    throw new TimeoutException(
                        String.Format("Job执行线程未能在指定时间内({0})结束", waitTimeout.ToString()));
            }
        }
        /// <summary>
        /// 停止此调度器并等待其状态到达
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Stop在当前状态不可用</exception>
        public void StopWait()
        {
            Stop(0);
        }
        /// <summary>
        /// 停止此调度器
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Stop在当前状态不可用</exception>
        public void Stop()
        {
            Stop(-1);
        }
        /// <summary>
        /// 启动此调度器
        /// </summary>
        public void Start()
        {
            if (StatusFlag == -1) throw new InvalidOperationException("JobScheduler已释放");
            else if (StatusFlag != 0) throw new InvalidOperationException("当前状态不可用 请先调用Finish()并等待其完成");
            CancelBits = new SyncBit32Map(0);
            ExecuteThread = new System.Threading.Thread(Loop);
            ExecuteThread.Name = "Job执行";
            ExecuteThread.Start();
        }
        #endregion


        /// <summary>
        /// 在job执行线程启动后，job执行循环开始前
        /// </summary>
        protected virtual void PreJobLoop()
        {
            JobQueue = new SyncQueue<TJob>();
            CancelBits = new SyncBit32Map(0);
        }

        /// <summary>
        /// 在job执行循环退出后，job执行线程退出前
        /// </summary>
        protected virtual void PostJobLoop()
        {
            JobQueue.Clear();
            JobQueue = null;
        }

        #region Ctor
        public JobScheduler(DoJobDelegate del)
        {
            ExecuteJobAction = del;
        }
        #endregion

        /// <summary>
        /// 调度器状态
        /// </summary>
        public ScheduleStates ScheduleState
        {
            get
            {
                switch (StatusFlag)
                {
                    case 0: return ScheduleStates.Stoped;
                    case 1: return ScheduleStates.Running;
                    case 2: return ScheduleStates.RequestStop;
                    case -1: return ScheduleStates.Disposed;
                    default: throw new ArgumentException("未能识别的StatusFlag值 {0}", StatusFlag.ToString());
                }
            }
        }
        /// <summary>
        /// 0 未运行或已停止；1运行中；2请求停止
        /// </summary>
        int StatusFlag = 0;
        System.Threading.AutoResetEvent AddJobWaitHandle = new System.Threading.AutoResetEvent(false);
        System.Threading.EventWaitHandle LoopWaitHandle = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.ManualReset);
        System.Threading.Thread ExecuteThread;
        protected SyncBit32Map CancelBits;
        SyncQueue<TJob> JobQueue;
        DoJobDelegate ExecuteJobAction;

        /// <summary>
        /// 释放调度器
        /// </summary>
        public virtual void Dispose()
        {
            StopWait();
            AddJobWaitHandle = null;
            LoopWaitHandle = null;
            ExecuteThread = null;
            StatusFlag = -1;
        }

        public delegate void DoJobDelegate(TJob job);
    }
    /// <summary>
    /// 调度器状态
    /// </summary>
    public enum ScheduleStates
    {
        /// <summary>
        /// 已停止
        /// </summary>
        Stoped,
        /// <summary>
        /// 运行中
        /// </summary>
        Running, 
        /// <summary>
        /// 正在请求停止
        /// </summary>
        RequestStop, 
        /// <summary>
        /// 以释放
        /// </summary>
        Disposed
    }
}
