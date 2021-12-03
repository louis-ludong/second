using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    public partial class TableCellEditDialog : Form
    {
        public TableCellEditDialog(IEnumerable<System.Linq.IGrouping<int, UIModels.TableData>> cellValue, UIModels.BetchEditModes betchEditModes)
        {
            InitializeComponent();
            ApplyLang();
            btnCancel.BackColor = Color .FromArgb (245,130,31);
            btnEnter.BackColor = Color.FromArgb(245, 130, 31);
            this.CellsValue = cellValue;
            this.BetchEditModes = betchEditModes;
        }

        private void TableCellEditDialog_Load(object sender, EventArgs e)
        {
            var LangWord = Services.Lang.CurrentWords;
            switch (BetchEditModes)
            {
                case UIModels.BetchEditModes.Value:
                    label1.Text = LangWord["305_13"];
                    break;
                case UIModels.BetchEditModes.Linear:
                    label1.Text = LangWord["305_15"];
                    break;
                case UIModels.BetchEditModes.Percentage:
                    label1.Text = LangWord["305_14"];
                    break;
                default:
                    label1.Text = "";
                    break;
            }
            txtValue.Focus();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int value = 0;//LDC修改 sbyte 改为 int
            int pValue = 0;
            if (!int.TryParse(txtValue.Text, out value))//LDC修改 sbyte 改为 int
                return;
            switch (BetchEditModes)
            {
                case UIModels.BetchEditModes.Value: 
                    if (value <0 || value > 255)
                        return;//LDC 原来50 改为255
                    break;
                case UIModels.BetchEditModes.Linear:
                    if (value < -255 || value > 255)
                        return;//LDC 原来50 改为255
                    break;
                case UIModels.BetchEditModes.Percentage:
                    if (!int.TryParse(txtValue.Text, out pValue)) return;
                    break;
                default:
                    return;
            }
            foreach (IGrouping<int, UIModels.TableData> item in CellsValue)
            {
                foreach (var data in item)
                {
                    int tempValue = 0;
                    switch (BetchEditModes)
                    {
                        case UIModels.BetchEditModes.Value:
                            tempValue = value;
                            break;
                        case UIModels.BetchEditModes.Linear:
                            tempValue = data.Value + value;
                            break;
                        case UIModels.BetchEditModes.Percentage:
                            tempValue = Convert.ToInt32(data.Value + data.Value * pValue / 100d);
                            break;
                    }
                    if (tempValue > 255) data.Value = 255;//LDC修改 原来50 改为255
                    else if (tempValue < 0) data.Value = 0;////LDC MAP修改-50改为0
                    else data.Value = Convert.ToByte(tempValue);////LDC MAP修改<Sbyte>改为<byte>

                    Services.Stroe.MAPCalibrationParams.MAPValues[data.RowIndex][data.ColumnIndex] =(byte)data.Value;
                }
            }
            Services.Stroe.SaveChanges();
            if (value<0)
                 EditValue = 0;
            else
                EditValue = value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ApplyLang()
        {
            var LangWord = Services.Lang.CurrentWords;
            switch (BetchEditModes)
            {
                case UIModels.BetchEditModes.Value:
                    this.Text = LangWord["305_3"];
                    break;
                case UIModels.BetchEditModes.Percentage:
                    this.Text = LangWord["305_4"];
                    break;
                case UIModels.BetchEditModes.Linear:
                    this.Text = LangWord["305_5"];
                    break;
                default:
                    break;
            }
            btnEnter.Text = LangWord["305_1"];
            btnCancel.Text = LangWord["305_2"];
        }

        public int EditValue { get; private set; }
        private IEnumerable<System.Linq.IGrouping<int, UIModels.TableData>> CellsValue;
        private UIModels.BetchEditModes BetchEditModes;

        #region GDI+
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 4);
            e.Graphics.DrawRectangle (redPen, 2, 2, this.ClientSize.Width-4, this.ClientSize.Height - 4);
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
