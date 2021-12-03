using System;
using System.Collections.Generic;
using System.Text;
using IGT.Service.PLC.OnTime;

namespace IGT.Service.PLC
{
    /// <summary>
    /// 定时任务枚举
    /// </summary>
    public enum OnTimeTasks
    {
        GetRealyTimeData, GetAutoCalibrationDetails, GetDiagnosisDetails, GetSelfAdaptationOR_ODBState, GetAdditionalInfo,GetTiji2DCurve
        , GetTiji3DCurve
    }
    /// <summary>
    /// 定时任务调度器
    /// </summary>
    class OnTimeSchudle:IDisposable
    {
        const int DisableValue = -1;
        const int EnableValue = 0;
        /// <summary>
        /// 实例化 定时任务调度器
        /// </summary>
        /// <param name="plc">要关联的设备</param>
        public OnTimeSchudle(Device plc)
        {
            this.PLC = plc;
            this.timer = new System.Threading.Timer(Do);
        }
        /// <summary>
        /// 启动
        /// </summary>
        public void Start()
        {
            isRunning = true;
            timer.Change(0, 100);//LDC 刷新时间
        }
        /// <summary>
        /// 停止运行
        /// </summary>
        public void Stop()
        {
            timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            EndTask(OnTimeTasks.GetRealyTimeData);
            EndTask(OnTimeTasks.GetAutoCalibrationDetails);
            EndTask(OnTimeTasks.GetDiagnosisDetails);
            EndTask(OnTimeTasks.GetSelfAdaptationOR_ODBState);
            EndTask(OnTimeTasks.GetAdditionalInfo);
            EndTask(OnTimeTasks.GetTiji2DCurve);
            isRunning = false;
        }
        /// <summary>
        /// 开始指定任务
        /// </summary>
        /// <param name="task">要开始的任务</param>
        public void BeginTask(OnTimeTasks task)
        {
            if (!isRunning) Start();
            switch (task)
            {
                case OnTimeTasks.GetRealyTimeData:
                    if (this.RealyDataJob == null) this.RealyDataJob = new OnTime.RealyDataJob(this.PLC);
                    this.RealyDataJob.Enable = true;
                  //  this.RealyDataJob.count = 0;
                    break;
                case OnTimeTasks.GetAutoCalibrationDetails:
                    if (this.AutoCalibationJob == null) this.AutoCalibationJob = new OnTime.AutoCalibationJob(this.PLC);
                    this.AutoCalibationJob.Enable = true;
                    this.AutoCalibationJob.count = 45;
                    break;
                case OnTimeTasks.GetDiagnosisDetails:
                    if (this.DiagnosisDetailsJob == null) this.DiagnosisDetailsJob = new OnTime.DiagnosisDetailsJob(this.PLC);
                    this.DiagnosisDetailsJob.Enable = true;
                    break;
                case OnTimeTasks.GetSelfAdaptationOR_ODBState:
                    if (this.ODBStateJob == null) this.ODBStateJob = new OnTime.ODBStateJob(this.PLC);
                    this.ODBStateJob.Enable = true;
                    break;
                case OnTimeTasks.GetAdditionalInfo:
                    if (this.AdditionalInfoJob == null) this.AdditionalInfoJob = new OnTime.AdditionalInfoJob(this.PLC);
                    this.AdditionalInfoJob.Enable = true;
                    break;
                case OnTimeTasks.GetTiji2DCurve:
                    if (this.Curve2DJob == null) this.Curve2DJob = new OnTime.Curve2DJob(this.PLC);
                    this.Curve2DJob.Enable = true;
                    break;
                case OnTimeTasks.GetTiji3DCurve:
                    if (this.Curve3DJob == null) this.Curve3DJob = new OnTime.Curve3DJob(this.PLC);
                    this.Curve3DJob.Enable = true;
                    break;
                default:
                    throw new ArgumentException("task");
            }
        }
        /// <summary>
        /// 结束指定任务
        /// </summary>
        /// <param name="task">要结束的任务</param>
        public void EndTask(OnTimeTasks task)
        {
            switch (task)
            {
                case OnTimeTasks.GetRealyTimeData:
                    if (this.RealyDataJob!=null)
                        this.RealyDataJob.Enable=false;
                    break;
                case OnTimeTasks.GetAutoCalibrationDetails:
                    if (this.AutoCalibationJob != null)
                        this.AutoCalibationJob.Enable = false;
                    break;
                case OnTimeTasks.GetDiagnosisDetails:
                    if (this.DiagnosisDetailsJob != null)
                        this.DiagnosisDetailsJob.Enable = false;
                    break;
                case OnTimeTasks.GetSelfAdaptationOR_ODBState:
                    if (this.ODBStateJob != null)
                        this.ODBStateJob.Enable = false;
                    break;
                case OnTimeTasks.GetAdditionalInfo:
                    if (this.AdditionalInfoJob != null)
                        this.AdditionalInfoJob.Enable = false;
                    break;
                case OnTimeTasks.GetTiji2DCurve:
                    if (this.Curve2DJob != null)
                        this.Curve2DJob.Enable = false;
                    break;
                case OnTimeTasks.GetTiji3DCurve:
                    if (this.Curve3DJob != null)
                        this.Curve3DJob.Enable = false;
                    break;
                default:
                    throw new ArgumentException("task");
            }
        }
        private void Do(object nothing)
        {
            if (this.RealyDataJob != null) this.RealyDataJob.DoIf();
            if (this.AutoCalibationJob != null) this.AutoCalibationJob.DoIf();
            if (this.DiagnosisDetailsJob != null) this.DiagnosisDetailsJob.DoIf();
            if (this.ODBStateJob != null) this.ODBStateJob.DoIf();
            if (this.AdditionalInfoJob != null) this.AdditionalInfoJob.DoIf();
          //    if (this.Curve2DJob != null) this.Curve2DJob.DoIf();
          //  if (this.Curve3DJob != null) this.Curve3DJob.DoIf();
        }
        
        bool isRunning;
        System.Threading.Timer timer;
        RealyDataJob RealyDataJob;
        AutoCalibationJob AutoCalibationJob;
        DiagnosisDetailsJob DiagnosisDetailsJob;
        ODBStateJob ODBStateJob;
        AdditionalInfoJob AdditionalInfoJob;
        Curve2DJob Curve2DJob;
        Curve3DJob Curve3DJob;
        private Device PLC;

        #region IDisposable 成员

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            this.Stop();
            timer.Dispose();
        }

        #endregion
    }
}
