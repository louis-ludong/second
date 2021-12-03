using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Utils
{
    /// <summary>
    /// 线程安全的32位bool存储器
    /// </summary>
    public class SyncBit32Map
    {
        public void SetAll(bool trueOrFalse)
        {
            System.Threading.Interlocked.Exchange(ref _Data, trueOrFalse ? -1 : 0);

        }
        /// <summary>
        /// 获取指定位的状态
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[int index]
        {
            get { return GetBitValue(Data, index); }
            set
            {
                int val = value ?
                    AddBitValue(_Data, index) :
                    RemoveBitValue(_Data, index);
                System.Threading.Interlocked.Exchange(ref _Data, val);
            }
        }
        public SyncBit32Map(int data)
        {
            _Data = data;
        }
        private int _Data;

        public int Data
        {
            get { return _Data; }
            protected set { _Data = value; }
        }


        int RemoveBitValue(int value, int index)
        {
            int bit = 1 << index;
            int nMark = 0;
            nMark = (~nMark) ^ bit;
            value &= nMark;
            return value;
        }
        int AddBitValue(int value, int index)
        {
            int bit = 1 << index;
            int result = value | bit;
            return result;
        }
        bool GetBitValue(int value, int index)
        {
            int result = (value >> index) & 0x01;
            return result == 1;
        }
    }
}
