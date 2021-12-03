using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    public partial class SetPWDForm : Form
    {
        public SetPWDForm()
        {
            InitializeComponent();
           // UIHelper.CommonSet(this);
            ApplyLang();
        }
        private void SetPWDForm_Load(object sender, EventArgs e)
        {

        }
        public void ApplyLang()
        {
            this.Text = Words["803"];
            labPwd.Text = Words["804"];
            labConfirm.Text = Words["805"];
            btnEnter.Text = Words["801"];
            btnCancel.Text = Words["802"];
        }
        Dictionary<String, String> Words
        {
            get { return Services.Lang.CurrentWords; }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text != txtConfirm.Text)
            {
                MessageBox.Show(Words["806"]);
            }
            else
            {
                Services.Device.SendAndRead("SetPWDForm", 19, Service.PLC.InstructionSet.SetPasssword,
                    Service.PLC.ValueConvert.PasswordValue(txtPwd.Text));
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
