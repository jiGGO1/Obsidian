namespace Obsidian
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            CCWin.SkinControl.Animation animation2 = new CCWin.SkinControl.Animation();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblWizard = new System.Windows.Forms.Label();
            this.PnlTure = new System.Windows.Forms.Panel();
            this.PnlFalse = new System.Windows.Forms.Panel();
            this.PnlFrm = new CCWin.SkinControl.SkinPanel();
            this.Animator1 = new CCWin.SkinControl.SkinAnimator(this.components);
            this.Animator2 = new CCWin.SkinControl.SkinAnimator(this.components);
            this.PnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.Black;
            this.PnlTitle.Controls.Add(this.pictureBox3);
            this.PnlTitle.Controls.Add(this.pictureBox2);
            this.PnlTitle.Controls.Add(this.pictureBox1);
            this.PnlTitle.Controls.Add(this.LblWizard);
            this.PnlTitle.Controls.Add(this.PnlTure);
            this.PnlTitle.Controls.Add(this.PnlFalse);
            this.PnlTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.Animator2.SetDecoration(this.PnlTitle, CCWin.SkinControl.DecorationType.None);
            this.Animator1.SetDecoration(this.PnlTitle, CCWin.SkinControl.DecorationType.None);
            this.PnlTitle.Location = new System.Drawing.Point(0, -1);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(845, 95);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitle_MouseDown);
            this.PnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTitle_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Obsidian.Properties.Resources.Setup_0;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animator1.SetDecoration(this.pictureBox3, CCWin.SkinControl.DecorationType.None);
            this.Animator2.SetDecoration(this.pictureBox3, CCWin.SkinControl.DecorationType.None);
            this.pictureBox3.Location = new System.Drawing.Point(501, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animator1.SetDecoration(this.pictureBox2, CCWin.SkinControl.DecorationType.None);
            this.Animator2.SetDecoration(this.pictureBox2, CCWin.SkinControl.DecorationType.None);
            this.pictureBox2.ErrorImage = global::Obsidian.Properties.Resources.Download_0;
            this.pictureBox2.Location = new System.Drawing.Point(396, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Obsidian.Properties.Resources.Game_0;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animator1.SetDecoration(this.pictureBox1, CCWin.SkinControl.DecorationType.None);
            this.Animator2.SetDecoration(this.pictureBox1, CCWin.SkinControl.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(288, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblWizard
            // 
            this.LblWizard.AutoSize = true;
            this.LblWizard.BackColor = System.Drawing.Color.Transparent;
            this.Animator1.SetDecoration(this.LblWizard, CCWin.SkinControl.DecorationType.None);
            this.Animator2.SetDecoration(this.LblWizard, CCWin.SkinControl.DecorationType.None);
            this.LblWizard.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblWizard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LblWizard.Location = new System.Drawing.Point(365, 35);
            this.LblWizard.Name = "LblWizard";
            this.LblWizard.Size = new System.Drawing.Size(110, 24);
            this.LblWizard.TabIndex = 3;
            this.LblWizard.Text = "设置向导";
            // 
            // PnlTure
            // 
            this.PnlTure.BackColor = System.Drawing.Color.Transparent;
            this.PnlTure.BackgroundImage = global::Obsidian.Properties.Resources.ture_1;
            this.PnlTure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animator2.SetDecoration(this.PnlTure, CCWin.SkinControl.DecorationType.None);
            this.Animator1.SetDecoration(this.PnlTure, CCWin.SkinControl.DecorationType.None);
            this.PnlTure.Location = new System.Drawing.Point(774, 12);
            this.PnlTure.Name = "PnlTure";
            this.PnlTure.Size = new System.Drawing.Size(20, 20);
            this.PnlTure.TabIndex = 2;
            this.PnlTure.Click += new System.EventHandler(this.PnlTure_Click);
            this.PnlTure.MouseEnter += new System.EventHandler(this.PnlTure_MouseEnter);
            this.PnlTure.MouseLeave += new System.EventHandler(this.PnlTure_MouseLeave);
            // 
            // PnlFalse
            // 
            this.PnlFalse.BackColor = System.Drawing.Color.Transparent;
            this.PnlFalse.BackgroundImage = global::Obsidian.Properties.Resources.false_1;
            this.PnlFalse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animator2.SetDecoration(this.PnlFalse, CCWin.SkinControl.DecorationType.None);
            this.Animator1.SetDecoration(this.PnlFalse, CCWin.SkinControl.DecorationType.None);
            this.PnlFalse.Location = new System.Drawing.Point(811, 13);
            this.PnlFalse.Name = "PnlFalse";
            this.PnlFalse.Size = new System.Drawing.Size(18, 18);
            this.PnlFalse.TabIndex = 1;
            this.PnlFalse.Click += new System.EventHandler(this.PnlFalse_Click);
            this.PnlFalse.MouseEnter += new System.EventHandler(this.PnlFalse_MouseEnter);
            this.PnlFalse.MouseLeave += new System.EventHandler(this.PnlFalse_MouseLeave);
            // 
            // PnlFrm
            // 
            this.PnlFrm.AutoScroll = true;
            this.PnlFrm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlFrm.BackColor = System.Drawing.Color.Transparent;
            this.PnlFrm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator2.SetDecoration(this.PnlFrm, CCWin.SkinControl.DecorationType.None);
            this.Animator1.SetDecoration(this.PnlFrm, CCWin.SkinControl.DecorationType.None);
            this.PnlFrm.DownBack = null;
            this.PnlFrm.Location = new System.Drawing.Point(1, 94);
            this.PnlFrm.MouseBack = null;
            this.PnlFrm.Name = "PnlFrm";
            this.PnlFrm.NormlBack = null;
            this.PnlFrm.Size = new System.Drawing.Size(844, 405);
            this.PnlFrm.TabIndex = 1;
            // 
            // Animator1
            // 
            this.Animator1.AnimationType = CCWin.SkinControl.AnimationType.Transparent;
            this.Animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Animator1.DefaultAnimation = animation1;
            this.Animator1.MaxAnimationTime = 1000;
            // 
            // Animator2
            // 
            this.Animator2.AnimationType = CCWin.SkinControl.AnimationType.Transparent;
            this.Animator2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.Animator2.DefaultAnimation = animation2;
            this.Animator2.MaxAnimationTime = 200;
            this.Animator2.TimeStep = 0.01F;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(844, 497);
            this.Controls.Add(this.PnlFrm);
            this.Controls.Add(this.PnlTitle);
            this.Animator2.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.Animator1.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(844, 497);
            this.Name = "FrmMain";
            this.ShadowWidth = 10;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "黑曜石启动器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PnlTitle;
        internal System.Windows.Forms.Panel PnlFalse;
        internal System.Windows.Forms.Panel PnlTure;
        internal System.Windows.Forms.Label LblWizard;
        private CCWin.SkinControl.SkinPanel PnlFrm;
        private CCWin.SkinControl.SkinAnimator Animator1;
        private CCWin.SkinControl.SkinAnimator Animator2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

