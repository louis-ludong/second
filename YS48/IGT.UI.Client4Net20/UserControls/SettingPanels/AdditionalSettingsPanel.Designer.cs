namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class AdditionalSettingsPanel
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
            this.gBoxRunningGasStrategy = new System.Windows.Forms.GroupBox();
            this.numuRunningMinRPM = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ToLab = new System.Windows.Forms.Label();
            this.numuRunningMaxRPM = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbRunningOilInc = new System.Windows.Forms.RadioButton();
            this.rbRunningTijiTime = new System.Windows.Forms.RadioButton();
            this.rbHighRunningGas = new System.Windows.Forms.RadioButton();
            this.labRunningOil = new System.Windows.Forms.Label();
            this.labRunning = new System.Windows.Forms.Label();
            this.numuRunningOil = new System.Windows.Forms.NumericUpDown();
            this.labRunningTijiTime = new System.Windows.Forms.Label();
            this.numuRunningTijiTime = new System.Windows.Forms.NumericUpDown();
            this.labRunningRPM = new System.Windows.Forms.Label();
            this.FromLab = new System.Windows.Forms.Label();
            this.rbRunningonlyGas = new System.Windows.Forms.RadioButton();
            this.rbRunningonlyTijiTime = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numuMinGasRPM = new System.Windows.Forms.NumericUpDown();
            this.rbRunningToOil = new System.Windows.Forms.RadioButton();
            this.labMinGasRPM = new System.Windows.Forms.Label();
            this.labmarcha = new System.Windows.Forms.Label();
            this.cbESAllowed = new System.Windows.Forms.CheckBox();
            this.labESPerformedUsed = new System.Windows.Forms.Label();
            this.numuESPerformedSetting = new System.Windows.Forms.NumericUpDown();
            this.btnESClear = new System.Windows.Forms.Button();
            this.labESPerformed = new System.Windows.Forms.Label();
            this.gboxEmergencyStats = new System.Windows.Forms.GroupBox();
            this.gBoxRunningGasStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningMinRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningMaxRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningTijiTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuMinGasRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuESPerformedSetting)).BeginInit();
            this.gboxEmergencyStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxRunningGasStrategy
            // 
            this.gBoxRunningGasStrategy.Controls.Add(this.numuRunningMinRPM);
            this.gBoxRunningGasStrategy.Controls.Add(this.label7);
            this.gBoxRunningGasStrategy.Controls.Add(this.ToLab);
            this.gBoxRunningGasStrategy.Controls.Add(this.numuRunningMaxRPM);
            this.gBoxRunningGasStrategy.Controls.Add(this.label6);
            this.gBoxRunningGasStrategy.Controls.Add(this.label5);
            this.gBoxRunningGasStrategy.Controls.Add(this.label4);
            this.gBoxRunningGasStrategy.Controls.Add(this.rbRunningOilInc);
            this.gBoxRunningGasStrategy.Controls.Add(this.rbRunningTijiTime);
            this.gBoxRunningGasStrategy.Controls.Add(this.rbHighRunningGas);
            this.gBoxRunningGasStrategy.Controls.Add(this.labRunningOil);
            this.gBoxRunningGasStrategy.Controls.Add(this.labRunning);
            this.gBoxRunningGasStrategy.Controls.Add(this.numuRunningOil);
            this.gBoxRunningGasStrategy.Controls.Add(this.labRunningTijiTime);
            this.gBoxRunningGasStrategy.Controls.Add(this.numuRunningTijiTime);
            this.gBoxRunningGasStrategy.Controls.Add(this.labRunningRPM);
            this.gBoxRunningGasStrategy.Controls.Add(this.FromLab);
            this.gBoxRunningGasStrategy.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.gBoxRunningGasStrategy.Location = new System.Drawing.Point(0, 214);
            this.gBoxRunningGasStrategy.Name = "gBoxRunningGasStrategy";
            this.gBoxRunningGasStrategy.Size = new System.Drawing.Size(769, 324);
            this.gBoxRunningGasStrategy.TabIndex = 69;
            this.gBoxRunningGasStrategy.TabStop = false;
            // 
            // numuRunningMinRPM
            // 
            this.numuRunningMinRPM.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuRunningMinRPM.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numuRunningMinRPM.Location = new System.Drawing.Point(380, 178);
            this.numuRunningMinRPM.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numuRunningMinRPM.Name = "numuRunningMinRPM";
            this.numuRunningMinRPM.ReadOnly = true;
            this.numuRunningMinRPM.Size = new System.Drawing.Size(91, 33);
            this.numuRunningMinRPM.TabIndex = 100;
            this.numuRunningMinRPM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numuRunningMinRPM.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(474, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 103;
            this.label7.Text = "(RPM)";
            // 
            // ToLab
            // 
            this.ToLab.AutoEllipsis = true;
            this.ToLab.AutoSize = true;
            this.ToLab.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToLab.Location = new System.Drawing.Point(536, 180);
            this.ToLab.Name = "ToLab";
            this.ToLab.Size = new System.Drawing.Size(33, 28);
            this.ToLab.TabIndex = 102;
            this.ToLab.Text = "到";
            // 
            // numuRunningMaxRPM
            // 
            this.numuRunningMaxRPM.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuRunningMaxRPM.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numuRunningMaxRPM.Location = new System.Drawing.Point(597, 178);
            this.numuRunningMaxRPM.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numuRunningMaxRPM.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numuRunningMaxRPM.Name = "numuRunningMaxRPM";
            this.numuRunningMaxRPM.ReadOnly = true;
            this.numuRunningMaxRPM.Size = new System.Drawing.Size(91, 33);
            this.numuRunningMaxRPM.TabIndex = 67;
            this.numuRunningMaxRPM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numuRunningMaxRPM.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(605, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 99;
            this.label6.Text = "(ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(605, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 99;
            this.label5.Text = "(ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(690, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 99;
            this.label4.Text = "(RPM)";
            // 
            // rbRunningOilInc
            // 
            this.rbRunningOilInc.AutoSize = true;
            this.rbRunningOilInc.Location = new System.Drawing.Point(23, 88);
            this.rbRunningOilInc.Name = "rbRunningOilInc";
            this.rbRunningOilInc.Size = new System.Drawing.Size(114, 32);
            this.rbRunningOilInc.TabIndex = 72;
            this.rbRunningOilInc.TabStop = true;
            this.rbRunningOilInc.Text = "燃油补偿";
            this.rbRunningOilInc.UseVisualStyleBackColor = true;
            this.rbRunningOilInc.CheckedChanged += new System.EventHandler(this.rbchecked);
            // 
            // rbRunningTijiTime
            // 
            this.rbRunningTijiTime.AutoSize = true;
            this.rbRunningTijiTime.Location = new System.Drawing.Point(23, 126);
            this.rbRunningTijiTime.Name = "rbRunningTijiTime";
            this.rbRunningTijiTime.Size = new System.Drawing.Size(72, 32);
            this.rbRunningTijiTime.TabIndex = 72;
            this.rbRunningTijiTime.TabStop = true;
            this.rbRunningTijiTime.Text = "燃油";
            this.rbRunningTijiTime.UseVisualStyleBackColor = true;
            this.rbRunningTijiTime.CheckedChanged += new System.EventHandler(this.rbchecked);
            // 
            // rbHighRunningGas
            // 
            this.rbHighRunningGas.AutoSize = true;
            this.rbHighRunningGas.BackColor = System.Drawing.Color.Transparent;
            this.rbHighRunningGas.Location = new System.Drawing.Point(23, 50);
            this.rbHighRunningGas.Name = "rbHighRunningGas";
            this.rbHighRunningGas.Size = new System.Drawing.Size(72, 32);
            this.rbHighRunningGas.TabIndex = 72;
            this.rbHighRunningGas.TabStop = true;
            this.rbHighRunningGas.Text = "燃气";
            this.rbHighRunningGas.UseVisualStyleBackColor = false;
            this.rbHighRunningGas.CheckedChanged += new System.EventHandler(this.rbchecked);
            // 
            // labRunningOil
            // 
            this.labRunningOil.AutoEllipsis = true;
            this.labRunningOil.AutoSize = true;
            this.labRunningOil.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRunningOil.Location = new System.Drawing.Point(12, 268);
            this.labRunningOil.Name = "labRunningOil";
            this.labRunningOil.Size = new System.Drawing.Size(117, 28);
            this.labRunningOil.TabIndex = 70;
            this.labRunningOil.Text = "燃油增加量";
            // 
            // labRunning
            // 
            this.labRunning.AutoEllipsis = true;
            this.labRunning.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRunning.Location = new System.Drawing.Point(13, 19);
            this.labRunning.Name = "labRunning";
            this.labRunning.Size = new System.Drawing.Size(579, 28);
            this.labRunning.TabIndex = 63;
            this.labRunning.Text = "高速运行时";
            // 
            // numuRunningOil
            // 
            this.numuRunningOil.DecimalPlaces = 1;
            this.numuRunningOil.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuRunningOil.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuRunningOil.Location = new System.Drawing.Point(467, 266);
            this.numuRunningOil.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numuRunningOil.Name = "numuRunningOil";
            this.numuRunningOil.ReadOnly = true;
            this.numuRunningOil.Size = new System.Drawing.Size(135, 33);
            this.numuRunningOil.TabIndex = 71;
            this.numuRunningOil.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labRunningTijiTime
            // 
            this.labRunningTijiTime.AutoEllipsis = true;
            this.labRunningTijiTime.AutoSize = true;
            this.labRunningTijiTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRunningTijiTime.Location = new System.Drawing.Point(12, 224);
            this.labRunningTijiTime.Name = "labRunningTijiTime";
            this.labRunningTijiTime.Size = new System.Drawing.Size(243, 28);
            this.labRunningTijiTime.TabIndex = 68;
            this.labRunningTijiTime.Text = "燃油增加的喷油时间条件";
            // 
            // numuRunningTijiTime
            // 
            this.numuRunningTijiTime.DecimalPlaces = 1;
            this.numuRunningTijiTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuRunningTijiTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuRunningTijiTime.Location = new System.Drawing.Point(467, 222);
            this.numuRunningTijiTime.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numuRunningTijiTime.Name = "numuRunningTijiTime";
            this.numuRunningTijiTime.ReadOnly = true;
            this.numuRunningTijiTime.Size = new System.Drawing.Size(135, 33);
            this.numuRunningTijiTime.TabIndex = 69;
            this.numuRunningTijiTime.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labRunningRPM
            // 
            this.labRunningRPM.AutoEllipsis = true;
            this.labRunningRPM.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRunningRPM.Location = new System.Drawing.Point(12, 180);
            this.labRunningRPM.Name = "labRunningRPM";
            this.labRunningRPM.Size = new System.Drawing.Size(310, 28);
            this.labRunningRPM.TabIndex = 66;
            this.labRunningRPM.Text = "转速条件";
            // 
            // FromLab
            // 
            this.FromLab.AutoEllipsis = true;
            this.FromLab.AutoSize = true;
            this.FromLab.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FromLab.Location = new System.Drawing.Point(325, 180);
            this.FromLab.Name = "FromLab";
            this.FromLab.Size = new System.Drawing.Size(33, 28);
            this.FromLab.TabIndex = 101;
            this.FromLab.Text = "从";
            this.FromLab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbRunningonlyGas
            // 
            this.rbRunningonlyGas.AutoSize = true;
            this.rbRunningonlyGas.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.rbRunningonlyGas.Location = new System.Drawing.Point(23, 48);
            this.rbRunningonlyGas.Name = "rbRunningonlyGas";
            this.rbRunningonlyGas.Size = new System.Drawing.Size(72, 32);
            this.rbRunningonlyGas.TabIndex = 73;
            this.rbRunningonlyGas.TabStop = true;
            this.rbRunningonlyGas.Text = "燃气";
            this.rbRunningonlyGas.UseVisualStyleBackColor = true;
            this.rbRunningonlyGas.CheckedChanged += new System.EventHandler(this.rbchecked);
            // 
            // rbRunningonlyTijiTime
            // 
            this.rbRunningonlyTijiTime.AutoSize = true;
            this.rbRunningonlyTijiTime.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.rbRunningonlyTijiTime.Location = new System.Drawing.Point(23, 118);
            this.rbRunningonlyTijiTime.Name = "rbRunningonlyTijiTime";
            this.rbRunningonlyTijiTime.Size = new System.Drawing.Size(72, 32);
            this.rbRunningonlyTijiTime.TabIndex = 74;
            this.rbRunningonlyTijiTime.TabStop = true;
            this.rbRunningonlyTijiTime.Text = "燃油";
            this.rbRunningonlyTijiTime.UseVisualStyleBackColor = true;
            this.rbRunningonlyTijiTime.CheckedChanged += new System.EventHandler(this.rbchecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numuMinGasRPM);
            this.groupBox1.Controls.Add(this.rbRunningToOil);
            this.groupBox1.Controls.Add(this.labMinGasRPM);
            this.groupBox1.Controls.Add(this.labmarcha);
            this.groupBox1.Controls.Add(this.rbRunningonlyGas);
            this.groupBox1.Controls.Add(this.rbRunningonlyTijiTime);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 215);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(410, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 99;
            this.label3.Text = "(RPM)";
            // 
            // numuMinGasRPM
            // 
            this.numuMinGasRPM.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuMinGasRPM.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numuMinGasRPM.Location = new System.Drawing.Point(327, 156);
            this.numuMinGasRPM.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numuMinGasRPM.Name = "numuMinGasRPM";
            this.numuMinGasRPM.ReadOnly = true;
            this.numuMinGasRPM.Size = new System.Drawing.Size(78, 33);
            this.numuMinGasRPM.TabIndex = 98;
            this.numuMinGasRPM.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // rbRunningToOil
            // 
            this.rbRunningToOil.AutoSize = true;
            this.rbRunningToOil.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.rbRunningToOil.Location = new System.Drawing.Point(23, 83);
            this.rbRunningToOil.Name = "rbRunningToOil";
            this.rbRunningToOil.Size = new System.Drawing.Size(114, 32);
            this.rbRunningToOil.TabIndex = 100;
            this.rbRunningToOil.TabStop = true;
            this.rbRunningToOil.Text = "转回燃油";
            this.rbRunningToOil.UseVisualStyleBackColor = true;
            this.rbRunningToOil.CheckedChanged += new System.EventHandler(this.rbchecked);
            // 
            // labMinGasRPM
            // 
            this.labMinGasRPM.AutoEllipsis = true;
            this.labMinGasRPM.AutoSize = true;
            this.labMinGasRPM.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMinGasRPM.Location = new System.Drawing.Point(13, 161);
            this.labMinGasRPM.Name = "labMinGasRPM";
            this.labMinGasRPM.Size = new System.Drawing.Size(138, 28);
            this.labMinGasRPM.TabIndex = 97;
            this.labMinGasRPM.Text = "燃气最低转速";
            // 
            // labmarcha
            // 
            this.labmarcha.AutoSize = true;
            this.labmarcha.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.labmarcha.Location = new System.Drawing.Point(13, 17);
            this.labmarcha.Name = "labmarcha";
            this.labmarcha.Size = new System.Drawing.Size(117, 28);
            this.labmarcha.TabIndex = 75;
            this.labmarcha.Text = "怠速运行时";
            // 
            // cbESAllowed
            // 
            this.cbESAllowed.AutoSize = true;
            this.cbESAllowed.Enabled = false;
            this.cbESAllowed.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbESAllowed.Location = new System.Drawing.Point(6, 20);
            this.cbESAllowed.Name = "cbESAllowed";
            this.cbESAllowed.Size = new System.Drawing.Size(69, 29);
            this.cbESAllowed.TabIndex = 53;
            this.cbESAllowed.Text = "允许";
            this.cbESAllowed.UseVisualStyleBackColor = true;
            this.cbESAllowed.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // labESPerformedUsed
            // 
            this.labESPerformedUsed.AutoSize = true;
            this.labESPerformedUsed.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labESPerformedUsed.Location = new System.Drawing.Point(559, 59);
            this.labESPerformedUsed.Name = "labESPerformedUsed";
            this.labESPerformedUsed.Size = new System.Drawing.Size(23, 25);
            this.labESPerformedUsed.TabIndex = 53;
            this.labESPerformedUsed.Text = "0";
            // 
            // numuESPerformedSetting
            // 
            this.numuESPerformedSetting.Enabled = false;
            this.numuESPerformedSetting.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuESPerformedSetting.Location = new System.Drawing.Point(484, 16);
            this.numuESPerformedSetting.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numuESPerformedSetting.Name = "numuESPerformedSetting";
            this.numuESPerformedSetting.ReadOnly = true;
            this.numuESPerformedSetting.Size = new System.Drawing.Size(104, 33);
            this.numuESPerformedSetting.TabIndex = 53;
            this.numuESPerformedSetting.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // btnESClear
            // 
            this.btnESClear.Enabled = false;
            this.btnESClear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnESClear.Location = new System.Drawing.Point(484, 52);
            this.btnESClear.Name = "btnESClear";
            this.btnESClear.Size = new System.Drawing.Size(69, 38);
            this.btnESClear.TabIndex = 56;
            this.btnESClear.Text = "清除";
            this.btnESClear.UseVisualStyleBackColor = true;
            this.btnESClear.Click += new System.EventHandler(this.btn_Click);
            // 
            // labESPerformed
            // 
            this.labESPerformed.AutoSize = true;
            this.labESPerformed.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labESPerformed.Location = new System.Drawing.Point(6, 52);
            this.labESPerformed.Name = "labESPerformed";
            this.labESPerformed.Size = new System.Drawing.Size(50, 25);
            this.labESPerformed.TabIndex = 60;
            this.labESPerformed.Text = "执行";
            // 
            // gboxEmergencyStats
            // 
            this.gboxEmergencyStats.BackColor = System.Drawing.Color.Transparent;
            this.gboxEmergencyStats.Controls.Add(this.labESPerformed);
            this.gboxEmergencyStats.Controls.Add(this.btnESClear);
            this.gboxEmergencyStats.Controls.Add(this.numuESPerformedSetting);
            this.gboxEmergencyStats.Controls.Add(this.labESPerformedUsed);
            this.gboxEmergencyStats.Controls.Add(this.cbESAllowed);
            this.gboxEmergencyStats.Location = new System.Drawing.Point(3, 3);
            this.gboxEmergencyStats.Name = "gboxEmergencyStats";
            this.gboxEmergencyStats.Size = new System.Drawing.Size(766, 97);
            this.gboxEmergencyStats.TabIndex = 68;
            this.gboxEmergencyStats.TabStop = false;
            this.gboxEmergencyStats.Text = "紧急启动";
            this.gboxEmergencyStats.Visible = false;
            // 
            // AdditionalSettingsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gBoxRunningGasStrategy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxEmergencyStats);
            this.DoubleBuffered = true;
            this.Name = "AdditionalSettingsPanel";
            this.Size = new System.Drawing.Size(769, 541);
            this.Load += new System.EventHandler(this.AdditionalSettingsPanel_Load);
            this.gBoxRunningGasStrategy.ResumeLayout(false);
            this.gBoxRunningGasStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningMinRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningMaxRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuRunningTijiTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuMinGasRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuESPerformedSetting)).EndInit();
            this.gboxEmergencyStats.ResumeLayout(false);
            this.gboxEmergencyStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRunningGasStrategy;
        private System.Windows.Forms.Label labRunningOil;
        private System.Windows.Forms.Label labRunning;
        private System.Windows.Forms.NumericUpDown numuRunningOil;
        private System.Windows.Forms.Label labRunningTijiTime;
        private System.Windows.Forms.NumericUpDown numuRunningMaxRPM;
        private System.Windows.Forms.NumericUpDown numuRunningTijiTime;
        private System.Windows.Forms.Label labRunningRPM;
        private System.Windows.Forms.RadioButton rbRunningOilInc;
        private System.Windows.Forms.RadioButton rbRunningTijiTime;
        private System.Windows.Forms.RadioButton rbHighRunningGas;
        private System.Windows.Forms.RadioButton rbRunningonlyTijiTime;
        private System.Windows.Forms.RadioButton rbRunningonlyGas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labmarcha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numuMinGasRPM;
        private System.Windows.Forms.Label labMinGasRPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbRunningToOil;
        private System.Windows.Forms.NumericUpDown numuRunningMinRPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ToLab;
        private System.Windows.Forms.Label FromLab;
        private System.Windows.Forms.CheckBox cbESAllowed;
        private System.Windows.Forms.Label labESPerformedUsed;
        private System.Windows.Forms.NumericUpDown numuESPerformedSetting;
        private System.Windows.Forms.Button btnESClear;
        private System.Windows.Forms.Label labESPerformed;
        private System.Windows.Forms.GroupBox gboxEmergencyStats;
    }
}
