namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class SensorsSettingsPanel
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
            this.numuLV4 = new System.Windows.Forms.NumericUpDown();
            this.numuLV3 = new System.Windows.Forms.NumericUpDown();
            this.numuLV2 = new System.Windows.Forms.NumericUpDown();
            this.numuLV1 = new System.Windows.Forms.NumericUpDown();
            this.ddlLevelIndicatorSens = new System.Windows.Forms.ComboBox();
            this.ddlGasTempSens = new System.Windows.Forms.ComboBox();
            this.ddlReducerTempSens = new System.Windows.Forms.ComboBox();
            this.labLevelIndicatorSens = new System.Windows.Forms.Label();
            this.labGasTempSens = new System.Windows.Forms.Label();
            this.labReducerTempSens = new System.Windows.Forms.Label();
            this.ddlLambda1Type = new System.Windows.Forms.ComboBox();
            this.labLambdaType = new System.Windows.Forms.Label();
            this.labLambda1Type = new System.Windows.Forms.Label();
            this.ddlLambda2Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LambdaNum = new System.Windows.Forms.Label();
            this.ddlO2Number = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlO2Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numuLV4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuLV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuLV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuLV1)).BeginInit();
            this.SuspendLayout();
            // 
            // numuLV4
            // 
            this.numuLV4.DecimalPlaces = 1;
            this.numuLV4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuLV4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuLV4.Location = new System.Drawing.Point(342, 159);
            this.numuLV4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numuLV4.Name = "numuLV4";
            this.numuLV4.ReadOnly = true;
            this.numuLV4.Size = new System.Drawing.Size(48, 33);
            this.numuLV4.TabIndex = 46;
            this.numuLV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numuLV4.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // numuLV3
            // 
            this.numuLV3.DecimalPlaces = 1;
            this.numuLV3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuLV3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuLV3.Location = new System.Drawing.Point(242, 159);
            this.numuLV3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numuLV3.Name = "numuLV3";
            this.numuLV3.ReadOnly = true;
            this.numuLV3.Size = new System.Drawing.Size(48, 33);
            this.numuLV3.TabIndex = 45;
            this.numuLV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numuLV3.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // numuLV2
            // 
            this.numuLV2.DecimalPlaces = 1;
            this.numuLV2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuLV2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuLV2.Location = new System.Drawing.Point(142, 159);
            this.numuLV2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numuLV2.Name = "numuLV2";
            this.numuLV2.ReadOnly = true;
            this.numuLV2.Size = new System.Drawing.Size(48, 33);
            this.numuLV2.TabIndex = 44;
            this.numuLV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numuLV2.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // numuLV1
            // 
            this.numuLV1.DecimalPlaces = 1;
            this.numuLV1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numuLV1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numuLV1.Location = new System.Drawing.Point(42, 159);
            this.numuLV1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numuLV1.Name = "numuLV1";
            this.numuLV1.ReadOnly = true;
            this.numuLV1.Size = new System.Drawing.Size(48, 33);
            this.numuLV1.TabIndex = 43;
            this.numuLV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numuLV1.ValueChanged += new System.EventHandler(this.numu_ValueChanged);
            // 
            // ddlLevelIndicatorSens
            // 
            this.ddlLevelIndicatorSens.BackColor = System.Drawing.Color.White;
            this.ddlLevelIndicatorSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLevelIndicatorSens.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlLevelIndicatorSens.FormattingEnabled = true;
            this.ddlLevelIndicatorSens.Location = new System.Drawing.Point(344, 112);
            this.ddlLevelIndicatorSens.Name = "ddlLevelIndicatorSens";
            this.ddlLevelIndicatorSens.Size = new System.Drawing.Size(205, 33);
            this.ddlLevelIndicatorSens.TabIndex = 42;
            this.ddlLevelIndicatorSens.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // ddlGasTempSens
            // 
            this.ddlGasTempSens.BackColor = System.Drawing.Color.White;
            this.ddlGasTempSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGasTempSens.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlGasTempSens.FormattingEnabled = true;
            this.ddlGasTempSens.Location = new System.Drawing.Point(344, 66);
            this.ddlGasTempSens.Name = "ddlGasTempSens";
            this.ddlGasTempSens.Size = new System.Drawing.Size(205, 33);
            this.ddlGasTempSens.TabIndex = 41;
            this.ddlGasTempSens.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // ddlReducerTempSens
            // 
            this.ddlReducerTempSens.BackColor = System.Drawing.Color.White;
            this.ddlReducerTempSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlReducerTempSens.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlReducerTempSens.FormattingEnabled = true;
            this.ddlReducerTempSens.Location = new System.Drawing.Point(344, 20);
            this.ddlReducerTempSens.Name = "ddlReducerTempSens";
            this.ddlReducerTempSens.Size = new System.Drawing.Size(205, 33);
            this.ddlReducerTempSens.TabIndex = 40;
            this.ddlReducerTempSens.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // labLevelIndicatorSens
            // 
            this.labLevelIndicatorSens.AutoSize = true;
            this.labLevelIndicatorSens.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLevelIndicatorSens.Location = new System.Drawing.Point(37, 117);
            this.labLevelIndicatorSens.Name = "labLevelIndicatorSens";
            this.labLevelIndicatorSens.Size = new System.Drawing.Size(159, 28);
            this.labLevelIndicatorSens.TabIndex = 38;
            this.labLevelIndicatorSens.Text = "液位传感器类型";
            // 
            // labGasTempSens
            // 
            this.labGasTempSens.AutoSize = true;
            this.labGasTempSens.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasTempSens.Location = new System.Drawing.Point(37, 71);
            this.labGasTempSens.Name = "labGasTempSens";
            this.labGasTempSens.Size = new System.Drawing.Size(159, 28);
            this.labGasTempSens.TabIndex = 37;
            this.labGasTempSens.Text = "进气温度传感器";
            // 
            // labReducerTempSens
            // 
            this.labReducerTempSens.AutoSize = true;
            this.labReducerTempSens.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labReducerTempSens.Location = new System.Drawing.Point(37, 25);
            this.labReducerTempSens.Name = "labReducerTempSens";
            this.labReducerTempSens.Size = new System.Drawing.Size(180, 28);
            this.labReducerTempSens.TabIndex = 36;
            this.labReducerTempSens.Text = "减压器温度传感器";
            // 
            // ddlLambda1Type
            // 
            this.ddlLambda1Type.BackColor = System.Drawing.Color.White;
            this.ddlLambda1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLambda1Type.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlLambda1Type.FormattingEnabled = true;
            this.ddlLambda1Type.Location = new System.Drawing.Point(344, 445);
            this.ddlLambda1Type.Name = "ddlLambda1Type";
            this.ddlLambda1Type.Size = new System.Drawing.Size(205, 33);
            this.ddlLambda1Type.TabIndex = 50;
            this.ddlLambda1Type.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // labLambdaType
            // 
            this.labLambdaType.AutoSize = true;
            this.labLambdaType.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambdaType.Location = new System.Drawing.Point(37, 396);
            this.labLambdaType.Name = "labLambdaType";
            this.labLambdaType.Size = new System.Drawing.Size(222, 28);
            this.labLambdaType.TabIndex = 52;
            this.labLambdaType.Text = "催化器前氧传感器类型";
            this.labLambdaType.Click += new System.EventHandler(this.labLambdaType_Click);
            // 
            // labLambda1Type
            // 
            this.labLambda1Type.AutoSize = true;
            this.labLambda1Type.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLambda1Type.Location = new System.Drawing.Point(37, 445);
            this.labLambda1Type.Name = "labLambda1Type";
            this.labLambda1Type.Size = new System.Drawing.Size(226, 28);
            this.labLambda1Type.TabIndex = 53;
            this.labLambda1Type.Text = "1#氧传感器（紫色线）";
            // 
            // ddlLambda2Type
            // 
            this.ddlLambda2Type.BackColor = System.Drawing.Color.White;
            this.ddlLambda2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLambda2Type.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlLambda2Type.FormattingEnabled = true;
            this.ddlLambda2Type.Location = new System.Drawing.Point(344, 490);
            this.ddlLambda2Type.Name = "ddlLambda2Type";
            this.ddlLambda2Type.Size = new System.Drawing.Size(205, 33);
            this.ddlLambda2Type.TabIndex = 54;
            this.ddlLambda2Type.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(95, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "(V)";
            // 
            // LambdaNum
            // 
            this.LambdaNum.AutoSize = true;
            this.LambdaNum.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LambdaNum.Location = new System.Drawing.Point(37, 347);
            this.LambdaNum.Name = "LambdaNum";
            this.LambdaNum.Size = new System.Drawing.Size(117, 28);
            this.LambdaNum.TabIndex = 60;
            this.LambdaNum.Text = "氧传感数量";
            this.LambdaNum.Visible = false;
            // 
            // ddlO2Number
            // 
            this.ddlO2Number.BackColor = System.Drawing.Color.White;
            this.ddlO2Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlO2Number.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlO2Number.FormattingEnabled = true;
            this.ddlO2Number.Location = new System.Drawing.Point(344, 342);
            this.ddlO2Number.Name = "ddlO2Number";
            this.ddlO2Number.Size = new System.Drawing.Size(72, 33);
            this.ddlO2Number.TabIndex = 59;
            this.ddlO2Number.Visible = false;
            this.ddlO2Number.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(37, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 28);
            this.label4.TabIndex = 62;
            this.label4.Text = "2#氧传感器（紫/黑线）";
            // 
            // ddlO2Type
            // 
            this.ddlO2Type.BackColor = System.Drawing.Color.White;
            this.ddlO2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlO2Type.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlO2Type.FormattingEnabled = true;
            this.ddlO2Type.Location = new System.Drawing.Point(344, 395);
            this.ddlO2Type.Name = "ddlO2Type";
            this.ddlO2Type.Size = new System.Drawing.Size(205, 33);
            this.ddlO2Type.TabIndex = 63;
            this.ddlO2Type.SelectedIndexChanged += new System.EventHandler(this.DDL_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(195, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 27);
            this.label2.TabIndex = 64;
            this.label2.Text = "(V)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(295, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 27);
            this.label3.TabIndex = 65;
            this.label3.Text = "(V)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(396, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 27);
            this.label5.TabIndex = 66;
            this.label5.Text = "(V)";
            // 
            // SensorsSettingsPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlO2Type);
            this.Controls.Add(this.LambdaNum);
            this.Controls.Add(this.ddlO2Number);
            this.Controls.Add(this.labLambda1Type);
            this.Controls.Add(this.ddlLambda2Type);
            this.Controls.Add(this.labLambdaType);
            this.Controls.Add(this.ddlLambda1Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numuLV4);
            this.Controls.Add(this.numuLV1);
            this.Controls.Add(this.numuLV3);
            this.Controls.Add(this.labLevelIndicatorSens);
            this.Controls.Add(this.numuLV2);
            this.Controls.Add(this.ddlLevelIndicatorSens);
            this.Controls.Add(this.labReducerTempSens);
            this.Controls.Add(this.labGasTempSens);
            this.Controls.Add(this.ddlReducerTempSens);
            this.Controls.Add(this.ddlGasTempSens);
            this.DoubleBuffered = true;
            this.Name = "SensorsSettingsPanel";
            this.Size = new System.Drawing.Size(769, 541);
            ((System.ComponentModel.ISupportInitialize)(this.numuLV4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuLV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuLV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuLV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numuLV4;
        private System.Windows.Forms.NumericUpDown numuLV3;
        private System.Windows.Forms.NumericUpDown numuLV2;
        private System.Windows.Forms.NumericUpDown numuLV1;
        private System.Windows.Forms.ComboBox ddlLevelIndicatorSens;
        private System.Windows.Forms.ComboBox ddlGasTempSens;
        private System.Windows.Forms.ComboBox ddlReducerTempSens;
        private System.Windows.Forms.Label labLevelIndicatorSens;
        private System.Windows.Forms.Label labGasTempSens;
        private System.Windows.Forms.Label labReducerTempSens;
        private System.Windows.Forms.ComboBox ddlLambda1Type;
        private System.Windows.Forms.Label labLambdaType;
        private System.Windows.Forms.Label labLambda1Type;
        private System.Windows.Forms.ComboBox ddlLambda2Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LambdaNum;
        private System.Windows.Forms.ComboBox ddlO2Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlO2Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
