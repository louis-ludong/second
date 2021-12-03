using System;
using System.Collections.Generic;

using System.Text;

namespace IGT.Models.Settings
{
    /// <summary>
    /// ECU设定参数
    /// </summary>
    [Serializable]
    public class ECUSetting
    {
        //[] GasLevel { get; set; }        public float[] GasLevel { get; set; }
        public int[] BaseData { get; set; }//LDC增加
        public int[] ExtraData { get; set; }//LDC增加
        public int[] AnticipateInjSetting { get; set; }//LDC增加
        /// <summary>
        /// 气缸数;
        /// </summary>
        public int Cylinders { get; set; }
        /// <summary>
        /// 燃料类型
        /// </summary>
        public Enums.FuelTypes FuelType { get; set; }
        /// <summary>
        /// 氧传感器数量
        /// </summary>
        public int O2Numbers { get; set; }
        /// <summary>
        /// 喷射模式
        /// </summary>
        public Enums.InjectionModes InjectionMode { get; set; }
        /// <summary>
        /// 线圈数量
        /// </summary>
        public int Coils { get; set; }
        /// <summary>
        /// 转速信号类型//LDC转速信号类型 增加
        /// </summary>
        public Enums.RevolutionSignalTypes RevolutionSignalType { get; set; }
        /// <summary>
        /// 转速信号源
        /// </summary>
        public Enums.RPMSources RPMSource { get; set; }
        /// <summary>
        /// 转速信号门限电压
        /// </summary>
        public float RPMVoltage { get; set; }

        /// <summary>
        /// 切换温度
        /// </summary>
        public sbyte SwitchTemp { get; set; }
        /// <summary>
        /// 转速源选择
        /// </summary>
        public bool RPMInjectionSelect { get; set; }    //LDC RPMInjectionSelect增加
        /// <summary>
        /// 切换转速
        /// </summary>
        public int SwitchRPM { get; set; }
        /// <summary>
        /// 切换方式
        /// </summary>
        public Enums.SwitchModes SwitchMode { get; set; }
        /// <summary>
        /// 切换延时
        /// </summary>
        public float OverlapTimes { get; set; }
        /// <summary>
        /// 顺序切换延时
        /// </summary>
        public int OrderDelay { get; set; }
        /// <summary>
        /// 减压器温度传感器
        /// </summary>
        public Enums.TempSensTypes ReducerTempSens { get; set; }
        /// <summary>
        /// 燃气温度传感器
        /// </summary>
        public Enums.TempSensTypes GasTempSens { get; set; }
        /// <summary>
        /// 燃气工作压力
        /// </summary>
        public float OperationalPress { get; set; }
        /// <summary>
        /// 最小燃气压力
        /// </summary>
        public float MinimumPress { get; set; }
        /// <summary>
        /// 压力故障时间
        /// </summary>
        public int PressErrorTime { get; set; }
        /// <summary>
        /// 最低转速是否转油 最小运行, 0-转回燃油, 1-燃油； 
        /// </summary>
        public bool MinOilEn { get; set; }
        /// <summary>
        /// 最低燃气转速
        /// </summary>
        public int MinGasRPM { get; set; }
        /// <summary>
        /// 燃气最低温度
        /// </summary>
        public sbyte MiniGasTemp { get; set; }
        /// <summary>
        /// 喷轨类型
        /// </summary>
        public Enums.InjectorTypes InjectorType { get; set; }
        /// <summary>
        /// 液位传感器类型
        /// </summary>
        public Enums.LevelIndicatorSensTypes LevelIndicatorSens { get; set; }
        /// <summary>
        /// 液位传感器电压
        /// </summary>
        public float[] GasLevel { get; set; }
        /// <summary>
        /// 喷油嘴切断过渡时间
        /// </summary>
        public int BackTransitionTm { get; set; }

        /// <summary>
        /// 喷嘴正极驱动，false为负极驱动
        /// </summary>
        public bool InjectorPositiveDriver { get; set; }
        /// <summary>
        /// 发动机类型
        /// </summary>
        public Enums.EngineTypes EngineType { get; set; }
        /// <summary>
        /// 发动机热启动
        /// </summary>
        public bool HotStart { get; set; }
        /// <summary>
        /// Start and Stop
        /// </summary>
        public bool StartAndStop { get; set; }
        /// <summary>
        /// Valvetronik
        /// </summary>
        public bool Valvetronik { get; set; }
        /// <summary>
        /// 正极驱动
        /// </summary>
        public bool InjetPositiveDrive { get; set; }

