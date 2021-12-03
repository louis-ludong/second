using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
namespace IGT.UI.Client
{
    /// <summary>
    /// UI帮助类
    /// </summary>
    public static class UIHelper
    {
        public const int CancelBit_HomePage = 1;
        public const int CancelBit_CarSettingPage = 2;
        public const int CancelBit_DiagnosisPage=3;
        public const int CancelBit_RealyTimeDataPage = 4;
        public const int CancelBit_AutoCalibPage = 5;
        public const int CancelBit_OBDErrors = 6;
        /// <summary>
        /// 在UI线程上调用指定Action
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T InvokeIfRequired<T>(this T source, Action<T> action)
        where T : Control
        {
            try
            {
                if (!source.InvokeRequired)
                    action(source);
                else
                    source.Invoke(new Action(() => action(source)));
                return source;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error on 'InvokeIfRequired': {0}", ex.Message);
                //
                //throw new Exception(ex.Message);
                //
                return source;
            }
        }
        /// <summary>
        /// 在UI线程上异步调用指定Action
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T BeginInvokeIfRequired<T>(this T source, Action<T> action)
        where T : Control
        {
            try
            {
                if (!source.InvokeRequired)
                    action(source);
                else
                    source.BeginInvoke(new Action(() => action(source)));
                return source;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write("Error on 'BeginInvokeIfRequired': {0}", ex.Message);
                //
                //throw new Exception(ex.Message);
                //
                return source;
            }
        }
        /// <summary>
        /// 打开上下文菜单
        /// </summary>
        /// <param name="control"></param>
        /// <param name="menuStrip"></param>
        public static void OpenContextMenu(this Control control, ContextMenuStrip menuStrip)
        {
            var cP = control.PointToScreen(control.Location);
            var point = new Point(cP.X, cP.Y + control.ClientSize.Height+3);
            menuStrip.Show(point);
        }
        /// <summary>
        /// 打开上下文菜单
        /// </summary>
        /// <param name="control"></param>
        /// <param name="menuStrip"></param>
        /// <param name="onflowPanel"></param>
        public static void OpenContextMenu(this Control control, ContextMenuStrip menuStrip,bool onflowPanel)
        {
            if (!onflowPanel) { control.OpenContextMenu(menuStrip); return; }
            var cP = control.FindForm().PointToScreen(control.Location);
            var point = new Point(cP.X, cP.Y + control.ClientSize.Height+3);
            menuStrip.Show(point);
        }

        /// <summary>
        /// 为窗体设定设定通用设置
        /// </summary>
        /// <param name="form"></param>
        public static void CommonSet(Form form)
        {
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "ICON.ico");
            form.Icon = new Icon(path);
        }

