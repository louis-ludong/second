namespace IGT.UI.Client.UserControls
{
    partial class InjectorsMeasurement
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
            this.pbCursor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCursor
            // 
            this.pbCursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.pbCursor.Location = new System.Drawing.Point(171, 85);
            this.pbCursor.Name = "pbCursor";
            this.pbCursor.Size = new System.Drawing.Size(14, 17);
            this.pbCursor.TabIndex = 1;
            this.pbCursor.TabStop = false;
            // 
            // InjectorsMeasurement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::IGT.UI.Client.Properties.Resources.InjectorsMeasurement;
            this.Controls.Add(this.pbCursor);
            this.Name = "InjectorsMeasurement";
            this.Size = new System.Drawing.Size(358, 160);
            this.Load += new System.EventHandler(this.InjectorsMeasurement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCursor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCursor;
    }
}
