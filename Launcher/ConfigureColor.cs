using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Obsidian.Launcher
{
    /// <summary>
    /// 配置文件颜色类
    /// </summary>
    public class ConfigureColor
    {
        /// <summary>
        /// 颜色红通道
        /// </summary>
        private int r;
        
        /// <summary>
        /// 颜色绿通道
        /// </summary>
        private int g;

        /// <summary>
        /// 颜色蓝通道
        /// </summary>
        private int b;

        /// <summary>
        /// ConfigureColor默认构造方法
        /// </summary>
        public ConfigureColor(){}

        /// <summary>
        /// ConfigureColor构造方法-1
        /// </summary>
        public ConfigureColor(int r,int g,int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        /// <summary>
        /// ConfigureColor构造方法-2
        /// </summary>
        public ConfigureColor(Color color)
        {
            this.r = color.R;
            this.g = color.G;
            this.b = color.B;
        }

        /// <summary>
        /// 封装红
        /// </summary>
        public int R
        {
            get { return r; }
            set { r = value; }
        }

        /// <summary>
        /// 封装绿
        /// </summary>
        public int G
        {
            get { return g; }
            set { g = value; }
        }

        /// <summary>
        /// 封装蓝
        /// </summary>
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        /// <summary>
        /// 转化颜色类
        /// </summary>
        /// <returns>返回默认颜色类</returns>
        public Color ToColor()
        {
            return Color.FromArgb(this.R,this.G,this.B);
        }
    }
}