        /// <summary>
        /// 显示ECU升级窗体
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static bool ShowUpECUForm(Form form)
        {
            return ShowUpECUForm(form,(sender,e)=>form.Show());
        }
        /// <summary>
        /// 显示ECU升级窗体
        /// </summary>
        /// <param name="form"></param>
        /// <param name="onUpECUFormClosed"></param>
        /// <returns></returns>
        public static bool ShowUpECUForm(Form form,FormClosedEventHandler onUpECUFormClosed)
        {
            bool open = false;
            OpenFileDialog ofd2 = new OpenFileDialog();
            //ofd2.Filter = "A8 Firmware Files|*.fwa";
            ofd2.Filter = "L48 Firmware Files|*.fwn";
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                Service.PLC.UpData data;
                if (Service.PLC.UpData.FromFile(ofd2.FileName, out data))
                {
                    UpdateECUForm uef = new UpdateECUForm(data);
                    uef.FormClosed += (p1, p2) => onUpECUFormClosed(p1, p2);
                    form.Hide();
                    uef.Show();
                    open= true;
                }
                else
                {
                    MessageBox.Show(Services.Lang.CurrentWords["4"], "");
                }
            }
            return open;
        }
        public delegate void UIINvkoeParam1<T>(T p1);
        public delegate void UIInvoke();

    }

    class RecoverWarper : IDisposable
    {

        public static void ShowRecords()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "txt (*.txt)|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var dic = new Dictionary<double, Models.Feedback.RealTimeData>();
                using (var stream = new System.IO.StreamReader(ofd.FileName))
                {
                    String line = stream.ReadLine();
                    do
                    {
                        var temp = line.Split(';');
                        var model = new Models.Feedback.RealTimeData();
                        model.GasesTime = float.Parse(temp[1]);
                        model.GasLevel = float.Parse(temp[2]);
                        model.GasPress = float.Parse(temp[3]);
                        model.MAPPress = float.Parse(temp[4]);
                        model.PetrolsTime = float.Parse(temp[5]);
                        model.RPM = int.Parse(temp[6]);
                        model.TempGas = int.Parse(temp[7]);
                        model.TempRed = int.Parse(temp[8]);
                        dic.Add(double.Parse(temp[0]), model);
                        line = stream.ReadLine();
                    } while (!String.IsNullOrEmpty(line));
                }
                RealTimeGraphForm rtgf = new RealTimeGraphForm(dic);
                rtgf.Show();
            }
        }

        public void Start()
        {
            Services.Device.RealyTimeDataGot += Device_RealyTimeDataGot;
            if (Records == null)
                Records = new Dictionary<double, Models.Feedback.RealTimeData>();
            else
                Records.Clear();
            System.Threading.Interlocked.CompareExchange(ref Flag_IsRecording, 1, 0);
        }

        void Device_RealyTimeDataGot(object sender, Service.PLC.ModelGotEventArg<Models.Feedback.RealTimeData> e)
        {
            if (Flag_IsRecording == 0) return;
            Record(e.Data);
        }

        public void End()
        {
            Services.Device.RealyTimeDataGot -= Device_RealyTimeDataGot;
            System.Threading.Interlocked.CompareExchange(ref Flag_IsRecording, 0, 1);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt (*.txt)|*.txt";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveRecords(sfd.FileName);
            }
        }

        public void Record(Models.Feedback.RealTimeData model)
        {
            if (rStartTime == null) rStartTime = DateTime.Now;
            Records.Add((DateTime.Now - rStartTime.Value).TotalMilliseconds, model);
        }


        public void Dispose()
        {
            System.Threading.Interlocked.CompareExchange(ref Flag_IsRecording, 0, 1);
            Records.Clear();
        }

        void SaveRecords(String fileName)
        {
            using (var stream = new System.IO.StreamWriter(fileName))
            {
                foreach (var item in Records)
                {
                    stream.WriteLine(String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};"
                        , item.Key, item.Value.GasesTime, item.Value.GasLevel, item.Value.GasPress, item.Value.MAPPress
                        , item.Value.PetrolsTime, item.Value.RPM, item.Value.TempGas, item.Value.TempRed));
                }
            }
        }
        Dictionary<double, Models.Feedback.RealTimeData> Records
        {
            get
            {
                if (records == null) records = new Dictionary<double, Models.Feedback.RealTimeData>();
                return records;
            }
            set { records = value; }
        }
        int Flag_IsRecording=0;
        public bool IsRecording { get { return Flag_IsRecording == 1; } }
        DateTime? rStartTime = null;
        Dictionary<double, Models.Feedback.RealTimeData> records;
    }

    class PointMoveHelper
    {

        #region Untils
        public static void MovePoints(Steema.TeeChart.Styles.Series series, UIModels.PointD p1, UIModels.PointD p2)
        {
            int startIndex =Convert.ToInt32(p1.X*10);
            int endIndex = Convert.ToInt32(p2.X * 10);
            if (startIndex < 0 &&endIndex<0&& endIndex >= series.YValues.Count) return;
            p1.Y = Math.Round(p1.Y, 0);
            p2.Y = Math.Round(p2.Y, 0);
            int pCount = endIndex - startIndex;
            double stepY = (p2.Y - p1.Y) / pCount;
            for (int index = startIndex, i = 0; index < endIndex; index++, i++)
            {
                series.YValues[index] = Math.Round(p1.Y + stepY * i);
            }
            series.YValues[endIndex] = p2.Y;
        }
        public static bool TryFindValueIndex(double xRaw, double[] xs, out int index)
        {
            bool get = false;
            for (index = 0; index < xs.Length; index++)
            {
                double x = xs[index];
                if (x - 0.4 < xRaw && x + 0.4 > xRaw)
                {
                    get = true;
                    break;
                }
            }
            return get;
        }
        #endregion
    }
}
