namespace IGT.UI.Client.UserControls
{
    partial class DiaLine
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
            this.label2 = new System.Windows.Forms.Label();
            this.tpbGasOFF1 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.tpbGasON1 = new IGT.UI.Client.UserControls.TogglePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = global::IGT.UI.Client.Properties.Resources.RedLabelBG2;
            this.label2.Location = new System.Drawing.Point(207, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "0.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpbGasOFF1
            // 
            this.tpbGasOFF1.BackgroundImage = global::IGT.UI.Client.Properties.Resources.ToggleR2;
            this.tpbGasOFF1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpbGasOFF1.Enabled = false;
            this.tpbGasOFF1.Image1 = global::IGT.UI.Client.Properties.Resources.ToggleR2;
            this.tpbGasOFF1.Image2 = global::IGT.UI.Client.Properties.Resources.ToggleR1;
            this.tpbGasOFF1.Location = new System.Drawing.Point(141, 0);
            this.tpbGasOFF1.Name = "tpbGasOFF1";
            this.tpbGasOFF1.Size = new System.Drawing.Size(60, 19);
            this.tpbGasOFF1.TabIndex = 63;
            this.tpbGasOFF1.Text = "0";
            this.tpbGasOFF1.Click += new System.EventHandler(this.tpbGasOFF1_Click);
            // 
            // tpbGasON1
            // 
            this.tpbGasON1.BackgroundImage = global::IGT.UI.Client.Properties.Resources.ToggleR1;
            this.tpbGasON1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpbGasON1.Enabled = false;
            this.tpbGasON1.Image1 = global::IGT.UI.Client.Properties.Resources.ToggleR1;
            this.tpbGasON1.Image2 = global::IGT.UI.Client.Properties.Resources.ToggleR2;
            this.tpbGasON1.Location = new System.Drawing.Point(73, 0);
            this.tpbGasON1.Name = "tpbGasON1";
            this.tpbGasON1.Size = new System.Drawing.Size(60, 19);
            this.tpbGasON1.TabIndex = 62;
            this.tpbGasON1.Text = "0";
            this.tpbGasON1.Click += new System.EventHandler(this.tpbGasON1_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::IGT.UI.Client.Properties.Resources.RedLabelBG;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiaLine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tpbGasOFF1);
            this.Controls.Add(this.tpbGasON1);
            this.Controls.Add(this.label1);
            this.Name = "DiaLine";
            this.Size = new System.Drawing.Size(273, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TogglePictureBox tpbGasOFF1;
        private TogglePictureBox tpbGasON1;
        private System.Windows.Forms.Label label2;
    }
}
