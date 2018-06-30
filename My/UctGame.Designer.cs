namespace Obsidian.My
{
    partial class UctGame
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.SLblPwd = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.SLblEdition = new CCWin.SkinControl.SkinLabel();
            this.SLblSignin = new CCWin.SkinControl.SkinLabel();
            this.SLblName = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox2 = new CCWin.SkinControl.SkinComboBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = global::Obsidian.Properties.Resources.back1;
            this.skinPanel1.Controls.Add(this.skinTextBox1);
            this.skinPanel1.Controls.Add(this.SLblPwd);
            this.skinPanel1.Controls.Add(this.skinComboBox1);
            this.skinPanel1.Controls.Add(this.skinTextBox2);
            this.skinPanel1.Controls.Add(this.SLblEdition);
            this.skinPanel1.Controls.Add(this.SLblSignin);
            this.skinPanel1.Controls.Add(this.SLblName);
            this.skinPanel1.Controls.Add(this.skinComboBox2);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(244, 403);
            this.skinPanel1.TabIndex = 19;
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(95, 103);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 10;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            this.skinTextBox1.Leave += new System.EventHandler(this.text);
            // 
            // SLblPwd
            // 
            this.SLblPwd.AutoSize = true;
            this.SLblPwd.BackColor = System.Drawing.Color.Transparent;
            this.SLblPwd.BorderColor = System.Drawing.Color.White;
            this.SLblPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SLblPwd.Location = new System.Drawing.Point(20, 153);
            this.SLblPwd.Name = "SLblPwd";
            this.SLblPwd.Size = new System.Drawing.Size(68, 17);
            this.SLblPwd.TabIndex = 18;
            this.SLblPwd.Text = "账号密码：";
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.Location = new System.Drawing.Point(95, 62);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(135, 24);
            this.skinComboBox1.TabIndex = 9;
            this.skinComboBox1.WaterText = "";
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '●';
            this.skinTextBox2.IsSystemPasswordChar = false;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(95, 148);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = false;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(135, 28);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.PasswordChar = '●';
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(125, 18);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 17;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            this.skinTextBox2.Leave += new System.EventHandler(this.skinTextBox2_Leave);
            // 
            // SLblEdition
            // 
            this.SLblEdition.AutoSize = true;
            this.SLblEdition.BackColor = System.Drawing.Color.Transparent;
            this.SLblEdition.BorderColor = System.Drawing.Color.White;
            this.SLblEdition.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SLblEdition.Location = new System.Drawing.Point(20, 65);
            this.SLblEdition.Name = "SLblEdition";
            this.SLblEdition.Size = new System.Drawing.Size(68, 17);
            this.SLblEdition.TabIndex = 13;
            this.SLblEdition.Text = "游戏版本：";
            // 
            // SLblSignin
            // 
            this.SLblSignin.AutoSize = true;
            this.SLblSignin.BackColor = System.Drawing.Color.Transparent;
            this.SLblSignin.BorderColor = System.Drawing.Color.White;
            this.SLblSignin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SLblSignin.Location = new System.Drawing.Point(20, 23);
            this.SLblSignin.Name = "SLblSignin";
            this.SLblSignin.Size = new System.Drawing.Size(68, 17);
            this.SLblSignin.TabIndex = 16;
            this.SLblSignin.Text = "登录方式：";
            // 
            // SLblName
            // 
            this.SLblName.AutoSize = true;
            this.SLblName.BackColor = System.Drawing.Color.Transparent;
            this.SLblName.BorderColor = System.Drawing.Color.White;
            this.SLblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SLblName.Location = new System.Drawing.Point(20, 108);
            this.SLblName.Name = "SLblName";
            this.SLblName.Size = new System.Drawing.Size(68, 17);
            this.SLblName.TabIndex = 14;
            this.SLblName.Text = "玩家名称：";
            // 
            // skinComboBox2
            // 
            this.skinComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinComboBox2.FormattingEnabled = true;
            this.skinComboBox2.Items.AddRange(new object[] {
            "正版登录",
            "离线登录"});
            this.skinComboBox2.Location = new System.Drawing.Point(95, 20);
            this.skinComboBox2.Name = "skinComboBox2";
            this.skinComboBox2.Size = new System.Drawing.Size(135, 24);
            this.skinComboBox2.TabIndex = 15;
            this.skinComboBox2.WaterText = "";
            this.skinComboBox2.SelectedIndexChanged += new System.EventHandler(this.skinComboBox2_SelectedIndexChanged);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.BorderColor = System.Drawing.Color.Silver;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.Black;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.InheritColor = true;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(695, 309);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 20;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(123, 69);
            this.skinButton1.TabIndex = 19;
            this.skinButton1.Text = "开始游戏";
            this.skinButton1.UseVisualStyleBackColor = true;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // UctGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "UctGame";
            this.Size = new System.Drawing.Size(843, 403);
            this.Load += new System.EventHandler(this.UctGame_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinComboBox skinComboBox1;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel SLblName;
        private CCWin.SkinControl.SkinLabel SLblSignin;
        private CCWin.SkinControl.SkinComboBox skinComboBox2;
        private CCWin.SkinControl.SkinLabel SLblEdition;
        private CCWin.SkinControl.SkinLabel SLblPwd;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}
