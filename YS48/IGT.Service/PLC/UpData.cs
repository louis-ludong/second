using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace IGT.Service.PLC
{
    /// <summary>
    /// 下位机升级数据
    /// </summary>
    public class UpData
    {
        /// <summary>
        /// 从文件获取升级数据
        /// </summary>
        /// <param name="file">文件</param>
        /// <param name="data">获取到的升级数据</param>
        /// <returns>是否获取到了升级数据</returns>
        public static bool FromFile(String file, out UpData data)
        {
            data = new UpData(file);
            return data.Right;
        }
        private UpData(string file)
        {
            this.Right = false;
            var f = new System.IO.FileInfo(file);
            if (f.Length > 8 + 3)
            {
                List<byte[]> data = new List<byte[]>();
                using (System.IO.BinaryReader io = new System.IO.BinaryReader(f.Open(System.IO.FileMode.Open)))
                {
                    var verBytes = io.ReadBytes(6);
              //      this.ROMVer = System.Text.Encoding.ASCII.GetString(verBytes);//LDC sc
                    this.ROMVer = verBytes[4].ToString() + "." + verBytes[5].ToString();//LDC增加
                  //  int a = 0;
                    do
                    {
                        var temp = io.ReadBytes(1);
                        char id = System.Text.Encoding.ASCII.GetChars(temp)[0];
                        if (id == 'X')
                        {
                            byte type = io.ReadByte();
                            byte lenght = io.ReadByte();
                            byte[] Rdbuf = new byte[lenght * 2 - 1];//Rdbuf
                            byte[] buf = new byte[lenght+2];
                            buf[0] = type;//1
                            buf[1] = lenght;//234
                            io.Read(Rdbuf, 2, lenght * 2 - 3);//lenght * 2 - 2 - a
                            //if (a == 0)
                            //{
                            //    a = 1;
                            //    continue;
                            //}
                            buf[2] = Rdbuf[2];//3
                            buf[3] = Rdbuf[3];//4
                            buf[4] = Rdbuf[4];//5
                            lenght = (byte)(lenght - 4);
                            ushort div = 0;
                            ushort tmp16;
                            int j=0;
                            int i = 0;
                            for ( ; i < lenght*2;)//
                            {
                                tmp16 = (ushort)(Rdbuf[5 + i++] << 8);
                                tmp16 += Rdbuf[5 + i++]; ;
                                if (div==0x00)
                                    div = (ushort)Math.Sqrt((double)tmp16);
                                else
                                    div = (ushort)(tmp16 / div);
                                buf[5 + j++] =(byte) div;
                            }
                            tmp16 = (ushort)(Rdbuf[5 + i++] << 8);//最后一个是检验
                            tmp16 += Rdbuf[5 + i++];
                            buf[5 + j++] = (byte)Math.Sqrt((double)tmp16);
                            data.Add(buf);
                        }
                        else 
                        if (id == 'E')
                        {
                            if (io.ReadChar() == 'N' && io.ReadChar() == 'D')
                            {
                                this.Right = true;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
                if(this.Right)//升级数据加工
                {
                    this.Data = data.Select(m =>
                         "S"+ System.Text.Encoding.ASCII.GetString(m,0,1)
                         +String.Join(String.Empty,m.Skip(1).Select(bin=>bin.ToString("X2")).ToArray())
                        ).ToArray();
                }
            }            
        }
        /// <summary>
        /// 升级数据是否正确
        /// </summary>
        public bool Right { get; private set; }
        /// <summary>
        /// 数据
        /// </summary>
        public string[] Data { get;private set; }
        /// <summary>
        /// ROM版本
        /// </summary>
        public string ROMVer { get; private set; }
    }
}
