using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace IGT.Service.PLC
{
    /// <summary>
    /// 报文工具类
    /// </summary>
    public static class PacketUtils
    {
        /// <summary>
        /// 获取报文正文
        /// </summary>
        /// <param name="packet">报文</param>
        /// <param name="cmdLenght">命令长度</param>
        /// <returns></returns>
        public static IEnumerable<byte> PacketData(this IEnumerable<byte> packet, int cmdLenght)
        {
            return packet.Take(packet.Count() - 1).Skip(2 + cmdLenght);
        }

        /// <summary>
        /// 构造发送到下位机的报文
        /// </summary>
        /// <param name="cmd">命令</param>
        /// <param name="data">正文</param>
        /// <returns>报文</returns>
        public static byte[] BuildSend(byte cmd,byte[] data=null)
        {
            return BuildRaw(InstructionSet.SendHead,cmd, data);
        }

        /// <summary>
        /// 构造发送到下位机的报文
        /// </summary>
        /// <param name="cmdPart1">命令</param>
        /// <param name="cmdPart2">子命令</param>
        /// <param name="data">正文</param>
        /// <returns>报文</returns>
        public static byte[] BuildSend(byte cmdPart1,byte cmdPart2,byte[] data=null)
        {
            return BuildRaw(InstructionSet.SendHead, cmdPart1, cmdPart2, data);
        }
       
        /// <summary>
        /// 构造报文
        /// </summary>
        /// <param name="head">报文头</param>
        /// <param name="cmd">命令</param>
        /// <param name="data">正文</param>
        /// <returns>报文</returns>
        internal static byte[] BuildRaw(byte head, byte cmd, byte[] data = null)
        {
            byte[] packet;
            if (data == null) packet = new byte[1 + 1 + 1 + 1];//头部+长度+命令+校验
            else packet = new byte[1 + 1 + 1 + data.Length + 1];
            packet[0] = head;
            packet[1] =(byte) packet.Length;
            packet[2] = cmd;
            int fill = 2;
            if (data != null)
                foreach (var item in data)
                {
                    packet[++fill] = item;
                }
            packet[++fill] = CalcCheckBitNew(packet);
            return packet;
        }

        /// <summary>
        /// 构造报文
        /// </summary>
        /// <param name="head">报文头</param>
        /// <param name="cmdPart1">命令</param>
        /// <param name="cmdPart2">子命令</param>
        /// <param name="data">正文</param>
        /// <returns>报文</returns>
        internal static byte[] BuildRaw(byte head, byte cmdPart1, byte cmdPart2, byte[] data = null)
        {
            byte[] packet;
            if (data == null) packet = new byte[1 + 1 + 2 + 1];
            else packet = new byte[1 + 1 + 2 + data.Length + 1];
            packet[0] = head;
            packet[1] = (byte)packet.Length;
            packet[2] = cmdPart1;
            packet[3] = cmdPart2;
            int fill = 3;
            if (data != null)
                foreach (var item in data)
                {
                    packet[++fill] = item;
                }
            packet[++fill] = CalcCheckBitNew(packet);
            return packet;
        }


        /// <summary>
        /// 为新构造的报文计算校验位
        /// </summary>
        /// <param name="packet"></param>
        /// <returns></returns>
        internal static byte CalcCheckBitNew(byte[] packet)
        {
            int sum=packet.Sum(m=>m)-packet[packet.Length-1];
            byte result;
            unchecked
            {
                result = (byte)(0 - sum);
            }
            return result;
        }

        /// <summary>
        /// 验证一个下位机发送的报文
        /// </summary>
        /// <param name="packet"></param>
        /// <returns></returns>
        internal static bool ValidateAsRecived(byte[] packet)
        {
            if (packet[0] == InstructionSet.RecivedHead
                && packet[1] == packet.Length
                && packet.Last() == CalcCheckBitNew(packet))
                return true;
            else return false;
        }
    }
}
