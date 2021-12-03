namespace IGT.UI.Client.Pages
{
    partial class RealyTimeData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealyTimeData));
            this.dasTempGasTemp = new DasNetTemperature.DAS_Net_Temperature();
            this.dasTempRedTemp = new DasNetTemperature.DAS_Net_Temperature();
            this.daSCGRPM = new DasNetGauge.DAS_Net_CircleGauge();
            this.labGas = new System.Windows.Forms.Label();
            this.labRed = new System.Windows.Forms.Label();
            this.labGas1 = new System.Windows.Forms.Label();
            this.labPetrol1 = new System.Windows.Forms.Label();
            this.labGasPress = new System.Windows.Forms.Label();
            this.labMapPress = new System.Windows.Forms.Label();
            this.labeInje = new System.Windows.Forms.Label();
            this.labCorrect = new System.Windows.Forms.Label();
            this.labTooSmall = new System.Windows.Forms.Label();
            this.labTooBig = new System.Windows.Forms.Label();
            this.labLambda2 = new System.Windows.Forms.Label();
            this.labLambda1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxAdp = new System.Windows.Forms.GroupBox();
            this.labAOffset = new System.Windows.Forms.Label();
            this.rtdlAdaptiveOffset = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.labAC = new System.Windows.Forms.Label();
            this.rtdlAAdaptiveC = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.gboxODB = new System.Windows.Forms.GroupBox();
            this.labOBDErrorValue = new System.Windows.Forms.Label();
            this.labOBDConnectValue = new System.Windows.Forms.Label();
            this.labODBError = new System.Windows.Forms.Label();
            this.labOBDConnect = new System.Windows.Forms.Label();
            this.labODBBank1Short = new System.Windows.Forms.Label();
            this.rtdlOBDBank1Short = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.labOBDBank1Long = new System.Windows.Forms.Label();
            this.rtdlOBDBank1Long = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.labLambdaPost = new System.Windows.Forms.Label();
            this.rtdlBank1Oxygen = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.labGasCorrection = new System.Windows.Forms.Label();
            this.rtdlGasCorrection = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtlLambda2 = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlLambda1 = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.tpbSolenoidValveStatus = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbIgnitionStatus = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.rtlGasPress = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlMapPress = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlGas = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlPetrol = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.tpbLED7 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED6 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED5 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED4 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED3 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED2 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED1 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.injectorsMeasurement1 = new IGT.UI.Client.UserControls.InjectorsMeasurement();
            this.tpbSwitchKey = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.gBoxAdp.SuspendLayout();
            this.gboxODB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dasTempGasTemp
            // 
            this.dasTempGasTemp.ActualValueVisible = true;
            this.dasTempGasTemp.AlarmMarkerVisible = false;
            this.dasTempGasTemp.AlarmValueVisible = false;
            this.dasTempGasTemp.BkGradient = false;
            this.dasTempGasTemp.BkGradientAngle = 90;
            this.dasTempGasTemp.BkGradientColor = System.Drawing.Color.White;
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
            this.dasTempGasTemp.BorderShape = DasNetTemperature.DAS_BorderStyle.BS_Rect;
            this.dasTempGasTemp.BulbVisible = true;
            this.dasTempGasTemp.ControlShadow = false;
            this.dasTempGasTemp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dasTempGasTemp.ForeColor = System.Drawing.Color.Black;
            this.dasTempGasTemp.HighAlarmColor = System.Drawing.Color.Red;
            this.dasTempGasTemp.HighAlarmLimit = 90D;
            this.dasTempGasTemp.HighWarningColor = System.Drawing.Color.Yellow;
            this.dasTempGasTemp.HighWarningLimit = 70D;
            this.dasTempGasTemp.InnerBorderDarkColor = System.Drawing.Color.DimGray;
            this.dasTempGasTemp.InnerBorderLength = 5;
            this.dasTempGasTemp.InnerBorderLightColor = System.Drawing.Color.White;
            this.dasTempGasTemp.Location = new System.Drawing.Point(130, 23);
            this.dasTempGasTemp.LowAlarmColor = System.Drawing.Color.Blue;
            this.dasTempGasTemp.LowAlarmLimit = 10D;
            this.dasTempGasTemp.LowWarningColor = System.Drawing.Color.Green;
            this.dasTempGasTemp.LowWarningLimit = 30D;
            this.dasTempGasTemp.Max = 100D;
            this.dasTempGasTemp.MeterBorderColor = System.Drawing.Color.Black;
            this.dasTempGasTemp.MeterBorderType = DasNetTemperature.DAS_MeterBorderStyle.MBS_Flat;
            this.dasTempGasTemp.MeterColor = System.Drawing.Color.White;
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
            this.dasTempGasTemp.Size = new System.Drawing.Size(113, 212);
            this.dasTempGasTemp.SubTickerFillColor = System.Drawing.Color.White;
            this.dasTempGasTemp.SubTickerLength = 6;
            this.dasTempGasTemp.SubTickerNumber = 5;
            this.dasTempGasTemp.SubTickerShape = DasNetTemperature.DAS_TickerShapeStyle.Line;
            this.dasTempGasTemp.SubTickerWidth = 1;
            this.dasTempGasTemp.SupportAlarm = false;
            this.dasTempGasTemp.SupportSecondUnit = false;
            this.dasTempGasTemp.SupportWarning = false;
            this.dasTempGasTemp.TabIndex = 26;
            this.dasTempGasTemp.Text = "daS_Net_Temperature1";
            this.dasTempGasTemp.TickerAlignment = DasNetTemperature.DAS_TickerAlignmentStyle.TAS_Border;
            this.dasTempGasTemp.TickerFillColor = System.Drawing.Color.White;
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
            this.dasTempRedTemp.BkGradient = false;
            this.dasTempRedTemp.BkGradientAngle = 90;
            this.dasTempRedTemp.BkGradientColor = System.Drawing.Color.White;
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
            this.dasTempRedTemp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dasTempRedTemp.ForeColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.HighAlarmColor = System.Drawing.Color.Red;
            this.dasTempRedTemp.HighAlarmLimit = 90D;
            this.dasTempRedTemp.HighWarningColor = System.Drawing.Color.Yellow;
            this.dasTempRedTemp.HighWarningLimit = 70D;
            this.dasTempRedTemp.InnerBorderDarkColor = System.Drawing.Color.DimGray;
            this.dasTempRedTemp.InnerBorderLength = 5;
            this.dasTempRedTemp.InnerBorderLightColor = System.Drawing.Color.White;
            this.dasTempRedTemp.Location = new System.Drawing.Point(11, 75);
            this.dasTempRedTemp.LowAlarmColor = System.Drawing.Color.Blue;
            this.dasTempRedTemp.LowAlarmLimit = 10D;
            this.dasTempRedTemp.LowWarningColor = System.Drawing.Color.Green;
            this.dasTempRedTemp.LowWarningLimit = 30D;
            this.dasTempRedTemp.Max = 100D;
            this.dasTempRedTemp.MeterBorderColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.MeterBorderType = DasNetTemperature.DAS_MeterBorderStyle.MBS_Flat;
            this.dasTempRedTemp.MeterColor = System.Drawing.Color.White;
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
            this.dasTempRedTemp.ProgressHighColor = System.Drawing.Color.DarkRed;
            this.dasTempRedTemp.ProgressLowColor = System.Drawing.Color.DarkBlue;
            this.dasTempRedTemp.ProgressTriangleVisible = false;
            this.dasTempRedTemp.RoundRadius = 10;
            this.dasTempRedTemp.ScaleTextColor = System.Drawing.Color.Black;
            this.dasTempRedTemp.SecondUnitOffset = 32D;
            this.dasTempRedTemp.SecondUnitRate = 1.8D;
            this.dasTempRedTemp.ShadowColor = System.Drawing.Color.DimGray;
            this.dasTempRedTemp.ShadowDepth = 8;
            this.dasTempRedTemp.ShadowRate = 0.5F;
            this.dasTempRedTemp.Size = new System.Drawing.Size(113, 212);
            this.dasTempRedTemp.SubTickerFillColor = System.Drawing.Color.White;
            this.dasTempRedTemp.SubTickerLength = 6;
            this.dasTempRedTemp.SubTickerNumber = 5;
            this.dasTempRedTemp.SubTickerShape = DasNetTemperature.DAS_TickerShapeStyle.Line;
            this.dasTempRedTemp.SubTickerWidth = 1;
            this.dasTempRedTemp.SupportAlarm = false;
            this.dasTempRedTemp.SupportSecondUnit = false;
            this.dasTempRedTemp.SupportWarning = false;
            this.dasTempRedTemp.TabIndex = 25;
            this.dasTempRedTemp.Text = "daS_Net_Temperature1";
            this.dasTempRedTemp.TickerAlignment = DasNetTemperature.DAS_TickerAlignmentStyle.TAS_Border;
            this.dasTempRedTemp.TickerFillColor = System.Drawing.Color.White;
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
            // daSCGRPM
            // 
            this.daSCGRPM.AntiClockwise = false;
            this.daSCGRPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.daSCGRPM.BkGradient = true;
            this.daSCGRPM.BkGradientAngle = 45;
            this.daSCGRPM.BkGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.BkGradientRate = 0.9F;
            this.daSCGRPM.BkGradientType = DasNetGauge.DAS_BkGradientStyle.BKGS_Shine;
            this.daSCGRPM.BkShinePosition = 1F;
            this.daSCGRPM.BkTransparency = 0F;
            this.daSCGRPM.BorderExteriorColor = System.Drawing.Color.Black;
            this.daSCGRPM.BorderExteriorLength = 0;
            this.daSCGRPM.BorderGradientAngle = 225;
            this.daSCGRPM.BorderGradientLightPos1 = 0.4F;
            this.daSCGRPM.BorderGradientLightPos2 = 0.7F;
            this.daSCGRPM.BorderGradientRate = 0.8F;
            this.daSCGRPM.BorderGradientType = DasNetGauge.DAS_BorderGradientStyle.BGS_Path;
            this.daSCGRPM.BorderLightIntermediateBrightness = 0.7F;
            this.daSCGRPM.BorderShape = DasNetGauge.DAS_BorderStyle.BS_Circle;
            this.daSCGRPM.ControlShadow = false;
            this.daSCGRPM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.daSCGRPM.ForeColor = System.Drawing.Color.Transparent;
            this.daSCGRPM.InnerBorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.InnerBorderLength = 0;
            this.daSCGRPM.InnerBorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.daSCGRPM.Location = new System.Drawing.Point(293, 23);
            this.daSCGRPM.Max = 7000D;
            this.daSCGRPM.MiddleBorderColor = System.Drawing.Color.Gray;
            this.daSCGRPM.MiddleBorderLength = 0;
            this.daSCGRPM.Min = 0D;
            this.daSCGRPM.Name = "daSCGRPM";
            this.daSCGRPM.NeedleBallFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.NeedleBallGradientColor = System.Drawing.SystemColors.Window;
            this.daSCGRPM.NeedleBallLineColor = System.Drawing.Color.DarkGray;
            this.daSCGRPM.NeedleBallSize = 12;
            this.daSCGRPM.NeedleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.NeedleGradient = false;
            this.daSCGRPM.NeedleGradientColor = System.Drawing.Color.Turquoise;
            this.daSCGRPM.NeedleLineColor = System.Drawing.Color.DimGray;
            this.daSCGRPM.NeedlePieAngle = 30;
            this.daSCGRPM.NeedleType = DasNetGauge.DAS_NeedleStyle.Stick;
            this.daSCGRPM.OuterBorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.OuterBorderLength = 8;
            this.daSCGRPM.OuterBorderLightColor = System.Drawing.Color.White;
            this.daSCGRPM.OuterTextHGap = 20;
            this.daSCGRPM.OuterTextVGap = 20;
            this.daSCGRPM.Precision = 0;
            this.daSCGRPM.RoundRadius = 30;
            this.daSCGRPM.ScaleAngularGap = 90;
            this.daSCGRPM.ScaleRingBorderColor = System.Drawing.Color.BlueViolet;
            this.daSCGRPM.ScaleRingBorderType = DasNetGauge.DAS_ScaleRingBorderStyle.None;
            this.daSCGRPM.ScaleRingColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.ScaleRingGradient = false;
            this.daSCGRPM.ScaleRingTransparency = 1F;
            this.daSCGRPM.ScaleRingWidth = 18;
            this.daSCGRPM.ScaleTextColor = System.Drawing.Color.Black;
            this.daSCGRPM.ScaleTextPosition = DasNetGauge.DAS_ShowPositionStyle.Inner;
            this.daSCGRPM.ShadowColor = System.Drawing.Color.DimGray;
            this.daSCGRPM.ShadowDepth = 8;
            this.daSCGRPM.ShadowRate = 0.5F;
            this.daSCGRPM.Size = new System.Drawing.Size(320, 320);
            this.daSCGRPM.SubTickerFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.daSCGRPM.SubTickerLength = 6;
            this.daSCGRPM.SubTickerNumber = 4;
            this.daSCGRPM.SubTickerShape = DasNetGauge.DAS_TickerShapeStyle.Line;
            this.daSCGRPM.SubTickerWidth = 1;
            this.daSCGRPM.TabIndex = 27;
            this.daSCGRPM.Text = "4";
            this.daSCGRPM.TickerAlignment = DasNetGauge.DAS_TickerAlignmentStyle.Outer;
            this.daSCGRPM.TickerFillColor = System.Drawing.Color.Maroon;
            this.daSCGRPM.TickerLength = 12;
            this.daSCGRPM.TickerLineColor = System.Drawing.Color.Black;
            this.daSCGRPM.TickerNumber = 8;
            this.daSCGRPM.TickerShape = DasNetGauge.DAS_TickerShapeStyle.Rectangle;
            this.daSCGRPM.TickerWidth = 1;
            this.daSCGRPM.Value = 0D;
            this.daSCGRPM.ValueColor = System.Drawing.Color.Black;
            this.daSCGRPM.ValueTextBox = false;
            this.daSCGRPM.ValueVisible = true;
            // 
            // labGas
            // 
            this.labGas.AutoSize = true;
            this.labGas.BackColor = System.Drawing.Color.Transparent;
            this.labGas.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGas.Location = new System.Drawing.Point(138, 232);
            this.labGas.Name = "labGas";
            this.labGas.Size = new System.Drawing.Size(74, 21);
            this.labGas.TabIndex = 74;
            this.labGas.Text = "燃气温度";
            // 
            // labRed
            // 
            this.labRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labRed.AutoSize = true;
            this.labRed.BackColor = System.Drawing.Color.Transparent;
            this.labRed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed.Location = new System.Drawing.Point(18, 290);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(90, 21);
            this.labRed.TabIndex = 73;
            this.labRed.Text = "减压器温度";
            // 
            // labGas1
            // 
            this.labGas1.AutoEllipsis = true;
            this.labGas1.BackColor = System.Drawing.Color.Transparent;
            this.labGas1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGas1.Location = new System.Drawing.Point(156, 594);
            this.labGas1.Name = "labGas1";
            this.labGas1.Size = new System.Drawing.Size(156, 28);
            this.labGas1.TabIndex = 104;
            this.labGas1.Text = "喷气时间";
            this.labGas1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPetrol1
            // 
            this.labPetrol1.AutoEllipsis = true;
            this.labPetrol1.BackColor = System.Drawing.Color.Transparent;
            this.labPetrol1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPetrol1.Location = new System.Drawing.Point(156, 548);
            this.labPetrol1.Name = "labPetrol1";
            this.labPetrol1.Size = new System.Drawing.Size(156, 28);
            this.labPetrol1.TabIndex = 103;
            this.labPetrol1.Text = "喷油时间";
            this.labPetrol1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGasPress
            // 
            this.labGasPress.AutoEllipsis = true;
            this.labGasPress.BackColor = System.Drawing.Color.Transparent;
            this.labGasPress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasPress.Location = new System.Drawing.Point(422, 548);
            this.labGasPress.Name = "labGasPress";
            this.labGasPress.Size = new System.Drawing.Size(156, 28);
            this.labGasPress.TabIndex = 105;
            this.labGasPress.Text = "燃气压力";
            this.labGasPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labMapPress
            // 
            this.labMapPress.AutoEllipsis = true;
            this.labMapPress.BackColor = System.Drawing.Color.Transparent;
            this.labMapPress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMapPress.Location = new System.Drawing.Point(422, 594);
            this.labMapPress.Name = "labMapPress";
            this.labMapPress.Size = new System.Drawing.Size(156, 28);
            this.labMapPress.TabIndex = 106;
            this.labMapPress.Text = "真空压力";
            this.labMapPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labeInje
            // 
            this.labeInje.AutoSize = true;
            this.labeInje.BackColor = System.Drawing.Color.Transparent;
            this.labeInje.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeInje.Location = new System.Drawing.Point(50, 386);
            this.labeInje.Name = "labeInje";
            this.labeInje.Size = new System.Drawing.Size(74, 21);
            this.labeInje.TabIndex = 110;
            this.labeInje.Text = "喷嘴口径";
            // 
            // labCorrect
            // 
            this.labCorrect.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.labCorrect.Location = new System.Drawing.Point(144, 455);
            this.labCorrect.Name = "labCorrect";
            this.labCorrect.Size = new System.Drawing.Size(84, 20);
            this.labCorrect.TabIndex = 116;
            this.labCorrect.Text = "correct";
            this.labCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTooSmall
            // 
            this.labTooSmall.AutoSize = true;
            this.labTooSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labTooSmall.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.labTooSmall.ForeColor = System.Drawing.Color.White;
            this.labTooSmall.Location = new System.Drawing.Point(227, 455);
            this.labTooSmall.Name = "labTooSmall";
            this.labTooSmall.Size = new System.Drawing.Size(77, 20);
            this.labTooSmall.TabIndex = 115;
            this.labTooSmall.Text = "TooSmall";
            this.labTooSmall.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labTooBig
            // 
            this.labTooBig.AutoSize = true;
            this.labTooBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labTooBig.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.labTooBig.ForeColor = System.Drawing.Color.White;
            this.labTooBig.Location = new System.Drawing.Point(45, 454);
            this.labTooBig.Name = "labTooBig";
            this.labTooBig.Size = new System.Drawing.Size(61, 20);
            this.labTooBig.TabIndex = 114;
            this.labTooBig.Text = "TooBig";
            this.labTooBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labLambda2
            // 
            this.labLambda2.AutoEllipsis = true;
            this.labLambda2.BackColor = System.Drawing.Color.Transparent;
            this.labLambda2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambda2.Location = new System.Drawing.Point(694, 594);
            this.labLambda2.Name = "labLambda2";
            this.labLambda2.Size = new System.Drawing.Size(163, 28);
            this.labLambda2.TabIndex = 118;
            this.labLambda2.Text = "氧传感器2";
            this.labLambda2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labLambda1
            // 
            this.labLambda1.AutoEllipsis = true;
            this.labLambda1.BackColor = System.Drawing.Color.Transparent;
            this.labLambda1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambda1.Location = new System.Drawing.Point(694, 548);
            this.labLambda1.Name = "labLambda1";
            this.labLambda1.Size = new System.Drawing.Size(163, 28);
            this.labLambda1.TabIndex = 117;
            this.labLambda1.Text = "氧传感器1";
            this.labLambda1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 157;
            this.label1.Text = "RPM";
            // 
            // gBoxAdp
            // 
            this.gBoxAdp.BackColor = System.Drawing.Color.Transparent;
            this.gBoxAdp.Controls.Add(this.labAOffset);
            this.gBoxAdp.Controls.Add(this.rtdlAdaptiveOffset);
            this.gBoxAdp.Controls.Add(this.labAC);
            this.gBoxAdp.Controls.Add(this.rtdlAAdaptiveC);
            this.gBoxAdp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBoxAdp.Location = new System.Drawing.Point(902, 14);
            this.gBoxAdp.Name = "gBoxAdp";
            this.gBoxAdp.Size = new System.Drawing.Size(96, 29);
            this.gBoxAdp.TabIndex = 121;
            this.gBoxAdp.TabStop = false;
            this.gBoxAdp.Text = "自适应状态";
            this.gBoxAdp.Visible = false;
            // 
            // labAOffset
            // 
            this.labAOffset.AutoSize = true;
            this.labAOffset.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAOffset.Location = new System.Drawing.Point(6, 62);
            this.labAOffset.Name = "labAOffset";
            this.labAOffset.Size = new System.Drawing.Size(51, 20);
            this.labAOffset.TabIndex = 109;
            this.labAOffset.Text = "偏离值";
            this.labAOffset.Visible = false;
            // 
            // rtdlAdaptiveOffset
            // 
            this.rtdlAdaptiveOffset.BackColor = System.Drawing.Color.Transparent;
            this.rtdlAdaptiveOffset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtdlAdaptiveOffset.BackgroundImage")));
            this.rtdlAdaptiveOffset.Location = new System.Drawing.Point(197, 48);
            this.rtdlAdaptiveOffset.Name = "rtdlAdaptiveOffset";
            this.rtdlAdaptiveOffset.Size = new System.Drawing.Size(99, 28);
            this.rtdlAdaptiveOffset.TabIndex = 108;
            this.rtdlAdaptiveOffset.UnitText = "%";
            this.rtdlAdaptiveOffset.ValueText = "n.a.";
            this.rtdlAdaptiveOffset.Visible = false;
            // 
            // labAC
            // 
            this.labAC.AutoSize = true;
            this.labAC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAC.Location = new System.Drawing.Point(6, 31);
            this.labAC.Name = "labAC";
            this.labAC.Size = new System.Drawing.Size(107, 20);
            this.labAC.TabIndex = 107;
            this.labAC.Text = "自适应短期修正";
            this.labAC.Visible = false;
            // 
            // rtdlAAdaptiveC
            // 
            this.rtdlAAdaptiveC.BackColor = System.Drawing.Color.Transparent;
            this.rtdlAAdaptiveC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtdlAAdaptiveC.BackgroundImage")));
            this.rtdlAAdaptiveC.Location = new System.Drawing.Point(197, 17);
            this.rtdlAAdaptiveC.Name = "rtdlAAdaptiveC";
            this.rtdlAAdaptiveC.Size = new System.Drawing.Size(99, 28);
            this.rtdlAAdaptiveC.TabIndex = 106;
            this.rtdlAAdaptiveC.UnitText = "%";
            this.rtdlAAdaptiveC.ValueText = "n.a.";
            this.rtdlAAdaptiveC.Visible = false;
            // 
            // gboxODB
            // 
            this.gboxODB.BackColor = System.Drawing.Color.Transparent;
            this.gboxODB.Controls.Add(this.labOBDErrorValue);
            this.gboxODB.Controls.Add(this.labOBDConnectValue);
            this.gboxODB.Controls.Add(this.labODBError);
            this.gboxODB.Controls.Add(this.labOBDConnect);
            this.gboxODB.Controls.Add(this.labODBBank1Short);
            this.gboxODB.Controls.Add(this.rtdlOBDBank1Short);
            this.gboxODB.Controls.Add(this.labOBDBank1Long);
            this.gboxODB.Controls.Add(this.rtdlOBDBank1Long);
            this.gboxODB.Controls.Add(this.labLambdaPost);
            this.gboxODB.Controls.Add(this.rtdlBank1Oxygen);
            this.gboxODB.Controls.Add(this.labGasCorrection);
            this.gboxODB.Controls.Add(this.rtdlGasCorrection);
            this.gboxODB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxODB.Location = new System.Drawing.Point(647, 40);
            this.gboxODB.Name = "gboxODB";
            this.gboxODB.Size = new System.Drawing.Size(321, 287);
            this.gboxODB.TabIndex = 122;
            this.gboxODB.TabStop = false;
            this.gboxODB.Text = "OBD状态";
            // 
            // labOBDErrorValue
            // 
            this.labOBDErrorValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labOBDErrorValue.AutoSize = true;
            this.labOBDErrorValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOBDErrorValue.Location = new System.Drawing.Point(174, 78);
            this.labOBDErrorValue.Name = "labOBDErrorValue";
            this.labOBDErrorValue.Size = new System.Drawing.Size(26, 21);
            this.labOBDErrorValue.TabIndex = 121;
            this.labOBDErrorValue.Text = "无";
            // 
            // labOBDConnectValue
            // 
            this.labOBDConnectValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labOBDConnectValue.AutoSize = true;
            this.labOBDConnectValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOBDConnectValue.Location = new System.Drawing.Point(174, 40);
            this.labOBDConnectValue.Name = "labOBDConnectValue";
            this.labOBDConnectValue.Size = new System.Drawing.Size(58, 21);
            this.labOBDConnectValue.TabIndex = 120;
            this.labOBDConnectValue.Text = "不可用";
            // 
            // labODBError
            // 
            this.labODBError.AutoSize = true;
            this.labODBError.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labODBError.Location = new System.Drawing.Point(23, 78);
            this.labODBError.Name = "labODBError";
            this.labODBError.Size = new System.Drawing.Size(74, 21);
            this.labODBError.TabIndex = 119;
            this.labODBError.Text = "故障状态";
            // 
            // labOBDConnect
            // 
            this.labOBDConnect.AutoSize = true;
            this.labOBDConnect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOBDConnect.Location = new System.Drawing.Point(20, 40);
            this.labOBDConnect.Name = "labOBDConnect";
            this.labOBDConnect.Size = new System.Drawing.Size(74, 21);
            this.labOBDConnect.TabIndex = 118;
            this.labOBDConnect.Text = "连接状态";
            // 
            // labODBBank1Short
            // 
            this.labODBBank1Short.AutoSize = true;
            this.labODBBank1Short.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labODBBank1Short.Location = new System.Drawing.Point(20, 116);
            this.labODBBank1Short.Name = "labODBBank1Short";
            this.labODBBank1Short.Size = new System.Drawing.Size(74, 21);
            this.labODBBank1Short.TabIndex = 117;
            this.labODBBank1Short.Text = "短期修正";
            // 
            // rtdlOBDBank1Short
            // 
            this.rtdlOBDBank1Short.BackColor = System.Drawing.Color.Transparent;
            this.rtdlOBDBank1Short.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtdlOBDBank1Short.BackgroundImage")));
            this.rtdlOBDBank1Short.Location = new System.Drawing.Point(178, 112);
            this.rtdlOBDBank1Short.Name = "rtdlOBDBank1Short";
            this.rtdlOBDBank1Short.Size = new System.Drawing.Size(99, 28);
            this.rtdlOBDBank1Short.TabIndex = 116;
            this.rtdlOBDBank1Short.UnitText = " %";
            this.rtdlOBDBank1Short.ValueText = "n.a.";
            // 
            // labOBDBank1Long
            // 
            this.labOBDBank1Long.AutoSize = true;
            this.labOBDBank1Long.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOBDBank1Long.Location = new System.Drawing.Point(20, 154);
            this.labOBDBank1Long.Name = "labOBDBank1Long";
            this.labOBDBank1Long.Size = new System.Drawing.Size(74, 21);
            this.labOBDBank1Long.TabIndex = 115;
            this.labOBDBank1Long.Text = "长期修正";
            // 
            // rtdlOBDBank1Long
            // 
            this.rtdlOBDBank1Long.BackColor = System.Drawing.Color.Transparent;
            this.rtdlOBDBank1Long.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtdlOBDBank1Long.BackgroundImage")));
            this.rtdlOBDBank1Long.Location = new System.Drawing.Point(178, 150);
            this.rtdlOBDBank1Long.Name = "rtdlOBDBank1Long";
            this.rtdlOBDBank1Long.Size = new System.Drawing.Size(99, 28);
            this.rtdlOBDBank1Long.TabIndex = 114;
            this.rtdlOBDBank1Long.UnitText = " %";
            this.rtdlOBDBank1Long.ValueText = "n.a.";
            // 
            // labLambdaPost
            // 
            this.labLambdaPost.AutoSize = true;
            this.labLambdaPost.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambdaPost.Location = new System.Drawing.Point(20, 192);
            this.labLambdaPost.Name = "labLambdaPost";
            this.labLambdaPost.Size = new System.Drawing.Size(90, 21);
            this.labLambdaPost.TabIndex = 113;
            this.labLambdaPost.Text = "后氧传感器";
            // 
            // rtdlBank1Oxygen
            // 
            this.rtdlBank1Oxygen.BackColor = System.Drawing.Color.Transparent;
            this.rtdlBank1Oxygen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtdlBank1Oxygen.BackgroundImage")));
            this.rtdlBank1Oxygen.Location = new System.Drawing.Point(178, 188);
            this.rtdlBank1Oxygen.Name = "rtdlBank1Oxygen";
            this.rtdlBank1Oxygen.Size = new System.Drawing.Size(99, 28);
            this.rtdlBank1Oxygen.TabIndex = 112;
            this.rtdlBank1Oxygen.UnitText = " %";
            this.rtdlBank1Oxygen.ValueText = "n.a.";
            // 
            // labGasCorrection
            // 
            this.labGasCorrection.AutoSize = true;
            this.labGasCorrection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasCorrection.Location = new System.Drawing.Point(23, 230);
            this.labGasCorrection.Name = "labGasCorrection";
            this.labGasCorrection.Size = new System.Drawing.Size(74, 21);
            this.labGasCorrection.TabIndex = 111;
            this.labGasCorrection.Text = "燃气修正";
            // 
            // rtdlGasCorrection
            // 
            this.rtdlGasCorrection.BackColor = System.Drawing.Color.Transparent;
            this.rtdlGasCorrection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtdlGasCorrection.BackgroundImage")));
            this.rtdlGasCorrection.Location = new System.Drawing.Point(178, 226);
            this.rtdlGasCorrection.Name = "rtdlGasCorrection";
            this.rtdlGasCorrection.Size = new System.Drawing.Size(99, 28);
            this.rtdlGasCorrection.TabIndex = 110;
            this.rtdlGasCorrection.UnitText = " %";
            this.rtdlGasCorrection.ValueText = "n.a.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(0, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 126);
            this.textBox2.TabIndex = 159;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(671, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 141);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OBS.:";
            this.groupBox1.Visible = false;
            // 
            // rtlLambda2
            // 
            this.rtlLambda2.BackColor = System.Drawing.Color.Transparent;
            this.rtlLambda2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlLambda2.BackgroundImage")));
            this.rtlLambda2.Location = new System.Drawing.Point(868, 594);
            this.rtlLambda2.Name = "rtlLambda2";
            this.rtlLambda2.Size = new System.Drawing.Size(99, 28);
            this.rtlLambda2.TabIndex = 120;
            this.rtlLambda2.UnitText = "V";
            this.rtlLambda2.ValueText = "n.a.";
            // 
            // rtlLambda1
            // 
            this.rtlLambda1.BackColor = System.Drawing.Color.Transparent;
            this.rtlLambda1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlLambda1.BackgroundImage")));
            this.rtlLambda1.Location = new System.Drawing.Point(868, 548);
            this.rtlLambda1.Name = "rtlLambda1";
            this.rtlLambda1.Size = new System.Drawing.Size(99, 28);
            this.rtlLambda1.TabIndex = 119;
            this.rtlLambda1.UnitText = "V";
            this.rtlLambda1.ValueText = "n.a.";
            // 
            // tpbSolenoidValveStatus
            // 
            this.tpbSolenoidValveStatus.BackgroundImage = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus2;
            this.tpbSolenoidValveStatus.Image1 = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus2;
            this.tpbSolenoidValveStatus.Image2 = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus;
            this.tpbSolenoidValveStatus.Location = new System.Drawing.Point(121, 603);
            this.tpbSolenoidValveStatus.Name = "tpbSolenoidValveStatus";
            this.tpbSolenoidValveStatus.Size = new System.Drawing.Size(29, 19);
            this.tpbSolenoidValveStatus.TabIndex = 109;
            // 
            // tpbIgnitionStatus
            // 
            this.tpbIgnitionStatus.BackgroundImage = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.tpbIgnitionStatus.Image1 = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.tpbIgnitionStatus.Image2 = global::IGT.UI.Client.Properties.Resources.IgnitionStatus;
            this.tpbIgnitionStatus.Location = new System.Drawing.Point(122, 548);
            this.tpbIgnitionStatus.Name = "tpbIgnitionStatus";
            this.tpbIgnitionStatus.Size = new System.Drawing.Size(28, 28);
            this.tpbIgnitionStatus.TabIndex = 108;
            // 
            // rtlGasPress
            // 
            this.rtlGasPress.BackColor = System.Drawing.Color.Transparent;
            this.rtlGasPress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlGasPress.BackgroundImage")));
            this.rtlGasPress.Location = new System.Drawing.Point(588, 548);
            this.rtlGasPress.Name = "rtlGasPress";
            this.rtlGasPress.Size = new System.Drawing.Size(99, 28);
            this.rtlGasPress.TabIndex = 99;
            this.rtlGasPress.UnitText = "bar";
            this.rtlGasPress.ValueText = "n.a.";
            // 
            // rtlMapPress
            // 
            this.rtlMapPress.BackColor = System.Drawing.Color.Transparent;
            this.rtlMapPress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlMapPress.BackgroundImage")));
            this.rtlMapPress.Location = new System.Drawing.Point(588, 594);
            this.rtlMapPress.Name = "rtlMapPress";
            this.rtlMapPress.Size = new System.Drawing.Size(99, 28);
            this.rtlMapPress.TabIndex = 97;
            this.rtlMapPress.UnitText = "bar";
            this.rtlMapPress.ValueText = "n.a.";
            // 
            // rtlGas
            // 
            this.rtlGas.BackColor = System.Drawing.Color.Transparent;
            this.rtlGas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlGas.BackgroundImage")));
            this.rtlGas.Location = new System.Drawing.Point(318, 594);
            this.rtlGas.Name = "rtlGas";
            this.rtlGas.Size = new System.Drawing.Size(99, 28);
            this.rtlGas.TabIndex = 96;
            this.rtlGas.UnitText = "ms";
            this.rtlGas.ValueText = "n.a.";
            // 
            // rtlPetrol
            // 
            this.rtlPetrol.BackColor = System.Drawing.Color.Transparent;
            this.rtlPetrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlPetrol.BackgroundImage")));
            this.rtlPetrol.Location = new System.Drawing.Point(318, 548);
            this.rtlPetrol.Name = "rtlPetrol";
            this.rtlPetrol.Size = new System.Drawing.Size(99, 28);
            this.rtlPetrol.TabIndex = 95;
            this.rtlPetrol.UnitText = "ms";
            this.rtlPetrol.ValueText = "n.a.";
            // 
            // tpbLED7
            // 
            this.tpbLED7.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED7.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED7.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightRed;
            this.tpbLED7.Location = new System.Drawing.Point(91, 609);
            this.tpbLED7.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED7.Name = "tpbLED7";
            this.tpbLED7.Size = new System.Drawing.Size(17, 17);
            this.tpbLED7.TabIndex = 92;
            // 
            // tpbLED6
            // 
            this.tpbLED6.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED6.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED6.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightYellow;
            this.tpbLED6.Location = new System.Drawing.Point(9, 609);
            this.tpbLED6.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED6.Name = "tpbLED6";
            this.tpbLED6.Size = new System.Drawing.Size(17, 17);
            this.tpbLED6.TabIndex = 89;
            // 
            // tpbLED5
            // 
            this.tpbLED5.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED5.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED5.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED5.Location = new System.Drawing.Point(91, 535);
            this.tpbLED5.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED5.Name = "tpbLED5";
            this.tpbLED5.Size = new System.Drawing.Size(17, 17);
            this.tpbLED5.TabIndex = 88;
            // 
            // tpbLED4
            // 
            this.tpbLED4.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED4.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED4.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED4.Location = new System.Drawing.Point(71, 535);
            this.tpbLED4.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED4.Name = "tpbLED4";
            this.tpbLED4.Size = new System.Drawing.Size(17, 17);
            this.tpbLED4.TabIndex = 87;
            // 
            // tpbLED3
            // 
            this.tpbLED3.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED3.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED3.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED3.Location = new System.Drawing.Point(51, 535);
            this.tpbLED3.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED3.Name = "tpbLED3";
            this.tpbLED3.Size = new System.Drawing.Size(17, 17);
            this.tpbLED3.TabIndex = 86;
            // 
            // tpbLED2
            // 
            this.tpbLED2.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED2.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED2.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED2.Location = new System.Drawing.Point(31, 535);
            this.tpbLED2.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED2.Name = "tpbLED2";
            this.tpbLED2.Size = new System.Drawing.Size(17, 17);
            this.tpbLED2.TabIndex = 85;
            // 
            // tpbLED1
            // 
            this.tpbLED1.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED1.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED1.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightRed;
            this.tpbLED1.Location = new System.Drawing.Point(11, 535);
            this.tpbLED1.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED1.Name = "tpbLED1";
            this.tpbLED1.Size = new System.Drawing.Size(17, 17);
            this.tpbLED1.TabIndex = 84;
            // 
            // injectorsMeasurement1
            // 
            this.injectorsMeasurement1.BackColor = System.Drawing.Color.Transparent;
            this.injectorsMeasurement1.BackgroundImage = global::IGT.UI.Client.Properties.Resources.InjectorsMeasurement;
            this.injectorsMeasurement1.Location = new System.Drawing.Point(7, 341);
            this.injectorsMeasurement1.Name = "injectorsMeasurement1";
            this.injectorsMeasurement1.Size = new System.Drawing.Size(357, 160);
            this.injectorsMeasurement1.TabIndex = 113;
            this.injectorsMeasurement1.Value = 0;
            // 
            // tpbSwitchKey
            // 
            this.tpbSwitchKey.BackgroundImage = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder;
            this.tpbSwitchKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpbSwitchKey.Image1 = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder;
            this.tpbSwitchKey.Image2 = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder2;
            this.tpbSwitchKey.Location = new System.Drawing.Point(22, 555);
            this.tpbSwitchKey.Name = "tpbSwitchKey";
            this.tpbSwitchKey.Size = new System.Drawing.Size(70, 64);
            this.tpbSwitchKey.TabIndex = 90;
            this.tpbSwitchKey.Click += new System.EventHandler(this.tpbSwitchKey_Click);
            // 
            // RealyTimeData
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackgroundImage = global::IGT.UI.Client.Properties.Resources.background1;
            this.Controls.Add(this.labRed);
            this.Controls.Add(this.labGas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dasTempGasTemp);
            this.Controls.Add(this.dasTempRedTemp);
            this.Controls.Add(this.gboxODB);
            this.Controls.Add(this.gBoxAdp);
            this.Controls.Add(this.rtlLambda2);
            this.Controls.Add(this.rtlLambda1);
            this.Controls.Add(this.labLambda2);
            this.Controls.Add(this.labLambda1);
            this.Controls.Add(this.labCorrect);
            this.Controls.Add(this.labTooSmall);
            this.Controls.Add(this.labTooBig);
            this.Controls.Add(this.labeInje);
            this.Controls.Add(this.tpbSolenoidValveStatus);
            this.Controls.Add(this.tpbIgnitionStatus);
            this.Controls.Add(this.labMapPress);
            this.Controls.Add(this.labGasPress);
            this.Controls.Add(this.labGas1);
            this.Controls.Add(this.labPetrol1);
            this.Controls.Add(this.rtlGasPress);
            this.Controls.Add(this.rtlMapPress);
            this.Controls.Add(this.rtlGas);
            this.Controls.Add(this.rtlPetrol);
            this.Controls.Add(this.tpbLED7);
            this.Controls.Add(this.tpbLED6);
            this.Controls.Add(this.tpbLED5);
            this.Controls.Add(this.tpbLED4);
            this.Controls.Add(this.tpbLED3);
            this.Controls.Add(this.tpbLED2);
            this.Controls.Add(this.tpbLED1);
            this.Controls.Add(this.daSCGRPM);
            this.Controls.Add(this.injectorsMeasurement1);
            this.Controls.Add(this.tpbSwitchKey);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RealyTimeData";
            this.Size = new System.Drawing.Size(1012, 652);
            this.Load += new System.EventHandler(this.RealyTimeData_Load);
            this.gBoxAdp.ResumeLayout(false);
            this.gBoxAdp.PerformLayout();
            this.gboxODB.ResumeLayout(false);
            this.gboxODB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DasNetTemperature.DAS_Net_Temperature dasTempGasTemp;
        private DasNetTemperature.DAS_Net_Temperature dasTempRedTemp;
        private DasNetGauge.DAS_Net_CircleGauge daSCGRPM;
        private System.Windows.Forms.Label labGas;
        private System.Windows.Forms.Label labRed;
        private UserControls.TogglePictureBox tpbSolenoidValveStatus;
        private UserControls.TogglePictureBox tpbIgnitionStatus;
        private System.Windows.Forms.Label labGas1;
        private System.Windows.Forms.Label labPetrol1;
        private UserControls.RealTimeDataLabel rtlGas;
        private UserControls.RealTimeDataLabel rtlPetrol;
        private UserControls.TogglePictureBox tpbLED7;
        private UserControls.TogglePictureBox tpbSwitchKey;
        private UserControls.TogglePictureBox tpbLED6;
        private UserControls.TogglePictureBox tpbLED5;
        private UserControls.TogglePictureBox tpbLED4;
        private UserControls.TogglePictureBox tpbLED3;
        private UserControls.TogglePictureBox tpbLED2;
        private UserControls.TogglePictureBox tpbLED1;
        private UserControls.RealTimeDataLabel rtlMapPress;
        private UserControls.RealTimeDataLabel rtlGasPress;
        private System.Windows.Forms.Label labGasPress;
        private System.Windows.Forms.Label labMapPress;
        private System.Windows.Forms.Label labeInje;
        private UserControls.InjectorsMeasurement injectorsMeasurement1;
        private System.Windows.Forms.Label labCorrect;
        private System.Windows.Forms.Label labTooSmall;
        private System.Windows.Forms.Label labTooBig;
        private UserControls.RealTimeDataLabel rtlLambda2;
        private UserControls.RealTimeDataLabel rtlLambda1;
        private System.Windows.Forms.Label labLambda2;
        private System.Windows.Forms.Label labLambda1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxAdp;
        private System.Windows.Forms.Label labAOffset;
        private UserControls.RealTimeDataLabel rtdlAdaptiveOffset;
        private System.Windows.Forms.Label labAC;
        private UserControls.RealTimeDataLabel rtdlAAdaptiveC;
        private System.Windows.Forms.GroupBox gboxODB;
        private System.Windows.Forms.Label labOBDErrorValue;
        private System.Windows.Forms.Label labOBDConnectValue;
        private System.Windows.Forms.Label labODBError;
        private System.Windows.Forms.Label labOBDConnect;
        private System.Windows.Forms.Label labODBBank1Short;
        private UserControls.RealTimeDataLabel rtdlOBDBank1Short;
        private System.Windows.Forms.Label labOBDBank1Long;
        private UserControls.RealTimeDataLabel rtdlOBDBank1Long;
        private System.Windows.Forms.Label labLambdaPost;
        private UserControls.RealTimeDataLabel rtdlBank1Oxygen;
        private System.Windows.Forms.Label labGasCorrection;
        private UserControls.RealTimeDataLabel rtdlGasCorrection;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
