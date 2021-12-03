namespace IGT.UI.Client
{
    partial class RealTimeGraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealTimeGraphForm));
            this.tChart1 = new Steema.TeeChart.TChart();
            this.lineGas = new Steema.TeeChart.Styles.Line();
            this.lineGasLevel = new Steema.TeeChart.Styles.Line();
            this.lineGasPress = new Steema.TeeChart.Styles.Line();
            this.lineMAPPress = new Steema.TeeChart.Styles.Line();
            this.linePetrol = new Steema.TeeChart.Styles.Line();
            this.lineRPM = new Steema.TeeChart.Styles.Line();
            this.lineTempGas = new Steema.TeeChart.Styles.Line();
            this.lineTempRed = new Steema.TeeChart.Styles.Line();
            this.myMenuStrip1 = new IGT.UI.Client.UserControls.MyMenuStrip();
            this.SuspendLayout();
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Visible = false;
            this.tChart1.BackColor = System.Drawing.Color.White;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            // 
            // 
            // 
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Pen.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(2, 27);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Series.Add(this.lineGas);
            this.tChart1.Series.Add(this.lineGasLevel);
            this.tChart1.Series.Add(this.lineGasPress);
            this.tChart1.Series.Add(this.lineMAPPress);
            this.tChart1.Series.Add(this.linePetrol);
            this.tChart1.Series.Add(this.lineRPM);
            this.tChart1.Series.Add(this.lineTempGas);
            this.tChart1.Series.Add(this.lineTempRed);
            this.tChart1.Size = new System.Drawing.Size(885, 705);
            this.tChart1.TabIndex = 2;
            // 
            // lineGas
            // 
            // 
            // 
            // 
            this.lineGas.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.lineGas.ColorEach = false;
            // 
            // 
            // 
            this.lineGas.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(82)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineGas.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineGas.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineGas.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineGas.Marks.Callout.Distance = 0;
            this.lineGas.Marks.Callout.Draw3D = false;
            this.lineGas.Marks.Callout.Length = 10;
            this.lineGas.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.lineGas.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineGas.Title = "Gas";
            // 
            // 
            // 
            this.lineGas.XValues.DataMember = "X";
            this.lineGas.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineGas.YValues.DataMember = "Y";
            // 
            // lineGasLevel
            // 
            // 
            // 
            // 
            this.lineGasLevel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.lineGasLevel.ColorEach = false;
            // 
            // 
            // 
            this.lineGasLevel.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(78)))), ((int)(((byte)(26)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineGasLevel.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineGasLevel.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineGasLevel.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineGasLevel.Marks.Callout.Distance = 0;
            this.lineGasLevel.Marks.Callout.Draw3D = false;
            this.lineGasLevel.Marks.Callout.Length = 10;
            this.lineGasLevel.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.lineGasLevel.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineGasLevel.Title = "GasLevel";
            // 
            // 
            // 
            this.lineGasLevel.XValues.DataMember = "X";
            this.lineGasLevel.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineGasLevel.YValues.DataMember = "Y";
            // 
            // lineGasPress
            // 
            // 
            // 
            // 
            this.lineGasPress.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.lineGasPress.ColorEach = false;
            // 
            // 
            // 
            this.lineGasPress.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineGasPress.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineGasPress.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineGasPress.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineGasPress.Marks.Callout.Distance = 0;
            this.lineGasPress.Marks.Callout.Draw3D = false;
            this.lineGasPress.Marks.Callout.Length = 10;
            this.lineGasPress.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.lineGasPress.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineGasPress.Title = "GasPress";
            // 
            // 
            // 
            this.lineGasPress.XValues.DataMember = "X";
            this.lineGasPress.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineGasPress.YValues.DataMember = "Y";
            // 
            // lineMAPPress
            // 
            // 
            // 
            // 
            this.lineMAPPress.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
            this.lineMAPPress.ColorEach = false;
            // 
            // 
            // 
            this.lineMAPPress.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(76)))), ((int)(((byte)(84)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineMAPPress.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineMAPPress.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineMAPPress.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineMAPPress.Marks.Callout.Distance = 0;
            this.lineMAPPress.Marks.Callout.Draw3D = false;
            this.lineMAPPress.Marks.Callout.Length = 10;
            this.lineMAPPress.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.lineMAPPress.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineMAPPress.Title = "MAPPress";
            // 
            // 
            // 
            this.lineMAPPress.XValues.DataMember = "X";
            this.lineMAPPress.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineMAPPress.YValues.DataMember = "Y";
            // 
            // linePetrol
            // 
            // 
            // 
            // 
            this.linePetrol.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(107)))));
            this.linePetrol.ColorEach = false;
            // 
            // 
            // 
            this.linePetrol.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.linePetrol.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.linePetrol.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.linePetrol.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.linePetrol.Marks.Callout.Distance = 0;
            this.linePetrol.Marks.Callout.Draw3D = false;
            this.linePetrol.Marks.Callout.Length = 10;
            this.linePetrol.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.linePetrol.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.linePetrol.Title = "Petrol";
            // 
            // 
            // 
            this.linePetrol.XValues.DataMember = "X";
            this.linePetrol.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.linePetrol.YValues.DataMember = "Y";
            // 
            // lineRPM
            // 
            // 
            // 
            // 
            this.lineRPM.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(123)))), ((int)(((byte)(99)))));
            this.lineRPM.ColorEach = false;
            // 
            // 
            // 
            this.lineRPM.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(62)))), ((int)(((byte)(50)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRPM.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineRPM.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineRPM.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineRPM.Marks.Callout.Distance = 0;
            this.lineRPM.Marks.Callout.Draw3D = false;
            this.lineRPM.Marks.Callout.Length = 10;
            this.lineRPM.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.lineRPM.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineRPM.Title = "RPM";
            // 
            // 
            // 
            this.lineRPM.XValues.DataMember = "X";
            this.lineRPM.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineRPM.YValues.DataMember = "Y";
            // 
            // lineTempGas
            // 
            // 
            // 
            // 
            this.lineTempGas.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
            this.lineTempGas.ColorEach = false;
            // 
            // 
            // 
            this.lineTempGas.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(4)))), ((int)(((byte)(7)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineTempGas.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineTempGas.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineTempGas.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineTempGas.Marks.Callout.Distance = 0;
            this.lineTempGas.Marks.Callout.Draw3D = false;
            this.lineTempGas.Marks.Callout.Length = 10;
            this.lineTempGas.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.lineTempGas.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineTempGas.Title = "TempGas";
            // 
            // 
            // 
            this.lineTempGas.XValues.DataMember = "X";
            this.lineTempGas.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineTempGas.YValues.DataMember = "Y";
            // 
            // lineTempRed
            // 
            // 
            // 
            // 
            this.lineTempRed.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(192)))), ((int)(((byte)(93)))));
            this.lineTempRed.ColorEach = false;
            // 
            // 
            // 
            this.lineTempRed.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(96)))), ((int)(((byte)(46)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineTempRed.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineTempRed.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineTempRed.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineTempRed.Marks.Callout.Distance = 0;
            this.lineTempRed.Marks.Callout.Draw3D = false;
            this.lineTempRed.Marks.Callout.Length = 10;
            this.lineTempRed.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.lineTempRed.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineTempRed.Title = "TempRed";
            // 
            // 
            // 
            this.lineTempRed.XValues.DataMember = "X";
            this.lineTempRed.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineTempRed.YValues.DataMember = "Y";
            // 
            // myMenuStrip1
            // 
            this.myMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myMenuStrip1.Location = new System.Drawing.Point(2, 0);
            this.myMenuStrip1.Name = "myMenuStrip1";
            this.myMenuStrip1.ShowCloseButton = true;
            this.myMenuStrip1.ShowConnictMenuButton = true;
            this.myMenuStrip1.ShowGraphMenuButton = false;
            this.myMenuStrip1.ShowMinButton = true;
            this.myMenuStrip1.Size = new System.Drawing.Size(885, 54);
            this.myMenuStrip1.TabIndex = 0;
            // 
            // RealTimeGraphForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 734);
            this.Controls.Add(this.myMenuStrip1);
            this.Controls.Add(this.tChart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealTimeGraphForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealTimeGraphForm";
            this.Load += new System.EventHandler(this.RealTimeGraphForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.MyMenuStrip myMenuStrip1;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Line lineGas;
        private Steema.TeeChart.Styles.Line lineGasLevel;
        private Steema.TeeChart.Styles.Line lineGasPress;
        private Steema.TeeChart.Styles.Line lineMAPPress;
        private Steema.TeeChart.Styles.Line linePetrol;
        private Steema.TeeChart.Styles.Line lineRPM;
        private Steema.TeeChart.Styles.Line lineTempGas;
        private Steema.TeeChart.Styles.Line lineTempRed;
    }
}