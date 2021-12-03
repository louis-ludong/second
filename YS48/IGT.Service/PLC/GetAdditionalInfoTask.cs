using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace IGT.Service.PLC
{
    /// <summary>
    /// 任务-获取附加信息
    /// </summary>
    class GetAdditionalInfoTask:ICustomTask
    {
        private Device PLC;
        public GetAdditionalInfoTask(Device device)
        {
            this.PLC = device;
        }

        #region ICustomTask 成员

        public byte[] Execute(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            var data1 = context.IO.SendAndRead(InstructionSet.GetEmergencyStartInfo).PacketData(1).ToArray();//返回燃气紧急启动信息
            var data2 = context.IO.SendAndRead(InstructionSet.GetMaintainInfo).PacketData(1).ToArray();
            var model = new Models.Feedback.AdditionalInfo();
            model.EmergencyStatsPerformed = data1[2];
            model.MaintainTime = ValueConvert.MaintainTimeFrom(data2[3], data2[4]);
            context.Job.Content.Context = model;
            return null;
        }

        #endregion
    }
}
