using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls
{
    public partial class DiaLine : UserControl
    {
        public DiaLine()
        {
            InitializeComponent();
        }
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                label1.Font = this.Font;
                label2.Font = this.Font;
                base.Font = value;
            }
        }
        private void tpbGasON1_Click(object sender, EventArgs e)
        {
            if (!this.MyEnable) return;
            tpbGasOFF1.Enabled = false;
            tpbGasON1.Enabled = false;
            if (ClickON_OR_Off != null) ClickON_OR_Off(this,true);
        }

        private void tpbGasOFF1_Click(object sender, EventArgs e)
        {
            if (!this.MyEnable) return;
            tpbGasOFF1.Enabled = false;
            tpbGasON1.Enabled = false;
            if (ClickON_OR_Off != null) ClickON_OR_Off(this,false);
        }
        public String LeftLabel { get { return label1.Text; } set { label1.Text = value; } }
        public String RightLabel { get { return label2.Text; } set { label2.Text = value; } }
        public bool ON
        {
            get { return _ON; }
            set { 
                _ON = value;
                tpbGasOFF1.Toggle(!_ON);
                tpbGasON1.Toggle(!_ON);
                tpbGasON1.Enabled = (!_ON)&&MyEnable;
                tpbGasOFF1.Enabled = _ON&&MyEnable;
            }
        }
        [DefaultValue(true)]
        private bool _MyEnable=true;

        public bool MyEnable
        {
            get { return _MyEnable; }
            set { _MyEnable = value; 
                //tpbGasOFF1.Enabled = _MyEnable;
                //tpbGasON1.Enabled = _MyEnable;
            }
        }

        private bool _ON;
        public event ClickON_OR_OffHandel ClickON_OR_Off;
        public delegate void ClickON_OR_OffHandel(object sender,bool on_or_off);
    }
}
