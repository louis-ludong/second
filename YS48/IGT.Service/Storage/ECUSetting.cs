using IGT.Models.Enums;
using IGT.Service.PLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
namespace IGT.Service.Storage
{
    /// <summary>
    /// ECU设定参数
    /// </summary>
    public class ECUSetting : IStorageModel<Models.Settings.ECUSetting>
    {
        public CorrectionSetting CorrectionSetting4UpdateGasPress=null;
        private PLCData storage;
        public ECUSetting(Models.Settings.ECUSetting eCUSetting,PLCData storage)
        {
            this.InnerModel = eCUSetting;
            this.GasLevel = new NotityArray<float>(eCUSetting.GasLevel);
            this.BaseData = new NotityArray<int>(eCUSetting.BaseData);
            this.ExtraData = new NotityArray<int>(eCUSetting.ExtraData);//ExtraData
            this.AnticipateInjSetting = new NotityArray<int>(eCUSetting.AnticipateInjSetting);
            this.AnticipateInjSetting.ItemChanged += AnticipateInjSetting_ItemChanged;
            this.GasLevel.ItemChanged += GasLevel_ItemChanged;
            this.storage = storage;
        }

        private void AnticipateInjSetting_ItemChanged(object sender, ItemChangedEventArgs e)
        {
            this.InnerModel.AnticipateInjSetting[e.ItemIndex] = this.AnticipateInjSetting[e.ItemIndex];
            if (!ChangesCollection.Contains("AnticipateInjSetting"))
                ChangesCollection.Add("AnticipateInjSetting"); ;
        }

        void GasLevel_ItemChanged(object sender, ItemChangedEventArgs e)
        {
            this.InnerModel.GasLevel[e.ItemIndex] = this.GasLevel[e.ItemIndex];
            if (!ChangesCollection.Contains("GasLevel"))
                ChangesCollection.Add("GasLevel"); ;
        }

        #region IStorageModel 成员
        
