using SerialPortsUtils.Agents.Models;
using SerialPortsUtils.Utils.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerialPortsUtils.Agents
{
    /// <summary>
    /// 串口IO代理
    /// </summary>
    public class Agent : IDisposable, IAgent, ISerialPortWarper
    {
        public virtual byte[] SendAndRead(byte[] packet, IReadFilter filter)
        {
            if (Port.BytesToRead > 0)
            {
                byte[] buffer = new byte[Port.BytesToRead];
                Port.Read(buffer, 0, buffer.Length);
            }
            Send(packet);
            if (packet[2] == 0xF9)
                return Read(filter, 50, packet[2]);
            else
                return Read(filter, packet[2]);
        }
        public virtual byte[] Read(IReadFilter filter, int readTimeOut, byte cmd)
        {
            long timeFlag = stopwatch.ElapsedMilliseconds;
            do
            {
                if (Port.BytesToRead > 0)
                {
                    System.Threading.Thread.Sleep(35);//V2.8修改
                    byte[] readBytes = new byte[Port.BytesToRead];
                    Port.Read(readBytes, 0, readBytes.Length);
                    if (!filter.Filter(readBytes))
                        break;
                }
                if (readTimeOut > 0 && stopwatch.ElapsedMilliseconds - timeFlag > readTimeOut)
               //     break;//读取不到时修改
                {
                    if (cmd == 0x39 || cmd == 0xA9 || cmd == 0x90)
                        break;
                    throw new TimeoutException("读取超时");
                }
            } while (true);
            var packet = filter.GetReadCode();
            System.Diagnostics.Debug.Write("Read: ");
            DEBUG_WirtePacket(packet);
            System.Diagnostics.Debug.WriteLine("");
            return packet;
        }
        public virtual byte[] Read(IReadFilter filter,byte cmd)
        {
            if (filter.Timeout.HasValue)
                return Read(filter, filter.Timeout.Value,cmd);
            else
                return Read(filter, Port.ReadTimeout, cmd);
        }
        public virtual void Send(byte[] packet)
        {
            System.Diagnostics.Debug.Write("Send: ");
            DEBUG_WirtePacket(packet);
            System.Diagnostics.Debug.WriteLine("");
            Port.Write(packet, 0, packet.Length);
            //Port.BaseStream.Flush();
            //System.Threading.Thread.Sleep(500);
        }



        #region Ctor
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="sp">要代理的串口</param>
        public Agent(System.IO.Ports.SerialPort sp)
        {
            Port = sp;
            stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
        }
        #endregion

        #region Dispose
        /// <summary>
        /// 释放资源
        /// </summary>
        public virtual void Dispose()
        {
            if (Port != null)
                Port.Dispose();
            stopwatch.Stop();
        }
        #endregion

        protected System.Diagnostics.Stopwatch stopwatch { get; set; }
        protected System.IO.Ports.SerialPort Port { get; set; }

        #region IAgent 成员

        #region Port
        public void ChangePort(string portName)
        {
            if (Port.IsOpen) Port.Close();
            Port.PortName = portName;
            Port.Open();
        }

        public void ClosePort()
        {
            if (Port.IsOpen)
                Port.Close();
        }
        public void OpenPort()
        {
            if (!Port.IsOpen)
                Port.Open();
        }
        public bool PortIsOpen
        {
            get { return PortIsOpen; }
        }
        public string PortName { get { return Port.PortName; } }
        #endregion

        #endregion

        #region Debug
        [System.Diagnostics.Conditional("DEBUG")]
        void DEBUG_WirtePacket(byte[] packet)
        {
            if (packet == null)//读取不到时修改
                return;//读取不到时修改
            foreach (var item in packet)
            {
                System.Diagnostics.Debug.Write(item.ToString("X2") + " ");
            }
        }
        #endregion

        #region ISerialPortWarper 成员

        System.IO.Ports.SerialPort ISerialPortWarper.GetSerialPort()
        {
            return this.Port;
        }

        #endregion
    }
}
