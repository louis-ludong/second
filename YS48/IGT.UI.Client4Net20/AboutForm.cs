using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IGT.UI.Client
{
    public partial class AboutForm : Form,Service.Language.IMultLang
    {
        public AboutForm()
        {
            InitializeComponent();
            UIHelper.CommonSet(this);
            ApplyLang();
            myMenuStrip1.HideAllMenus();
            myMenuStrip1.ShowCloseButton =false ;
            myMenuStrip1.ShowMinButton =false ;
            ConfigHelper cfh = new ConfigHelper();
            cfh.Load();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //激活回车键
      {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;
            if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        this.Close();//csc关闭窗体
                        break;
                }
            }
            return false;
        }
        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            
        }

        #region IMultLang 成员

        public void ApplyLang()
        {
            var LangWord = Services.Lang.CurrentWords;
            this .linkLabel1 .Text =LangWord ["702"];
            this.label2.Text = LangWord["703"];
            labelTel.Text = LangWord["704"];
            labelWeb.Text = LangWord["705"];
            labelVer.Text = LangWord["706"];
          //  labelVerN.Text = LangWord["707"];
        }

        #endregion

        #region GDI+
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Pen redPen = new Pen(new SolidBrush(Color.FromArgb(245, 130, 31)), 4);
            e.Graphics.DrawRectangle(redPen, 2, 2, this.ClientSize.Width - 4, this.ClientSize.Height - 4);
            redPen.Dispose();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { System.Diagnostics.Process.Start(linkLabel1.Text); }
            catch
            {
                MessageBox.Show("errado");
            }
        }
    }
}
//变更履历：
/*
变更履历：
V2.1.1 :
 * 1.选1ohm 时，多出一个按钮，去掉;  
 * 2.改用.net framework4.0  LinqBridge.dll  
 * 3.部分语言修改
 * 
V2.1.2:
 * 1.MAP图标设置的确认和取消按钮改成葡萄牙文和英文

V2.2:
 * 实时参数，水温与气温对调
 * 高速转油问题调整
 * 发送用户首次使用时间格式修改
 * 增加参数设置Start &Stop
 * 使用专用握手包
 * 
 * 
V2.3: 
 * Start/Stopb改到高级设置里面，不要用葡萄牙语
 * 
V2.4:
 * 增加Valvetronik功能
V2.5:
 * 读升级文件第一串数据时，根据文件作了修正
 * 
V2.6:
 * 增加8缸读写
 * 
V2.7:
 * 增加直接气启动功能
 * 
V2.8
 * 发送后，接收时等50ms                      System.Threading.Thread.Sleep(50);//V2.8修改
 * 检查返回数据时，返回开始数据不至检查数据头，而且检查命令，因为我们ECU是先返回一段电脑发过去的数据，而这些数据中有时正好与数据头相同
 * 
 * 直接气启动功能改到高级设置界面
 * 
V2.9
 * 增加Anticipate the injection sequence
 * 
 * 
 * 
V3.1
 * 增加喷油回转
 * 增加OBD功能
 * 
V3.2
 * 水温设置调成从0开始，本来从15开始的
 * 
V3.3
 * 增加读序列号功能
 * 去掉设置密码功能
 * 
V3.4
 * OBD功能标志位以前读错了，修改
 * 
V3.5
 *八缸诊断显示问题修复
 * 
V3.6
 *增加西班牙语
 * 
V3.7
 * 启动图片更换
 * 部分葡萄牙语修正

V3.8
 * 增加预充气时间
 *  读：CMDr_PARA_EX 0x21增加最后一个字节单位100ms
    写：CMDw_PARA_EX 0x91 子命令 0x10
 * 
*/