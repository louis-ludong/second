namespace IGT.UI.Client
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.myMenuStrip1 = new IGT.UI.Client.UserControls.MyMenuStrip();
            this.SuspendLayout();
            // 
            // myMenuStrip1
            // 
            this.myMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myMenuStrip1.Location = new System.Drawing.Point(6, 0);
            this.myMenuStrip1.Name = "myMenuStrip1";
            this.myMenuStrip1.ShowCloseButton = true;
            this.myMenuStrip1.ShowConnictMenuButton = true;
            this.myMenuStrip1.ShowGraphMenuButton = false;
            this.myMenuStrip1.ShowMinButton = true;
            this.myMenuStrip1.Size = new System.Drawing.Size(1018, 60);
            this.myMenuStrip1.TabIndex = 0;
            this.myMenuStrip1.Load += new System.EventHandler(this.myMenuStrip1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1030, 722);
            this.Controls.Add(this.myMenuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.MyMenuStrip myMenuStrip1;


    }
}

