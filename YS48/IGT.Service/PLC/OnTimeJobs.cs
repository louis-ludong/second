using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service.PLC.OnTime
{
    /// <summary>
    /// 定时任务
    /// </summary>
    abstract class OnTimeJob
    {
        /// <summary>
        /// 实例化 定时任务
        /// </summary>
        /// <param name="plc">要关联的设备</param>
        public OnTimeJob(Device plc) { this.PLC = plc; Enable = true; }
        /// <summary>
        /// 执行定时任务
        /// </summary>
        protected abstract void Excetue();
        public void DoIf()
        {
            if (Enable&&count >= Do)
            {
                Excetue();
                System.Threading.Interlocked.Exchange(ref count,0);
            }
            else
                System.Threading.Interlocked.Increment(ref  count);
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get; set; }
        protected int Do;
        public int count;
        protected Device PLC;
    }
    /// <summary>
    /// 实时数据任务
    /// </summary>
    class RealyDataJob:OnTimeJob
    {
        public RealyDataJob(Device plc):base(plc)
        {
            Do = 2;//LDCT   5--3
            count = 1;//LDCT   5--3
        }
        protected override void Excetue()
        {
            this.PLC.GetRealyTimeData();
        }
    }
    /// <summary>
    /// 自动标定任务
    /// </summary>
    class AutoCalibationJob : OnTimeJob
    {
        public AutoCalibationJob(Device plc): base(plc)
        {
            Do = 5;//LDCT   5--3
            count = 4;//LDCT   4--2
        }
        protected override void Excetue()
        {
            this.PLC.GetAutoCalibrationDetails();
        }
    }
    /// <summary>
    /// 诊断信息任务
    /// </summary>
    class DiagnosisDetailsJob:OnTimeJob
    {
        public DiagnosisDetailsJob(Device plc)
            : base(plc)
        {
            Do = 5;//LDCT   5--3
            count = 1;//LDCT   3--1
        }
        protected override void Excetue()
        {
            this.PLC.GetDiagnosisDetails();
        }
    }
    /// <summary>
    /// OBD状态任务
    /// </summary>
    class ODBStateJob:OnTimeJob
    {
        public ODBStateJob(Device plc)
            : base(plc)
        {
            Do = 5;//LDCT   5--3
            count = 0;
        }
        protected override void Excetue()
        {
            this.PLC.GetSelfAdaptationOR_OBDState();//LDC OBD状态
        }
    }
    /// <summary>
    /// 附加信息任务
    /// </summary>
    class AdditionalInfoJob : OnTimeJob
    {
        public AdditionalInfoJob(Device plc)
            : base(plc)
        {
            Do = 5;
            count = 0;
        }
        protected override void Excetue()
        {
            this.PLC.GetAdditionalInfo();
        }
    }
    /// <summary>
    /// 2D曲线任务
    /// </summary>
    class Curve2DJob : OnTimeJob
    {
        public Curve2DJob(Device plc)
            : base(plc)
        {
            Do = 60;
            count = 55;
        }
        protected override void Excetue()
        {
           // this.PLC.GetTiji2DCurve();
        }
    }
    /// <summary>
    /// 3D曲线任务
    /// </summary>
    class Curve3DJob : OnTimeJob
    {
        public Curve3DJob(Device plc)
            : base(plc)
        {
            Do = 180;
            count = 175;
        }
        protected override void Excetue()
        {
          //  this.PLC.GetTiji3DCurve();
        }
    }

}
