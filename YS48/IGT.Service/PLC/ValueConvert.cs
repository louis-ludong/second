using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;








namespace IGT.Service.PLC
{
    public class ValueConvert
    {
        /// <summary>
        /// 保存ECU基本参数的前四个字节
        /// </summary>
        //public static byte[] BaseData = new byte[4];//LDC增加
        /// <summary>
        /// 保存ECU基本参数的转速源设置
        /// </summary>
        //public static byte DataRpm;
        /// <summary>
        /// 保存ECU扩展参数的前五个字节
        /// </summary>
        //public static byte[] ExtraDataFive = new byte[5];//LDC增加
        /// <summary>
        /// 转换为byte，但不做溢出检查
        /// </summary>
        /// <param name="value">要转换的值</param>
        /// <returns>转换后的值</returns>
        public static byte ConvertToByteSafe(sbyte value)
        {
            unchecked
            {
                return (byte)value;
            }
        }
        
        /// <summary>
        /// 转换为sbyte，但不做溢出检查
        /// </summary>
        /// <param name="value">要转换的值</param>
        /// <returns>转换后的值</returns>
        public static sbyte ConvetToSbyteSafe(byte value)
        {
            unchecked
            {
                return (sbyte)value;
            }
        }

        /// <summary>
        /// 将电压格式从byte转换到float
        /// </summary>
        /// <param name="value">电压</param>
        /// <returns>转换后的电压</returns>
        public static float SingleVoltageFrom(byte value)
        {
            
            return value * 5 / 255f;
        }

        /// <summary>
        /// 将电压格式从float转换到byte
        /// </summary>
        /// <param name="value">电压</param>
        /// <returns></returns>
        public static byte SingleVoltageValue(float value)
        {
            return Convert.ToByte(value * 255 / 5);
        }
        /// <summary>
        /// 转换双字节数据为2.56us为单位的时间
        /// </summary>
        /// <param name="lowBit"></param>
        /// <param name="hightBit"></param>
        /// <returns></returns>
        public static float TwoBitTimeByusFrom(byte hightBit, byte lowBit)
        {
            return ((hightBit << 8) | lowBit)*2.56f / 1000f;
        }


