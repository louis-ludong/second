using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class TempCorrectionSettingsPanel : UserControl,ISettingPanel,Service.Language.IMultLang
    {
        public TempCorrectionSettingsPanel()
        {
            InitializeComponent();
            ApplyLang();
        }

        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }
        private void TempCorrectionSettingsPanel_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            IsInit = true;
            var rModel = Services.Stroe.CorrectionSetting.Red;
            var gModel = Services.Stroe.CorrectionSetting.Gas;
            SetData4Temp(kryptonDataGridView1, rModel);
            SetData4Temp(kryptonDataGridView2, gModel);
            SetData4Press(kryptonDataGridView3, Services.Stroe.CorrectionSetting.GasPress);
            IsInit = false;
        }
        void SetData4Press(ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGrid, Service.Storage.CorrectionSetting.NotityPressCorrectionSet model)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
            DataGridViewRow row1 = new DataGridViewRow();
            row1.HeaderCell.Value = LangWords["306_7"];
            var row2 = new DataGridViewRow();
            row2.HeaderCell.Value = LangWords["306_2"];

            for (int i = 0; i < model.Items.Count; i++)
            {
                dataGrid.Columns.Add(i.ToString(), i.ToString());
                dataGrid.Columns[i].Width = 41;//LDC 原来38
                row1.Cells.Add(new DataGridViewTextBoxCell() { Value = model.Items[i].ToString("N2") });
                row2.Cells.Add(new DataGridViewTextBoxCell() { Value = model.Corrections[i].ToString("N1") });
            }
            dataGrid.Rows.Add(row1);
            dataGrid.Rows.Add(row2);
        }
        void SetData4Temp(ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGrid, Service.Storage.CorrectionSetting.NotityTempCorrectionSet model)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
            DataGridViewRow row1 = new DataGridViewRow();
            row1.HeaderCell.Value = LangWords["306_1"];
            var row2 = new DataGridViewRow();
            row2.HeaderCell.Value = LangWords["306_2"];

            for (int i = 0; i < model.Corrections.Count; i++)
            {
                dataGrid.Columns.Add(i.ToString(), i.ToString());
                dataGrid.Columns[i].Width = 66;
            }
            int j = model.Temps.Count;
            for (int i = 0; i < model.Temps.Count; i++)
            {
                row1.Cells.Add(new DataGridViewTextBoxCell() { Value = model.Temps[j-1].ToString() });
                row2.Cells.Add(new DataGridViewTextBoxCell() { Value = model.Corrections[j].ToString() });
                j--;
            }
            var overCellIndex1 = row1.Cells.Add(new DataGridViewTextBoxCell() { Value = LangWords["306_3"] });
            row1.Cells[overCellIndex1].ReadOnly = true;
           // row2.Cells.Add(new DataGridViewTextBoxCell() { Value = model.Over });
            row2.Cells.Add(new DataGridViewTextBoxCell() { Value = model.Corrections[0].ToString() });
            dataGrid.Rows.Add(row1);
            dataGrid.Rows.Add(row2);

        }

        private void kryptonDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            sbyte value;
            if (e.RowIndex == 0 && e.ColumnIndex == kryptonDataGridView1.Columns.Count - 1
                || !sbyte.TryParse(kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value))
            {
                kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue1;
                return;
            }
            if (e.RowIndex == 0)
            {
                if (value > 100) value = 100;
                else if (value < -100) value = -100;
                if (Services.Stroe.CorrectionSetting.Red.Temps.Contains(value))
                    kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue1;
                else
                {
                    Services.Stroe.CorrectionSetting.Red.Temps[7-e.ColumnIndex] = value;
                    Services.Stroe.SaveChanges();
                }
            }
            else
            {
                if (value > 127) value = 127;
                else if (value < -128) value = -128;
                Services.Stroe.CorrectionSetting.Red.Corrections[8-e.ColumnIndex] = value;
                Services.Stroe.SaveChanges();
            }
            kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
        }
        object oldValue1;
        private void kryptonDataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue1 = kryptonDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        object oldValue2;
        private void kryptonDataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue2 = kryptonDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void kryptonDataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            sbyte value;
            if (e.RowIndex == 0 && e.ColumnIndex == kryptonDataGridView2.Columns.Count - 1
                || !sbyte.TryParse(kryptonDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value))
            {
                kryptonDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue2;
                return;
            }
            if (e.RowIndex == 0)
            {
                if (value > 100) value = 100;
                else if (value < -100) value = -100;
                if (Services.Stroe.CorrectionSetting.Gas.Temps.Contains(value))
                    kryptonDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue2;
                else
                {
                    Services.Stroe.CorrectionSetting.Gas.Temps[7-e.ColumnIndex] = value;
                    Services.Stroe.SaveChanges();
                }
            }
            else
            {
                if (value > 127) value = 127;
                else if (value < -128) value = -128;
                Services.Stroe.CorrectionSetting.Gas.Corrections[8-e.ColumnIndex] = value;
                Services.Stroe.SaveChanges();
            }
            kryptonDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;

        }
        object oldValue3;
        private void kryptonDataGridView3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue3 = kryptonDataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void kryptonDataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == 0)
            {
                float value;
                if (!float.TryParse(kryptonDataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value))
                {
                    kryptonDataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue3;
                    return;
                }
                if (value > 2.55f) value = 2.55f;
                else if (value < 0) value = 0f;
                if (Services.Stroe.CorrectionSetting.GasPress.Items.Contains(value))
                    kryptonDataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue3;
                else
                {
                    Services.Stroe.CorrectionSetting.GasPress.Items[e.ColumnIndex] = value;
                    Services.Stroe.SaveChanges();
                }
            }
            else
            {
                float value;//LDC int----float
                if (!float.TryParse(kryptonDataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value))//LDC int----float
                {
                    kryptonDataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue3;
                    return;
                }
                if (value > 127) value = 127;
                else if (value < -128) value = -128;
                Services.Stroe.CorrectionSetting.GasPress.Corrections[e.ColumnIndex] = value;
                Services.Stroe.SaveChanges();
            }

        }

        private bool  IsInit = false;

        public void ApplyLang()
        { 
            IsInit = true;
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            labGas.Font = new Font(fontFamily, labGas.Font.Size);
            labRed.Font = new Font(fontFamily, labRed.Font.Size);
            labGasPress.Font = new Font(fontFamily, labGasPress.Font.Size);
            labGas.Text = LangWords["306_4"];
            labRed.Text = LangWords["306_5"];
            labGasPress.Text = LangWords["306_6"];
            textBox1 .Text =LangWords ["306_8"];
            textBox2.Text = LangWords["306_9"];
            IsInit = false;
        }
        public Dictionary<String, String> LangWords
        { get { return Services.Lang.CurrentWords; } }
    }
}
