using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Obsidian;
using Obsidian.Launcher;
using CCWin;
using CCWin.SkinControl;
using KMCCC.Launcher;
using KMCCC.Authentication;
using KMCCC.Modules;
using KMCCC.Pro;
using KMCCC.Tools;
using Version = KMCCC.Launcher.Version;

namespace Obsidian.My
{
    public partial class UctGame : UserControl
    {

        public UctGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 存储父类窗体
        /// </summary>
        private Object owner = new Object();

        /// <summary>
        /// 封装父类窗体
        /// </summary>
        public FrmMain Owner
        {
            get { return (FrmMain)owner; }
            set { owner = value; }
        }

        /// <summary>
        /// Set父类窗体
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">父类</param>
        public void SetOwner<T>(T t)
        {
            this.owner = t;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            //Regex reEamil = new Regex(@"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.[a-zA-Z0-9]{2,6}$");
            //Regex rePwd = new Regex(@"[a-zA-Z0-9]{8,}");
            //bool ui = reEamil.IsMatch(this.skinTextBox1.Text);
            //MessageBox.Show(ui.ToString());
            //bool ui2 = rePwd.IsMatch(this.skinTextBox2.Text);
            //MessageBox.Show(ui2.ToString());
            var ver = (KMCCC.Launcher.Version)skinComboBox1.SelectedItem;
            LaunchResult result = null;
            if(this.Owner.Config.PositiveEdition)
            {
                result = App.launcherCore.Launch(new LaunchOptions
                {
                    Version = ver, //Ver为Versions里你要启动的版本名字
                    MaxMemory = 512, //最大内存，int类型
                    Authenticator = new YggdrasilLogin(this.skinTextBox1.Text.ToString(), this.skinTextBox2.Text.ToString(),true), // 正版启动，最后一个为是否twitch登录
                    Size = new WindowSize { Height = 768, Width = 1280 } //设置窗口大小，可以不要
                });
               
            }
            else
            {
                result = App.launcherCore.Launch(new LaunchOptions
                {
                    Version = ver, //Ver为Versions里你要启动的版本名字
                    MaxMemory = 512, //最大内存，int类型
                    Authenticator = new OfflineAuthenticator(this.skinTextBox1.Text), //离线启动，ZhaiSoul那儿为你要设置的游戏名
                    //Mode = LaunchMode.BmclMode, //启动模式，这个我会在后面解释有哪几种
                    Size = new WindowSize { Height = 768, Width = 1280 } //设置窗口大小，可以不要
                });
            }

            if (!result.Success)
            {
                switch (result.ErrorType)
                {
                    case ErrorType.NoJAVA:
                        MessageBox.Show("你系统的Java有异常，可能你非正常途径删除过Java，请尝试重新安装Java\n详细信息：" + result.ErrorMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case ErrorType.AuthenticationFailed:
                        MessageBox.Show(this, "正版验证失败！请检查你的账号密码", "账号错误\n详细信息：" + result.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case ErrorType.UncompressingFailed:
                        MessageBox.Show(this, "可能的多开或文件损坏，请确认文件完整且不要多开\n如果你不是多开游戏的话，请检查libraries文件夹是否完整\n详细信息：" + result.ErrorMessage, "可能的多开或文件损坏", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(this,
                            result.ErrorMessage + "\n" +
                            (result.Exception == null ? string.Empty : result.Exception.StackTrace),
                            "启动错误，请将此窗口截图向开发者寻求帮助");
                        break;
                }
            }
        }

        private void skinComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.skinComboBox2.Text.Equals("正版登录"))
            {
                this.SLblName.Text = "登录账号:";
                this.SLblPwd.Visible = true;
                this.skinTextBox2.Visible = true;
                this.Owner.Config.PositiveEdition = true;
            }
            else if(this.skinComboBox2.Text.Equals("离线登录"))
            {
                this.SLblName.Text = "游戏名称:";
                this.SLblPwd.Visible = false;
                this.skinTextBox2.Visible = false;
                this.Owner.Config.PositiveEdition = false;
            }
        }

        private void UctGame_Load(object sender, EventArgs e)
        {
            Version[] versions = App.launcherCore.GetVersions().ToArray();
            this.skinComboBox1.DataSource = versions;//绑定数据源
            this.skinComboBox1.DisplayMember = "Id";//设置comboBox显示的为版本Id
            this.skinComboBox2.Text = "离线登录";
            this.SLblPwd.Visible = false;
            this.skinTextBox2.Visible = false;
        }

        public void text(object sender, EventArgs e)
        {
            this.Owner.Config.EmailOrName = this.skinTextBox1.Text;
        }

        private void skinTextBox2_Leave(object sender, EventArgs e)
        {
            this.Owner.Config.Password = this.skinTextBox2.Text;
        }
    }
}
