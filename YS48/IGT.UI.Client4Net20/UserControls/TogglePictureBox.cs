using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls
{
    public partial class TogglePictureBox : Control
    {
        public TogglePictureBox()
        {
            InitializeComponent();
        }
        public void Toggle(bool oneOrTwo)
        {
            if (this.OneORTwo != oneOrTwo)
            {
                BackgroundImage = oneOrTwo ? Image1 : Image2;
            }
        }
        public void Toggle()
        {
            if (this.OneORTwo)
                BackgroundImage = Image2;
            else
                BackgroundImage = Image1;
        }
        private Image image1;

        public Image Image1
        {
            get { return image1; }
            set
            {
                image1 = value;
                BackgroundImage = image1;
            }
        }

        public Image Image2 { get; set; }
        bool OneORTwo { get { return this.BackgroundImage != Image2; } }
    }
}
