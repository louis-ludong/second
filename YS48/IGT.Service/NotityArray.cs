using System;
using System.Collections.Generic;
using System.Text;
namespace IGT.Service
{
    /// <summary>
    /// 可发布变更通知的数组
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NotityArray<T> : IEnumerable<T>, IList<T>
    {
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="array">原始数组</param>
        /// <param name="customSender">发布事件时的事件源</param>
        public NotityArray(T[] array,object customSender)
        {
            this.InnerArrary = array;
            this.CustomObject = customSender;
        }
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="array">原始数组</param>
        public NotityArray(T[] array)
        {
            this.CustomObject = null;
            this.InnerArrary = array;
        }
        /// <summary>
        /// 克隆内部数据
        /// </summary>
        /// <returns></returns>
        public T[] CloneInner()
        {
            T[] result = new T[this.InnerArrary.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = this.InnerArrary[i];
            }
            return result;
        }
        /// <summary>
        /// 修改数组但不触发事件
        /// </summary>
        /// <param name="array"></param>
        internal void AttactNoEvent(T[] array)
        {
            this.InnerArrary = array;
        }
        #region IEnumerable<T> 成员

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            
            return (InnerArrary as IEnumerable<T>).GetEnumerator();
        }

        #endregion

        #region IEnumerable 成员

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerArrary.GetEnumerator();
        }

        #endregion
        T[] InnerArrary;

        #region IList<T> 成员

        public int IndexOf(T item)
        {
            return (this.InnerArrary as IList<T>).IndexOf(item);
        }

        void IList<T>.Insert(int index, T item)
        {
            throw new NotSupportedException();
        }

        void IList<T>.RemoveAt(int index)
        {
            throw new NotSupportedException();
        }

        public T this[int index]
        {
            get { return this.InnerArrary[index]; }
            set
            {
                this.InnerArrary[index] = value;
                if (ItemChanged != null)
                    ItemChanged(this, new ItemChangedEventArgs(index));
                if(ItemChangedCustomSender!=null)
                    ItemChangedCustomSender(CustomObject, new ItemChangedEventArgs(index));
            }
        }

        #endregion

        #region ICollection<T> 成员

        void ICollection<T>.Add(T item)
        {
            throw new NotSupportedException();
        }

        void ICollection<T>.Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(T item)
        {
            return (this.InnerArrary as ICollection<T>).Contains(item);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            this.InnerArrary.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return (this.InnerArrary as ICollection<T>).Count; }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { return false; }
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotSupportedException();
        }

        #endregion
        /// <summary>
        /// 自定义源
        /// </summary>
        public object CustomObject { get; private set; }
        /// <summary>
        /// 事件 数组项变更（带自定义源）
        /// </summary>
        public event EventHandler<ItemChangedEventArgs> ItemChangedCustomSender;
        /// <summary>
        /// 事件 数组项变更
        /// </summary>
        public event EventHandler<ItemChangedEventArgs> ItemChanged;
        
    }
    /// <summary>
    /// 数据变更 事件参数
    /// </summary>
    public class ItemChangedEventArgs : EventArgs
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="index">变更项索引</param>
        public ItemChangedEventArgs(int index)
        {
            this.ItemIndex = index;
        }
        /// <summary>
        /// 变更项索引
        /// </summary>
        public int ItemIndex { get; protected set; }
    }
}
