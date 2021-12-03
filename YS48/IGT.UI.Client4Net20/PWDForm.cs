using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    public partial class PWDForm : Form,Service.Language.IMultLang
    {
        public PWDForm()
        {
            InitializeComponent();
            UIHelper.CommonSet(this);
            IsCancel = false;
            ApplyLang();
            Services.Device.Connect.PasswordPass += Connict_PasswordPass;
            Services.Device.Connect.RequestPassword += Connict_RequestPassword;
        }

        void Connict_RequestPassword(object sender, Service.PLC.RequestPWdEventArgs e)
        {
            this.Invoke(new UIHelper.UIInvoke(ShoWFaild));
        }

        void Connict_PasswordPass(object sender, EventArgs e)
        {
            this.Invoke(new UIHelper.UIInvoke(this.Close));
        }
        private void btnEnter_Click(object sender,EventArgs e)
        {
            if (txtPwd.Text.Length < 1) return;
            Services.Device.Connect.SendPassword(txtPwd.Text);
        }
        private void ShoWFaild()
        {
            MessageBox.Show(Services.Lang.CurrentWords["807"], "");
        }

        private void PWDForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Services.Device.Connect.RequestPassword -= Connict_RequestPassword;
            Services.Device.Connect.PasswordPass -= Connict_PasswordPass;
            if(IsCancel==true)
                Services.Device.Connect.Stop();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                IsCancel = true;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #region IMultLang 成员

        public void ApplyLang()
        {
            labPwd.Text = Services.Lang.CurrentWords["804"];
            btnEnter.Text = Services.Lang.CurrentWords["801"];
            labSerialNumber.Text = "SerialNumber:" + Device.DeviceInfo.SerialNumber;
        }
        public bool IsCancel { get; set; }


        Service.PLC.Device Device { get { return Services.Device; } }

        #endregion
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Device.DeviceInfo.SerialNumber);
        }
    }
}
