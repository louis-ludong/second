//#define FIX
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class MAPCalibrationSettingPanel : UserControl, Service.Language.IMultLang, ISettingPanel
    {
        float[][] maps;
        Point RedCellPoint = new Point(-1, -1);
        public MAPCalibrationSettingPanel()
        {
            InitializeComponent();
            txtForHeaderCell.Hide();
            ApplyLang();
            maps = new float[Services.Stroe.MAPCalibrationParams.RPMs.Count+1][];
        }
        //SolidBrush brush = new SolidBrush(Color.Yellow);
        //Rectangle oldBall = new Rectangle(0, 0, 0, 0);
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model)//红点显示
        {
            if (IsInit) return;
            //var x = Store.MAPCalibrationParams.RPMs
            //    .Select((m, i) => new KeyValuePair<int, float>(i, Math.Abs(m - model.RPM)))
            //    .OrderBy(m => m.Value).Select(m => m.Key).First();
            //var y = Store.MAPCalibrationParams.Injection.ToArray()
            //    .Select((m, i) => new KeyValuePair<int, float>(i, Math.Abs(m - model.PetrolsTime)))
            //    .OrderBy(m => m.Value).Select(m => m.Key).First();
            //if (RedCellPoint.X != x || RedCellPoint.Y != y)
            //{
            //    if (RedCellPoint.X >= 0 && RedCellPoint.Y >= 0)
            //        kryptonDataGridView1.Rows[RedCellPoint.Y].Cells[RedCellPoint.X].Style.BackColor = Color.White;
            //    kryptonDataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
            //    RedCellPoint = new Point(x, y);
            //}
          //  while (true) ;
            int x,y;
            int i = 0;
            for (; i < Store.MAPCalibrationParams.RPMs.Count; i++)
            {
                if (model.RPM >= Store.MAPCalibrationParams.RPMs[i])
                    continue;
                else
                    break;
            }
            if (i == 0)
                x = 67;
            else if (i >= Store.MAPCalibrationParams.RPMs.Count)
                x = 800;
            else
            {
                x = (model.RPM - Store.MAPCalibrationParams.RPMs[i - 1] + (Store.MAPCalibrationParams.RPMs[i] - Store.MAPCalibrationParams.RPMs[i - 1]) / 2) * 61
                   / (Store.MAPCalibrationParams.RPMs[i] - Store.MAPCalibrationParams.RPMs[i - 1]);
               x = x + 67 +( i-1)*61;
            }
            for (i = 0; i < Store.MAPCalibrationParams.Injection.Count; i++)
            {
                if (model.PetrolsTime >= Store.MAPCalibrationParams.Injection[i])
                    continue;
                else
                    break;
            }
            if (i >= Store.MAPCalibrationParams.Injection.Count)
                y = 340;
            else if (i == 0)
                y = 27;
            else
            {
                y = (int)((model.PetrolsTime - Store.MAPCalibrationParams.Injection[i - 1]+ (Store.MAPCalibrationParams.Injection[i] - Store.MAPCalibrationParams.Injection[i-1])/2) * 26
                    / (Store.MAPCalibrationParams.Injection[i] - Store.MAPCalibrationParams.Injection[i - 1]));
                y = (int)(y + 27 + (i-1) * 26);
            }
           // this.Invalidate();
            if (RedCellPoint.X != x || RedCellPoint.Y != y)
            {
                 kryptonDataGridView1.Refresh();
                 RedCellPoint.X = x;
                 RedCellPoint.Y = y;
            }
        //    Graphics g = Graphics.FromHwnd(kryptonDataGridView1.Handle);
            Graphics g = kryptonDataGridView1.CreateGraphics();
          //  g.FillRectangle(new SolidBrush(kryptonDataGridView1.BackColor),oldBall);//new SolidBrush(kryptonDataGridView1.BackColor)
            g.FillEllipse(Brushes.Blue, x, y, 15, 15);  // 67,27           800, 340,
          //  oldBall = new Rectangle(x, y, 15, 15);
        }
        public void ShowData()
        {
            IsInit = true;
            numuWeak.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Weak);
            //tBarSpeedThicken.Value = Services.Stroe.ECUSetting.SpeedThicken;
            tBarSpeedThicken.Value = 20;
            cbExtraCutting.Checked = Services.Stroe.ECUSetting.ExtraInjectionCutting;
            cbExtraSen.Checked = Services.Stroe.ECUSetting.ExtraInjectionSensitivityEnable;
            numuSen.Value = (decimal)Services.Stroe.ECUSetting.ExtrainjSensitivity;
            tBarSen.Value =(int) Services.Stroe.ECUSetting.ExtrainjSensitivity*10;
            numuIdentTime.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.ExtraInjectionIdentTime);
            cbExtraSen.Enabled = !cbExtraCutting.Checked;
            numuSen.Enabled = cbExtraSen.Enabled && cbExtraSen.Checked;
            tBarSen.Enabled = cbExtraSen.Enabled && cbExtraSen.Checked;
            //numuIdentTime.Enabled = cbExtraSen.Enabled;
            tBarSpeedThicken.Value = Services.Stroe.ECUSetting.SpeedThicken;
            RedCellPoint = new Point(-1, -1);
            kryptonDataGridView1.SuspendLayout();//以下为表格初始化
            kryptonDataGridView1.Rows.Clear();
            kryptonDataGridView1.Columns.Clear();
     //       kryptonDataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            //kryptonDataGridView1.Columns.Add("0.0", "0.0");////LDC删除
            //foreach (var item in Store.MAPCalibrationParams.Injection)   ///Font
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();//237, 243, 247
            columnHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            columnHeaderStyle.Font = new Font("微软雅黑",12);
            kryptonDataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            foreach (var item in Store.MAPCalibrationParams.RPMs)
            {
                var temp = String.Format("{0}", item);//原{0:N1}
                kryptonDataGridView1.Columns.Add(temp, temp);//
            }
            foreach (DataGridViewColumn item in kryptonDataGridView1.Columns)
            {
                item.Width =61;
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //var rowHeads = (new int[] { 0 }).Concat(Store.MAPCalibrationParams.RPMs);//LDC删除 
            //var rowHeads = Store.MAPCalibrationParams.RPMs;//LDC增加   MAP初始化

            var rowHeads = Store.MAPCalibrationParams.Injection;
            for (int i = 0; i < Store.MAPCalibrationParams.MAPValues.Count; i++)
            {
               // int headerValue = rowHeads.ElementAt(i);
                var temp = String.Format("{0:N1}", rowHeads[i]);
                DataGridViewRow row = new DataGridViewRow();
                //row.HeaderCell.Value = headerValue.ToString();
                row.HeaderCell.Value = temp;
                row.HeaderCell.Style.Font = new Font("微软雅黑", 12);
               // row.HeaderCell.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
                row.Cells.AddRange(Store.MAPCalibrationParams.MAPValues[i].
                    Select((m, index) => new DataGridViewTextBoxCell() { Value = m.ToString() }).ToArray());
                row.Height = 26;
                kryptonDataGridView1.Rows.Add(row);
#if FIX
                if(Store.MAPCalibrationParams.DataLockStatus.Count<i) return;
                int cellCountMax = Math.Min(row.Cells.Count, Store.MAPCalibrationParams.DataLockStatus[i].Count);
#else
                int cellCountMax = row.Cells.Count;
#endif
                //for (int index = 0; index < cellCountMax; index++)
                //{
                //    if (Store.MAPCalibrationParams.DataLockStatus[i][index] == true)
                //        row.Cells[index].ReadOnly = true;
                //}
            }
          //  kryptonDataGridView1.Columns[0].HeaderCell.Value = "第一列";
            kryptonDataGridView1.TopLeftHeaderCell.Value = "T/RPM";
            kryptonDataGridView1.ResumeLayout();
            IsInit = false;
        }

        private void MAPCalibrationSettingPanel_Load(object sender, EventArgs e)
        {
            kryptonDataGridView1.CellBeginEdit += kryptonDataGridView1_CellBeginEdit;
            kryptonDataGridView1.CellEndEdit += kryptonDataGridView1_CellEndEdit;
           // kryptonDataGridView1.ColumnHeaderMouseDoubleClick += kryptonDataGridView1_ColumnHeaderMouseDoubleClick;//
          //  kryptonDataGridView1.RowHeaderMouseDoubleClick += kryptonDataGridView1_RowHeaderMouseDoubleClick;//
            txtForHeaderCell.KeyPress += txtForHeaderCell_KeyPress;
            txtForHeaderCell.LostFocus += txtForHeaderCell_LostFocus;
            cMenuBatchEdit.ItemClicked += cMenuBatchEdit_Item_Click;
        }
        //在为选定的单元格停止编辑模式时发生。
        private void kryptonDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            byte value = 0;//LDC MAP修改<Sbyte>改为<byte>
            if (byte.TryParse(kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value)
                 )////LDC MAP修改50改为255  删掉&& value >= -50 && value < 255
            {
                Store.MAPCalibrationParams.MAPValues[e.RowIndex][e.ColumnIndex] =(byte)value;
                Store.SaveChanges();
            }
            else
            {
                kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Store.MAPCalibrationParams.MAPValues[e.RowIndex][e.ColumnIndex];
            }
        }
        //在为选定的单元格启动编辑模式时发生。
        private void kryptonDataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) { if (IsInit)e.Cancel = true; }
      //双击列表列时发生
        private void kryptonDataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (IsInit) return;
            var cell = kryptonDataGridView1.Columns[e.ColumnIndex].HeaderCell;
            BeginHeaderEdit(cell.Value.ToString(), e.ColumnIndex, e.RowIndex);

        }
        //双击列表行时发生
        private void kryptonDataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (IsInit) return;
            var cell = kryptonDataGridView1.Rows[e.RowIndex].HeaderCell;
            BeginHeaderEdit(cell.Value.ToString(), e.ColumnIndex, e.RowIndex);
        }
        //失去焦点时发生
        private void txtForHeaderCell_LostFocus(object sender, EventArgs e)
        {
            EndHeaderEdit();
        }
        //有焦点时按键发生
        private void txtForHeaderCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                kryptonDataGridView1.Focus();
            }
        }
        //回车后进入
        void cMenuBatchEdit_Item_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            if (IsInit || kryptonDataGridView1.SelectedCells.Count < 1) return;
            var editCells = kryptonDataGridView1.SelectedCells.Cast<DataGridViewTextBoxCell>()
                .Where(m => m.ReadOnly == false);
            var cellValues = editCells
                .Select(m => new UIModels.TableData() { ColumnIndex = m.ColumnIndex, RowIndex = m.RowIndex, Value = byte.Parse(m.Value.ToString()) })//LDC MAP修改<Sbyte>改为<byte>
                .GroupBy(m => m.RowIndex).ToArray();
            TableCellEditDialog t = null;
            switch (e.ClickedItem.Name)
            {
                case "tsmiEditByValue":
                    t = new TableCellEditDialog(cellValues, UIModels.BetchEditModes.Value);
                    if (t.ShowDialog() == DialogResult.OK)
                        foreach (DataGridViewTextBoxCell item in editCells)
                        {
                            item.Value = t.EditValue;
                        }
                    break;
                case "tsmiEditByPercentage":
                    t = new TableCellEditDialog(cellValues, UIModels.BetchEditModes.Percentage);
                    if (t.ShowDialog() == DialogResult.OK)
                        foreach (DataGridViewTextBoxCell item in editCells)
                        {
                            item.Value = Store.MAPCalibrationParams.MAPValues[item.RowIndex][item.ColumnIndex];
                        }
                    break;
                case "tsmiEditByLinear":
                    t = new TableCellEditDialog(cellValues, UIModels.BetchEditModes.Linear);
                    if (t.ShowDialog() == DialogResult.OK)
                        foreach (DataGridViewTextBoxCell item in editCells)
                        {
                            item.Value = Store.MAPCalibrationParams.MAPValues[item.RowIndex][item.ColumnIndex];
                        }
                    break;
                default:
                    break;
            }
        }

        public void cb_Checked(object sender, EventArgs e)
        {
            if (IsInit) return;
            var cb = sender as CheckBox;
            switch (cb.Name)
            {
                case "cbExtraCutting":
                    if (cb.Checked)
                    {
                        cbExtraSen.Enabled = false;
                        numuSen.Enabled = false;
                        tBarSen.Enabled = false;
                    }
                    else
                    {
                        cbExtraSen.Enabled = true;
                        numuSen.Enabled = cbExtraSen.Checked;
                        tBarSen.Enabled = cbExtraSen.Checked;
                    }
                    //numuIdentTime.Enabled = !cb.Checked;
                    Services.Stroe.ECUSetting.ExtraInjectionCutting = cb.Checked;
                    if (cb.Checked)
                        Services.Stroe.ECUSetting.ExtraData[0] = (byte)(Services.Stroe.ECUSetting.ExtraData[0] | 0x01);
                    else
                        Services.Stroe.ECUSetting.ExtraData[0] = (byte)(Services.Stroe.ECUSetting.ExtraData[0] & 0xFE);
                    break;
                case "cbExtraSen":
                    Services.Stroe.ECUSetting.ExtraInjectionSensitivityEnable = cb.Checked;
                    if (!cb.Checked)
                        Services.Stroe.ECUSetting.BaseData[1] = (byte)(Services.Stroe.ECUSetting.BaseData[1] | 0x02);
                    else
                        Services.Stroe.ECUSetting.BaseData[1] = (byte)(Services.Stroe.ECUSetting.BaseData[1]  &0xFD);
                    numuSen.Enabled = cb.Checked;
                    tBarSen.Enabled = cb.Checked;
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();
        }
        public void numu_ValueChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {
                case "numuWeak":
                    Services.Stroe.ECUSetting.Weak = Convert.ToInt32(numu.Value);
                    break;
                case "numuSen":
                    Services.Stroe.ECUSetting.ExtrainjSensitivity = (float)numu.Value;
                    tBarSen.Value = (int)(Services.Stroe.ECUSetting.ExtrainjSensitivity*10);//
                    break;
                case "numuIdentTime":
                    Services.Stroe.ECUSetting.ExtraInjectionIdentTime = Convert.ToSingle(numu.Value);
                    break;
                default:
                    break;
            }
            Services.Stroe.SaveChanges();
        }
        private void trackBarSen_Scroll(object sender, EventArgs e)
        {




            if (IsInit) return;
            var tb = sender as TrackBar;
            switch (tb.Name)
            {
                case "tBarSen":
                    numuSen.Value = (decimal)((float)tb.Value / 10f);
                    return;
                case "tBarSpeedThicken":
                    Services.Stroe.ECUSetting.SpeedThicken = tb.Value;
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();
        }
        private void cMenuBatchEdit_Opening(object sender, CancelEventArgs e)
        {
            if (IsInit) return;
            var temp = kryptonDataGridView1.SelectedCells.Count < 1;
            if (temp) e.Cancel = true;
        }


        #region HeaderEdit
       // 双击列表时发生
        void BeginHeaderEdit(String value, int columnIndex, int rowIndex)
        {
            if ((columnIndex == -1 && rowIndex == 0)
                || (rowIndex == -1 && columnIndex == 0)) return;
            var rec = kryptonDataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);
            CurHeaderColumnIndex = columnIndex;
            CurHeaderRowIndex = rowIndex;
            txtForHeaderCell.Location = rec.Location;
            txtForHeaderCell.Size = rec.Size;
            txtForHeaderCell.Text = value;
            txtForHeaderCell.SelectAll();
            txtForHeaderCell.Show();
            txtForHeaderCell.Focus();
        }
        //失去焦点时发生
        void EndHeaderEdit()
        {
            txtForHeaderCell.Hide();
            if (CurHeaderRowIndex == -1)
            {
                float temp;
                if (float.TryParse(txtForHeaderCell.Text, out temp))
                {
                    if (temp < 0) temp = 0;
                    else if (temp > 34.46f) temp = 34.46f;
                    if (Store.MAPCalibrationParams.Injection[CurHeaderColumnIndex - 1] == temp) return;
                    var str = String.Format("{0:N1}", temp);
                    kryptonDataGridView1.Columns[CurHeaderColumnIndex].HeaderCell.Value = str;
                    Store.MAPCalibrationParams.Injection[CurHeaderColumnIndex - 1] = temp;
                    Store.SaveChanges();
                }
            }
            else if (CurHeaderColumnIndex == -1)
            {
                String str = txtForHeaderCell.Text.Trim();
                int temp;
                if (int.TryParse(str, out temp))
                {
                    if (temp < 0) temp = 0;
                    else if (temp > 25500) temp = 25500;
                    if (Store.MAPCalibrationParams.RPMs[CurHeaderRowIndex - 1] == temp) return;
                    kryptonDataGridView1.Rows[CurHeaderRowIndex].HeaderCell.Value = temp.ToString();
                    Store.MAPCalibrationParams.RPMs[CurHeaderRowIndex - 1] = temp;
                    Store.SaveChanges();
                }
            }
        }
        int CurHeaderRowIndex, CurHeaderColumnIndex;
        #endregion

        #region ISettingPanel 成员
        #endregion
        public void FixOverData()//对超出的数据进行调整
        {
            bool change = Services.Stroe.ECUSetting.AdaptiveRange > Convert.ToInt32(numuAdaptiveRange.Maximum) || Services.Stroe.ECUSetting.AdaptiveRange < Convert.ToInt32(numuAdaptiveRange.Minimum) ||
             Services.Stroe.ECUSetting.Weak > Convert.ToInt32(numuWeak.Maximum) || Services.Stroe.ECUSetting.Weak < Convert.ToInt32(numuWeak.Minimum) ||
             Services.Stroe.ECUSetting.ExtrainjSensitivity > Convert.ToInt32(numuSen.Maximum) || Services.Stroe.ECUSetting.ExtrainjSensitivity < Convert.ToInt32(numuSen.Minimum);
            if (Services.Stroe.ECUSetting.Weak > Convert.ToInt32(numuWeak.Maximum))
                Services.Stroe.ECUSetting.Weak = Convert.ToInt32(numuWeak.Maximum);
            if (Services.Stroe.ECUSetting.Weak < Convert.ToInt32(numuWeak.Minimum))
                Services.Stroe.ECUSetting.Weak = Convert.ToInt32(numuWeak.Minimum);
            if (Services.Stroe.ECUSetting.ExtrainjSensitivity > Convert.ToInt32(numuSen.Maximum))
                Services.Stroe.ECUSetting.ExtrainjSensitivity = Convert.ToInt32(numuSen.Maximum);
            if (Services.Stroe.ECUSetting.ExtrainjSensitivity < Convert.ToInt32(numuSen.Minimum))
                Services.Stroe.ECUSetting.ExtrainjSensitivity = Convert.ToInt32(numuSen.Minimum);
            if (Services.Stroe.ECUSetting.ExtraInjectionIdentTime > Convert.ToSingle(numuIdentTime.Maximum))
                Services.Stroe.ECUSetting.ExtraInjectionIdentTime = Convert.ToSingle(numuIdentTime.Maximum);
            if (Services.Stroe.ECUSetting.ExtraInjectionIdentTime < Convert.ToSingle(numuIdentTime.Minimum))
                Services.Stroe.ECUSetting.ExtraInjectionIdentTime = Convert.ToSingle(numuIdentTime.Minimum);
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
            tsmiEditByValue.Font = new Font(fontFamily, tsmiEditByValue.Font.Size);
            tsmiEditByPercentage.Font = new Font(fontFamily, tsmiEditByPercentage.Font.Size);
            tsmiEditByLinear.Font = new Font(fontFamily, tsmiEditByLinear.Font.Size);
            labSpeedThicken.Font = new Font(fontFamily, labSpeedThicken.Font.Size);
            labWeak.Font = new Font(fontFamily, labWeak.Font.Size);
            cbExtraCutting.Font = new Font(fontFamily, cbExtraCutting.Font.Size);
            cbExtraSen.Font = new Font(fontFamily, cbExtraSen.Font.Size);
            labIdentTime.Font = new Font(fontFamily, labIdentTime.Font.Size);
            textBox1.Text = LangWords ["309_22"];
                //"OBS.:A sensibilidade de injeção e injeção extra," + Environment.NewLine + "são reserentes à injeção de combustível líquido,"+ Environment.NewLine+"podendo causar falhas ou"+ "trancos" +"no veículo.";
            labSpeedThicken.Text = LangWords["309_13"];
            labWeak.Text = LangWords["309_12"];
            cbExtraCutting.Text = LangWords["309_14"];
            cbExtraSen.Text = LangWords["309_15"];
            labIdentTime.Text = LangWords["309_16"];
            tsmiEditByValue.Text = LangWords["305_3"];
            tsmiEditByPercentage.Text = LangWords["305_4"];
            tsmiEditByLinear.Text = LangWords["305_5"];
            ButMapRef.ButtonText = LangWords["309_26"];

            IsInit = false;
        }

        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }
        #endregion
        public IGT.Service.PLC.Device Device { get { return Services.Device; } }
        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }
        bool IsInit = true;

        private void kryptonDataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected
                && Control.ModifierKeys == Keys.Control)
            {
                this.kryptonDataGridView1.CellStateChanged -= kryptonDataGridView1_CellStateChanged;
                e.Cell.Selected = !e.Cell.Selected;
                this.kryptonDataGridView1.CellStateChanged += kryptonDataGridView1_CellStateChanged;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (kryptonDataGridView1.SelectedCells.Count > 0
                && txtForHeaderCell.Visible == false)
            {

                switch (keyData)
                {
                    case Keys.Enter:
                        if (kryptonDataGridView1.SelectedCells.Count > 1)
                            cMenuBatchEdit_Item_Click(tsmiEditByLinear, new ToolStripItemClickedEventArgs(tsmiEditByLinear));
                        return true;
                    case Keys.Control | Keys.Up:
                    case Keys.LControlKey | Keys.Up:
                    case Keys.RControlKey | Keys.Up:
                        SmoothChangingSelectedCells(true); return true;
                    case Keys.Control | Keys.Down:
                    case Keys.LControlKey | Keys.Down:
                    case Keys.RControlKey | Keys.Down:
                        SmoothChangingSelectedCells(false); return true;
                    case Keys.Control | Keys.Left:
                    case Keys.Control | Keys.Right:
                        return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SmoothChangingSelectedCells(bool upORDown)
        {
            var sCells = kryptonDataGridView1.SelectedCells.Cast<DataGridViewTextBoxCell>();
            if (sCells.Any(c => c.IsInEditMode
                || (upORDown && c.Value.ToString() == "50")
                || (!upORDown && c.Value.ToString() == "-50"))) return;
            foreach (var cell in sCells)
            {
                setCellValueStepSafe(cell, upORDown ? 1 : -1);
            }
            var maxCol = sCells.Max(m => m.ColumnIndex);
            var minCol = sCells.Min(m => m.ColumnIndex);
            var maxRow = sCells.Max(m => m.RowIndex);
            var minRow = sCells.Min(m => m.RowIndex);
            foreach (var cell in Get1RoundCells(minRow, maxRow, minCol, maxCol))
                SetCellValueStepSafe(cell, upORDown ? 0.875f : -0.875f);
            foreach (var cell in Get2RoundCells(minRow, maxRow, minCol, maxCol))
                SetCellValueStepSafe(cell, upORDown ? 0.75f : -0.75f);
            foreach (var cell in Get3RoundCells(minRow, maxRow, minCol, maxCol))
                SetCellValueStepSafe(cell, upORDown ? 0.5f : -0.5f);
            foreach (var cell in Get4RoundCells(minRow, maxRow, minCol, maxCol))
                SetCellValueStepSafe(cell, upORDown ? 0.375f : -0.375f);
            Services.Stroe.SaveChanges();
        }
        private void SetCellValueStepSafe(DataGridViewTextBoxCell cell, float addValue)
        {
            if (maps[cell.RowIndex] == null)
            {
                maps[cell.RowIndex] = new float[kryptonDataGridView1.Columns.Count];
            }
            maps[cell.RowIndex][cell.ColumnIndex] += addValue;
            int rAdd = Convert.ToInt32(Math.Round(maps[cell.RowIndex][cell.ColumnIndex], MidpointRounding.AwayFromZero));
            maps[cell.RowIndex][cell.ColumnIndex] -= rAdd;
            int temp = Services.Stroe.MAPCalibrationParams.MAPValues[cell.RowIndex][cell.ColumnIndex] + rAdd;
            if ((temp <= 255)//LDC MAP  原来50
                || (temp >= 0))
            {
                cell.Value = temp.ToString();
                Services.Stroe.MAPCalibrationParams.MAPValues[cell.RowIndex][cell.ColumnIndex] = Convert.ToByte(temp);//LDC MAP修改<Sbyte>改为<byte>
            }
        }
        private void setCellValueStepSafe(DataGridViewTextBoxCell cell, int addValue)
        {
            int temp = int.Parse(cell.Value.ToString()) + addValue;
            if ((temp <= 255)//LDC MAP  原来50
                || (temp >=0))
            {
                cell.Value = temp.ToString();
                Services.Stroe.MAPCalibrationParams.MAPValues[cell.RowIndex][cell.ColumnIndex] = Convert.ToByte(temp);//LDC MAP修改<Sbyte>改为<byte>
            }
        }
        private System.Windows.Forms.NumericUpDown numuAdaptiveRange;
        private IEnumerable<DataGridViewTextBoxCell> Get1RoundCells(int minRow, int maxRow, int minCol, int maxCol)
        {
            int topRowIndex = minRow - 1;
            int bottomRowIndex = maxRow + 1;
            int leftColIndex = minCol - 1;
            int rightColIndex = maxCol + 1;
            bool hasTop = topRowIndex >= 0;
            bool hasBottom = bottomRowIndex < kryptonDataGridView1.Rows.Count;
            bool hasLeft = leftColIndex >= 0;
            bool hasRight = rightColIndex < kryptonDataGridView1.Columns.Count;
            if (hasTop)
            {
                var topRow = kryptonDataGridView1.Rows[topRowIndex];
                for (int i = minCol; i <= maxCol; i++)
                    yield return (DataGridViewTextBoxCell)topRow.Cells[i];
            }
            if (hasBottom)
            {
                var bRow = kryptonDataGridView1.Rows[bottomRowIndex];
                for (int i = minCol; i <= maxCol; i++)
                    yield return (DataGridViewTextBoxCell)bRow.Cells[i];
            }
            for (int row = minRow; row <= maxRow; row++)
            {
                if (hasLeft)
                    yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[row].Cells[leftColIndex];
                if (hasRight)
                    yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[row].Cells[rightColIndex];
            }
        }
        private IEnumerable<DataGridViewTextBoxCell> Get2RoundCells(int minRow, int maxRow, int minCol, int maxCol)
        {
            int topRowIndex = minRow - 1;
            int bottomRowIndex = maxRow + 1;
            int leftColIndex = minCol - 1;
            int rightColIndex = maxCol + 1;
            bool hasTop = topRowIndex >= 0;
            bool hasBottom = bottomRowIndex < kryptonDataGridView1.Rows.Count;
            bool hasLeft = leftColIndex >= 0;
            bool hasRight = rightColIndex < kryptonDataGridView1.Columns.Count;
            if (hasTop && hasLeft)
                yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[topRowIndex].Cells[leftColIndex];
            if (hasTop && hasRight)
                yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[topRowIndex].Cells[rightColIndex];
            if (hasBottom && hasLeft)
                yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[bottomRowIndex].Cells[leftColIndex];
            if (hasBottom && hasRight)
                yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[bottomRowIndex].Cells[rightColIndex];
        }
        private IEnumerable<DataGridViewTextBoxCell> Get3RoundCells(int minRow, int maxRow, int minCol, int maxCol)
        {
            int topRowIndex = minRow - 2;
            int bottomRowIndex = maxRow + 2;
            int leftColIndex = minCol - 2;
            int rightColIndex = maxCol + 2;
            bool hasTop = topRowIndex >= 0;
            bool hasBottom = bottomRowIndex < kryptonDataGridView1.Rows.Count;
            bool hasLeft = leftColIndex >= 0;
            bool hasRight = rightColIndex < kryptonDataGridView1.Columns.Count;
            if (hasTop)
            {
                var topRow = kryptonDataGridView1.Rows[topRowIndex];
                for (int i = minCol; i <= maxCol; i++)
                    yield return (DataGridViewTextBoxCell)topRow.Cells[i];
            }
            if (hasBottom)
            {
                var bRow = kryptonDataGridView1.Rows[bottomRowIndex];
                for (int i = minCol; i <= maxCol; i++)
                    yield return (DataGridViewTextBoxCell)bRow.Cells[i];
            }
            for (int row = minRow; row <= maxRow; row++)
            {
                if (hasLeft)
                    yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[row].Cells[leftColIndex];
                if (hasRight)
                    yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[row].Cells[rightColIndex];
            }
        }
        private IEnumerable<DataGridViewTextBoxCell> Get4RoundCells(int minRow, int maxRow, int minCol, int maxCol)
        {
            Point[] points = { new Point(minCol - 1, minRow - 2), new Point(maxCol + 1, minRow - 2)
                             ,new Point(minCol-1,maxRow+2),new Point(maxCol+1,maxRow+2)
                             ,new Point(minCol-2,minRow-1),new Point(minCol-2,maxRow+1)
                             ,new Point(maxCol+2,minRow-1),new Point(maxCol+2,maxRow+1)};
            foreach (var point in points)
            {
                if (point.X >= 0 && point.X < kryptonDataGridView1.Columns.Count
                    && point.Y >= 0 && point.Y < kryptonDataGridView1.Rows.Count)
                    yield return (DataGridViewTextBoxCell)kryptonDataGridView1.Rows[point.Y].Cells[point.X];
            }
        }

 
        private void qq(object sender, PaintEventArgs e)
        {
            //Graphics gp = e.Graphics;
            //SolidBrush s = new SolidBrush(Color.Red);
            //gp.FillEllipse(s, 490, 390, 100, 100);
            //Graphics graphics = this.CreateGraphics();
            //Pen myPen = new Pen(Color.Black, 3);
            //graphics.DrawEllipse(myPen, 490, 340, 100, 50);
        }

        private void vistaButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(LangWords["309_24"], LangWords["309_23"], MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//LangWords["309_13"];
            {

       //         Services.Stroe.MAPCalibrationParams.MAPValues[0] = new int[] { };
                int[][] MAPValues = new int[][]{
                    new int[]{ 132, 132, 132, 132, 132, 132, 133, 134, 134, 134, 134, 134 },
                    new int[]{ 134, 134, 134, 134, 134, 134, 135, 136, 136, 136, 136, 136 },
                    new int[]{ 146, 146, 146, 146, 146, 146, 147, 148, 148, 148, 148, 148 },           
                    new int[]{ 155, 155, 155, 155, 155, 155, 155, 155, 155, 155, 155, 155 },          
                    new int[]{ 159, 159, 159, 160, 160, 160, 160, 160, 160, 160, 160, 160 },         
                    new int[]{ 156, 156, 157, 158, 158, 158, 158, 159, 159, 159, 159, 159 },   
                    new int[]{ 151, 151, 152, 153, 153, 153, 154, 155, 155, 155, 155, 155 },
                    new int[]{ 139, 139, 139, 139, 139, 139, 140, 142, 142, 142, 142, 142 },
                    new int[]{ 130, 130, 130, 130, 130, 130, 131, 132, 132, 132, 132, 132 },           
                    new int[]{ 126, 126, 126, 126, 126, 126, 127, 128, 128, 128, 128, 128 },          
                    new int[]{ 126, 126, 126, 126, 126, 126, 127, 128, 128, 128, 128, 128 },    
                    new int[]{ 124, 124, 124, 124, 124, 124, 125, 126, 126, 126, 126, 126}
                };
                for (int i = 0; i < 12; i++)
                    for (int j = 0; j < 12; j++)
                    {
                        Store.MAPCalibrationParams.MAPValues[i][j] = MAPValues[i][j];

                    }          
                int[] RPMs = new int[] { 500, 1000,1500,2000,2500,3000,3500,4000,4500,5000,5500,6000 };
                float[] Injection = new float[] { 2.0f, 2.5f, 3.0f, 3.5f, 4.5f, 6.0f, 8.0f, 10.0f, 12.0f,14.0f, 16.0f,18.0f };
                for (int i = 0; i < RPMs.Length; i++)
                {
                    Store.MAPCalibrationParams.RPMs[i] = RPMs[i];
                }
                for (int i = 0; i < Injection.Length; i++)
                {
                    Store.MAPCalibrationParams.Injection[i] = Injection[i];
                }
                Services.Stroe.SaveChanges();
                ShowData();
              }
        }

        private void ButMapRef_Click(object sender, EventArgs e)
        {
            (new MAPset()).ShowDialog();
            ShowData();

        }
    }
}
