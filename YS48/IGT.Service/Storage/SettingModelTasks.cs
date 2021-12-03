using IGT.Service.PLC;
using SerialPortsUtils.Agents;
using SerialPortsUtils.Agents.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace IGT.Service.Storage
{
    /// <summary>
    /// 任务 加载ECU设定
    /// </summary>
    internal class ECUSettingTask : ICustomTask<Models.Settings.ECUSetting>
    {
        private Models.Settings.ECUSetting Result;

        #region ICustomTask<ECUSetting> 成员
        public Models.Settings.ECUSetting GetResult()
        {
            return this.Result;
        }
        #endregion

        #region ICustomTask 成员

        public byte[] Execute(CustomActionContext context)
        {
            this.Result = context.IO.GetSettingFormPLC();
            return null;
        }
        #endregion
    }

    /// <summary>
    /// 任务 获取MAP标定参数
    /// </summary>
    internal class MAPCalibrationParamsTask : ICustomTask<Models.Settings.MAPCalibrationParams>
    {
        private Models.Settings.MAPCalibrationParams Result;

        #region ICustomTask<MAPCalibrationParams> 成员

        public Models.Settings.MAPCalibrationParams GetResult()
        {
            return this.Result;
        }

        #endregion

        #region ICustomTask 成员

        public byte[] Execute(CustomActionContext context)
        {
            this.Result = context.IO.GetMAPCalibrationParams(); return null;
        }

        #endregion
    }

    /// <summary>
    /// 任务 获取ECU修正比例
    /// </summary>
    internal class ECUCorrectionParamsTask : ICustomTask<Models.Settings.ECUCorrectionParams>
    {
        private Models.Settings.ECUCorrectionParams Result;
        #region ICustomTask<ECUCorrectionParams> 成员

        public Models.Settings.ECUCorrectionParams GetResult()
        {
            return this.Result;
        }

        #endregion

        #region ICustomTask 成员

        public byte[] Execute(CustomActionContext context)
        {
            this.Result = context.IO.GetECUCorrectionParams(); 
            return null;
        }

        #endregion
    }
    /// <summary>
    /// 任务 获取喷规修正参数
    /// </summary>
    internal class InjectorCorrectionSettingTask : ICustomTask<Models.Settings.InjectorCorrectionSetting>
    {
        private Models.Settings.InjectorCorrectionSetting Result;

        #region ICustomTask<InjectorCorrectionSetting> 成员

        Models.Settings.InjectorCorrectionSetting ICustomTask<Models.Settings.InjectorCorrectionSetting>.GetResult()
        {
            return this.Result;
        }

        #endregion

        #region ICustomTask 成员

        byte[] ICustomTask.Execute(CustomActionContext context)
        {
            this.Result = context.IO.GetInjectorCorrectionSetting(); return null;
        }

        #endregion
    }
    /// <summary>
    /// 任务 获取修正设定
    /// </summary>
    internal class CorrectSettingTask : ICustomTask<Models.Settings.CorrectSetting>
    {
        private Models.Settings.CorrectSetting Result;
        #region ICustomTask<CorrectSetting> 成员

        public Models.Settings.CorrectSetting GetResult()
        {
            return this.Result;
        }

        #endregion

        #region ICustomTask 成员

        public byte[] Execute(CustomActionContext context)
        {

            var model = new Models.Settings.CorrectSetting();
            model.GasTemp = context.IO.GetGasTempCorrectionSettings();
            model.RedTemp = context.IO.GetRedTempCorrectionSettings();
            model.GasPress = context.IO.GetGasPressCorrectionSettings();
            this.Result = model;
            return null;
        }

        #endregion
    }

    /// <summary>
    /// 任务 获取附加设定
    /// </summary>
    internal class AdditionalSettingsTask:ICustomTask<Models.Settings.AdditionalSettings>
    {

        #region ICustomTask<AdditionalSettings> 成员

        public Models.Settings.AdditionalSettings GetResult()
        {
            return this.Result;
        }

        #endregion

        #region ICustomTask 成员

        public byte[] Execute(CustomActionContext context)
        {
            var data1 = context.IO.SendAndRead(InstructionSet.GetEmergencyStartInfo).PacketData(1).ToArray();
            //var data2 = context.IO.SendAndRead(InstructionSet.GetMaintainInfo).PacketData(1).ToArray();
            this.Result = new Models.Settings.AdditionalSettings();
            if(data1[0] == 0x00)//LDC删除
                this.Result.EmergencyStartAllowed = false;
            else
                this.Result.EmergencyStartAllowed = true;
            this.Result.EmergencyStatsPerformed = data1[1];
            //this.Result.MaintainRemind = ValueConvert.MaintainRemindTypesFrom(data2[0]);
            //this.Result.MaintainTime = ValueConvert.MaintainTimeFrom(data2[1], data2[2]);
            return null;
        }
        
        #endregion
        Models.Settings.AdditionalSettings Result;
    }
    /// <summary>
    /// 任务 获取2D曲线
    /// </summary>
    internal class Tiji2DCurveTask : ICustomTask
    {
        #region ICustomTask 成员

        public byte[] Execute(CustomActionContext context)
        {
            var tt = context.IO.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, InstructionSet.MAPCalibrationParamsPart2_2DGasCurve);
            var gasCurve2D = tt.PacketData(2)
                .Select(m => m * 0.1f).ToArray();
            var petrolCurve2D = context.IO.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, InstructionSet.MAPCalibrationParamsPart2_2DPetrolCurve).PacketData(2)
                .Select(m => m * 0.1f).ToArray();
            context.Job.Content.Context= new Models.Feedback.Tiji2DCurve() { PetrolCurve2D = petrolCurve2D, GasCurve2D = gasCurve2D };
            return null;
        }

        #endregion
    }
    /// <summary>
    /// 任务 获取3D曲线
    /// </summary>
    internal class Tiji3DCurveTask : ICustomTask
    {
        #region ICustomTask 成员

        public byte[] Execute(CustomActionContext context)
        {
            var petrolCurve = InstructionSet.MAPCalibrationParamsPart2_PetrolCurve.Select(m =>
                context.IO.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, m).PacketData(2)
                .Select(m2 => ValueConvert.MapTableInjectionFrom(m2)).ToArray()).ToArray();
            var gasCurve = InstructionSet.MAPCalibrationParamsPart2_GasCurve.Select(m =>
                context.IO.SendAndRead(InstructionSet.MAPCalibrationParamsPart1, m).PacketData(2)
                .Select(m2 => ValueConvert.MapTableInjectionFrom(m2)).ToArray()).ToArray();
            context.Job.Content.Context = new Models.Feedback.Tiji3DCurve() { PetrolCurve = petrolCurve, GasCurve = gasCurve };
            return null;
        }

        #endregion
    }
}
