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
    public partial class InjectorsMeasurement : UserControl
    {
        public InjectorsMeasurement()
        {
            InitializeComponent();
        }

        private void InjectorsMeasurement_Load(object sender, EventArgs e)
        {

        }
        private void SetValue(int value)
        {
            if (value < 40) value = 40;
            else if (value > 255) value = 255;
            int x = 40;
            x = 32 + 285 * (value - 40) / 240;
            pbCursor.Location = new Point(x, pbCursor.Location.Y);
        }
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; SetValue(value); }
        }
    }
}
