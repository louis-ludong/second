using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    interface ISettingPanel:IDisposable
    {
        void Show();
        void Hide();
        void ShowData();
        void HandlerRealyTimeData(Models.Feedback.RealTimeData model);
    }
}
