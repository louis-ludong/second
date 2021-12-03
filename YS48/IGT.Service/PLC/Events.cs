using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service.PLC
{

    /// <summary>
    /// 请求密码事件
    /// </summary>
    public class RequestPWdEventArgs : EventArgs
    {
        public RequestPWdEventArgs()
        {
            this.Handeled = false;
        }
        public bool Handeled { get; set; }
    }
    /// <summary>
    /// 连接结束事件
    /// </summary>
    public class ConnictFinishEventArgs : EventArgs
    {
        public ConnictFinishEventArgs(ConnectionFinishReasons reason)
        {
            this.Reason = reason;
        }
        public ConnectionFinishReasons Reason { get; private set; }
    }
    /// <summary>
    /// 数据获取事件
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ModelGotEventArg<T>:EventArgs
    {
        public ModelGotEventArg(T model)
        {
            this.Data = model;
        }
        public T Data { get; private set; }
    }
}
