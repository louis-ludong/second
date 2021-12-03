namespace IGT.UI.Client.UserControls
{
    partial class OBDErrorsForm
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
            this.components = new System.ComponentModel.Container();
            this.lvErrors = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPotential = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labErrors = new System.Windows.Forms.Label();
            this.labPotential = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myMenuStrip1 = new IGT.UI.Client.UserControls.MyMenuStrip();
            this.btnClear = new IGT.UI.Client.VistaButton();
            this.btnRefresh = new IGT.UI.Client.VistaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvErrors
            // 
            this.lvErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvErrors.Location = new System.Drawing.Point(12, 95);
            this.lvErrors.Name = "lvErrors";
            this.lvErrors.ShowItemToolTips = true;
            this.lvErrors.Size = new System.Drawing.Size(385, 446);
            this.lvErrors.TabIndex = 150;
            this.lvErrors.UseCompatibleStateImageBehavior = false;
            this.lvErrors.View = System.Windows.Forms.View.Details;
            this.lvErrors.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lvErrors_ItemMouseHover);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Code";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 345;
            // 
            // lvPotential
            // 
            this.lvPotential.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.lvPotential.Location = new System.Drawing.Point(403, 95);
            this.lvPotential.Name = "lvPotential";
            this.lvPotential.ShowItemToolTips = true;
            this.lvPotential.Size = new System.Drawing.Size(385, 446);
            this.lvPotential.TabIndex = 151;
            this.lvPotential.UseCompatibleStateImageBehavior = false;
            this.lvPotential.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 337;
            // 
            // labErrors
            // 
            this.labErrors.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.labErrors.Location = new System.Drawing.Point(12, 69);
            this.labErrors.Name = "labErrors";
            this.labErrors.Size = new System.Drawing.Size(385, 23);
            this.labErrors.TabIndex = 152;
            this.labErrors.Text = "储存故障";
            this.labErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPotential
            // 
            this.labPotential.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPotential.ForeColor = System.Drawing.Color.LimeGreen;
            this.labPotential.Location = new System.Drawing.Point(403, 69);
            this.labPotential.Name = "labPotential";
            this.labPotential.Size = new System.Drawing.Size(385, 23);
            this.labPotential.TabIndex = 153;
            this.labPotential.Text = "潜在故障";
            this.labPotential.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IGT.UI.Client.Properties.Resources.TopBar_CloseButton;
            this.pictureBox1.Location = new System.Drawing.Point(762, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 155;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.myMenuStrip1.Size = new System.Drawing.Size(800, 52);
            this.myMenuStrip1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnClear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnClear.Location = new System.Drawing.Point(565, 547);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 34);
            this.btnClear.TabIndex = 156;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnRefresh.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnRefresh.ButtonText = "Refresh";
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(38)))));
            this.btnRefresh.Location = new System.Drawing.Point(686, 547);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 34);
            this.btnRefresh.TabIndex = 156;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // OBDErrorsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labPotential);
            this.Controls.Add(this.labErrors);
            this.Controls.Add(this.lvPotential);
            this.Controls.Add(this.lvErrors);
            this.Controls.Add(this.myMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OBDErrorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OBDErrorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyMenuStrip myMenuStrip1;
        private System.Windows.Forms.ListView lvErrors;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvPotential;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label labErrors;
        private System.Windows.Forms.Label labPotential;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VistaButton btnClear;
        private VistaButton btnRefresh;
    }
}