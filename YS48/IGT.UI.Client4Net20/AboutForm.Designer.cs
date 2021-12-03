namespace IGT.UI.Client
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelTel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVerN = new System.Windows.Forms.Label();
            this.labelVer = new System.Windows.Forms.Label();
            this.labelWeb = new System.Windows.Forms.Label();
            this.myMenuStrip1 = new IGT.UI.Client.UserControls.MyMenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IGT.UI.Client.Properties.Resources.TopBar_CloseButton;
            this.pictureBox1.Location = new System.Drawing.Point(292, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(68, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 22);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Website:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTel.Location = new System.Drawing.Point(7, 87);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(39, 22);
            this.labelTel.TabIndex = 31;
            this.labelTel.Text = "Tel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "telphone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(169, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "IGT";
            this.label3.Visible = false;
            // 
            // labelVerN
            // 
            this.labelVerN.AutoSize = true;
            this.labelVerN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelVerN.Location = new System.Drawing.Point(68, 181);
            this.labelVerN.Name = "labelVerN";
            this.labelVerN.Size = new System.Drawing.Size(46, 22);
            this.labelVerN.TabIndex = 34;
            this.labelVerN.Text = "V3.8";
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVer.Location = new System.Drawing.Point(7, 181);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(42, 22);
            this.labelVer.TabIndex = 33;
            this.labelVer.Text = "Ver:";
            // 
            // labelWeb
            // 
            this.labelWeb.AutoSize = true;
            this.labelWeb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWeb.Location = new System.Drawing.Point(7, 134);
            this.labelWeb.Name = "labelWeb";
            this.labelWeb.Size = new System.Drawing.Size(52, 22);
            this.labelWeb.TabIndex = 35;
            this.labelWeb.Text = "Web:";
            // 
            // myMenuStrip1
            // 
            this.myMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myMenuStrip1.Enabled = false;
            this.myMenuStrip1.Location = new System.Drawing.Point(2, 0);
            this.myMenuStrip1.Name = "myMenuStrip1";
            this.myMenuStrip1.ShowCloseButton = false;
            this.myMenuStrip1.ShowConnictMenuButton = true;
            this.myMenuStrip1.ShowGraphMenuButton = false;
            this.myMenuStrip1.ShowMinButton = true;
            this.myMenuStrip1.Size = new System.Drawing.Size(330, 58);
            this.myMenuStrip1.TabIndex = 27;
            // 
            // AboutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.labelWeb);
            this.Controls.Add(this.labelVerN);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.MyMenuStrip myMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVerN;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.Label labelWeb;
    }
}