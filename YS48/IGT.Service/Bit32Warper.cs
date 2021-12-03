using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service
{
    /// <summary>
    /// 32位的bool存储器
    /// </summary>
    public class Bit32Warper
    {
        public const int Data_AllTRUE = -1;
        public const int Data_ALLFALSE = 0;
        /// <summary>
        /// 设置所有位
        /// </summary>
        /// <param name="trueOrFalse">设设定的值</param>
        public void SetAll(bool trueOrFalse)
        {
            Data = trueOrFalse ? Data_AllTRUE : Data_ALLFALSE;

        }
        /// <summary>
        /// 获取或设置指定位上的bool值
        /// </summary>
        /// <param name="index">位索引</param>
        /// <returns>指定位上的值</returns>
        public bool this[int index]
        {
            get { return GetBitValue(Data, index)==1; }
            set
            {
                _Data = value ?
                    AddBitValue(_Data, index) :
                    RemoveBitValue(_Data, index);
            }
        }
        /// <summary>
        /// 实例化
        /// </summary>
        public Bit32Warper() : this(0) { }
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="data">初始值</param>
        public Bit32Warper(int data)
        {
            _Data = data;
        }
        private int _Data;

        /// <summary>
        /// 被包装的值
        /// </summary>
        public int Data
        {
            get { return _Data; }
            protected set { _Data = value; }
        }


        /// <summary>
        /// 将指定位上的值置为0
        /// </summary>
        /// <param name="value">要设置的位集</param>
        /// <param name="index">要设置的位</param>
        /// <returns></returns>
        public static int RemoveBitValue(int value, int index)
        {
            int bit = 1 << index;
            int nMark = 0;
            nMark = (~nMark) ^ bit;
            value &= nMark;
            return value;
        }
        /// <summary>
        /// 将指定位上的值置为1
        /// </summary>
        /// <param name="value">要设置的位集</param>
        /// <param name="index">要设置的位</param>
        /// <returns></returns>
        public static int AddBitValue(int value, int index)
        {
            int bit = 1 << index;
            int result = value | bit;
            return result;
        }
        /// <summary>
        /// 获取指定位上的值
        /// </summary>
        /// <param name="value">来源位集</param>
        /// <param name="index">要获取的位</param>
        /// <returns></returns>
        public static int GetBitValue(int value, int index)
        {
            int result = (value >> index) & 0x01;
            return result;
        }
    }
}
