using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service
{
    /// <summary>
    /// 元祖
    /// </summary>
    public static class Tulpe
    {
        /// <summary>
        /// 创建元祖
        /// </summary>
        /// <typeparam name="T1">Item1的类型</typeparam>
        /// <typeparam name="T2">Item2的类型</typeparam>
        /// <param name="item1">item1</param>
        /// <param name="item2">item2</param>
        /// <returns></returns>
        public static Tulpe<T1,T2> Create<T1,T2>(T1 item1,T2 item2)
        {
            return new Tulpe<T1, T2>(item1, item2);
        }
        /// <summary>
        /// 创建元祖
        /// </summary>
        /// <typeparam name="T1">Item1的类型</typeparam>
        /// <typeparam name="T2">Item2的类型</typeparam>
        /// <typeparam name="T3">Item3的类型</typeparam>
        /// <typeparam name="T4">Item4的类型</typeparam>
        /// <typeparam name="T5">Item5的类型</typeparam>
        /// <param name="item1">item1</param>
        /// <param name="item2">item2</param>
        /// <param name="item3">item3</param>
        /// <param name="item4">item4</param>
        /// <param name="item5">item5</param>
        /// <returns></returns>
        public static Tulpe<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2,T3 item3,T4 item4,T5 item5)
        {
            return new Tulpe<T1, T2, T3, T4, T5>(item1, item2,item3,item4,item5);
        }
    }
    /// <summary>
    /// 元祖
    /// </summary>
    /// <typeparam name="T1">Item1的类型</typeparam>
    /// <typeparam name="T2">Item2的类型</typeparam>
    public class Tulpe<T1,T2>
    {
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="item1">item1</param>
        /// <param name="item2">item2</param>
        public Tulpe(T1 item1,T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }
        public T1 Item1 { get;private set; }
        public T2 Item2 { get;private set; }
        public override string ToString()
        {
            return String.Format("{0};{1}",Item1.ToString(), Item2.ToString());
        }
    }
    /// <summary>
    /// 元祖
    /// </summary>
    /// <typeparam name="T1">Item1的类型</typeparam>
    /// <typeparam name="T2">Item2的类型</typeparam>
    /// <typeparam name="T3">Item3的类型</typeparam>
    /// <typeparam name="T4">Item4的类型</typeparam>
    /// <typeparam name="T5">Item5的类型</typeparam>
    public class Tulpe<T1,T2,T3,T4,T5>
    {
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="item1">item1</param>
        /// <param name="item2">item2</param>
        /// <param name="item3">item3</param>
        /// <param name="item4">item4</param>
        /// <param name="item5">item5</param>
        public Tulpe(T1 item1,T2 item2,T3 item3,T4 item4,T5 item5)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
            this.Item4 = item4;
            this.Item5 = item5;
        }
        public T1 Item1 { get; private set; }
        public T2 Item2 { get; private set; }
        public T3 Item3 { get; private set; }
        public T4 Item4 { get; private set; }
        public T5 Item5 { get; private set; }
        public override string ToString()
        {
            return String.Format("{0};{1};{2};{3};{4}", Item1.ToString(), Item2.ToString()
                ,Item3.ToString(),Item4.ToString(),Item5.ToString());
        }
    }
}
