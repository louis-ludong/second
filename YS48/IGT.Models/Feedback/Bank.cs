using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Feedback
{
    /// <summary>
    /// Bank
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Bank<T>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }
    }
}
