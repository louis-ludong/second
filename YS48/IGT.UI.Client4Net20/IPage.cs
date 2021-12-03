using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.UI.Client
{
    /// <summary>
    /// 表示一个页面
    /// </summary>
    public interface IPage:Service.Language.IMultLang
    {
        /// <summary>
        /// 加载此页
        /// </summary>
        void LoadPage();
        
        /// <summary>
        /// 卸载此页
        /// </summary>
        void UnLoadPage();
        
        /// <summary>
        /// 从连接应用所有改变
        /// </summary>
        void Change4Connect();
        
        /// <summary>
        /// 处理实时数据
        /// </summary>
        /// <param name="model">数据</param>
        void ProcessRealyTimeData(Models.Feedback.RealTimeData model);

        /// <summary>
        /// 处理自动标定信息
        /// </summary>
        /// <param name="model">数据</param>
        void ProcessAutoCalbrationDetails(Models.Feedback.AutoCalibrationDetails model);
        /// <summary>
        /// 处理诊断信息
        /// </summary>
        /// <param name="model">数据</param>
        void ProcessDiagnosisDetails(Models.Feedback.DiagnosisDetails model);
        /// <summary>
        /// 是否就绪
        /// </summary>
        bool IsReadly { get; }
        /// <summary>
        /// 名称
        /// </summary>
        String Text { get; }
        String Name { get; }
        /// <summary>
        /// 转换为System.Windows.Forms.Control
        /// </summary>
        System.Windows.Forms.Control AsControl { get; }
    }

}
