using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Utils
{
    /// <summary>
    /// 线程安全的队列
    /// </summary>
    /// <typeparam name="T">队列元素类型</typeparam>
    public class SyncQueue<T>
    {
        /// <summary>
        /// 元素数量
        /// </summary>
        public int Count { get { return _Count; } }
        /// <summary>
        /// 返回此队列对应的数组，并清空队列
        /// </summary>
        /// <returns></returns>
        public T[] ToArrayAndClear()
        {
            lock (_syncRoot)
            {
                var results = this.Queue.ToArray();
                this.Queue.Clear();
                System.Threading.Interlocked.Exchange(ref _Count, 0);
                return results;
            }
        }
        /// <summary>
        /// 返回此队列对应的数组
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            lock (_syncRoot)
            {
                return this.Queue.ToArray();
            }
        }
        /// <summary>
        /// 清空队列
        /// </summary>
        /// <returns>是否成功</returns>
        public bool Clear()
        {
            bool result = false;
            if (_Count == 0) result = true;
            else
            {
                lock (_syncRoot)
                {
                    this.Queue.Clear();
                    System.Threading.Interlocked.Exchange(ref _Count, 0);
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// 尝试获取队列开始初的对象，但不移除他
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool TryPeek(out T item)
        {
            bool get = false;
            if (_Count < 1) { item = default(T); }
            else
            {
                lock (_syncRoot)
                {
                    if (_Count < 1) { item = default(T); }
                    item = this.Queue.Peek();
                    get = true;
                }
            }
            return get;
        }
        /// <summary>
        /// 尝试移除并返回队列开始处的对象
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool TryDequeue(out T item)
        {
            bool get = false;
            if (_Count < 1) { item = default(T); }
            else
            {
                lock (_syncRoot)
                {
                    if (_Count < 1) { item = default(T); }
                    item = this.Queue.Dequeue();
                    System.Threading.Interlocked.Decrement(ref _Count);
                    get = true;
                }
            }
            return get;
        }

        /// <summary>
        /// 将对象添加到队列末尾
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            lock (_syncRoot)
            {
                this.Queue.Enqueue(item);
                System.Threading.Interlocked.Increment(ref _Count);
            }
        }
        /// <summary>
        /// 实例化
        /// </summary>
        public SyncQueue()
        {
            this.Queue = new Queue<T>();
            _Count = 0;
        }
        int _Count;
        System.Collections.Generic.Queue<T> Queue;
        object _syncRoot = new object();
    }
}
