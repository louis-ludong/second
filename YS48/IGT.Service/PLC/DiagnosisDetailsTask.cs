using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace IGT.Service.PLC
{
    /// <summary>
    /// 任务-获取诊断信息
    /// </summary>
    class DiagnosisDetailsTask : ICustomTask
    {
        private Device PLC;
        public DiagnosisDetailsTask(Device plc)
        {
            this.PLC = plc;
        }
        #region ICustomTask 成员

        public byte[] Execute(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            var temp = GetInjectTimeTime(context);
            var temp2 = GetECUTime(context);
            Models.Feedback.DiagnosisDetails model = new Models.Feedback.DiagnosisDetails();
            model.InjectTimes = temp;
            model.ECUWorkTime = temp2;
            model.InjectOnOffs = GetInjectOnOff(context);
            SetECUErrors(context, model);
            var data = context.IO.SendAndRead(InstructionSet.GetInjectOnOff).PacketData(1).ToArray();
            var b1 = new Models.Feedback.Bank<bool[]>() { Name = "Bank1" };
            b1.Data = ValueConvert.InjectOnOffFrom(data[0]);
            //var b2 = new Models.Feedback.Bank<bool[]>() { Name = "Bank2" };
            //b2.Data = ValueConvert.InjectOnOffFrom(data[1]);
            model.InjectOnOffs = new Models.Feedback.Bank<bool[]>[] { b1 };//, b2
            model.OnOffRaw = data.Take(2).ToArray();//返回前面两个元素   OnOffRaw是InjectOnOffs标记集合
            context.Job.Content.Context = model;
            return null;
        }
        #endregion
        private Models.Feedback.InjectTime[] GetInjectTimeTime(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            if (this.PLC.DeviceInfo.HardInof.ECUExtension == false)
            {
                var data1 = context.IO.SendAndRead(InstructionSet.GetInjectTimePart1).PacketData(1).ToArray();
                var model1 = new Models.Feedback.InjectTime() { Bank = "Bank1" };
                model1.Pertrol = new float[]{ ValueConvert.TwoBitTimeByusFrom(data1[0], data1[1])
                    ,ValueConvert.TwoBitTimeByusFrom(data1[2], data1[3])
                    ,ValueConvert.TwoBitTimeByusFrom(data1[4], data1[5])
                    ,ValueConvert.TwoBitTimeByusFrom(data1[6], data1[7])};
                model1.Gas = new float[]{ ValueConvert.TwoBitTimeByusFrom(data1[8], data1[9])
                    , ValueConvert.TwoBitTimeByusFrom(data1[10], data1[11])
                    , ValueConvert.TwoBitTimeByusFrom(data1[12], data1[13])
                    , ValueConvert.TwoBitTimeByusFrom(data1[14], data1[15])};
                return new Models.Feedback.InjectTime[] { model1, null };
            }
            else
            {//context.IO.SendAndRead(InstructionSet.GetInjectTimePart1, InstructionSet.GetInjectTimePart2_Bank2).PacketData(2).ToArray();
                var data2 = context.IO.SendAndRead(InstructionSet.GetInjectTimePart1).PacketData(1).ToArray();
                var model2 = new Models.Feedback.InjectTime() { Bank = "Bank2" };
                model2.Pertrol = new float[]{ ValueConvert.TwoBitTimeByusFrom(data2[0], data2[1])
                ,ValueConvert.TwoBitTimeByusFrom(data2[2], data2[3])
                ,ValueConvert.TwoBitTimeByusFrom(data2[4], data2[5])
                ,ValueConvert.TwoBitTimeByusFrom(data2[6], data2[7])
                ,ValueConvert.TwoBitTimeByusFrom(data2[16], data2[17])
                , ValueConvert.TwoBitTimeByusFrom(data2[18], data2[19])
                , ValueConvert.TwoBitTimeByusFrom(data2[20], data2[21])
                , ValueConvert.TwoBitTimeByusFrom(data2[22], data2[23])};
                model2.Gas = new float[]{ ValueConvert.TwoBitTimeByusFrom(data2[8], data2[9])
                , ValueConvert.TwoBitTimeByusFrom(data2[10], data2[11])
                , ValueConvert.TwoBitTimeByusFrom(data2[12], data2[13])
                , ValueConvert.TwoBitTimeByusFrom(data2[14], data2[15])
                ,ValueConvert.TwoBitTimeByusFrom(data2[24], data2[25])
                , ValueConvert.TwoBitTimeByusFrom(data2[26], data2[27])
                , ValueConvert.TwoBitTimeByusFrom(data2[28], data2[29])
                , ValueConvert.TwoBitTimeByusFrom(data2[30], data2[31])};
                return new Models.Feedback.InjectTime[] { model2, null };
            }
        }
        //private Models.Feedback.InjectTime[] GetInjectTimeTime(SerialPortsUtils.Agents.Models.CustomActionContext context)
        //{
        //  //  var data5 = context.IO.SendAndRead(InstructionSet.GasPressCorrectionSettings, InstructionSet.GasPressCorrectionPer).PacketData(2).ToArray();
        //   // var data1 = context.IO.SendAndRead(InstructionSet.GetInjectTimePart1, InstructionSet.GetInjectTimePart2_Bank1).PacketData(2).ToArray();
        //    var data1 = context.IO.SendAndRead(InstructionSet.GetInjectTimePart1).PacketData(1).ToArray();
        //    var model1 = new Models.Feedback.InjectTime() { Bank = "Bank1" };
        //    model1.Pertrol = new float[]{ ValueConvert.TwoBitTimeByusFrom(data1[0], data1[1])
        //        ,ValueConvert.TwoBitTimeByusFrom(data1[2], data1[3])
        //        ,ValueConvert.TwoBitTimeByusFrom(data1[4], data1[5])
        //        ,ValueConvert.TwoBitTimeByusFrom(data1[6], data1[7])};
        //    model1.Gas = new float[]{ ValueConvert.TwoBitTimeByusFrom(data1[8], data1[9])
        //        , ValueConvert.TwoBitTimeByusFrom(data1[10], data1[11])
        //        , ValueConvert.TwoBitTimeByusFrom(data1[12], data1[13])
        //        , ValueConvert.TwoBitTimeByusFrom(data1[14], data1[15])};
        //    if (this.PLC.DeviceInfo.HardInof.ECUExtension == false)
        //        return new Models.Feedback.InjectTime[] { model1, null };
        //    var data2 = context.IO.SendAndRead(InstructionSet.GetInjectTimePart1, InstructionSet.GetInjectTimePart2_Bank2).PacketData(2).ToArray();
        //    var model2 = new Models.Feedback.InjectTime() { Bank = "Bank2" };
        //    model2.Pertrol = new float[]{ ValueConvert.TwoBitTimeByusFrom(data2[0], data2[1])
        //        ,ValueConvert.TwoBitTimeByusFrom(data2[2], data2[3])
        //        ,ValueConvert.TwoBitTimeByusFrom(data2[4], data2[5])
        //        ,ValueConvert.TwoBitTimeByusFrom(data2[6], data2[7])
        //        ,ValueConvert.TwoBitTimeByusFrom(data2[8], data2[9])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[10], data2[11])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[12], data2[13])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[14], data2[15])};
        //    model2.Gas = new float[]{ ValueConvert.TwoBitTimeByusFrom(data2[16], data2[17])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[18], data2[19])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[20], data2[21])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[22], data2[23])
        //        ,ValueConvert.TwoBitTimeByusFrom(data2[24], data2[25])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[26], data2[27])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[28], data2[29])
        //        , ValueConvert.TwoBitTimeByusFrom(data2[30], data2[31])};
        //    return new Models.Feedback.InjectTime[] { model1, model2 };
        //}

        private Models.Feedback.Bank<bool[]>[] GetInjectOnOff(SerialPortsUtils.Agents.Models.CustomActionContext context)//一样
        {
            var data = context.IO.SendAndRead(InstructionSet.GetInjectOnOff).PacketData(1).ToArray();
            var b1 = new Models.Feedback.Bank<bool[]>() { Name = "Bank1" };
            b1.Data = ValueConvert.InjectOnOffFrom(data[0]);
            //if (!PLC.DeviceInfo.HardInof.ECUExtension)
            return new Models.Feedback.Bank<bool[]>[] { b1, null };
        }

        private Models.Feedback.ECUWorkTime GetECUTime(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            var packet = context.IO.SendAndRead(InstructionSet.GetECUTime);
            Models.Feedback.ECUWorkTime model = ValueConvert.ECUWorkTimeFrom(packet.PacketData(1).ToArray());
            return model;
        }
        private void SetECUErrors(SerialPortsUtils.Agents.Models.CustomActionContext context, Models.Feedback.DiagnosisDetails model)
        {
            var data = context.IO.SendAndRead(InstructionSet.GetECUErrorState).PacketData(1).ToArray();
            model.ECUErrorStates = data[0] | data[1] << 8 | data[2] << 16;
            model.ECUErrorStates_Store = 0;
        }
    }
}