        /// <summary>
        /// 转换以us为单位时间为双字节数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] TwoBitTimeByusValue(float value)
        {
            int temp = (int)(value * 1000);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)(temp&0xFF)
            };
        }

        /// <summary>
        /// 温度传感器转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Models.Enums.TempSensTypes TempSensFrom(byte value)
        {
            switch (value)//LDCYG
            {
                case 0x05:
                    return Models.Enums.TempSensTypes.Ohm10K;
                case 0x04:
                    return Models.Enums.TempSensTypes.Ohm10K;
                case 0x00:
                    return Models.Enums.TempSensTypes.Ohm4K7;
                case 0x02:
                    return Models.Enums.TempSensTypes.Ohm2K;
                //case 0x00:
                //    return Models.Enums.TempSensTypes.Ohm10K;
                //case 0x01:
                //    return Models.Enums.TempSensTypes.Ohm8K5;
                //case 0x02:
                //    return Models.Enums.TempSensTypes.Ohm5K;
                //case 0x03:
                //    return Models.Enums.TempSensTypes.Ohm4K7;
                //case 0x04:
                //    return Models.Enums.TempSensTypes.Ohm2K2;
                //case 0x05:
                //    return Models.Enums.TempSensTypes.Ohm2K;
                default:
                    throw new ArgumentException();
            }
        }
        /// <summary>
        /// 温度传感器转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte GasTempSensValue(Models.Enums.TempSensTypes value)
        {
            switch (value)
            {
                case IGT.Models.Enums.TempSensTypes.Ohm10K:
                    return 0x05;
                case IGT.Models.Enums.TempSensTypes.Ohm8K5:
                    return 0x01;
                case IGT.Models.Enums.TempSensTypes.Ohm5K:
                    return 0x02;
                case IGT.Models.Enums.TempSensTypes.Ohm4K7:
                    return 0x00;
                case IGT.Models.Enums.TempSensTypes.Ohm2K2:
                    return 0x04;
                case IGT.Models.Enums.TempSensTypes.Ohm2K:
                    return 0x02;
                default:
                    throw new ArgumentException("未预期的TempSensTypes类型");
            }
        }
        public static byte ReducerTempSensValue(Models.Enums.TempSensTypes value)
        {
            switch (value)
            {
                case IGT.Models.Enums.TempSensTypes.Ohm10K:
                    return 0x04;
                case IGT.Models.Enums.TempSensTypes.Ohm8K5:
                    return 0x01;
                case IGT.Models.Enums.TempSensTypes.Ohm5K:
                    return 0x02;
                case IGT.Models.Enums.TempSensTypes.Ohm4K7:
                    return 0x00;
                case IGT.Models.Enums.TempSensTypes.Ohm2K2:
                    return 0x04;
                case IGT.Models.Enums.TempSensTypes.Ohm2K:
                    return 0x02;
                default:
                    throw new ArgumentException("未预期的TempSensTypes类型");
            }
        }
        /// <summary>
        /// 双字节电压转换
        /// </summary>
        /// <param name="values">高位 低位...高位 低位...</param>
        /// <returns></returns>
        public static float[] TwoBitKVFrom(params byte[] values)
        {
            var lenght = values.Length;//LDCYG
            int index = 0;
            float[] result = new float[lenght];
            for (int i = 0; i < values.Length; i++)
            {
                result[index] = Convert.ToSingle(Math.Round(Convert.ToSingle(values[i] ) / 51f, 2));          
                index++;
            }
            return result;
        }
        /// <summary>
        /// 双字节电压转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] TwoBitKVValue(float[] value)
        {
            byte[] result = new byte[value.Length * 2];
            int index = 0;
            for (int i = 0; i < value.Length; i++)
            {
                int temp = Convert.ToInt32(value[i] * 0x3FF / 5);
                result[index] = (byte)((temp & 0xFF00) >> 8);
                result[index + 1] = (byte)(temp & 0xFF);
                index += 2;
            }
            return result;
        }

        /// <summary>
        /// 单字节温度转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static sbyte SingleTempFrom(byte value)
        {
            unchecked
            {
                return (sbyte)value;
            }
        }
        /// <summary>
        /// 单字节温度转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte SingleTempValue(sbyte value)
        {
            unchecked
            {
                return (byte)value;
            }
        }

        public static int CylindersFrom(byte cylinders)
        {
            switch (cylinders)//LDC
            {
                case 0x03:
                    return 2;
                case 0x07:
                    return 3;
                case 0x0F:
                    return 4;
                case 0x37:
                    return 5;
                case 0x77:
                    return 6;
                case 0xFF:
                    return 8;
                default:
                    throw new ArgumentException();
            }
        }
        public static byte CylindersValue(int value)
        {
            switch (value)
            {
                case 2:
                    return 0x03;
                case 3:
                    return 0x07;
                case 4:
                    return 0x0F;
                case 5:
                    return 0x37;
                case 6:
                    return 0x77;
                case 8:
                    return 0xff;
                default:
                    throw new ArgumentException();
            }
        }
        public static Models.Enums.FuelTypes FuelTypeFrom(byte fuleType)
        {
            switch (fuleType & 2)//LDC
            {
                case 0x00:
                    return Models.Enums.FuelTypes.LPG;//LDC
                case 0x02:
                    return Models.Enums.FuelTypes.CNG;//LDC
                default:
                    throw new ArgumentException();
            }
        }
        public static byte FuleTypeValue(Models.Enums.FuelTypes fuleType)
        {
            switch (fuleType)
            {
                case IGT.Models.Enums.FuelTypes.CNG:
                    return 0x00;
                case IGT.Models.Enums.FuelTypes.LPG:
                    return 0x01;
                default:
                    throw new ArgumentException();
            }
        }

       public static int O2NumbersFrom(byte value)// O2NumbersFrom
        {
            if ((value & 0x04) == 0x04)
                return 1;
            else
                return 2;
        }
       public static byte[] IntToBy(params int[] bd)
       {
           return new byte[] { (byte)bd[0], (byte)bd[1], (byte)bd[2], (byte)bd[3] };
       }
       public static byte[] IntToBy5(params int[] bd)
       {
           return new byte[] { (byte)bd[0], (byte)bd[1], (byte)bd[2], (byte)bd[3], (byte)bd[4] };
       }
        public static Models.Enums.InjectionModes InjectionModeFrom(byte value1, byte value2)
        {
            switch (value1 & 0x40)//LDC
            {
                case 0x00:
                    if ((value2 & 0x40)==0x40)
                        return Models.Enums.InjectionModes.SemiSequential;//
                    else
                        return Models.Enums.InjectionModes.Sequential;
                case 0x40:
                    return Models.Enums.InjectionModes.FullGroup;//LDC
                default:
                    throw new ArgumentException();
            }
        }

        public static byte[] ExtraInjectionSensitivityEnableValue(bool value)//可删
        {
            //if (!value)
                //{
                //    return new byte[]{(byte)(BaseData[0]),BaseData[1]=(byte)(BaseData[1]|0x02),
                //     BaseData[2],(byte)(BaseData[3]) };
                //}
                //else
                //    return new byte[]{(byte)(BaseData[0]),BaseData[1]=(byte)(BaseData[1]&0xFD),
                //     BaseData[2],(byte)(BaseData[3]) };
                return new byte[] { 1, 2, 3, 4 };
        }

        public static byte[] InjectionModeValue(Models.Enums.InjectionModes value)////LDCbd
        {

            //switch (value)
            //{
            //    case IGT.Models.Enums.InjectionModes.Sequential:
            //        return new byte[]{BaseData[0]=(byte)(BaseData[0]&0xBF),BaseData[1],
            //       BaseData[2],(byte)(BaseData[3]&0xBF) };
            //    case IGT.Models.Enums.InjectionModes.SemiSequential:
            //        return new byte[]{BaseData[0]=(byte)(BaseData[0]&0xBF),BaseData[1],
            //       BaseData[2],(byte)(BaseData[3]|0x40) };
            //    case IGT.Models.Enums.InjectionModes.FullGroup:
            //        return new byte[]{BaseData[0]=(byte)(BaseData[0]|0x40),BaseData[1],
            //       BaseData[2],(byte)(BaseData[3]&0xBF) };
            ////    default:
            ////        throw new ArgumentException();
            //}
            return new byte[] { 1, 2, 3, 4 };
        }
        public static float MinThresholdFrom(byte high, byte low)
        {
            return ((high << 8) | low) / 1000f;
        }
        public static byte[] MinThresholdValue(float value)
        {

            int temp = (int)(value * 1000);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)(temp&0xFF)
            };
        }
        public static int SwitchRPMFrom(byte high, byte low)
        {
            return ((high << 8) | low)&0xFFFE;//LDCYG
        }
        public static byte[] SwitchRPMValue(int switchRPM, Models.Enums.SwitchModes sm)//
        {
            //return Convert.ToByte(switchRPM);

            if (switchRPM == 0)
                return new byte[] { 0, 0 };
            switch (sm)
            {
                case IGT.Models.Enums.SwitchModes.InAcceleration:
                    return new byte[]{
                    Convert.ToByte(((switchRPM&0xFF00)>>8)),
                    Convert.ToByte(switchRPM&0xFF)};
                case IGT.Models.Enums.SwitchModes.InDecelertion:
                    return new byte[]{//先高后低
                    Convert.ToByte((switchRPM&0xFF00)>>8),
                    Convert.ToByte((switchRPM&0xFF)|0x01)};
                case IGT.Models.Enums.SwitchModes.StartOnGas:
                    return new byte[] { 0, 0 };
                default:
                    throw new ArgumentException();
            }
        }

        //public static byte[] OffsetValue(float value)//参考
        //{
        //    int temp = (int)(value * 1000);
        //    return new byte[]{
        //        (byte)(temp&0xFF),
        //        (byte)((temp&0xFF00)>>8)
        //    };
        //}



        public static Models.Enums.SwitchModes SwitchModeFrom(byte Hvalue, byte Lvalue)
        {
            if (Hvalue == 0 && Lvalue == 0)
                return Models.Enums.SwitchModes.StartOnGas;
            switch (Lvalue & 1)//需修改
            {
                case 0x00:
                    return Models.Enums.SwitchModes.InAcceleration;
                case 0x01:
                    return Models.Enums.SwitchModes.InDecelertion;
                default:
                    throw new ArgumentException();
            }
        }
        public static byte SwitchModeValue(Models.Enums.SwitchModes switchMode)
        {
            switch (switchMode)
            {
                case IGT.Models.Enums.SwitchModes.InAcceleration:
                    return 0x00;
                case IGT.Models.Enums.SwitchModes.InDecelertion:
                    return 0x01;
                default:
                    throw new ArgumentException();
            }
        }
        public static float OverlapTimesFrom(byte value)
        {
            return value;//LDC
        }
        public static byte OverlapTimesValue(float time)
        {
            return (byte)(time);
        }



        public static float OffsetFrom(byte low, byte high)
        {
            return ((high << 8) | low) / 1000f;
        }
        public static byte[] OffsetValue(float value)
        {
            int temp = (int)(value * 1000);
            return new byte[]{
                (byte)(temp&0xFF),
                (byte)((temp&0xFF00)>>8)
            };
        }
        public static bool EnableMapTableFrom(byte value)
        {
            switch (value)
            {
                case 0x00:
                    return false;
                case 0x01:
                    return true;
                default:
                    throw new ArgumentException();
            }
        }
        public static byte EnableMapTableValue(bool value)
        {
            return (byte)(value ? 0x01 : 0x00);
        }
        public static int MinGasRPMFrom(byte high, byte low)
        {
            //return value * 20;
            return ((high << 8) | low);//LDC
        }
        public static int OrderDelayFrom(byte value)
        {
            //return value * 20;
            return value;//LDCYG
        }
        //public static byte MinGasRPMValue(int value)
        //{
        //    return Convert.ToByte(value / 20);
        //}
        public static byte[] MinGasRPMValue(int value)
        {
            //return Convert.ToByte(value / 20);
            return new byte[]{
                (byte)((value&0xFF00)>>8),
                (byte)((value&0xFF))};
        }

        public static int PressErrorTimeFrom(byte value)
        {
            return value /50;
        }
        public static byte PressErrorTimeValue(int value)
        {
            if (value < 1)
                value = 30;
            else
                value = value * 50;
            return Convert.ToByte(value);
        }
        public static Models.Enums.LevelIndicatorSensTypes LevelIndicatorSensFrom(byte value)
        {
            switch (value)//1 字节，传感器，气体液位传感器类型，0x81：IGT，0x02：0-90Ohm， 
                        //0x04：Not standard，0x83：Not standard inverted；
            {
                case 0x81:
                    return Models.Enums.LevelIndicatorSensTypes.IGT;//需修改
                //case 0x02:
                //    return Models.Enums.LevelIndicatorSensTypes.Lovato;
                case 0x02:
                    return Models.Enums.LevelIndicatorSensTypes.ZeroTo90ohm;
                case 0x04:
                    return Models.Enums.LevelIndicatorSensTypes.NotStandard;
                case 0x83:
                    return Models.Enums.LevelIndicatorSensTypes.NotStandardInverted;
                    //return Models.Enums.LevelIndicatorSensTypes.ZeroTo110ohm;
                //case 5:
                //    return Models.Enums.LevelIndicatorSensTypes.HundredTo10Kohm;
                //case 6:
                //    return Models.Enums.LevelIndicatorSensTypes.ZeroTo90ohm_2;
                //case 7:
                //    return Models.Enums.LevelIndicatorSensTypes.NinetyTo0ohm;
                //case 8:
                //    return Models.Enums.LevelIndicatorSensTypes.HundredTenTo0ohm;
                //case 9:
                //    return Models.Enums.LevelIndicatorSensTypes.TenKTo100ohm;
                default:
                    return Models.Enums.LevelIndicatorSensTypes.Unknow;
                    //break;
                    //throw new ArgumentException();
            }
        }
        public static byte LevelIndicatorSensValue(Models.Enums.LevelIndicatorSensTypes value)
        {
            switch (value)
            {
                case IGT.Models.Enums.LevelIndicatorSensTypes.IGT:
                    return 0x81;
                case IGT.Models.Enums.LevelIndicatorSensTypes.NotStandard:
                    return 0x04;
                case IGT.Models.Enums.LevelIndicatorSensTypes.ZeroTo90ohm:
                    return 0x02;
                case IGT.Models.Enums.LevelIndicatorSensTypes.NotStandardInverted:
                    return 0x83;
                case IGT.Models.Enums.LevelIndicatorSensTypes.HundredTo10Kohm:
                    return 5;
                case IGT.Models.Enums.LevelIndicatorSensTypes.ZeroTo90ohm_2:
                    return 6;
                case IGT.Models.Enums.LevelIndicatorSensTypes.NinetyTo0ohm:
                    return 7;
                case IGT.Models.Enums.LevelIndicatorSensTypes.HundredTenTo0ohm:
                    return 8;
                case IGT.Models.Enums.LevelIndicatorSensTypes.TenKTo100ohm:
                    return 9;
                default:
                    throw new ArgumentException();
            }
        }
        public static float[] GasLevelSetFrom(params byte[] values)
        {
            float[] result = new float[values.Length];
            for(int i=0;i<values.Length;i++)
            {
                result[i] = (float)values[i] / 255f * 5f;
            }
            return result;
        }
        internal static byte[] GasLevelValue(float[] values)
        {

            byte[] result = new byte[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                result[i] = (byte)(values[i]* 51f);
            }
            return result;
        }
        public static float OperationalPressFrom(byte high,byte low)
        {
            return ((high << 8) | low) * 0.001f;
        }
        public static byte[] OperationalPressValue(float value)//LDC修改
        {
            int temp = (int)(value * 1000);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)((temp&0xFF))};
            //return (byte)(value * 100);
        }
        public static float MinimumPressFrom(byte high, byte low)
        {
            return ((high << 8) | low) * 0.001f;
        }
        public static byte[] MinimumPressValue(float value)//LDC修改
        {
            int temp = (int)(value * 1000);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)((temp&0xFF))};


            //return (byte)(value * 100);
        }

        public static Models.Enums.RevolutionSignalTypes RevolutionSignalTypeFrom(byte value)
        {
               switch (value&0x40)
               {
                   case 0x00:
                       return Models.Enums.RevolutionSignalTypes.Standard;
                   case 0x40:
                       return Models.Enums.RevolutionSignalTypes.Weak;
                   default:
                       throw new ArgumentException();
               }
        }
        public static byte RPMType(bool b7,Models.Enums.RevolutionSignalTypes b6,Models.Enums.RPMSources b5_0)
        {
            byte temp;
            temp = 0;
            if (b7)
                temp = (byte)(temp | 0x80);
            else
                temp = (byte)(temp & 0x7F);
            switch (b6)
            {
                case IGT.Models.Enums.RevolutionSignalTypes.Standard://第六位  强弱
                    temp= (byte)(temp & 0xBF);
                    break;
                case IGT.Models.Enums.RevolutionSignalTypes.Weak:
                    temp = (byte)(temp | 0x40);
                    break;
                default:
                    throw new ArgumentException();
            }
            switch (b5_0)
            {
                case IGT.Models.Enums.RPMSources.OneCoil:
                    return (byte)((temp & 0xC0) | 0x01);//
                case Models.Enums.RPMSources.TwoCoils:
                    return (byte)((temp & 0xC0) | 0x02);
                case Models.Enums.RPMSources.RPMSensor:
                    return (byte)((temp & 0xC0) | 0x03);
                case Models.Enums.RPMSources.RPMSensor2:
                    return (byte)((temp & 0xC0) | 0x04);
                default:
                    throw new ArgumentException();
            }
        }
        /*
        public static byte RPMInjectionSelectValue(bool value)//第七位 是否喷油觜
        {
            if (value)
                return (byte)(DataRpm | 0x80);
            else
                return (byte)(DataRpm & 0x7F);
        }
        public static byte RevolutionSignalTypeValue(Models.Enums.RevolutionSignalTypes sw)//(int switchRPM, Models.Enums.RevolutionSignalTypes sw)
        {
            switch (sw)
            {
                case IGT.Models.Enums.RevolutionSignalTypes.Standard://第六位  强弱
                    return (byte)(DataRpm & 0xBF);
                case IGT.Models.Enums.RevolutionSignalTypes.Weak:
                    return (byte)(DataRpm | 0x40);
                default:
                    throw new ArgumentException();

            }
        }

        public static byte RPMSourceValue(Models.Enums.RPMSources value)//低六位
        {
            switch (value)
            {
                case IGT.Models.Enums.RPMSources.OneCoil:
                    return (byte)((DataRpm & 0xC0) | 0x01);//
                case Models.Enums.RPMSources.TwoCoils:
                    return (byte)((DataRpm & 0xC0) | 0x02);
                case Models.Enums.RPMSources.RPMSensor:
                    return (byte)((DataRpm & 0xC0) | 0x03);
                case Models.Enums.RPMSources.RPMSensor2:
                    return (byte)((DataRpm & 0xC0) | 0x04);
                default:
                    throw new ArgumentException();
            }
        }*/

        public static bool RPMInjectionSelectFrom(byte value)
        {
            switch (value&0x80)
            {
                case 0x00:
                    return false;
                case 0x80:
                    return true;
                default:
                    throw new ArgumentException();
            }
        }





        public static Models.Enums.RPMSources RPMSourceFrom(byte value)
        {
            switch (value&0x3F)
            {
                //case 0x00:
                //    return Models.Enums.RPMSources.Injector;//LDCrpm
                //case 0x01:
                //    return Models.Enums.RPMSources.Coil;
                //case 0x02:
                //    return Models.Enums.RPMSources.CamshaftSensor;
                //case 0x0F:
                //    return Models.Enums.RPMSources.Auto;
                case 0x01:
                    return Models.Enums.RPMSources.OneCoil;
                case 0x02:
                    return Models.Enums.RPMSources.TwoCoils;
                case 0x03:
                    return Models.Enums.RPMSources.RPMSensor;
                case 0x04:
                    return Models.Enums.RPMSources.RPMSensor2;
                //case 0x01:
                //    return Models.Enums.RPMSources.OneCoil;
                //case 0x02:
                //    return Models.Enums.RPMSources.TwoCoils;
                //case 0x03:
                //    return Models.Enums.RPMSources.RPMSensor;
                //case 0x04:
                //    return Models.Enums.RPMSources.RPMSensor;
                default:
                    throw new ArgumentException();
            }
        }

        public static int CoilNumsFrom(byte value)
        {
            switch (value&0x07)//LDC 取低三位
            {
                case 0x01:
                    return 1;
                case 0x02:
                    return 2;
                case 0x04:
                    return 4;
                //case 0x06:
                //    return 6;
                default:
                    throw new ArgumentException();
            }
        }
        public static byte CoilNumsValue(int value)
        {
            switch (value)
            {
                case 1:
                    return 0x01;
                case 2:
                    return 0x02;
                case 4:
                    return 0x04;
                case 6:
                    return 0x06;
                default:
                    throw new ArgumentException();
            }
        }

        //public static int MapTableRPMFrom(byte value)
        //{
        //    return value * 100;
        //}

        public static int[] MapTableRPMFrom(params byte[] values)
        {
            int[] tem = new int[12];//
            int j=0;
            for(int i=0;i<values.Length;i++)// ((high << 8) | low)&0xFFFE;
            {
                tem[j++] = ((values[i] << 8) | values[++i]);

            }
            return tem;
        }
        public static float[] MapTableInjectionFrom(params byte[] values)
        {
            float[] tem = new float[12];//
            int j = 0;
            for (int i = 0; i < values.Length; i++)// ((high << 8) | low)&0xFFFE;
            {
                tem[j++] = (((values[i] << 8) | values[++i]) & 0xFFFE) * 0.00256f;

            }
            return tem;
        }



        public static byte[] MapTableRPMValue(params int[] values)
        {

            byte[] tem = new byte[values.Length*2];//
            int j = 0;
            for (int i = 0; i < values.Length;i++)// ((high << 8) | low)&0xFFFE;
            {
                tem[j++] =(byte)(values[i] >> 8);
                tem[j++] = (byte)(values[i]&0x00ff);
            }
            return tem;
        }

        public static int TempCorrectionFrom(byte value)
        {
            unchecked
            {
                return (sbyte)value;
            }
        }
        public static byte TempCorrectionValue(float value)///LDC int...float
        {
            unchecked
            {
                return (byte)(value+100);
            }
        }


        public static int RealyDataRPMFrom(byte hightBit, byte lowBit)
        {
            return ((hightBit << 8) | lowBit);
        }

        public static float PressFrom(byte p)
        {
            return p * 0.01f;
            //return ((hightBit << 8) | lowBit) * 0.001f;
        }
        public static float CorrectionPressFrom(byte hightBit, byte lowBit)
        {
            //return p * 0.01f;
            return ((hightBit << 8) | lowBit) * 0.001f;
        }
        public static float PressCorrectionFrom(byte hightBit, byte lowBit)
        {
            //return p * 0.01f;
            short temp = (short)((hightBit << 8) | lowBit);
            return (float)(temp * 0.01f);
        }
        public static byte[] PressCorrectionValue(float value)
        {
            int temp = (int)(value * 100);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)((temp&0xFF))};
        }

        public static byte[] PressValue(float value)
        {
            int temp = (int)(value * 1000);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)((temp&0xFF))};
        }
        public static IGT.Models.Feedback.AutoCalibrationDetails AutoCalibrationDetailsFrom(byte[] value)//自动标定
        {
            var model = new Models.Feedback.AutoCalibrationDetails();
            model.State = value[0];
            //switch (value[0])
            //{
            //    case 0x00:
            //        model.State = Models.Enums.AutoCalibrationState.NotEnter;
            //        break;
            //    case 0x01:
            //        model.State = Models.Enums.AutoCalibrationState.WaitEngineStart;
            //        break;
            //    case 0x02:
            //        model.State = Models.Enums.AutoCalibrationState.WaitRedArrive50;
            //        break;
            //    case 0x03:
            //        model.State = Models.Enums.AutoCalibrationState.InjectorParamSend;
            //        break;
            //    case 0x04:
            //        model.State = Models.Enums.AutoCalibrationState.Error;
            //        break;
            //    case 0x05:
            //        model.State = Models.Enums.AutoCalibrationState.Finished;
            //        break;
            //}
            model.AutoCalibrationResult = value[1];
            //switch (value[1])AutoCalibrationResult
            //{
            //    case 0x00:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.Successed;
            //        break;
            //    case 0x01:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.NoMAPSensor;//水温过低
            //        break;
            //    case 0x02:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.MAPPressLower;
            //        break;
            //    case 0x03:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.MAPPressHigher;
            //        break;
            //    case 0x04:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.RPMLower;
            //        break;
            //    case 0x05:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.RPMHigher;
            //        break;
            //    case 0x06:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.PertolSignalError;
            //        break;
            //    case 0xFF:
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.UnknowageError;     
            //        break;
            //    default: 
            //        model.AutoCalibrationResult = Models.Enums.AutoCalibrationResult.UnknowageError;
            //        break;
            //}
            //sbyte temp;
            //unchecked
            //{
            //    temp = (sbyte)value[2];
            //}
            //model.InjectorBoreValue = temp; 
            model.InjectorBoreValue = 0;
            return model;
        }

        public static IGT.Models.Feedback.ECUWorkTime ECUWorkTimeFrom(byte[] value)
        {
            var model = new IGT.Models.Feedback.ECUWorkTime();
            model.System = new TimeSpan(value[0] << 8 | value[1], value[2] << 8 | value[3],0);//时 分 秒
           int temp1= (value[4] << 8 | (value[5]))/3;
           int temp2 = (value[4] << 8 | (value[5])) %3*20 + (value[6] << 8 | (value[7]))/60;
           model.Red = new TimeSpan(temp1, temp2, 0);
           temp1 = (value[8] << 8 | (value[9])) / 3;
           temp2 = (value[8] << 8 | (value[9])) % 3 * 20 + (value[10] << 8 | (value[11])) / 60;
           model.Gas = new TimeSpan(temp1, temp2, 0);
           return model;
        }

        public static byte AutoCalibrationCMDValue(IGT.Models.Enums.AutoCalibrationCMD value)
        {
            switch (value)
            {
                case IGT.Models.Enums.AutoCalibrationCMD.Exit:
                    return 0x00;
                case IGT.Models.Enums.AutoCalibrationCMD.Auto:
                    return 0x01;
                case IGT.Models.Enums.AutoCalibrationCMD.AutoFull:
                    return 0x02;
                default:
                    throw new ArgumentException();
            }
        }

        public static byte OrderDelayValue(int value)
        {
            return Convert.ToByte(value / 20);
        }

        public static int LowLevelTimeFrom(byte value)
        {
            if (value == 0xFF)
                return value;
            else
                return value * 5;
        }
        public static byte LowLevelTimeValue(int value)
        {
            return Convert.ToByte(value / 5);
        }
        public static bool HotStartFrom(byte value)
        {
            //return value == 0x01;
            return (value&0x02) == 0x02;

        }
        internal static bool ValvetronikFrom(byte value)
        {
            return (value & 0x04) == 0x04;
        }
        internal static bool StartAndStopForm(byte p)
        {
            return (p & 0x10) == 0x10;
        }


        //public static byte[] HotStartValue(bool value)
        //{
        //    if(value)
        //        return new byte[]{ExtraDataFive[0]=(byte)(ExtraDataFive[0]|0x02),ExtraDataFive[1],
        //            ExtraDataFive[2],ExtraDataFive[3],ExtraDataFive[4]};
        //    else
        //        return new byte[]{ExtraDataFive[0]=(byte)(ExtraDataFive[0]&0xFD),ExtraDataFive[1],
        //            ExtraDataFive[2],ExtraDataFive[3],ExtraDataFive[4]};

        //}

        //public static byte[] ExtraInjectionCuttingValue(bool value)//ExtraInjectionCutting
        //{
        //    //return value ? (byte)0x01 : (byte)0x00;
        //    if (value)
        //        return new byte[]{ExtraDataFive[0]=(byte)(ExtraDataFive[0]|0x01),ExtraDataFive[1],
        //            ExtraDataFive[2],ExtraDataFive[3],ExtraDataFive[4]};
        //    else
        //        return new byte[]{ExtraDataFive[0]=(byte)(ExtraDataFive[0]&0xFE),ExtraDataFive[1],
        //            ExtraDataFive[2],ExtraDataFive[3],ExtraDataFive[4]};

        //}

        public static float ExtraThresholdFrom(byte high, byte low)
        {
            return ((high << 8) | low) / 1000f;
        }
        public static byte[] ExtraThresholdValue(float value)
        {
            int temp = (int)(value * 1000);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)(temp&0xFF)
            };
        }

       public static float GasLevelFrom(byte value)
        {

            return (float)((float)value / 255f * 5f);
        }

        public static bool[] LEDLightFrom(byte value)
        {
            return new bool[] { (value & 1) == 1, (value &2)==2
            , (value & 4)==4, (value & 8)==8, (value & 16)==16
            , (value & 32)==32, (value & 64)==64, (value &128)==128};
        }


        public static byte InjectOnOffValue(bool[] onOrOff)
        {
            int data = 0;
            for (int i = 0; i < onOrOff.Length; i++)
            {
                if (onOrOff[i] == true)
                    data = Bit32Warper.RemoveBitValue(data, i);
                else
                    data = Bit32Warper.AddBitValue(data, i);
            }
            return Convert.ToByte(data);
            //return (byte)(
            //    (onOrOff[0] ? 1 : 0) | (onOrOff[1] ? 2 : 0) | (onOrOff[2] ? 4 : 0) | (onOrOff[3] ? 8 : 0)
            //    | (onOrOff[4] ? 16 : 0) | (onOrOff[5] ? 32 : 0) | (onOrOff[6] ? 64 : 0) | (onOrOff[7] ? 128 : 0));
        }
        public static bool[] InjectOnOffFrom(byte value)
        {
            return new bool[]{
                Bit32Warper.GetBitValue(value,0)==0,Bit32Warper.GetBitValue(value,1)==0,
                Bit32Warper.GetBitValue(value,2)==0,Bit32Warper.GetBitValue(value,3)==0,
                Bit32Warper.GetBitValue(value,4)==0,Bit32Warper.GetBitValue(value,5)==0,
                Bit32Warper.GetBitValue(value,6)==0,Bit32Warper.GetBitValue(value,7)==0,
            };
        }

        public static float RPMVoltageFrom(byte value)
        {
            return value * 0.1f;
        }
        public static byte RPMVoltageValue(float value)
        {
            return Convert.ToByte(value * 10);
        }

        public static Models.Enums.InjectorTypes InjectorTypeFrom(byte value)
        {
            switch (value)//LDCYG
            {
                case 0x00:
                    return Models.Enums.InjectorTypes.Matrix;
                case 0x12:
                    return Models.Enums.InjectorTypes.ThreeOhm;
                case 0x52:
                    return Models.Enums.InjectorTypes.OneOhm;
                case 0x16:
                    return Models.Enums.InjectorTypes.IGT;
                //case 0x16:
                //    return Models.Enums.InjectorTypes.OneOhm;
                //case 0x0F://0x16
                //    return Models.Enums.InjectorTypes.Custom;
                default:
                    return Models.Enums.InjectorTypes.Unknow;
                    //throw new ArgumentException();
            }
        }
        public static byte InjectorTypeValue(Models.Enums.InjectorTypes value)
        {
            switch (value)
            {
                case IGT.Models.Enums.InjectorTypes.Matrix:
                    return 0x00;
                case IGT.Models.Enums.InjectorTypes.ThreeOhm:
                    return 0x12;
                case IGT.Models.Enums.InjectorTypes.OneOhm:
                    return 0x52;
                case IGT.Models.Enums.InjectorTypes.IGT:
                    return 0x16;

                //case IGT.Models.Enums.InjectorTypes.Custom:
                //    return 0x0F;
                default:
                    throw new ArgumentException();
            }
        }

        public static byte[] MapTableInjectionValue(params float[] values)
        {
           // return Convert.ToByte(value * 10);
            byte[] tem = new byte[values.Length * 2];//
            int ls;
            int j = 0;
            for (int i = 0; i < values.Length; i++)// ((high << 8) | low)&0xFFFE;
            {
                ls = (short)(values[i] / 0.00256f);
                tem[j++] = (byte)(ls >> 8);
                tem[j++] = (byte)(ls & 0x00ff);
            }
            return tem;
        }

        //public static byte[] MapTableRPMValue(params int[] values)
        //{

        //    byte[] tem = new byte[values.Length * 2];//
        //    int j = 0;
        //    for (int i = 0; i < values.Length; i++)// ((high << 8) | low)&0xFFFE;
        //    {
        //        tem[j++] = (byte)(values[i] >> 8);
        //        tem[j++] = (byte)(values[i] & 0x00ff);
        //    }
        //    return tem;
        //}



        public static float MapTableInjectionFrom(byte value)
        {
            return value * 0.1f;
        }

        public static byte[] PasswordValue(string pwd)
        {
            int pwdLenght = 6;
            byte[] data = null;
            if (pwd == String.Empty)
            {
                data = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            }
            else if (pwd.Length < pwdLenght)
            {
                data = new byte[pwdLenght];
                int i = 0;
                for (; i < pwd.Length; i++)
                    data[i] = Convert.ToByte(pwd[i]);
                for (; i < pwdLenght; i++)
                    data[i] = Convert.ToByte(0xFF);
            }
            else
                data = pwd.ToCharArray(0, pwdLenght).Select(m => Convert.ToByte(m)).ToArray();
            return data;
        }

        public static bool[] SolenoidValveAndIgnitionStatusFrom(byte value)
        {
            return new bool[]
            {
                (value&0x01)==0x01,
                (value&0x10)==0x10
            };
        }
        public static byte SolenoidValveAndIgnitionStatusValue(bool solenoidValve, bool ignition)
        {
            int temp1 = solenoidValve ? 0x01 : 0x00;
            int temp2 = ignition ? 0x10 : 0x00;
            return (byte)(temp1 | temp2);
        }

        public static Models.Enums.EngineTypes EngineTypeFrom(byte value)
        {
            switch (value)
            {
                case 0x00:
                    return Models.Enums.EngineTypes.Standard;
                case 0x01:
                    return Models.Enums.EngineTypes.Turbo;
                default:
                    throw new ArgumentException();
            }
        }

     public static float ExtrainjSensitivityFrom(byte high,byte low)
     {
         return ((high << 8) | low) / 391f;
     }
     public static byte[] ExtrainjSensitivityValue(float value)
     {
         int temp = (int)(value * 391);
         return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)(temp&0xFF)
            };
     }


     public static byte[] ExtraInjectionIdentTimeValue(float value)
     {
         int temp = (int)(value * 391);
         return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)(temp&0xFF)
            };
     }

     public static float ExtraInjectionIdentTimeFrom(byte high, byte low)
     {
         return ((high << 8) | low) / 391f;
     }

        public static byte EngineTypeValue(Models.Enums.EngineTypes value)
        {
            switch (value)
            {
                case IGT.Models.Enums.EngineTypes.Standard:
                    return 0x00;
                case IGT.Models.Enums.EngineTypes.Turbo:
                    return 0x01;
                default:
                    throw new NotImplementedException();
            }
        }
        public static Models.Enums.LambdaTypes O2TypeFrom(byte value)
        {
            switch (value)
            {
                case 0x02:
                    return Models.Enums.LambdaTypes.Volt0_1;//OK
                case 0x03:
                    return Models.Enums.LambdaTypes.Volt0_5;//OK
                //case 2:
                //    return Models.Enums.LambdaTypes.Reverse;
                case 0x19:
                    return Models.Enums.LambdaTypes.Volt5_0;
                case 0x4:
                    return Models.Enums.LambdaTypes.Volt08_16;
                default:
                    throw new ArgumentException();
            }
        }
        public static Models.Enums.LambdaTypes LambdaTypeFrom(byte value)
        {
            switch (value)
            {
                case 0:
                    return Models.Enums.LambdaTypes.NoConnection;
                case 1:
                    return Models.Enums.LambdaTypes.Befor;
                //case 2:
                //    return Models.Enums.LambdaTypes.Reverse;
                case 3:
                    return Models.Enums.LambdaTypes.After;
                default:
                    throw new ArgumentException();
            }
        }
        public static byte[] LambdaTypeValue(Models.Enums.LambdaTypes value1, Models.Enums.LambdaTypes value2, Models.Enums.LambdaTypes value3)
        {
            byte[] temp=new byte[3];
            switch (value1)
            {
                case IGT.Models.Enums.LambdaTypes.Volt0_1:
                    temp[0] = 0x02;
                    break;
                case IGT.Models.Enums.LambdaTypes.Volt0_5:
                    temp[0] = 0x03;
                    break;
                case IGT.Models.Enums.LambdaTypes.Volt5_0:
                    temp[0] = 0x19;
                    break;
                case IGT.Models.Enums.LambdaTypes.Volt08_16:
                    temp[0] =0x04;
                    break;
                default:
                    throw new ArgumentException();
            }
            switch (value2)
            {
                case IGT.Models.Enums.LambdaTypes.NoConnection:
                    temp[1] = 0;
                    break;
                case IGT.Models.Enums.LambdaTypes.Befor:
                    temp[1] = 1;
                    break;
                case IGT.Models.Enums.LambdaTypes.After:
                    temp[1] = 3;
                    break;
                default:
                    throw new ArgumentException();
            }
            switch (value3)
            {
                case IGT.Models.Enums.LambdaTypes.NoConnection:
                    temp[2] = 0;
                    break;
                case IGT.Models.Enums.LambdaTypes.Befor:
                    temp[2] = 1;
                    break;
                case IGT.Models.Enums.LambdaTypes.After:
                    temp[2] = 3;
                    break;
                default:
                    throw new ArgumentException();
            }
            return temp;
        }

        public static Models.Enums.GasStrategies GasStrategiesFrom(byte value,byte high, byte low)
        {
            int temp=(high << 8) | low;
            
            if((value&0x80)==0x80)
            {
                return Models.Enums.GasStrategies.OilCompensation;
             
            }
            else
            {
                if(temp>=8500)
                    return Models.Enums.GasStrategies.KeepGas;
                else
                    return Models.Enums.GasStrategies.SwitchOil;
            }
            //{
            //    case 0:
            //        return Models.Enums.GasStrategies.KeepGas;
            //    case 1:+
            //        return Models.Enums.GasStrategies.SwitchOil;
            //    case 2:
            //        return Models.Enums.GasStrategies.OilCompensation;
            //    default:
            //        throw new ArgumentException();
            //}
        }
        public static byte GasStrategiesValue(Models.Enums.GasStrategies value)
        {
            switch (value)
            {
                case IGT.Models.Enums.GasStrategies.KeepGas:
                    return 0;
                case IGT.Models.Enums.GasStrategies.SwitchOil:
                    return 1;
                case IGT.Models.Enums.GasStrategies.OilCompensation:
                    return 2;
                default:
                    throw new ArgumentException();
            }
        }

        public static Models.Enums.ErroClearLevels ODBErrorAutoClearFrom(byte value)
        {
            switch (value)
            {
                case 0:
                    return Models.Enums.ErroClearLevels.Not;
                case 1:
                    return Models.Enums.ErroClearLevels.Choice;
                case 2:
                    return Models.Enums.ErroClearLevels.Full;
                default:
                    throw new ArgumentException();
            }
        }
        public static byte ODBErrorAutoClearValue(Models.Enums.ErroClearLevels value)
        {
            switch (value)
            {
                case IGT.Models.Enums.ErroClearLevels.Not:
                    return 0;
                case IGT.Models.Enums.ErroClearLevels.Choice:
                    return 1;
                case IGT.Models.Enums.ErroClearLevels.Full:
                    return 2;
                default:
                    throw new ArgumentException();
            }
        }

        public static bool[] DataLockStatusFrom(params byte[] value)
        {
            List<bool> result = new List<bool>();
            foreach (var item in value)
            {
                result.Add((item & 1) == 1);
                result.Add((item & 2) == 2);
                result.Add((item & 4) == 4);
                result.Add((item & 8) == 8);
                result.Add((item & 16) == 16);
                result.Add((item & 32) == 32);
                result.Add((item & 64) == 64);
                result.Add((item & 128) == 128);
            }
            return result.ToArray();
        }

        internal static byte[] DataLockStatusValue(params bool[] aline)
        {
            int byte1 = Convert.ToInt32(aline[0]) | Convert.ToInt32(aline[1]) << 1 | Convert.ToInt32(aline[2]) << 2
                | Convert.ToInt32(aline[3]) << 3 | Convert.ToInt32(aline[4]) << 4 | Convert.ToInt32(aline[4]) << 4
                | Convert.ToInt32(aline[5]) << 5 | Convert.ToInt32(aline[6]) << 6 | Convert.ToInt32(aline[7]) << 7;
            int byte2 = Convert.ToInt32(aline[8]) | Convert.ToInt32(aline[9]) << 1 | Convert.ToInt32(aline[10]) << 2
                | Convert.ToInt32(aline[11]) << 3 | Convert.ToInt32(aline[12]) << 4 | Convert.ToInt32(aline[13]) << 4
                | Convert.ToInt32(aline[5]) << 5 | Convert.ToInt32(aline[6]) << 6 | Convert.ToInt32(aline[7]) << 7;
            int byte3 = Convert.ToInt32(aline[14]) | Convert.ToInt32(aline[15]) << 1 | Convert.ToInt32(aline[16]) << 2
                | Convert.ToInt32(aline[17]) << 3 | Convert.ToInt32(aline[18]) << 4 | Convert.ToInt32(aline[19]) << 4
                | Convert.ToInt32(aline[20]) << 5 | Convert.ToInt32(aline[21]) << 6 | Convert.ToInt32(aline[22]) << 7;
            return new byte[] { (byte)byte1, (byte)byte2, (byte)byte3 };
        }

        internal static byte[] RunningRPMValue(int value)
        {
            //return Convert.ToByte(value / 100);
            return new byte[]{
                (byte)((value&0xFF00)>>8),
                (byte)(value&0xFF)};
        }
        internal static byte[] RunningMinRPM(int value)
        {
            //return Convert.ToByte(value / 100);
            return new byte[]{
                (byte)((value&0xFF00)>>8),
                (byte)(value&0xFF)};
        }


        internal static int RunningRPMFrom(byte high, byte low)
        {
            //return value * 100;
            return ((high << 8) | low);
        }



        internal static float RunningTimeFrom(byte high, byte low)
        {
            //return value * 100;
            return ((high << 8) | low) * 0.00256f;
        }

        public static byte[] RunningTimeValue(float value)
        {
            int temp = (int)(value * 390.625f);
            return new byte[]{
                (byte)((temp&0xFF00)>>8),
                (byte)(temp&0xFF)
            };
        }

        //internal static Models.Enums.ODBConnectState ODBConnectSateFrom(byte value)
        //{
        //    var code = value >> 4;
        //    switch (code)
        //    {
        //        case 1: return Models.Enums.ODBConnectState.Init;
        //        case 2: return Models.Enums.ODBConnectState.Connecting;
        //        case 3: return Models.Enums.ODBConnectState.Connected;
        //        case 4: return Models.Enums.ODBConnectState.NoConnect;
        //        case 0xF: return Models.Enums.ODBConnectState.Error;
        //        default:
        //            throw new ArgumentException("value");
        //    }
        //}

        internal static Models.Enums.OBDConnectState ODBConnectSateFrom(byte value)
        {
            //  var code = value >> 4;
            switch (value)
            {
                case 0: return Models.Enums.OBDConnectState.Init;
                case 1: return Models.Enums.OBDConnectState.Waitting;
                case 2: return Models.Enums.OBDConnectState.Connecting;
                case 3: return Models.Enums.OBDConnectState.Connected;
                case 4: return Models.Enums.OBDConnectState.Error;
                default:
                    throw new ArgumentException("value");
            }
        }



        internal static Models.Enums.MaintainRemindTypes MaintainRemindTypesFrom(byte value)
        {
            switch (value)
            {
                case 0:
                    return Models.Enums.MaintainRemindTypes.Off;
                case 1:
                    return Models.Enums.MaintainRemindTypes.Sound;
                case 2:
                    return Models.Enums.MaintainRemindTypes.Forbid;
                default:
                    throw new ArgumentException("value");
            }
        }
        internal static byte MaintainRemindTypesValue(Models.Enums.MaintainRemindTypes value)
        {
            switch (value)
            {
                case IGT.Models.Enums.MaintainRemindTypes.Off:
                    return 0;
                case IGT.Models.Enums.MaintainRemindTypes.Sound:
                    return 1;
                case IGT.Models.Enums.MaintainRemindTypes.Forbid:
                    return 2;
                default:
                    throw new ArgumentException("value");
            }
        }

        internal static TimeSpan MaintainTimeFrom(byte high, byte low)
        {
            return new TimeSpan(0, low | (high << 8), 0);
        }
        internal static byte[] MaintainTimeValue(TimeSpan value)
        {
            var data = Convert.ToInt32(value.TotalMinutes);
            if (data > 0xFFFF) data = 0xFFFF;
            return new byte[]
            {
                Convert.ToByte((data&0xFF00)>>8)
                ,Convert.ToByte(data&0xFF)
            };
        }

        internal static Models.Enums.OBDStandard OBDStandardFrom(byte p)
        {
            switch (p)
            {
                case 0:
                    return IGT.Models.Enums.OBDStandard.Standard;
                case 1:
                    return IGT.Models.Enums.OBDStandard.Opposite;
                default:
                    return IGT.Models.Enums.OBDStandard.Standard;
            }
        }
        internal static Models.Enums.OBDTypes OBDTypeFrom(byte p)
        {
            switch (p)
            {
                case 0:
                    return IGT.Models.Enums.OBDTypes.Auto;
                case 1:
                    return IGT.Models.Enums.OBDTypes.ISO9141_2;
                case 2:
                    return IGT.Models.Enums.OBDTypes.KWP_2000FastInit;
                case 3:
                    return IGT.Models.Enums.OBDTypes.KWP_2000SlowInit;
                case 4:
                    return IGT.Models.Enums.OBDTypes.CANStandard250kbps;
                case 5:
                    return IGT.Models.Enums.OBDTypes.CANExtended250kbps;
                case 6:
                    return IGT.Models.Enums.OBDTypes.CANStandard500kbps;
                case 7:
                    return IGT.Models.Enums.OBDTypes.CANExtended500kbps;
                case 0xff:
                    return IGT.Models.Enums.OBDTypes.None;
                default:
                    return IGT.Models.Enums.OBDTypes.None;
            }
        }

        internal static byte[] SetOBDSettingValue(Models.Enums.OBDStandard oBDStandard, int p1, Models.Enums.OBDTypes oBDTypes, int p2)
        {
            byte pst, pty;
            switch (oBDStandard)
            {
                case Models.Enums.OBDStandard.Standard:
                    pst = 0;
                    break;
                case Models.Enums.OBDStandard.Opposite:
                    pst = 1;
                    break;
                default:
                    pst = 0;
                    break;
            }
            switch (oBDTypes)
            {
                case IGT.Models.Enums.OBDTypes.Auto:
                    pty = 0;
                    break;
                case IGT.Models.Enums.OBDTypes.ISO9141_2:
                    pty = 1;
                    break;
                case IGT.Models.Enums.OBDTypes.KWP_2000FastInit:
                    pty = 2;
                    break;
                case IGT.Models.Enums.OBDTypes.KWP_2000SlowInit:
                    pty = 3;
                    break;
                case IGT.Models.Enums.OBDTypes.CANStandard250kbps:
                    pty = 4;
                    break;
                case IGT.Models.Enums.OBDTypes.CANExtended250kbps:
                    pty = 5;
                    break;
                case IGT.Models.Enums.OBDTypes.CANStandard500kbps:
                    pty = 6;
                    break;
                case IGT.Models.Enums.OBDTypes.CANExtended500kbps:
                    pty = 7;
                    break;
                case IGT.Models.Enums.OBDTypes.None:
                    pty = 0xff;
                    break;
                default:
                    pty = 0;
                    break;
            }
            return new byte[] { pst, (byte)p1, pty, (byte)p2 };
        }







    }
}
