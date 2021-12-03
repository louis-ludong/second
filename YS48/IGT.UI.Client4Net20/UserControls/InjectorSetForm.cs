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
    public partial class InjectorSetForm : Form,Service.Language.IMultLang
    {
        public InjectorSetForm()
        {
            InitializeComponent();
            UIHelper.CommonSet(this);
            ApplyLang();
            myMenuStrip1.HideAllMenus();
            myMenuStrip1.ShowMinButton = false;
            ShowData();
        }

        private void numu_ValueChanged(object sender, EventArgs e)
        {
            if (IsInit == true) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {

                case "numuMinOpenTime":
                    Services.Stroe.InjectorCorrection.MinOpenTime = Convert.ToSingle(numu.Value);
                    break;
                case "numuCorrectionTime":
                    Services.Stroe.InjectorCorrection.CorrectionTime = Convert.ToSingle(numu.Value);
                    break;
                case "numuOpenKeepTime":
                    Services.Stroe.InjectorCorrection.OpenKeepTime = Convert.ToSingle(numu.Value);
                    break;
                case "numuInjectEmptyScale":
                    Services.Stroe.InjectorCorrection.InjectEmptyScale = Convert.ToInt32(numu.Value);
                    break;
                case "numuMaxOpenTime":
                    Services.Stroe.InjectorCorrection.MaxOpenTime = Convert.ToSingle(numu.Value);
                    break;
                default:
                    break;
            }
            Services.Stroe.SaveChanges();
        }

        private void ShowData()
        {
            IsInit = true;
            FixOverData();
            numuMinOpenTime.Value = (decimal)Services.Stroe.InjectorCorrection.MinOpenTime;
            numuCorrectionTime.Value = (decimal)Services.Stroe.InjectorCorrection.CorrectionTime;
            numuOpenKeepTime.Value = (decimal)Services.Stroe.InjectorCorrection.OpenKeepTime;
            numuInjectEmptyScale.Value = (decimal)Services.Stroe.InjectorCorrection.InjectEmptyScale;
            numuMaxOpenTime.Value = (decimal)Services.Stroe.InjectorCorrection.MaxOpenTime;
            IsInit = false;
        }
        void FixOverData()
        {
            bool change = Services.Stroe.InjectorCorrection.MinOpenTime > Convert.ToSingle(numuMinOpenTime.Maximum) || Services.Stroe.InjectorCorrection.MinOpenTime < Convert.ToSingle(numuMinOpenTime.Minimum) ||
            Services.Stroe.InjectorCorrection.CorrectionTime > Convert.ToSingle(numuCorrectionTime.Maximum) || Services.Stroe.InjectorCorrection.CorrectionTime < Convert.ToSingle(numuCorrectionTime.Minimum) ||
            Services.Stroe.InjectorCorrection.OpenKeepTime > Convert.ToSingle(numuOpenKeepTime.Maximum) || Services.Stroe.InjectorCorrection.OpenKeepTime < Convert.ToSingle(numuOpenKeepTime.Minimum) ||
            Services.Stroe.InjectorCorrection.InjectEmptyScale > Convert.ToInt32(numuInjectEmptyScale.Maximum) || Services.Stroe.InjectorCorrection.InjectEmptyScale < Convert.ToInt32(numuInjectEmptyScale.Minimum) ||
            Services.Stroe.InjectorCorrection.MaxOpenTime > Convert.ToSingle(numuMaxOpenTime.Maximum) || Services.Stroe.InjectorCorrection.MaxOpenTime < Convert.ToSingle(numuMaxOpenTime.Minimum);
            if (Services.Stroe.InjectorCorrection.MinOpenTime > Convert.ToSingle(numuMinOpenTime.Maximum))
                Services.Stroe.InjectorCorrection.MinOpenTime = Convert.ToSingle(numuMinOpenTime.Maximum);
            if (Services.Stroe.InjectorCorrection.MinOpenTime < Convert.ToSingle(numuMinOpenTime.Minimum))
                Services.Stroe.InjectorCorrection.MinOpenTime = Convert.ToSingle(numuMinOpenTime.Minimum);
            if (Services.Stroe.InjectorCorrection.CorrectionTime > Convert.ToSingle(numuCorrectionTime.Maximum))
                Services.Stroe.InjectorCorrection.CorrectionTime = Convert.ToSingle(numuCorrectionTime.Maximum);
            if (Services.Stroe.InjectorCorrection.CorrectionTime < Convert.ToSingle(numuCorrectionTime.Minimum))
                Services.Stroe.InjectorCorrection.CorrectionTime = Convert.ToSingle(numuCorrectionTime.Minimum);
            if (Services.Stroe.InjectorCorrection.OpenKeepTime > Convert.ToSingle(numuOpenKeepTime.Maximum))
                Services.Stroe.InjectorCorrection.OpenKeepTime = Convert.ToSingle(numuOpenKeepTime.Maximum);
            if (Services.Stroe.InjectorCorrection.OpenKeepTime < Convert.ToSingle(numuOpenKeepTime.Minimum))
                Services.Stroe.InjectorCorrection.OpenKeepTime = Convert.ToSingle(numuOpenKeepTime.Minimum);
            if (Services.Stroe.InjectorCorrection.InjectEmptyScale > Convert.ToInt32(numuInjectEmptyScale.Maximum))
                Services.Stroe.InjectorCorrection.InjectEmptyScale = Convert.ToInt32(numuInjectEmptyScale.Maximum);
            if (Services.Stroe.InjectorCorrection.InjectEmptyScale < Convert.ToInt32(numuInjectEmptyScale.Minimum))
                Services.Stroe.InjectorCorrection.InjectEmptyScale = Convert.ToInt32(numuInjectEmptyScale.Minimum);
            if (Services.Stroe.InjectorCorrection.MaxOpenTime > Convert.ToSingle(numuMaxOpenTime.Maximum))
                Services.Stroe.InjectorCorrection.MaxOpenTime = Convert.ToSingle(numuMaxOpenTime.Maximum);
            if (Services.Stroe.InjectorCorrection.MaxOpenTime < Convert.ToSingle(numuMaxOpenTime.Minimum))
                Services.Stroe.InjectorCorrection.MaxOpenTime = Convert.ToSingle(numuMaxOpenTime.Minimum);
            if (change)
                Services.Stroe.SaveChanges();
        }
        #region IMultLang 成员

        public void ApplyLang()
        {
            IsInit = true;
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            this.Font = new Font(fontFamily, this.Font.Size);
            labCorrectionTime.Font = new Font(fontFamily, labCorrectionTime.Font.Size);
            labMinOpenTime.Font = new Font(fontFamily, labMinOpenTime.Font.Size);
            labOpenKeepTime.Font = new Font(fontFamily, labOpenKeepTime.Font.Size);
            labInjectEmptyScale.Font = new Font(fontFamily, labInjectEmptyScale.Font.Size);
            labMaxOpenTime.Font = new Font(fontFamily, labMaxOpenTime.Font.Size);

            LangWords = Services.Lang.CurrentWords;
            //this.Text = LangWords["303_34"];

            labCorrectionTime.Text = LangWords["303_30"];
            labMinOpenTime.Text = LangWords["303_29"];
            labOpenKeepTime.Text = LangWords["303_31"];
            labInjectEmptyScale.Text = LangWords["303_32"];
            labMaxOpenTime.Text = LangWords["303_33"];
            IsInit = false;
        }

        #endregion
        Dictionary<String,string> LangWords ;

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
        bool IsInit = false;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
