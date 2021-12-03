namespace IGT.UI.Client.UserControls
{
    partial class MyMenuStrip
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labTopAbout = new System.Windows.Forms.Label();
            this.pbTopAbout = new System.Windows.Forms.PictureBox();
            this.labTopHelp = new System.Windows.Forms.Label();
            this.pbTopHelp = new System.Windows.Forms.PictureBox();
            this.labTopSetting = new System.Windows.Forms.Label();
            this.pbTopSetting = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labTopConnict = new System.Windows.Forms.Label();
            this.labTopGraph = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.cmsConnict = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisConnict = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGraph = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_G_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_G_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_G_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cmsConnict.SuspendLayout();
            this.cmsSettings.SuspendLayout();
            this.cmsGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.flowLayoutPanel1.Controls.Add(this.pbClose);
            this.flowLayoutPanel1.Controls.Add(this.pbMin);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.labTopAbout);
            this.flowLayoutPanel1.Controls.Add(this.pbTopAbout);
            this.flowLayoutPanel1.Controls.Add(this.labTopHelp);
            this.flowLayoutPanel1.Controls.Add(this.pbTopHelp);
            this.flowLayoutPanel1.Controls.Add(this.labTopSetting);
            this.flowLayoutPanel1.Controls.Add(this.pbTopSetting);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.labTopConnict);
            this.flowLayoutPanel1.Controls.Add(this.labTopGraph);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 60);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::IGT.UI.Client.Properties.Resources.TopBar_CloseButton;
            this.pbClose.Location = new System.Drawing.Point(986, 15);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 15, 10, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 24);
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.TopBarSysButton_Click);
            // 
            // pbMin
            // 
            this.pbMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMin.Image = global::IGT.UI.Client.Properties.Resources.TopBar_MinButton;
            this.pbMin.Location = new System.Drawing.Point(947, 15);
            this.pbMin.Margin = new System.Windows.Forms.Padding(3, 15, 12, 3);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(24, 24);
            this.pbMin.TabIndex = 1;
            this.pbMin.TabStop = false;
            this.pbMin.Click += new System.EventHandler(this.TopBarSysButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(925, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 26);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labTopAbout
            // 
            this.labTopAbout.AutoSize = true;
            this.labTopAbout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTopAbout.ForeColor = System.Drawing.Color.White;
            this.labTopAbout.Location = new System.Drawing.Point(887, 18);
            this.labTopAbout.Margin = new System.Windows.Forms.Padding(0, 18, 9, 0);
            this.labTopAbout.Name = "labTopAbout";
            this.labTopAbout.Size = new System.Drawing.Size(29, 12);
            this.labTopAbout.TabIndex = 2;
            this.labTopAbout.Text = "关于";
            this.labTopAbout.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // pbTopAbout
            // 
            this.pbTopAbout.Image = global::IGT.UI.Client.Properties.Resources.TopBar_About;
            this.pbTopAbout.Location = new System.Drawing.Point(875, 20);
            this.pbTopAbout.Margin = new System.Windows.Forms.Padding(3, 20, 0, 3);
            this.pbTopAbout.Name = "pbTopAbout";
            this.pbTopAbout.Size = new System.Drawing.Size(12, 12);
            this.pbTopAbout.TabIndex = 3;
            this.pbTopAbout.TabStop = false;
            this.pbTopAbout.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // labTopHelp
            // 
            this.labTopHelp.AutoSize = true;
            this.labTopHelp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTopHelp.ForeColor = System.Drawing.Color.White;
            this.labTopHelp.Location = new System.Drawing.Point(834, 18);
            this.labTopHelp.Margin = new System.Windows.Forms.Padding(0, 18, 9, 0);
            this.labTopHelp.Name = "labTopHelp";
            this.labTopHelp.Size = new System.Drawing.Size(29, 12);
            this.labTopHelp.TabIndex = 4;
            this.labTopHelp.Text = "帮助";
            this.labTopHelp.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // pbTopHelp
            // 
            this.pbTopHelp.Image = global::IGT.UI.Client.Properties.Resources.TopBar_Help;
            this.pbTopHelp.Location = new System.Drawing.Point(822, 20);
            this.pbTopHelp.Margin = new System.Windows.Forms.Padding(3, 20, 0, 3);
            this.pbTopHelp.Name = "pbTopHelp";
            this.pbTopHelp.Size = new System.Drawing.Size(12, 12);
            this.pbTopHelp.TabIndex = 5;
            this.pbTopHelp.TabStop = false;
            this.pbTopHelp.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // labTopSetting
            // 
            this.labTopSetting.AutoSize = true;
            this.labTopSetting.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTopSetting.ForeColor = System.Drawing.Color.White;
            this.labTopSetting.Location = new System.Drawing.Point(781, 18);
            this.labTopSetting.Margin = new System.Windows.Forms.Padding(0, 18, 9, 0);
            this.labTopSetting.Name = "labTopSetting";
            this.labTopSetting.Size = new System.Drawing.Size(29, 12);
            this.labTopSetting.TabIndex = 6;
            this.labTopSetting.Text = "设置";
            this.labTopSetting.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // pbTopSetting
            // 
            this.pbTopSetting.Image = global::IGT.UI.Client.Properties.Resources.TopBar_Setting;
            this.pbTopSetting.Location = new System.Drawing.Point(769, 20);
            this.pbTopSetting.Margin = new System.Windows.Forms.Padding(3, 20, 0, 3);
            this.pbTopSetting.Name = "pbTopSetting";
            this.pbTopSetting.Size = new System.Drawing.Size(12, 12);
            this.pbTopSetting.TabIndex = 7;
            this.pbTopSetting.TabStop = false;
            this.pbTopSetting.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(754, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 0, 11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 26);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // labTopConnict
            // 
            this.labTopConnict.AutoSize = true;
            this.labTopConnict.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTopConnict.ForeColor = System.Drawing.Color.White;
            this.labTopConnict.Location = new System.Drawing.Point(716, 18);
            this.labTopConnict.Margin = new System.Windows.Forms.Padding(0, 18, 9, 0);
            this.labTopConnict.Name = "labTopConnict";
            this.labTopConnict.Size = new System.Drawing.Size(29, 12);
            this.labTopConnict.TabIndex = 10;
            this.labTopConnict.Text = "连接";
            this.labTopConnict.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // labTopGraph
            // 
            this.labTopGraph.AutoSize = true;
            this.labTopGraph.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTopGraph.ForeColor = System.Drawing.Color.White;
            this.labTopGraph.Location = new System.Drawing.Point(678, 18);
            this.labTopGraph.Margin = new System.Windows.Forms.Padding(0, 18, 9, 0);
            this.labTopGraph.Name = "labTopGraph";
            this.labTopGraph.Size = new System.Drawing.Size(29, 12);
            this.labTopGraph.TabIndex = 11;
            this.labTopGraph.Text = "图表";
            this.labTopGraph.Click += new System.EventHandler(this.TopBarMenu_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(160, 18);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(51, 25);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "Title";
            // 
            // cmsConnict
            // 
            this.cmsConnict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsConnict.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiDisConnict,
            this.toolStripSeparator1});
            this.cmsConnict.Name = "cmsConnict";
            this.cmsConnict.Size = new System.Drawing.Size(123, 54);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(122, 22);
            this.tsmiSearch.Text = "自动搜索";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // tsmiDisConnict
            // 
            this.tsmiDisConnict.Checked = true;
            this.tsmiDisConnict.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiDisConnict.Name = "tsmiDisConnict";
            this.tsmiDisConnict.Size = new System.Drawing.Size(122, 22);
            this.tsmiDisConnict.Text = "断开连接";
            this.tsmiDisConnict.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // cmsSettings
            // 
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLang,
            this.tsmiReset,
            this.tsmiSetPassword});
            this.cmsSettings.Name = "cmsSettings";
            this.cmsSettings.Size = new System.Drawing.Size(153, 92);
            this.cmsSettings.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSettings_Opening);
            // 
            // tsmiLang
            // 
            this.tsmiLang.Name = "tsmiLang";
            this.tsmiLang.Size = new System.Drawing.Size(152, 22);
            this.tsmiLang.Text = "语言";
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(152, 22);
            this.tsmiReset.Text = "重置";
            this.tsmiReset.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // tsmiSetPassword
            // 
            this.tsmiSetPassword.Name = "tsmiSetPassword";
            this.tsmiSetPassword.Size = new System.Drawing.Size(152, 22);
            this.tsmiSetPassword.Text = "设置密码";
            this.tsmiSetPassword.Visible = false;
            this.tsmiSetPassword.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // cmsGraph
            // 
            this.cmsGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsGraph.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_G_Start,
            this.tsmi_G_Stop,
            this.tsmi_G_Show});
            this.cmsGraph.Name = "cmsConnict";
            this.cmsGraph.Size = new System.Drawing.Size(123, 70);
            this.cmsGraph.Opening += new System.ComponentModel.CancelEventHandler(this.cmsGraph_Opening);
            // 
            // tsmi_G_Start
            // 
            this.tsmi_G_Start.Name = "tsmi_G_Start";
            this.tsmi_G_Start.Size = new System.Drawing.Size(122, 22);
            this.tsmi_G_Start.Text = "开始记录";
            this.tsmi_G_Start.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // tsmi_G_Stop
            // 
            this.tsmi_G_Stop.Name = "tsmi_G_Stop";
            this.tsmi_G_Stop.Size = new System.Drawing.Size(122, 22);
            this.tsmi_G_Stop.Text = "结束记录";
            this.tsmi_G_Stop.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // tsmi_G_Show
            // 
            this.tsmi_G_Show.Name = "tsmi_G_Show";
            this.tsmi_G_Show.Size = new System.Drawing.Size(122, 22);
            this.tsmi_G_Show.Text = "显示图表";
            this.tsmi_G_Show.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // MyMenuStrip
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MyMenuStrip";
            this.Size = new System.Drawing.Size(1020, 60);
            this.Load += new System.EventHandler(this.MyMenuStrip_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cmsConnict.ResumeLayout(false);
            this.cmsSettings.ResumeLayout(false);
            this.cmsGraph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labTopAbout;
        private System.Windows.Forms.PictureBox pbTopAbout;
        private System.Windows.Forms.Label labTopHelp;
        private System.Windows.Forms.PictureBox pbTopHelp;
        private System.Windows.Forms.Label labTopSetting;
        private System.Windows.Forms.PictureBox pbTopSetting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labTopConnict;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.ContextMenuStrip cmsConnict;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisConnict;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiLang;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetPassword;
        private System.Windows.Forms.Label labTopGraph;
        private System.Windows.Forms.ContextMenuStrip cmsGraph;
        private System.Windows.Forms.ToolStripMenuItem tsmi_G_Start;
        private System.Windows.Forms.ToolStripMenuItem tsmi_G_Stop;
        private System.Windows.Forms.ToolStripMenuItem tsmi_G_Show;

    }
}
