using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service.PLC
{
    class ConnectTask_GetDeviceInfo:ICustomTask
    {
        #region ICustomTask 成员

        public byte[] Execute(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            var packet1= context.IO.SendAndRead(InstructionSet.FireWareInfo);
            var pacet2 = context.IO.SendAndRead(InstructionSet.HardInfo);
            var model = new Models.Feedback.DeviceStaticData();
            model.FirmwareInfo = packet1.ToFireWareInfo();
            model.HardInof = pacet2.ToHardwareInfo();
            context.Job.Content.Context = context;
            return null;
        }

        #endregion
    }
    class ConnectTask_ValidateInfo : ICustomTask
    {
        private string Password;
        public ConnectTask_ValidateInfo(string pwd)
        {
            this.Password = pwd;
        }
        #region ICustomTask 成员

        public byte[] Execute(SerialPortsUtils.Agents.Models.CustomActionContext context)
        {
            context.IO.SendAndRead(InstructionSet.HandShake, InstructionSet.DeviceCode);//心跳包，防止握手失效
            context.IO.SendAndRead(InstructionSet.InputPassword, ValueConvert.PasswordValue(this.Password));
            return context.IO.SendAndRead(InstructionSet.PasswordIsSet);
        }

        #endregion
    }
}
