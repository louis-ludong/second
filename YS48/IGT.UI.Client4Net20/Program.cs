using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sw.Start();
            Services.InitLang();
            if (args.Length > 0)
            {
                foreach (var item in args)
                {
                    if (item.ToLower().StartsWith("wait-".ToLower()))
                    {
                        string waitTime= item.Split('-')[1];
                        System.Threading.Thread.Sleep(Convert.ToInt32(waitTime));
                    }
                }
            }
            //var listener = new System.Diagnostics.TextWriterTraceListener(
            //    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            //    +"\\NPDebug.log");
            //System.Diagnostics.Debug.Listeners.Add(listener);
            //System.Diagnostics.Debug.AutoFlush = true;
            //System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("hh:mm:ss yyyy-MM-dd"), "Start");
            //Application.ThreadException += Application_ThreadException;
            Application.Run(new LaunchForm());
            sw.Stop();
            //System.Diagnostics.Trace.Flush();
        }

        public static long RunningMilliseconds
        {
            get { return sw.ElapsedMilliseconds; }
        }
        private static System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("No Handler Exception On Application Running");
            System.Diagnostics.Trace.Indent();
            System.Diagnostics.Trace.WriteLine("Source:{0}", e.Exception.Source);
            System.Diagnostics.Trace.WriteLine("StackTrace:{0}", e.Exception.StackTrace);
            System.Diagnostics.Trace.WriteLine("Message:{0}", e.Exception.Message);
            System.Diagnostics.Trace.Unindent();
            String tip;
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLower() == "zh-CN".ToLower())
                tip = "运行期间发生错误，是否重启程序?";
            else
                tip = "An error occurred during operation, Restart program?";
            if (MessageBox.Show(tip, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
                psi.FileName = Application.ExecutablePath;
                psi.Verb = "runas";
                System.Diagnostics.Process.Start(psi);
            }
            IsException = true;
            Application.Exit();
        }
        public static bool IsException = false;
    }
}
