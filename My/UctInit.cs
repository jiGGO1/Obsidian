using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using Obsidian.Launcher;

namespace Obsidian.My
{
    /// <summary>
    /// 用户窗体UctInit类
    /// </summary>
    public partial class UctInit : UserControl 
    {
        /// <summary>
        /// 窗体初始化
        /// </summary>
        public UctInit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 存储父类窗体
        /// </summary>
        private Object owner = new Object();

        /// <summary>
        /// Get父类窗体
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <returns>返回父类窗体</returns>
        public T GetOwner<T>()
        {
            return (T)(this.owner);
        }

        /// <summary>
        /// Get父类窗体
        /// </summary>
        /// <returns>返回父类窗体</returns>
        public FrmMain GetOwner()
        {
            return (FrmMain)(this.owner);
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

        /// <summary>
        /// 设置标题颜色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SCSPnl1_SelectedColorChanged(object sender, EventArgs e)
        {
            this.LblPrompt1.ForeColor = SCSPnl1.SelectedColor;
            this.GetOwner().PnlTitle.BackColor = SCSPnl1.SelectedColor;
            this.LblTitle.ForeColor = SCSPnl1.SelectedColor;
            this.GetOwner().Config.TitleColor = new ConfigureColor(SCSPnl1.SelectedColor);
        }

        /// <summary>
        /// 设置背景颜色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SCSPnl2_SelectedColorChanged(object sender, EventArgs e)
        {
            this.GetOwner().BackColor = SCSPnl2.SelectedColor;
            this.BackColor = SCSPnl2.SelectedColor;
            this.GetOwner().Config.BackColor = new ConfigureColor(SCSPnl2.SelectedColor);
        }

        /// <summary>
        /// 设置字体颜色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SCSPnl3_SelectedColorChanged(object sender, EventArgs e)
        {
            this.LblTxt1.ForeColor = SCSPnl3.SelectedColor;
            this.LblTxt2.ForeColor = SCSPnl3.SelectedColor;
            this.LblFont.ForeColor = SCSPnl3.SelectedColor;
            this.LblPrompt2.ForeColor = SCSPnl3.SelectedColor;
            this.LblPrompt3.ForeColor = SCSPnl3.SelectedColor;
            this.GetOwner().Config.FontColor = new ConfigureColor(SCSPnl3.SelectedColor);
        }

        /// <summary>
        /// 设置按钮的字体颜色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SCSPnl4_SelectedColorChanged(object sender, EventArgs e)
        {
            this.LblButten.ForeColor = SCSPnl4.SelectedColor;
            this.skinButton1.ForeColor = SCSPnl4.SelectedColor;
            this.SRdoBtnColor_1.ForeColor = SCSPnl4.SelectedColor;
            this.SRdoBtnColor_2.ForeColor = SCSPnl4.SelectedColor;
            this.SRdoTilColor_2.ForeColor = SCSPnl4.SelectedColor;
            this.SRdoTilColor_1.ForeColor = SCSPnl4.SelectedColor;
            this.GetOwner().Config.ButtemColor = new ConfigureColor(SCSPnl4.SelectedColor);
        }

        /// <summary>
        /// 设置标题按键白色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SRdoBtnColor1_CheckedChanged(object sender, EventArgs e)
        {
            this.GetOwner().PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_1;
            this.GetOwner().PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_1;
            this.GetOwner().Config.TitleButtonColor = true;
        }

        /// <summary>
        /// 设置标题按键黑色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SRdoBtnColor2_CheckedChanged(object sender, EventArgs e)
        {
            this.GetOwner().PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_3;
            this.GetOwner().PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_3;
            this.GetOwner().Config.TitleButtonColor = false;
        }

        /// <summary>
        /// 设置标题栏黑色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SRdoTilColor1_CheckedChanged(object sender, EventArgs e)
        {
            this.GetOwner().LblWizard.ForeColor = Color.Black;
            this.GetOwner().Config.TitleFontColor = false;
        }

        /// <summary>
        /// 设置标题栏白色
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void SRdoTilColor2_CheckedChanged(object sender, EventArgs e)
        {
            this.GetOwner().LblWizard.ForeColor = Color.White;
            this.GetOwner().Config.TitleFontColor = true;
        }

        /// <summary>
        /// 打开游戏启动窗体
        /// </summary>
        /// <param name="sender">产生事件的参数</param>
        /// <param name="e">事件的参数</param>
        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.GetOwner().UctGameShow();
            //Configure con = new Configure();
            //con.WriteFile();
        }
    }
}
