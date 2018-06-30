/*
 *版本 V1.00 修改时间：2018.6.10
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CCWin;
using CCWin.SkinControl;
using Obsidian.My;
using Obsidian.Launcher;

namespace Obsidian
{
    /// <summary>
    /// Menu窗体类
    /// </summary>
    public partial class FrmMain : CCSkinMain
    {
        /// <summary>
        /// 配置文件类
        /// </summary>
        public ConfigureFile Config;

        /// <summary>
        /// 创建Point类
        /// </summary>
        private Point MousePoint = new Point();

        /// <summary>
        /// 窗体构造方法
        /// </summary>
        public FrmMain()
        {
            //窗口初始化
            InitializeComponent();
            InitFrmMain();
        }

        /// <summary>
        /// 窗体加载调用
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            UctInitShow();//调用初始化窗体
        }

        /// <summary>
        /// 实现窗口最小化
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlTure_Click(object sender, EventArgs e)
        {
            //最小化程序
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 实现关闭程序
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlFalse_Click(object sender, EventArgs e)
        {
            //关闭程序
            Application.Exit();
        }

        /// <summary>
        /// 拖拽窗口进行移动
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //在鼠标指针移动到指定的元素后执行
            base.OnMouseDown(e);
            this.MousePoint.X = e.X;
            this.MousePoint.Y = e.Y;
        }

        /// <summary>
        /// 放开窗口实现移动
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            //在鼠标指针移动到指定的元素后执行
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - MousePoint.Y;
                this.Left = Control.MousePosition.X - MousePoint.X;
            }
        }

        /// <summary>
        /// 进入控件改变图片
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlTure_MouseEnter(object sender, EventArgs e)
        {
            if (this.Config.TitleButtonColor == true)
            {
                this.PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_0;
            }
            else if (this.Config.TitleButtonColor == false)
            {
                this.PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_2;
            }
        }

        /// <summary>
        /// 离开控件改变图片
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlTure_MouseLeave(object sender, EventArgs e)
        {
            if (this.Config.TitleButtonColor == true)
            {
                this.PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_1;
            }
            else if (this.Config.TitleButtonColor == false)
            {
                this.PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_3;
            }
        }

        /// <summary>
        /// 进入控件改变图片
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlFalse_MouseEnter(object sender, EventArgs e)
        {
            if (this.Config.TitleButtonColor == true)
            {
                this.PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_0;
            }
            else if (this.Config.TitleButtonColor == false)
            {
                this.PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_2;
            }
        }

        /// <summary>
        /// 离开控件改变图片
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void PnlFalse_MouseLeave(object sender, EventArgs e)
        {
            if (this.Config.TitleButtonColor == true)
            {
                this.PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_1;
            }
            else if (this.Config.TitleButtonColor == false)
            {
                this.PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_3;
            }
        }

        /// <summary>
        /// 关闭程序前重新创建josn
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件定义的参数</param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configure configure = new Configure();
            configure.WriteFile(Configure.ToJson(this.Config));
        }

        /// <summary>
        /// 配置文件初始化游戏窗体
        /// </summary>
        public void InitFrmMain()
        {
            try
            {
                //ConfigureFile类读取josn赋值
                Config = Configure.ReadJosn();
                //初始化标题颜色
                this.PnlTitle.BackColor = Config.TitleColor.ToColor();
                //初始化背景颜色
                this.BackColor = Config.BackColor.ToColor();
                //初始化标题字体
                if(this.Config.TitleFontColor)
                {
                    this.LblWizard.ForeColor = Color.FromArgb(230,230,230);
                }
                else 
                {
                    this.LblWizard.ForeColor = Color.FromArgb(0,0,0);
                }
                //初始化标题的按键颜色和字体颜色
                if (this.Config.TitleButtonColor)
                {
                    this.PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_1;
                    this.PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_1;
                }
                else
                {
                    this.PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_2;
                    this.PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_2;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 打开初始化窗体
        /// </summary>
        public void UctInitShow()
        {
            UctInit uctinit = new UctInit();//初始化用户窗体
            uctinit.SetOwner<FrmMain>(this);
            uctinit.Show();
            this.PnlFrm.Controls.Clear();
            this.PnlFrm.Controls.Add(uctinit);
        }

        /// <summary>
        /// 打开游戏开启窗体
        /// </summary>
        public void UctGameShow()
        {
            Animator1.Hide(this.PnlFrm);
            Animator1.Hide(this.LblWizard);
            Animator1.WaitAllAnimations();
            UctGame uctGame = new UctGame();//游戏用户窗体
            uctGame.SetOwner<FrmMain>(this);
            uctGame.Show();
            this.PnlFrm.Controls.Clear();
            this.PnlFrm.Controls.Add(uctGame);
            Animator1.Show(this.pictureBox1,true);
            Animator1.Show(this.pictureBox2,true);
            Animator1.Show(this.pictureBox3,true);
            Animator1.Show(this.PnlFrm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Animator1.Hide(this.PnlFrm);
            Animator1.WaitAllAnimations();
            UctGame uctGame = new UctGame();
            uctGame.SetOwner<FrmMain>(this);
            uctGame.Show();
            this.PnlFrm.Controls.Clear();
            this.PnlFrm.Controls.Add(uctGame);
            Animator2.Show(this.PnlFrm);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Animator1.Hide(this.PnlFrm);
            Animator1.WaitAllAnimations();
            UctDownload uctDownload = new UctDownload();
            uctDownload.Show();
            this.PnlFrm.Controls.Clear();
            this.PnlFrm.Controls.Add(uctDownload);
            Animator2.Show(this.PnlFrm);
        }
    }
}