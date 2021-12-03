using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class DiagramPanel : UserControl, ISettingPanel, Service.Language.IMultLang
    {
        MAPCalibrationSettingPanel mapControls;
        TempCorrectionSettingsPanel tempControls;
        public DiagramPanel()
        {
            InitializeComponent();
            ApplyLang();
            //SetChartStyle();
            mapControls = new MAPCalibrationSettingPanel();
            tempControls = new TempCorrectionSettingsPanel();
            mapControls.Dock = DockStyle.Fill;
            this.tabPage0.Controls.Add(mapControls);
            this.tabPage3.Controls.Add(tempControls);
            mapControls.Show();
        }
        //void MAPCalibrationParams_OnTiji3DCurveChanged(Models.Feedback.Tiji3DCurve data)
        //{
        //    if (IsInit == false && loadFinsh && data != null)
        //        this.BeginInvokeIfRequired(f => f.HandleTiji3DCurveGot(data));
        //}
        //void MAPCalibrationParams_OnTiji2DCurveChanged(Models.Feedback.Tiji2DCurve data)
        //{
        //    if (IsInit == false && loadFinsh && data != null)
        //        this.BeginInvokeIfRequired(f => f.HandleTiji2DCurveGot(data));

        //}
        bool loadFinsh = false;
        //private void HandleTiji2DCurveGot(Models.Feedback.Tiji2DCurve model)
        //{
        //    if (tabControl1.SelectedIndex == 2)
        //    {
        //        Show2DCurve(model);
        //    }
        //}
        //private void HandleTiji3DCurveGot(Models.Feedback.Tiji3DCurve model)
        //{
        //    if (tabControl1.SelectedIndex == 1
        //        && (ddlChart.SelectedIndex == 1 || ddlChart.SelectedIndex == 2))
        //    {
        //        ShowTijiSurface(model);
        //    }
        //}
        #region ISettingPanel 成员
        public void PanelLoad()
        {
            //Services.Stroe.MAPCalibrationParams.OnTiji2DCurveChanged += MAPCalibrationParams_OnTiji2DCurveChanged;
            //Services.Stroe.MAPCalibrationParams.OnTiji3DCurveChanged += MAPCalibrationParams_OnTiji3DCurveChanged;
            //Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetTiji2DCurve);
            //Services.Device.BeginOnTimeTask(Service.PLC.OnTimeTasks.GetTiji3DCurve);
            loadFinsh = true;
        }
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model)
        {
            if (loadFinsh == false || IsInit == true) return;
            switch (tabControl1.SelectedIndex)
            {
                //case 2:
                //    colorLineV.Value = model.PetrolsTime;
                //    colorLineH.Value = model.MAPPress * 100;
                //    break;
                case 0:
                    mapControls.HandlerRealyTimeData(model);
                    break;
            }
        }
        public void ShowData()
        {
            IsInit = true;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    mapControls.ShowData();
                    break;
                //case 1:
                //    ShowData43D();
                //    break;
                //case 2:
                //    ShowData42D();
                //    break;
                case 1:
                    tempControls.ShowData();
                    break;
                default:
                    break;
            }
            IsInit = false;
        }
        public void PanelUnLoad()
        {
            loadFinsh = false;
            //Services.Stroe.MAPCalibrationParams.OnTiji2DCurveChanged -= MAPCalibrationParams_OnTiji2DCurveChanged;
            //Services.Stroe.MAPCalibrationParams.OnTiji3DCurveChanged -= MAPCalibrationParams_OnTiji3DCurveChanged;
            //Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetTiji2DCurve);
            //Services.Device.EndOnTimeTask(Service.PLC.OnTimeTasks.GetTiji3DCurve);
        }
        #endregion

        //#region 2D
        //private void ShowData42D()
        //{
        //    double x = 0.0;
        //    line1.BeginUpdate();
        //    line1.Clear();
        //    for (int i = 0; i < Services.Stroe.ECUCorrectionParams.CalibrationScale.Length; i++)
        //    {
        //        line1.Add(x, Services.Stroe.ECUCorrectionParams.CalibrationScale[i]);
        //        x = Math.Round(x + 0.1, 1);
        //    }
        //    line1.EndUpdate();

        //    points1.BeginUpdate();
        //    points1.Clear();
        //    points1.Add(0, Services.Stroe.ECUCorrectionParams.CalibrationScale[0], Color.Yellow);
        //    foreach (var item in Services.Stroe.ECUCorrectionParams.LocationX.Distinct().Where(m => m > 0))
        //    {
        //        int yIndex = Convert.ToInt32(item * 10);
        //        points1.Add(item, Services.Stroe.ECUCorrectionParams.CalibrationScale[yIndex], Color.Yellow);
        //    }
        //    points1.Add(25.5, Services.Stroe.ECUCorrectionParams.CalibrationScale[255], Color.Yellow);
        //    points1.EndUpdate();
        //    Show2DCurve();
        //}

        //private void Show2DCurve(Models.Feedback.Tiji2DCurve model=null)
        //{
        //    if (model == null)
        //    {
        //        model = Services.Stroe.MAPCalibrationParams.Tiji2DCurve;
        //    }
        //    pointsGas2D.BeginUpdate();
        //    pointsGas2D.Clear();
        //    for (int i = 15, index = 0; index < 80; i++, index++)
        //    {
        //        var item = model.GasCurve2D[index];
        //        if (item > 0)
        //            pointsGas2D.Add(item, i);
        //    }
        //    pointsGas2D.EndUpdate();

        //    pointsPertol2D.BeginUpdate();
        //    pointsPertol2D.Clear();
        //    for (int i = 15, index = 0; index < 80; i++, index++)
        //    {
        //        var item = model.PetrolCurve2D[index];
        //        if (item > 0)
        //            pointsPertol2D.Add(item, i);
        //    }
        //    pointsPertol2D.EndUpdate();
        //}
        //private void tChart1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (MouseButtons == System.Windows.Forms.MouseButtons.Right && points1.Count < 10 + 2)
        //    {
        //        var xValue = Math.Round(line1.XScreenToValue(e.X), 1);
        //        int pIndex;
        //        if (PointMoveHelper.TryFindValueIndex(xValue, points1.XValues.Value, out pIndex)) return;
        //        var index = line1.XValues.IndexOf(xValue);
        //        if (index > 0)
        //        {
        //            if (curIndex > 0)
        //                points1.Colors[curIndex] = Color.Yellow;
        //            var addIndex = points1.Add(xValue, line1.YValues[index], Color.Red);
        //            curIndex = addIndex;
        //            points1.DrawSeries();
        //            Send10Point();
        //            ShowSelectLocation();
        //        }
        //    }
        //    else if (MouseButtons == System.Windows.Forms.MouseButtons.Left)
        //    {
        //        SelectPoint();
        //    }
        //}


        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (tabControl1.SelectedIndex == 2)
        //    {
        //        if (curIndex >= 0)
        //            ProcessCmdKeyOnSelected(keyData);
        //        else
        //            ProcessCmdKeyOnNoSelected(keyData);
        //        ShowSelectLocation();
        //        return true;
        //    }
        //    else
        //        return base.ProcessCmdKey(ref msg, keyData);
        //}

        //private void ProcessCmdKeyOnNoSelected(Keys keyData)
        //{
        //    switch (keyData)
        //    {
        //        case Keys.Up:
        //            if (Services.Stroe.ECUCorrectionParams.CalibrationScale.Any(m => m >= 200)) return;
        //            line1.BeginUpdate();
        //            points1.BeginUpdate();
        //            for (int i = 0; i < line1.Count; i++)
        //            {
        //                line1[i].Y = line1[i].Y + 1.0;
        //            }
        //            for (int i = 0; i < points1.Count; i++)
        //            {
        //                points1[i].Y = points1[i].Y + 1.0;
        //            }
        //            line1.EndUpdate();
        //            points1.EndUpdate();
        //            Services.Stroe.ECUCorrectionParams.CalibrationScale = line1.YValues.Value.Take(256).Select(m => Convert.ToInt32(m)).ToArray();
        //            Services.Stroe.SaveChanges();
        //            break;
        //        case Keys.Down:
        //            if (Services.Stroe.ECUCorrectionParams.CalibrationScale.Any(m => m <= 0)) return;
        //            line1.BeginUpdate();
        //            points1.BeginUpdate();
        //            for (int i = 0; i < line1.Count; i++)
        //            {
        //                line1[i].Y = line1[i].Y - 1.0;
        //            }
        //            for (int i = 0; i < points1.Count; i++)
        //            {
        //                points1[i].Y = points1[i].Y - 1.0;
        //            }
        //            line1.EndUpdate();
        //            points1.EndUpdate();
        //            Services.Stroe.ECUCorrectionParams.CalibrationScale = line1.YValues.Value.Take(256).Select(m => Convert.ToInt32(m)).ToArray();
        //            Services.Stroe.SaveChanges();
        //            break;
        //    }
        //}
        //private void ProcessCmdKeyOnSelected(Keys keyData)
        //{
        //    var curP = points1[curIndex];
        //    var x = curP.X;
        //    var y = curP.Y;
        //    switch (keyData)
        //    {
        //        case Keys.Up:
        //            y = Math.Round(curP.Y + 1.0, 1);
        //            if (y > 200.0d) y = 200.0d;
        //            curP.Y = y;
        //            if (curIndex > 0)
        //                PointMoveHelper.MovePoints(line1, new UIModels.PointD(points1.XValues[curIndex - 1], points1.YValues[curIndex - 1])
        //                    , new UIModels.PointD(curP.X, curP.Y));
        //            if (curIndex < points1.Count - 1)
        //                PointMoveHelper.MovePoints(line1, new UIModels.PointD(curP.X, curP.Y),
        //                    new UIModels.PointD(points1.XValues[curIndex + 1], points1.YValues[curIndex + 1]));
        //            var temp = line1.YValues.Value.Take(256).Select(m => Convert.ToInt32(m)).ToArray();
        //            Services.Stroe.ECUCorrectionParams.CalibrationScale = temp;
        //            this.SaveChanges();
        //            break;
        //        case Keys.Down:
        //            y = Math.Round(curP.Y - 1.0, 1);
        //            if (y < 0.0d) y = 0.0d;
        //            curP.Y = y;
        //            if (curIndex > 0)
        //                PointMoveHelper.MovePoints(line1, new UIModels.PointD(points1.XValues[curIndex - 1], points1.YValues[curIndex - 1])
        //                    , new UIModels.PointD(curP.X, curP.Y));
        //            if (curIndex < points1.Count - 1)
        //                PointMoveHelper.MovePoints(line1, new UIModels.PointD(curP.X, curP.Y),
        //                    new UIModels.PointD(points1.XValues[curIndex + 1], points1.YValues[curIndex + 1]));
        //            var temp2 = line1.YValues.Value.Take(256).Select(m => Convert.ToInt32(m)).ToArray();
        //            Services.Stroe.ECUCorrectionParams.CalibrationScale = temp2;
        //            this.SaveChanges();
        //            break;
        //        case Keys.Left:
        //            if (curIndex <= 0 || curIndex == points1.Count - 1) break;
        //            x = Math.Round(curP.X - 0.1, 1);
        //            if (curIndex > 0)
        //            {
        //                var tempx = points1.XValues[curIndex - 1];
        //                if (x <= tempx + 0.4)
        //                    x = tempx + 0.4;
        //            }
        //            else if (x < 0.0)
        //                x = 0.0;
        //            curP.X = x;
        //            curP.Y = line1.YValues[Convert.ToInt32(curP.X * 10)];
        //            Send10Point();
        //            break;
        //        case Keys.Right:
        //            if (curIndex <= 0 || curIndex == points1.Count - 1) break;
        //            x = Math.Round(curP.X + 0.1, 1);
        //            if (curIndex < points1.Count)
        //            {
        //                var tempx = points1.XValues[curIndex + 1];
        //                if (x > tempx - 0.4)
        //                    x = tempx - 0.4;
        //            }
        //            else if (x > 25.5)
        //                x = 25.5;
        //            curP.X = x;
        //            curP.Y = line1.YValues[Convert.ToInt32(curP.X * 10)];
        //            Send10Point();
        //            break;
        //        case Keys.Delete:
        //            if (curIndex > 0 && curIndex != points1.Count - 1)
        //            {
        //                points1.Delete(curIndex, 1);
        //                Send10Point();
        //            }
        //            break;
        //        case Keys.Control | Keys.Left:
        //            SelectPoint(curIndex - 1);
        //            break;
        //        case Keys.Control | Keys.Right:
        //            SelectPoint(curIndex + 1);
        //            break;
        //    }
        //}
        //private void SelectPoint()
        //{
        //    int index;
        //    var xs = points1.XValues.Value;
        //    if (PointMoveHelper.TryFindValueIndex(points1.XScreenToValue(tChart1.PointToClient(MousePosition).X), xs, out index))
        //        SelectPoint(index);
        //    else
        //    {
        //        if (curIndex >= 0 && curIndex < points1.Count)
        //        {
        //            points1.BeginUpdate();
        //            points1.Colors[curIndex] = Color.Yellow;
        //            points1.EndUpdate();
        //        }
        //        curIndex = -1;
        //        ShowSelectLocation();
        //    }
        //}
        //private void SelectPoint(int index)
        //{
        //    if (index == curIndex || index < 0 || index >= points1.Count) return;
        //    points1.BeginUpdate();
        //    if (curIndex >= 0)
        //        points1.Colors[curIndex] = Color.Yellow;
        //    curIndex = index;
        //    points1.Colors[curIndex] = Color.Red;
        //    points1.EndUpdate();
        //    ShowSelectLocation();
        //}
        //void Send10Point()
        //{
        //    int index = 0;
        //    for (int i = 1; i < points1.Count - 1; i++, index++)
        //    {
        //        Services.Stroe.ECUCorrectionParams.LocationX[index] = Convert.ToSingle(points1[i].X);
        //    }
        //    for (; index < Services.Stroe.ECUCorrectionParams.LocationX.Count; index++)
        //    {
        //        Services.Stroe.ECUCorrectionParams.LocationX[index] = 0;
        //    }
        //    this.SaveChanges();
        //}
        //void ShowSelectLocation()
        //{
        //    String x = curIndex >= 0 ? points1.XValues[curIndex].ToString("N1") : "";
        //    String y = curIndex >= 0 ? points1.YValues[curIndex].ToString() : "";
        //    labSPointX.Text = String.Format("X:{0}[ms]", x);
        //    labSPointY.Text = string.Format("Y:{0}", y);
        //}
        //#endregion


        //#region 3D

        //private void ShowData43D()
        //{
        //    switch (ddlChart.SelectedIndex)
        //    {
        //        case 0:
        //            ShowMainSurface();
        //            break;
        //        case 1:
        //        case 2:
        //            ShowTijiSurface(Services.Stroe.MAPCalibrationParams.Tiji3DCurve);
        //            break;
        //    }
        //}

        //#region ChartSet
        //private void SetAxes4PG()
        //{
        //    tChart2.Axes.Bottom.Labels.Items.Clear();
        //    tChart2.Axes.Left.Automatic = false;
        //    tChart2.Axes.Bottom.Automatic = false;
        //    tChart2.Axes.Left.Maximum = 25.5;
        //    tChart2.Axes.Left.Minimum = 0.0;
        //    tChart2.Axes.Bottom.Minimum = 0;
        //    tChart2.Axes.Bottom.Maximum = 18;
        //    for (int i = 0; i <= 18; i++)
        //    {
        //        tChart2.Axes.Bottom.Labels.Items.Add(i)
        //            .Text = (10 + i * 5).ToString();
        //    }
        //}

        //private void SetAxes4M()
        //{
        //    tChart2.Axes.Bottom.Labels.Items.Clear();
        //    tChart2.Axes.Left.Automatic = false;
        //    tChart2.Axes.Bottom.Automatic = false;
        //    tChart2.Axes.Left.Maximum = 2.5;
        //    tChart2.Axes.Left.Minimum = 0.0;
        //    tChart2.Axes.Bottom.Minimum = 0;
        //    tChart2.Axes.Bottom.Maximum = 25.5;
        //}

        //private void SetChartStyle()
        //{
        //    // adjust some axes properties...
        //    this.tChart2.Axes.Depth.Visible = true;
        //    this.tChart2.Axes.Depth.Labels.ValueFormat = "#.0";
        //    //this.tChart1.Axes.Depth.Increment = 0.2;
        //    //this.tChart1.Axes.Bottom.Labels.ValueFormat = "#.0";
        //    //this.tChart1.Axes.Bottom.Increment = 0.1;

        //    // visual properties...
        //    this.tChart2.Aspect.Chart3DPercent = 100;
        //    this.tChart2.Aspect.Orthogonal = false;
        //    this.tChart2.Aspect.Perspective = 50;
        //    this.tChart2.Aspect.Rotation = 327;
        //    this.tChart2.Aspect.Elevation = 352;
        //    this.tChart2.Aspect.Zoom = 70;
        //    this.tChart2.Panning.Allow = Steema.TeeChart.ScrollModes.None;//阻止默认的右键拖动
        //    this.tChart2.Zoom.Allow = false;//阻止手动缩放
        //    this.surface1.TimesZOrder = 2;//纵深
        //    points3D1.Pointer.Visible = false;

        //    tChart2.Axes.Depth.Labels.Items.Clear();
        //    tChart2.Axes.Depth.Automatic = false;
        //    tChart2.Axes.Depth.Maximum = 12;
        //    tChart2.Axes.Depth.Minimum = 0;
        //    //tChart1.Axes.Depth.Labels.Font.Color = Color.Red;
        //    for (int i = 0; i <= 12; i++)
        //    {
        //        tChart2.Axes.Depth.Labels.Items.Add(i)
        //            .Text = (i * 500).ToString();
        //    }
        //}

        //private void tChart2_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Right)
        //    {
        //        MouseRightButtonDrop = true;
        //        lastPoint = e.Location;
        //    }
        //}

        //private void tChart2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (MouseRightButtonDrop == false) return;
        //    int moveX = e.X - lastPoint.X;
        //    int moveY = e.Y - lastPoint.Y;
        //    if (Math.Abs(moveX) > 3)
        //    {
        //        int rValue = this.tChart2.Aspect.Rotation - moveX;
        //        if (rValue > 360) rValue = 360;
        //        else if (rValue < 250) rValue = 250;
        //        this.tChart2.Aspect.Rotation = rValue;
        //        lastPoint.X = e.Location.X;
        //    }
        //    if (Math.Abs(moveY) > 3)
        //    {
        //        int eValue = this.tChart2.Aspect.Elevation - moveY;
        //        if (eValue > 360) eValue = 360;
        //        else if (eValue < 270) eValue = 270;
        //        this.tChart2.Aspect.Elevation = eValue;
        //        lastPoint.Y = e.Location.Y;
        //    }
        //}

        //private void tChart2_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Right)
        //        MouseRightButtonDrop = false;
        //}
        //Point lastPoint;
        //bool MouseRightButtonDrop = false;
        //#endregion

        //private void ddlChart_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (IsInit) return;
        //    ShowData43D();
        //}
        //private void ShowTijiSurface(Models.Feedback.Tiji3DCurve model)
        //{
        //    points3D1.Clear();
        //    surface1.Clear();
        //    points3D1.Visible = false;
        //    SetAxes4PG();
        //    for (int i = 0; i <= 18; i++)
        //    {
        //        int value = 10 + i * 5;
        //        tChart2.Axes.Bottom.Labels.Items.Add(i)
        //            .Text = value.ToString();
        //    }
        //    for (int i = 0; i < 8; i++)
        //    {
        //        int z = 1000 + i * 500;
        //        for (int x = 0; x < 18; x++)
        //        {
        //            float y;
        //            if (ddlChart.SelectedIndex == 1)
        //                y = model.PetrolCurve[i][x];
        //            else
        //                y = model.GasCurve[i][x];
        //            //y = rd.Next(25);
        //            if (y == 0) continue;
        //            surface1.Add(x, y, z / 500);
        //        }
        //    }
        //}
        //private void ShowMainSurface()
        //{
        //    points3D1.Clear();
        //    surface1.Clear();
        //    SetAxes4M();
        //    points3D1.Visible = true;
        //    var map = Services.Stroe.MAPCalibrationParams;
        //    var ecuC = Services.Stroe.ECUCorrectionParams;
        //    float[] xs = (new float[] { 0f }).Concat(map.Injection).ToArray();
        //    var ys = ecuC.CalibrationScale.Select(m => m / 100f).ToArray();
        //    var zs = (new int[] { 0 }).Concat(map.RPMs).ToArray();
        //    var offset = map.MAPValues.Select(m => m.Select(m2 => m2 / 100f).ToArray()).ToArray();
        //    System.Diagnostics.Debug.WriteLine("Begin 3D Point");
        //    for (int i = 0; i < zs.Length; i++)
        //    {
        //        int z = zs[i];
        //        for (int j = 0; j < xs.Length; j++)
        //        {
        //            float x = xs[j];
        //            float y = ys[Convert.ToInt32(x * 10)];
        //            float yOffset = 0f;
        //            if (i < offset.Length && j < offset[i].Length)
        //                yOffset = offset[i][j];
        //            surface1.Add(x, y + yOffset, Math.Round(z / 500d, 1));
        //            System.Diagnostics.Debug.WriteLine(String.Format("({0},{1},{2})", x.ToString(), (y + yOffset).ToString(), Math.Round(z / 500d, 1).ToString()));
        //        }
        //    }
        //    System.Diagnostics.Debug.WriteLine("End 3D Point");
        //    for (int i = 0; i < ys.Length; i++)
        //    {
        //        points3D1.Add(i / 10, ys[i]);
        //    }
        //}
        //#endregion


        void SaveChanges()
        {
            if (Program.RunningMilliseconds - timeStamp > 500)
            {
                Services.Stroe.SaveChanges();
                timeStamp = Program.RunningMilliseconds;
            }
        }
        long timeStamp = Program.RunningMilliseconds;
        public void ApplyLang()
        {
            if (this.DesignMode == true) return;
            IsInit = true;
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            //labMultiplier.Font = new Font(fontFamily, labMultiplier.Font.Size);
            //labInjt.Font = new Font(fontFamily, labInjt.Font.Size);
            //labRPM.Font = new Font(fontFamily, labRPM.Font.Size);
            //ddlChart.Font = new Font(fontFamily, ddlChart.Font.Size);
            //tabPage2.Font = new Font(fontFamily, tabPage2.Font.Size);
            //tabPage1.Font = new Font(fontFamily, tabPage1.Font.Size);
            tabPage0.Font = new Font(fontFamily, tabPage0.Font.Size);

            var LangWords = Services.Lang.CurrentWords;
            //tChart1.Axes.Left.Title.Caption = LangWords["308_1"];
            //tChart1.Axes.Bottom.Title.Caption = LangWords["308_2"];
            //tChart1.Axes.Right.Title.Caption = LangWords["308_3"];

            //labMultiplier.Text = LangWords["308_1"];
            //labInjt.Text = LangWords["308_2"];
            //labRPM.Text = LangWords["308_7"];
            //ddlChart.Items.Clear();
            //ddlChart.Items.Add(LangWords["308_4"]);
            //ddlChart.Items.Add(LangWords["308_5"]);
            //ddlChart.Items.Add(LangWords["308_6"]);
            //ddlChart.SelectedIndex = 0;
            //tabPage2.Text = "2D" + LangWords["308_8"];
            //tabPage1.Text = "3D" + LangWords["308_8"];
            tabPage0.Text = LangWords["308_10"];
            tabPage3.Text = LangWords["308_13"];
            //btnClearPetrol.ButtonText = LangWords["308_11"];
            //btnClearGas.ButtonText = LangWords["308_12"];
            IsInit = false;
        }
        int curIndex = -1;
        bool IsInit = false;

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            if (tabControl1.SelectedIndex == 0)
            {
                //tChart1.Focus();
            }
            ShowData();
        }

        void DiagramPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.SaveChanges();
        }

        private void DiagramPanel_Load(object sender, EventArgs e)
        {
            //tChart1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btnClears_Click(object sender, EventArgs e)
        //{
        //    var btn = sender as IGT.UI.Client.VistaButton;
        //    switch (btn.Name)
        //    {
        //        case "btnClearGas":
        //            Services.Device.SendAndRead("SetODBErrorClear", UIHelper.CancelBit_CarSettingPage
        //                , Service.PLC.InstructionSet.SetMAPCalibrationParamsPart1
        //                , Service.PLC.InstructionSet.SetMAPCalibrationParamsPart2_ClearGasCurve);
        //            Services.Device.GetTiji2DCurve();
        //            break;
        //        case "btnClearPetrol":
        //            Services.Device.SendAndRead("SetODBErrorClear", UIHelper.CancelBit_CarSettingPage
        //                , Service.PLC.InstructionSet.SetMAPCalibrationParamsPart1
        //                , Service.PLC.InstructionSet.SetMAPCalibrationParamsPart2_ClearPetrolCurve);
        //            Services.Device.GetTiji2DCurve();
        //            break;
        //    }
        //}
    }
}
