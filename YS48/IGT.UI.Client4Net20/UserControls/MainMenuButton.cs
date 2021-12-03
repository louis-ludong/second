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
    public partial class MainMenuButton : UserControl
    {
        public static readonly IList<MainMenuButton> GlobelCollicts = new List<MainMenuButton>();
        public MainMenuButton()
        {
            InitializeComponent();
            GlobelCollicts.Add(this);
        }
        public void Switch(bool normalOrHover)
        {
            BackgroundImage = normalOrHover ? NormalBack : HoverBack;
            label1.BackColor = normalOrHover ? NormalColor : HoverColor;
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            HoverFlag = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            HoverFlag = false;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (HoverFlag == true) return;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (!this.DisplayRectangle.Contains(this.PointToClient(MousePosition)))
            {
                HoverFlag = false;
                base.OnMouseLeave(e);
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
                label1.Font = value;
                base.Font = value;
            }
        }



        public Color NormalColor
        {
            get { return normalColor; }
            set { normalColor = value; label1.BackColor = value; }
        }

        public Color HoverColor { get; set; }
        public Image NormalBack
        {
            get { return image1; }
            set
            {
                image1 = value;
                BackgroundImage = image1;
            }
        }

        public Image HoverBack { get; set; }
        public String LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        bool HoverFlag = false;
        private Image image1;
        private Color normalColor;

        private void label1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
