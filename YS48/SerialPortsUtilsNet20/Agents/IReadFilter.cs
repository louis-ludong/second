using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents
{
    /// <summary>
    /// 筛选器，用于提取需要的报文
    /// </summary>
    public interface IReadFilter
    {
        /// <summary>
        /// 筛选报文
        /// </summary>
        /// <param name="raw"></param>
        /// <returns>是否已筛选出符合要求的数据</returns>
        bool Filter(byte[] raw);
        /// <summary>
        /// 返回筛选后的最新的报文，如果无则引发异常
        /// </summary>
        /// <returns></returns>
        byte[] GetReadCode();
        /// <summary>
        /// 超时时间
        /// </summary>
        int? Timeout { get; }

      //  byte[] CommondFilter { get; set; }
    }

    /// <summary>
    /// 可重复使用的IReadFilter
    /// </summary>
    public interface IReadFilterReuses:IReadFilter
    {
    }
}
