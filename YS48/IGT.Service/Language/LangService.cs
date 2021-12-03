using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
namespace IGT.Service.Language
{
    /// <summary>
    /// 多语言服务
    /// </summary>
    public class LangService
    {
        /// <summary>
        /// 创建多语言服务
        /// </summary>
        /// <param name="dir">语言文件目录</param>
        /// <param name="ver">要加载的版本</param>
        public LangService(string dir,string ver)
        {
            this.LangueDir = dir;
            this.Ver = ver;
            InitList();
        }
        /// <summary>
        /// 设置当前语言
        /// </summary>
        /// <param name="lang">要使用的语言的信息</param>
        public void SetCurrentWords(LangInfo lang)
        {
            CurrentWords = new Dictionary<string, string>();
            CurrentLang = lang;
            using (var sr = new StreamReader(CurrentLang.FileFullName, System.Text.Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line)
                        || line.StartsWith("//"))
                        continue;
                    var temp = line.Split('=');
                    switch (temp[0])
                    {
                        case "FileVersion":
                        case "Language":
                        case "LanguageID":
                        case "Font":
                            break;
                        default:
                            currentWord.Add(temp[0], temp[1]);
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// 设置当前语言
        /// </summary>
        /// <param name="fileFullName">语言文件完整名称</param>
        public void SetCurrentWords(String fileFullName)
        {
            CurrentWords = new Dictionary<string, string>();
            var lang = LangList.SingleOrDefault(m => m.FileFullName == fileFullName);
            if (lang == null) throw new ArgumentException("fileFullName不在LangList中");
            SetCurrentWords(lang);
        }
        /// <summary>
        /// 初始化语言列表
        /// </summary>
        private void InitList()
        {
            String path =System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(),LangueDir);
            String[] flies = System.IO.Directory.GetFiles(path,"*.lng");
            List<LangInfo> list = new List<LangInfo>();
            foreach (var file in flies)
            {
                using (var sr=new StreamReader(file,System.Text.Encoding.UTF8))
                {
                    int flagCount = 0;
                    var info = new LangInfo();
                    info.FileFullName = file;
                    info.LCID = -1;
                    do
                    {
                        string line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line)
                            || line.StartsWith("//"))
                            continue;
                        var temp = line.Split('=');
                        switch (temp[0])
                        {
                            case "FileVersion":
                                if (temp[1] == Ver) flagCount++;
                                break;
                            case "Language":
                                info.DisplayName = temp[1];
                                flagCount++;
                                break;
                            case "LanguageID":
                                info.LCID = int.Parse(temp[1]);
                                flagCount++;
                                break;
                            case "Font":
                                info.Font = temp[1];
                                flagCount++;
                                break;
                            default:
                                break;
                        }
                    } while (flagCount < 4 && !sr.EndOfStream);
                    if (flagCount == 4)
                        list.Add(info);
                }
            }
            LangList = list;

        }

        /// <summary>
        /// 语言文件目录
        /// </summary>
        public String LangueDir { get;private set; }
        /// <summary>
        /// 当前使用的语言字典
        /// </summary>
        public Dictionary<String, String> CurrentWords{get{return currentWord;}private set{currentWord = value;}}
        /// <summary>
        /// 当前语言信息
        /// </summary>
        public LangInfo CurrentLang { get; private set; }
        /// <summary>
        /// 语言列表
        /// </summary>
        public List<LangInfo> LangList { get; private set; }
        /// <summary>
        /// 版本
        /// </summary>
        public String Ver { get; set; }
        Dictionary<String, String> currentWord;
    }
    /// <summary>
    /// 语言信息
    /// </summary>
    public class LangInfo
    {
        /// <summary>
        /// 语言文件完整名称
        /// </summary>
        public String FileFullName { get; set; }
        /// <summary>
        /// LCID
        /// </summary>
        public int LCID { get; set; }
        /// <summary>
        /// 用于显示的友好名称
        /// </summary>
        public String DisplayName { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        public String Ver { get; set; }

        /// <summary>
        /// 字体
        /// </summary>
        public string Font { get; set; }
        /// <summary>
        /// 相对于标准字体大小的偏移
        /// </summary>
        public float FontSizeOffset { get; set; }
    }
}
