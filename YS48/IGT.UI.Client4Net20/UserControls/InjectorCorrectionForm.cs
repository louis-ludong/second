using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls
{
    public partial class InjectorCorrectionForm : Form,Service.Language.IMultLang
    {
        public InjectorCorrectionForm()
        {
            InitializeComponent();
            UIHelper.CommonSet(this);
            myMenuStrip1.HideAllMenus();
            myMenuStrip1.ShowCloseButton = true;
            ApplyLang();
            ShowData();
        }
        void numu_ValueChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var numu = sender as NumericUpDown;
            Services.Stroe.InjectorCorrection.CorrectionValues[int.Parse(numu.Tag.ToString())] = Convert.ToInt32(numu.Value);
            Services.Stroe.SaveChanges();
        }

        private void ShowData()
        {
            IsInit = true;
            FixOverData();
            foreach (var item in NumuCy)
            {
                item.Value = Services.Stroe.InjectorCorrection.CorrectionValues[int.Parse(item.Tag.ToString())];
            }
            IsInit = false;
        }
        void FixOverData()
        {
            int max = Convert.ToInt32(NumuCy[0].Maximum);
            int mini = Convert.ToInt32(NumuCy[0].Minimum);
            for (int i = 0; i < Services.Stroe.InjectorCorrection.CorrectionValues.Count; i++)
            {
                if (Services.Stroe.InjectorCorrection.CorrectionValues[i] > max) Services.Stroe.InjectorCorrection.CorrectionValues[i] = max;
                if (Services.Stroe.InjectorCorrection.CorrectionValues[i] < mini) Services.Stroe.InjectorCorrection.CorrectionValues[i] = mini;
            }
            Services.Stroe.SaveChanges();
        }
        private void SetCylidersControls()
        {
            NumuCy = new NumericUpDown[Services.Device.DeviceInfo.HardInof.SumCylinders];
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = Services.Device.DeviceInfo.HardInof.SumCylinders;
            for (int i = 0; i < Services.Device.DeviceInfo.HardInof.SumCylinders; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
            var font = new System.Drawing.Font(Services.Lang.CurrentLang.Font,
                12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            int index=0;
            for (; index < Services.Device.DeviceInfo.HardInof.Bank1Cylinders; index++)
            {
                Label lab = new Label();
                lab.Font = font;
                lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lab.Text = String.Format(LangWords["303_36"] + "(Bank1)", (index + 1).ToString());
                lab.Size = new System.Drawing.Size(120, 30);
                tableLayoutPanel1.Controls.Add(lab, 0, index);
                NumericUpDown numu = new NumericUpDown();
                numu.Font = font;
                numu.ReadOnly = true;
                numu.Increment = 1;
                numu.Maximum = 200;
                numu.Minimum = 0;
                numu.Size = new System.Drawing.Size(60, 30);
                numu.Tag = index.ToString();
                tableLayoutPanel1.Controls.Add(numu, 1, index);
                NumuCy[index] = numu;
                numu.ValueChanged += numu_ValueChanged;
            }
            if(Services.Device.DeviceInfo.HardInof.ECUExtension)
                for (int j = 0; j < Services.Device.DeviceInfo.HardInof.Bank2Cylinders; j++,index++)
                {
                    Label lab = new Label();
                    lab.Font = font;
                    lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lab.Text =String.Format(LangWords["303_36"] + "(Bank2)", (j + 1).ToString());
                    lab.Size = new System.Drawing.Size(120, 30);
                    tableLayoutPanel1.Controls.Add(lab, 0, index);
                    NumericUpDown numu = new NumericUpDown();
                    numu.Font = font;
                    numu.ReadOnly = true;
                    numu.Increment = 1;
                    numu.Maximum = 200;
                    numu.Minimum = 0;
                    numu.Size = new System.Drawing.Size(60, 30);
                    numu.Tag = (j + 8).ToString();
                    tableLayoutPanel1.Controls.Add(numu, 1, index);
                    NumuCy[index] = numu;
                    numu.ValueChanged += numu_ValueChanged;
                }
        }

        #region IMultLang 成员

        public void ApplyLang()
        {
            IsInit = true;
            LangWords = Services.Lang.CurrentWords;
            this.Text = null;//LangWords["303_35"];
            SetCylidersControls();
            IsInit = false;
        }
        Dictionary<string, string> LangWords;
        #endregion
        NumericUpDown[] NumuCy;
        bool IsInit = false;

        #region GDI+
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 4);
            e.Graphics.DrawRectangle(redPen, 2, 2, this.ClientSize.Width - 4, this.ClientSize.Height - 4);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
