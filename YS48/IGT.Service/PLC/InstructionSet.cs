using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IGT.Service.PLC
{
    /// <summary>
    /// IGT指令集
    /// </summary>
    public static class InstructionSet
    {
        /// <summary>
        /// 设备识别码
        /// </summary>
        public static byte[] DeviceCode { get { return new byte[] { 0x4E, 0x50, 0x0A }; } }
        //L48 0x4E,0x50,0x0A
        //万能0x43, 0x35, 0x50
        /// <summary>
        /// 发送头
        /// </summary>
        public static byte SendHead { get { return 0xE9; } }
        /// <summary>
        /// 接收头
        /// </summary>
        public static byte RecivedHead { get { return 0x9E; } }
        /// <summary>
        /// 握手
        /// </summary>
        public static byte HandShake { get { return 0xFF; } }
        /// <summary>
        /// 软件版本
        /// </summary>
        public static byte CopyRightInfo { get { return 0x01; } }
        /// <summary>
        /// 固件信息
        /// </summary>
        public static byte FireWareInfo { get { return 0x02; } }
        /// <summary>
        /// 硬件版本
        /// </summary>
        public static byte HardInfo { get { return 0x03; } }
        /// <summary>
        /// 发布日期
        /// </summary>
        public static byte ReleaseDate { get { return 0x04; } }
        /// <summary>
        /// 是否设置过密码
        /// </summary>
        public static byte PasswordIsSet { get { return 0x07; } }
        /// <summary>
        /// 产品序列号
        /// </summary>
        public static byte SerialNumber { get { return 0x08; } }
        /// <summary>
        /// 首次使用时间
        /// </summary>
        public static byte FirstUsingTime { get { return 0x09; } }
        /// <summary>
        /// ECU实时状态数据
        /// </summary>
        public static byte RealyData { get { return 0x10; } }
        /// <summary>
        /// ECU喷油、喷气时间 Part1
        /// </summary>
        public static byte GetInjectTimePart1 { get { return 0x11; } }
        /// <summary>
        /// ECU喷油、喷气时间 Part2 返回Bank1喷油、喷气时间
        /// </summary>
        public static byte GetInjectTimePart2_Bank1 { get { return 0x01; } }
        /// <summary>
        /// ECU喷油、喷气时间 Part2 返回Bank2喷油、喷气时间
        /// </summary>
        public static byte GetInjectTimePart2_Bank2 { get { return 0x02; } }
        /// <summary>
        /// 返回自适应（OBD）状态
        /// </summary>
        public static byte GetSelfAdaptationOR_ODBState { get { return 0x12; } }
        /// <summary>
        /// 返回ECU错误状态
        /// </summary>
        public static byte GetECUErrorState { get { return 0x15; } }//LDC
        /// <summary>
        /// 返回喷轨测试状态
        /// </summary>
        public static byte GetInjectOnOff { get { return 0x16; } }

        /// <summary>
        /// 返回自动标定状态
        /// </summary>
        public static byte GetAutoCalibrationState { get { return 0x17; } }
        /// <summary>
        /// ECU工作时间
        /// </summary>
        public static byte GetECUTime { get { return 0x18; } }
        /// <summary>
        /// 返回OBD故障码
        /// </summary>
        public static byte GetOBDErrorsPart1 { get { return 0x19; } }
        /// <summary>
        /// 返回故障码数量
        /// </summary>
        public static byte GetOBDErrorsPart2_Error { get { return 0x01; } }
        /// <summary>
        /// 返回潜在故障
        /// </summary>
        public static byte GetOBDErrorsPart2_Potential { get { return 0x02; } }
        /// <summary>
        /// 返回紧急燃气启动信息
        /// </summary>
        public static byte GetEmergencyStartInfo { get { return 0x25; } }//LDC 1A.。。25
        /// <summary>
        /// 返回燃气保养信息
        /// </summary>
        public static byte GetMaintainInfo { get { return 0x26; } }//LDC 1B----26
        /// <summary>
        /// 返回ECU设定参数数据
        /// </summary>
        public static byte GetECUSetting { get { return 0x20; } }
        /// <summary>
        /// 返回氧传感器设定参数数据
        /// </summary>
        public static byte GetO2Setting { get { return 0x23; } }
        /// <summary>
        /// 喷射顺序提前
        /// </summary>
        public static byte GetAnticipateInjSetting { get { return 0x39; } }

        /// <summary>
        /// 减压器温度修正
        /// </summary>
        public static byte RedTempCorrectionSettings { get { return 0x34; } }//LDC 21....34
        /// <summary>
        /// 燃气温度修正
        /// </summary>
        public static byte GasTempCorrectionSettings { get { return 0x35; } }//LDC 22.....35
        /// <summary>
        /// 燃气压力修正
        /// </summary>
        public static byte GasPressCorrectionSettings { get { return 0x36; } }//LDC23....36
        /// <summary>
        /// 燃气压力修正子命令 0x00：返回 30 字节，表示 1~15 格压力从小到大；单位 0.001bar； 
        /// </summary>
        public static byte GasPressCorrectionValue { get { return 0x00; } }//LDC
        /// <summary>
        /// 燃气压力修正子命令 0x10：返回 30 字节，表示 1~15 格修正百分比从小到大；单位 0.01%； 
        /// </summary>
        public static byte GasPressCorrectionPer { get { return 0x10; } }//LDC
        /// <summary>
        /// 返回ECU设定拓展参数数据
        /// </summary>
        public static byte GetECUSettingExtra { get { return 0x21; } }//LDCYG 原来ox24
        /// <summary>
        /// 喷轨参数
        /// </summary>
        public static byte InjectorCorrectionSetting { get { return 0x30; } }
        /// <summary>
        /// ECU修正比例参数Part1
        /// </summary>
        public static byte ECUCorrectionSettingPart1 { get { return 0x31; } }
        /// <summary>
        /// ECU修正比例参数Part2 修正比例
        /// </summary>
        public static byte[] ECUCorrectionSettingPart2_CorrectionValue { get { return new byte[] {0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 }; } }
        /// <summary>
        /// ECU修正比例参数Part2 10个坐标点的x轴位置
        /// </summary>
        public static byte ECUCorrectionSettingPart2_Ponits { get { return 0x08; } }

        #region 获取MAP标定参数
        /// <summary>
        /// Map标定参数Part1
        /// </summary>
        public static byte MAPCalibrationParamsPart1 { get { return 0x33; } }//LDC修改 原来0x32
        /// <summary>
        /// Map标定参数Part2 12格RPM的值
        /// </summary>
        public static byte MAPCalibrationParamsPart2_12RPMs { get { return 0x01; } }//LDC修改 原来0x00
        /// <summary>
        /// Map标定参数Part2 12格喷油时间的值
        /// </summary>
        public static byte MAPCalibrationParamsPart2_12Tinj { get { return 0x00; } }//LDC修改 原来0x01
        /// <summary>
        /// Map标定参数Part2 RPM与喷油时间映射的百分比值
        /// </summary>
        public static byte[] MAPCalibrationParamsPart2_MAPValue//
        {
            get { return new byte[] {0x02, 0x03,0x04,0x05,0x06,0x07,0x08,0x09,0x0A,0x0B,0x0C,0x0D }; }
        }//LDC修改 原来0x002, 0x003,0x04,0x05,0x06,0x07,0x08,0x09,0x0A,0x0B,0x0C,0x0D,0x0E
        /// <summary>
        /// Map标定参数Part2 汽油喷射曲线
        /// </summary>
        public static byte[] MAPCalibrationParamsPart2_PetrolCurve { get { return new byte[]{ 0x10,0x11,0x12,0x13,0x14,0x15,0x16,0x17}; } }
        /// <summary>
        /// Map标定参数Part2 2D汽油喷射曲线
        /// </summary>
        public static byte MAPCalibrationParamsPart2_2DPetrolCurve { get { return 0x1D; } }
        /// <summary>
        /// Map标定参数Part2 气体喷射曲线
        /// </summary>
        public static byte[] MAPCalibrationParamsPart2_GasCurve { get { return new byte[] { 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27 }; } }
        /// <summary>
        /// Map标定参数Part2 2D气体喷射曲线
        /// </summary>
        public static byte MAPCalibrationParamsPart2_2DGasCurve { get { return 0x2D; } }
        /// <summary>
        /// MAP标定数据锁定状态
        /// </summary>
        public static byte MAPCalibrationParamsPart2_DataLockStatus { get { return 0x30; } }
        #endregion

        /// <summary>
        /// 清除ECU错误代码
        /// </summary>
        public static byte SetECUErrorCodeClear { get { return 0x85; } }

        /// <summary>
        /// 设置喷轨测试命令
        /// </summary>
        public static byte SetInjectOnOff { get { return 0x86; } }//LDC 

        /// <summary>
        /// 设置自动标定命令
        /// </summary>
        public static byte SetAutoCalibrationCMD { get { return 0x87; } }
        /// <summary>
        /// OBD故障码清除命令
        /// </summary>
        public static byte SetODBErrorClear{ get { return 0x89; } }
        /// <summary>
        /// OBD故障码清除命令值
        /// </summary>
        public static byte SetODBErrorClear_Const { get { return 0xB4; } }
        /// <summary>
        /// 设置紧急燃气启动设置
        /// </summary>
        public static byte SetEmergencyStats { get { return 0x8A; } }
        /// <summary>
        /// 设置燃气保养提醒设置
        /// </summary>
        public static byte SetMaintainRemind { get { return 0x8B; } }

        #region 设置ECU设定参数
        /// <summary>
        /// 设置氧传感器
        /// </summary>
        public static byte SetECUSettingO2 { get { return 0x93; } }//LDC
        /// <summary>
        /// 喷射顺序提前
        /// </summary>
        public static byte SetAnticipateInjSetting { get { return 0xA9; } }
        /// <summary>
        /// 设置ECU设定参数Part1
        /// </summary>
        public static byte SetECUSettingPart1 { get { return 0x90; } }
        /// <summary>
        /// 设置ECU设定参数Part2 子命令 0x00（标志功能位） ：4 字节
        /// </summary>
        public static byte SetECUSettingPart2_SetFlag{ get { return 0x00; } }//LDC
        /// <summary>
        /// 设置ECU设定参数Part2 设置气缸数
        /// </summary>
        public static byte SetECUSettingPart2_SetCylinders { get { return 0x01; } }//LDC子命令 0x01（气缸数） ：单字节；//原0x00
        /// <summary>
        /// 设置ECU设定参数Part2 设置燃料类型
        /// </summary>
        public static byte SetECUSettingPart2_SetFuelType { get { return 0x01; } }
        /// <summary>
        /// 设置ECU设定参数Part2 设置喷射模式
        /// </summary>
        public static byte SetECUSettingPart2_SetInjectionMode { get { return 0x02; } }
        /// <summary>
        /// 设置ECU设定参数Part2 设置线圈数
        /// </summary>
        public static byte SetECUSettingPart2_SetCoilNums { get { return 0x03; } }
        /// <summary>
        /// 设置ECU设定参数Part2 设置辅助喷射模式
        /// </summary>
        public static byte SetECUSettingPart2_SetExtraInjectionMode { get { return 0x04; } }

        /// <summary>
        /// 设置ECU设定参数Part2 设置喷射起始时间
        /// </summary>
        public static byte SetECUSettingPart2_SetExtraInjectionIdentTime { get { return 0x05; } }
        /// <summary>
        /// 设置ECU设定参数Part2 设置转速信号源
        /// </summary>
        public static byte SetECUSettingPart2_SetRPMSource { get { return 0x02; } }//LDC 原来0x06
        /// <summary>
        /// 设置ECU设定参数Part2 转速信号门限电压
        /// </summary>
        public static byte SetECUSettingPart2_SetRPMVoltage { get { return 0x07; } }
        /// <summary>
        /// 设置ECU设定参数Part2 设置切换温度
        /// </summary>
        public static byte SetECUSettingPart2_SetSwitchTemp { get { return 0x04; } }//LDC 原来0x08
        /// <summary>
        /// 设置ECU设定参数Part2 设置切换转速
        /// </summary>
        public static byte SetECUSettingPart2_SetSwitchRPM { get { return 0x03; } }//LDC 原来0x09
        /// <summary>
        /// 设置ECU设定参数Part2 设置切换方式
        /// </summary>
        public static byte SetECUSettingPart2_SetSwitchMode { get { return 0x0A; } }
        /// <summary>
        /// 设置ECU设定参数Part2 设置切换延时
        /// </summary>
        public static byte SetECUSettingPart2_SetOverlapTimes { get { return 0x05; } }//LDC 原来0x0B
        /// <summary>
        /// 设置ECU设定参数Part2 设置顺序切换延时
        /// </summary>
        public static byte SetECUSettingPart2_SetOrderDelay { get { return 0x0C; } }
        /// <summary>
        /// 设置ECU设定参数Part2 设置减压器温度传感器类型
        /// </summary>
        public static byte SetECUSettingPart2_SetReducerTempSens { get { return 0x08; } }//   0x0D--- 0x08
        /// <summary>
        /// 设置ECU设定参数Part2 设置燃气温度传感器类型
        /// </summary>
        public static byte SetECUSettingPart2_SetGasTempSens { get { return 0x09; } }//0x0E-----09
        /// <summary>
        /// 设置ECU设定参数Part2 设置燃气工作压力
        /// </summary>
        public static byte SetECUSettingPart2_SetOperationalPress { get { return 0x0A; } }//LDC修改 0x0F改为
        /// <summary>
        /// 设置ECU设定参数Part2 设置最小工作压力
        /// </summary>
        public static byte SetECUSettingPart2_SetMinimumPress { get { return 0x0B; } }//LDC修改0x10》》  0x0B
        /// <summary>
        /// 设置ECU设定参数Part2 设置压力故障时间
        /// </summary>
        public static byte SetECUSettingPart2_SetPressErrorTime { get { return 0x0C; } }//LDC修改 0x11.... 0x0C

        /// <summary>
        /// 设置ECU设定参数Part2 设置燃气最低温度
        /// </summary>
        public static byte SetECUSettingPart2_SetMiniGasTemp { get { return 0x0D; } }//LDC修改 0x13 。。0x0D
        /// <summary>
        /// 设置ECU设定参数Part2 设置喷轨类型
        /// </summary>
        public static byte SetECUSettingPart2_SetInjectorType { get { return 0x0E; } }//LDC 原来0x14
        /// <summary>
        /// 设置ECU设定参数Part2 设置液位传感器类型
        /// </summary>
        public static byte SetECUSettingPart2_SetLevelIndicatorSens { get { return 0x0F; } }//LDC 15---- 0x0F
        /// <summary>
        /// 设置ECU设定参数Part2 设置液位传感器电压
        /// </summary>
        public static byte SetECUSettingPart2_SetGasLevel { get { return 0x10; } }//LDC 16------10
        /// <summary>
        /// 设置ECU设定参数Part2 设置喷油切断过渡时间
        /// </summary>
        public static byte SetECUSettingPart2_SetBackTransitionTm { get { return 0x11; } }
        #endregion

        #region 设置ECU设定拓展参数
        /// <summary>
        /// 设置ECU设定拓展参数Part1
        /// </summary>
        public static byte SetECUSettingExtraPart1 { get { return 0x91; } }//LDC 原来0x94
        /// <summary>
        /// 设置ECU设定拓展参数Part2 子命令 0x00（标志功能位） ：5 字节
        /// </summary>
        public static byte SetECUSettingExtraPart2_SetFlag { get { return 0x00; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 喷嘴正极驱动
        /// </summary>
        public static byte SetECUSettingExtraPart2_InjectorPositiveDriver { get { return 0x00; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 发动机类型
        /// </summary>
        public static byte SetECUSettingExtraPart2_EngineType { get { return 0x01; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 发动机热启动
        /// </summary>
        public static byte SetECUSettingExtraPart2_HotStart { get { return 0x02; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 马自达减弱
        /// </summary>
        public static byte SetECUSettingExtraPart2_Weak { get { return 0x03; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 加速加浓
        /// </summary>
        public static byte SetECUSettingExtraPart2_SpeedThicken { get { return 0x04; } }
        /// <summary>
        /// 子命令 0x05（额外喷射敏感度） ：双字节；
        /// </summary>
        public static byte SetECUSettingExtraPart2_SetExtrainjSensitivity { get { return 0x05; } }//LDC
        /// <summary>
        /// 子命令 0x06（额外喷射起始时间） ：双字节；
        /// </summary>
        public static byte SetECUSettingExtraPart2_SetExtraInjectionIdentTime { get { return 0x06; } }//LDC
        /// <summary>
        /// 设置ECU设定参数Part2 设置最低燃气转速
        /// </summary>
        public static byte SetECUSettingExtraPart2_SetMinGasRPM { get { return 0x07; } }//LDC
        /// <summary>
        /// 设置ECU设定拓展参数Part2 燃气高速运行时
        /// </summary>
        public static byte SetECUSettingExtraPart2_RunningGasStrategy { get { return 0x05; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 燃气高速运行转速条件(高)
        /// </summary>
        public static byte SetECUSettingExtraPart2_RunningRPM { get { return 0x09; } }//LDC
        /// <summary>
        /// 设置ECU设定拓展参数Part2 燃气高速运行转速条件（低）
        /// </summary>
        public static byte SetECUSettingExtraPart2_RunningMinRPM { get { return 0x08; } }//LDC

        /// <summary>
        /// 设置ECU设定拓展参数Part2 燃气高速运行喷油时间条件
        /// </summary>
        public static byte SetECUSettingExtraPart2_RunningTijiTime { get { return 0x0A; } }//LDC
        /// <summary>
        /// 设置ECU设定拓展参数Part2 燃气高速运行喷油补偿
        /// </summary>
        public static byte SetECUSettingExtraPart2_RunningOilCompensation { get { return 0x0B; } }//LDC
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器1类型
        /// </summary>
        public static byte SetECUSettingExtraPart2_Lambda1Type { get { return 0x09; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器2类型
        /// </summary>
        public static byte SetECUSettingExtraPart2_Lambda2Type { get { return 0x0A; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器1高电压
        /// </summary>
        public static byte SetECUSettingExtraPart2_Lambda1HV { get { return 0x0B; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器1低电压
        /// </summary>
        public static byte SetECUSettingExtraPart2_Lambda1LV { get { return 0x0C; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器2高电压
        /// </summary>
        public static byte SetECUSettingExtraPart2_Lambda2HV { get { return 0x0D; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器2低电压
        /// </summary>
        public static byte SetECUSettingExtraPart2_Lambda2LV { get { return 0x0E; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器仿真延时
        /// </summary>
        public static byte SetECUSettingExtraPart2_LambdaDelay { get { return 0x0F; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 氧传感器喷射学习数量
        /// </summary>
        public static byte SetECUSettingExtraPart2_LambdaInjectNum { get { return 0x10; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 自动诊断
        /// </summary>
        public static byte SetECUSettingExtraPart2_AutoDiagnosis { get { return 0x11; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 自动自适应（OBD自适应）
        /// </summary>
        public static byte SetECUSettingExtraPart2_AutoAdaptive { get { return 0x12; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 自适应范围
        /// </summary>
        public static byte SetECUSettingExtraPart2_AdaptiveRange { get { return 0x13; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 自适应自动停止
        /// </summary>
        public static byte SetECUSettingExtraPart2_AutoStopAdaptive { get { return 0x14; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 自适应协助
        /// </summary>
        public static byte SetECUSettingExtraPart2_AdaptiveAssist { get { return 0x15; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 ODB反向修正
        /// </summary>
        public static byte SetECUSettingExtraPart2_ODBReverseAssist { get { return 0x16; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 ODB适应范围
        /// </summary>
        public static byte SetECUSettingExtraPart2_ODBAdaptRange { get { return 0x17; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 Bank1矫正
        /// </summary>
        public static byte SetECUSettingExtraPart2_ODBBank1Correct { get { return 0x18; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 Bank2矫正
        /// </summary>
        public static byte SetECUSettingExtraPart2_ODBBank2Correct { get { return 0x19; } }
        /// <summary>
        /// 设置ECU设定拓展参数Part2 ODB故障码自动消除
        /// </summary>
        public static byte SetECUSettingExtraPart2_ODBErrorAutoClear { get { return 0x1A; } }
        #endregion

        #region 设置减压器温度修正
        /// <summary>
        /// 设置减压器温度修正Part1
        /// </summary>
        public static byte SetRedTempCorrectionPart1 { get { return 0xA4; } }//LDC 91---A4
        /// <summary>
        /// 设置减压器温度修正Part2 设置温度
        /// </summary>
        public static byte[] SetRedTempCorrectionPart2_Temp { get { return new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 }; } }
      //  public static byte[] SetRedTempCorrectionPart2_Temp { get { return new byte[] { 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 0x00 }; } }
        /// <summary>
        /// 设置减压器温度修正Part2 设置修正百分比
        /// </summary>
        public static byte[] SetRedTempCorrectionPart2_Correction { get { return new byte[] { 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,0x10 }; } }
       // public static byte[] SetRedTempCorrectionPart2_Correction { get { return new byte[] { 0x10, 0x0F, 0x0E, 0x0D, 0x0C, 0x0B, 0x0A, 0x09, 0x08 }; } }
        #endregion

        #region 设置燃气温度修正
        /// <summary>
        /// 设置燃气温度修正Part1
        /// </summary>
        public static byte SetGasTempCorrectionPart1 { get { return 0xA5; } }//LDC 92----A5
        /// <summary>
        /// 设置燃气温度修正Part2 设置温度
        /// </summary>
        public static byte[] SetGasTempCorrectionPart2_Temp { get { return new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 }; } }
        /// <summary>
        /// 设置燃气温度修正Part2 设置修正百分比
        /// </summary>
        public static byte[] SetGasTempCorrectionPart2_Correction { get { return new byte[] { 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10 }; } }
        #endregion

        #region 设置燃气压力修正
        public static byte SetGasPressPart1 { get { return 0xA6; } }
        public static byte[] SetGasPressPart2_Items { get { return new byte[] {0x01,0x02,0x03,0x04,0x05,0x06,0x07,0x08,0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0xF }; } }
      //  public static byte[] SetGasPressPart2_Items { get { return new byte[] { 0x0f, 0x0e, 0x0d, 0x0c, 0x0b, 0x0a, 0x09, 0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01 }; } }
        public static byte[] SetGasPressPart2_Correction { get { return new byte[] { 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F }; } }
       // public static byte[] SetGasPressPart2_Correction { get { return new byte[] {0x1f,0x1e,0x1d,0x1c,0x1b,0x1a,0x19,0x18,0x17,0x16,0x15,0x14,0x13,0x12,0x11}; } }
        #endregion
        /// <summary>
        /// 设定喷轨参数
        /// </summary>
        public static byte SetInjectorCorrectionSetting { get { return 0xA0; } }

        #region 设置ECU修正比例参数
        /// <summary>
        /// 设置ECU修正比例参数Part1
        /// </summary>
        public static byte SetECUCorrectionParamsPart1 { get { return 0xA1; } }
        /// <summary>
        /// 设置ECU修正比例参数Part2 修正比例
        /// </summary>
        public static byte[] SetECUCorrectionParamsPart2_Correction { get { return new byte[] {0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 }; } }
        /// <summary>
        /// 设置ECU修正比例参数Part2 10个坐标点的x轴位置
        /// </summary>
        public static byte SetECUCorrectionParamsPart2_Points { get { return 0x08; } }
        #endregion

        #region 设置MAP标定参数
        /// <summary>
        /// 设置MAP标定参数Part1
        /// </summary>
        public static byte SetMAPCalibrationParamsPart1 { get { return 0xA3; } }//LDC修改 原0xA2
        /// <summary>
        /// 设置Map标定参数Part2 12格RPM的值
        /// </summary>
        public static byte SetMAPCalibrationParamsPart2_12RPMs { get { return 0x01; } }//LDC 00---01
        /// <summary>
        /// 设置Map标定参数Part2 12格喷油时间的值
        /// </summary>
        public static byte SetMAPCalibrationParamsPart2_12Tinj { get { return 0x00; } }//LDC 01---00
        /// <summary>
        /// 设置Map标定参数Part2 RPM与喷油时间映射的百分比值
        /// </summary>
        public static byte[] SetMAPCalibrationParamsPart2_MAPValue
        {
            get { return new byte[] { 0x002, 0x003, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E }; }
        }
        /// <summary>
        /// 设置Map标定参数Part2 汽油喷射曲线
        /// </summary>
        public static byte[] SetMAPCalibrationParamsPart2_PetrolCurve { get { return new byte[] { 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17 }; } }
        /// <summary>
        /// 设置Map标定参数Part2 气体喷射曲线
        /// </summary>
        public static byte[] SetMAPCalibrationParamsPart2_GasCurve { get { return new byte[] { 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27 }; } }
        public static byte[] SetMAPCalibrationParamsPart2_DataLockStatus {get{return new byte[] {0x31,0x32,0x33,0x34,0x35,0x36,0x37,0x38,0x39,0x3A,0x3B,0x3C,0x3D}; }}
        /// <summary>
        /// 设置Map标定参数Part2 清除汽油曲线
        /// </summary>
        public static byte SetMAPCalibrationParamsPart2_ClearPetrolCurve { get { return 0x1F; } }
        /// <summary>
        /// 设置Map标定参数Part2 清除燃气曲线
        /// </summary>
        public static byte SetMAPCalibrationParamsPart2_ClearGasCurve { get { return 0x2F; } }
        #endregion

        /// <summary>
        /// OBD设置
        /// </summary>
        public static byte SetOBDSetting { get { return 0x94; } }
        /// <summary>
        /// 读取OBD设置
        /// </summary>
        public static byte GetOBDSetting { get { return 0x24; } }
        /// <summary>
        /// ECU参数复位
        /// </summary>
        public static byte SetECUReset { get { return 0xF0; } }
        /// <summary>
        /// 按键切换命令
        /// </summary>
        public static byte SetKeySwitch { get { return 0xF2; } }
        /// <summary>
        /// 设置ECU保存命令
        /// </summary>
        public static byte SetECUSave { get { return 0xF5; } }
        /// <summary>
        /// 输入密码
        /// </summary>
        public static byte InputPassword { get { return 0xF6; } }
        /// <summary>
        /// 设置密码
        /// </summary>
        public static byte SetPasssword { get { return 0xF7; } }
        /// <summary>
        /// 产品序列号写入命令
        /// </summary>
        public static byte SerialNumberWrite { get { return 0xF8; } }
        /// <summary>
        /// 产品日期写入命令
        /// </summary>
        public static byte ReleaseDateWrite { get { return 0xF9; } }
        /// <summary>
        /// ECU Restart命令
        /// </summary>
        public static byte ECURestart { get { return 0xFA; } }
        /// <summary>
        /// 预充气时间命令
        /// </summary>
        public static byte SetECUSettingExtraPart2_GasFillTime { get { return 0x10; } }
    }
}
