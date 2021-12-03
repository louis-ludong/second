namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class AdvancedSettingPanel
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
            this.gboxODB = new System.Windows.Forms.GroupBox();
            this.numuODBBank1Correct = new System.Windows.Forms.NumericUpDown();
            this.ddlOBDClear = new System.Windows.Forms.ComboBox();
            this.labOBDClear = new System.Windows.Forms.Label();
            this.cbODBReverseAssist = new System.Windows.Forms.CheckBox();
            this.cbODBOpen = new System.Windows.Forms.CheckBox();
            this.numuODBBank2Correct = new System.Windows.Forms.NumericUpDown();
            this.labODBBank2Correct = new System.Windows.Forms.Label();
            this.labODBBank1Correct = new System.Windows.Forms.Label();
            this.numuODBAdaptRange = new System.Windows.Forms.NumericUpDown();
            this.labODBAdaptRange = new System.Windows.Forms.Label();
            this.gboxadp = new System.Windows.Forms.GroupBox();
            this.cbAutoStopAdaptive = new System.Windows.Forms.CheckBox();
            this.numuAdaptiveRange = new System.Windows.Forms.NumericUpDown();
            this.labAdaptiveRange = new System.Windows.Forms.Label();
            this.cbAdaptiveAssist = new System.Windows.Forms.CheckBox();
            this.cbAutoAdaptive = new System.Windows.Forms.CheckBox();
            this.gboxMaintainRemind = new System.Windows.Forms.GroupBox();
            this.btnMREnter = new IGT.UI.Client.VistaButton();
            this.labMRNextTime = new System.Windows.Forms.Label();
            this.ddlMRKM = new System.Windows.Forms.ComboBox();
            this.labMRType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlMRType = new System.Windows.Forms.ComboBox();
            this.txtMRKM = new System.Windows.Forms.TextBox();
            this.labMRTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labMRTime = new System.Windows.Forms.Label();
            this.gboxODB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuODBBank1Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuODBBank2Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuODBAdaptRange)).BeginInit();
            this.gboxadp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuAdaptiveRange)).BeginInit();
            this.gboxMaintainRemind.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxODB
            // 
            this.gboxODB.BackColor = System.Drawing.Color.Transparent;
            this.gboxODB.Controls.Add(this.numuODBBank1Correct);
            this.gboxODB.Controls.Add(this.ddlOBDClear);
            this.gboxODB.Controls.Add(this.labOBDClear);
            this.gboxODB.Controls.Add(this.cbODBReverseAssist);
            this.gboxODB.Controls.Add(this.cbODBOpen);
            this.gboxODB.Controls.Add(this.numuODBBank2Correct);
            this.gboxODB.Controls.Add(this.labODBBank2Correct);
            this.gboxODB.Controls.Add(this.labODBBank1Correct);
            this.gboxODB.Controls.Add(this.numuODBAdaptRange);
            this.gboxODB.Controls.Add(this.labODBAdaptRange);
            this.gboxODB.Location = new System.Drawing.Point(3, 187);
            this.gboxODB.Name = "gboxODB";
            this.gboxODB.Size = new System.Drawing.Size(803, 178);
            this.gboxODB.TabIndex = 0;
            this.gboxODB.TabStop = false;
            this.gboxODB.Text = "ODB相关";
            // 
            // numuODBBank1Correct
            // 
            this.numuODBBank1Correct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuODBBank1Correct.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuODBBank1Correct.Location = new System.Drawing.Point(248, 134);
            this.numuODBBank1Correct.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numuODBBank1Correct.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.numuODBBank1Correct.Name = "numuODBBank1Correct";
            this.numuODBBank1Correct.ReadOnly = true;
            this.numuODBBank1Correct.Size = new System.Drawing.Size(157, 33);
            this.numuODBBank1Correct.TabIndex = 60;
            this.numuODBBank1Correct.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // ddlOBDClear
            // 
            this.ddlOBDClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlOBDClear.BackColor = System.Drawing.Color.White;
            this.ddlOBDClear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOBDClear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlOBDClear.FormattingEnabled = true;
            this.ddlOBDClear.Location = new System.Drawing.Point(248, 95);
            this.ddlOBDClear.Name = "ddlOBDClear";
            this.ddlOBDClear.Size = new System.Drawing.Size(157, 33);
            this.ddlOBDClear.TabIndex = 66;
            this.ddlOBDClear.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // labOBDClear
            // 
            this.labOBDClear.AutoSize = true;
            this.labOBDClear.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOBDClear.Location = new System.Drawing.Point(3, 63);
            this.labOBDClear.Name = "labOBDClear";
            this.labOBDClear.Size = new System.Drawing.Size(159, 28);
            this.labOBDClear.TabIndex = 65;
            this.labOBDClear.Text = "故障码自动消除";
            // 
            // cbODBReverseAssist
            // 
            this.cbODBReverseAssist.AutoSize = true;
            this.cbODBReverseAssist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbODBReverseAssist.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbODBReverseAssist.Location = new System.Drawing.Point(404, 20);
            this.cbODBReverseAssist.Name = "cbODBReverseAssist";
            this.cbODBReverseAssist.Size = new System.Drawing.Size(161, 32);
            this.cbODBReverseAssist.TabIndex = 64;
            this.cbODBReverseAssist.Text = "ODB反向修正";
            this.cbODBReverseAssist.UseVisualStyleBackColor = true;
            this.cbODBReverseAssist.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // cbODBOpen
            // 
            this.cbODBOpen.AutoSize = true;
            this.cbODBOpen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbODBOpen.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbODBOpen.Location = new System.Drawing.Point(3, 20);
            this.cbODBOpen.Name = "cbODBOpen";
            this.cbODBOpen.Size = new System.Drawing.Size(140, 32);
            this.cbODBOpen.TabIndex = 63;
            this.cbODBOpen.Text = "ODB自适应";
            this.cbODBOpen.UseVisualStyleBackColor = true;
            this.cbODBOpen.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // numuODBBank2Correct
            // 
            this.numuODBBank2Correct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuODBBank2Correct.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuODBBank2Correct.Location = new System.Drawing.Point(637, 134);
            this.numuODBBank2Correct.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numuODBBank2Correct.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.numuODBBank2Correct.Name = "numuODBBank2Correct";
            this.numuODBBank2Correct.ReadOnly = true;
            this.numuODBBank2Correct.Size = new System.Drawing.Size(157, 33);
            this.numuODBBank2Correct.TabIndex = 62;
            this.numuODBBank2Correct.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labODBBank2Correct
            // 
            this.labODBBank2Correct.AutoSize = true;
            this.labODBBank2Correct.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labODBBank2Correct.Location = new System.Drawing.Point(405, 134);
            this.labODBBank2Correct.Name = "labODBBank2Correct";
            this.labODBBank2Correct.Size = new System.Drawing.Size(173, 28);
            this.labODBBank2Correct.TabIndex = 61;
            this.labODBBank2Correct.Text = "ODB Bank2 矫正";
            // 
            // labODBBank1Correct
            // 
            this.labODBBank1Correct.AutoSize = true;
            this.labODBBank1Correct.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labODBBank1Correct.Location = new System.Drawing.Point(3, 134);
            this.labODBBank1Correct.Name = "labODBBank1Correct";
            this.labODBBank1Correct.Size = new System.Drawing.Size(173, 28);
            this.labODBBank1Correct.TabIndex = 59;
            this.labODBBank1Correct.Text = "ODB Bank1 矫正";
            // 
            // numuODBAdaptRange
            // 
            this.numuODBAdaptRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuODBAdaptRange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuODBAdaptRange.Location = new System.Drawing.Point(637, 95);
            this.numuODBAdaptRange.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numuODBAdaptRange.Name = "numuODBAdaptRange";
            this.numuODBAdaptRange.ReadOnly = true;
            this.numuODBAdaptRange.Size = new System.Drawing.Size(157, 33);
            this.numuODBAdaptRange.TabIndex = 58;
            this.numuODBAdaptRange.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labODBAdaptRange
            // 
            this.labODBAdaptRange.AutoSize = true;
            this.labODBAdaptRange.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labODBAdaptRange.Location = new System.Drawing.Point(405, 55);
            this.labODBAdaptRange.Name = "labODBAdaptRange";
            this.labODBAdaptRange.Size = new System.Drawing.Size(142, 28);
            this.labODBAdaptRange.TabIndex = 57;
            this.labODBAdaptRange.Text = "ODB适应范围";
            // 
            // gboxadp
            // 
            this.gboxadp.BackColor = System.Drawing.Color.Transparent;
            this.gboxadp.Controls.Add(this.cbAutoStopAdaptive);
            this.gboxadp.Controls.Add(this.numuAdaptiveRange);
            this.gboxadp.Controls.Add(this.labAdaptiveRange);
            this.gboxadp.Controls.Add(this.cbAdaptiveAssist);
            this.gboxadp.Controls.Add(this.cbAutoAdaptive);
            this.gboxadp.Location = new System.Drawing.Point(3, 13);
            this.gboxadp.Name = "gboxadp";
            this.gboxadp.Size = new System.Drawing.Size(803, 168);
            this.gboxadp.TabIndex = 63;
            this.gboxadp.TabStop = false;
            this.gboxadp.Text = "自适应相关";
            // 
            // cbAutoStopAdaptive
            // 
            this.cbAutoStopAdaptive.AutoSize = true;
            this.cbAutoStopAdaptive.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoStopAdaptive.Location = new System.Drawing.Point(11, 96);
            this.cbAutoStopAdaptive.Name = "cbAutoStopAdaptive";
            this.cbAutoStopAdaptive.Size = new System.Drawing.Size(115, 32);
            this.cbAutoStopAdaptive.TabIndex = 63;
            this.cbAutoStopAdaptive.Text = "自动停止";
            this.cbAutoStopAdaptive.UseVisualStyleBackColor = true;
            this.cbAutoStopAdaptive.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // numuAdaptiveRange
            // 
            this.numuAdaptiveRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuAdaptiveRange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuAdaptiveRange.Location = new System.Drawing.Point(248, 129);
            this.numuAdaptiveRange.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numuAdaptiveRange.Name = "numuAdaptiveRange";
            this.numuAdaptiveRange.ReadOnly = true;
            this.numuAdaptiveRange.Size = new System.Drawing.Size(133, 33);
            this.numuAdaptiveRange.TabIndex = 58;
            this.numuAdaptiveRange.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labAdaptiveRange
            // 
            this.labAdaptiveRange.AutoSize = true;
            this.labAdaptiveRange.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAdaptiveRange.Location = new System.Drawing.Point(9, 131);
            this.labAdaptiveRange.Name = "labAdaptiveRange";
            this.labAdaptiveRange.Size = new System.Drawing.Size(117, 28);
            this.labAdaptiveRange.TabIndex = 57;
            this.labAdaptiveRange.Text = "自适应范围";
            // 
            // cbAdaptiveAssist
            // 
            this.cbAdaptiveAssist.AutoSize = true;
            this.cbAdaptiveAssist.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAdaptiveAssist.Location = new System.Drawing.Point(11, 58);
            this.cbAdaptiveAssist.Name = "cbAdaptiveAssist";
            this.cbAdaptiveAssist.Size = new System.Drawing.Size(136, 32);
            this.cbAdaptiveAssist.TabIndex = 56;
            this.cbAdaptiveAssist.Text = "自适应协助";
            this.cbAdaptiveAssist.UseVisualStyleBackColor = true;
            this.cbAdaptiveAssist.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // cbAutoAdaptive
            // 
            this.cbAutoAdaptive.AutoSize = true;
            this.cbAutoAdaptive.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoAdaptive.Location = new System.Drawing.Point(11, 20);
            this.cbAutoAdaptive.Name = "cbAutoAdaptive";
            this.cbAutoAdaptive.Size = new System.Drawing.Size(136, 32);
            this.cbAutoAdaptive.TabIndex = 55;
            this.cbAutoAdaptive.Text = "自动自适应";
            this.cbAutoAdaptive.UseVisualStyleBackColor = true;
            this.cbAutoAdaptive.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // gboxMaintainRemind
            // 
            this.gboxMaintainRemind.BackColor = System.Drawing.Color.Transparent;
            this.gboxMaintainRemind.Controls.Add(this.btnMREnter);
            this.gboxMaintainRemind.Controls.Add(this.labMRNextTime);
            this.gboxMaintainRemind.Controls.Add(this.ddlMRKM);
            this.gboxMaintainRemind.Controls.Add(this.labMRType);
            this.gboxMaintainRemind.Controls.Add(this.label4);
            this.gboxMaintainRemind.Controls.Add(this.ddlMRType);
            this.gboxMaintainRemind.Controls.Add(this.txtMRKM);
            this.gboxMaintainRemind.Controls.Add(this.labMRTimeLabel);
            this.gboxMaintainRemind.Controls.Add(this.label5);
            this.gboxMaintainRemind.Controls.Add(this.labMRTime);
            this.gboxMaintainRemind.Location = new System.Drawing.Point(3, 371);
            this.gboxMaintainRemind.Name = "gboxMaintainRemind";
            this.gboxMaintainRemind.Size = new System.Drawing.Size(803, 167);
            this.gboxMaintainRemind.TabIndex = 70;
            this.gboxMaintainRemind.TabStop = false;
            this.gboxMaintainRemind.Text = " ";
            // 
            // btnMREnter
            // 
            this.btnMREnter.BackColor = System.Drawing.Color.Transparent;
            this.btnMREnter.BaseColor = System.Drawing.Color.White;
            this.btnMREnter.ButtonColor = System.Drawing.Color.White;
            this.btnMREnter.ButtonText = "设定";
            this.btnMREnter.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMREnter.ForeColor = System.Drawing.Color.Black;
            this.btnMREnter.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.btnMREnter.Location = new System.Drawing.Point(558, 44);
            this.btnMREnter.Name = "btnMREnter";
            this.btnMREnter.Size = new System.Drawing.Size(212, 77);
            this.btnMREnter.TabIndex = 65;
            this.btnMREnter.Click += new System.EventHandler(this.btn_Click);
            // 
            // labMRNextTime
            // 
            this.labMRNextTime.AutoSize = true;
            this.labMRNextTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMRNextTime.Location = new System.Drawing.Point(9, 76);
            this.labMRNextTime.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labMRNextTime.Name = "labMRNextTime";
            this.labMRNextTime.Size = new System.Drawing.Size(88, 25);
            this.labMRNextTime.TabIndex = 60;
            this.labMRNextTime.Text = "下次保养";
            // 
            // ddlMRKM
            // 
            this.ddlMRKM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ddlMRKM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlMRKM.FormattingEnabled = true;
            this.ddlMRKM.Location = new System.Drawing.Point(159, 81);
            this.ddlMRKM.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ddlMRKM.Name = "ddlMRKM";
            this.ddlMRKM.Size = new System.Drawing.Size(121, 20);
            this.ddlMRKM.TabIndex = 61;
            // 
            // labMRType
            // 
            this.labMRType.AutoSize = true;
            this.labMRType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMRType.Location = new System.Drawing.Point(6, 20);
            this.labMRType.Name = "labMRType";
            this.labMRType.Size = new System.Drawing.Size(88, 25);
            this.labMRType.TabIndex = 59;
            this.labMRType.Text = "保养类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(297, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "km    1h = ";
            // 
            // ddlMRType
            // 
            this.ddlMRType.BackColor = System.Drawing.Color.White;
            this.ddlMRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMRType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlMRType.FormattingEnabled = true;
            this.ddlMRType.Location = new System.Drawing.Point(248, 17);
            this.ddlMRType.Name = "ddlMRType";
            this.ddlMRType.Size = new System.Drawing.Size(157, 33);
            this.ddlMRType.TabIndex = 58;
            this.ddlMRType.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // txtMRKM
            // 
            this.txtMRKM.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMRKM.Location = new System.Drawing.Point(398, 81);
            this.txtMRKM.Name = "txtMRKM";
            this.txtMRKM.Size = new System.Drawing.Size(40, 29);
            this.txtMRKM.TabIndex = 63;
            this.txtMRKM.Text = "50";
            // 
            // labMRTimeLabel
            // 
            this.labMRTimeLabel.AutoSize = true;
            this.labMRTimeLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMRTimeLabel.ForeColor = System.Drawing.Color.Green;
            this.labMRTimeLabel.Location = new System.Drawing.Point(6, 124);
            this.labMRTimeLabel.Name = "labMRTimeLabel";
            this.labMRTimeLabel.Size = new System.Drawing.Size(88, 25);
            this.labMRTimeLabel.TabIndex = 57;
            this.labMRTimeLabel.Text = "保养时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(458, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "km";
            // 
            // labMRTime
            // 
            this.labMRTime.AutoSize = true;
            this.labMRTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMRTime.ForeColor = System.Drawing.Color.Green;
            this.labMRTime.Location = new System.Drawing.Point(302, 129);
            this.labMRTime.Name = "labMRTime";
            this.labMRTime.Size = new System.Drawing.Size(23, 25);
            this.labMRTime.TabIndex = 53;
            this.labMRTime.Text = "0";
            // 
            // AdvancedSettingPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gboxMaintainRemind);
            this.Controls.Add(this.gboxadp);
            this.Controls.Add(this.gboxODB);
            this.DoubleBuffered = true;
            this.Name = "AdvancedSettingPanel";
            this.Size = new System.Drawing.Size(820, 541);
            this.Load += new System.EventHandler(this.AdvancedSettingPanel_Load);
            this.gboxODB.ResumeLayout(false);
            this.gboxODB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuODBBank1Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuODBBank2Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuODBAdaptRange)).EndInit();
            this.gboxadp.ResumeLayout(false);
            this.gboxadp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuAdaptiveRange)).EndInit();
            this.gboxMaintainRemind.ResumeLayout(false);
            this.gboxMaintainRemind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxODB;
        private System.Windows.Forms.NumericUpDown numuODBBank2Correct;
        private System.Windows.Forms.Label labODBBank2Correct;
        private System.Windows.Forms.NumericUpDown numuODBBank1Correct;
        private System.Windows.Forms.Label labODBBank1Correct;
        private System.Windows.Forms.NumericUpDown numuODBAdaptRange;
        private System.Windows.Forms.Label labODBAdaptRange;
        private System.Windows.Forms.GroupBox gboxadp;
        private System.Windows.Forms.NumericUpDown numuAdaptiveRange;
        private System.Windows.Forms.Label labAdaptiveRange;
        private System.Windows.Forms.CheckBox cbAdaptiveAssist;
        private System.Windows.Forms.CheckBox cbAutoAdaptive;
        private System.Windows.Forms.CheckBox cbAutoStopAdaptive;
        private System.Windows.Forms.CheckBox cbODBReverseAssist;
        private System.Windows.Forms.CheckBox cbODBOpen;
        private System.Windows.Forms.Label labOBDClear;
        private System.Windows.Forms.ComboBox ddlOBDClear;
        private System.Windows.Forms.GroupBox gboxMaintainRemind;
        private System.Windows.Forms.Label labMRNextTime;
        private System.Windows.Forms.ComboBox ddlMRKM;
        private System.Windows.Forms.Label labMRType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlMRType;
        private System.Windows.Forms.TextBox txtMRKM;
        private System.Windows.Forms.Label labMRTimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labMRTime;
        private VistaButton btnMREnter;
    }
}
