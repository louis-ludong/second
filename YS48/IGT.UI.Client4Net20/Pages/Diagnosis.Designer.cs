namespace IGT.UI.Client.Pages
{
    partial class Diagnosis
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否 则为 false。</param>
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
            this.labXTip = new System.Windows.Forms.Label();
            this.labOKTip = new System.Windows.Forms.Label();
            this.labOpTime = new System.Windows.Forms.Label();
            this.labGasTitle = new System.Windows.Forms.Label();
            this.labPetrolTitle = new System.Windows.Forms.Label();
            this.labRedTime = new System.Windows.Forms.Label();
            this.labGasTime = new System.Windows.Forms.Label();
            this.ddlBank = new System.Windows.Forms.ComboBox();
            this.listvErrors = new System.Windows.Forms.ListView();
            this.clnErr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiagnosis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbAutoDiagnosis = new System.Windows.Forms.CheckBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetErrors = new IGT.UI.Client.VistaButton();
            this.btnOBDErrors = new IGT.UI.Client.VistaButton();
            this.diaLine16 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine15 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine14 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine13 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine12 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine11 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine10 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine9 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine8 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine7 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine6 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine5 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine4 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine3 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine2 = new IGT.UI.Client.UserControls.DiaLine();
            this.diaLine1 = new IGT.UI.Client.UserControls.DiaLine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labXTip
            // 
            this.labXTip.AutoSize = true;
            this.labXTip.BackColor = System.Drawing.Color.Transparent;
            this.labXTip.Location = new System.Drawing.Point(38, 589);
            this.labXTip.Name = "labXTip";
            this.labXTip.Size = new System.Drawing.Size(89, 12);
            this.labXTip.TabIndex = 48;
            this.labXTip.Text = "X - 喷嘴未就绪";
            // 
            // labOKTip
            // 
            this.labOKTip.AutoSize = true;
            this.labOKTip.BackColor = System.Drawing.Color.Transparent;
            this.labOKTip.Location = new System.Drawing.Point(36, 573);
            this.labOKTip.Name = "labOKTip";
            this.labOKTip.Size = new System.Drawing.Size(95, 12);
            this.labOKTip.TabIndex = 47;
            this.labOKTip.Text = "OK - 喷嘴已就绪";
            // 
            // labOpTime
            // 
            this.labOpTime.AutoEllipsis = true;
            this.labOpTime.BackColor = System.Drawing.Color.Transparent;
            this.labOpTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOpTime.Location = new System.Drawing.Point(396, 482);
            this.labOpTime.Name = "labOpTime";
            this.labOpTime.Size = new System.Drawing.Size(253, 28);
            this.labOpTime.TabIndex = 46;
            this.labOpTime.Text = "操作时间";
            this.labOpTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labGasTitle
            // 
            this.labGasTitle.AutoEllipsis = true;
            this.labGasTitle.BackColor = System.Drawing.Color.Transparent;
            this.labGasTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasTitle.Location = new System.Drawing.Point(36, 20);
            this.labGasTitle.Name = "labGasTitle";
            this.labGasTitle.Size = new System.Drawing.Size(136, 33);
            this.labGasTitle.TabIndex = 45;
            this.labGasTitle.Text = "燃气喷嘴诊断";
            this.labGasTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPetrolTitle
            // 
            this.labPetrolTitle.AutoEllipsis = true;
            this.labPetrolTitle.BackColor = System.Drawing.Color.Transparent;
            this.labPetrolTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPetrolTitle.Location = new System.Drawing.Point(32, 330);
            this.labPetrolTitle.Name = "labPetrolTitle";
            this.labPetrolTitle.Size = new System.Drawing.Size(273, 33);
            this.labPetrolTitle.TabIndex = 44;
            this.labPetrolTitle.Text = "汽油喷嘴信号诊断";
            this.labPetrolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labRedTime
            // 
            this.labRedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labRedTime.BackColor = System.Drawing.Color.White;
            this.labRedTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRedTime.Location = new System.Drawing.Point(472, 583);
            this.labRedTime.Name = "labRedTime";
            this.labRedTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labRedTime.Size = new System.Drawing.Size(95, 25);
            this.labRedTime.TabIndex = 35;
            this.labRedTime.Text = "00000:00";
            this.labRedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labGasTime
            // 
            this.labGasTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labGasTime.BackColor = System.Drawing.Color.White;
            this.labGasTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasTime.Location = new System.Drawing.Point(471, 532);
            this.labGasTime.Name = "labGasTime";
            this.labGasTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labGasTime.Size = new System.Drawing.Size(96, 25);
            this.labGasTime.TabIndex = 34;
            this.labGasTime.Text = "00000:00";
            this.labGasTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ddlBank
            // 
            this.ddlBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBank.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddlBank.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlBank.FormattingEnabled = true;
            this.ddlBank.Items.AddRange(new object[] {
            "Bank1",
            "Bank2"});
            this.ddlBank.Location = new System.Drawing.Point(178, 20);
            this.ddlBank.Name = "ddlBank";
            this.ddlBank.Size = new System.Drawing.Size(121, 33);
            this.ddlBank.TabIndex = 65;
            this.ddlBank.SelectedIndexChanged += new System.EventHandler(this.ddlBank_SelectedIndexChanged);
            // 
            // listvErrors
            // 
            this.listvErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.listvErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnErr,
            this.clnDiagnosis,
            this.clnState});
            this.listvErrors.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listvErrors.FullRowSelect = true;
            this.listvErrors.LabelWrap = false;
            this.listvErrors.Location = new System.Drawing.Point(334, 3);
            this.listvErrors.MultiSelect = false;
            this.listvErrors.Name = "listvErrors";
            this.listvErrors.Size = new System.Drawing.Size(633, 462);
            this.listvErrors.TabIndex = 66;
            this.listvErrors.UseCompatibleStateImageBehavior = false;
            this.listvErrors.View = System.Windows.Forms.View.Details;
            // 
            // clnErr
            // 
            this.clnErr.Text = "Error code";
            this.clnErr.Width = 125;
            // 
            // clnDiagnosis
            // 
            this.clnDiagnosis.Text = "Diagnosis";
            this.clnDiagnosis.Width = 392;
            // 
            // clnState
            // 
            this.clnState.Text = "State";
            this.clnState.Width = 141;
            // 
            // cbAutoDiagnosis
            // 
            this.cbAutoDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoDiagnosis.AutoSize = true;
            this.cbAutoDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.cbAutoDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAutoDiagnosis.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoDiagnosis.Location = new System.Drawing.Point(782, 578);
            this.cbAutoDiagnosis.Name = "cbAutoDiagnosis";
            this.cbAutoDiagnosis.Size = new System.Drawing.Size(133, 32);
            this.cbAutoDiagnosis.TabIndex = 149;
            this.cbAutoDiagnosis.Text = "自动应诊断";
            this.cbAutoDiagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAutoDiagnosis.UseVisualStyleBackColor = false;
            this.cbAutoDiagnosis.CheckedChanged += new System.EventHandler(this.cbAutoDiagnosis_CheckedChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::IGT.UI.Client.Properties.Resources.OperatingTime;
            this.pictureBox7.Location = new System.Drawing.Point(358, 449);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(330, 194);
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::IGT.UI.Client.Properties.Resources.PetrolDiagnosis;
            this.pictureBox6.Location = new System.Drawing.Point(13, 308);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(318, 264);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::IGT.UI.Client.Properties.Resources.GasCutout;
            this.pictureBox2.Location = new System.Drawing.Point(13, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 292);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(124)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(573, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 167;
            this.label1.Text = "h.mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(124)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(573, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 167;
            this.label2.Text = "h.mm";
            // 
            // btnResetErrors
            // 
            this.btnResetErrors.BackColor = System.Drawing.Color.Transparent;
            this.btnResetErrors.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnResetErrors.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnResetErrors.ButtonText = "Reset Errors";
            this.btnResetErrors.CornerRadius = 12;
            this.btnResetErrors.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btnResetErrors.ForeColor = System.Drawing.Color.Black;
            this.btnResetErrors.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnResetErrors.Location = new System.Drawing.Point(745, 509);
            this.btnResetErrors.Name = "btnResetErrors";
            this.btnResetErrors.Size = new System.Drawing.Size(160, 43);
            this.btnResetErrors.TabIndex = 168;
            this.btnResetErrors.Click += new System.EventHandler(this.btnResetErrors_Click);
            // 
            // btnOBDErrors
            // 
            this.btnOBDErrors.BackColor = System.Drawing.Color.Transparent;
            this.btnOBDErrors.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnOBDErrors.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnOBDErrors.ButtonText = "OBD Error";
            this.btnOBDErrors.CornerRadius = 12;
            this.btnOBDErrors.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.btnOBDErrors.ForeColor = System.Drawing.Color.Black;
            this.btnOBDErrors.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnOBDErrors.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnOBDErrors.Location = new System.Drawing.Point(860, 509);
            this.btnOBDErrors.Name = "btnOBDErrors";
            this.btnOBDErrors.Size = new System.Drawing.Size(149, 43);
            this.btnOBDErrors.TabIndex = 168;
            this.btnOBDErrors.Visible = false;
            this.btnOBDErrors.Click += new System.EventHandler(this.btnOBDError_Click);
            // 
            // diaLine16
            // 
            this.diaLine16.BackColor = System.Drawing.Color.Transparent;
            this.diaLine16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine16.LeftLabel = "H";
            this.diaLine16.Location = new System.Drawing.Point(36, 532);
            this.diaLine16.MyEnable = false;
            this.diaLine16.Name = "diaLine16";
            this.diaLine16.ON = false;
            this.diaLine16.RightLabel = "0.00";
            this.diaLine16.Size = new System.Drawing.Size(273, 20);
            this.diaLine16.TabIndex = 166;
            // 
            // diaLine15
            // 
            this.diaLine15.BackColor = System.Drawing.Color.Transparent;
            this.diaLine15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine15.LeftLabel = "G";
            this.diaLine15.Location = new System.Drawing.Point(36, 511);
            this.diaLine15.MyEnable = false;
            this.diaLine15.Name = "diaLine15";
            this.diaLine15.ON = false;
            this.diaLine15.RightLabel = "0.00";
            this.diaLine15.Size = new System.Drawing.Size(273, 20);
            this.diaLine15.TabIndex = 165;
            // 
            // diaLine14
            // 
            this.diaLine14.BackColor = System.Drawing.Color.Transparent;
            this.diaLine14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine14.LeftLabel = "F";
            this.diaLine14.Location = new System.Drawing.Point(36, 490);
            this.diaLine14.MyEnable = false;
            this.diaLine14.Name = "diaLine14";
            this.diaLine14.ON = false;
            this.diaLine14.RightLabel = "0.00";
            this.diaLine14.Size = new System.Drawing.Size(273, 20);
            this.diaLine14.TabIndex = 164;
            // 
            // diaLine13
            // 
            this.diaLine13.BackColor = System.Drawing.Color.Transparent;
            this.diaLine13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine13.LeftLabel = "E";
            this.diaLine13.Location = new System.Drawing.Point(36, 469);
            this.diaLine13.MyEnable = false;
            this.diaLine13.Name = "diaLine13";
            this.diaLine13.ON = false;
            this.diaLine13.RightLabel = "0.00";
            this.diaLine13.Size = new System.Drawing.Size(273, 20);
            this.diaLine13.TabIndex = 163;
            // 
            // diaLine12
            // 
            this.diaLine12.BackColor = System.Drawing.Color.Transparent;
            this.diaLine12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine12.LeftLabel = "D";
            this.diaLine12.Location = new System.Drawing.Point(36, 449);
            this.diaLine12.MyEnable = false;
            this.diaLine12.Name = "diaLine12";
            this.diaLine12.ON = false;
            this.diaLine12.RightLabel = "0.00";
            this.diaLine12.Size = new System.Drawing.Size(273, 20);
            this.diaLine12.TabIndex = 162;
            // 
            // diaLine11
            // 
            this.diaLine11.BackColor = System.Drawing.Color.Transparent;
            this.diaLine11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine11.LeftLabel = "C";
            this.diaLine11.Location = new System.Drawing.Point(36, 428);
            this.diaLine11.MyEnable = false;
            this.diaLine11.Name = "diaLine11";
            this.diaLine11.ON = false;
            this.diaLine11.RightLabel = "0.00";
            this.diaLine11.Size = new System.Drawing.Size(273, 20);
            this.diaLine11.TabIndex = 161;
            // 
            // diaLine10
            // 
            this.diaLine10.BackColor = System.Drawing.Color.Transparent;
            this.diaLine10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine10.LeftLabel = "B";
            this.diaLine10.Location = new System.Drawing.Point(36, 407);
            this.diaLine10.MyEnable = false;
            this.diaLine10.Name = "diaLine10";
            this.diaLine10.ON = false;
            this.diaLine10.RightLabel = "0.00";
            this.diaLine10.Size = new System.Drawing.Size(273, 20);
            this.diaLine10.TabIndex = 160;
            // 
            // diaLine9
            // 
            this.diaLine9.BackColor = System.Drawing.Color.Transparent;
            this.diaLine9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine9.LeftLabel = "A";
            this.diaLine9.Location = new System.Drawing.Point(36, 386);
            this.diaLine9.MyEnable = true;
            this.diaLine9.Name = "diaLine9";
            this.diaLine9.ON = false;
            this.diaLine9.RightLabel = "0.00";
            this.diaLine9.Size = new System.Drawing.Size(273, 20);
            this.diaLine9.TabIndex = 159;
            // 
            // diaLine8
            // 
            this.diaLine8.BackColor = System.Drawing.Color.Transparent;
            this.diaLine8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine8.LeftLabel = "H";
            this.diaLine8.Location = new System.Drawing.Point(36, 236);
            this.diaLine8.MyEnable = true;
            this.diaLine8.Name = "diaLine8";
            this.diaLine8.ON = false;
            this.diaLine8.RightLabel = "0.00";
            this.diaLine8.Size = new System.Drawing.Size(273, 20);
            this.diaLine8.TabIndex = 158;
            this.diaLine8.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // diaLine7
            // 
            this.diaLine7.BackColor = System.Drawing.Color.Transparent;
            this.diaLine7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine7.LeftLabel = "G";
            this.diaLine7.Location = new System.Drawing.Point(36, 215);
            this.diaLine7.MyEnable = true;
            this.diaLine7.Name = "diaLine7";
            this.diaLine7.ON = false;
            this.diaLine7.RightLabel = "0.00";
            this.diaLine7.Size = new System.Drawing.Size(273, 20);
            this.diaLine7.TabIndex = 157;
            this.diaLine7.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // diaLine6
            // 
            this.diaLine6.BackColor = System.Drawing.Color.Transparent;
            this.diaLine6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine6.LeftLabel = "F";
            this.diaLine6.Location = new System.Drawing.Point(36, 194);
            this.diaLine6.MyEnable = true;
            this.diaLine6.Name = "diaLine6";
            this.diaLine6.ON = false;
            this.diaLine6.RightLabel = "0.00";
            this.diaLine6.Size = new System.Drawing.Size(273, 20);
            this.diaLine6.TabIndex = 156;
            this.diaLine6.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // diaLine5
            // 
            this.diaLine5.BackColor = System.Drawing.Color.Transparent;
            this.diaLine5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine5.LeftLabel = "E";
            this.diaLine5.Location = new System.Drawing.Point(36, 173);
            this.diaLine5.MyEnable = true;
            this.diaLine5.Name = "diaLine5";
            this.diaLine5.ON = false;
            this.diaLine5.RightLabel = "0.00";
            this.diaLine5.Size = new System.Drawing.Size(273, 20);
            this.diaLine5.TabIndex = 155;
            this.diaLine5.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // diaLine4
            // 
            this.diaLine4.BackColor = System.Drawing.Color.Transparent;
            this.diaLine4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine4.LeftLabel = "D";
            this.diaLine4.Location = new System.Drawing.Point(36, 152);
            this.diaLine4.MyEnable = true;
            this.diaLine4.Name = "diaLine4";
            this.diaLine4.ON = false;
            this.diaLine4.RightLabel = "0.00";
            this.diaLine4.Size = new System.Drawing.Size(273, 20);
            this.diaLine4.TabIndex = 154;
            this.diaLine4.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // diaLine3
            // 
            this.diaLine3.BackColor = System.Drawing.Color.Transparent;
            this.diaLine3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine3.LeftLabel = "C";
            this.diaLine3.Location = new System.Drawing.Point(36, 131);
            this.diaLine3.MyEnable = true;
            this.diaLine3.Name = "diaLine3";
            this.diaLine3.ON = false;
            this.diaLine3.RightLabel = "0.00";
            this.diaLine3.Size = new System.Drawing.Size(273, 20);
            this.diaLine3.TabIndex = 153;
            this.diaLine3.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // diaLine2
            // 
            this.diaLine2.BackColor = System.Drawing.Color.Transparent;
            this.diaLine2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine2.LeftLabel = "B";
            this.diaLine2.Location = new System.Drawing.Point(36, 110);
            this.diaLine2.MyEnable = true;
            this.diaLine2.Name = "diaLine2";
            this.diaLine2.ON = false;
            this.diaLine2.RightLabel = "0.00";
            this.diaLine2.Size = new System.Drawing.Size(273, 20);
            this.diaLine2.TabIndex = 152;
            this.diaLine2.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // diaLine1
            // 
            this.diaLine1.BackColor = System.Drawing.Color.Transparent;
            this.diaLine1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.diaLine1.LeftLabel = "A";
            this.diaLine1.Location = new System.Drawing.Point(36, 89);
            this.diaLine1.MyEnable = true;
            this.diaLine1.Name = "diaLine1";
            this.diaLine1.ON = false;
            this.diaLine1.RightLabel = "0.00";
            this.diaLine1.Size = new System.Drawing.Size(273, 20);
            this.diaLine1.TabIndex = 151;
            this.diaLine1.ClickON_OR_Off += new IGT.UI.Client.UserControls.DiaLine.ClickON_OR_OffHandel(this.diaLine1_ClickON_OR_Off);
            // 
            // Diagnosis
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::IGT.UI.Client.Properties.Resources.background1;
            this.Controls.Add(this.btnResetErrors);
            this.Controls.Add(this.btnOBDErrors);
            this.Controls.Add(this.listvErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diaLine16);
            this.Controls.Add(this.diaLine15);
            this.Controls.Add(this.diaLine14);
            this.Controls.Add(this.diaLine13);
            this.Controls.Add(this.diaLine12);
            this.Controls.Add(this.diaLine11);
            this.Controls.Add(this.diaLine10);
            this.Controls.Add(this.diaLine9);
            this.Controls.Add(this.diaLine8);
            this.Controls.Add(this.diaLine7);
            this.Controls.Add(this.diaLine6);
            this.Controls.Add(this.diaLine5);
            this.Controls.Add(this.diaLine4);
            this.Controls.Add(this.diaLine3);
            this.Controls.Add(this.diaLine2);
            this.Controls.Add(this.diaLine1);
            this.Controls.Add(this.cbAutoDiagnosis);
            this.Controls.Add(this.ddlBank);
            this.Controls.Add(this.labXTip);
            this.Controls.Add(this.labOKTip);
            this.Controls.Add(this.labOpTime);
            this.Controls.Add(this.labGasTitle);
            this.Controls.Add(this.labPetrolTitle);
            this.Controls.Add(this.labRedTime);
            this.Controls.Add(this.labGasTime);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Diagnosis";
            this.Size = new System.Drawing.Size(1023, 656);
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label labXTip;
        private System.Windows.Forms.Label labOKTip;
        private System.Windows.Forms.Label labOpTime;
        private System.Windows.Forms.Label labGasTitle;
        private System.Windows.Forms.Label labPetrolTitle;
        private System.Windows.Forms.Label labRedTime;
        private System.Windows.Forms.Label labGasTime;
        private System.Windows.Forms.ComboBox ddlBank;
        private System.Windows.Forms.ListView listvErrors;
        private System.Windows.Forms.ColumnHeader clnDiagnosis;
        private System.Windows.Forms.ColumnHeader clnState;
        private System.Windows.Forms.CheckBox cbAutoDiagnosis;
        private UserControls.DiaLine diaLine1;
        private UserControls.DiaLine diaLine2;
        private UserControls.DiaLine diaLine3;
        private UserControls.DiaLine diaLine4;
        private UserControls.DiaLine diaLine5;
        private UserControls.DiaLine diaLine6;
        private UserControls.DiaLine diaLine7;
        private UserControls.DiaLine diaLine8;
        private UserControls.DiaLine diaLine9;
        private UserControls.DiaLine diaLine10;
        private UserControls.DiaLine diaLine11;
        private UserControls.DiaLine diaLine12;
        private UserControls.DiaLine diaLine13;
        private UserControls.DiaLine diaLine14;
        private UserControls.DiaLine diaLine15;
        private UserControls.DiaLine diaLine16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private VistaButton btnResetErrors;
        private VistaButton btnOBDErrors;
        private System.Windows.Forms.ColumnHeader clnErr;

    }
}
