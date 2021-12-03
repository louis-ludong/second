namespace IGT.UI.Client.Pages
{
    partial class AutoCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCalibration));
            this.labCorrect = new System.Windows.Forms.Label();
            this.labTooSmall = new System.Windows.Forms.Label();
            this.labTooBig = new System.Windows.Forms.Label();
            this.labeInje = new System.Windows.Forms.Label();
            this.labGas = new System.Windows.Forms.Label();
            this.labRed = new System.Windows.Forms.Label();
            this.daSCGRPM = new DasNetGauge.DAS_Net_CircleGauge();
            this.dasTempGasTemp = new DasNetTemperature.DAS_Net_Temperature();
            this.dasTempRedTemp = new DasNetTemperature.DAS_Net_Temperature();
            this.labMapPress = new System.Windows.Forms.Label();
            this.labGasPress = new System.Windows.Forms.Label();
            this.labGas1 = new System.Windows.Forms.Label();
            this.labPetrol1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pBarCalibration = new System.Windows.Forms.ProgressBar();
            this.labTipCalibration = new System.Windows.Forms.Label();
            this.cbAllWork = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.labLambda2 = new System.Windows.Forms.Label();
            this.labLambda1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtlLambda2 = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlLambda1 = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlGasPress = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlMapPress = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlGas = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlPetrol = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.tpbSolenoidValveStatus = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbIgnitionStatus = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED7 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED6 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED5 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED4 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED3 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED2 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED1 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.injectorsMeasurement1 = new IGT.UI.Client.UserControls.InjectorsMeasurement();
            this.tpbSwitchKey = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCorrect
            // 
            this.labCorrect.Font = new System.Drawing.Font("宋体", 11F);
            this.labCorrect.Location = new System.Drawing.Point(169, 444);
            this.labCorrect.Name = "labCorrect";
            this.labCorrect.Size = new System.Drawing.Size(78, 20);
            this.labCorrect.TabIndex = 126;
            this.labCorrect.Text = "correct";
            this.labCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTooSmall
            // 
            this.labTooSmall.AutoSize = true;
            this.labTooSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labTooSmall.Font = new System.Drawing.Font("宋体", 11F);
            this.labTooSmall.ForeColor = System.Drawing.Color.White;
            this.labTooSmall.Location = new System.Drawing.Point(249, 445);
            this.labTooSmall.Name = "labTooSmall";
            this.labTooSmall.Size = new System.Drawing.Size(71, 15);
            this.labTooSmall.TabIndex = 125;
            this.labTooSmall.Text = "TooSmall";
            this.labTooSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTooBig
            // 
            this.labTooBig.AutoSize = true;
            this.labTooBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labTooBig.Font = new System.Drawing.Font("宋体", 11F);
            this.labTooBig.ForeColor = System.Drawing.Color.White;
            this.labTooBig.Location = new System.Drawing.Point(62, 445);
            this.labTooBig.Name = "labTooBig";
            this.labTooBig.Size = new System.Drawing.Size(55, 15);
            this.labTooBig.TabIndex = 124;
            this.labTooBig.Text = "TooBig";
            this.labTooBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeInje
            // 
            this.labeInje.AutoSize = true;
            this.labeInje.BackColor = System.Drawing.Color.Transparent;
            this.labeInje.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeInje.Location = new System.Drawing.Point(71, 375);
            this.labeInje.Name = "labeInje";
            this.labeInje.Size = new System.Drawing.Size(74, 21);
            this.labeInje.TabIndex = 122;
            this.labeInje.Text = "喷嘴口径";
            // 
            // labGas
            // 
            this.labGas.AutoSize = true;
            this.labGas.BackColor = System.Drawing.Color.Transparent;
            this.labGas.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGas.Location = new System.Drawing.Point(188, 246);
            this.labGas.Name = "labGas";
            this.labGas.Size = new System.Drawing.Size(74, 21);
            this.labGas.TabIndex = 121;
            this.labGas.Text = "燃气温度";
            // 
            // labRed
            // 
            this.labRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labRed.AutoSize = true;
            this.labRed.BackColor = System.Drawing.Color.Transparent;
            this.labRed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed.Location = new System.Drawing.Point(44, 306);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(90, 21);
            this.labRed.TabIndex = 120;
            this.labRed.Text = "减压器温度";
            // 
            // daSCGRPM
            // 
            this.daSCGRPM.AntiClockwise = false;
            this.daSCGRPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.BkGradient = true;
            this.daSCGRPM.BkGradientAngle = 45;
            this.daSCGRPM.BkGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.BkGradientRate = 0.9F;
            this.daSCGRPM.BkGradientType = DasNetGauge.DAS_BkGradientStyle.BKGS_Shine;
            this.daSCGRPM.BkShinePosition = 1F;
            this.daSCGRPM.BkTransparency = 0F;
            this.daSCGRPM.BorderExteriorColor = System.Drawing.Color.Blue;
            this.daSCGRPM.BorderExteriorLength = 0;
            this.daSCGRPM.BorderGradientAngle = 225;
            this.daSCGRPM.BorderGradientLightPos1 = 0.4F;
            this.daSCGRPM.BorderGradientLightPos2 = 0.7F;
            this.daSCGRPM.BorderGradientRate = 0.8F;
            this.daSCGRPM.BorderGradientType = DasNetGauge.DAS_BorderGradientStyle.BGS_Path;
            this.daSCGRPM.BorderLightIntermediateBrightness = 0.7F;
            this.daSCGRPM.BorderShape = DasNetGauge.DAS_BorderStyle.BS_Circle;
            this.daSCGRPM.ControlShadow = false;
            this.daSCGRPM.InnerBorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.InnerBorderLength = 0;
            this.daSCGRPM.InnerBorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.Location = new System.Drawing.Point(332, 47);
            this.daSCGRPM.Max = 7000D;
            this.daSCGRPM.MiddleBorderColor = System.Drawing.Color.Gray;
            this.daSCGRPM.MiddleBorderLength = 0;
            this.daSCGRPM.Min = 0D;
            this.daSCGRPM.Name = "daSCGRPM";
            this.daSCGRPM.NeedleBallFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.NeedleBallGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.NeedleBallLineColor = System.Drawing.Color.DarkGray;
            this.daSCGRPM.NeedleBallSize = 10;
            this.daSCGRPM.NeedleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.NeedleGradient = false;
            this.daSCGRPM.NeedleGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.NeedleLineColor = System.Drawing.Color.DimGray;
            this.daSCGRPM.NeedlePieAngle = 30;
            this.daSCGRPM.NeedleType = DasNetGauge.DAS_NeedleStyle.Stick;
            this.daSCGRPM.OuterBorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.OuterBorderLength = 8;
            this.daSCGRPM.OuterBorderLightColor = System.Drawing.Color.WhiteSmoke;
            this.daSCGRPM.OuterTextHGap = 20;
            this.daSCGRPM.OuterTextVGap = 20;
            this.daSCGRPM.Precision = 0;
            this.daSCGRPM.RoundRadius = 30;
            this.daSCGRPM.ScaleAngularGap = 90;
            this.daSCGRPM.ScaleRingBorderColor = System.Drawing.Color.Black;
            this.daSCGRPM.ScaleRingBorderType = DasNetGauge.DAS_ScaleRingBorderStyle.None;
            this.daSCGRPM.ScaleRingColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.ScaleRingGradient = false;
            this.daSCGRPM.ScaleRingTransparency = 1F;
            this.daSCGRPM.ScaleRingWidth = 18;
            this.daSCGRPM.ScaleTextColor = System.Drawing.Color.Black;
            this.daSCGRPM.ScaleTextPosition = DasNetGauge.DAS_ShowPositionStyle.Inner;
            this.daSCGRPM.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.ShadowDepth = 8;
            this.daSCGRPM.ShadowRate = 0.5F;
            this.daSCGRPM.Size = new System.Drawing.Size(321, 308);
            this.daSCGRPM.SubTickerFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.SubTickerLength = 6;
            this.daSCGRPM.SubTickerNumber = 4;
            this.daSCGRPM.SubTickerShape = DasNetGauge.DAS_TickerShapeStyle.Line;
            this.daSCGRPM.SubTickerWidth = 1;
            this.daSCGRPM.TabIndex = 119;
            this.daSCGRPM.Text = "daS_Net_CircleGauge1";
            this.daSCGRPM.TickerAlignment = DasNetGauge.DAS_TickerAlignmentStyle.Outer;
            this.daSCGRPM.TickerFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.TickerLength = 12;
            this.daSCGRPM.TickerLineColor = System.Drawing.Color.Black;
            this.daSCGRPM.TickerNumber = 8;
            this.daSCGRPM.TickerShape = DasNetGauge.DAS_TickerShapeStyle.Circle;
            this.daSCGRPM.TickerWidth = 1;
            this.daSCGRPM.Value = 0D;
            this.daSCGRPM.ValueColor = System.Drawing.Color.Black;
            this.daSCGRPM.ValueTextBox = false;
            this.daSCGRPM.ValueVisible = true;
            // 
            // dasTempGasTemp
            // 
            this.dasTempGasTemp.ActualValueVisible = true;
            this.dasTempGasTemp.AlarmMarkerVisible = false;
            this.dasTempGasTemp.AlarmValueVisible = false;
            this.dasTempGasTemp.BackColor = System.Drawing.Color.Transparent;
            this.dasTempGasTemp.BkGradient = false;
            this.dasTempGasTemp.BkGradientAngle = 90;
            this.dasTempGasTemp.BkGradientColor = System.Drawing.Color.Transparent;
            this.dasTempGasTemp.BkGradientRate = 0.5F;
            this.dasTempGasTemp.BkGradientType = DasNetTemperature.DAS_BkGradientStyle.BKGS_Linear;
            this.dasTempGasTemp.BkShinePosition = 1F;
            this.dasTempGasTemp.BkTransparency = 0F;
            this.dasTempGasTemp.BorderExteriorColor = System.Drawing.Color.Blue;
            this.dasTempGasTemp.BorderExteriorLength = 0;
            this.dasTempGasTemp.BorderGradientAngle = 225;
            this.dasTempGasTemp.BorderGradientLightPos1 = 1F;
            this.dasTempGasTemp.BorderGradientLightPos2 = -1F;
            this.dasTempGasTemp.BorderGradientRate = 0.5F;
            this.dasTempGasTemp.BorderGradientType = DasNetTemperature.DAS_BorderGradientStyle.BGS_None;
            this.dasTempGasTemp.BorderLightIntermediateBrightness = 0F;
            this.dasTempGasTemp.BorderShape = DasNetTemperature.DAS_BorderStyle.BS_RoundRect;
            this.dasTempGasTemp.BulbVisible = true;
            this.dasTempGasTemp.ControlShadow = false;
            this.dasTempGasTemp.ForeColor = System.Drawing.Color.Black;
            this.dasTempGasTemp.HighAlarmColor = System.Drawing.Color.Red;
            this.dasTempGasTemp.HighAlarmLimit = 90D;
            this.dasTempGasTemp.HighWarningColor = System.Drawing.Color.Yellow;
            this.dasTempGasTemp.HighWarningLimit = 70D;
            this.dasTempGasTemp.InnerBorderDarkColor = System.Drawing.Color.DimGray;
            this.dasTempGasTemp.InnerBorderLength = 5;
            this.dasTempGasTemp.InnerBorderLightColor = System.Drawing.Color.Transparent;
            this.dasTempGasTemp.Location = new System.Drawing.Point(167, 31);
            this.dasTempGasTemp.LowAlarmColor = System.Drawing.Color.Blue;
            this.dasTempGasTemp.LowAlarmLimit = 10D;
            this.dasTempGasTemp.LowWarningColor = System.Drawing.Color.Green;
            this.dasTempGasTemp.LowWarningLimit = 30D;
            this.dasTempGasTemp.Max = 100D;
            this.dasTempGasTemp.MeterBorderColor = System.Drawing.Color.Black;
            this.dasTempGasTemp.MeterBorderType = DasNetTemperature.DAS_MeterBorderStyle.MBS_Flat;
            this.dasTempGasTemp.MeterColor = System.Drawing.Color.Transparent;
            this.dasTempGasTemp.MeterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.dasTempGasTemp.MeterGradient = false;
            this.dasTempGasTemp.MeterInterGap = 0;
            this.dasTempGasTemp.MeterShift = 0;
            this.dasTempGasTemp.MeterWidth = 12;
            this.dasTempGasTemp.MiddleBorderColor = System.Drawing.Color.Gray;
            this.dasTempGasTemp.MiddleBorderLength = 0;
            this.dasTempGasTemp.Min = -20D;
            this.dasTempGasTemp.Name = "dasTempGasTemp";
            this.dasTempGasTemp.OuterBorderDarkColor = System.Drawing.Color.DimGray;
            this.dasTempGasTemp.OuterBorderLength = 5;
            this.dasTempGasTemp.OuterBorderLightColor = System.Drawing.Color.White;
            this.dasTempGasTemp.Precision = 0;
            this.dasTempGasTemp.ProcessTriangleWidth = 15;
            this.dasTempGasTemp.ProgressHighColor = System.Drawing.Color.DarkRed;
            this.dasTempGasTemp.ProgressLowColor = System.Drawing.Color.DarkBlue;
            this.dasTempGasTemp.ProgressTriangleVisible = false;
            this.dasTempGasTemp.RoundRadius = 10;
            this.dasTempGasTemp.ScaleTextColor = System.Drawing.Color.Black;
            this.dasTempGasTemp.SecondUnitOffset = 32D;
            this.dasTempGasTemp.SecondUnitRate = 1.8D;
            this.dasTempGasTemp.ShadowColor = System.Drawing.Color.DimGray;
            this.dasTempGasTemp.ShadowDepth = 8;
            this.dasTempGasTemp.ShadowRate = 0.5F;
            this.dasTempGasTemp.Size = new System.Drawing.Size(127, 212);
            this.dasTempGasTemp.SubTickerFillColor = System.Drawing.Color.Transparent;
            this.dasTempGasTemp.SubTickerLength = 6;
            this.dasTempGasTemp.SubTickerNumber = 4;
            this.dasTempGasTemp.SubTickerShape = DasNetTemperature.DAS_TickerShapeStyle.Line;
            this.dasTempGasTemp.SubTickerWidth = 1;
            this.dasTempGasTemp.SupportAlarm = false;
            this.dasTempGasTemp.SupportSecondUnit = false;
            this.dasTempGasTemp.SupportWarning = false;
            this.dasTempGasTemp.TabIndex = 118;
            this.dasTempGasTemp.Text = "daS_Net_Temperature1";
            this.dasTempGasTemp.TickerAlignment = DasNetTemperature.DAS_TickerAlignmentStyle.TAS_Border;
            this.dasTempGasTemp.TickerFillColor = System.Drawing.Color.Transparent;
            this.dasTempGasTemp.TickerLength = 16;
            this.dasTempGasTemp.TickerLineColor = System.Drawing.Color.Black;
            this.dasTempGasTemp.TickerNumber = 5;
            this.dasTempGasTemp.TickerShape = DasNetTemperature.DAS_TickerShapeStyle.Line;
            this.dasTempGasTemp.TickerWidth = 1;
            this.dasTempGasTemp.Value = 0D;
            this.dasTempGasTemp.Vertical = true;
            this.dasTempGasTemp.WarningMarkerVisible = false;
            this.dasTempGasTemp.WarningValueVisible = false;
            // 
            // dasTempRedTemp
            // 
            this.dasTempRedTemp.ActualValueVisible = true;
            this.dasTempRedTemp.AlarmMarkerVisible = false;
            this.dasTempRedTemp.AlarmValueVisible = false;
            this.dasTempRedTemp.BackColor = System.Drawing.Color.Transparent;
            this.dasTempRedTemp.BkGradient = false;
            this.dasTempRedTemp.BkGradientAngle = 90;
            this.dasTempRedTemp.BkGradientColor = System.Drawing.Color.Transparent;
            this.dasTempRedTemp.BkGradientRate = 0.5F;
            this.dasTempRedTemp.BkGradientType = DasNetTemperature.DAS_BkGradientStyle.BKGS_Linear;
            this.dasTempRedTemp.BkShinePosition = 1F;
            this.dasTempRedTemp.BkTransparency = 0F;
            this.dasTempRedTemp.BorderExteriorColor = System.Drawing.Color.Blue;
            this.dasTempRedTemp.BorderExteriorLength = 0;
            this.dasTempRedTemp.BorderGradientAngle = 225;
            this.dasTempRedTemp.BorderGradientLightPos1 = 1F;
            this.dasTempRedTemp.BorderGradientLightPos2 = -1F;
            this.dasTempRedTemp.BorderGradientRate = 0.5F;
            this.dasTempRedTemp.BorderGradientType = DasNetTemperature.DAS_BorderGradientStyle.BGS_None;
            this.dasTempRedTemp.BorderLightIntermediateBrightness = 0F;
            this.dasTempRedTemp.BorderShape = DasNetTemperature.DAS_BorderStyle.BS_Rect;
            this.dasTempRedTemp.BulbVisible = true;
            this.dasTempRedTemp.ControlShadow = false;
            this.dasTempRedTemp.ForeColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.HighAlarmColor = System.Drawing.Color.Red;
            this.dasTempRedTemp.HighAlarmLimit = 90D;
            this.dasTempRedTemp.HighWarningColor = System.Drawing.Color.Yellow;
            this.dasTempRedTemp.HighWarningLimit = 70D;
            this.dasTempRedTemp.InnerBorderDarkColor = System.Drawing.Color.DimGray;
            this.dasTempRedTemp.InnerBorderLength = 5;
            this.dasTempRedTemp.InnerBorderLightColor = System.Drawing.Color.Transparent;
            this.dasTempRedTemp.Location = new System.Drawing.Point(28, 90);
            this.dasTempRedTemp.LowAlarmColor = System.Drawing.Color.Blue;
            this.dasTempRedTemp.LowAlarmLimit = 10D;
            this.dasTempRedTemp.LowWarningColor = System.Drawing.Color.Green;
            this.dasTempRedTemp.LowWarningLimit = 30D;
            this.dasTempRedTemp.Max = 100D;
            this.dasTempRedTemp.MeterBorderColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.MeterBorderType = DasNetTemperature.DAS_MeterBorderStyle.MBS_Flat;
            this.dasTempRedTemp.MeterColor = System.Drawing.Color.Transparent;
            this.dasTempRedTemp.MeterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.dasTempRedTemp.MeterGradient = false;
            this.dasTempRedTemp.MeterInterGap = 0;
            this.dasTempRedTemp.MeterShift = 0;
            this.dasTempRedTemp.MeterWidth = 12;
            this.dasTempRedTemp.MiddleBorderColor = System.Drawing.Color.Gray;
            this.dasTempRedTemp.MiddleBorderLength = 0;
            this.dasTempRedTemp.Min = -20D;
            this.dasTempRedTemp.Name = "dasTempRedTemp";
            this.dasTempRedTemp.OuterBorderDarkColor = System.Drawing.Color.DimGray;
            this.dasTempRedTemp.OuterBorderLength = 5;
            this.dasTempRedTemp.OuterBorderLightColor = System.Drawing.Color.White;
            this.dasTempRedTemp.Precision = 0;
            this.dasTempRedTemp.ProcessTriangleWidth = 15;
            this.dasTempRedTemp.ProgressHighColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.ProgressLowColor = System.Drawing.Color.DarkBlue;
            this.dasTempRedTemp.ProgressTriangleVisible = false;
            this.dasTempRedTemp.RoundRadius = 10;
            this.dasTempRedTemp.ScaleTextColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.SecondUnitOffset = 32D;
            this.dasTempRedTemp.SecondUnitRate = 1.8D;
            this.dasTempRedTemp.ShadowColor = System.Drawing.Color.DimGray;
            this.dasTempRedTemp.ShadowDepth = 8;
            this.dasTempRedTemp.ShadowRate = 0.5F;
            this.dasTempRedTemp.Size = new System.Drawing.Size(127, 215);
            this.dasTempRedTemp.SubTickerFillColor = System.Drawing.Color.Transparent;
            this.dasTempRedTemp.SubTickerLength = 6;
            this.dasTempRedTemp.SubTickerNumber = 4;
            this.dasTempRedTemp.SubTickerShape = DasNetTemperature.DAS_TickerShapeStyle.Line;
            this.dasTempRedTemp.SubTickerWidth = 1;
            this.dasTempRedTemp.SupportAlarm = false;
            this.dasTempRedTemp.SupportSecondUnit = false;
            this.dasTempRedTemp.SupportWarning = false;
            this.dasTempRedTemp.TabIndex = 117;
            this.dasTempRedTemp.Text = "daS_Net_Temperature1";
            this.dasTempRedTemp.TickerAlignment = DasNetTemperature.DAS_TickerAlignmentStyle.TAS_Border;
            this.dasTempRedTemp.TickerFillColor = System.Drawing.Color.Transparent;
            this.dasTempRedTemp.TickerLength = 16;
            this.dasTempRedTemp.TickerLineColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.TickerNumber = 5;
            this.dasTempRedTemp.TickerShape = DasNetTemperature.DAS_TickerShapeStyle.Line;
            this.dasTempRedTemp.TickerWidth = 1;
            this.dasTempRedTemp.Value = 0D;
            this.dasTempRedTemp.Vertical = true;
            this.dasTempRedTemp.WarningMarkerVisible = false;
            this.dasTempRedTemp.WarningValueVisible = false;
            // 
            // labMapPress
            // 
            this.labMapPress.AutoEllipsis = true;
            this.labMapPress.BackColor = System.Drawing.Color.Transparent;
            this.labMapPress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMapPress.Location = new System.Drawing.Point(455, 563);
            this.labMapPress.Name = "labMapPress";
            this.labMapPress.Size = new System.Drawing.Size(157, 29);
            this.labMapPress.TabIndex = 144;
            this.labMapPress.Text = "真空压力";
            this.labMapPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGasPress
            // 
            this.labGasPress.AutoEllipsis = true;
            this.labGasPress.BackColor = System.Drawing.Color.Transparent;
            this.labGasPress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasPress.Location = new System.Drawing.Point(452, 517);
            this.labGasPress.Name = "labGasPress";
            this.labGasPress.Size = new System.Drawing.Size(160, 28);
            this.labGasPress.TabIndex = 143;
            this.labGasPress.Text = "燃气压力";
            this.labGasPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGas1
            // 
            this.labGas1.AutoEllipsis = true;
            this.labGas1.BackColor = System.Drawing.Color.Transparent;
            this.labGas1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGas1.Location = new System.Drawing.Point(161, 563);
            this.labGas1.Name = "labGas1";
            this.labGas1.Size = new System.Drawing.Size(180, 28);
            this.labGas1.TabIndex = 142;
            this.labGas1.Text = "喷气时间";
            this.labGas1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPetrol1
            // 
            this.labPetrol1.AutoEllipsis = true;
            this.labPetrol1.BackColor = System.Drawing.Color.Transparent;
            this.labPetrol1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPetrol1.Location = new System.Drawing.Point(164, 517);
            this.labPetrol1.Name = "labPetrol1";
            this.labPetrol1.Size = new System.Drawing.Size(177, 28);
            this.labPetrol1.TabIndex = 141;
            this.labPetrol1.Text = "喷油时间";
            this.labPetrol1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(668, 394);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(169, 35);
            this.btnStart.TabIndex = 147;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pBarCalibration
            // 
            this.pBarCalibration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBarCalibration.Location = new System.Drawing.Point(0, 616);
            this.pBarCalibration.Name = "pBarCalibration";
            this.pBarCalibration.Size = new System.Drawing.Size(1023, 40);
            this.pBarCalibration.TabIndex = 148;
            // 
            // labTipCalibration
            // 
            this.labTipCalibration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTipCalibration.AutoSize = true;
            this.labTipCalibration.BackColor = System.Drawing.Color.Transparent;
            this.labTipCalibration.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTipCalibration.Location = new System.Drawing.Point(10, 624);
            this.labTipCalibration.Name = "labTipCalibration";
            this.labTipCalibration.Size = new System.Drawing.Size(161, 25);
            this.labTipCalibration.TabIndex = 150;
            this.labTipCalibration.Text = "按\"开始\"自动标定";
            // 
            // cbAllWork
            // 
            this.cbAllWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAllWork.AutoSize = true;
            this.cbAllWork.BackColor = System.Drawing.Color.Transparent;
            this.cbAllWork.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAllWork.Location = new System.Drawing.Point(480, 439);
            this.cbAllWork.Name = "cbAllWork";
            this.cbAllWork.Size = new System.Drawing.Size(183, 29);
            this.cbAllWork.TabIndex = 149;
            this.cbAllWork.Text = "全部喷嘴一起工作";
            this.cbAllWork.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(886, 394);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 35);
            this.btnStop.TabIndex = 151;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labLambda2
            // 
            this.labLambda2.AutoEllipsis = true;
            this.labLambda2.BackColor = System.Drawing.Color.Transparent;
            this.labLambda2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambda2.Location = new System.Drawing.Point(723, 563);
            this.labLambda2.Name = "labLambda2";
            this.labLambda2.Size = new System.Drawing.Size(157, 28);
            this.labLambda2.TabIndex = 153;
            this.labLambda2.Text = "氧传感器2";
            this.labLambda2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labLambda1
            // 
            this.labLambda1.AutoEllipsis = true;
            this.labLambda1.BackColor = System.Drawing.Color.Transparent;
            this.labLambda1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambda1.Location = new System.Drawing.Point(723, 517);
            this.labLambda1.Name = "labLambda1";
            this.labLambda1.Size = new System.Drawing.Size(157, 28);
            this.labLambda1.TabIndex = 152;
            this.labLambda1.Text = "氧传感器1";
            this.labLambda1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(476, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 156;
            this.label1.Text = "RPM";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 323);
            this.textBox1.TabIndex = 157;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(700, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 337);
            this.groupBox1.TabIndex = 158;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OBS.:";
            this.groupBox1.Visible = false;
            // 
            // rtlLambda2
            // 
            this.rtlLambda2.BackColor = System.Drawing.Color.Transparent;
            this.rtlLambda2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlLambda2.BackgroundImage")));
            this.rtlLambda2.Location = new System.Drawing.Point(886, 563);
            this.rtlLambda2.Name = "rtlLambda2";
            this.rtlLambda2.Size = new System.Drawing.Size(99, 28);
            this.rtlLambda2.TabIndex = 155;
            this.rtlLambda2.UnitText = "V";
            this.rtlLambda2.ValueText = "n.a.";
            // 
            // rtlLambda1
            // 
            this.rtlLambda1.BackColor = System.Drawing.Color.Transparent;
            this.rtlLambda1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlLambda1.BackgroundImage")));
            this.rtlLambda1.Location = new System.Drawing.Point(886, 517);
            this.rtlLambda1.Name = "rtlLambda1";
            this.rtlLambda1.Size = new System.Drawing.Size(99, 28);
            this.rtlLambda1.TabIndex = 154;
            this.rtlLambda1.UnitText = "V";
            this.rtlLambda1.ValueText = "n.a.";
            // 
            // rtlGasPress
            // 
            this.rtlGasPress.BackColor = System.Drawing.Color.Transparent;
            this.rtlGasPress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlGasPress.BackgroundImage")));
            this.rtlGasPress.Location = new System.Drawing.Point(618, 517);
            this.rtlGasPress.Name = "rtlGasPress";
            this.rtlGasPress.Size = new System.Drawing.Size(99, 28);
            this.rtlGasPress.TabIndex = 140;
            this.rtlGasPress.UnitText = "bar";
            this.rtlGasPress.ValueText = "n.a.";
            // 
            // rtlMapPress
            // 
            this.rtlMapPress.BackColor = System.Drawing.Color.Transparent;
            this.rtlMapPress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlMapPress.BackgroundImage")));
            this.rtlMapPress.Location = new System.Drawing.Point(618, 563);
            this.rtlMapPress.Name = "rtlMapPress";
            this.rtlMapPress.Size = new System.Drawing.Size(99, 28);
            this.rtlMapPress.TabIndex = 139;
            this.rtlMapPress.UnitText = "bar";
            this.rtlMapPress.ValueText = "n.a.";
            // 
            // rtlGas
            // 
            this.rtlGas.BackColor = System.Drawing.Color.Transparent;
            this.rtlGas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlGas.BackgroundImage")));
            this.rtlGas.Location = new System.Drawing.Point(347, 563);
            this.rtlGas.Name = "rtlGas";
            this.rtlGas.Size = new System.Drawing.Size(99, 28);
            this.rtlGas.TabIndex = 138;
            this.rtlGas.UnitText = "ms";
            this.rtlGas.ValueText = "n.a.";
            // 
            // rtlPetrol
            // 
            this.rtlPetrol.BackColor = System.Drawing.Color.Transparent;
            this.rtlPetrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlPetrol.BackgroundImage")));
            this.rtlPetrol.Location = new System.Drawing.Point(347, 517);
            this.rtlPetrol.Name = "rtlPetrol";
            this.rtlPetrol.Size = new System.Drawing.Size(99, 28);
            this.rtlPetrol.TabIndex = 137;
            this.rtlPetrol.UnitText = "ms";
            this.rtlPetrol.ValueText = "n.a.";
            // 
            // tpbSolenoidValveStatus
            // 
            this.tpbSolenoidValveStatus.BackgroundImage = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus2;
            this.tpbSolenoidValveStatus.Image1 = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus2;
            this.tpbSolenoidValveStatus.Image2 = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus;
            this.tpbSolenoidValveStatus.Location = new System.Drawing.Point(126, 575);
            this.tpbSolenoidValveStatus.Name = "tpbSolenoidValveStatus";
            this.tpbSolenoidValveStatus.Size = new System.Drawing.Size(29, 19);
            this.tpbSolenoidValveStatus.TabIndex = 136;
            // 
            // tpbIgnitionStatus
            // 
            this.tpbIgnitionStatus.BackgroundImage = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.tpbIgnitionStatus.Image1 = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.tpbIgnitionStatus.Image2 = global::IGT.UI.Client.Properties.Resources.IgnitionStatus;
            this.tpbIgnitionStatus.Location = new System.Drawing.Point(127, 520);
            this.tpbIgnitionStatus.Name = "tpbIgnitionStatus";
            this.tpbIgnitionStatus.Size = new System.Drawing.Size(28, 28);
            this.tpbIgnitionStatus.TabIndex = 135;
            // 
            // tpbLED7
            // 
            this.tpbLED7.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED7.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED7.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightRed;
            this.tpbLED7.Location = new System.Drawing.Point(97, 594);
            this.tpbLED7.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED7.Name = "tpbLED7";
            this.tpbLED7.Size = new System.Drawing.Size(17, 17);
            this.tpbLED7.TabIndex = 134;
            // 
            // tpbLED6
            // 
            this.tpbLED6.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED6.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED6.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightYellow;
            this.tpbLED6.Location = new System.Drawing.Point(15, 594);
            this.tpbLED6.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED6.Name = "tpbLED6";
            this.tpbLED6.Size = new System.Drawing.Size(17, 17);
            this.tpbLED6.TabIndex = 132;
            // 
            // tpbLED5
            // 
            this.tpbLED5.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED5.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED5.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED5.Location = new System.Drawing.Point(97, 520);
            this.tpbLED5.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED5.Name = "tpbLED5";
            this.tpbLED5.Size = new System.Drawing.Size(17, 17);
            this.tpbLED5.TabIndex = 131;
            // 
            // tpbLED4
            // 
            this.tpbLED4.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED4.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED4.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED4.Location = new System.Drawing.Point(77, 520);
            this.tpbLED4.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED4.Name = "tpbLED4";
            this.tpbLED4.Size = new System.Drawing.Size(17, 17);
            this.tpbLED4.TabIndex = 130;
            // 
            // tpbLED3
            // 
            this.tpbLED3.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED3.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED3.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED3.Location = new System.Drawing.Point(57, 520);
            this.tpbLED3.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED3.Name = "tpbLED3";
            this.tpbLED3.Size = new System.Drawing.Size(17, 17);
            this.tpbLED3.TabIndex = 129;
            // 
            // tpbLED2
            // 
            this.tpbLED2.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED2.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED2.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED2.Location = new System.Drawing.Point(37, 520);
            this.tpbLED2.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED2.Name = "tpbLED2";
            this.tpbLED2.Size = new System.Drawing.Size(17, 17);
            this.tpbLED2.TabIndex = 128;
            // 
            // tpbLED1
            // 
            this.tpbLED1.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED1.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED1.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightRed;
            this.tpbLED1.Location = new System.Drawing.Point(17, 520);
            this.tpbLED1.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED1.Name = "tpbLED1";
            this.tpbLED1.Size = new System.Drawing.Size(17, 17);
            this.tpbLED1.TabIndex = 127;
            // 
            // injectorsMeasurement1
            // 
            this.injectorsMeasurement1.BackColor = System.Drawing.Color.Transparent;
            this.injectorsMeasurement1.BackgroundImage = global::IGT.UI.Client.Properties.Resources.InjectorsMeasurement;
            this.injectorsMeasurement1.Location = new System.Drawing.Point(28, 330);
            this.injectorsMeasurement1.Name = "injectorsMeasurement1";
            this.injectorsMeasurement1.Size = new System.Drawing.Size(357, 160);
            this.injectorsMeasurement1.TabIndex = 123;
            this.injectorsMeasurement1.Value = 0;
            // 
            // tpbSwitchKey
            // 
            this.tpbSwitchKey.BackgroundImage = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder;
            this.tpbSwitchKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpbSwitchKey.Image1 = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder;
            this.tpbSwitchKey.Image2 = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder2;
            this.tpbSwitchKey.Location = new System.Drawing.Point(30, 540);
            this.tpbSwitchKey.Name = "tpbSwitchKey";
            this.tpbSwitchKey.Size = new System.Drawing.Size(64, 67);
            this.tpbSwitchKey.TabIndex = 133;
            this.tpbSwitchKey.Click += new System.EventHandler(this.tpbSwitchKey_Click);
            // 
            // AutoCalibration
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackgroundImage = global::IGT.UI.Client.Properties.Resources.background1;
            this.Controls.Add(this.labRed);
            this.Controls.Add(this.labGas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dasTempRedTemp);
            this.Controls.Add(this.dasTempGasTemp);
            this.Controls.Add(this.rtlLambda2);
            this.Controls.Add(this.rtlLambda1);
            this.Controls.Add(this.labLambda2);
            this.Controls.Add(this.labLambda1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labTipCalibration);
            this.Controls.Add(this.cbAllWork);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labMapPress);
            this.Controls.Add(this.labGasPress);
            this.Controls.Add(this.labGas1);
            this.Controls.Add(this.labPetrol1);
            this.Controls.Add(this.rtlGasPress);
            this.Controls.Add(this.rtlMapPress);
            this.Controls.Add(this.rtlGas);
            this.Controls.Add(this.rtlPetrol);
            this.Controls.Add(this.tpbSolenoidValveStatus);
            this.Controls.Add(this.tpbIgnitionStatus);
            this.Controls.Add(this.tpbLED7);
            this.Controls.Add(this.tpbLED6);
            this.Controls.Add(this.tpbLED5);
            this.Controls.Add(this.tpbLED4);
            this.Controls.Add(this.tpbLED3);
            this.Controls.Add(this.tpbLED2);
            this.Controls.Add(this.tpbLED1);
            this.Controls.Add(this.labCorrect);
            this.Controls.Add(this.labTooSmall);
            this.Controls.Add(this.labTooBig);
            this.Controls.Add(this.labeInje);
            this.Controls.Add(this.daSCGRPM);
            this.Controls.Add(this.injectorsMeasurement1);
            this.Controls.Add(this.tpbSwitchKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBarCalibration);
            this.DoubleBuffered = true;
            this.Name = "AutoCalibration";
            this.Size = new System.Drawing.Size(1023, 656);
            this.Load += new System.EventHandler(this.AutoCalibration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCorrect;
        private System.Windows.Forms.Label labTooSmall;
        private System.Windows.Forms.Label labTooBig;
        private System.Windows.Forms.Label labeInje;
        private System.Windows.Forms.Label labGas;
        private System.Windows.Forms.Label labRed;
        private DasNetGauge.DAS_Net_CircleGauge daSCGRPM;
        private DasNetTemperature.DAS_Net_Temperature dasTempGasTemp;
        private DasNetTemperature.DAS_Net_Temperature dasTempRedTemp;
        private UserControls.TogglePictureBox tpbSolenoidValveStatus;
        private UserControls.TogglePictureBox tpbIgnitionStatus;
        private UserControls.TogglePictureBox tpbLED7;
        private UserControls.TogglePictureBox tpbSwitchKey;
        private UserControls.TogglePictureBox tpbLED6;
        private UserControls.TogglePictureBox tpbLED5;
        private UserControls.TogglePictureBox tpbLED4;
        private UserControls.TogglePictureBox tpbLED3;
        private UserControls.TogglePictureBox tpbLED2;
        private UserControls.TogglePictureBox tpbLED1;
        private System.Windows.Forms.Label labMapPress;
        private System.Windows.Forms.Label labGasPress;
        private System.Windows.Forms.Label labGas1;
        private System.Windows.Forms.Label labPetrol1;
        private UserControls.RealTimeDataLabel rtlGasPress;
        private UserControls.RealTimeDataLabel rtlMapPress;
        private UserControls.RealTimeDataLabel rtlGas;
        private UserControls.RealTimeDataLabel rtlPetrol;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pBarCalibration;
        private System.Windows.Forms.Label labTipCalibration;
        private System.Windows.Forms.CheckBox cbAllWork;
        private System.Windows.Forms.Button btnStop;
        private UserControls.RealTimeDataLabel rtlLambda2;
        private UserControls.RealTimeDataLabel rtlLambda1;
        private System.Windows.Forms.Label labLambda2;
        private System.Windows.Forms.Label labLambda1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.InjectorsMeasurement injectorsMeasurement1;
    }
}
