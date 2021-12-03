using System;
using System.Collections.Generic;
using System.Text;
using IGT.Service.PLC;

namespace IGT.UI.Client
{
    /// <summary>
    /// 预加载的实时数据
    /// 直接截获相关事件，绕开正常装配流程以减少等待时间
    /// </summary>
    public class RealyDataPre
    {
        private Models.Feedback.RealTimeData rData;
        private Device device;
        private bool getOnce=false,subscribed=false;
        /// <summary>
        /// 实时数据
        /// </summary>
        public Models.Feedback.RealTimeData RealData
        {
            get { return rData; }
            private set { rData = value; }
        }
        public RealyDataPre(Device device)
        {
            this.device = device;
        }

        void device_RealyTimeDataGot(object sender, ModelGotEventArg<Models.Feedback.RealTimeData> e)
        {
            System.Threading.Interlocked.Exchange(ref rData, e.Data);
            if (getOnce == true)
                End();
        }
        /// <summary>
        /// 开始获取
        /// </summary>
        /// <param name="once">仅一次</param>
        public void Begin(bool once)
        {
            this.getOnce = once;
            Begin();

        }
        /// <summary>
        /// 开始获取
        /// </summary>
        public void Begin()
        {
            if (!subscribed)
            {
                this.device.RealyTimeDataGot += device_RealyTimeDataGot;
                subscribed = true;
            }
        }
        /// <summary>
        /// 结束获取
        /// </summary>
        public void End()
        {
            if (getOnce)
            {
                getOnce = false;
            }
            if (subscribed)
            {
                this.device.RealyTimeDataGot -= device_RealyTimeDataGot;
                subscribed = false;
            }
        }
    }
}
