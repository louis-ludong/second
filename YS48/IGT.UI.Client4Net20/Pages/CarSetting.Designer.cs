namespace IGT.UI.Client.Pages
{
    partial class CarSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSetting));
            this.labGasLevel = new System.Windows.Forms.Label();
            this.labMapPress = new System.Windows.Forms.Label();
            this.labGasPress = new System.Windows.Forms.Label();
            this.labGas1 = new System.Windows.Forms.Label();
            this.labPetrol1 = new System.Windows.Forms.Label();
            this.labTempGas = new System.Windows.Forms.Label();
            this.labTempRed = new System.Windows.Forms.Label();
            this.labRPMSource = new System.Windows.Forms.Label();
            this.labLambda1 = new System.Windows.Forms.Label();
            this.labLambda2 = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btn1 = new IGT.UI.Client.VistaButton();
            this.btn2 = new IGT.UI.Client.VistaButton();
            this.labRPM = new System.Windows.Forms.Label();
            this.btn9 = new IGT.UI.Client.VistaButton();
            this.btn8 = new IGT.UI.Client.VistaButton();
            this.btn7 = new IGT.UI.Client.VistaButton();
            this.rtlLambda2 = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.MAPbtn = new IGT.UI.Client.VistaButton();
            this.rtlLambda1 = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.btn3 = new IGT.UI.Client.VistaButton();
            this.tpbSolenoidValveStatus = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbIgnitionStatus = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.rtlGasPress = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlGasLevel = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlMapPress = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlGas = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlPetrol = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlTempRed = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.rtlTempGas = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.tpbLED7 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.rtlRPM = new IGT.UI.Client.UserControls.RealTimeDataLabel();
            this.tpbLED6 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED5 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED4 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED3 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED2 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbLED1 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbSwitchKey = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.OBDSETBtn = new IGT.UI.Client.VistaButton();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labGasLevel
            // 
            this.labGasLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labGasLevel.AutoEllipsis = true;
            this.labGasLevel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasLevel.Location = new System.Drawing.Point(583, 586);
            this.labGasLevel.Name = "labGasLevel";
            this.labGasLevel.Size = new System.Drawing.Size(114, 28);
            this.labGasLevel.TabIndex = 75;
            this.labGasLevel.Text = "液位传感器";
            this.labGasLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labMapPress
            // 
            this.labMapPress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labMapPress.AutoEllipsis = true;
            this.labMapPress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMapPress.Location = new System.Drawing.Point(583, 552);
            this.labMapPress.Name = "labMapPress";
            this.labMapPress.Size = new System.Drawing.Size(114, 27);
            this.labMapPress.TabIndex = 74;
            this.labMapPress.Text = "真空压力";
            this.labMapPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGasPress
            // 
            this.labGasPress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labGasPress.AutoEllipsis = true;
            this.labGasPress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasPress.Location = new System.Drawing.Point(361, 619);
            this.labGasPress.Name = "labGasPress";
            this.labGasPress.Size = new System.Drawing.Size(111, 28);
            this.labGasPress.TabIndex = 73;
            this.labGasPress.Text = "燃气压力";
            this.labGasPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGas1
            // 
            this.labGas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labGas1.AutoEllipsis = true;
            this.labGas1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGas1.Location = new System.Drawing.Point(364, 586);
            this.labGas1.Name = "labGas1";
            this.labGas1.Size = new System.Drawing.Size(108, 27);
            this.labGas1.TabIndex = 72;
            this.labGas1.Text = "喷气时间";
            this.labGas1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPetrol1
            // 
            this.labPetrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labPetrol1.AutoEllipsis = true;
            this.labPetrol1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPetrol1.Location = new System.Drawing.Point(361, 552);
            this.labPetrol1.Name = "labPetrol1";
            this.labPetrol1.Size = new System.Drawing.Size(111, 27);
            this.labPetrol1.TabIndex = 71;
            this.labPetrol1.Text = "喷油时间";
            this.labPetrol1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labTempGas
            // 
            this.labTempGas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTempGas.AutoEllipsis = true;
            this.labTempGas.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTempGas.Location = new System.Drawing.Point(155, 586);
            this.labTempGas.Name = "labTempGas";
            this.labTempGas.Size = new System.Drawing.Size(97, 28);
            this.labTempGas.TabIndex = 70;
            this.labTempGas.Text = "燃气温度";
            this.labTempGas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labTempRed
            // 
            this.labTempRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTempRed.AutoEllipsis = true;
            this.labTempRed.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTempRed.Location = new System.Drawing.Point(155, 620);
            this.labTempRed.Name = "labTempRed";
            this.labTempRed.Size = new System.Drawing.Size(97, 27);
            this.labTempRed.TabIndex = 69;
            this.labTempRed.Text = "减压器温度";
            this.labTempRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labRPMSource
            // 
            this.labRPMSource.AutoEllipsis = true;
            this.labRPMSource.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRPMSource.Location = new System.Drawing.Point(620, 619);
            this.labRPMSource.Name = "labRPMSource";
            this.labRPMSource.Size = new System.Drawing.Size(229, 28);
            this.labRPMSource.TabIndex = 78;
            this.labRPMSource.Text = "转速信号源";
            this.labRPMSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labRPMSource.Visible = false;
            // 
            // labLambda1
            // 
            this.labLambda1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labLambda1.AutoEllipsis = true;
            this.labLambda1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambda1.Location = new System.Drawing.Point(814, 552);
            this.labLambda1.Name = "labLambda1";
            this.labLambda1.Size = new System.Drawing.Size(106, 27);
            this.labLambda1.TabIndex = 80;
            this.labLambda1.Text = "氧传感器1";
            this.labLambda1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labLambda2
            // 
            this.labLambda2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labLambda2.AutoEllipsis = true;
            this.labLambda2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambda2.Location = new System.Drawing.Point(814, 586);
            this.labLambda2.Name = "labLambda2";
            this.labLambda2.Size = new System.Drawing.Size(106, 28);
            this.labLambda2.TabIndex = 81;
            this.labLambda2.Text = "氧传感器2";
            this.labLambda2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelSettings.Controls.Add(this.btn1);
            this.panelSettings.Controls.Add(this.btn2);
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(827, 541);
            this.panelSettings.TabIndex = 84;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.btn1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.btn1.ButtonText = "标准设定";
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(17, 14);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(204, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BaseColor = System.Drawing.Color.White;
            this.btn2.ButtonColor = System.Drawing.Color.White;
            this.btn2.ButtonText = "高级设定";
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(227, 14);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(204, 50);
            this.btn2.TabIndex = 0;
            this.btn2.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // labRPM
            // 
            this.labRPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labRPM.AutoEllipsis = true;
            this.labRPM.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRPM.Location = new System.Drawing.Point(152, 551);
            this.labRPM.Name = "labRPM";
            this.labRPM.Size = new System.Drawing.Size(100, 28);
            this.labRPM.TabIndex = 68;
            this.labRPM.Text = "发动机转速";
            this.labRPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BaseColor = System.Drawing.Color.White;
            this.btn9.ButtonColor = System.Drawing.Color.White;
            this.btn9.ButtonText = "附加设定";
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.HighlightColor = System.Drawing.Color.LightGray;
            this.btn9.Location = new System.Drawing.Point(833, 261);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(177, 50);
            this.btn9.TabIndex = 0;
            this.btn9.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BaseColor = System.Drawing.Color.White;
            this.btn8.ButtonColor = System.Drawing.Color.White;
            this.btn8.ButtonText = "设定";
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.HighlightColor = System.Drawing.Color.LightGray;
            this.btn8.Location = new System.Drawing.Point(833, 93);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(177, 50);
            this.btn8.TabIndex = 0;
            this.btn8.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BaseColor = System.Drawing.Color.White;
            this.btn7.ButtonColor = System.Drawing.Color.White;
            this.btn7.ButtonText = "高级选项";
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.HighlightColor = System.Drawing.Color.LightGray;
            this.btn7.Location = new System.Drawing.Point(833, 373);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(177, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Visible = false;
            this.btn7.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // rtlLambda2
            // 
            this.rtlLambda2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlLambda2.BackColor = System.Drawing.Color.Transparent;
            this.rtlLambda2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlLambda2.BackgroundImage")));
            this.rtlLambda2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlLambda2.Location = new System.Drawing.Point(926, 586);
            this.rtlLambda2.Name = "rtlLambda2";
            this.rtlLambda2.Size = new System.Drawing.Size(99, 28);
            this.rtlLambda2.TabIndex = 83;
            this.rtlLambda2.UnitText = "V";
            this.rtlLambda2.ValueText = "n.a.";
            // 
            // MAPbtn
            // 
            this.MAPbtn.BackColor = System.Drawing.Color.Transparent;
            this.MAPbtn.BaseColor = System.Drawing.Color.White;
            this.MAPbtn.ButtonColor = System.Drawing.Color.White;
            this.MAPbtn.ButtonText = "图表";
            this.MAPbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.MAPbtn.ForeColor = System.Drawing.Color.Black;
            this.MAPbtn.HighlightColor = System.Drawing.Color.LightGray;
            this.MAPbtn.Location = new System.Drawing.Point(833, 205);
            this.MAPbtn.Name = "MAPbtn";
            this.MAPbtn.Size = new System.Drawing.Size(177, 50);
            this.MAPbtn.TabIndex = 0;
            this.MAPbtn.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // rtlLambda1
            // 
            this.rtlLambda1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlLambda1.BackColor = System.Drawing.Color.Transparent;
            this.rtlLambda1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlLambda1.BackgroundImage")));
            this.rtlLambda1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlLambda1.Location = new System.Drawing.Point(926, 550);
            this.rtlLambda1.Name = "rtlLambda1";
            this.rtlLambda1.Size = new System.Drawing.Size(99, 28);
            this.rtlLambda1.TabIndex = 82;
            this.rtlLambda1.UnitText = "V";
            this.rtlLambda1.ValueText = "n.a.";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BaseColor = System.Drawing.Color.White;
            this.btn3.ButtonColor = System.Drawing.Color.White;
            this.btn3.ButtonText = "传感器设定";
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.HighlightColor = System.Drawing.Color.LightGray;
            this.btn3.Location = new System.Drawing.Point(833, 149);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(177, 50);
            this.btn3.TabIndex = 0;
            this.btn3.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // tpbSolenoidValveStatus
            // 
            this.tpbSolenoidValveStatus.BackColor = System.Drawing.Color.Black;
            this.tpbSolenoidValveStatus.BackgroundImage = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus2;
            this.tpbSolenoidValveStatus.Image1 = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus2;
            this.tpbSolenoidValveStatus.Image2 = global::IGT.UI.Client.Properties.Resources.SolenoidValveStatus;
            this.tpbSolenoidValveStatus.Location = new System.Drawing.Point(115, 620);
            this.tpbSolenoidValveStatus.Name = "tpbSolenoidValveStatus";
            this.tpbSolenoidValveStatus.Size = new System.Drawing.Size(29, 19);
            this.tpbSolenoidValveStatus.TabIndex = 77;
            // 
            // tpbIgnitionStatus
            // 
            this.tpbIgnitionStatus.BackgroundImage = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.tpbIgnitionStatus.Image1 = global::IGT.UI.Client.Properties.Resources.IgnitionStatus2;
            this.tpbIgnitionStatus.Image2 = global::IGT.UI.Client.Properties.Resources.IgnitionStatus;
            this.tpbIgnitionStatus.Location = new System.Drawing.Point(116, 565);
            this.tpbIgnitionStatus.Name = "tpbIgnitionStatus";
            this.tpbIgnitionStatus.Size = new System.Drawing.Size(28, 28);
            this.tpbIgnitionStatus.TabIndex = 76;
            // 
            // rtlGasPress
            // 
            this.rtlGasPress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlGasPress.BackColor = System.Drawing.Color.Transparent;
            this.rtlGasPress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlGasPress.BackgroundImage")));
            this.rtlGasPress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlGasPress.Location = new System.Drawing.Point(478, 619);
            this.rtlGasPress.Name = "rtlGasPress";
            this.rtlGasPress.Size = new System.Drawing.Size(99, 28);
            this.rtlGasPress.TabIndex = 66;
            this.rtlGasPress.UnitText = "bar";
            this.rtlGasPress.ValueText = "n.a.";
            // 
            // rtlGasLevel
            // 
            this.rtlGasLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlGasLevel.BackColor = System.Drawing.Color.Transparent;
            this.rtlGasLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlGasLevel.BackgroundImage")));
            this.rtlGasLevel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlGasLevel.Location = new System.Drawing.Point(708, 586);
            this.rtlGasLevel.Name = "rtlGasLevel";
            this.rtlGasLevel.Size = new System.Drawing.Size(99, 28);
            this.rtlGasLevel.TabIndex = 62;
            this.rtlGasLevel.UnitText = "V";
            this.rtlGasLevel.ValueText = "n.a.";
            // 
            // rtlMapPress
            // 
            this.rtlMapPress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlMapPress.BackColor = System.Drawing.Color.Transparent;
            this.rtlMapPress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlMapPress.BackgroundImage")));
            this.rtlMapPress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlMapPress.Location = new System.Drawing.Point(708, 551);
            this.rtlMapPress.Name = "rtlMapPress";
            this.rtlMapPress.Size = new System.Drawing.Size(99, 28);
            this.rtlMapPress.TabIndex = 60;
            this.rtlMapPress.UnitText = "bar";
            this.rtlMapPress.ValueText = "n.a.";
            // 
            // rtlGas
            // 
            this.rtlGas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlGas.BackColor = System.Drawing.Color.Transparent;
            this.rtlGas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlGas.BackgroundImage")));
            this.rtlGas.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlGas.Location = new System.Drawing.Point(478, 585);
            this.rtlGas.Name = "rtlGas";
            this.rtlGas.Size = new System.Drawing.Size(99, 28);
            this.rtlGas.TabIndex = 56;
            this.rtlGas.UnitText = "ms";
            this.rtlGas.ValueText = "n.a.";
            // 
            // rtlPetrol
            // 
            this.rtlPetrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlPetrol.BackColor = System.Drawing.Color.Transparent;
            this.rtlPetrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlPetrol.BackgroundImage")));
            this.rtlPetrol.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtlPetrol.Location = new System.Drawing.Point(478, 551);
            this.rtlPetrol.Name = "rtlPetrol";
            this.rtlPetrol.Size = new System.Drawing.Size(99, 28);
            this.rtlPetrol.TabIndex = 54;
            this.rtlPetrol.UnitText = "ms";
            this.rtlPetrol.ValueText = "n.a.";
            // 
            // rtlTempRed
            // 
            this.rtlTempRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlTempRed.BackColor = System.Drawing.Color.Transparent;
            this.rtlTempRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlTempRed.BackgroundImage")));
            this.rtlTempRed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlTempRed.Location = new System.Drawing.Point(258, 620);
            this.rtlTempRed.Name = "rtlTempRed";
            this.rtlTempRed.Size = new System.Drawing.Size(99, 28);
            this.rtlTempRed.TabIndex = 52;
            this.rtlTempRed.UnitText = "℃";
            this.rtlTempRed.ValueText = "n.a.";
            // 
            // rtlTempGas
            // 
            this.rtlTempGas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlTempGas.BackColor = System.Drawing.Color.Transparent;
            this.rtlTempGas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlTempGas.BackgroundImage")));
            this.rtlTempGas.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.rtlTempGas.Location = new System.Drawing.Point(258, 586);
            this.rtlTempGas.Name = "rtlTempGas";
            this.rtlTempGas.Size = new System.Drawing.Size(99, 28);
            this.rtlTempGas.TabIndex = 50;
            this.rtlTempGas.UnitText = "℃";
            this.rtlTempGas.ValueText = "n.a.";
            // 
            // tpbLED7
            // 
            this.tpbLED7.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED7.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED7.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightRed;
            this.tpbLED7.Location = new System.Drawing.Point(85, 626);
            this.tpbLED7.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED7.Name = "tpbLED7";
            this.tpbLED7.Size = new System.Drawing.Size(17, 17);
            this.tpbLED7.TabIndex = 40;
            // 
            // rtlRPM
            // 
            this.rtlRPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtlRPM.BackColor = System.Drawing.Color.Transparent;
            this.rtlRPM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtlRPM.BackgroundImage")));
            this.rtlRPM.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtlRPM.Location = new System.Drawing.Point(258, 552);
            this.rtlRPM.Name = "rtlRPM";
            this.rtlRPM.Size = new System.Drawing.Size(99, 28);
            this.rtlRPM.TabIndex = 38;
            this.rtlRPM.UnitText = " RPM";
            this.rtlRPM.ValueText = "n.a.";
            // 
            // tpbLED6
            // 
            this.tpbLED6.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED6.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED6.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightYellow;
            this.tpbLED6.Location = new System.Drawing.Point(6, 626);
            this.tpbLED6.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED6.Name = "tpbLED6";
            this.tpbLED6.Size = new System.Drawing.Size(17, 17);
            this.tpbLED6.TabIndex = 36;
            // 
            // tpbLED5
            // 
            this.tpbLED5.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED5.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED5.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED5.Location = new System.Drawing.Point(85, 552);
            this.tpbLED5.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED5.Name = "tpbLED5";
            this.tpbLED5.Size = new System.Drawing.Size(17, 17);
            this.tpbLED5.TabIndex = 35;
            // 
            // tpbLED4
            // 
            this.tpbLED4.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED4.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED4.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED4.Location = new System.Drawing.Point(65, 552);
            this.tpbLED4.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED4.Name = "tpbLED4";
            this.tpbLED4.Size = new System.Drawing.Size(17, 17);
            this.tpbLED4.TabIndex = 34;
            // 
            // tpbLED3
            // 
            this.tpbLED3.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED3.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED3.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED3.Location = new System.Drawing.Point(45, 552);
            this.tpbLED3.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED3.Name = "tpbLED3";
            this.tpbLED3.Size = new System.Drawing.Size(17, 17);
            this.tpbLED3.TabIndex = 33;
            // 
            // tpbLED2
            // 
            this.tpbLED2.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED2.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED2.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightGreen;
            this.tpbLED2.Location = new System.Drawing.Point(25, 552);
            this.tpbLED2.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED2.Name = "tpbLED2";
            this.tpbLED2.Size = new System.Drawing.Size(17, 17);
            this.tpbLED2.TabIndex = 32;
            // 
            // tpbLED1
            // 
            this.tpbLED1.BackgroundImage = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpbLED1.Image1 = global::IGT.UI.Client.Properties.Resources.LEDLightNone;
            this.tpbLED1.Image2 = global::IGT.UI.Client.Properties.Resources.LEDLightRed;
            this.tpbLED1.Location = new System.Drawing.Point(6, 552);
            this.tpbLED1.Margin = new System.Windows.Forms.Padding(0);
            this.tpbLED1.Name = "tpbLED1";
            this.tpbLED1.Size = new System.Drawing.Size(17, 17);
            this.tpbLED1.TabIndex = 31;
            // 
            // tpbSwitchKey
            // 
            this.tpbSwitchKey.BackgroundImage = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder;
            this.tpbSwitchKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpbSwitchKey.Image1 = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder;
            this.tpbSwitchKey.Image2 = global::IGT.UI.Client.Properties.Resources.KeySwitchNoBorder2;
            this.tpbSwitchKey.Location = new System.Drawing.Point(17, 572);
            this.tpbSwitchKey.Name = "tpbSwitchKey";
            this.tpbSwitchKey.Size = new System.Drawing.Size(68, 64);
            this.tpbSwitchKey.TabIndex = 37;
            this.tpbSwitchKey.Click += new System.EventHandler(this.tpbSwitchKey_Click);
            // 
            // OBDSETBtn
            // 
            this.OBDSETBtn.BackColor = System.Drawing.Color.Transparent;
            this.OBDSETBtn.BaseColor = System.Drawing.Color.White;
            this.OBDSETBtn.ButtonColor = System.Drawing.Color.White;
            this.OBDSETBtn.ButtonText = "OBD设置";
            this.OBDSETBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.OBDSETBtn.ForeColor = System.Drawing.Color.Black;
            this.OBDSETBtn.HighlightColor = System.Drawing.Color.LightGray;
            this.OBDSETBtn.Location = new System.Drawing.Point(833, 317);
            this.OBDSETBtn.Name = "OBDSETBtn";
            this.OBDSETBtn.Size = new System.Drawing.Size(177, 50);
            this.OBDSETBtn.TabIndex = 0;
            this.OBDSETBtn.Click += new System.EventHandler(this.CMenu_Click);
            // 
            // CarSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::IGT.UI.Client.Properties.Resources.background1;
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.OBDSETBtn);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.rtlLambda2);
            this.Controls.Add(this.MAPbtn);
            this.Controls.Add(this.rtlLambda1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.labLambda2);
            this.Controls.Add(this.labLambda1);
            this.Controls.Add(this.labRPMSource);
            this.Controls.Add(this.tpbSolenoidValveStatus);
            this.Controls.Add(this.tpbIgnitionStatus);
            this.Controls.Add(this.labGasLevel);
            this.Controls.Add(this.labMapPress);
            this.Controls.Add(this.labGasPress);
            this.Controls.Add(this.labGas1);
            this.Controls.Add(this.labPetrol1);
            this.Controls.Add(this.labTempGas);
            this.Controls.Add(this.labTempRed);
            this.Controls.Add(this.labRPM);
            this.Controls.Add(this.rtlGasPress);
            this.Controls.Add(this.rtlGasLevel);
            this.Controls.Add(this.rtlMapPress);
            this.Controls.Add(this.rtlGas);
            this.Controls.Add(this.rtlPetrol);
            this.Controls.Add(this.rtlTempRed);
            this.Controls.Add(this.rtlTempGas);
            this.Controls.Add(this.tpbLED7);
            this.Controls.Add(this.rtlRPM);
            this.Controls.Add(this.tpbLED6);
            this.Controls.Add(this.tpbLED5);
            this.Controls.Add(this.tpbLED4);
            this.Controls.Add(this.tpbLED3);
            this.Controls.Add(this.tpbLED2);
            this.Controls.Add(this.tpbLED1);
            this.Controls.Add(this.tpbSwitchKey);
            this.DoubleBuffered = true;
            this.Name = "CarSetting";
            this.Size = new System.Drawing.Size(1035, 656);
            this.Load += new System.EventHandler(this.CarSetting_Load);
            this.panelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.TogglePictureBox tpbLED1;
        private UserControls.TogglePictureBox tpbLED2;
        private UserControls.TogglePictureBox tpbLED3;
        private UserControls.TogglePictureBox tpbLED4;
        private UserControls.TogglePictureBox tpbLED5;
        private UserControls.TogglePictureBox tpbLED6;
        private UserControls.TogglePictureBox tpbSwitchKey;
        private UserControls.RealTimeDataLabel rtlRPM;
        private UserControls.TogglePictureBox tpbLED7;
        private UserControls.RealTimeDataLabel rtlTempGas;
        private UserControls.RealTimeDataLabel rtlTempRed;
        private UserControls.RealTimeDataLabel rtlGas;
        private UserControls.RealTimeDataLabel rtlPetrol;
        private UserControls.RealTimeDataLabel rtlGasLevel;
        private UserControls.RealTimeDataLabel rtlMapPress;
        private UserControls.RealTimeDataLabel rtlGasPress;
        private System.Windows.Forms.Label labGasLevel;
        private System.Windows.Forms.Label labMapPress;
        private System.Windows.Forms.Label labGasPress;
        private System.Windows.Forms.Label labGas1;
        private System.Windows.Forms.Label labPetrol1;
        private System.Windows.Forms.Label labTempGas;
        private System.Windows.Forms.Label labTempRed;
        private UserControls.TogglePictureBox tpbIgnitionStatus;
        private UserControls.TogglePictureBox tpbSolenoidValveStatus;
        private System.Windows.Forms.Label labLambda1;
        private System.Windows.Forms.Label labLambda2;
        private UserControls.RealTimeDataLabel rtlLambda1;
        private UserControls.RealTimeDataLabel rtlLambda2;
        private System.Windows.Forms.Label labRPMSource;
        private VistaButton btn9;
        private VistaButton btn8;
        private VistaButton btn7;
        private VistaButton MAPbtn;
        private VistaButton btn3;
        private VistaButton btn2;
        private VistaButton btn1;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labRPM;
        private VistaButton OBDSETBtn;
    }
}
