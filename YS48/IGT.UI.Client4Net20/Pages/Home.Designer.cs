namespace IGT.UI.Client.Pages
{
    partial class Home
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
            this.labHardWareVer = new System.Windows.Forms.Label();
            this.labFirmWare = new System.Windows.Forms.Label();
            this.labConnectState = new System.Windows.Forms.Label();
            this.labMExit = new System.Windows.Forms.Label();
            this.labMUpdate = new System.Windows.Forms.Label();
            this.labMLoad = new System.Windows.Forms.Label();
            this.labMSave = new System.Windows.Forms.Label();
            this.labMAutoCalibration = new System.Windows.Forms.Label();
            this.labMDiagnostics = new System.Windows.Forms.Label();
            this.labMRealyData = new System.Windows.Forms.Label();
            this.labMCar = new System.Windows.Forms.Label();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.labSerialNumber = new System.Windows.Forms.Label();
            this.btnCopy = new IGT.UI.Client.VistaButton();
            this.SuspendLayout();
            // 
            // labHardWareVer
            // 
            this.labHardWareVer.AutoSize = true;
            this.labHardWareVer.BackColor = System.Drawing.Color.Transparent;
            this.labHardWareVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labHardWareVer.Location = new System.Drawing.Point(798, 619);
            this.labHardWareVer.Name = "labHardWareVer";
            this.labHardWareVer.Size = new System.Drawing.Size(41, 12);
            this.labHardWareVer.TabIndex = 10;
            this.labHardWareVer.Text = "label3";
            // 
            // labFirmWare
            // 
            this.labFirmWare.AutoSize = true;
            this.labFirmWare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labFirmWare.Location = new System.Drawing.Point(612, 621);
            this.labFirmWare.Name = "labFirmWare";
            this.labFirmWare.Size = new System.Drawing.Size(41, 12);
            this.labFirmWare.TabIndex = 9;
            this.labFirmWare.Text = "label2";
            // 
            // labConnectState
            // 
            this.labConnectState.AutoSize = true;
            this.labConnectState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labConnectState.Location = new System.Drawing.Point(85, 626);
            this.labConnectState.Name = "labConnectState";
            this.labConnectState.Size = new System.Drawing.Size(41, 12);
            this.labConnectState.TabIndex = 8;
            this.labConnectState.Text = "label1";
            // 
            // labMExit
            // 
            this.labMExit.BackColor = System.Drawing.Color.Transparent;
            this.labMExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMExit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.labMExit.ForeColor = System.Drawing.Color.Black;
            this.labMExit.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_Exit;
            this.labMExit.Location = new System.Drawing.Point(566, 445);
            this.labMExit.Name = "labMExit";
            this.labMExit.Size = new System.Drawing.Size(367, 130);
            this.labMExit.TabIndex = 18;
            this.labMExit.Text = "label8";
            this.labMExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMExit.Click += new System.EventHandler(this.Button_Click);
            this.labMExit.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMExit.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // labMUpdate
            // 
            this.labMUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labMUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMUpdate.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.labMUpdate.ForeColor = System.Drawing.Color.Black;
            this.labMUpdate.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_Update;
            this.labMUpdate.Location = new System.Drawing.Point(566, 315);
            this.labMUpdate.Name = "labMUpdate";
            this.labMUpdate.Size = new System.Drawing.Size(367, 130);
            this.labMUpdate.TabIndex = 17;
            this.labMUpdate.Text = "label7";
            this.labMUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMUpdate.Click += new System.EventHandler(this.Button_Click);
            this.labMUpdate.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMUpdate.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // labMLoad
            // 
            this.labMLoad.BackColor = System.Drawing.Color.Transparent;
            this.labMLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMLoad.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.labMLoad.ForeColor = System.Drawing.Color.Black;
            this.labMLoad.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_Load;
            this.labMLoad.Location = new System.Drawing.Point(566, 185);
            this.labMLoad.Name = "labMLoad";
            this.labMLoad.Size = new System.Drawing.Size(367, 130);
            this.labMLoad.TabIndex = 16;
            this.labMLoad.Text = "label6";
            this.labMLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMLoad.Click += new System.EventHandler(this.Button_Click);
            this.labMLoad.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMLoad.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // labMSave
            // 
            this.labMSave.BackColor = System.Drawing.Color.Transparent;
            this.labMSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.labMSave.ForeColor = System.Drawing.Color.Black;
            this.labMSave.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_Save;
            this.labMSave.Location = new System.Drawing.Point(566, 55);
            this.labMSave.Name = "labMSave";
            this.labMSave.Size = new System.Drawing.Size(367, 130);
            this.labMSave.TabIndex = 15;
            this.labMSave.Text = "label5";
            this.labMSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMSave.Click += new System.EventHandler(this.Button_Click);
            this.labMSave.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMSave.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // labMAutoCalibration
            // 
            this.labMAutoCalibration.BackColor = System.Drawing.Color.Transparent;
            this.labMAutoCalibration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMAutoCalibration.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.labMAutoCalibration.ForeColor = System.Drawing.Color.Black;
            this.labMAutoCalibration.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_AutoCalibration;
            this.labMAutoCalibration.Location = new System.Drawing.Point(84, 445);
            this.labMAutoCalibration.Name = "labMAutoCalibration";
            this.labMAutoCalibration.Size = new System.Drawing.Size(367, 130);
            this.labMAutoCalibration.TabIndex = 14;
            this.labMAutoCalibration.Text = "label4";
            this.labMAutoCalibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMAutoCalibration.Click += new System.EventHandler(this.Button_Click);
            this.labMAutoCalibration.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMAutoCalibration.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // labMDiagnostics
            // 
            this.labMDiagnostics.BackColor = System.Drawing.Color.Transparent;
            this.labMDiagnostics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMDiagnostics.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.labMDiagnostics.ForeColor = System.Drawing.Color.Black;
            this.labMDiagnostics.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_Diagnostics;
            this.labMDiagnostics.Location = new System.Drawing.Point(84, 315);
            this.labMDiagnostics.Name = "labMDiagnostics";
            this.labMDiagnostics.Size = new System.Drawing.Size(367, 130);
            this.labMDiagnostics.TabIndex = 13;
            this.labMDiagnostics.Text = "label3";
            this.labMDiagnostics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMDiagnostics.Click += new System.EventHandler(this.Button_Click);
            this.labMDiagnostics.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMDiagnostics.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // labMRealyData
            // 
            this.labMRealyData.BackColor = System.Drawing.Color.Transparent;
            this.labMRealyData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMRealyData.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.labMRealyData.ForeColor = System.Drawing.Color.Black;
            this.labMRealyData.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_RealyData;
            this.labMRealyData.Location = new System.Drawing.Point(84, 185);
            this.labMRealyData.Name = "labMRealyData";
            this.labMRealyData.Size = new System.Drawing.Size(367, 130);
            this.labMRealyData.TabIndex = 12;
            this.labMRealyData.Text = "label2";
            this.labMRealyData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMRealyData.Click += new System.EventHandler(this.Button_Click);
            this.labMRealyData.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMRealyData.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // labMCar
            // 
            this.labMCar.BackColor = System.Drawing.Color.Transparent;
            this.labMCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labMCar.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMCar.ForeColor = System.Drawing.Color.Black;
            this.labMCar.Image = global::IGT.UI.Client.Properties.Resources.MainMenu_Car;
            this.labMCar.Location = new System.Drawing.Point(84, 55);
            this.labMCar.Name = "labMCar";
            this.labMCar.Size = new System.Drawing.Size(367, 130);
            this.labMCar.TabIndex = 11;
            this.labMCar.Text = "label1";
            this.labMCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labMCar.Click += new System.EventHandler(this.Button_Click);
            this.labMCar.MouseEnter += new System.EventHandler(this.mainMenuButton_MouseEnter);
            this.labMCar.MouseLeave += new System.EventHandler(this.mainMenuButton_MouseLeave);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(30, 30);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.TabIndex = 0;
            // 
            // labSerialNumber
            // 
            this.labSerialNumber.AutoSize = true;
            this.labSerialNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labSerialNumber.Location = new System.Drawing.Point(197, 621);
            this.labSerialNumber.Name = "labSerialNumber";
            this.labSerialNumber.Size = new System.Drawing.Size(262, 21);
            this.labSerialNumber.TabIndex = 19;
            this.labSerialNumber.Text = "SerialNumber:1234567890123456";
            this.labSerialNumber.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnCopy.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnCopy.ButtonText = "COPY";
            this.btnCopy.CornerRadius = 12;
            this.btnCopy.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnCopy.Location = new System.Drawing.Point(468, 613);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(66, 34);
            this.btnCopy.TabIndex = 169;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Home
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::IGT.UI.Client.Properties.Resources.background1;
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.labSerialNumber);
            this.Controls.Add(this.labMExit);
            this.Controls.Add(this.labMUpdate);
            this.Controls.Add(this.labMLoad);
            this.Controls.Add(this.labMSave);
            this.Controls.Add(this.labMAutoCalibration);
            this.Controls.Add(this.labMDiagnostics);
            this.Controls.Add(this.labMRealyData);
            this.Controls.Add(this.labMCar);
            this.Controls.Add(this.labHardWareVer);
            this.Controls.Add(this.labFirmWare);
            this.Controls.Add(this.labConnectState);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1023, 656);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHardWareVer;
        private System.Windows.Forms.Label labFirmWare;
        private System.Windows.Forms.Label labConnectState;
        private System.Windows.Forms.Label labMCar;
        private System.Windows.Forms.Label labMRealyData;
        private System.Windows.Forms.Label labMDiagnostics;
        private System.Windows.Forms.Label labMAutoCalibration;
        private System.Windows.Forms.Label labMSave;
        private System.Windows.Forms.Label labMLoad;
        private System.Windows.Forms.Label labMUpdate;
        private System.Windows.Forms.Label labMExit;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private System.Windows.Forms.Label labSerialNumber;
        private VistaButton btnCopy;
    }
}
