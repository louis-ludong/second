using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    public partial class RealTimeGraphForm : Form
    {
        private Dictionary<double, Models.Feedback.RealTimeData> dic;

        public RealTimeGraphForm(Dictionary<double, Models.Feedback.RealTimeData> dic)
        {
            this.dic = dic;
            InitializeComponent();
            UIHelper.CommonSet(this);
            myMenuStrip1.HideAllMenus();
        }
        private void RealTimeGraphForm_Load(object sender, EventArgs e)
        {
            ApplyLang();
            lineGas.Title = LangWords["903"];
            lineGasLevel.Title = LangWords["908"];
            lineGasPress.Title = LangWords["904"];
            lineMAPPress.Title = LangWords["905"];
            linePetrol.Title = LangWords["902"];
            lineRPM.Title = LangWords["909"] + " X 100";
            lineTempGas.Title = LangWords["907"] + " X 10";
            lineTempRed.Title = LangWords["906"] + "X 10";
            foreach (var item in dic)
            {
                lineGas.Add(Convert.ToInt32(item.Key), item.Value.GasesTime);
                lineGasLevel.Add(Convert.ToInt32(item.Key), item.Value.GasLevel);
                lineGasPress.Add(Convert.ToInt32(item.Key), item.Value.GasPress);
                lineMAPPress.Add(Convert.ToInt32(item.Key), item.Value.MAPPress);
                linePetrol.Add(Convert.ToInt32(item.Key), item.Value.PetrolsTime);
                lineRPM.Add(Convert.ToInt32(item.Key), item.Value.RPM / 100);
                lineTempGas.Add(Convert.ToInt32(item.Key), item.Value.TempGas / 10);
                lineTempRed.Add(Convert.ToInt32(item.Key), item.Value.TempRed / 10);
            }
        }

        public void ApplyLang()
        {
            this.Text = LangWords["901"];
            myMenuStrip1.ApplyLang();
        }
        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }
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
