using IGT.Service.PLC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace IGT.Service
{
    /// <summary>
    /// IO工具类
    /// </summary>
    static class IOUtils
    {
        /// <summary>
        /// 发送并读取报文
        /// </summary>
        /// <param name="agent">通信代理</param>
        /// <param name="cmd1">命令</param>
        /// <param name="cmd2">子命令</param>
        /// <param name="data">正文</param>
        /// <returns>响应的报文</returns>
        internal static byte[] SendAndRead(this SerialPortsUtils.Agents.Agent agent, byte cmd1,byte cmd2, byte[] data = null)
        {
            var packet = PacketUtils.BuildSend(cmd1,cmd2, data);
            var reader = new ReadFilter(cmd1,cmd2);
            return agent.SendAndRead(packet, reader);
        }
        /// <summary>
        /// 发送并读取报文
        /// </summary>
        /// <param name="agent">通信代理</param>
        /// <param name="cmd">命令</param>
        /// <param name="data">正文</param>
        /// <returns>响应的报文</returns>
        internal static byte[] SendAndRead(this SerialPortsUtils.Agents.Agent agent,byte cmd,byte[] data=null)
        {
            var packet=PacketUtils.BuildSend(cmd,data);
            var reader = new ReadFilter(cmd);
            return agent.SendAndRead(packet, reader);
        }
        
        #region Get
        /// <summary>
        /// 从下位机获取ECU设定
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        internal static Models.Settings.ECUSetting GetSettingFormPLC(this SerialPortsUtils.Agents.Agent io)
        {
            var r1 = io.SendAndRead(InstructionSet.GetECUSetting);
            var r2 = io.SendAndRead(InstructionSet.GetECUSettingExtra);
            var r3 = io.SendAndRead(InstructionSet.GetO2Setting);//LDC增加
            byte[] r4 = null;
            if (SSer.Device.DeviceInfo.HardInof.OBDEn)
                r4 = io.SendAndRead(InstructionSet.GetOBDSetting);//LDC增加 OBD增加

            var r5 = io.SendAndRead(InstructionSet.GetAnticipateInjSetting);//LDC增加
            var model = DTOUitils.TOECUSetting(r1, r2, r3, r4, r5);
            return model;
        }
        /// <summary>
        /// 从下位机获取MAP标定参数
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        internal static Models.Settings.MAPCalibrationParams GetMAPCalibrationParams(this SerialPortsUtils.Agents.Agent io)
        {
            var data = io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, InstructionSet.MAPCalibrationParamsPart2_12RPMs).PacketData(2);
            var data2 = io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, InstructionSet.MAPCalibrationParamsPart2_12Tinj).PacketData(2);
            var mapValues = InstructionSet.MAPCalibrationParamsPart2_MAPValue
                .Select(m => io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, m).PacketData(2)
                    .Select(m2 =>
                    {
                        unchecked
                        {
                            //return (sbyte)m2;//LDC MAP修改 
                            return (int)m2;////LDC MAP修改<Sbyte>改为<byte>
                        }
                    }).ToArray()).ToArray();
            //var petrolCurve = InstructionSet.MAPCalibrationParamsPart2_PetrolCurve.Select(m =>//LDC删除
            //    io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, m).PacketData(2)
            //    .Select(m2 => ValueConvert.MapTableInjectionFrom(m2)).ToArray()).ToArray();
            //var gasCurve = InstructionSet.MAPCalibrationParamsPart2_GasCurve.Select(m =>
            //    io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, m).PacketData(2)
            //    .Select(m2 => ValueConvert.MapTableInjectionFrom(m2)).ToArray()).ToArray();
            //var packet3 = io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, InstructionSet.MAPCalibrationParamsPart2_DataLockStatus).PacketData(2).ToArray();
            var model = new Models.Settings.MAPCalibrationParams();
            byte[] temp = data.ToArray();
            //model.RPMs = data.Select(m => ValueConvert.MapTableRPMFrom(m)).ToArray();
            model.RPMs = ValueConvert.MapTableRPMFrom(temp);
            temp = data2.ToArray();
            model.Injection = ValueConvert.MapTableInjectionFrom(temp);
            //model.Injection = data2.Select(m => ValueConvert.MapTableInjectionFrom(m)).ToArray();//LDC删除
            model.MAPValues = mapValues;
            //model.PetrolCurve = petrolCurve;
            //model.GasCurve = gasCurve;
            //model.DataLockStatus = new bool[InstructionSet.MAPCalibrationParamsPart2_MAPValue.Length][];
            //for (int i = 0; i < model.DataLockStatus.Length; i++)
            //{
            //    model.DataLockStatus[i] = ValueConvert.DataLockStatusFrom(packet3[i * 3], packet3[i * 3 + 1], packet3[i * 3 + 2]);
            //}
            //var tt = io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, InstructionSet.MAPCalibrationParamsPart2_2DGasCurve);
            //model.GasCurve2D = tt.PacketData(2)
            //    .Select(m => m * 0.1f).ToArray();
            //model.PetrolCurve2D = io.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, InstructionSet.MAPCalibrationParamsPart2_2DPetrolCurve).PacketData(2)
            //    .Select(m => m * 0.1f).ToArray();

            return model;
        }
        /// <summary>
        /// 从下位机获取ECU修正比例
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        internal static Models.Settings.ECUCorrectionParams GetECUCorrectionParams(this SerialPortsUtils.Agents.Agent io)
        {
            var data1 = InstructionSet.ECUCorrectionSettingPart2_CorrectionValue
                .Select(m => io.SendAndRead(InstructionSet.ECUCorrectionSettingPart1, m).PacketData(2).ToArray()).ToArray();
            var packet2 = io.SendAndRead(InstructionSet.ECUCorrectionSettingPart1, InstructionSet.ECUCorrectionSettingPart2_Ponits);
            var model = new Models.Settings.ECUCorrectionParams();
            model.CalibrationScale = new int[data1.Sum(m => m.Length)];
            int index = 0;
            for (int i = 0; i < data1.Length; i++)
            {
                for (int j = 0; j < data1[i].Length; j++)
                {
                    model.CalibrationScale[index] = data1[i][j];
                    index++;
                }
            }
            model.LocationX = packet2.PacketData(2).Select(m => Convert.ToSingle(m / 10)).ToArray();
            return model;
        }

        /// <summary>
        /// 从下位机获取喷轨修正参数
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        internal static Models.Settings.InjectorCorrectionSetting GetInjectorCorrectionSetting(this SerialPortsUtils.Agents.Agent io)
        {
            var packet = io.SendAndRead(InstructionSet.InjectorCorrectionSetting);
            return packet.ToInjectorCorrectionSetting();
        }

        /// <summary>
        /// 从下位机燃气温度修正
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        internal static Models.Settings.TempCorrectionSet GetGasTempCorrectionSettings(this SerialPortsUtils.Agents.Agent io)
        {
            var data = io.SendAndRead(InstructionSet.GasTempCorrectionSettings).PacketData(1).ToArray();
            Models.Settings.TempCorrectionSet model = new Models.Settings.TempCorrectionSet();
            model.Items = new sbyte[8];
            model.Corrections = new int[9];
            for (int i = 0; i < 8; i++)
            {
                model.Items[i] = ValueConvert.SingleTempFrom(data[i]);
                model.Corrections[i] = ValueConvert.TempCorrectionFrom(data[i+8])-100;
            }
            model.Corrections[8] = data[16]-100;
            return model;
        }

        /// <summary>
        /// 从下位机获取减压器温度修正
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        internal static Models.Settings.TempCorrectionSet GetRedTempCorrectionSettings(this SerialPortsUtils.Agents.Agent io)
        {
            var data = io.SendAndRead(InstructionSet.RedTempCorrectionSettings).PacketData(1).ToArray();
            Models.Settings.TempCorrectionSet model = new Models.Settings.TempCorrectionSet();
            model.Items = new sbyte[8];
            model.Corrections = new int[9];
            for (int i = 0; i < 8; i++)
            {
                model.Items[i] = ValueConvert.SingleTempFrom(data[i]);
                model.Corrections[i] = ValueConvert.TempCorrectionFrom(data[i + 8])-100;
            }
            model.Corrections[8] = data[16]-100;
            return model;
        }
        /// <summary>
        /// 从下位机获取燃气压力修正
        /// </summary>
        /// <param name="io"></param>
        /// <returns></returns>
        internal static Models.Settings.PressCorrectionSet GetGasPressCorrectionSettings(this SerialPortsUtils.Agents.Agent io)
        {
            var data1 = io.SendAndRead(InstructionSet.GasPressCorrectionSettings, InstructionSet.GasPressCorrectionValue).PacketData(2).ToArray();
            var data2 = io.SendAndRead(InstructionSet.GasPressCorrectionSettings, InstructionSet.GasPressCorrectionPer).PacketData(2).ToArray();
            Models.Settings.PressCorrectionSet model = new Models.Settings.PressCorrectionSet();
            model.Items = new float[15];
            model.Corrections = new float[15];
            int a=0,b=1;
            for (int i = 0; i < 15; i++)
            {
                model.Items[i] = ValueConvert.CorrectionPressFrom(data1[a], data1[b]);
                model.Corrections[i] = ValueConvert.PressCorrectionFrom(data2[a], data2[b]);
                a = a + 2;
                b = b + 2;               
            }
            return model;
        }
        #endregion

        #region Send
        /// <summary>
        /// 设定下位机燃气温度修正百分比
        /// </summary>
        /// <param name="io"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public static void SetGasTempCorrection_Correction(this SerialPortsUtils.Agents.Agent io,int index, int value)
        {
            io.SendAndRead(InstructionSet.SetGasTempCorrectionPart1, InstructionSet.SetGasTempCorrectionPart2_Correction[index]
                , new byte[] { ValueConvert.TempCorrectionValue(value) });
        }

        /// <summary>
        /// 设置ECU修正比例的坐标点
        /// </summary>
        /// <param name="value"></param>
        public static void SetECUCorrectionParams_LocationX(this SerialPortsUtils.Agents.Agent io, float[] value)
        {
            io.SendAndRead(InstructionSet.SetECUCorrectionParamsPart1, InstructionSet.SetECUCorrectionParamsPart2_Points
                , value.Select(m => Convert.ToByte(m * 10)).ToArray());
        }

        /// <summary>
        /// 设置ECU修正比例的比例
        /// </summary>
        /// <param name="value"></param>
        public static void SetECUCorrectionParams_CalibrationScale(this SerialPortsUtils.Agents.Agent io, int[] value)
        {
            for (int i = 0; i < InstructionSet.SetECUCorrectionParamsPart2_Correction.Length; i++)
            {
                io.SendAndRead(InstructionSet.SetECUCorrectionParamsPart1
                    , InstructionSet.SetECUCorrectionParamsPart2_Correction[i]
                    , value.Skip(i * 32).Take(32).Select(m => (byte)m).ToArray());
            }
        }

        #endregion
    }
}