        /// <summary>
        /// 马自达减弱
        /// </summary>
        public int Weak { get; set; }
        /// <summary>
        /// 加速加浓
        /// </summary>
        public int SpeedThicken { get; set; }
        /// <summary>
        /// 燃气高速运行时
        /// </summary>
        public Models.Enums.GasStrategies RunningGasStrategy { get; set; }
        /// <summary>
        /// 燃气高速运行转速条件（高）
        /// </summary>
        public int RunningMaxRPM { get; set; }
        /// <summary>
        /// 燃气高速运行转速条件（低）
        /// </summary>
        public int RunningMinRPM { get; set; }
        /// <summary>
        /// 燃气高速运行喷油时间条件
        /// </summary>
        public float RunningTijiTime { get; set; }
        /// <summary>
        /// 燃气高速运行喷油补偿
        /// </summary>
        public float RunningOilCompensation { get; set; }
        /// <summary>
        /// 预充气时间
        /// </summary>
        public int GasFillTime { get; set; }
        /// <summary>
        /// 氧传感器1类型
        /// </summary>
        /// 
        public Enums.LambdaTypes O2Type { get; set; }

        public Enums.LambdaTypes Lambda1Type { get; set; }
        /// <summary>
        /// 氧传感器2类型
        /// </summary>
        public Enums.LambdaTypes Lambda2Type { get; set; }
        /// <summary>
        /// 氧传感器1高电压
        /// </summary>
        public float Lambda1HV { get; set; }
        /// <summary>
        /// 氧传感器1低电压
        /// </summary>
        public float Lambda1LV { get; set; }
        /// <summary>
        /// 氧传感器2高电压
        /// </summary>
        public float Lambda2HV { get; set; }
        /// <summary>
        /// 氧传感器2低电压
        /// </summary>
        public float Lambda2LV { get; set; }
        /// <summary>
        /// 氧传感器仿真延时
        /// </summary>
        public int LambdaDelay { get; set; }
        /// <summary>
        /// 氧传感器喷射学习数量
        /// </summary>
        public int LambdaInjectNum { get; set; }
        /// <summary>
        /// 自动诊断
        /// </summary>
        public bool AutoDiagnosis { get; set; }
        /// <summary>
        /// 自动自适应（OBD自适应）
        /// </summary>
        public bool AutoAdaptive { get; set; }
        /// <summary>
        /// 自适应范围
        /// </summary>
        public int AdaptiveRange { get; set; }
        /// <summary>
        /// 自适应自动停止
        /// </summary>
        public bool AutoStopAdaptive { get; set; }
        /// <summary>
        /// 自适应协助
        /// </summary>
        public bool AdaptiveAssist { get; set; }
        /// <summary>
        /// ODB反向修正
        /// </summary>
        public bool ODBReverseAssist { get; set; }
        /// <summary>
        /// ODB适应范围
        /// </summary>
        public int ODBAdaptRange { get; set; }
        /// <summary>
        /// ODB Bank1矫正
        /// </summary>
        public sbyte ODBBank1Correct { get; set; }
        /// <summary>
        /// ODB Bank2矫正
        /// </summary>
        public sbyte ODBBank2Correct { get; set; }
        /// <summary>
        /// OBD故障码自动消除
        /// </summary>
        public Models.Enums.ErroClearLevels ODBErrorAutoClear { get; set; }
        /// <summary>
        /// 额外喷射断开
        /// </summary>
        public bool ExtraInjectionCutting { get; set; }
        /// <summary>
        /// 辅助喷射敏感度
        /// </summary>
        public float ExtrainjSensitivity { get; set; }//LDC int ---float
        /// <summary>
        /// 辅助喷射起始时间
        /// </summary>
        public float ExtraInjectionIdentTime { get; set; }
        /// <summary>
        /// 灵敏度可调
        /// </summary>
        public bool ExtraInjectionSensitivityEnable { get; set; }
        /// <summary>
        /// 1 字节bit4：OBD 完成故障错误复位有效, 0-取消, 1-选中；
        /// </summary>
        public bool CompleteResetOfErrors { get; set; }
        /// <summary>
        ///1 字节bit7：OBD 使用选择性错误复位, 0-取消, 1-选中；
        /// <summary>
        public bool SelectiveResetOfErrors { get; set; }
        //OBD参数读取 0x24（设置0x94） ，共4字节。
        //第1字节：0x00:标准, 0x01:反相类型；
        //第2字节：0x00（保留）；
        //第3字节：连接类型，
        //0x00：Auto；
        //0x01：1: ISO9141-2；
        //0x02：2: KWP-2000 Fast Init；
        //0x03：3: KWP-2000 Slow Init；
        //0x04：6: CAN Standard 250 kbps；
        //0x05：7: CAN Extended 250 kbps；
        //0x06：8: CAN Standard 500 kbps；
        //0x07：9: CAN Extended 500 kbps；
        //0xFF：None；
        //第4字节：自适应范围0~25
        public Models.Enums.OBDStandard OBDStandard { get; set; }
        public int Reserve { get; set; }
        public Models.Enums.OBDTypes OBDType { get; set; }
        public int OBDAdaptiveRange { get; set; }
    }
}
