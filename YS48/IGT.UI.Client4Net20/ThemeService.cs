using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    /// <summary>
    /// 主题服务
    /// </summary>
    class ThemeService
    {
        /// <summary>
        /// 实例化
        /// </summary>
        public ThemeService()
        {
            ConfigHelper cfh = new ConfigHelper();
            cfh.Load();
            FormBorderColor = ColorTranslator.FromHtml(cfh.Configs["FormBorderColor"]);
            CommonButtonBackColor = ColorTranslator.FromHtml(cfh.Configs["CommonButtonBackColor"]);
            CarSettingMenuNormalBackColor = ColorTranslator.FromHtml(cfh.Configs["CarSettingMenuNormalBackColor"]);
            CarSettingMenuSelectedBackColor = ColorTranslator.FromHtml(cfh.Configs["CarSettingMenuSelectedBackColor"]);
            CarSettingMenuNormalForeColor = ColorTranslator.FromHtml(cfh.Configs["CarSettingMenuNormalForeColor"]);
            CarSettingMenuSelectedForeColor = ColorTranslator.FromHtml(cfh.Configs["CarSettingMenuSelectedForeColor"]);
            RealTimeDataBackColor = ColorTranslator.FromHtml(cfh.Configs["RealTimeDataBackColor"]);
        }
        /// <summary>
        /// 绘制边框
        /// </summary>
        /// <param name="e"></param>
        public void DrawBorder(PaintEventArgs e)
        {
            Pen redPen = new Pen(new SolidBrush(Color .FromArgb (245,130,31)), 12);
            e.Graphics.DrawRectangle(redPen, e.ClipRectangle.Left+6, e.ClipRectangle.Top, e.ClipRectangle.Width -12, e.ClipRectangle.Height-6);
            redPen.Dispose();
        }
        /// <summary>
        /// 窗体边框颜色
        /// </summary>
        public Color FormBorderColor { get; private set; }
        /// <summary>
        /// 通用按钮背景色
        /// </summary>
        public Color CommonButtonBackColor { get; private set; }
        /// <summary>
        /// 车辆设置菜单默认前景色
        /// </summary>
        public Color CarSettingMenuNormalForeColor { get; private set; }
        /// <summary>
        /// 车辆设置菜单选中前景色
        /// </summary>
        public Color CarSettingMenuSelectedForeColor { get; private set; }
        /// <summary>
        /// 车辆设置菜单默认背景色
        /// </summary>
        public Color CarSettingMenuNormalBackColor { get; private set; }
        /// <summary>
        /// 车辆设置菜单选中背景色
        /// </summary>
        public Color CarSettingMenuSelectedBackColor { get; private set; }
        /// <summary>
        /// 实时数据背景色
        /// </summary>
        public Color RealTimeDataBackColor { get;private set; }
    }
}
