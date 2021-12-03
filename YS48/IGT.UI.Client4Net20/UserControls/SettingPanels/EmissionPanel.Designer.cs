namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class EmissionPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab1Low = new System.Windows.Forms.Label();
            this.numu1Low = new System.Windows.Forms.NumericUpDown();
            this.lab1Hight = new System.Windows.Forms.Label();
            this.numu1Hight = new System.Windows.Forms.NumericUpDown();
            this.lab2Low = new System.Windows.Forms.Label();
            this.numu2Low = new System.Windows.Forms.NumericUpDown();
            this.lab2Hight = new System.Windows.Forms.Label();
            this.numu2Hight = new System.Windows.Forms.NumericUpDown();
            this.numuDealy = new System.Windows.Forms.NumericUpDown();
            this.labDealy = new System.Windows.Forms.Label();
            this.numuNumber = new System.Windows.Forms.NumericUpDown();
            this.labNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numu1Low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numu1Hight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numu2Low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numu2Hight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuDealy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1Low
            // 
            this.lab1Low.AutoSize = true;
            this.lab1Low.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab1Low.Location = new System.Drawing.Point(81, 288);
            this.lab1Low.Name = "lab1Low";
            this.lab1Low.Size = new System.Drawing.Size(122, 22);
            this.lab1Low.TabIndex = 47;
            this.lab1Low.Text = "仿真输出低电平";
            // 
            // numu1Low
            // 
            this.numu1Low.DecimalPlaces = 1;
            this.numu1Low.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numu1Low.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numu1Low.Location = new System.Drawing.Point(209, 283);
            this.numu1Low.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numu1Low.Name = "numu1Low";
            this.numu1Low.ReadOnly = true;
            this.numu1Low.Size = new System.Drawing.Size(48, 33);
            this.numu1Low.TabIndex = 46;
            this.numu1Low.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // lab1Hight
            // 
            this.lab1Hight.AutoSize = true;
            this.lab1Hight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab1Hight.Location = new System.Drawing.Point(77, 249);
            this.lab1Hight.Name = "lab1Hight";
            this.lab1Hight.Size = new System.Drawing.Size(122, 22);
            this.lab1Hight.TabIndex = 45;
            this.lab1Hight.Text = "仿真输出高电平";
            // 
            // numu1Hight
            // 
            this.numu1Hight.DecimalPlaces = 1;
            this.numu1Hight.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numu1Hight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numu1Hight.Location = new System.Drawing.Point(209, 244);
            this.numu1Hight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numu1Hight.Name = "numu1Hight";
            this.numu1Hight.ReadOnly = true;
            this.numu1Hight.Size = new System.Drawing.Size(48, 33);
            this.numu1Hight.TabIndex = 44;
            this.numu1Hight.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // lab2Low
            // 
            this.lab2Low.AutoSize = true;
            this.lab2Low.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab2Low.Location = new System.Drawing.Point(77, 427);
            this.lab2Low.Name = "lab2Low";
            this.lab2Low.Size = new System.Drawing.Size(122, 22);
            this.lab2Low.TabIndex = 47;
            this.lab2Low.Text = "仿真输出低电平";
            // 
            // numu2Low
            // 
            this.numu2Low.DecimalPlaces = 1;
            this.numu2Low.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numu2Low.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numu2Low.Location = new System.Drawing.Point(229, 422);
            this.numu2Low.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numu2Low.Name = "numu2Low";
            this.numu2Low.ReadOnly = true;
            this.numu2Low.Size = new System.Drawing.Size(48, 33);
            this.numu2Low.TabIndex = 46;
            this.numu2Low.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // lab2Hight
            // 
            this.lab2Hight.AutoSize = true;
            this.lab2Hight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab2Hight.Location = new System.Drawing.Point(77, 378);
            this.lab2Hight.Name = "lab2Hight";
            this.lab2Hight.Size = new System.Drawing.Size(122, 22);
            this.lab2Hight.TabIndex = 45;
            this.lab2Hight.Text = "仿真输出高电平";
            // 
            // numu2Hight
            // 
            this.numu2Hight.DecimalPlaces = 1;
            this.numu2Hight.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numu2Hight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numu2Hight.Location = new System.Drawing.Point(229, 373);
            this.numu2Hight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numu2Hight.Name = "numu2Hight";
            this.numu2Hight.ReadOnly = true;
            this.numu2Hight.Size = new System.Drawing.Size(48, 33);
            this.numu2Hight.TabIndex = 44;
            this.numu2Hight.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // numuDealy
            // 
            this.numuDealy.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuDealy.Location = new System.Drawing.Point(347, 198);
            this.numuDealy.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numuDealy.Name = "numuDealy";
            this.numuDealy.ReadOnly = true;
            this.numuDealy.Size = new System.Drawing.Size(157, 33);
            this.numuDealy.TabIndex = 52;
            this.numuDealy.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labDealy
            // 
            this.labDealy.AutoSize = true;
            this.labDealy.BackColor = System.Drawing.Color.Transparent;
            this.labDealy.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDealy.Location = new System.Drawing.Point(342, 150);
            this.labDealy.Name = "labDealy";
            this.labDealy.Size = new System.Drawing.Size(180, 28);
            this.labDealy.TabIndex = 51;
            this.labDealy.Text = "氧传感器仿真延时";
            // 
            // numuNumber
            // 
            this.numuNumber.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuNumber.Location = new System.Drawing.Point(347, 407);
            this.numuNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numuNumber.Name = "numuNumber";
            this.numuNumber.ReadOnly = true;
            this.numuNumber.Size = new System.Drawing.Size(157, 33);
            this.numuNumber.TabIndex = 54;
            this.numuNumber.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.BackColor = System.Drawing.Color.Transparent;
            this.labNumber.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNumber.Location = new System.Drawing.Point(342, 360);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(222, 28);
            this.labNumber.TabIndex = 53;
            this.labNumber.Text = "氧传感器喷射学习数量";
            // 
            // EmissionPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lab1Hight);
            this.Controls.Add(this.numu1Low);
            this.Controls.Add(this.numu1Hight);
            this.Controls.Add(this.lab1Low);
            this.Controls.Add(this.lab2Hight);
            this.Controls.Add(this.lab2Low);
            this.Controls.Add(this.numu2Hight);
            this.Controls.Add(this.numuNumber);
            this.Controls.Add(this.numu2Low);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.numuDealy);
            this.Controls.Add(this.labDealy);
            this.DoubleBuffered = true;
            this.Name = "EmissionPanel";
            this.Size = new System.Drawing.Size(769, 541);
            ((System.ComponentModel.ISupportInitialize)(this.numu1Low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numu1Hight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numu2Low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numu2Hight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuDealy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numu1Hight;
        private System.Windows.Forms.Label lab1Low;
        private System.Windows.Forms.NumericUpDown numu1Low;
        private System.Windows.Forms.Label lab1Hight;
        private System.Windows.Forms.Label lab2Low;
        private System.Windows.Forms.NumericUpDown numu2Low;
        private System.Windows.Forms.Label lab2Hight;
        private System.Windows.Forms.NumericUpDown numu2Hight;
        private System.Windows.Forms.NumericUpDown numuDealy;
        private System.Windows.Forms.Label labDealy;
        private System.Windows.Forms.NumericUpDown numuNumber;
        private System.Windows.Forms.Label labNumber;
    }
}
