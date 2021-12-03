namespace IGT.UI.Client
{
    partial class UpdateECUForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateECUForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labHard = new System.Windows.Forms.Label();
            this.labROMF = new System.Windows.Forms.Label();
            this.labROMD = new System.Windows.Forms.Label();
            this.labmsg = new System.Windows.Forms.Label();
            this.labValueHard = new System.Windows.Forms.Label();
            this.labValueROMF = new System.Windows.Forms.Label();
            this.labValueROMD = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.myMenuStrip1 = new IGT.UI.Client.UserControls.MyMenuStrip();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 231);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(303, 30);
            this.progressBar1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(15, 267);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 35);
            this.btnStart.TabIndex = 148;
            this.btnStart.Text = "升级";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(186, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 35);
            this.btnExit.TabIndex = 149;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labHard
            // 
            this.labHard.AutoSize = true;
            this.labHard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHard.Location = new System.Drawing.Point(13, 75);
            this.labHard.Name = "labHard";
            this.labHard.Size = new System.Drawing.Size(74, 21);
            this.labHard.TabIndex = 150;
            this.labHard.Text = "硬件版本";
            // 
            // labROMF
            // 
            this.labROMF.AutoSize = true;
            this.labROMF.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labROMF.Location = new System.Drawing.Point(13, 172);
            this.labROMF.Name = "labROMF";
            this.labROMF.Size = new System.Drawing.Size(116, 21);
            this.labROMF.TabIndex = 151;
            this.labROMF.Text = "固件版本(文件)";
            // 
            // labROMD
            // 
            this.labROMD.AutoSize = true;
            this.labROMD.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labROMD.Location = new System.Drawing.Point(13, 125);
            this.labROMD.Name = "labROMD";
            this.labROMD.Size = new System.Drawing.Size(116, 21);
            this.labROMD.TabIndex = 152;
            this.labROMD.Text = "固件版本(设备)";
            // 
            // labmsg
            // 
            this.labmsg.BackColor = System.Drawing.Color.White;
            this.labmsg.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labmsg.Location = new System.Drawing.Point(11, 193);
            this.labmsg.Name = "labmsg";
            this.labmsg.Size = new System.Drawing.Size(246, 35);
            this.labmsg.TabIndex = 153;
            this.labmsg.Text = "msg";
            this.labmsg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labValueHard
            // 
            this.labValueHard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labValueHard.Location = new System.Drawing.Point(203, 75);
            this.labValueHard.Name = "labValueHard";
            this.labValueHard.Size = new System.Drawing.Size(85, 21);
            this.labValueHard.TabIndex = 154;
            this.labValueHard.Text = "1.0";
            this.labValueHard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labValueROMF
            // 
            this.labValueROMF.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labValueROMF.Location = new System.Drawing.Point(199, 172);
            this.labValueROMF.Name = "labValueROMF";
            this.labValueROMF.Size = new System.Drawing.Size(89, 21);
            this.labValueROMF.TabIndex = 155;
            this.labValueROMF.Text = "1.0";
            this.labValueROMF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labValueROMD
            // 
            this.labValueROMD.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labValueROMD.Location = new System.Drawing.Point(203, 125);
            this.labValueROMD.Name = "labValueROMD";
            this.labValueROMD.Size = new System.Drawing.Size(85, 21);
            this.labValueROMD.TabIndex = 156;
            this.labValueROMD.Text = "1.0";
            this.labValueROMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // myMenuStrip1
            // 
            this.myMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.myMenuStrip1.Name = "myMenuStrip1";
            this.myMenuStrip1.ShowCloseButton = true;
            this.myMenuStrip1.ShowConnictMenuButton = true;
            this.myMenuStrip1.ShowGraphMenuButton = false;
            this.myMenuStrip1.ShowMinButton = true;
            this.myMenuStrip1.Size = new System.Drawing.Size(325, 52);
            this.myMenuStrip1.TabIndex = 1;
            // 
            // UpdateECUForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 314);
            this.Controls.Add(this.labValueROMD);
            this.Controls.Add(this.labValueROMF);
            this.Controls.Add(this.labValueHard);
            this.Controls.Add(this.labmsg);
            this.Controls.Add(this.labROMD);
            this.Controls.Add(this.labROMF);
            this.Controls.Add(this.labHard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.myMenuStrip1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateECUForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateECU";
            this.Load += new System.EventHandler(this.UpdateECUForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private UserControls.MyMenuStrip myMenuStrip1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labHard;
        private System.Windows.Forms.Label labROMF;
        private System.Windows.Forms.Label labROMD;
        private System.Windows.Forms.Label labmsg;
        private System.Windows.Forms.Label labValueHard;
        private System.Windows.Forms.Label labValueROMF;
        private System.Windows.Forms.Label labValueROMD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}