using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IGT.UI.Client
{
    /// <summary>
    /// 配置帮助类
    /// </summary>
    class ConfigHelper
    {
        /// <summary>
        /// 获取配置项
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>配置项</returns>
        public String this[String key]
        {
            get { return Configs[key]; }
        }
        /// <summary>
        /// 加载配置
        /// </summary>
        public void Load()
        {
            Configs=new Dictionary<string,string>();
            using (var stream=new System.IO.StreamReader(GetPath(),Encoding.UTF8))
            {
                char[] split={'='};
                do
                {
                    string line = stream.ReadLine().Trim();
                    if (line.Length <2 || line.StartsWith("#")) continue;
                    var temp=line.Split(split,2);
                    Configs.Add(temp[0].Trim(), temp[1].Trim());
                } while (!stream.EndOfStream);
            }
        }
        /// <summary>
        /// 保存配置
        /// </summary>
        public void Save()
        {
            using (var stream=new System.IO.StreamWriter(GetPath(),false,Encoding.UTF8))
            {
                foreach (var item in Configs)
                {
                    stream.Write(item.Key);
                    stream.Write('=');
                    stream.Write(item.Value);
                    stream.WriteLine();
                }
            }
        }
        private string GetPath()
        {
            return String.Format("{0}{1}{2}", System.IO.Directory.GetCurrentDirectory()
                , System.IO.Path.DirectorySeparatorChar
                , "Config.txt");
        }
        /// <summary>
        /// 所有配置项
        /// </summary>
        public Dictionary<String, string> Configs { get; private set; }
    }
}
