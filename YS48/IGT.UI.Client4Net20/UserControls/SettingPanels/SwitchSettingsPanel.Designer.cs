namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class SwitchSettingsPanel
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
            this.numuMiniGasTemp = new System.Windows.Forms.NumericUpDown();
            this.labMiniGasTemp = new System.Windows.Forms.Label();
            this.numuMinimumPress = new System.Windows.Forms.NumericUpDown();
            this.numuOperationalPress = new System.Windows.Forms.NumericUpDown();
            this.labMinimumPress = new System.Windows.Forms.Label();
            this.labOperationalPress = new System.Windows.Forms.Label();
            this.numuPressError = new System.Windows.Forms.NumericUpDown();
            this.labPressErrorTime = new System.Windows.Forms.Label();
            this.btnInjectorCorrection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbInjetPositiveDrive = new System.Windows.Forms.CheckBox();
            this.cbStartAndStop = new System.Windows.Forms.CheckBox();
            this.cbValvetronik = new System.Windows.Forms.CheckBox();
            this.cBStartOnGas = new System.Windows.Forms.CheckBox();
            this.cBAnticipate = new System.Windows.Forms.CheckBox();
            this.labAnticipate = new System.Windows.Forms.Label();
            this.numBackTransitionTm = new System.Windows.Forms.NumericUpDown();
            this.cbBackTransition = new System.Windows.Forms.CheckBox();
            this.labcbBackTransition = new System.Windows.Forms.Label();
            this.labGasFillTime = new System.Windows.Forms.Label();
            this.numGasFillTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numuMiniGasTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuMinimumPress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOperationalPress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuPressError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackTransitionTm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasFillTime)).BeginInit();
            this.SuspendLayout();
            // 
            // numuMiniGasTemp
            // 
            this.numuMiniGasTemp.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuMiniGasTemp.Location = new System.Drawing.Point(322, 165);
            this.numuMiniGasTemp.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numuMiniGasTemp.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.numuMiniGasTemp.Name = "numuMiniGasTemp";
            this.numuMiniGasTemp.ReadOnly = true;
            this.numuMiniGasTemp.Size = new System.Drawing.Size(67, 33);
            this.numuMiniGasTemp.TabIndex = 65;
            this.numuMiniGasTemp.ValueChanged += new System.EventHandler(this.Numu_ValueChanged);
            // 
            // labMiniGasTemp
            // 
            this.labMiniGasTemp.AutoEllipsis = true;
            this.labMiniGasTemp.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMiniGasTemp.Location = new System.Drawing.Point(47, 167);
            this.labMiniGasTemp.Name = "labMiniGasTemp";
            this.labMiniGasTemp.Size = new System.Drawing.Size(263, 28);
            this.labMiniGasTemp.TabIndex = 64;
            this.labMiniGasTemp.Text = "燃气最低温度";
            // 
            // numuMinimumPress
            // 
            this.numuMinimumPress.DecimalPlaces = 2;
            this.numuMinimumPress.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuMinimumPress.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numuMinimumPress.Location = new System.Drawing.Point(322, 125);
            this.numuMinimumPress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            131072});
            this.numuMinimumPress.Name = "numuMinimumPress";
            this.numuMinimumPress.ReadOnly = true;
            this.numuMinimumPress.Size = new System.Drawing.Size(67, 33);
            this.numuMinimumPress.TabIndex = 63;
            this.numuMinimumPress.ValueChanged += new System.EventHandler(this.Numu_ValueChanged);
            // 
            // numuOperationalPress
            // 
            this.numuOperationalPress.DecimalPlaces = 2;
            this.numuOperationalPress.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuOperationalPress.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numuOperationalPress.Location = new System.Drawing.Point(322, 85);
            this.numuOperationalPress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            131072});
            this.numuOperationalPress.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            131072});
            this.numuOperationalPress.Name = "numuOperationalPress";
            this.numuOperationalPress.ReadOnly = true;
            this.numuOperationalPress.Size = new System.Drawing.Size(67, 33);
            this.numuOperationalPress.TabIndex = 62;
            this.numuOperationalPress.Value = new decimal(new int[] {
            60,
            0,
            0,
            131072});
            this.numuOperationalPress.ValueChanged += new System.EventHandler(this.Numu_ValueChanged);
            // 
            // labMinimumPress
            // 
            this.labMinimumPress.AutoEllipsis = true;
            this.labMinimumPress.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMinimumPress.Location = new System.Drawing.Point(47, 127);
            this.labMinimumPress.Name = "labMinimumPress";
            this.labMinimumPress.Size = new System.Drawing.Size(263, 28);
            this.labMinimumPress.TabIndex = 61;
            this.labMinimumPress.Text = "燃气最低压力";
            // 
            // labOperationalPress
            // 
            this.labOperationalPress.AutoEllipsis = true;
            this.labOperationalPress.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOperationalPress.Location = new System.Drawing.Point(47, 87);
            this.labOperationalPress.Name = "labOperationalPress";
            this.labOperationalPress.Size = new System.Drawing.Size(263, 28);
            this.labOperationalPress.TabIndex = 60;
            this.labOperationalPress.Text = "燃气工作压力";
            // 
            // numuPressError
            // 
            this.numuPressError.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuPressError.Location = new System.Drawing.Point(322, 206);
            this.numuPressError.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numuPressError.Name = "numuPressError";
            this.numuPressError.ReadOnly = true;
            this.numuPressError.Size = new System.Drawing.Size(67, 33);
            this.numuPressError.TabIndex = 69;
            this.numuPressError.ValueChanged += new System.EventHandler(this.Numu_ValueChanged);
            // 
            // labPressErrorTime
            // 
            this.labPressErrorTime.AutoEllipsis = true;
            this.labPressErrorTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPressErrorTime.Location = new System.Drawing.Point(47, 208);
            this.labPressErrorTime.Name = "labPressErrorTime";
            this.labPressErrorTime.Size = new System.Drawing.Size(269, 28);
            this.labPressErrorTime.TabIndex = 68;
            this.labPressErrorTime.Text = "压力故障时间";
            // 
            // btnInjectorCorrection
            // 
            this.btnInjectorCorrection.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInjectorCorrection.Location = new System.Drawing.Point(357, 315);
            this.btnInjectorCorrection.Name = "btnInjectorCorrection";
            this.btnInjectorCorrection.Size = new System.Drawing.Size(242, 35);
            this.btnInjectorCorrection.TabIndex = 94;
            this.btnInjectorCorrection.Text = "喷轨参数设定";
            this.btnInjectorCorrection.UseVisualStyleBackColor = true;
            this.btnInjectorCorrection.Visible = false;
            this.btnInjectorCorrection.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(395, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "(Bar)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(395, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 95;
            this.label2.Text = "(Bar)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(395, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 95;
            this.label4.Text = "(S)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(395, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 95;
            this.label5.Text = "(℃)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.pictureBox3.Location = new System.Drawing.Point(461, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 33);
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.pictureBox2.Location = new System.Drawing.Point(461, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // cbInjetPositiveDrive
            // 
            this.cbInjetPositiveDrive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbInjetPositiveDrive.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbInjetPositiveDrive.Location = new System.Drawing.Point(368, 277);
            this.cbInjetPositiveDrive.Name = "cbInjetPositiveDrive";
            this.cbInjetPositiveDrive.Size = new System.Drawing.Size(318, 32);
            this.cbInjetPositiveDrive.TabIndex = 107;
            this.cbInjetPositiveDrive.Text = "Inject positive drive";
            this.cbInjetPositiveDrive.UseVisualStyleBackColor = true;
            this.cbInjetPositiveDrive.Visible = false;
            this.cbInjetPositiveDrive.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // cbStartAndStop
            // 
            this.cbStartAndStop.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStartAndStop.Location = new System.Drawing.Point(53, 248);
            this.cbStartAndStop.Name = "cbStartAndStop";
            this.cbStartAndStop.Size = new System.Drawing.Size(250, 32);
            this.cbStartAndStop.TabIndex = 108;
            this.cbStartAndStop.Text = "Start/Stop";
            this.cbStartAndStop.UseVisualStyleBackColor = true;
            this.cbStartAndStop.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // cbValvetronik
            // 
            this.cbValvetronik.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbValvetronik.Location = new System.Drawing.Point(53, 289);
            this.cbValvetronik.Name = "cbValvetronik";
            this.cbValvetronik.Size = new System.Drawing.Size(250, 32);
            this.cbValvetronik.TabIndex = 108;
            this.cbValvetronik.Text = "Valvetronik";
            this.cbValvetronik.UseVisualStyleBackColor = true;
            this.cbValvetronik.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // cBStartOnGas
            // 
            this.cBStartOnGas.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBStartOnGas.Location = new System.Drawing.Point(53, 329);
            this.cBStartOnGas.Name = "cBStartOnGas";
            this.cBStartOnGas.Size = new System.Drawing.Size(250, 32);
            this.cBStartOnGas.TabIndex = 108;
            this.cBStartOnGas.Text = "Start on gas";
            this.cBStartOnGas.UseVisualStyleBackColor = true;
            this.cBStartOnGas.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // cBAnticipate
            // 
            this.cBAnticipate.AutoSize = true;
            this.cBAnticipate.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBAnticipate.Location = new System.Drawing.Point(53, 367);
            this.cBAnticipate.Name = "cBAnticipate";
            this.cBAnticipate.Size = new System.Drawing.Size(370, 32);
            this.cBAnticipate.TabIndex = 108;
            this.cBAnticipate.Text = "Anticipate the injection sequence";
            this.cBAnticipate.UseVisualStyleBackColor = true;
            this.cBAnticipate.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // labAnticipate
            // 
            this.labAnticipate.AutoEllipsis = true;
            this.labAnticipate.AutoSize = true;
            this.labAnticipate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labAnticipate.Location = new System.Drawing.Point(66, 402);
            this.labAnticipate.Name = "labAnticipate";
            this.labAnticipate.Size = new System.Drawing.Size(432, 21);
            this.labAnticipate.TabIndex = 68;
            this.labAnticipate.Text = "Incompatible with petrol strategy when running on gas";
            // 
            // numBackTransitionTm
            // 
            this.numBackTransitionTm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numBackTransitionTm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.numBackTransitionTm.Location = new System.Drawing.Point(391, 460);
            this.numBackTransitionTm.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numBackTransitionTm.Name = "numBackTransitionTm";
            this.numBackTransitionTm.ReadOnly = true;
            this.numBackTransitionTm.Size = new System.Drawing.Size(49, 29);
            this.numBackTransitionTm.TabIndex = 118;
            this.numBackTransitionTm.ValueChanged += new System.EventHandler(this.Numu_ValueChanged);
            // 
            // cbBackTransition
            // 
            this.cbBackTransition.AutoSize = true;
            this.cbBackTransition.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBackTransition.Location = new System.Drawing.Point(52, 426);
            this.cbBackTransition.Name = "cbBackTransition";
            this.cbBackTransition.Size = new System.Drawing.Size(398, 32);
            this.cbBackTransition.TabIndex = 117;
            this.cbBackTransition.Text = "Cut-off petrol switch-back transition";
            this.cbBackTransition.UseVisualStyleBackColor = true;
            this.cbBackTransition.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // labcbBackTransition
            // 
            this.labcbBackTransition.AutoEllipsis = true;
            this.labcbBackTransition.AutoSize = true;
            this.labcbBackTransition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labcbBackTransition.Location = new System.Drawing.Point(64, 464);
            this.labcbBackTransition.Name = "labcbBackTransition";
            this.labcbBackTransition.Size = new System.Drawing.Size(256, 21);
            this.labcbBackTransition.TabIndex = 116;
            this.labcbBackTransition.Text = "Injections for petrol switch-back";
            // 
            // labGasFillTime
            // 
            this.labGasFillTime.AutoEllipsis = true;
            this.labGasFillTime.AutoSize = true;
            this.labGasFillTime.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.labGasFillTime.Location = new System.Drawing.Point(48, 499);
            this.labGasFillTime.Name = "labGasFillTime";
            this.labGasFillTime.Size = new System.Drawing.Size(302, 28);
            this.labGasFillTime.TabIndex = 116;
            this.labGasFillTime.Text = "Increase gas pipe filling time";
            // 
            // numGasFillTime
            // 
            this.numGasFillTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numGasFillTime.DecimalPlaces = 1;
            this.numGasFillTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.numGasFillTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGasFillTime.Location = new System.Drawing.Point(439, 499);
            this.numGasFillTime.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numGasFillTime.Name = "numGasFillTime";
            this.numGasFillTime.ReadOnly = true;
            this.numGasFillTime.Size = new System.Drawing.Size(49, 29);
            this.numGasFillTime.TabIndex = 118;
            this.numGasFillTime.ValueChanged += new System.EventHandler(this.Numu_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(494, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 95;
            this.label3.Text = "(S)";
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // SwitchSettingsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.numGasFillTime);
            this.Controls.Add(this.numBackTransitionTm);
            this.Controls.Add(this.cbBackTransition);
            this.Controls.Add(this.labGasFillTime);
            this.Controls.Add(this.labcbBackTransition);
            this.Controls.Add(this.cBAnticipate);
            this.Controls.Add(this.cBStartOnGas);
            this.Controls.Add(this.cbValvetronik);
            this.Controls.Add(this.cbStartAndStop);
            this.Controls.Add(this.cbInjetPositiveDrive);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numuPressError);
            this.Controls.Add(this.btnInjectorCorrection);
            this.Controls.Add(this.labOperationalPress);
            this.Controls.Add(this.labAnticipate);
            this.Controls.Add(this.labPressErrorTime);
            this.Controls.Add(this.labMinimumPress);
            this.Controls.Add(this.labMiniGasTemp);
            this.Controls.Add(this.numuOperationalPress);
            this.Controls.Add(this.numuMiniGasTemp);
            this.Controls.Add(this.numuMinimumPress);
            this.DoubleBuffered = true;
            this.Name = "SwitchSettingsPanel";
            this.Size = new System.Drawing.Size(769, 541);
            ((System.ComponentModel.ISupportInitialize)(this.numuMiniGasTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuMinimumPress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOperationalPress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuPressError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackTransitionTm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasFillTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numuMiniGasTemp;
        private System.Windows.Forms.Label labMiniGasTemp;
        private System.Windows.Forms.NumericUpDown numuMinimumPress;
        private System.Windows.Forms.NumericUpDown numuOperationalPress;
        private System.Windows.Forms.Label labMinimumPress;
        private System.Windows.Forms.Label labOperationalPress;
        private System.Windows.Forms.NumericUpDown numuPressError;
        private System.Windows.Forms.Label labPressErrorTime;
        private System.Windows.Forms.Button btnInjectorCorrection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbInjetPositiveDrive;
        private System.Windows.Forms.CheckBox cbStartAndStop;
        private System.Windows.Forms.CheckBox cbValvetronik;
        private System.Windows.Forms.CheckBox cBStartOnGas;
        private System.Windows.Forms.CheckBox cBAnticipate;
        private System.Windows.Forms.Label labAnticipate;
        private System.Windows.Forms.NumericUpDown numBackTransitionTm;
        private System.Windows.Forms.CheckBox cbBackTransition;
        private System.Windows.Forms.Label labcbBackTransition;
        private System.Windows.Forms.Label labGasFillTime;
        private System.Windows.Forms.NumericUpDown numGasFillTime;
        private System.Windows.Forms.Label label3;

    }
}
