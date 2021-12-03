using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace IGT.UI.Client.UserControls
{
    public partial class OBDErrorsForm : Form, Service.Language.IMultLang
    {
        public OBDErrorsForm()
        {
            UIHelper.CommonSet(this);
            InitializeComponent();
            myMenuStrip1.HideAllMenus();
            myMenuStrip1.ShowCloseButton=true ;
            btnClear.BackColor = Color.FromArgb(245, 130, 31);
            btnRefresh.BackColor = Color.FromArgb(245, 130, 31);
            FaultCodeDic = GetFaultCodeDic();
            ApplyLang();
        }
        private void OBDErrorsForm_Load(object sender, EventArgs e)
        {
            Services.Device.ResultGot += Device_ResultGot;
            GetErrors();
            this.FormClosing += OBDErrorsForm_FormClosing;
        }

        void OBDErrorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Services.Device.ResultGot -= Device_ResultGot;
        }
        private void SetErrorsList(ParmWarper<Models.Feedback.OBDError[]> errors)
        {
            //errors.Parm = new Models.Feedback.OBDError[]{
            //    new Models.Feedback.OBDError(){Code="P0010"},
            //    new Models.Feedback.OBDError(){Code="P2029"},
            //    new Models.Feedback.OBDError(){Code="U0022"},
            //    new Models.Feedback.OBDError(){Code="U0023"},
            //    new Models.Feedback.OBDError(){Code="U0024"},
            //    new Models.Feedback.OBDError(){Code="P2029"},
            //    new Models.Feedback.OBDError(){Code="U0021"},
            //    new Models.Feedback.OBDError(){Code="B0090"},
            //};
            var items = errors.Parm.Select(m => {
                var item = new ListViewItem(m.Code);
                string content = FaultCodeDic.ContainsKey(m.Code) ? FaultCodeDic[m.Code] : "Unknow Error";
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, content));
                item.ToolTipText = content;
                return item;
            }).ToArray();
            lvErrors.Items.Clear();
            lvErrors.Items.AddRange(items);
        }
        private void SetPotentialErrorList(ParmWarper<Models.Feedback.OBDError[]> errors)
        {
            var items = errors.Parm.Select(m =>
            {
                var item = new ListViewItem(m.Code);
                string content = FaultCodeDic.ContainsKey(m.Code) ? FaultCodeDic[m.Code] : "Unknow Error";
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, content));
                item.ToolTipText = content;
                return item;
            }).ToArray();
            lvPotential.Items.Clear();
            lvPotential.Items.AddRange(items);
            btnRefresh.Enabled = true;
        }
        void Device_ResultGot(SerialPortsUtils.Agents.Models.AgentTaskResult result)
        {
            if (result.Successed)
            {
                switch (result.Identity)
                {
                    case "GetOBDErrorsPart2_Error":
                        var r = Service.PLC.DTOUitils.ToOBDError(result.ExecuteResult);
                            this.Invoke(new UIHelper.UIINvkoeParam1<ParmWarper<Models.Feedback.OBDError[]>>(SetErrorsList), new ParmWarper<Models.Feedback.OBDError[]>(r));
                        break;
                    case "GetOBDErrorsPart2_Potential":
                        var r2 = Service.PLC.DTOUitils.ToOBDError(result.ExecuteResult);
                        this.Invoke(new UIHelper.UIINvkoeParam1<ParmWarper<Models.Feedback.OBDError[]>>(SetPotentialErrorList), new ParmWarper<Models.Feedback.OBDError[]>(r2));
                        break;
                }
            }
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
            labErrors.Font = new Font(fontFamily, labErrors.Font.Size);
            labPotential.Font = new Font(fontFamily, labPotential.Font.Size);
            lvErrors.Font = new Font(fontFamily, lvErrors.Font.Size);
            lvPotential.Font = new Font(fontFamily, lvPotential.Font.Size);
            btnClear.Font = new Font(fontFamily, btnClear.Font.Size);
            btnRefresh.Font = new Font(fontFamily, btnRefresh.Font.Size);


            this.Text = Services.Lang.CurrentWords["523_1"];
            labErrors.Text = Services.Lang.CurrentWords["523_2"];
            labPotential.Text = Services.Lang.CurrentWords["523_3"];
            lvErrors.Columns[0].Text = Services.Lang.CurrentWords["523_4"];
            lvPotential.Columns[0].Text = Services.Lang.CurrentWords["523_4"];
            btnClear.ButtonText = Services.Lang.CurrentWords["523_5"];
            btnRefresh.ButtonText = Services.Lang.CurrentWords["523_6"];
        }

        #endregion
        private void GetErrors()
        {
            btnRefresh.Enabled = false;
            Services.Device.SendAndRead("GetOBDErrorsPart2_Error", UIHelper.CancelBit_OBDErrors, Service.PLC.InstructionSet.GetOBDErrorsPart1
                ,Service.PLC.InstructionSet.GetOBDErrorsPart2_Error);
            Services.Device.SendAndRead("GetOBDErrorsPart2_Potential", UIHelper.CancelBit_OBDErrors, Service.PLC.InstructionSet.GetOBDErrorsPart1
                , Service.PLC.InstructionSet.GetOBDErrorsPart2_Potential);
        }
        class ParmWarper<T>
        {
            public ParmWarper(T p)
            {
                this.Parm = p;
            }
            public T Parm { get; set; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetErrors();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Services.Device.SendAndRead("SetODBErrorClear", UIHelper.CancelBit_OBDErrors, Service.PLC.InstructionSet.SetODBErrorClear,
                new byte[] {Service.PLC.InstructionSet.SetODBErrorClear_Const });
            GetErrors();
        }
        private Dictionary<String, String> FaultCodeDic;
        private Dictionary<String, String> GetFaultCodeDic()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            String file = System.IO.Directory.GetCurrentDirectory() + "\\OBD_Fault_Code.txt";
            using (var stream=new System.IO.StreamReader(file,Encoding.UTF8))
            {
                do
                {
                    string line = stream.ReadLine();
                    if (string.IsNullOrEmpty(line)) continue;
                    string[] temp = line.Split(new char[] { ' ' }, 2);
                    if(temp[0].Contains('-'))
                    {
                        string[] temp2 = temp[0].Split('-');
                        dic.Add(temp2[0], temp[1]);
                        dic.Add(temp2[1], temp[1]);
                    }
                    else
                        dic.Add(temp[0], temp[1]);
                } while (!stream.EndOfStream);
            }
            return dic;
        }

        private void lvErrors_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 4);
            e.Graphics.DrawRectangle(redPen, 2, 2, this.ClientSize.Width - 4, this.ClientSize.Height - 4);
            //e.Graphics.DrawLine(redPen, 829, 0, 829, this.ClientSize.Height - 114);
            redPen.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