        public void Attach(Models.Settings.ECUSetting model)
        {
            for (int i = 0; i < this.BaseData.Count; i++)
            {
                this.BaseData[i] = model.BaseData[i];
            }
            for (int i = 0; i < this.ExtraData.Count; i++)
            {
                this.ExtraData[i] = model.ExtraData[i];
            }
            for (int i = 0; i < this.AnticipateInjSetting.Count; i++)
            {
                this.AnticipateInjSetting[i] = model.AnticipateInjSetting[i];
            }

            this.Cylinders = model.Cylinders;
            this.FuelType = model.FuelType;
            this.O2Numbers = model.O2Numbers;  //LDC    O2Numbers
            this.InjectionMode = model.InjectionMode;
            this.Coils = model.Coils;
            this.RevolutionSignalType = model.RevolutionSignalType;
            this.RPMInjectionSelect = model.RPMInjectionSelect;//       //LDC RPMInjectionSelect增加
            this.RPMSource = model.RPMSource;
            this.RPMVoltage = model.RPMVoltage;
            this.SwitchTemp = model.SwitchTemp;
            this.SwitchRPM = model.SwitchRPM;
            this.SwitchMode = model.SwitchMode;
            this.OverlapTimes = model.OverlapTimes;
            this.OrderDelay = model.OrderDelay;
            this.ReducerTempSens = model.ReducerTempSens;
            this.GasTempSens = model.GasTempSens;
            this.OperationalPress = model.OperationalPress;
            this.MinimumPress = model.MinimumPress;
            this.PressErrorTime = model.PressErrorTime;
            this.MinOilEn = model.MinOilEn;
            this.MinGasRPM = model.MinGasRPM;
            this.MiniGasTemp = model.MiniGasTemp;
            this.InjectorType = model.InjectorType;
            this.LevelIndicatorSens = model.LevelIndicatorSens;
            for (int i = 0; i < this.GasLevel.Count; i++)
            {
                this.GasLevel[i] = model.GasLevel[i];
            }
            this.BackTransitionTm = model.BackTransitionTm;
            this.InjectorPositiveDriver = model.InjectorPositiveDriver;
            this.EngineType = model.EngineType;
            this.HotStart = model.HotStart;//
            this.StartAndStop = model.StartAndStop;//
            this.Valvetronik = model.Valvetronik;//
            this.InjetPositiveDrive = model.InjetPositiveDrive;//InjetPositiveDrive
            this.Weak = model.Weak;
            this.SpeedThicken = model.SpeedThicken;
            this.RunningGasStrategy = model.RunningGasStrategy;
            this.RunningRPM = model.RunningMaxRPM;
            this.RunningMinRPM = model.RunningMinRPM;
            this.RunningTijiTime = model.RunningTijiTime;
            this.RunningOilCompensation = model.RunningOilCompensation;
            this.GasFillTime = model.GasFillTime;
            this.O2Type = model.O2Type;
            this.Lambda1Type = model.Lambda1Type;
            this.Lambda2Type = model.Lambda2Type;
            this.Lambda1HV = model.Lambda1HV;
            this.Lambda1LV = model.Lambda1LV;
            this.Lambda2HV = model.Lambda2HV;
            this.Lambda2LV = model.Lambda2LV;
            this.LambdaDelay = model.LambdaDelay;
            this.LambdaInjectNum = model.LambdaInjectNum;
            this.AutoDiagnosis = model.AutoDiagnosis;
            this.AutoAdaptive = model.AutoAdaptive;
            this.AdaptiveRange = model.AdaptiveRange;
            this.AutoStopAdaptive = model.AutoStopAdaptive;
            this.AdaptiveAssist = model.AdaptiveAssist;
            this.ODBReverseAssist = model.ODBReverseAssist;
            this.ODBAdaptRange = model.ODBAdaptRange;
            this.ODBBank1Correct = model.ODBBank1Correct;
            this.ODBBank2Correct = model.ODBBank2Correct;
            this.ODBErrorAutoClear = model.ODBErrorAutoClear;
            this.ExtraInjectionCutting = model.ExtraInjectionCutting;
            this.ExtrainjSensitivity = model.ExtrainjSensitivity;
            this.ExtraInjectionIdentTime = model.ExtraInjectionIdentTime;
            this.ExtraInjectionSensitivityEnable = model.ExtraInjectionSensitivityEnable;

            this.CompleteResetOfErrors = model.CompleteResetOfErrors;
            this.SelectiveResetOfErrors = model.SelectiveResetOfErrors;
            this.OBDStandard = model.OBDStandard;
            this.Reserve = model.Reserve;
            this.OBDType = model.OBDType;
            this.OBDAdaptiveRange = model.OBDAdaptiveRange;
        }
        public void CancelChanges()
        {
            ChangesCollection.Clear();
        }
        public Models.Settings.ECUSetting Detaching()
        {
            return InnerModel.Clone();
        }
        void IStorageModel.SaveChanges(SerialPortsUtils.Agents.Agent io)
        {
            System.Diagnostics.Debug.WriteLine("Begin apply modify on ECUSetting");
            foreach (var prop in ChangesCollection)
            {
                switch (prop)
                {
                    case "Cylinders":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetCylinders,
                            new byte[] { ValueConvert.CylindersValue(InnerModel.Cylinders) }); break;
                    case "FuelType":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetFuelType,
                             new byte[] { ValueConvert.FuleTypeValue(InnerModel.FuelType) });
                        //var r1 = io.SendAndRead(InstructionSet.GetECUSetting).PacketData(1).ToArray();
                        //this.InnerModel.OperationalPress = ValueConvert.OperationalPressFrom(r1[14], r1[15]);
                        //this.InnerModel.MinimumPress = ValueConvert.MinimumPressFrom(r1[16], r1[17]);
                        //storage.LoadItem(SettingItems.CorrectionSetting);
                        //if (FuleTypeChangeApply != null)
                        //    FuleTypeChangeApply(this, EventArgs.Empty);
                        break;
                    case "SetBaseFlag":        //"O2Numbers"               
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetFlag
                            , ValueConvert.IntToBy(InnerModel.BaseData)); 
                            break;
                    case "SetExtraFlag"://HotStart
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_SetFlag
                        , ValueConvert.IntToBy5(InnerModel.ExtraData)); 
                        break;//ExtraData
                    case "AnticipateInjSetting":
                        io.SendAndRead(InstructionSet.SetAnticipateInjSetting,
                             ValueConvert.IntToBy(InnerModel.AnticipateInjSetting)); 
                        break;
                    case "InjectionMode"://可删
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetInjectionMode
                        //    , new byte[] { ValueConvert.InjectionModeValue(InnerModel.InjectionMode) }); break;
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetFlag
                        //    , ValueConvert.InjectionModeValue(InnerModel.InjectionMode)); 
                            break;
                    case "Coils":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetCoilNums
                            , new byte[] { ValueConvert.CoilNumsValue(InnerModel.Coils) }); break;
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetCoilNums
                        //    , new byte[] { ValueConvert.CoilNumsValue(InnerModel.Coils) }); break;

                    //case "RevolutionSignalType"://RevolutionSignalTypeValue(Models.Enums.RevolutionSignalTypes sw)
                    //    System.Diagnostics.Debug.WriteLine("RevolutionSignalType");
                    //    io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetRPMSource
                    //        , new byte[] {ValueConvert.RevolutionSignalTypeValue(InnerModel.RevolutionSignalType)}); break;//
                    case "RPMType"://RPMType RPMInjectionSelect
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetRPMSource
                        //    , new byte[] { ValueConvert.RPMInjectionSelectValue(InnerModel.RPMInjectionSelect) }); break;
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetRPMSource
                            , new byte[] { ValueConvert.RPMType(InnerModel.RPMInjectionSelect,InnerModel.RevolutionSignalType,InnerModel.RPMSource) }); break;
                    //case "RPMSource":
                    //    io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetRPMSource
                    //        ,new byte[] { ValueConvert.RPMSourceValue(InnerModel.RPMSource) } ); break;


                    case "RPMVoltage":
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetRPMVoltage
                        //    , new byte[] { ValueConvert.RPMVoltageValue(InnerModel.RPMVoltage) });
                            break;
                    case "SwitchTemp":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetSwitchTemp
                            , new byte[] { ValueConvert.SingleTempValue(InnerModel.SwitchTemp) }); break;
                    case "SwitchRPM":
                    case "SwitchMode":
                           io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetSwitchRPM
                            , ValueConvert.SwitchRPMValue(InnerModel.SwitchRPM,InnerModel.SwitchMode)); break;
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetSwitchRPM
                        //    , ); break;//InnerModel.RevolutionSignalType
                    //case "SwitchMode":
                    //    io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetSwitchMode
                    //        , new byte[] { ValueConvert.SwitchModeValue(InnerModel.SwitchMode) }); break;
                    case "OverlapTimes":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetOverlapTimes
                            , new byte[] { ValueConvert.OverlapTimesValue(InnerModel.OverlapTimes) }); break;
                    case "OrderDelay":
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetOrderDelay
                        //    , new byte[] { ValueConvert.OrderDelayValue(InnerModel.OrderDelay) });
                            break;
                    case "ReducerTempSens":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetReducerTempSens
                            , new byte[] { ValueConvert.ReducerTempSensValue(InnerModel.ReducerTempSens) }); break;
                    case "GasTempSens":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetGasTempSens
                            , new byte[] { ValueConvert.GasTempSensValue(InnerModel.GasTempSens) }); break;
                    case "OperationalPress":
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetOperationalPress
                        //    , new byte[] { ValueConvert.OperationalPressValue(InnerModel.OperationalPress) });
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetOperationalPress
                              , ValueConvert.OperationalPressValue(InnerModel.OperationalPress));
                        //if (this.CorrectionSetting4UpdateGasPress != null)//需修改
                        //    this.CorrectionSetting4UpdateGasPress.UpdateGasPress(io.GetGasPressCorrectionSettings());
                        break;
                    case "MinimumPress":
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetMinimumPress
                        //    , new byte[] { ValueConvert.MinimumPressValue(InnerModel.MinimumPress) }); break;
                          io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetMinimumPress
                            , ValueConvert.MinimumPressValue(InnerModel.MinimumPress)); break;
                    case "PressErrorTime":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetPressErrorTime
                            , new byte[] { ValueConvert.PressErrorTimeValue(InnerModel.PressErrorTime) }); break;
                    //case "MinOilEn":
                    //     //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetFlag
                    //     //   , ValueConvert.MinOilEnValue(InnerModel.MinOilEn)); break;
                    case "MinGasRPM":
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_SetMinGasRPM
                            ,ValueConvert.MinGasRPMValue(InnerModel.MinGasRPM)); break;
                    case "MiniGasTemp":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetMiniGasTemp
                            , new byte[] { ValueConvert.SingleTempValue(InnerModel.MiniGasTemp) }); 
                            break;
                    case "InjectorType":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetInjectorType
                            , new byte[] { ValueConvert.InjectorTypeValue(InnerModel.InjectorType) }); break;
                    case "LevelIndicatorSens"://LDC
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetLevelIndicatorSens
                            , new byte[] { ValueConvert.LevelIndicatorSensValue(InnerModel.LevelIndicatorSens) });
                        //var data = io.SendAndRead(InstructionSet.GetECUSetting).PacketData(1).ToArray();
                        //this.GasLevel.AttactNoEvent(IGT.Service.PLC.ValueConvert.TwoBitKVFrom(data[24], data[25]
                        //    , data[26], data[27]
                        //    , data[28], data[29]
                        //    , data[30], data[31]));
                        break;
                    case "GasLevel":
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetGasLevel
                            , ValueConvert.GasLevelValue(InnerModel.GasLevel));
                            break;
                    case "BackTransitionTm":
                            if (InnerModel.BackTransitionTm > 0xff)
                                InnerModel.BackTransitionTm = 0;
                            io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetBackTransitionTm
                                , new byte[] { Convert.ToByte(InnerModel.BackTransitionTm) });
                            break;
                    case "InjectorPositiveDriver":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_InjectorPositiveDriver
                        //    , new byte[] { InnerModel.InjectorPositiveDriver ? (byte)0x01 : (byte)0x00 });
                            break;
                    case "EngineType":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_EngineType
                        //    , new byte[] { ValueConvert.EngineTypeValue(InnerModel.EngineType) }); 
                            break;
                    case "Weak":
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_Weak
                            , new byte[] { Convert.ToByte(InnerModel.Weak) }); break;
                    case "SpeedThicken"://加速加浓
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_SpeedThicken
                            , new byte[] { Convert.ToByte(InnerModel.SpeedThicken) });
                            break;
                    case "RunningGasStrategy"://可删
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_RunningGasStrategy
                        //    , new byte[] { ValueConvert.GasStrategiesValue(InnerModel.RunningGasStrategy) }); 
                            break;
                    case "RunningRPM"://高转速运行条件（高）
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_RunningRPM
                            ,  ValueConvert.RunningRPMValue(InnerModel.RunningMaxRPM) ); break;
                    case "RunningMinRPM"://高转速运行条件（低）
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_RunningMinRPM
                            , ValueConvert.RunningMinRPM(InnerModel.RunningMinRPM)); break;
                    case "RunningTijiTime":
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_RunningTijiTime
                            ,  ValueConvert.RunningTimeValue(InnerModel.RunningTijiTime)); break;
                    case "RunningOilCompensation":
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_RunningOilCompensation
                            , ValueConvert.RunningTimeValue(InnerModel.RunningOilCompensation)); break;//
                    case "GasFillTime":
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_GasFillTime
                            , new byte[]{Convert.ToByte(InnerModel.GasFillTime)}); break;//
                    //case "Lambda1Type":
                    //    //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_Lambda1Type
                    //    //    , new byte[] { ValueConvert.LambdaTypeValue(InnerModel.Lambda1Type) }); break;
                    //    io.SendAndRead(InstructionSet.SetECUSettingO2, ValueConvert.LambdaTypeValue(InnerModel.O2Type,
                    //        InnerModel.Lambda1Type, InnerModel.Lambda2Type)); break;
                    case "LambdaType":
                        io.SendAndRead(InstructionSet.SetECUSettingO2, ValueConvert.LambdaTypeValue(InnerModel.O2Type,
                            InnerModel.Lambda1Type,InnerModel.Lambda2Type)); 
                            break;
                    case "Lambda1HV":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_Lambda1HV
                        //    , new byte[] { ValueConvert.SingleVoltageValue(InnerModel.Lambda1HV) }); 
                            break;
                    case "Lambda1LV":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_Lambda1LV
                        //    , new byte[] { ValueConvert.SingleVoltageValue(InnerModel.Lambda1LV) }); 
                            break;
                    case "Lambda2HV":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_Lambda2HV
                        //    , new byte[] { ValueConvert.SingleVoltageValue(InnerModel.Lambda2HV) }); 
                            break;
                    case "Lambda2LV":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_Lambda2LV
                        //    , new byte[] { ValueConvert.SingleVoltageValue(InnerModel.Lambda2LV) }); 
                            break;
                    case "LambdaDelay":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_LambdaDelay
                        //    , new byte[] { Convert.ToByte(InnerModel.LambdaDelay) });
                            break;
                    case "LambdaInjectNum":
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_LambdaInjectNum
                            , new byte[] { Convert.ToByte(InnerModel.LambdaInjectNum) }); break;
                    case "AutoDiagnosis"://在标志位里了
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_AutoDiagnosis
                        //    , new byte[] { InnerModel.AutoDiagnosis ? (byte)0x01 : (byte)0x00 }); 
                            break;
                    case "AutoAdaptive":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_AutoAdaptive
                        //    , new byte[] { InnerModel.AutoAdaptive ? (byte)0x01 : (byte)0x00 }); 
                            break;
                    case "AdaptiveRange":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_AdaptiveRange
                        //    , new byte[] { Convert.ToByte(InnerModel.AdaptiveRange) }); 
                            break;
                    case "AutoStopAdaptive":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_AutoStopAdaptive
                        //    , new byte[] { (byte)(InnerModel.AutoStopAdaptive ? 0x01 : 0x00) }); 
                            break;
                    case "AdaptiveAssist":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_AdaptiveAssist
                        //    , new byte[] { (byte)(InnerModel.AdaptiveAssist ? 0x01 : 0x00) }); 
                            break;
                    case "ODBReverseAssist":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_ODBReverseAssist
                        //    , new byte[] { (byte)(InnerModel.ODBReverseAssist ? 0x01 : 0x00) }); 
                            break;
                    case "ODBAdaptRange":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_ODBAdaptRange
                        //    , new byte[] { Convert.ToByte(InnerModel.ODBAdaptRange) }); 
                            break;
                    case "ODBBank1Correct":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_ODBBank1Correct
                        //    , new byte[] { ValueConvert.ConvertToByteSafe(InnerModel.ODBBank1Correct) }); 
                            break;
                    case "ODBBank2Correct":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_ODBBank2Correct
                        //    , new byte[] { ValueConvert.ConvertToByteSafe(InnerModel.ODBBank2Correct) }); 
                            break;
                    case "ODBErrorAutoClear":
                        //io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_ODBErrorAutoClear
                        //    , new byte[] { ValueConvert.ODBErrorAutoClearValue(InnerModel.ODBErrorAutoClear) }); 
                            break;
                    case "ExtraInjectionMode":
                        //int temp1 = InnerModel.ExtraInjectionCutting ? 1 : 0;
                        //int temp2 = InnerModel.ExtraInjectionSensitivityEnable ? 10 : 0;
                        //byte[] eim_data = new byte[2];
                        //eim_data[0] = Convert.ToByte(temp1 | temp2);
                        //eim_data[1] = Convert.ToByte(InnerModel.ExtrainjSensitivity);
                        //io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetExtraInjectionMode, eim_data);
                        break;
                    //case "ExtraInjectionCutting":
                    //    io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_SetFlag
                    //        , ValueConvert.ExtraInjectionCuttingValue(InnerModel.ExtraInjectionCutting)); break;

                    case "ExtraInjectionSensitivityEnable"://可删
                        io.SendAndRead(InstructionSet.SetECUSettingPart1, InstructionSet.SetECUSettingPart2_SetFlag
                            , ValueConvert.ExtraInjectionSensitivityEnableValue(InnerModel.ExtraInjectionSensitivityEnable)); break;

                    case "ExtrainjSensitivity"://灵敏度可调
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_SetExtrainjSensitivity
                            , ValueConvert.ExtrainjSensitivityValue(InnerModel.ExtrainjSensitivity)); break;
                    case "ExtraInjectionIdentTime":
                        //byte[] eiit_data = ValueConvert.TwoBitTimeByusValue(InnerModel.ExtraInjectionIdentTime);
                        io.SendAndRead(InstructionSet.SetECUSettingExtraPart1, InstructionSet.SetECUSettingExtraPart2_SetExtraInjectionIdentTime,
                           ValueConvert.ExtraInjectionIdentTimeValue(InnerModel.ExtraInjectionIdentTime));
                        break;
                    case "OBDStandard":
                    case "OBDType":
                    case "OBDAdaptiveRange":
                        io.SendAndRead(InstructionSet.SetOBDSetting,
                           ValueConvert.SetOBDSettingValue(InnerModel.OBDStandard, InnerModel.Reserve, InnerModel.OBDType, InnerModel.OBDAdaptiveRange));
                        break;

                }
            }
            ChangesCollection.Clear();
            System.Diagnostics.Debug.WriteLine("End apply modify on ECUSetting");
        }

        #endregion



        #region IDisposable 成员

        public void Dispose()
        {
            this.InnerModel = null;
            ChangesCollection.Clear();
            ChangesCollection = null;
        }



        #endregion

        System.Collections.Specialized.StringCollection ChangesCollection = new System.Collections.Specialized.StringCollection();

        #region Model属性
        Models.Settings.ECUSetting InnerModel;

        /// <summary>
        /// 保存ECU基本参数的前四个字节
        /// </summary>
        //      public NotityArray<Single> GasLevel { get; set; }
        //public static byte[] BaseData { get; set; }
        public NotityArray<int> BaseData { get; set; }
        public NotityArray<int> ExtraData { get; set; }

        public NotityArray<int> AnticipateInjSetting { get; set; }


        /// <summary>
        /// 气缸数
        /// </summary>
        public Int32 Cylinders
        {
            get { return InnerModel.Cylinders; }
            set
            {
                if (InnerModel.Cylinders != value)
                {
                    InnerModel.Cylinders = value;
                    if (!ChangesCollection.Contains("Cylinders"))
                        ChangesCollection.Add("Cylinders");
                }
            }
        }

        /// <summary>
        /// 燃料类型
        /// </summary>
        public FuelTypes FuelType
        {
            get { return InnerModel.FuelType; }
            set
            {
                if (InnerModel.FuelType != value)
                {
                    InnerModel.FuelType = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }
        /// <summary>
        /// 氧传感器数量
        /// </summary>
        public Int32 O2Numbers
        {
            get { return InnerModel.O2Numbers; }
            set
            {
                if (InnerModel.O2Numbers != value)
                {
                    InnerModel.O2Numbers = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }
        /// <summary>
        /// 喷射模式
        /// </summary>
        public InjectionModes InjectionMode
        {
            get { return InnerModel.InjectionMode; }
            set
            {
                if (InnerModel.InjectionMode != value)
                {
                    InnerModel.InjectionMode = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))//InjectionMode
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }

        /// <summary>
        /// 线圈数量
        /// </summary>
        public Int32 Coils
        {
            get { return InnerModel.Coils; }
            set
            {
                if (InnerModel.Coils != value)
                {
                    InnerModel.Coils = value;
                    if (!ChangesCollection.Contains("Coils"))
                        ChangesCollection.Add("Coils");
                }
            }
        }

        /// <summary>
        /// 转速信号类型 LDC转速信号类型 增加 RevolutionSignalType
        /// </summary>

        public RevolutionSignalTypes RevolutionSignalType
        {
            get { return InnerModel.RevolutionSignalType; }
            set
            {
                if (InnerModel.RevolutionSignalType != value)
                {
                    InnerModel.RevolutionSignalType = value;
                    if (!ChangesCollection.Contains("RPMType"))
                        ChangesCollection.Add("RPMType");
                }
            }
        }
        /// <summary>
        /// 转速源选择  LDC RPMInjectionSelect增加
        /// </summary>
        public Boolean RPMInjectionSelect
        {
            get { return InnerModel.RPMInjectionSelect; }
            set
            {
                if (InnerModel.RPMInjectionSelect != value)
                {
                    InnerModel.RPMInjectionSelect = value;
                    if (!ChangesCollection.Contains("RPMType"))
                        ChangesCollection.Add("RPMType");
                }
            }
        }

        /// <summary>
        /// 转速信号源
        /// </summary>
        public RPMSources RPMSource
        {
            get { return InnerModel.RPMSource; }
            set
            {
                if (InnerModel.RPMSource != value)
                {
                    InnerModel.RPMSource = value;
                    if (!ChangesCollection.Contains("RPMType"))
                        ChangesCollection.Add("RPMType");
                }
            }
        }

        /// <summary>
        /// 转速信号门限电压
        /// </summary>
        public Single RPMVoltage
        {
            get { return InnerModel.RPMVoltage; }
            set
            {
                if (InnerModel.RPMVoltage != value)
                {
                    InnerModel.RPMVoltage = value;
                    if (!ChangesCollection.Contains("RPMVoltage"))
                        ChangesCollection.Add("RPMVoltage");
                }
            }
        }

        /// <summary>
        /// 切换温度
        /// </summary>
        public SByte SwitchTemp
        {
            get { return InnerModel.SwitchTemp; }
            set
            {
                if (InnerModel.SwitchTemp != value)
                {
                    InnerModel.SwitchTemp = value;
                    if (!ChangesCollection.Contains("SwitchTemp"))
                        ChangesCollection.Add("SwitchTemp");
                }
            }
        }
        /// <summary>
        /// 切换转速
        /// </summary>
        public Int32 SwitchRPM
        {
            get { return InnerModel.SwitchRPM; }
            set
            {
                if (InnerModel.SwitchRPM != value)
                {
                    InnerModel.SwitchRPM = value;
                    if (!ChangesCollection.Contains("SwitchRPM"))
                        ChangesCollection.Add("SwitchRPM");
                }
            }
        }

        /// <summary>
        /// 切换方式
        /// </summary>
        public SwitchModes SwitchMode
        {
            get { return InnerModel.SwitchMode; }
            set
            {
                if (InnerModel.SwitchMode != value)
                {
                    InnerModel.SwitchMode = value;
                    if (!ChangesCollection.Contains("SwitchMode"))
                        ChangesCollection.Add("SwitchMode");
                }
            }
        }

        /// <summary>
        /// 切换延时
        /// </summary>
        public Single OverlapTimes
        {
            get { return InnerModel.OverlapTimes; }
            set
            {
                if (InnerModel.OverlapTimes != value)
                {
                    InnerModel.OverlapTimes = value;
                    if (!ChangesCollection.Contains("OverlapTimes"))
                        ChangesCollection.Add("OverlapTimes");
                }
            }
        }

        /// <summary>
        /// 顺序切换延时
        /// </summary>
        public Int32 OrderDelay
        {
            get { return InnerModel.OrderDelay; }
            set
            {
                if (InnerModel.OrderDelay != value)
                {
                    InnerModel.OrderDelay = value;
                    if (!ChangesCollection.Contains("OrderDelay"))
                        ChangesCollection.Add("OrderDelay");
                }
            }
        }

        /// <summary>
        /// 预充气时间
        /// </summary>
        public int GasFillTime
        {
            get { return InnerModel.GasFillTime; }
            set
            {
                if (InnerModel.GasFillTime != value)
                {
                    InnerModel.GasFillTime = value;
                    if (!ChangesCollection.Contains("GasFillTime"))
                        ChangesCollection.Add("GasFillTime");
                }
            }
        }
        /// <summary>
        /// 减压器温度传感器
        /// </summary>
        public TempSensTypes ReducerTempSens
        {
            get { return InnerModel.ReducerTempSens; }
            set
            {
                if (InnerModel.ReducerTempSens != value)
                {
                    InnerModel.ReducerTempSens = value;
                    if (!ChangesCollection.Contains("ReducerTempSens"))
                        ChangesCollection.Add("ReducerTempSens");
                }
            }
        }

        /// <summary>
        /// 燃气温度传感器
        /// </summary>
        public TempSensTypes GasTempSens
        {
            get { return InnerModel.GasTempSens; }
            set
            {
                if (InnerModel.GasTempSens != value)
                {
                    InnerModel.GasTempSens = value;
                    if (!ChangesCollection.Contains("GasTempSens"))
                        ChangesCollection.Add("GasTempSens");
                }
            }
        }

        /// <summary>
        /// 燃气工作压力
        /// </summary>
        public Single OperationalPress
        {
            get { return InnerModel.OperationalPress; }
            set
            {
                if (InnerModel.OperationalPress != value)
                {
                    InnerModel.OperationalPress = value;
                    if (!ChangesCollection.Contains("OperationalPress"))
                        ChangesCollection.Add("OperationalPress");
                }
            }
        }

        /// <summary>
        /// 最小燃气压力
        /// </summary>
        public Single MinimumPress
        {
            get { return InnerModel.MinimumPress; }
            set
            {
                if (InnerModel.MinimumPress != value)
                {
                    InnerModel.MinimumPress = value;
                    if (!ChangesCollection.Contains("MinimumPress"))
                        ChangesCollection.Add("MinimumPress");
                }
            }
        }

        /// <summary>
        /// 压力故障时间
        /// </summary>
        public Int32 PressErrorTime
        {
            get { return InnerModel.PressErrorTime; }
            set
            {
                if (InnerModel.PressErrorTime != value)
                {
                    InnerModel.PressErrorTime = value;
                    if (!ChangesCollection.Contains("PressErrorTime"))
                        ChangesCollection.Add("PressErrorTime");
                }
            }
        }
        /// <summary>
        /// 最低转速转油
        /// </summary>
        public Boolean MinOilEn
        {
            get { return InnerModel.MinOilEn; }
            set
            {
                if (InnerModel.MinOilEn != value)
                {
                    InnerModel.MinOilEn = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }
        /// <summary>
        /// 最低燃气转速
        /// </summary>
        public Int32 MinGasRPM
        {
            get { return InnerModel.MinGasRPM; }
            set
            {
                if (InnerModel.MinGasRPM != value)
                {
                    InnerModel.MinGasRPM = value;
                    if (!ChangesCollection.Contains("MinGasRPM"))
                        ChangesCollection.Add("MinGasRPM");
                }
            }
        }

        /// <summary>
        /// 燃气最低温度
        /// </summary>
        public SByte MiniGasTemp
        {
            get { return InnerModel.MiniGasTemp; }
            set
            {
                if (InnerModel.MiniGasTemp != value)
                {
                    InnerModel.MiniGasTemp = value;
                    if (!ChangesCollection.Contains("MiniGasTemp"))
                        ChangesCollection.Add("MiniGasTemp");
                }
            }
        }

        /// <summary>
        /// 喷轨类型
        /// </summary>
        public InjectorTypes InjectorType
        {
            get { return InnerModel.InjectorType; }
            set
            {
                if (InnerModel.InjectorType != value)
                {
                    InnerModel.InjectorType = value;
                    if (!ChangesCollection.Contains("InjectorType"))
                        ChangesCollection.Add("InjectorType");
                }
            }
        }

        /// <summary>
        /// 液位传感器类型
        /// </summary>
        public LevelIndicatorSensTypes LevelIndicatorSens
        {
            get { return InnerModel.LevelIndicatorSens; }
            set
            {
                if (InnerModel.LevelIndicatorSens != value)
                {
                    InnerModel.LevelIndicatorSens = value;
                    if (!ChangesCollection.Contains("LevelIndicatorSens"))
                        ChangesCollection.Add("LevelIndicatorSens");
                }
            }
        }

        /// <summary>
        /// 液位传感器电压
        /// </summary>
        public NotityArray<Single> GasLevel { get; set; }

        public int BackTransitionTm
        {
            get { return InnerModel.BackTransitionTm; }
            set
            {
                if (InnerModel.BackTransitionTm != value)
                {
                    InnerModel.BackTransitionTm = value;
                    if (!ChangesCollection.Contains("BackTransitionTm"))
                        ChangesCollection.Add("BackTransitionTm");
                }
            }
        }

        public Boolean InjectorPositiveDriver
        {
            get { return InnerModel.InjectorPositiveDriver; }
            set
            {
                if (InnerModel.InjectorPositiveDriver != value)
                {
                    InnerModel.InjectorPositiveDriver = value;
                    if (!ChangesCollection.Contains("InjectorPositiveDriver"))
                        ChangesCollection.Add("InjectorPositiveDriver");
                }
            }
        }

        /// <summary>
        /// 发动机类型
        /// </summary>
        public EngineTypes EngineType
        {
            get { return InnerModel.EngineType; }
            set
            {
                if (InnerModel.EngineType != value)
                {
                    InnerModel.EngineType = value;
                    if (!ChangesCollection.Contains("EngineType"))
                        ChangesCollection.Add("EngineType");
                }
            }
        }

        /// <summary>
        /// 发动机热启动
        /// </summary>
        public Boolean HotStart
        {
            get { return InnerModel.HotStart; }
            set
            {
                if (InnerModel.HotStart != value)
                {
                    InnerModel.HotStart = value;
                    if (!ChangesCollection.Contains("SetExtraFlag"))
                        ChangesCollection.Add("SetExtraFlag");
                }
            }
        }
        /// <summary>
        /// Start and Stop
        /// </summary>
        public Boolean StartAndStop
        {
            get { return InnerModel.StartAndStop; }
            set
            {
                if (InnerModel.StartAndStop != value)
                {
                    InnerModel.StartAndStop = value;
                    if (!ChangesCollection.Contains("SetExtraFlag"))
                        ChangesCollection.Add("SetExtraFlag");
                }
            }
        }
        /// <summary>
        /// Valvetronik
        /// </summary>
        public Boolean Valvetronik
        {
            get { return InnerModel.Valvetronik; }
            set
            {
                if (InnerModel.Valvetronik != value)
                {
                    InnerModel.Valvetronik = value;
                    if (!ChangesCollection.Contains("SetExtraFlag"))
                        ChangesCollection.Add("SetExtraFlag");
                }
            }
        }
        /// <summary>
        /// 喷油嘴正极驱动
        /// </summary>
        public Boolean InjetPositiveDrive
        {
            get { return InnerModel.InjetPositiveDrive; }
            set
            {
                if (InnerModel.InjetPositiveDrive != value)
                {
                    InnerModel.InjetPositiveDrive = value;
                    if (!ChangesCollection.Contains("SetExtraFlag"))
                        ChangesCollection.Add("SetExtraFlag");
                }
            }
        }





        /// <summary>
        /// 马自达减弱
        /// </summary>
        public Int32 Weak
        {
            get { return InnerModel.Weak; }
            set
            {
                if (InnerModel.Weak != value)
                {
                    InnerModel.Weak = value;
                    if (!ChangesCollection.Contains("Weak"))
                        ChangesCollection.Add("Weak");
                }
            }
        }

        /// <summary>
        /// 加速加浓
        /// </summary>
        public Int32 SpeedThicken
        {
            get { return InnerModel.SpeedThicken; }
            set
            {
                if (InnerModel.SpeedThicken != value)
                {
                    InnerModel.SpeedThicken = value;
                    if (!ChangesCollection.Contains("SpeedThicken"))
                        ChangesCollection.Add("SpeedThicken");
                }
            }
        }

        /// <summary>
        /// 燃气高速运行时
        /// </summary>
        public GasStrategies RunningGasStrategy
        {
            get { return InnerModel.RunningGasStrategy; }
            set
            {
                if (InnerModel.RunningGasStrategy != value)
                {
                    InnerModel.RunningGasStrategy = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }

        /// <summary>
        /// 燃气高速运行转速条件(高)
        /// </summary>
        public Int32 RunningRPM
        {
            get { return InnerModel.RunningMaxRPM; }
            set
            {
                if (InnerModel.RunningMaxRPM != value)
                {
                    InnerModel.RunningMaxRPM = value;
                    if (!ChangesCollection.Contains("RunningRPM"))
                        ChangesCollection.Add("RunningRPM");
                }
            }
        }        /// <summary>
        /// 燃气高速运行转速条件（低）
        /// </summary>
        public Int32 RunningMinRPM
        {
            get { return InnerModel.RunningMinRPM; }
            set
            {
                if (InnerModel.RunningMinRPM != value)
                {
                    InnerModel.RunningMinRPM = value;
                    if (!ChangesCollection.Contains("RunningMinRPM"))
                        ChangesCollection.Add("RunningMinRPM");
                }
            }
        }
        /// <summary>
        /// 燃气高速运行喷油时间条件
        /// </summary>
        public float RunningTijiTime
        {
            get { return InnerModel.RunningTijiTime; }
            set
            {
                if (InnerModel.RunningTijiTime != value)
                {
                    InnerModel.RunningTijiTime = value;
                    if (!ChangesCollection.Contains("RunningTijiTime"))
                        ChangesCollection.Add("RunningTijiTime");
                }
            }
        }

        /// <summary>
        /// 燃气高速运行喷油补偿
        /// </summary>
        public float RunningOilCompensation
        {
            get { return InnerModel.RunningOilCompensation; }
            set
            {
                if (InnerModel.RunningOilCompensation != value)
                {
                    InnerModel.RunningOilCompensation = value;
                    if (!ChangesCollection.Contains("RunningOilCompensation"))
                        ChangesCollection.Add("RunningOilCompensation");
                }
            }
        }
        /// <summary>
        /// 氧传感器类型
        /// </summary>
        public LambdaTypes O2Type
        {
            get { return InnerModel.O2Type; }
            set
            {
                if (InnerModel.O2Type != value)
                {
                    InnerModel.O2Type = value;
                    if (!ChangesCollection.Contains("LambdaType"))
                        ChangesCollection.Add("LambdaType");
                }
            }
        }
        /// <summary>
        /// 氧传感器1类型
        /// </summary>
        public LambdaTypes Lambda1Type
        {
            get { return InnerModel.Lambda1Type; }
            set
            {
                if (InnerModel.Lambda1Type != value)
                {
                    InnerModel.Lambda1Type = value;
                    if (!ChangesCollection.Contains("LambdaType"))
                        ChangesCollection.Add("LambdaType");
                }
            }
        }

        /// <summary>
        /// 氧传感器2类型
        /// </summary>
        public LambdaTypes Lambda2Type
        {
            get { return InnerModel.Lambda2Type; }
            set
            {
                if (InnerModel.Lambda2Type != value)
                {
                    InnerModel.Lambda2Type = value;
                    if (!ChangesCollection.Contains("LambdaType"))
                        ChangesCollection.Add("LambdaType");
                }
            }
        }

        /// <summary>
        /// 氧传感器1高电压
        /// </summary>
        public float Lambda1HV
        {
            get { return InnerModel.Lambda1HV; }
            set
            {
                if (InnerModel.Lambda1HV != value)
                {
                    InnerModel.Lambda1HV = value;
                    if (!ChangesCollection.Contains("Lambda1HV"))
                        ChangesCollection.Add("Lambda1HV");
                }
            }
        }

        /// <summary>
        /// 氧传感器1低电压
        /// </summary>
        public float Lambda1LV
        {
            get { return InnerModel.Lambda1LV; }
            set
            {
                if (InnerModel.Lambda1LV != value)
                {
                    InnerModel.Lambda1LV = value;
                    if (!ChangesCollection.Contains("Lambda1LV"))
                        ChangesCollection.Add("Lambda1LV");
                }
            }
        }

        /// <summary>
        /// 氧传感器2高电压
        /// </summary>
        public float Lambda2HV
        {
            get { return InnerModel.Lambda2HV; }
            set
            {
                if (InnerModel.Lambda2HV != value)
                {
                    InnerModel.Lambda2HV = value;
                    if (!ChangesCollection.Contains("Lambda2HV"))
                        ChangesCollection.Add("Lambda2HV");
                }
            }
        }

        /// <summary>
        /// 氧传感器2低电压
        /// </summary>
        public float Lambda2LV
        {
            get { return InnerModel.Lambda2LV; }
            set
            {
                if (InnerModel.Lambda2LV != value)
                {
                    InnerModel.Lambda2LV = value;
                    if (!ChangesCollection.Contains("Lambda2LV"))
                        ChangesCollection.Add("Lambda2LV");
                }
            }
        }

        /// <summary>
        /// 氧传感器仿真延时
        /// </summary>
        public Int32 LambdaDelay
        {
            get { return InnerModel.LambdaDelay; }
            set
            {
                if (InnerModel.LambdaDelay != value)
                {
                    InnerModel.LambdaDelay = value;
                    if (!ChangesCollection.Contains("LambdaDelay"))
                        ChangesCollection.Add("LambdaDelay");
                }
            }
        }

        /// <summary>
        /// 氧传感器喷射学习数量
        /// </summary>
        public Int32 LambdaInjectNum
        {
            get { return InnerModel.LambdaInjectNum; }
            set
            {
                if (InnerModel.LambdaInjectNum != value)
                {
                    InnerModel.LambdaInjectNum = value;
                    if (!ChangesCollection.Contains("LambdaInjectNum"))
                        ChangesCollection.Add("LambdaInjectNum");
                }
            }
        }

        /// <summary>
        /// 自动诊断
        /// </summary>
        public Boolean AutoDiagnosis
        {
            get { return InnerModel.AutoDiagnosis; }
            set
            {
                if (InnerModel.AutoDiagnosis != value)
                {
                    InnerModel.AutoDiagnosis = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }

        /// <summary>
        /// 自动自适应（OBD自适应）
        /// </summary>
        public Boolean AutoAdaptive
        {
            get { return InnerModel.AutoAdaptive; }
            set
            {
                if (InnerModel.AutoAdaptive != value)
                {
                    InnerModel.AutoAdaptive = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }

        /// <summary>
        /// 自适应范围
        /// </summary>
        public Int32 AdaptiveRange
        {
            get { return InnerModel.AdaptiveRange; }
            set
            {
                if (InnerModel.AdaptiveRange != value)
                {
                    InnerModel.AdaptiveRange = value;
                    if (!ChangesCollection.Contains("AdaptiveRange"))
                        ChangesCollection.Add("AdaptiveRange");
                }
            }
        }

        /// <summary>
        /// 自适应自动停止
        /// </summary>
        public Boolean AutoStopAdaptive
        {
            get { return InnerModel.AutoStopAdaptive; }
            set
            {
                if (InnerModel.AutoStopAdaptive != value)
                {
                    InnerModel.AutoStopAdaptive = value;
                    if (!ChangesCollection.Contains("AutoStopAdaptive"))
                        ChangesCollection.Add("AutoStopAdaptive");
                }
            }
        }

        /// <summary>
        /// 自适应协助
        /// </summary>
        public Boolean AdaptiveAssist
        {
            get { return InnerModel.AdaptiveAssist; }
            set
            {
                if (InnerModel.AdaptiveAssist != value)
                {
                    InnerModel.AdaptiveAssist = value;
                    if (!ChangesCollection.Contains("AdaptiveAssist"))
                        ChangesCollection.Add("AdaptiveAssist");
                }
            }
        }

        /// <summary>
        /// 反向修正
        /// </summary>
        public Boolean ODBReverseAssist
        {
            get { return InnerModel.ODBReverseAssist; }
            set
            {
                if (InnerModel.ODBReverseAssist != value)
                {
                    InnerModel.ODBReverseAssist = value;
                    if (!ChangesCollection.Contains("ODBReverseAssist"))
                        ChangesCollection.Add("ODBReverseAssist");
                }
            }
        }

        /// <summary>
        /// ODB适应范围
        /// </summary>
        public Int32 ODBAdaptRange
        {
            get { return InnerModel.ODBAdaptRange; }
            set
            {
                if (InnerModel.ODBAdaptRange != value)
                {
                    InnerModel.ODBAdaptRange = value;
                    if (!ChangesCollection.Contains("ODBAdaptRange"))
                        ChangesCollection.Add("ODBAdaptRange");
                }
            }
        }

        /// <summary>
        /// ODB Bank1矫正
        /// </summary>
        public sbyte ODBBank1Correct
        {
            get { return InnerModel.ODBBank1Correct; }
            set
            {
                if (InnerModel.ODBBank1Correct != value)
                {
                    InnerModel.ODBBank1Correct = value;
                    if (!ChangesCollection.Contains("ODBBank1Correct"))
                        ChangesCollection.Add("ODBBank1Correct");
                }
            }
        }

        /// <summary>
        /// ODB Bank2矫正
        /// </summary>
        public sbyte ODBBank2Correct
        {
            get { return InnerModel.ODBBank2Correct; }
            set
            {
                if (InnerModel.ODBBank2Correct != value)
                {
                    InnerModel.ODBBank2Correct = value;
                    if (!ChangesCollection.Contains("ODBBank2Correct"))
                        ChangesCollection.Add("ODBBank2Correct");
                }
            }
        }

        /// <summary>
        /// OBD故障码自动消除
        /// </summary>
        public ErroClearLevels ODBErrorAutoClear
        {
            get { return InnerModel.ODBErrorAutoClear; }
            set
            {
                if (InnerModel.ODBErrorAutoClear != value)
                {
                    InnerModel.ODBErrorAutoClear = value;
                    if (!ChangesCollection.Contains("ODBErrorAutoClear"))
                        ChangesCollection.Add("ODBErrorAutoClear");
                }
            }
        }

        /// <summary>
        /// 额外喷射断开
        /// </summary>
        public bool ExtraInjectionCutting
        {
            get { return InnerModel.ExtraInjectionCutting; }
            set
            {
                if (InnerModel.ExtraInjectionCutting != value)
                {
                    InnerModel.ExtraInjectionCutting = value;
                    if (!ChangesCollection.Contains("SetExtraFlag"))//ExtraInjectionMod
                        ChangesCollection.Add("SetExtraFlag");//ExtraInjectionMod
                }
            }
        }
        /// <summary>
        /// 辅助喷射敏感度使能
        /// </summary>
        public bool ExtraInjectionSensitivityEnable
        {
            get { return InnerModel.ExtraInjectionSensitivityEnable; }
            set
            {
                if (InnerModel.ExtraInjectionSensitivityEnable != value)
                {
                    InnerModel.ExtraInjectionSensitivityEnable = value;
                    if (!ChangesCollection.Contains("SetBaseFlag"))
                        ChangesCollection.Add("SetBaseFlag");
                }
            }
        }

        /// <summary>
        /// 辅助喷射起始时间
        /// </summary>
        public float ExtrainjSensitivity//LDC int----float
        {
            get { return InnerModel.ExtrainjSensitivity; }
            set
            {
                if (InnerModel.ExtrainjSensitivity != value)
                {
                    InnerModel.ExtrainjSensitivity = value;
                    if (!ChangesCollection.Contains("ExtrainjSensitivity"))//ExtraInjectionMode
                        ChangesCollection.Add("ExtrainjSensitivity");//ExtraInjectionMode
                }
            }
        }

        /// <summary>
        /// 灵敏度可调
        /// </summary>
        public float ExtraInjectionIdentTime
        {
            get { return InnerModel.ExtraInjectionIdentTime; }
            set
            {
                if (InnerModel.ExtraInjectionIdentTime != value)
                {
                    InnerModel.ExtraInjectionIdentTime = value;
                    if (!ChangesCollection.Contains("ExtraInjectionIdentTime"))
                        ChangesCollection.Add("ExtraInjectionIdentTime");
                }
            }
        }
        /// <summary>
        /// 1 字节bit4：OBD 完成故障错误复位有效, 0-取消, 1-选中；
        /// </summary>
        public bool CompleteResetOfErrors
        {
            get { return InnerModel.CompleteResetOfErrors; }
            set
            {
                if (InnerModel.CompleteResetOfErrors != value)
                {
                    InnerModel.CompleteResetOfErrors = value;
                    if (!ChangesCollection.Contains("SetExtraFlag"))
                        ChangesCollection.Add("SetExtraFlag");
                }
            }
        }
        /// <summary>
        ///1 字节bit7：OBD 使用选择性错误复位, 0-取消, 1-选中；
        /// <summary>
        public bool SelectiveResetOfErrors
        {
            get { return InnerModel.SelectiveResetOfErrors; }
            set
            {
                if (InnerModel.SelectiveResetOfErrors != value)
                {
                    InnerModel.SelectiveResetOfErrors = value;
                    if (!ChangesCollection.Contains("SetExtraFlag"))
                        ChangesCollection.Add("SetExtraFlag");
                }
            }
        }
        /// <summary>
        /// OBD标准
        /// </summary>
        public Models.Enums.OBDStandard OBDStandard
        {
            get { return InnerModel.OBDStandard; }
            set
            {
                if (InnerModel.OBDStandard != value)
                {
                    InnerModel.OBDStandard = value;
                    if (!ChangesCollection.Contains("OBDStandard"))
                        ChangesCollection.Add("OBDStandard");
                }
            }
        }
        /// <summary>
        /// 保留
        /// </summary>
        public int Reserve
        {
            get { return InnerModel.Reserve; }
            set
            {
                if (InnerModel.Reserve != value)
                {
                    InnerModel.Reserve = value;
                    if (!ChangesCollection.Contains("Reserve"))
                        ChangesCollection.Add("Reserve");
                }
            }
        }


        /// <summary>
        /// OBD类型
        /// </summary>
        public Models.Enums.OBDTypes OBDType
        {
            get { return InnerModel.OBDType; }
            set
            {
                if (InnerModel.OBDType != value)
                {
                    InnerModel.OBDType = value;
                    if (!ChangesCollection.Contains("OBDType"))
                        ChangesCollection.Add("OBDType");
                }
            }
        }
        /// <summary>
        /// OBD自适应范围
        /// </summary>
        public int OBDAdaptiveRange
        {
            get { return InnerModel.OBDAdaptiveRange; }
            set
            {
                if (InnerModel.OBDAdaptiveRange != value)
                {
                    InnerModel.OBDAdaptiveRange = value;
                    if (!ChangesCollection.Contains("OBDAdaptiveRange"))
                        ChangesCollection.Add("OBDAdaptiveRange");
                }
            }
        }




        #endregion
        public event EventHandler FuleTypeChangeApply;
    }
}
