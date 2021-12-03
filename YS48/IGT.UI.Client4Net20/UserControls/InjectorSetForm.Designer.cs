namespace IGT.UI.Client.UserControls
{
    partial class InjectorSetForm
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
            this.labMinOpenTime = new System.Windows.Forms.Label();
            this.numuMinOpenTime = new System.Windows.Forms.NumericUpDown();
            this.labCorrectionTime = new System.Windows.Forms.Label();
            this.numuMaxOpenTime = new System.Windows.Forms.NumericUpDown();
            this.numuCorrectionTime = new System.Windows.Forms.NumericUpDown();
            this.labMaxOpenTime = new System.Windows.Forms.Label();
            this.labOpenKeepTime = new System.Windows.Forms.Label();
            this.numuInjectEmptyScale = new System.Windows.Forms.NumericUpDown();
            this.numuOpenKeepTime = new System.Windows.Forms.NumericUpDown();
            this.labInjectEmptyScale = new System.Windows.Forms.Label();
            this.myMenuStrip1 = new IGT.UI.Client.UserControls.MyMenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numuMinOpenTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuMaxOpenTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuCorrectionTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuInjectEmptyScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOpenKeepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labMinOpenTime
            // 
            this.labMinOpenTime.AutoSize = true;
            this.labMinOpenTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMinOpenTime.Location = new System.Drawing.Point(12, 167);
            this.labMinOpenTime.Name = "labMinOpenTime";
            this.labMinOpenTime.Size = new System.Drawing.Size(138, 28);
            this.labMinOpenTime.TabIndex = 90;
            this.labMinOpenTime.Text = "最小开启时间";
            // 
            // numuMinOpenTime
            // 
            this.numuMinOpenTime.DecimalPlaces = 1;
            this.numuMinOpenTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuMinOpenTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuMinOpenTime.Location = new System.Drawing.Point(251, 162);
            this.numuMinOpenTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numuMinOpenTime.Name = "numuMinOpenTime";
            this.numuMinOpenTime.ReadOnly = true;
            this.numuMinOpenTime.Size = new System.Drawing.Size(120, 33);
            this.numuMinOpenTime.TabIndex = 91;
            this.numuMinOpenTime.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labCorrectionTime
            // 
            this.labCorrectionTime.AutoSize = true;
            this.labCorrectionTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCorrectionTime.Location = new System.Drawing.Point(12, 233);
            this.labCorrectionTime.Name = "labCorrectionTime";
            this.labCorrectionTime.Size = new System.Drawing.Size(96, 28);
            this.labCorrectionTime.TabIndex = 92;
            this.labCorrectionTime.Text = "修正时间";
            // 
            // numuMaxOpenTime
            // 
            this.numuMaxOpenTime.DecimalPlaces = 1;
            this.numuMaxOpenTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuMaxOpenTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuMaxOpenTime.Location = new System.Drawing.Point(251, 89);
            this.numuMaxOpenTime.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numuMaxOpenTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numuMaxOpenTime.Name = "numuMaxOpenTime";
            this.numuMaxOpenTime.ReadOnly = true;
            this.numuMaxOpenTime.Size = new System.Drawing.Size(120, 33);
            this.numuMaxOpenTime.TabIndex = 99;
            this.numuMaxOpenTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numuMaxOpenTime.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // numuCorrectionTime
            // 
            this.numuCorrectionTime.DecimalPlaces = 1;
            this.numuCorrectionTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuCorrectionTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuCorrectionTime.Location = new System.Drawing.Point(251, 228);
            this.numuCorrectionTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numuCorrectionTime.Name = "numuCorrectionTime";
            this.numuCorrectionTime.ReadOnly = true;
            this.numuCorrectionTime.Size = new System.Drawing.Size(120, 33);
            this.numuCorrectionTime.TabIndex = 93;
            this.numuCorrectionTime.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labMaxOpenTime
            // 
            this.labMaxOpenTime.AutoSize = true;
            this.labMaxOpenTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMaxOpenTime.Location = new System.Drawing.Point(12, 94);
            this.labMaxOpenTime.Name = "labMaxOpenTime";
            this.labMaxOpenTime.Size = new System.Drawing.Size(138, 28);
            this.labMaxOpenTime.TabIndex = 98;
            this.labMaxOpenTime.Text = "最大开启时间";
            // 
            // labOpenKeepTime
            // 
            this.labOpenKeepTime.AutoSize = true;
            this.labOpenKeepTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOpenKeepTime.Location = new System.Drawing.Point(12, 297);
            this.labOpenKeepTime.Name = "labOpenKeepTime";
            this.labOpenKeepTime.Size = new System.Drawing.Size(138, 28);
            this.labOpenKeepTime.TabIndex = 94;
            this.labOpenKeepTime.Text = "全开保持时间";
            // 
            // numuInjectEmptyScale
            // 
            this.numuInjectEmptyScale.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuInjectEmptyScale.Location = new System.Drawing.Point(251, 364);
            this.numuInjectEmptyScale.Name = "numuInjectEmptyScale";
            this.numuInjectEmptyScale.ReadOnly = true;
            this.numuInjectEmptyScale.Size = new System.Drawing.Size(120, 33);
            this.numuInjectEmptyScale.TabIndex = 97;
            this.numuInjectEmptyScale.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // numuOpenKeepTime
            // 
            this.numuOpenKeepTime.DecimalPlaces = 1;
            this.numuOpenKeepTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuOpenKeepTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuOpenKeepTime.Location = new System.Drawing.Point(251, 292);
            this.numuOpenKeepTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numuOpenKeepTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numuOpenKeepTime.Name = "numuOpenKeepTime";
            this.numuOpenKeepTime.ReadOnly = true;
            this.numuOpenKeepTime.Size = new System.Drawing.Size(120, 33);
            this.numuOpenKeepTime.TabIndex = 95;
            this.numuOpenKeepTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numuOpenKeepTime.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labInjectEmptyScale
            // 
            this.labInjectEmptyScale.AutoSize = true;
            this.labInjectEmptyScale.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInjectEmptyScale.Location = new System.Drawing.Point(12, 369);
            this.labInjectEmptyScale.Name = "labInjectEmptyScale";
            this.labInjectEmptyScale.Size = new System.Drawing.Size(159, 28);
            this.labInjectEmptyScale.TabIndex = 96;
            this.labInjectEmptyScale.Text = "喷轨输出占空比";
            // 
            // myMenuStrip1
            // 
            this.myMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.myMenuStrip1.Name = "myMenuStrip1";
            this.myMenuStrip1.ShowCloseButton = true;
            this.myMenuStrip1.ShowConnictMenuButton = true;
            this.myMenuStrip1.ShowGraphMenuButton = false;
            this.myMenuStrip1.ShowMinButton = true;
            this.myMenuStrip1.Size = new System.Drawing.Size(399, 59);
            this.myMenuStrip1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IGT.UI.Client.Properties.Resources.TopBar_CloseButton;
            this.pictureBox1.Location = new System.Drawing.Point(361, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InjectorSetForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labMinOpenTime);
            this.Controls.Add(this.numuMinOpenTime);
            this.Controls.Add(this.labCorrectionTime);
            this.Controls.Add(this.numuMaxOpenTime);
            this.Controls.Add(this.numuCorrectionTime);
            this.Controls.Add(this.labMaxOpenTime);
            this.Controls.Add(this.labOpenKeepTime);
            this.Controls.Add(this.numuInjectEmptyScale);
            this.Controls.Add(this.numuOpenKeepTime);
            this.Controls.Add(this.labInjectEmptyScale);
            this.Controls.Add(this.myMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InjectorSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InjectorSetForm";
            ((System.ComponentModel.ISupportInitialize)(this.numuMinOpenTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuMaxOpenTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuCorrectionTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuInjectEmptyScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOpenKeepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyMenuStrip myMenuStrip1;
        private System.Windows.Forms.Label labMinOpenTime;
        private System.Windows.Forms.NumericUpDown numuMinOpenTime;
        private System.Windows.Forms.Label labCorrectionTime;
        private System.Windows.Forms.NumericUpDown numuMaxOpenTime;
        private System.Windows.Forms.NumericUpDown numuCorrectionTime;
        private System.Windows.Forms.Label labMaxOpenTime;
        private System.Windows.Forms.Label labOpenKeepTime;
        private System.Windows.Forms.NumericUpDown numuInjectEmptyScale;
        private System.Windows.Forms.NumericUpDown numuOpenKeepTime;
        private System.Windows.Forms.Label labInjectEmptyScale;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}