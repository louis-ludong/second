namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class MAPCalibrationSettingPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtForHeaderCell = new System.Windows.Forms.TextBox();
            this.cMenuBatchEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditByValue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditByPercentage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditByLinear = new System.Windows.Forms.ToolStripMenuItem();
            this.tBarSpeedThicken = new System.Windows.Forms.TrackBar();
            this.numuIdentTime = new System.Windows.Forms.NumericUpDown();
            this.numuSen = new System.Windows.Forms.NumericUpDown();
            this.labIdentTime = new System.Windows.Forms.Label();
            this.cbExtraSen = new System.Windows.Forms.CheckBox();
            this.cbExtraCutting = new System.Windows.Forms.CheckBox();
            this.tBarSen = new System.Windows.Forms.TrackBar();
            this.numuWeak = new System.Windows.Forms.NumericUpDown();
            this.labWeak = new System.Windows.Forms.Label();
            this.labSpeedThicken = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButMapRef = new IGT.UI.Client.VistaButton();
            this.vistaButton1 = new IGT.UI.Client.VistaButton();
            this.cMenuBatchEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSpeedThicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuIdentTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuSen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuWeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtForHeaderCell
            // 
            this.txtForHeaderCell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForHeaderCell.Location = new System.Drawing.Point(652, 346);
            this.txtForHeaderCell.Name = "txtForHeaderCell";
            this.txtForHeaderCell.Size = new System.Drawing.Size(84, 14);
            this.txtForHeaderCell.TabIndex = 40;
            this.txtForHeaderCell.Visible = false;
            // 
            // cMenuBatchEdit
            // 
            this.cMenuBatchEdit.BackColor = System.Drawing.Color.Gold;
            this.cMenuBatchEdit.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cMenuBatchEdit.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cMenuBatchEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditByValue,
            this.tsmiEditByPercentage,
            this.tsmiEditByLinear});
            this.cMenuBatchEdit.Name = "cMenuBatchEdit";
            this.cMenuBatchEdit.Size = new System.Drawing.Size(230, 70);
            this.cMenuBatchEdit.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuBatchEdit_Opening);
            // 
            // tsmiEditByValue
            // 
            this.tsmiEditByValue.Name = "tsmiEditByValue";
            this.tsmiEditByValue.Size = new System.Drawing.Size(229, 22);
            this.tsmiEditByValue.Text = "按值批量编辑";
            // 
            // tsmiEditByPercentage
            // 
            this.tsmiEditByPercentage.Name = "tsmiEditByPercentage";
            this.tsmiEditByPercentage.Size = new System.Drawing.Size(229, 22);
            this.tsmiEditByPercentage.Text = "按百分比修改";
            // 
            // tsmiEditByLinear
            // 
            this.tsmiEditByLinear.Name = "tsmiEditByLinear";
            this.tsmiEditByLinear.Size = new System.Drawing.Size(229, 22);
            this.tsmiEditByLinear.Text = "按线性比例批量调整";
            // 
            // tBarSpeedThicken
            // 
            this.tBarSpeedThicken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBarSpeedThicken.LargeChange = 1;
            this.tBarSpeedThicken.Location = new System.Drawing.Point(337, 385);
            this.tBarSpeedThicken.Maximum = 20;
            this.tBarSpeedThicken.Name = "tBarSpeedThicken";
            this.tBarSpeedThicken.Size = new System.Drawing.Size(133, 45);
            this.tBarSpeedThicken.TabIndex = 68;
            this.tBarSpeedThicken.Scroll += new System.EventHandler(this.trackBarSen_Scroll);
            // 
            // numuIdentTime
            // 
            this.numuIdentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuIdentTime.DecimalPlaces = 1;
            this.numuIdentTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuIdentTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuIdentTime.Location = new System.Drawing.Point(164, 457);
            this.numuIdentTime.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numuIdentTime.Name = "numuIdentTime";
            this.numuIdentTime.ReadOnly = true;
            this.numuIdentTime.Size = new System.Drawing.Size(62, 33);
            this.numuIdentTime.TabIndex = 55;
            this.numuIdentTime.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // numuSen
            // 
            this.numuSen.DecimalPlaces = 1;
            this.numuSen.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuSen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuSen.Location = new System.Drawing.Point(12, 425);
            this.numuSen.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            65536});
            this.numuSen.Name = "numuSen";
            this.numuSen.ReadOnly = true;
            this.numuSen.Size = new System.Drawing.Size(104, 33);
            this.numuSen.TabIndex = 53;
            this.numuSen.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labIdentTime
            // 
            this.labIdentTime.AutoSize = true;
            this.labIdentTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labIdentTime.Location = new System.Drawing.Point(7, 463);
            this.labIdentTime.Name = "labIdentTime";
            this.labIdentTime.Size = new System.Drawing.Size(164, 25);
            this.labIdentTime.TabIndex = 53;
            this.labIdentTime.Text = "额外喷射起始时间";
            // 
            // cbExtraSen
            // 
            this.cbExtraSen.AutoSize = true;
            this.cbExtraSen.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbExtraSen.Location = new System.Drawing.Point(12, 391);
            this.cbExtraSen.Name = "cbExtraSen";
            this.cbExtraSen.Size = new System.Drawing.Size(199, 29);
            this.cbExtraSen.TabIndex = 54;
            this.cbExtraSen.Text = "Extrainj. sensitivity";
            this.cbExtraSen.UseVisualStyleBackColor = true;
            this.cbExtraSen.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // cbExtraCutting
            // 
            this.cbExtraCutting.AutoSize = true;
            this.cbExtraCutting.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbExtraCutting.Location = new System.Drawing.Point(12, 357);
            this.cbExtraCutting.Name = "cbExtraCutting";
            this.cbExtraCutting.Size = new System.Drawing.Size(234, 29);
            this.cbExtraCutting.TabIndex = 53;
            this.cbExtraCutting.Text = "Extra-injection cutting";
            this.cbExtraCutting.UseVisualStyleBackColor = true;
            this.cbExtraCutting.CheckedChanged += new System.EventHandler(this.cb_Checked);
            // 
            // tBarSen
            // 
            this.tBarSen.BackColor = System.Drawing.Color.White;
            this.tBarSen.LargeChange = 1;
            this.tBarSen.Location = new System.Drawing.Point(122, 425);
            this.tBarSen.Maximum = 36;
            this.tBarSen.Name = "tBarSen";
            this.tBarSen.Size = new System.Drawing.Size(104, 45);
            this.tBarSen.TabIndex = 51;
            this.tBarSen.Scroll += new System.EventHandler(this.trackBarSen_Scroll);
            // 
            // numuWeak
            // 
            this.numuWeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numuWeak.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuWeak.Location = new System.Drawing.Point(631, 391);
            this.numuWeak.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numuWeak.Name = "numuWeak";
            this.numuWeak.ReadOnly = true;
            this.numuWeak.Size = new System.Drawing.Size(60, 33);
            this.numuWeak.TabIndex = 71;
            this.numuWeak.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // labWeak
            // 
            this.labWeak.AutoSize = true;
            this.labWeak.BackColor = System.Drawing.Color.Transparent;
            this.labWeak.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWeak.Location = new System.Drawing.Point(552, 358);
            this.labWeak.Name = "labWeak";
            this.labWeak.Size = new System.Drawing.Size(117, 28);
            this.labWeak.TabIndex = 70;
            this.labWeak.Text = "马自达减弱";
            // 
            // labSpeedThicken
            // 
            this.labSpeedThicken.AutoSize = true;
            this.labSpeedThicken.BackColor = System.Drawing.Color.Transparent;
            this.labSpeedThicken.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSpeedThicken.Location = new System.Drawing.Point(278, 358);
            this.labSpeedThicken.Name = "labSpeedThicken";
            this.labSpeedThicken.Size = new System.Drawing.Size(96, 28);
            this.labSpeedThicken.TabIndex = 69;
            this.labSpeedThicken.Text = "加速加浓";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(475, 435);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(336, 67);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "\"OBS.:A sensibilidade de injeção e injeção extra,\"+ Environment.NewLine+\"são rese" +
    "rentes à injeção de combustível líquido,\"+ Environment.NewLine+\"podendo causar f" +
    "alhas ou\"trancos\" no veículo.\"";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToResizeColumns = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.kryptonDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridView1.ColumnHeadersHeight = 35;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.kryptonDataGridView1.ContextMenuStrip = this.cMenuBatchEdit;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonDataGridView1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.kryptonDataGridView1.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.kryptonDataGridView1.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView1.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView1.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonDataGridView1.RowHeadersWidth = 75;
            this.kryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.kryptonDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.kryptonDataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.kryptonDataGridView1.RowTemplate.Height = 40;
            this.kryptonDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.kryptonDataGridView1.ShowEditingIcon = false;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(810, 355);
            this.kryptonDataGridView1.StandardTab = true;
            this.kryptonDataGridView1.TabIndex = 41;
            this.kryptonDataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.kryptonDataGridView1_CellStateChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IGT.UI.Client.Properties.Resources.未标题_1;
            this.pictureBox1.Location = new System.Drawing.Point(418, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // ButMapRef
            // 
            this.ButMapRef.BackColor = System.Drawing.Color.Transparent;
            this.ButMapRef.BaseColor = System.Drawing.Color.White;
            this.ButMapRef.ButtonColor = System.Drawing.Color.White;
            this.ButMapRef.ButtonText = "Reajuste do Mapa";
            this.ButMapRef.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButMapRef.ForeColor = System.Drawing.Color.Black;
            this.ButMapRef.HighlightColor = System.Drawing.Color.Gray;
            this.ButMapRef.Location = new System.Drawing.Point(245, 420);
            this.ButMapRef.Name = "ButMapRef";
            this.ButMapRef.Size = new System.Drawing.Size(164, 38);
            this.ButMapRef.TabIndex = 75;
            this.ButMapRef.Click += new System.EventHandler(this.ButMapRef_Click);
            // 
            // vistaButton1
            // 
            this.vistaButton1.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton1.BaseColor = System.Drawing.Color.White;
            this.vistaButton1.ButtonColor = System.Drawing.Color.White;
            this.vistaButton1.ButtonText = "Map reset";
            this.vistaButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vistaButton1.ForeColor = System.Drawing.Color.Black;
            this.vistaButton1.HighlightColor = System.Drawing.Color.Gray;
            this.vistaButton1.Location = new System.Drawing.Point(245, 463);
            this.vistaButton1.Name = "vistaButton1";
            this.vistaButton1.Size = new System.Drawing.Size(164, 38);
            this.vistaButton1.TabIndex = 75;
            this.vistaButton1.Click += new System.EventHandler(this.vistaButton1_Click);
            // 
            // MAPCalibrationSettingPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButMapRef);
            this.Controls.Add(this.vistaButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numuWeak);
            this.Controls.Add(this.numuIdentTime);
            this.Controls.Add(this.numuSen);
            this.Controls.Add(this.labIdentTime);
            this.Controls.Add(this.cbExtraSen);
            this.Controls.Add(this.cbExtraCutting);
            this.Controls.Add(this.tBarSen);
            this.Controls.Add(this.labSpeedThicken);
            this.Controls.Add(this.txtForHeaderCell);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.tBarSpeedThicken);
            this.Controls.Add(this.labWeak);
            this.DoubleBuffered = true;
            this.Name = "MAPCalibrationSettingPanel";
            this.Size = new System.Drawing.Size(810, 510);
            this.Load += new System.EventHandler(this.MAPCalibrationSettingPanel_Load);
            this.cMenuBatchEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBarSpeedThicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuIdentTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuSen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuWeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForHeaderCell;
        private System.Windows.Forms.ContextMenuStrip cMenuBatchEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditByValue;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditByPercentage;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditByLinear;
        private System.Windows.Forms.TrackBar tBarSpeedThicken;
        private System.Windows.Forms.NumericUpDown numuIdentTime;
        private System.Windows.Forms.NumericUpDown numuSen;
        private System.Windows.Forms.Label labIdentTime;
        private System.Windows.Forms.CheckBox cbExtraSen;
        private System.Windows.Forms.CheckBox cbExtraCutting;
        private System.Windows.Forms.TrackBar tBarSen;
        private System.Windows.Forms.NumericUpDown numuWeak;
        private System.Windows.Forms.Label labWeak;
        private System.Windows.Forms.Label labSpeedThicken;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private VistaButton vistaButton1;
        private VistaButton ButMapRef;
    }
}
