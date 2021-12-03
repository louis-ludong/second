using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace IGT.UI.Client
{
    public partial class UpdateECUForm : Form,Service.Language.IMultLang
    {
        private Service.PLC.UpData Data;
        public UpdateECUForm(Service.PLC.UpData updata)
        {
            this.Data = updata;
            InitializeComponent();
            UIHelper.CommonSet(this);
            btnExit.BackColor = Services.Theme.CommonButtonBackColor;
            btnStart.BackColor = Services.Theme.CommonButtonBackColor;
            myMenuStrip1.HideAllMenus();
            myMenuStrip1.ShowCloseButton = false;
            labmsg.Width = this.ClientSize.Width - 4;
         //   progressBar1.Width = this.ClientSize.Width - 4;
            labmsg.Text = String.Empty;
            ApplyLang();
        }

        private void UpdateECUForm_Load(object sender, EventArgs e)
        {

        }

        #region IMultLang 成员

        public void ApplyLang()
        {
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            this.Font = new Font(fontFamily, this.Font.Size);
            labHard.Font = new Font(fontFamily, labHard.Font.Size);
            labROMD.Font = new Font(fontFamily, labROMD.Font.Size);
            labROMF.Font = new Font(fontFamily, labROMF.Font.Size);
            labValueHard.Font = new Font(fontFamily, labValueHard.Font.Size);
            labValueROMD.Font = new Font(fontFamily, labValueROMD.Font.Size);
            labValueROMF.Font = new Font(fontFamily, labValueROMF.Font.Size);
            btnExit.Font = new Font(fontFamily, btnExit.Font.Size);
            btnStart.Font = new Font(fontFamily, btnStart.Font.Size);

            this.Text = words["1001"];
            labHard.Text = words["1006"];
            labROMD.Text = words["1005"];
            labROMF.Text = words["1004"];
            labValueHard.Text = Services.Device.DeviceInfo.HardInof.PCBVer;
            labValueROMD.Text = Services.Device.DeviceInfo.FirmwareInfo;
            labValueROMF.Text = this.Data.ROMVer;
            btnExit.Text = words["1003"];
            btnStart.Text = words["1002"];
        }
        Dictionary<string,string> words = Services.Lang.CurrentWords;

        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            Services.Device.ChangeTaskState(false);
            btnExit.Enabled = false;
            btnStart.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {

            //if (dialog2.FirewareBreaken) IGT.UI.Client.UserControls.MyMenuStrip.
            this.Close();
            if (btnExit.Text == words["1011"])
            {
                Services.Device.ChangeTaskState(true);
                String cst;
                cst = Services.Device.PortName;
                var dialog2 = new DeviceSearchForm(cst);//Services.Device.PortName
                dialog2.ShowDialog();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Services.Device.ChangeTaskState(30,true);
            Service.PLC.ECUUpdateTask task = new Service.PLC.ECUUpdateTask(this.Data);
            Services.Device.AddCustomTask("UpdateECUForm", 30, task);
            bool con = true;
            do
            {
                task.Wait();
                switch (task.Step)
                {
                    case IGT.Service.PLC.ECUUpdateTask.Steps.Bootloader:
                    case IGT.Service.PLC.ECUUpdateTask.Steps.ClearEEPROM:
                    case IGT.Service.PLC.ECUUpdateTask.Steps.ClearFLASH:
                        this.CurStep = task.Step;
                        backgroundWorker1.ReportProgress(0);
                        break;
                    case IGT.Service.PLC.ECUUpdateTask.Steps.WriteData:
                        this.CurStep = task.Step;
                        backgroundWorker1.ReportProgress(100*task.WriteCount / this.Data.Data.Length);
                        break;
                    case IGT.Service.PLC.ECUUpdateTask.Steps.Finish:
                    default:
                        if (!task.Succesed)
                        {
                            res = task.ERROR == null ? string.Empty : task.ERROR;
                        }
                        else
                            res = null;
                        con = false;
                        break;
                }
            } while (con);
            this.res = task.ERROR;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            switch (CurStep)
            {
                case IGT.Service.PLC.ECUUpdateTask.Steps.Bootloader:
                    labmsg.Text = words["1007"];
                    break;
                case IGT.Service.PLC.ECUUpdateTask.Steps.ClearEEPROM:
                    labmsg.Text = words["1008"];
                    break;
                case IGT.Service.PLC.ECUUpdateTask.Steps.ClearFLASH:
                    labmsg.Text = words["1009"];
                    break;
                case IGT.Service.PLC.ECUUpdateTask.Steps.WriteData:
                    labmsg.Text = words["1010"];
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (res != null)
            {
                labmsg.Text = res;
                res = null;
                btnStart.Enabled = true;
            }
            else
            {
                labmsg.Text = words["1011"];
                btnExit.Text = words["1011"];
                btnStart.Enabled = false;
                progressBar1.Value = 100;

       //     Services.Device.ChangeTaskState(true);
            btnExit.Enabled = true;//升级完成
            }
        }
        string res;
        Service.PLC.ECUUpdateTask.Steps CurStep= Service.PLC.ECUUpdateTask.Steps.Bootloader;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape&&btnExit.Enabled==true)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region GDI+
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 4);
            e.Graphics.DrawRectangle(redPen, 2, 2, this.ClientSize.Width - 4, this.ClientSize.Height - 4);
            //e.Graphics.DrawLine(redPen, 829, 0, 829, this.ClientSize.Height - 114);
            redPen.Dispose();
        }
        #endregion
    }
}
