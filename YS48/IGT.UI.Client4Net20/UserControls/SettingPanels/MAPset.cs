using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client.UserControls.SettingPanels
{
    public partial class MAPset : Form
    {
        private bool IsInit;
        private bool[] RPMchange;
        private bool[] Timechange;
        private bool Changed;

        public MAPset()
        {

            InitializeComponent();
            RPMchange = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
            Timechange = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
            Changed = false;
            ApplyLang();
           // UIHelper.CommonSet(this);
        }

        private void ApplyLang()
        {
       //   throw new NotImplementedException();
            IsInit = true;
            RPMBox.Text = LangWords["309_27"];
            TimeBox.Text = LangWords["309_28"];
            btnCancel.Text=LangWords["309_32"];;
            btnEnter.Text = LangWords["309_33"]; ;
            textBox1.Text = Store.MAPCalibrationParams.RPMs[0].ToString();
            textBox2.Text = Store.MAPCalibrationParams.RPMs[1].ToString();
            textBox3.Text = Store.MAPCalibrationParams.RPMs[2].ToString();
            textBox4.Text = Store.MAPCalibrationParams.RPMs[3].ToString();
            textBox5.Text = Store.MAPCalibrationParams.RPMs[4].ToString();
            textBox6.Text = Store.MAPCalibrationParams.RPMs[5].ToString();
            textBox7.Text = Store.MAPCalibrationParams.RPMs[6].ToString();
            textBox8.Text = Store.MAPCalibrationParams.RPMs[7].ToString();
            textBox9.Text = Store.MAPCalibrationParams.RPMs[8].ToString();
            textBox10.Text = Store.MAPCalibrationParams.RPMs[9].ToString();
            textBox11.Text = Store.MAPCalibrationParams.RPMs[10].ToString();
            textBox12.Text = Store.MAPCalibrationParams.RPMs[11].ToString();

            textBox13.Text = String.Format("{0:N1}",Store.MAPCalibrationParams.Injection[0]);
            textBox14.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[1]);
            textBox15.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[2]);
            textBox16.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[3]);
            textBox17.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[4]);
            textBox18.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[5]);
            textBox19.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[6]);
            textBox20.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[7]);
            textBox21.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[8]);
            textBox22.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[9]);
            textBox23.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[10]);
            textBox24.Text = String.Format("{0:N1}", Store.MAPCalibrationParams.Injection[11]);
            textBox1.Focus();
            IsInit = false;

        }

        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void Timebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
                    
        }


        //#region GDI+
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);
        //    Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 4);
        //    e.Graphics.DrawRectangle(redPen, 2, 2, this.ClientSize.Width - 4, this.ClientSize.Height - 4);
        //    //e.Graphics.DrawLine(redPen, 829, 0, 829, this.ClientSize.Height - 114);
        //    redPen.Dispose();
        //}
        //#endregion




        Dictionary<String, String> LangWords { get { return Services.Lang.CurrentWords; } }

        public IGT.Service.Storage.PLCData Store { get { return Services.Stroe; } }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool RPMsErr = false;
            bool TimeErr = false;
            if (Changed)
            {
                if (Convert.ToSingle(textBox1.Text) < Convert.ToSingle(textBox2.Text))
                {
                    if (RPMchange[0])
                        Store.MAPCalibrationParams.RPMs[0] = Convert.ToInt32(textBox1.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox2.Text) < Convert.ToSingle(textBox3.Text) && Convert.ToSingle(textBox1.Text) < Convert.ToSingle(textBox2.Text))
                {
                    if (RPMchange[1] )
                        Store.MAPCalibrationParams.RPMs[1] = Convert.ToInt32(textBox2.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox3.Text) < Convert.ToSingle(textBox4.Text) && Convert.ToSingle(textBox2.Text) < Convert.ToSingle(textBox3.Text))
                {
                    if (RPMchange[2])
                        Store.MAPCalibrationParams.RPMs[2] = Convert.ToInt32(textBox3.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox4.Text) < Convert.ToSingle(textBox5.Text) && Convert.ToSingle(textBox3.Text) < Convert.ToSingle(textBox4.Text))
                {
                    if (RPMchange[3])
                        Store.MAPCalibrationParams.RPMs[3] = Convert.ToInt32(textBox4.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox5.Text) < Convert.ToSingle(textBox6.Text) && Convert.ToSingle(textBox4.Text) < Convert.ToSingle(textBox5.Text))
                {
                    if (RPMchange[4])
                        Store.MAPCalibrationParams.RPMs[4] = Convert.ToInt32(textBox5.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox6.Text) < Convert.ToSingle(textBox7.Text) && Convert.ToSingle(textBox5.Text) < Convert.ToSingle(textBox6.Text))
                {
                    if (RPMchange[5])
                        Store.MAPCalibrationParams.RPMs[5] = Convert.ToInt32(textBox6.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox7.Text) < Convert.ToSingle(textBox8.Text) && Convert.ToSingle(textBox6.Text) < Convert.ToSingle(textBox7.Text))
                {
                    if (RPMchange[6])
                        Store.MAPCalibrationParams.RPMs[6] = Convert.ToInt32(textBox7.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox8.Text) < Convert.ToSingle(textBox9.Text) && Convert.ToSingle(textBox7.Text) < Convert.ToSingle(textBox8.Text))
                {
                    if (RPMchange[7])
                        Store.MAPCalibrationParams.RPMs[7] = Convert.ToInt32(textBox8.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox9.Text) < Convert.ToSingle(textBox10.Text) && Convert.ToSingle(textBox8.Text) < Convert.ToSingle(textBox9.Text))
                {
                    if (RPMchange[8])
                        Store.MAPCalibrationParams.RPMs[8] = Convert.ToInt32(textBox9.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox10.Text) < Convert.ToSingle(textBox11.Text) && Convert.ToSingle(textBox9.Text) < Convert.ToSingle(textBox10.Text))
                {
                    if (RPMchange[9])
                        Store.MAPCalibrationParams.RPMs[9] = Convert.ToInt32(textBox10.Text);
                }
                else
                    RPMsErr = true;
                if (Convert.ToSingle(textBox11.Text) < Convert.ToSingle(textBox12.Text) && Convert.ToSingle(textBox10.Text) < Convert.ToSingle(textBox11.Text))
                {
                    if (RPMchange[10])
                        Store.MAPCalibrationParams.RPMs[10] = Convert.ToInt32(textBox11.Text);
                }
                else
                    RPMsErr = true;
                if( Convert.ToSingle(textBox12.Text) > Convert.ToSingle(textBox11.Text))
                {
                    if (RPMchange[11])
                        Store.MAPCalibrationParams.RPMs[11] = Convert.ToInt32(textBox12.Text);
                }
                else
                    RPMsErr = true;





                if (RPMsErr)
                    MessageBox.Show(LangWords["309_29"], LangWords["309_31"], MessageBoxButtons.OK, MessageBoxIcon.Warning);




                if (Convert.ToSingle(textBox13.Text) < Convert.ToSingle(textBox14.Text))
                {
                    if (Timechange[0])
                        Store.MAPCalibrationParams.Injection[0] = Convert.ToSingle(textBox13.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox14.Text) < Convert.ToSingle(textBox15.Text) && Convert.ToSingle(textBox13.Text) < Convert.ToSingle(textBox14.Text))
                {
                   if (Timechange[1]  )
                      Store.MAPCalibrationParams.Injection[1] = Convert.ToSingle(textBox14.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox15.Text) < Convert.ToSingle(textBox16.Text) && Convert.ToSingle(textBox14.Text) < Convert.ToSingle(textBox15.Text))
                {
                    if (Timechange[2])
                        Store.MAPCalibrationParams.Injection[2] = Convert.ToSingle(textBox15.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox16.Text) < Convert.ToSingle(textBox17.Text) && Convert.ToSingle(textBox15.Text) < Convert.ToSingle(textBox16.Text))
                {
                    if (Timechange[3])
                        Store.MAPCalibrationParams.Injection[3] = Convert.ToSingle(textBox16.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox17.Text) < Convert.ToSingle(textBox18.Text) && Convert.ToSingle(textBox16.Text) < Convert.ToSingle(textBox17.Text))
                {
                    if (Timechange[4])
                        Store.MAPCalibrationParams.Injection[4] = Convert.ToSingle(textBox17.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox18.Text) < Convert.ToSingle(textBox19.Text) && Convert.ToSingle(textBox17.Text) < Convert.ToSingle(textBox18.Text))
                {
                    if (Timechange[5])
                        Store.MAPCalibrationParams.Injection[5] = Convert.ToSingle(textBox18.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox19.Text) < Convert.ToSingle(textBox20.Text) && Convert.ToSingle(textBox18.Text) < Convert.ToSingle(textBox19.Text))
                {
                    if (Timechange[6])
                        Store.MAPCalibrationParams.Injection[6] = Convert.ToSingle(textBox19.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox20.Text) < Convert.ToSingle(textBox21.Text) && Convert.ToSingle(textBox19.Text) < Convert.ToSingle(textBox20.Text))
                {
                    if (Timechange[7])
                        Store.MAPCalibrationParams.Injection[7] = Convert.ToSingle(textBox20.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox21.Text) < Convert.ToSingle(textBox22.Text) && Convert.ToSingle(textBox20.Text) < Convert.ToSingle(textBox21.Text))
                {
                    if (Timechange[8])
                        Store.MAPCalibrationParams.Injection[8] = Convert.ToSingle(textBox21.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox22.Text) < Convert.ToSingle(textBox23.Text) && Convert.ToSingle(textBox21.Text) < Convert.ToSingle(textBox22.Text))
                {
                    if (Timechange[9])
                        Store.MAPCalibrationParams.Injection[9] = Convert.ToSingle(textBox22.Text);
                }
                else
                    TimeErr = true;
                if (Convert.ToSingle(textBox23.Text) < Convert.ToSingle(textBox24.Text) && Convert.ToSingle(textBox22.Text) < Convert.ToSingle(textBox23.Text))
                {
                    if (Timechange[10])
                        Store.MAPCalibrationParams.Injection[10] = Convert.ToSingle(textBox23.Text);
                }
                else
                    TimeErr = true;
                if(Convert.ToSingle(textBox24.Text) > Convert.ToSingle(textBox23.Text))
                {
                    if (Timechange[11])
                        Store.MAPCalibrationParams.Injection[11] = Convert.ToSingle(textBox24.Text);
                }
                else
                    TimeErr = true;
                if (TimeErr)
                    MessageBox.Show(LangWords["309_30"], LangWords["309_31"], MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //for (int i = 0; i < Store.MAPCalibrationParams.RPMs.Count-1;i++ )
                //{
                //    if (Store.MAPCalibrationParams.RPMs[i] > Store.MAPCalibrationParams.RPMs[i + 1])
                //    {
                //        MessageBox.Show(LangWords["309_29"], LangWords["309_31"], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        err = true;
                //    }
                //    if (Store.MAPCalibrationParams.Injection[i] > Store.MAPCalibrationParams.Injection[i + 1])
                //    {
                //        MessageBox.Show(LangWords["309_30"], LangWords["309_31"], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //         err = true;
                //    }
                //}
                if (!RPMsErr && !TimeErr)
                    Store.SaveChanges();
            }
            this.Close();
        }

        private void Textchanged(object sender, EventArgs e)
        {
            if (IsInit) return;
            var ddl = sender as TextBox;
            switch (ddl.Name)
            {
                case "textBox1":
                    RPMchange[0] = true;
                    break;
                case "textBox2":
                    RPMchange[1] = true;
                    break;
                case "textBox3":
                    RPMchange[2] = true;
                    break;
                case "textBox4":
                    RPMchange[3] = true;
                    break;
                case "textBox5":
                    RPMchange[4] = true;
                    break;
                case "textBox6":
                    RPMchange[5] = true;
                    break;
                case "textBox7":
                    RPMchange[6] = true;
                    break;
                case "textBox8":
                    RPMchange[7] = true;
                    break;
                case "textBox9":
                    RPMchange[8] = true;
                    break;
                case "textBox10":
                    RPMchange[9] = true;
                    break;
                case "textBox11":
                    RPMchange[10] = true;
                    break;
                case "textBox12":
                    RPMchange[11] = true;
                    break;
                case "textBox13":
                    Timechange[0] = true;
                    break;
                case "textBox14":
                    Timechange[1] = true;
                    break;
                case "textBox15":
                    Timechange[2] = true;
                    break;
                case "textBox16":
                    Timechange[3] = true;
                    break;
                case "textBox17":
                    Timechange[4] = true;
                    break;
                case "textBox18":
                    Timechange[5] = true;
                    break;
                case "textBox19":
                    Timechange[6] = true;
                    break;
                case "textBox20":
                    Timechange[7] = true;
                    break;
                case "textBox21":
                    Timechange[8] = true;
                    break;
                case "textBox22":
                    Timechange[9] = true;
                    break;
                case "textBox23":
                    Timechange[10] = true;
                    break;
                case "textBox24":
                    Timechange[11] = true;
                    break;
                default:
                    break;
            }
            Changed = true;
        }
    }
}
