using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls
{
    public partial class RealTimeDataLabel : UserControl
    {
        public RealTimeDataLabel()
        {
            InitializeComponent();
            //this.BackColor = Services.Theme.RealTimeDataBackColor;
        }
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = Color.Transparent;
                label2.BackColor = value;
            }
        }
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                this.label1.Font = this.Font;
                this.label2.Font = new Font(this.Font.FontFamily, this.Font.Size);
            }
        }
        public String ValueText { get { return label1.Text; } set { label1.Text = value; } }
        public String UnitText { get { return label2.Text; } set { label2.Text = value; } }
    }
}
