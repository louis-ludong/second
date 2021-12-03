namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class CarParametersSettings
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
            this.numuRPMVoltage = new System.Windows.Forms.NumericUpDown();
            this.cbInjectorPositiveDriver = new System.Windows.Forms.CheckBox();
            this.labRPMVoltage = new System.Windows.Forms.Label();
            this.ddlInjectionModes = new System.Windows.Forms.ComboBox();
            this.ddlSingalType = new System.Windows.Forms.ComboBox();
            this.ddlCylinders = new System.Windows.Forms.ComboBox();
            this.labInjectionModes = new System.Windows.Forms.Label();
            this.labCoilNums = new System.Windows.Forms.Label();
            this.ddlEngineType = new System.Windows.Forms.ComboBox();
            this.labEngineType = new System.Windows.Forms.Label();
            this.numuOrderDelay = new System.Windows.Forms.NumericUpDown();
            this.cbHotStart = new System.Windows.Forms.CheckBox();
            this.labOrderDelay = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.ddlMode = new System.Windows.Forms.ComboBox();
            this.labOverlapTimes = new System.Windows.Forms.Label();
            this.numuOverlapTimes = new System.Windows.Forms.NumericUpDown();
            this.ddlSpeed = new System.Windows.Forms.ComboBox();
            this.ddlTemp = new System.Windows.Forms.ComboBox();
            this.labMode = new System.Windows.Forms.Label();
            this.labSpeed = new System.Windows.Forms.Label();
            this.btnInjectorParam = new System.Windows.Forms.Button();
            this.labInject = new System.Windows.Forms.Label();
            this.ddlInject = new System.Windows.Forms.ComboBox();
            this.rbCNG = new System.Windows.Forms.RadioButton();
            this.rbLPG = new System.Windows.Forms.RadioButton();
            this.labFuelType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlRPMSource = new System.Windows.Forms.ComboBox();
            this.labRPMTyp = new System.Windows.Forms.CheckBox();
            this.CylinderNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numuRPMVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOrderDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOverlapTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // numuRPMVoltage
            // 
            this.numuRPMVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuRPMVoltage.DecimalPlaces = 1;
            this.numuRPMVoltage.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuRPMVoltage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuRPMVoltage.Location = new System.Drawing.Point(455, 303);
            this.numuRPMVoltage.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numuRPMVoltage.Name = "numuRPMVoltage";
            this.numuRPMVoltage.ReadOnly = true;
            this.numuRPMVoltage.Size = new System.Drawing.Size(157, 33);
            this.numuRPMVoltage.TabIndex = 48;
            this.numuRPMVoltage.Visible = false;
            this.numuRPMVoltage.ValueChanged += new System.EventHandler(this.numuRPMVoltage_ValueChanged);
            // 
            // cbInjectorPositiveDriver
            // 
            this.cbInjectorPositiveDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInjectorPositiveDriver.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbInjectorPositiveDriver.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbInjectorPositiveDriver.Location = new System.Drawing.Point(455, 224);
            this.cbInjectorPositiveDriver.Name = "cbInjectorPositiveDriver";
            this.cbInjectorPositiveDriver.Size = new System.Drawing.Size(168, 33);
            this.cbInjectorPositiveDriver.TabIndex = 47;
            this.cbInjectorPositiveDriver.Text = "喷嘴正极驱动";
            this.cbInjectorPositiveDriver.UseVisualStyleBackColor = true;
            this.cbInjectorPositiveDriver.Visible = false;
            this.cbInjectorPositiveDriver.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // labRPMVoltage
            // 
            this.labRPMVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labRPMVoltage.AutoSize = true;
            this.labRPMVoltage.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRPMVoltage.Location = new System.Drawing.Point(453, 268);
            this.labRPMVoltage.Name = "labRPMVoltage";
            this.labRPMVoltage.Size = new System.Drawing.Size(159, 28);
            this.labRPMVoltage.TabIndex = 46;
            this.labRPMVoltage.Text = "转速信门限电压";
            this.labRPMVoltage.Visible = false;
            // 
            // ddlInjectionModes
            // 
            this.ddlInjectionModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlInjectionModes.BackColor = System.Drawing.Color.White;
            this.ddlInjectionModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlInjectionModes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlInjectionModes.FormattingEnabled = true;
            this.ddlInjectionModes.Location = new System.Drawing.Point(231, 198);
            this.ddlInjectionModes.Name = "ddlInjectionModes";
            this.ddlInjectionModes.Size = new System.Drawing.Size(165, 33);
            this.ddlInjectionModes.TabIndex = 42;
            this.ddlInjectionModes.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // ddlSingalType
            // 
            this.ddlSingalType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSingalType.BackColor = System.Drawing.Color.White;
            this.ddlSingalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSingalType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlSingalType.FormattingEnabled = true;
            this.ddlSingalType.Location = new System.Drawing.Point(231, 285);
            this.ddlSingalType.Name = "ddlSingalType";
            this.ddlSingalType.Size = new System.Drawing.Size(165, 33);
            this.ddlSingalType.TabIndex = 41;
            this.ddlSingalType.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // ddlCylinders
            // 
            this.ddlCylinders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlCylinders.BackColor = System.Drawing.Color.White;
            this.ddlCylinders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCylinders.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlCylinders.FormattingEnabled = true;
            this.ddlCylinders.Location = new System.Drawing.Point(231, 111);
            this.ddlCylinders.Name = "ddlCylinders";
            this.ddlCylinders.Size = new System.Drawing.Size(165, 33);
            this.ddlCylinders.TabIndex = 40;
            this.ddlCylinders.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // labInjectionModes
            // 
            this.labInjectionModes.AutoSize = true;
            this.labInjectionModes.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInjectionModes.Location = new System.Drawing.Point(24, 200);
            this.labInjectionModes.Name = "labInjectionModes";
            this.labInjectionModes.Size = new System.Drawing.Size(138, 28);
            this.labInjectionModes.TabIndex = 38;
            this.labInjectionModes.Text = "燃油喷射类型";
            // 
            // labCoilNums
            // 
            this.labCoilNums.AutoSize = true;
            this.labCoilNums.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCoilNums.Location = new System.Drawing.Point(24, 287);
            this.labCoilNums.Name = "labCoilNums";
            this.labCoilNums.Size = new System.Drawing.Size(96, 28);
            this.labCoilNums.TabIndex = 37;
            this.labCoilNums.Text = "点火类型";
            // 
            // ddlEngineType
            // 
            this.ddlEngineType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlEngineType.BackColor = System.Drawing.Color.White;
            this.ddlEngineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEngineType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlEngineType.FormattingEnabled = true;
            this.ddlEngineType.Location = new System.Drawing.Point(639, 378);
            this.ddlEngineType.Name = "ddlEngineType";
            this.ddlEngineType.Size = new System.Drawing.Size(157, 33);
            this.ddlEngineType.TabIndex = 50;
            this.ddlEngineType.Visible = false;
            this.ddlEngineType.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // labEngineType
            // 
            this.labEngineType.AutoSize = true;
            this.labEngineType.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labEngineType.Location = new System.Drawing.Point(462, 379);
            this.labEngineType.Name = "labEngineType";
            this.labEngineType.Size = new System.Drawing.Size(117, 28);
            this.labEngineType.TabIndex = 49;
            this.labEngineType.Text = "发动机类型";
            this.labEngineType.Visible = false;
            // 
            // numuOrderDelay
            // 
            this.numuOrderDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuOrderDelay.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuOrderDelay.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numuOrderDelay.Location = new System.Drawing.Point(639, 333);
            this.numuOrderDelay.Maximum = new decimal(new int[] {
            5100,
            0,
            0,
            0});
            this.numuOrderDelay.Name = "numuOrderDelay";
            this.numuOrderDelay.ReadOnly = true;
            this.numuOrderDelay.Size = new System.Drawing.Size(157, 33);
            this.numuOrderDelay.TabIndex = 105;
            this.numuOrderDelay.Visible = false;
            this.numuOrderDelay.ValueChanged += new System.EventHandler(this.numuRPMVoltage_ValueChanged);
            // 
            // cbHotStart
            // 
            this.cbHotStart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbHotStart.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbHotStart.Location = new System.Drawing.Point(20, 492);
            this.cbHotStart.Name = "cbHotStart";
            this.cbHotStart.Size = new System.Drawing.Size(376, 32);
            this.cbHotStart.TabIndex = 106;
            this.cbHotStart.Text = "发动机热启动";
            this.cbHotStart.UseVisualStyleBackColor = true;
            this.cbHotStart.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // labOrderDelay
            // 
            this.labOrderDelay.AutoEllipsis = true;
            this.labOrderDelay.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOrderDelay.Location = new System.Drawing.Point(462, 351);
            this.labOrderDelay.Name = "labOrderDelay";
            this.labOrderDelay.Size = new System.Drawing.Size(153, 28);
            this.labOrderDelay.TabIndex = 104;
            this.labOrderDelay.Text = "顺序延时";
            this.labOrderDelay.Visible = false;
            // 
            // labTemp
            // 
            this.labTemp.AutoEllipsis = true;
            this.labTemp.AutoSize = true;
            this.labTemp.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTemp.Location = new System.Drawing.Point(24, 328);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(96, 28);
            this.labTemp.TabIndex = 96;
            this.labTemp.Text = "转换温度";
            // 
            // ddlMode
            // 
            this.ddlMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlMode.FormattingEnabled = true;
            this.ddlMode.Location = new System.Drawing.Point(231, 408);
            this.ddlMode.Name = "ddlMode";
            this.ddlMode.Size = new System.Drawing.Size(165, 33);
            this.ddlMode.TabIndex = 102;
            this.ddlMode.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // labOverlapTimes
            // 
            this.labOverlapTimes.AutoEllipsis = true;
            this.labOverlapTimes.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOverlapTimes.Location = new System.Drawing.Point(24, 451);
            this.labOverlapTimes.Name = "labOverlapTimes";
            this.labOverlapTimes.Size = new System.Drawing.Size(201, 28);
            this.labOverlapTimes.TabIndex = 99;
            this.labOverlapTimes.Text = "转换延时";
            // 
            // numuOverlapTimes
            // 
            this.numuOverlapTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuOverlapTimes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuOverlapTimes.Location = new System.Drawing.Point(231, 449);
            this.numuOverlapTimes.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numuOverlapTimes.Name = "numuOverlapTimes";
            this.numuOverlapTimes.ReadOnly = true;
            this.numuOverlapTimes.Size = new System.Drawing.Size(165, 33);
            this.numuOverlapTimes.TabIndex = 103;
            this.numuOverlapTimes.ValueChanged += new System.EventHandler(this.numuRPMVoltage_ValueChanged);
            // 
            // ddlSpeed
            // 
            this.ddlSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSpeed.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlSpeed.FormattingEnabled = true;
            this.ddlSpeed.Location = new System.Drawing.Point(231, 367);
            this.ddlSpeed.Name = "ddlSpeed";
            this.ddlSpeed.Size = new System.Drawing.Size(165, 33);
            this.ddlSpeed.TabIndex = 101;
            this.ddlSpeed.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // ddlTemp
            // 
            this.ddlTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTemp.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlTemp.FormattingEnabled = true;
            this.ddlTemp.Location = new System.Drawing.Point(231, 326);
            this.ddlTemp.Name = "ddlTemp";
            this.ddlTemp.Size = new System.Drawing.Size(165, 33);
            this.ddlTemp.TabIndex = 100;
            this.ddlTemp.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // labMode
            // 
            this.labMode.AutoEllipsis = true;
            this.labMode.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMode.Location = new System.Drawing.Point(24, 410);
            this.labMode.Name = "labMode";
            this.labMode.Size = new System.Drawing.Size(201, 28);
            this.labMode.TabIndex = 98;
            this.labMode.Text = "转换方式";
            // 
            // labSpeed
            // 
            this.labSpeed.AutoEllipsis = true;
            this.labSpeed.AutoSize = true;
            this.labSpeed.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSpeed.Location = new System.Drawing.Point(24, 369);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(96, 28);
            this.labSpeed.TabIndex = 97;
            this.labSpeed.Text = "转换速度";
            // 
            // btnInjectorParam
            // 
            this.btnInjectorParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInjectorParam.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInjectorParam.Location = new System.Drawing.Point(402, 174);
            this.btnInjectorParam.Name = "btnInjectorParam";
            this.btnInjectorParam.Size = new System.Drawing.Size(342, 44);
            this.btnInjectorParam.TabIndex = 109;
            this.btnInjectorParam.Text = "燃气喷嘴设定";
            this.btnInjectorParam.UseVisualStyleBackColor = true;
            this.btnInjectorParam.Visible = false;
            this.btnInjectorParam.Click += new System.EventHandler(this.btn_Click);
            // 
            // labInject
            // 
            this.labInject.AutoEllipsis = true;
            this.labInject.AutoSize = true;
            this.labInject.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInject.Location = new System.Drawing.Point(24, 154);
            this.labInject.Name = "labInject";
            this.labInject.Size = new System.Drawing.Size(138, 28);
            this.labInject.TabIndex = 107;
            this.labInject.Text = "燃气喷轨类型";
            // 
            // ddlInject
            // 
            this.ddlInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlInject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlInject.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlInject.FormattingEnabled = true;
            this.ddlInject.Location = new System.Drawing.Point(231, 154);
            this.ddlInject.Name = "ddlInject";
            this.ddlInject.Size = new System.Drawing.Size(165, 33);
            this.ddlInject.TabIndex = 108;
            this.ddlInject.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // rbCNG
            // 
            this.rbCNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCNG.AutoSize = true;
            this.rbCNG.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbCNG.Location = new System.Drawing.Point(320, 74);
            this.rbCNG.Name = "rbCNG";
            this.rbCNG.Size = new System.Drawing.Size(72, 29);
            this.rbCNG.TabIndex = 95;
            this.rbCNG.TabStop = true;
            this.rbCNG.Text = "CNG";
            this.rbCNG.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbCNG.UseVisualStyleBackColor = true;
            // 
            // rbLPG
            // 
            this.rbLPG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLPG.AutoSize = true;
            this.rbLPG.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbLPG.Location = new System.Drawing.Point(235, 74);
            this.rbLPG.Name = "rbLPG";
            this.rbLPG.Size = new System.Drawing.Size(66, 29);
            this.rbLPG.TabIndex = 94;
            this.rbLPG.TabStop = true;
            this.rbLPG.Text = "LPG";
            this.rbLPG.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbLPG.UseVisualStyleBackColor = true;
            this.rbLPG.CheckedChanged += new System.EventHandler(this.RadioBox_CheckedChanged);
            // 
            // labFuelType
            // 
            this.labFuelType.AutoSize = true;
            this.labFuelType.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFuelType.Location = new System.Drawing.Point(24, 72);
            this.labFuelType.Name = "labFuelType";
            this.labFuelType.Size = new System.Drawing.Size(96, 28);
            this.labFuelType.TabIndex = 49;
            this.labFuelType.Text = "燃料类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(676, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 22);
            this.label5.TabIndex = 110;
            this.label5.Text = "(V)";
            this.label5.Visible = false;
            // 
            // ddlRPMSource
            // 
            this.ddlRPMSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlRPMSource.BackColor = System.Drawing.Color.White;
            this.ddlRPMSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRPMSource.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlRPMSource.FormattingEnabled = true;
            this.ddlRPMSource.Location = new System.Drawing.Point(231, 241);
            this.ddlRPMSource.Name = "ddlRPMSource";
            this.ddlRPMSource.Size = new System.Drawing.Size(165, 33);
            this.ddlRPMSource.TabIndex = 112;
            this.ddlRPMSource.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectIndexChanged);
            // 
            // labRPMTyp
            // 
            this.labRPMTyp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labRPMTyp.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRPMTyp.Location = new System.Drawing.Point(-30, 241);
            this.labRPMTyp.Name = "labRPMTyp";
            this.labRPMTyp.Size = new System.Drawing.Size(207, 33);
            this.labRPMTyp.TabIndex = 113;
            this.labRPMTyp.Text = "转速信号类型";
            this.labRPMTyp.UseVisualStyleBackColor = true;
            this.labRPMTyp.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // CylinderNumber
            // 
            this.CylinderNumber.AutoSize = true;
            this.CylinderNumber.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CylinderNumber.Location = new System.Drawing.Point(24, 113);
            this.CylinderNumber.Name = "CylinderNumber";
            this.CylinderNumber.Size = new System.Drawing.Size(54, 28);
            this.CylinderNumber.TabIndex = 114;
            this.CylinderNumber.Text = "缸数";
            // 
            // CarParametersSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CylinderNumber);
            this.Controls.Add(this.labRPMTyp);
            this.Controls.Add(this.ddlRPMSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numuOrderDelay);
            this.Controls.Add(this.cbHotStart);
            this.Controls.Add(this.labOrderDelay);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.ddlMode);
            this.Controls.Add(this.labOverlapTimes);
            this.Controls.Add(this.numuOverlapTimes);
            this.Controls.Add(this.ddlSpeed);
            this.Controls.Add(this.ddlTemp);
            this.Controls.Add(this.labMode);
            this.Controls.Add(this.labSpeed);
            this.Controls.Add(this.btnInjectorParam);
            this.Controls.Add(this.labInject);
            this.Controls.Add(this.ddlInject);
            this.Controls.Add(this.rbCNG);
            this.Controls.Add(this.rbLPG);
            this.Controls.Add(this.numuRPMVoltage);
            this.Controls.Add(this.labRPMVoltage);
            this.Controls.Add(this.cbInjectorPositiveDriver);
            this.Controls.Add(this.ddlInjectionModes);
            this.Controls.Add(this.labInjectionModes);
            this.Controls.Add(this.labFuelType);
            this.Controls.Add(this.labEngineType);
            this.Controls.Add(this.ddlEngineType);
            this.Controls.Add(this.ddlCylinders);
            this.Controls.Add(this.labCoilNums);
            this.Controls.Add(this.ddlSingalType);
            this.DoubleBuffered = true;
            this.Name = "CarParametersSettings";
            this.Size = new System.Drawing.Size(769, 541);
            ((System.ComponentModel.ISupportInitialize)(this.numuRPMVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOrderDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuOverlapTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numuRPMVoltage;
        private System.Windows.Forms.CheckBox cbInjectorPositiveDriver;
        private System.Windows.Forms.Label labRPMVoltage;
        private System.Windows.Forms.ComboBox ddlInjectionModes;
        private System.Windows.Forms.ComboBox ddlSingalType;
        private System.Windows.Forms.ComboBox ddlCylinders;
        private System.Windows.Forms.Label labInjectionModes;
        private System.Windows.Forms.Label labCoilNums;
        private System.Windows.Forms.ComboBox ddlEngineType;
        private System.Windows.Forms.Label labEngineType;
        private System.Windows.Forms.NumericUpDown numuOrderDelay;
        private System.Windows.Forms.CheckBox cbHotStart;
        private System.Windows.Forms.Label labOrderDelay;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.ComboBox ddlMode;
        private System.Windows.Forms.Label labOverlapTimes;
        private System.Windows.Forms.NumericUpDown numuOverlapTimes;
        private System.Windows.Forms.ComboBox ddlSpeed;
        private System.Windows.Forms.ComboBox ddlTemp;
        private System.Windows.Forms.Label labMode;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.Button btnInjectorParam;
        private System.Windows.Forms.Label labInject;
        private System.Windows.Forms.ComboBox ddlInject;
        private System.Windows.Forms.RadioButton rbCNG;
        private System.Windows.Forms.RadioButton rbLPG;
        private System.Windows.Forms.Label labFuelType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlRPMSource;
        private System.Windows.Forms.CheckBox labRPMTyp;
        private System.Windows.Forms.Label CylinderNumber;

    }
}
