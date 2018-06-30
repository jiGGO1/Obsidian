using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Obsidian.Launcher
{
    /// <summary>
    /// josn配置类
    /// </summary>
    public class ConfigureFile
    {
        /// <summary>
        /// 标题背景颜色
        /// </summary>
        private ConfigureColor titleColor = new ConfigureColor(0,0,0);

        /// <summary>
        /// 背景颜色
        /// </summary>
        private ConfigureColor backColor = new ConfigureColor(255,255,255);

        /// <summary>
        /// 字体颜色
        /// </summary>
        private ConfigureColor fontColor = new ConfigureColor(0,0,0);

        /// <summary>
        /// 按钮颜色
        /// </summary>
        private ConfigureColor buttonColor = new ConfigureColor(0,0,0);

        /// <summary>
        /// 标题按钮颜色黑白
        /// </summary>
        private bool titleButtonColor = true;

        /// <summary>
        /// 标题字体颜色黑白
        /// </summary>
        private bool titleFontColor = true;
        
        /// <summary>
        /// 电子邮箱或名字
        /// </summary>
        private string emailOrName = "";

        /// <summary>
        /// 账号密码
        /// </summary>
        private string password = "";

        /// <summary>
        /// 是否正版
        /// </summary>
        private bool positiveEdition = false;

        /// <summary>
        /// 游戏宽度
        /// </summary>
        private int width = 1280;

        /// <summary>
        /// 游戏高度
        /// </summary>
        private int height = 680;

        /// <summary>
        /// 游戏文件夹路径
        /// </summary>
        private String gameRootPath = "";

        /// <summary>
        /// java路径
        /// </summary>
        private String javaPath = "";


        /// <summary>
        /// 封装标题背景颜色
        /// </summary>
        public ConfigureColor TitleColor
        {
            get { return titleColor; }
            set { titleColor = value; }
        }

        /// <summary>
        /// 封装背景颜色
        /// </summary>
        public ConfigureColor BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }

        /// <summary>
        /// 封装字体颜色
        /// </summary>
        public ConfigureColor FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }

        /// <summary>
        /// 封装按钮颜色
        /// </summary>
        public ConfigureColor ButtemColor
        {
            get { return buttonColor; }
            set { buttonColor = value; }
        }

        /// <summary>
        /// 封装标题按钮颜色
        /// </summary>
        public bool TitleButtonColor
        {
            get { return titleButtonColor; }
            set { titleButtonColor = value; }
        }

        /// <summary>
        /// 封装标题字体颜色
        /// </summary>
        public bool TitleFontColor
        {
            get { return titleFontColor; }
            set { titleFontColor = value; }
        }

        /// <summary>
        /// 封装电子邮箱或名字
        /// </summary>
        public string EmailOrName
        {
            get { return emailOrName; }
            set { emailOrName = value; }
        }

        /// <summary>
        /// 封装密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// 封装是否正版
        /// </summary>
        public bool PositiveEdition
        {
            get { return positiveEdition; }
            set { positiveEdition = value; }
        }

        /// <summary>
        /// 封装游戏宽度
        /// </summary>
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>
        /// 封装游戏高度
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// 封装游戏文件夹路径
        /// </summary>
        public String GameRootPath
        {
            get { return gameRootPath; }
            set { gameRootPath = value; }
        }

        /// <summary>
        /// 封装java路径
        /// </summary>
        public String JavaPath
        {
            get { return javaPath; }
            set { javaPath = value; }
        }
    }
}
