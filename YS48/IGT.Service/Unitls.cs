using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
namespace IGT.Service.Storage
{
    static class Unitls
    {
        /// <summary>
        /// 克隆ECUSetting
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        internal static Models.Settings.ECUSetting Clone(this Models.Settings.ECUSetting model)
        {
            var result = new Models.Settings.ECUSetting();
            result.BaseData = model.BaseData;
            result.ExtraData = model.ExtraData;
            result.AnticipateInjSetting = model.AnticipateInjSetting;
            result.Cylinders = model.Cylinders;
            result.FuelType = model.FuelType;
            result.O2Numbers = model.O2Numbers;
            result.InjectionMode = model.InjectionMode;
            result.Coils = model.Coils;
            result.RevolutionSignalType = model.RevolutionSignalType;
            result.RPMSource = model.RPMSource;
            result.RPMVoltage = model.RPMVoltage;
            result.SwitchTemp = model.SwitchTemp;
            result.SwitchRPM = model.SwitchRPM;
            result.SwitchMode = model.SwitchMode;
            result.OverlapTimes = model.OverlapTimes;
            result.OrderDelay = model.OrderDelay;
            result.ReducerTempSens = model.ReducerTempSens;
            result.GasTempSens = model.GasTempSens;
            result.OperationalPress = model.OperationalPress;
            result.MinimumPress = model.MinimumPress;
            result.PressErrorTime = model.PressErrorTime;
            result.MinOilEn = model.MinOilEn;
            result.MinGasRPM = model.MinGasRPM;
            result.MiniGasTemp = model.MiniGasTemp;
            result.InjectorType = model.InjectorType;
            result.LevelIndicatorSens = model.LevelIndicatorSens;
            result.GasLevel = model.GasLevel.ToArray();
            result.BackTransitionTm = model.BackTransitionTm;
            result.InjectorPositiveDriver = model.InjectorPositiveDriver;
            result.EngineType = model.EngineType;
            result.HotStart = model.HotStart;
            result.StartAndStop = model.StartAndStop;
            result.Valvetronik = model.Valvetronik;
            result.InjetPositiveDrive = model.InjetPositiveDrive;
            result.Weak = model.Weak;
            result.SpeedThicken = model.SpeedThicken;
            result.RunningGasStrategy = model.RunningGasStrategy;
            result.RunningMaxRPM = model.RunningMaxRPM;
            result.RunningMinRPM = model.RunningMinRPM;
            result.RunningTijiTime = model.RunningTijiTime;
            result.RunningOilCompensation = model.RunningOilCompensation;
            result.GasFillTime = model.GasFillTime;
            result.O2Type = model.O2Type;
            result.Lambda1Type = model.Lambda1Type;
            result.Lambda2Type = model.Lambda2Type;
            result.Lambda1HV = model.Lambda1HV;
            result.Lambda1LV = model.Lambda1LV;
            result.Lambda2HV = model.Lambda2HV;
            result.Lambda2LV = model.Lambda2LV;
            result.LambdaDelay = model.LambdaDelay;
            result.LambdaInjectNum = model.LambdaInjectNum;
            result.AutoDiagnosis = model.AutoDiagnosis;
            result.AutoAdaptive = model.AutoAdaptive;
            result.AdaptiveRange = model.AdaptiveRange;
            result.AutoStopAdaptive = model.AutoStopAdaptive;
            result.AdaptiveAssist = model.AdaptiveAssist;
            result.ODBReverseAssist = model.ODBReverseAssist;
            result.ODBAdaptRange = model.ODBAdaptRange;
            result.ODBBank1Correct = model.ODBBank1Correct;
            result.ODBBank2Correct = model.ODBBank2Correct;
            result.ODBErrorAutoClear = model.ODBErrorAutoClear;
            result.ExtraInjectionIdentTime = model.ExtraInjectionIdentTime;
            result.ExtraInjectionCutting = model.ExtraInjectionCutting;
            result.ExtrainjSensitivity = model.ExtrainjSensitivity;
            result.ExtraInjectionSensitivityEnable = model.ExtraInjectionSensitivityEnable;

            result.CompleteResetOfErrors = model.CompleteResetOfErrors;
            result.SelectiveResetOfErrors = model.SelectiveResetOfErrors;
            result.OBDStandard = model.OBDStandard;
            result.Reserve = model.Reserve;
            result.OBDType = model.OBDType;
            result.OBDAdaptiveRange = model.OBDAdaptiveRange;

            return result;
        }

        /// <summary>
        /// 转换为只读集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">源</param>
        /// <returns>转换后的只读集合</returns>
        internal static System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IList<T> source)
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<T>(source);
        }
    }
}
