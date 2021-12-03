using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace IGT.Service.PLC
{
    /// <summary>
    /// DTO工具类
    /// </summary>
    public static class DTOUitils
    {
        /// <summary>
        /// 从报文提取 自适应状态
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>自适应状态</returns>
        public static Models.Feedback.AdaptiveState ToAdaptiveState(byte[] packet)
        {
            var data=packet.PacketData(1).ToArray();
            var model = new Models.Feedback.AdaptiveState();
            model.ShortCorrection = ValueConvert.ConvetToSbyteSafe(data[0]);
            model.Offset = ValueConvert.ConvetToSbyteSafe(data[1]);
            return model;
        }
        /// <summary>
        /// 从报文提取 OBD状态 
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>OBD状态</returns>
        public static Models.Feedback.OBDState ToODBState(byte[] packet)
        {
            //var data = packet.PacketData(1).ToArray();
            //var model = new Models.Feedback.OBDState();
            //model.ConnectState = ValueConvert.ODBConnectSateFrom(data[0]);
            //model.FailuresCount = data[1];
            //model.Bank1ShortCorrection = ValueConvert.ConvetToSbyteSafe(data[2]);
            //model.Bank1LongCorrection = ValueConvert.ConvetToSbyteSafe(data[3]);
            //model.Bank2ShortCorrection = ValueConvert.ConvetToSbyteSafe(data[4]);
            //model.Bank2LongCorrection = ValueConvert.ConvetToSbyteSafe(data[5]);
            //return model;
            var data = packet.PacketData(1).ToArray();
            var model = new Models.Feedback.OBDState();
            model.ConnectState = ValueConvert.ODBConnectSateFrom(data[0]);
            model.FailuresCount = data[2];
            model.Bank1ShortCorrection = (float)Math.Round(((float)data[6] - 128) / 1.28f, 1);
            model.Bank1LongCorrection = (float)Math.Round(((float)data[7] - 128) / 1.28f, 1);
            model.Bank2ShortCorrection = (float)Math.Round(((float)data[8] - 128) / 1.28f, 1);
            model.Bank2LongCorrection = (float)Math.Round(((float)data[9] - 128) / 1.28f, 1);
            model.Bank1Oxygen = (float)Math.Round((float)data[10] * 0.005f, 2);
            if (data.Count() >= 13)
                model.GasCorrection = (SByte)data[12];
            return model;


        }

        /// <summary>
        /// 从报文提取 ECU设定参数
        /// </summary>
        /// <param name="packet">报文</param>
        /// <param name="extraPacket">额外的报文</param>
        /// <returns>ECU设定参数</returns>
        public static Models.Settings.ECUSetting TOECUSetting(byte[] packet, byte[] extraPacket, byte[] O2Packet, byte[] OBDPacket = null, byte[] AnticipateInjPacket=null)//LDC提取接收到的设置参数
        {
            System.Diagnostics.Debug.WriteLine("Begin Packet To Model ECUSetting");
            packet = packet.PacketData(1).ToArray();
            extraPacket = extraPacket.PacketData(1).ToArray();
            O2Packet = O2Packet.PacketData(1).ToArray();
            if (OBDPacket != null)
                OBDPacket = OBDPacket.PacketData(1).ToArray();
            if (AnticipateInjPacket!=null)
                AnticipateInjPacket = AnticipateInjPacket.PacketData(1).ToArray();
            var model = new Models.Settings.ECUSetting();
          //  model.GasLevel[0] = 2;
            //model.BaseData[0] = packet[0];
            //model.BaseData[1] = packet[1];
            //model.BaseData[2] = packet[2];
            //model.BaseData[3] = packet[3];
            model.BaseData = new int[] { packet[0], packet[1], packet[2], packet[3] };
            model.FuelType = ValueConvert.FuelTypeFrom(packet[0]);//LDCYG  1 字节 bit1：燃料类型, 0-LPG, 1-CNG；
            model.O2Numbers = ValueConvert.O2NumbersFrom(packet[0]);   //O2Numbers //1 字节 bit2：氧传感器 Number of bank, 0-2 个, 1-1 个；
            //1 字节 bit4：MAP 传感器类型, 1-IGT013；
           //1 字节 bit5：转换时没有油气混和过度, 0-禁止, 1-允许；
            model.InjectionMode = ValueConvert.InjectionModeFrom(packet[0], packet[3]);//LDCYG  1 字节 bit6：喷射方式, 0-Sequential, 1-Full group；
           // 1 字节 bit7：燃气电磁阀提前打开, 0-取消, 1-选中；
            //是否为单燃料2 字节 bit0  //需修改2 字节 bit0：转换方式, 0-other, 1-Monofuel（单燃料）；
            model.ExtraInjectionSensitivityEnable = (packet[1] & 2) != 2; //2 字节 bit1：额外喷射灵敏度, 0-选中, 1-取消；
           // 2 字节 bit3：Switch from PC, 0-disable, 1-enable；
            //2 字节 bit4：Switch, 0-off, 1-on；
           // 2 字节 bit5：MAP 传感器类型, 1-IGT025；
            model.AutoDiagnosis = (packet[2]&0x08) == 0x08; //3 字节 bit3：启用诊断, 0-取消, 1-选中；
            // 3 字节 bit6：加速密集喷射处理, 0-禁止, 1-允许； 
            model.RunningGasStrategy = ValueConvert.GasStrategiesFrom(packet[2], extraPacket[15], extraPacket[16]);//处理异常 //3 字节 bit7：高速运行, 0-燃气/燃油, 1-燃油增加； 0燃气（转速8500）  1-燃油增加   0燃油
            model.MinOilEn = (packet[3] & 1) == 1; //4 字节 bit0：最小运行, 0-转回燃油, 1-燃油 ； 0燃气 0转回燃油（有转速）   1燃油（有转速）
            //4 字节 bit4：燃料顺序转换, 0-选中, 1-取消； 
            //4 字节 bit6：喷射方式, 0-Sequential, 1-MJ-Sequential； 
            //4 字节 bit7：OBD 适应性, 0-取消, 1-选中； 
            model.AutoAdaptive = (packet[3] & 0x80) == 0x80; //4 字节 bit7：OBD 适应性, 0-取消, 1-选中； 
            model.Cylinders = ValueConvert.CylindersFrom(packet[4]);//LDC  5 字节：发动机参数-缸数；三缸：0x07，四缸：0x0F；
            //model.Coils = ValueConvert.CoilNumsFrom(packet[5]);//LDC转速信号类型 增加 & 0x40
            model.RevolutionSignalType = ValueConvert.RevolutionSignalTypeFrom(packet[5]);//LDC转速信号类型 增加 & 0x40
            model.RPMInjectionSelect = ValueConvert.RPMInjectionSelectFrom(packet[5]);//LDC RPMInjectionSelect增加
            model.RPMSource = ValueConvert.RPMSourceFrom(packet[5]);// 6 字节：Bit6:0-Standard，1-Weak；Bit7:0-传感器，1-喷油嘴
            model.SwitchRPM = ValueConvert.SwitchRPMFrom(packet[6], packet[7]); //7、8 字节：切换转速；单位 rpm；已改
            model.SwitchMode = ValueConvert.SwitchModeFrom(packet[6], packet[7]);//切换方式 转速的最后一位
            model.SwitchTemp = ValueConvert.SingleTempFrom(packet[8]);//9 字节：切换温度；范围：0~80，单位℃
            model.OverlapTimes = ValueConvert.OverlapTimesFrom(packet[9]);//10 字节：切换延时时间；单位 s；//LDC已改
            //11 字节：重叠时间；单位 20ms；
            model.OrderDelay = ValueConvert.OrderDelayFrom(packet[11]);//12 字节：顺序切换延时；真接数字不用转换
            model.ReducerTempSens = ValueConvert.TempSensFrom(packet[12]); // 13 字节：减压器温度传感器类型；10Kohm：0x04，4K7ohm：0x00，2Kohm：0x02； 
            model.GasTempSens = ValueConvert.TempSensFrom(packet[13]);//14 字节：燃气温度传感器类型；10Kohm：0x05，4K7ohm：0x00，2Kohm：0x02； 
            model.OperationalPress = ValueConvert.OperationalPressFrom(packet[14], packet[15]);  //15、16 字节：燃气工作压力；单位 0.001bar//需修改         
            model.MinimumPress = ValueConvert.MinimumPressFrom(packet[16], packet[17]);//17、18 字节：最小燃气压力；单位 0.001bar//需修改
            model.PressErrorTime = ValueConvert.PressErrorTimeFrom(packet[18]); // 19 字节：压力故障时间；单位 20ms；//同A8
            model.MiniGasTemp = ValueConvert.SingleTempFrom(packet[19]);//20 字节：燃气最低温度；范围：-20~15，单位℃；//同A8
            model.InjectorType = ValueConvert.InjectorTypeFrom(packet[20]);//LDCYG 21 字节：燃气喷轨类型；0x00：Matrix，0x12：3ohm，0x52：1ohm； 0x16:IGT
            model.LevelIndicatorSens = ValueConvert.LevelIndicatorSensFrom(packet[21]);// 22 字节：液位传感器类型；//还需修改
            model.GasLevel = ValueConvert.GasLevelSetFrom(packet[22], packet[23]//液位传感器电压档   LDCYG
                , packet[24], packet[25]);
            if (packet.Count() >= 27)
                model.BackTransitionTm = packet[26];
            else
                model.BackTransitionTm = 0xf000;
            //model.MinGasRPM = ValueConvert.MinGasRPMFrom(packet[20]);
          //  model.RPMVoltage = ValueConvert.RPMVoltageFrom(packet[9]);
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            model.ExtraData = new int[] { extraPacket[0], extraPacket[1], extraPacket[2], extraPacket[3], extraPacket[4] };
            if (AnticipateInjPacket != null)
                model.AnticipateInjSetting = new int[] { AnticipateInjPacket[0], AnticipateInjPacket[1], AnticipateInjPacket[2], AnticipateInjPacket[3] };
            else
                model.AnticipateInjSetting = new int[] { 0xf0, 0xf0, 0xf0, 0xf0 };
            //model.MinGasRPM = ValueConvert.MinGasRPMFrom(packet[20]);      
            //model.ExtraInjectionCutting = (packet[4] & 1) == 1; 
            model.HotStart = ValueConvert.HotStartFrom(extraPacket[0]);
            model.Valvetronik = ValueConvert.ValvetronikFrom(extraPacket[0]);

            model.CompleteResetOfErrors = (extraPacket[0] & 0x10) == 0x10;//OBD
            model.SelectiveResetOfErrors = (extraPacket[0] & 0x80) == 0x80;//OBD

            model.StartAndStop = ValueConvert.StartAndStopForm(extraPacket[1]);
            model.InjetPositiveDrive = ((extraPacket[4] & 0x01) == 0x01);
            model.ExtraInjectionCutting = (extraPacket[0] & 1) == 1; //  1 字节 bit0：额外喷射断开, 0-取消, 1-选中；
            model.InjectorPositiveDriver = extraPacket[0] == 0x01;
         //   model.EngineType = ValueConvert.EngineTypeFrom(extraPacket[1]);    
            model.Weak = extraPacket[7];
            model.SpeedThicken = extraPacket[8];
            //////////model.RunningTijiTime = extraPacket[7] * 0.1f;
            //////////model.RunningOilCompensation = extraPacket[8] * 0.1f;
            //////////model.Lambda1Type = ValueConvert.LambdaTypeFrom(extraPacket[9]);//O2Packet
            model.ExtrainjSensitivity = ValueConvert.ExtrainjSensitivityFrom(extraPacket[9], extraPacket[10]);//额外喷射灵敏度
            model.ExtraInjectionIdentTime = ValueConvert.ExtraInjectionIdentTimeFrom(extraPacket[11], extraPacket[12]);//额外喷射起始时间
            model.MinGasRPM = ValueConvert.MinGasRPMFrom(extraPacket[13], extraPacket[14]);//最低转速  气的时候为00
            model.RunningMinRPM = ValueConvert.RunningRPMFrom(extraPacket[15], extraPacket[16]);//最高转速(低)
            model.RunningMaxRPM = ValueConvert.RunningRPMFrom(extraPacket[17], extraPacket[18]);//最高转速(高)
            model.RunningTijiTime = ValueConvert.RunningTimeFrom(extraPacket[19], extraPacket[20]);
            model.RunningOilCompensation = ValueConvert.RunningTimeFrom(extraPacket[21], extraPacket[22]);

            //if (extraPacket.Length > 25)
            //{
            //    model.HighGasTempLowRPM = (sbyte)extraPacket[25];
            //    model.HighGasTempHighRPM = (sbyte)extraPacket[26];
            //}
            if (extraPacket.Length > 27)
            {
                model.GasFillTime = extraPacket[27];
            }
            //model.Lambda1HV = ValueConvert.SingleVoltageFrom(extraPacket[11]);
            //model.Lambda1LV = ValueConvert.SingleVoltageFrom(extraPacket[12]);
            //model.Lambda2HV = ValueConvert.SingleVoltageFrom(extraPacket[13]);
            //model.Lambda2LV = ValueConvert.SingleVoltageFrom(extraPacket[14]);
            //model.LambdaDelay = extraPacket[15];
            //model.LambdaInjectNum = extraPacket[16];
 
            //model.AutoAdaptive = extraPacket[18] == 0x01;
            //model.AdaptiveRange = extraPacket[19];
            //model.AutoStopAdaptive = extraPacket[20] == 0x01;
            //model.AdaptiveAssist = extraPacket[21] == 0x01;
            //model.ODBReverseAssist = extraPacket[22] == 0x01;
            //model.ODBAdaptRange = extraPacket[23];
            //model.ODBBank1Correct =ValueConvert.ConvetToSbyteSafe(extraPacket[24]);
            //model.ODBBank2Correct = ValueConvert.ConvetToSbyteSafe(extraPacket[25]);
            //model.ODBErrorAutoClear = ValueConvert.ODBErrorAutoClearFrom(extraPacket[26]);
            model.O2Type = ValueConvert.O2TypeFrom(O2Packet[0]);
            model.Lambda1Type = ValueConvert.LambdaTypeFrom(O2Packet[1]);//O2Packet
            model.Lambda2Type = ValueConvert.LambdaTypeFrom(O2Packet[2]);

            if (OBDPacket != null)
            {
                model.OBDStandard = ValueConvert.OBDStandardFrom(OBDPacket[0]);
                model.Reserve = OBDPacket[1];
                model.OBDType = ValueConvert.OBDTypeFrom(OBDPacket[2]);
                if (OBDPacket.Length > 3)
                    model.OBDAdaptiveRange = OBDPacket[3];
            }


            System.Diagnostics.Debug.WriteLine("End Packet To Model ECUSetting");
            return model;
        }
        /// <summary>
        /// 从报文提取 握手结果
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>握手结果</returns>
        public static bool ToHandSharkResult(this byte[] packet)
        {
            return packet[3] == 0x01;
        }
        /// <summary>
        /// 获取序列号
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>获取序列号</returns>
        public static String ToSerialNumberResult(this byte[] packet)
        {

         //   return packet[3].ToString();
            string s="";
            for(int i=0;i<8;i++)
            {
                if (5 + i > packet.Count())
                    break;
                s += String.Format("{0:X2}", packet[3 + i]);
            }
            return s;
        }
        /// <summary>
        /// 从报文提取 是否设置了密码
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>是否设置了密码</returns>
        public static bool ToPasswordNeed(this byte[] packet)
        {
            return packet[3] == 0x01;
        }
        /// <summary>
        /// 从报文提取 硬件信息
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>硬件信息</returns>
        public static Models.Feedback.HardwareInfo ToHardwareInfo(this byte[] packet)
        {
            var model = new Models.Feedback.HardwareInfo();
        //    model.HarwareID = ((Char)packet[3]).ToString();
            //      model.ECUVer = String.Format("{0}.{1}", packet[3], packet[4]);
            model.PCBVer = String.Format("{0}.{1}", packet[4] >> 4, packet[4] & 0x0f);
            model.OBDEn = (packet[5] & 1) == 1;//LDC
            model.AutoAdaptive = false;//LDC
            model.OxygenSimulation = (packet[5] & 0x40) == 0x40;//LDC
            model.SmartSwitch = false;//LDC
            model.GasAlert = false;//LDC
            model.ECUExtension = false;//LDC
            model.MapChoose = false;//LDC
            model.Bank1Cylinders = 4;//LDC
            if ((packet[3] & (byte)(0xF0)) == (byte)(0x60))//如果是 0x2开头表示48PIN  0x4表示64  0X6表示八缸
            {
                model.ECUExtension = true;//LDC
                model.Bank2Cylinders = 4;//LDC
            }
            else
                model.Bank2Cylinders = 0;//LDC
            return model;


            //var model = new Models.Feedback.HardwareInfo();
            //model.ECUVer = String.Format("{0}.{1}", packet[3], packet[4]);
            //model.PCBVer = String.Format("{0}.{1}", packet[3], packet[4]);
            //model.ODB = (packet[2] & 1) == 1;//LDC
            //model.AutoAdaptive = false;//LDC
            //model.OxygenSimulation = (packet[2] & 0x40)== 0x40;//LDC
            //model.SmartSwitch = false;//LDC
            //model.GasAlert = false;//LDC
            //model.ECUExtension = false;//LDC
            //model.MapChoose = false;//LDC
            //model.Bank1Cylinders = 4;//LDC
            //model.Bank2Cylinders = 0;//LDC
            //return model;
        }
        /// <summary>
        /// 从报文提取 固件信息
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>固件信息</returns>
        public static String ToFireWareInfo(this byte[] packet)
        {
            //var thechar = Char.ConvertFromUtf32(packet[5]);
            //return String.Format("{0}.{1}{2}", packet[3], packet[4], thechar);
            return String.Format("{0}.{1}", packet[3], packet[4]);

        }
        /// <summary>
        /// 从报文提取 实时数据
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>实时数据</returns>
        public static Models.Feedback.RealTimeData ToRealyTimeData(this byte[] packet)//LDC
        {
            var data = packet.PacketData(1).ToArray();
            Models.Feedback.RealTimeData model = new Models.Feedback.RealTimeData();
            model.PetrolsTime = ValueConvert.TwoBitTimeByusFrom(data[0], data[1]);//1（高位）、2（低位）字节：当前喷油时间；单位2.56us；
            model.GasesTime = ValueConvert.TwoBitTimeByusFrom(data[2], data[3]);//3（高位）、4（低位）字节：当前喷气时间；单位2.56us；
            model.RPM = ValueConvert.RealyDataRPMFrom(data[4], data[5]);//5（高位）、6（低位）字节：当前发动机转速；单位rpm；
            model.TempRed = ValueConvert.SingleTempFrom(data[6]);//7字节：当前减压器温度；单位℃；
            model.TempGas = ValueConvert.SingleTempFrom(data[7]);//8字节：当前燃气温度；单位℃；
            model.MAPPress = ValueConvert.PressFrom(data[8]);//9字节：当前真空压力；单位0.01bar；
            model.GasPress = ValueConvert.PressFrom(data[9]);//10字节：当前燃气压力；单位0.01bar；
            model.Lambda = ValueConvert.TwoBitKVFrom(data[10], data[11]);
            model.GasLevel = ValueConvert.GasLevelFrom(data[12]);
            model.LEDLight = ValueConvert.LEDLightFrom(data[13]);//14字节：开关LED灯状态；bit0：level0，bit1：level1，bit2：level2，bit3：level3，bit4：level4，bit5：gas，bit6：petrol，bit7：保留
            bool[] state = ValueConvert.SolenoidValveAndIgnitionStatusFrom(data[14]);
            model.SolenoidValveStatus = state[0];
            model.IgnitionStatus = state[1];
            //model.RPMSource = ValueConvert.RPMSourceFrom(data[18]);
            return model;
        }
//        命令0x10（返回ECU实时状态数据）：





        //11字节：氧传感器1电压；0~0xFF表示0~5V电压
//12字节：氧传感器2电压；0~0xFF表示0~5V电压
 //13字节：当前液位传感器电压；0~0xFF表示0~5V电压

//15字节：电磁阀、点火钥匙状态；bit0：电磁阀状态， bit4：点火钥匙状态
//16字节：电瓶电压；




        //{//原代码
        //    var data = packet.PacketData(1).ToArray();
        //    Models.Feedback.RealTimeData model = new Models.Feedback.RealTimeData();
        //    model.PetrolsTime = ValueConvert.TwoBitTimeByusFrom(data[0], data[1]);
        //    model.GasesTime = ValueConvert.TwoBitTimeByusFrom(data[2], data[3]);
        //    model.RPM = ValueConvert.RealyDataRPMFrom(data[4], data[5]);
        //    model.TempRed =ValueConvert.SingleTempFrom(data[6]);
        //    model.TempGas =ValueConvert.SingleTempFrom(data[7]);
        //    model.MAPPress = ValueConvert.PressFrom(data[8]);
        //    model.GasPress = ValueConvert.PressFrom(data[9]);
        //    model.Lambda = ValueConvert.TwoBitKVFrom(data[10], data[11], data[12], data[13]);
        //    model.GasLevel = ValueConvert.TwoBitKVFrom(data[14], data[15])[0];
        //    model.LEDLight = ValueConvert.LEDLightFrom(data[16]);
        //    bool[] state = ValueConvert.SolenoidValveAndIgnitionStatusFrom(data[17]);
        //    model.SolenoidValveStatus = state[0];
        //    model.IgnitionStatus = state[1];
        //    model.RPMSource = ValueConvert.RPMSourceFrom(data[18]);
        //    return model;
        //}



        /// <summary>
        /// 从报文提取 自动标定信息
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>自动标定信息</returns>
        public static Models.Feedback.AutoCalibrationDetails ToAutoCalibrationDetails(this byte[] packet)
        {
            return ValueConvert.AutoCalibrationDetailsFrom(packet.PacketData(1).ToArray());
        }
        /// <summary>
        /// 从报文提取 喷轨修正参数
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>喷轨修正参数</returns>
        public static Models.Settings.InjectorCorrectionSetting ToInjectorCorrectionSetting(this byte[] packet)
        {
            var data = packet.PacketData(1).ToArray();
            var model = new Models.Settings.InjectorCorrectionSetting();
            model.CorrectionValues = new int[16];
            for (int i = 0; i < model.CorrectionValues.Length; i++)
            {
                model.CorrectionValues[i] = data[i];
            }
            model.MinOpenTime = ValueConvert.TwoBitTimeByusFrom(data[16], data[17]);
            model.CorrectionTime = ValueConvert.TwoBitTimeByusFrom(data[18], data[19]);
            model.OpenKeepTime = ValueConvert.TwoBitTimeByusFrom(data[20], data[21]);
            model.InjectEmptyScale = data[22];
            model.MaxOpenTime = ValueConvert.TwoBitTimeByusFrom(data[23], data[24]);
            return model;
        }
        /// <summary>
        /// 从报文提取 OBD故障
        /// </summary>
        /// <param name="packet">报文</param>
        /// <returns>OBD故障</returns>
        public static Models.Feedback.OBDError[] ToOBDError(this byte[] packet)
        {
            var data=packet.PacketData(2).ToArray();
            int count = data[0];
            Models.Feedback.OBDError[] results=new Models.Feedback.OBDError[count]; 
            for (int i = 0,index=1; i < count; i++,index+=2)
            {
                int raw = (data[index] << 8) | data[index + 1];
                results[i] = new Models.Feedback.OBDError() { Code = GetCode(raw) };
            }
            return results;
        }
        private static string GetHead(int raw)
        {
            switch (raw>>14)
            {
                case 0: return "P";
                case 1: return "C";
                case 2: return "B";
                case 3: return "U";
                default:
                    return String.Empty;
            }
        }
        private static string GetCode(int raw)
        {
            int one = (raw >> 12) & 0x03;
            int two = (raw >> 8) & 0x0F;
            int three = (raw>>4) & 0x0F;
            int four = raw & 0x0F;
            return string.Format("{0}{1}{2}{3}{4}", GetHead(raw), one.ToString(), two.ToString(), three.ToString(), four.ToString());
        }
    }
}
