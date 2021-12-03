using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IGT.Service.PLC
{
    /// <summary>
    /// 下位机报文筛选器
    /// </summary>
    public class ReadFilter : SerialPortsUtils.Agents.IReadFilterReuses
    {
        /// <summary>
        /// 超时时间
        /// </summary>
        public int? Timeout { get { return null; } }
        /// <summary>
        /// 实例化下位机报文筛选器
        /// </summary>
        /// <param name="cmd">要筛选报文的命令</param>
        public ReadFilter(byte cmd)
        {
            HeadFilter = InstructionSet.RecivedHead;
            CommondFilter = new byte[] { cmd };
        }

        /// <summary>
        /// 实例化下位机报文筛选器
        /// </summary>
        /// <param name="cmd1">要筛选报文的命令</param>
        /// <param name="cmd2">要筛选报文的子命令</param>
        public ReadFilter(byte cmd1, byte cmd2)
        {
            HeadFilter = InstructionSet.RecivedHead;
            CommondFilter = new byte[] { cmd1, cmd2 };
        }
        /// <summary>
        /// 从原始数据筛选报文
        /// </summary>
        /// <param name="raw">原始数据</param>
        /// <returns>是否继续（即是否未得到报文）</returns>
        public bool Filter(byte[] raw)
        {
            if (TempBuffer != null)
            {
                var temp = raw;
                raw = TempBuffer.Concat(temp).ToArray();
                TempBuffer = null;
            }
            int index = CommondFilter.Length == 1 ? FilterSingleCMD(raw) : FilterDoubleCMD(raw);
            if (index+1 < raw.Length)
                TempBuffer = raw.Skip(index + 1).ToArray();
            return FillIndex<4||FillIndex!=LengthByte;
        }
        private int FilterDoubleCMD(byte[] raw)
        {
            int index = 0;
            for (; index < raw.Length; index++)
            {
                byte item = raw[index];
                switch (FillIndex)
                {
                    case 0:
                        if (item == HeadFilter && index + 2 < raw.Length)// V2.8修改
                            if (raw[index + 2] == CommondFilter[0])
                                FillIndex++;
                        break;
                    case 1:
                        LengthByte = item;
                        FillIndex++;
                        break;
                    case 2:
                        if (item == CommondFilter[0])
                            FillIndex++;
                        else
                        {
                            FillIndex = 0;
                        }
                        break;
                    case 3:
                        if (item == CommondFilter[1])
                            FillIndex++;
                        else
                        {
                            FillIndex = 0;
                        }
                        break;
                    default:
                        if (FillIndex == 4)
                            PacketBuffer = new byte[LengthByte];
                        TempBuffer = null;
                        PacketBuffer[FillIndex] = item;
                        FillIndex++;
                        if (FillIndex >= LengthByte)
                            return index;
                        break;
                }
            }
            return index;
        }
        private int FilterSingleCMD(byte[] raw)
        {
            int index = 0;
            for (; index < raw.Length; index++)
            {
                byte item = raw[index];
                switch (FillIndex)
                {
                    case 0:
                        if (item == HeadFilter && index + 2<raw.Length)// 
                            if(raw[index + 2] == CommondFilter[0])
                                FillIndex++;
                        break;
                    case 1:
                        LengthByte = item;
                        FillIndex++;
                        break;
                    case 2:
                        if (item == CommondFilter[0])
                            FillIndex++;
                        else
                        {
                            FillIndex = 0;
                        }
                        break;
                    default:
                        if (FillIndex == 3)
                            PacketBuffer = new byte[LengthByte];
                        TempBuffer = null;
                        PacketBuffer[FillIndex] = item;
                        FillIndex++;
                        if (FillIndex >= LengthByte)
                            return index;
                        break;
                }
            }
            return index;
        }
        /// <summary>
        /// 返回筛选后的数据，如果未筛选出符合的数据则引发异常
        /// </summary>
        /// <exception cref="System.InvalidOperationException">读取尚未结束</exception>
        /// <returns></returns>
        public byte[] GetReadCode()
        {
            if (LengthByte == 0)//读取不到时修改
                return null;//读取不到时修改
            if (FillIndex < LengthByte)
            {
                throw new InvalidOperationException("读取尚未结束");
            }
            PacketBuffer[0] = HeadFilter;
            PacketBuffer[1] = LengthByte;
            for (int i = 0; i < CommondFilter.Length; i++)
            {
                PacketBuffer[2+i] = CommondFilter[i];
            }
            return PacketBuffer;
        }
        byte[] TempBuffer;
        int FillIndex;
        byte[] PacketBuffer;
        byte LengthByte;
        readonly byte HeadFilter;
        byte[] CommondFilter;
    }
    /// <summary>
    /// 用于Bootloader的报文筛选器
    /// </summary>
    public class BootloaderReadFilter : SerialPortsUtils.Agents.IReadFilterReuses
    {
        //private byte[] bytes = System.Text.Encoding.ASCII.GetBytes("A8 Bootloader");//NP5.0 Bootloader
        private byte[] bytes = System.Text.Encoding.ASCII.GetBytes("NP5.0 Bootloader");
        public BootloaderReadFilter(int timeout)
        {
            Timeout = timeout;
        }
        public BootloaderReadFilter() { }
        #region IReadFilter 成员
        public int? Timeout{get;private set;}
        public bool Filter(byte[] raw)
        {
            String x= System.Text.Encoding.ASCII.GetString(raw);
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == bytes[matchIndex])
                    matchIndex++;
                else if (matchIndex > 0)
                    matchIndex = 0;
                if (matchIndex == bytes.Length - 1)
                {
                    if (isTwo) return false;
                    else
                    {
                        isTwo = true;
                        matchIndex = 0;
                    }
                }
            }
            return true;
        }

        public byte[] GetReadCode()
        {
            if (matchIndex != bytes.Length - 1) throw new InvalidOperationException("读取尚未结束");
            return bytes;
        }
        #endregion
        private bool isTwo=false;
        private int matchIndex=0;
    }
}
