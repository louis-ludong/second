using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace IGT.UI.Client
{
    /// <summary>
    /// 服务类
    /// </summary>
    class Services
    {
        private static ThemeService _ThemeService;

        /// <summary>
        /// 主题服务
        /// </summary>
        public static ThemeService Theme
        {
            get
            {
                if (_ThemeService == null)
                {
                    _ThemeService = new ThemeService();
                }
                return _ThemeService;
            }
        }

        private static RealyDataPre _RealyDataPre;

        /// <summary>
        /// 预加载的实时数据
        /// </summary>
        public static RealyDataPre RealyDataPre
        {
            get
            {
                if (_RealyDataPre == null)
                    _RealyDataPre = new RealyDataPre(Device);
                return _RealyDataPre;
            }
        }

        /// <summary>
        /// 页面动作队列
        /// </summary>
        public static Queue<Actions> ActionMsg
        {
            get
            {
                if (_ActionMsg == null) _ActionMsg = new Queue<Actions>();
                return _ActionMsg;
            }
        }
        /// <summary>
        /// 下位机数据
        /// </summary>
        public static Service.Storage.PLCData Stroe
        {
            get
            {
                if (_Stroe == null)
                    _Stroe = new Service.Storage.PLCData(Device,
                        System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "DefaultSetting.xml"));
                return _Stroe;
            }
        }
        /// <summary>
        /// 下位机设备
        /// </summary>
        public static Service.PLC.Device Device
        {
            get
            {
                if (_Device == null)
                {
                    _Device = new Service.PLC.Device();
                    _Device.ChangeTaskState(true);
                }
                return _Device;
            }
        }
        /// <summary>
        /// 语言服务
        /// </summary>
        public static Service.Language.LangService Lang
        {
            get
            {
                if (_Lang == null)
                    InitLang();
                return _Lang;
            }
        }

        /// <summary>
        /// 初始化语言服务
        /// </summary>
        public static void InitLang()
        {
            string dir = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Properties.Settings.Default.LanguageDir);
            _Lang = new Service.Language.LangService(dir, "1.0");
            Service.Language.LangInfo lang = null;
            if (Properties.Settings.Default.LangNotSet
                || Lang.LangList.SingleOrDefault(m => m.FileFullName.EndsWith(Properties.Settings.Default.Language)) == null)
            {
                lang = _Lang.LangList.SingleOrDefault(m => m.LCID != -1 && m.LCID == System.Threading.Thread.CurrentThread.CurrentUICulture.LCID);
                if (lang == null) lang = _Lang.LangList.SingleOrDefault(m => m.LCID == 1033);//默认语言
                Properties.Settings.Default.Language = System.IO.Path.GetFileName(lang.FileFullName);
                Properties.Settings.Default.LangNotSet = false;
                Properties.Settings.Default.Save();
            }
            if (lang == null)
            {
                lang = _Lang.LangList.SingleOrDefault(m => m.FileFullName.EndsWith(Properties.Settings.Default.Language));
            }
            _Lang.SetCurrentWords(lang);
        }
        static Service.PLC.Device _Device;
        static Service.Language.LangService _Lang;
        static Service.Storage.PLCData _Stroe;
        static Queue<Actions> _ActionMsg;
    }
}
