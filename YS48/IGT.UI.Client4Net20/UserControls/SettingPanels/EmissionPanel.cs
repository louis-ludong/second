using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class EmissionPanel : UserControl,ISettingPanel,Service.Language.IMultLang
    {
        public EmissionPanel()
        {
            InitializeComponent();
            ApplyLang();
        }
        public void numu_ValueChanged(object sender,EventArgs e)
        {
            if (Init) return;
            var numu = sender as NumericUpDown;
            switch (numu.Name)
            {
                case "numu1Hight":
                    Services.Stroe.ECUSetting.Lambda1HV = Convert.ToSingle(numu1Hight.Value);
                    break;
                case "numu1Low":
                    Services.Stroe.ECUSetting.Lambda1LV = Convert.ToSingle(numu1Low.Value);
                    break;
                case "numu2Hight":
                    Services.Stroe.ECUSetting.Lambda2HV = Convert.ToSingle(numu2Hight.Value);
                    break;
                case "numu2Low":
                    Services.Stroe.ECUSetting.Lambda2LV = Convert.ToSingle(numu2Low.Value);
                    break;
                case "numuDealy":
                    Services.Stroe.ECUSetting.LambdaDelay = Convert.ToInt32(numuDealy.Value);
                    break;
                case "numuNumber":
                    Services.Stroe.ECUSetting.LambdaInjectNum = Convert.ToInt32(numuNumber.Value);
                    break;
                default:
                    return;
            }
            Services.Stroe.SaveChanges();
        }
        #region ISettingPanel 成员


        public void ShowData()
        {
            Init = true;
            FixOverData();
            numu1Hight.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda1HV);
            numu1Low.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda1LV);
            numu2Hight.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda2HV);
            numu2Low.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.Lambda2LV);
            numuDealy.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.LambdaDelay);
            numuNumber.Value = Convert.ToDecimal(Services.Stroe.ECUSetting.LambdaInjectNum);
            Init = false;
        }
        void FixOverData()
        {
            bool change = Services.Stroe.ECUSetting.Lambda1HV > Convert.ToSingle(numu1Hight.Maximum) || Services.Stroe.ECUSetting.Lambda1HV < Convert.ToSingle(numu1Hight.Minimum) ||
            Services.Stroe.ECUSetting.Lambda1LV > Convert.ToSingle(numu1Low.Maximum) || Services.Stroe.ECUSetting.Lambda1LV < Convert.ToSingle(numu1Low.Minimum) ||
            Services.Stroe.ECUSetting.Lambda2HV > Convert.ToSingle(numu2Hight.Maximum) || Services.Stroe.ECUSetting.Lambda2HV < Convert.ToSingle(numu2Hight.Minimum) ||
            Services.Stroe.ECUSetting.Lambda2LV > Convert.ToSingle(numu2Low.Maximum) || Services.Stroe.ECUSetting.Lambda2LV < Convert.ToSingle(numu2Low.Minimum) ||
            Services.Stroe.ECUSetting.LambdaDelay > Convert.ToInt32(numuDealy.Maximum) || Services.Stroe.ECUSetting.LambdaDelay < Convert.ToInt32(numuDealy.Minimum) ||
            Services.Stroe.ECUSetting.LambdaInjectNum > Convert.ToInt32(numuNumber.Maximum) || Services.Stroe.ECUSetting.LambdaInjectNum < Convert.ToInt32(numuNumber.Minimum);
            if (Services.Stroe.ECUSetting.Lambda1HV > Convert.ToSingle(numu1Hight.Maximum))
                Services.Stroe.ECUSetting.Lambda1HV = Convert.ToSingle(numu1Hight.Maximum);
            if (Services.Stroe.ECUSetting.Lambda1HV < Convert.ToSingle(numu1Hight.Minimum))
                Services.Stroe.ECUSetting.Lambda1HV = Convert.ToSingle(numu1Hight.Minimum);
            if (Services.Stroe.ECUSetting.Lambda1LV > Convert.ToSingle(numu1Low.Maximum))
                Services.Stroe.ECUSetting.Lambda1LV = Convert.ToSingle(numu1Low.Maximum);
            if (Services.Stroe.ECUSetting.Lambda1LV < Convert.ToSingle(numu1Low.Minimum))
                Services.Stroe.ECUSetting.Lambda1LV = Convert.ToSingle(numu1Low.Minimum);
            if (Services.Stroe.ECUSetting.Lambda2HV > Convert.ToSingle(numu2Hight.Maximum))
                Services.Stroe.ECUSetting.Lambda2HV = Convert.ToSingle(numu2Hight.Maximum);
            if (Services.Stroe.ECUSetting.Lambda2HV < Convert.ToSingle(numu2Hight.Minimum))
                Services.Stroe.ECUSetting.Lambda2HV = Convert.ToSingle(numu2Hight.Minimum);
            if (Services.Stroe.ECUSetting.Lambda2LV > Convert.ToSingle(numu2Low.Maximum))
                Services.Stroe.ECUSetting.Lambda2LV = Convert.ToSingle(numu2Low.Maximum);
            if (Services.Stroe.ECUSetting.Lambda2LV < Convert.ToSingle(numu2Low.Minimum))
                Services.Stroe.ECUSetting.Lambda2LV = Convert.ToSingle(numu2Low.Minimum);
            if (Services.Stroe.ECUSetting.LambdaDelay > Convert.ToInt32(numuDealy.Maximum))
                Services.Stroe.ECUSetting.LambdaDelay = Convert.ToInt32(numuDealy.Maximum);
            if (Services.Stroe.ECUSetting.LambdaDelay < Convert.ToInt32(numuDealy.Minimum))
                Services.Stroe.ECUSetting.LambdaDelay = Convert.ToInt32(numuDealy.Minimum);
            if (Services.Stroe.ECUSetting.LambdaInjectNum > Convert.ToInt32(numuNumber.Maximum))
                Services.Stroe.ECUSetting.LambdaInjectNum = Convert.ToInt32(numuNumber.Maximum);
            if (Services.Stroe.ECUSetting.LambdaInjectNum < Convert.ToInt32(numuNumber.Minimum))
                Services.Stroe.ECUSetting.LambdaInjectNum = Convert.ToInt32(numuNumber.Minimum);
            if (change)
                Services.Stroe.SaveChanges();
        }
        public void HandlerRealyTimeData(Models.Feedback.RealTimeData model) { }

        #endregion

        #region IMultLang 成员

        public void ApplyLang()
        {
            Init = true;
            FontFamily fontFamily = this.Font.FontFamily;
            try
            {
                fontFamily = new FontFamily(Services.Lang.CurrentLang.Font);
            }
            catch (Exception) { }
            lab1Hight.Font = new Font(fontFamily, lab1Hight.Font.Size);
            lab1Low.Font = new Font(fontFamily, lab1Low.Font.Size);
            lab2Hight.Font = new Font(fontFamily, lab2Hight.Font.Size);
            lab2Low.Font = new Font(fontFamily, lab2Low.Font.Size);
            labDealy.Font = new Font(fontFamily, labDealy.Font.Size);
            labNumber.Font = new Font(fontFamily, labNumber.Font.Size);

            var word = Services.Lang.CurrentWords;
            lab1Hight.Text = word["310_2"];
            lab1Low.Text = word["310_3"];
            lab2Hight.Text = word["310_2"];
            lab2Low.Text = word["310_3"];
            labDealy.Text = word["310_4"];
            labNumber.Text = word["310_5"];


            Init = false;
        }

        #endregion
        bool Init = false;
    }
}
