namespace IGT.UI.Client.UserControls.SettingPanels
{
    partial class OBDSettingPanel
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
            this.labOBDType = new System.Windows.Forms.Label();
            this.ddlOBDType = new System.Windows.Forms.ComboBox();
            this.ckbAdaptivity = new System.Windows.Forms.CheckBox();
            this.labTypePetTim = new System.Windows.Forms.Label();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbOpposite = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbCompleteErrors = new System.Windows.Forms.CheckBox();
            this.ckbSelectiveErrors = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labOBDType
            // 
            this.labOBDType.AutoEllipsis = true;
            this.labOBDType.AutoSize = true;
            this.labOBDType.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOBDType.Location = new System.Drawing.Point(34, 36);
            this.labOBDType.Name = "labOBDType";
            this.labOBDType.Size = new System.Drawing.Size(142, 28);
            this.labOBDType.TabIndex = 109;
            this.labOBDType.Text = "OBD连接类型";
            // 
            // ddlOBDType
            // 
            this.ddlOBDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOBDType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlOBDType.FormattingEnabled = true;
            this.ddlOBDType.Location = new System.Drawing.Point(310, 34);
            this.ddlOBDType.Name = "ddlOBDType";
            this.ddlOBDType.Size = new System.Drawing.Size(272, 33);
            this.ddlOBDType.TabIndex = 110;
            this.ddlOBDType.SelectedIndexChanged += new System.EventHandler(this.ddlOBDType_SelectedIndexChanged);
            // 
            // ckbAdaptivity
            // 
            this.ckbAdaptivity.AutoSize = true;
            this.ckbAdaptivity.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbAdaptivity.Location = new System.Drawing.Point(614, 34);
            this.ckbAdaptivity.Name = "ckbAdaptivity";
            this.ckbAdaptivity.Size = new System.Drawing.Size(94, 32);
            this.ckbAdaptivity.TabIndex = 114;
            this.ckbAdaptivity.Text = "适应性";
            this.ckbAdaptivity.UseVisualStyleBackColor = true;
            this.ckbAdaptivity.CheckedChanged += new System.EventHandler(this.ckb_CheckedChanged);
            // 
            // labTypePetTim
            // 
            this.labTypePetTim.AutoEllipsis = true;
            this.labTypePetTim.AutoSize = true;
            this.labTypePetTim.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTypePetTim.Location = new System.Drawing.Point(34, 86);
            this.labTypePetTim.Name = "labTypePetTim";
            this.labTypePetTim.Size = new System.Drawing.Size(159, 28);
            this.labTypePetTim.TabIndex = 109;
            this.labTypePetTim.Text = "燃油自适应类型";
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.rbStandard.Location = new System.Drawing.Point(34, 131);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(72, 32);
            this.rbStandard.TabIndex = 115;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "标准";
            this.rbStandard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbStandard_CheckedChanged);
            // 
            // rbOpposite
            // 
            this.rbOpposite.AutoSize = true;
            this.rbOpposite.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.rbOpposite.Location = new System.Drawing.Point(389, 131);
            this.rbOpposite.Name = "rbOpposite";
            this.rbOpposite.Size = new System.Drawing.Size(114, 32);
            this.rbOpposite.TabIndex = 116;
            this.rbOpposite.TabStop = true;
            this.rbOpposite.Text = "反向类型";
            this.rbOpposite.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOpposite.UseVisualStyleBackColor = true;
            this.rbOpposite.CheckedChanged += new System.EventHandler(this.rbStandard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(34, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 51);
            this.label1.TabIndex = 109;
            this.label1.Text = "正自适应值稀混合比";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(385, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 51);
            this.label2.TabIndex = 109;
            this.label2.Text = "负自适应值稀混合比";
            // 
            // ckbCompleteErrors
            // 
            this.ckbCompleteErrors.AutoSize = true;
            this.ckbCompleteErrors.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbCompleteErrors.Location = new System.Drawing.Point(34, 220);
            this.ckbCompleteErrors.Name = "ckbCompleteErrors";
            this.ckbCompleteErrors.Size = new System.Drawing.Size(241, 32);
            this.ckbCompleteErrors.TabIndex = 114;
            this.ckbCompleteErrors.Text = "完成故障错误复位有效";
            this.ckbCompleteErrors.UseVisualStyleBackColor = true;
            this.ckbCompleteErrors.CheckedChanged += new System.EventHandler(this.ckb_CheckedChanged);
            // 
            // ckbSelectiveErrors
            // 
            this.ckbSelectiveErrors.AutoSize = true;
            this.ckbSelectiveErrors.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbSelectiveErrors.Location = new System.Drawing.Point(34, 262);
            this.ckbSelectiveErrors.Name = "ckbSelectiveErrors";
            this.ckbSelectiveErrors.Size = new System.Drawing.Size(220, 32);
            this.ckbSelectiveErrors.TabIndex = 114;
            this.ckbSelectiveErrors.Text = "使用选择性错误复位";
            this.ckbSelectiveErrors.UseVisualStyleBackColor = true;
            this.ckbSelectiveErrors.CheckedChanged += new System.EventHandler(this.ckb_CheckedChanged);
            // 
            // OBDSettingPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.rbStandard);
            this.Controls.Add(this.rbOpposite);
            this.Controls.Add(this.ckbSelectiveErrors);
            this.Controls.Add(this.ckbCompleteErrors);
            this.Controls.Add(this.ckbAdaptivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labTypePetTim);
            this.Controls.Add(this.labOBDType);
            this.Controls.Add(this.ddlOBDType);
            this.Name = "OBDSettingPanel";
            this.Size = new System.Drawing.Size(827, 541);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOBDType;
        private System.Windows.Forms.ComboBox ddlOBDType;
        private System.Windows.Forms.CheckBox ckbAdaptivity;
        private System.Windows.Forms.Label labTypePetTim;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbOpposite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbCompleteErrors;
        private System.Windows.Forms.CheckBox ckbSelectiveErrors;

    }
}
