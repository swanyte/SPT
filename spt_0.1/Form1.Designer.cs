namespace spt_0._1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bannerAds1 = new AdsJumboWinForm.BannerAds();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.TextBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.LogoBox = new System.Windows.Forms.Panel();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.SetButton = new FontAwesome.Sharp.IconButton();
            this.CheckButton = new FontAwesome.Sharp.IconButton();
            this.EncrtpyButton = new FontAwesome.Sharp.IconButton();
            this.ManualButton = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TextBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.LogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.LeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.welcome);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(176, 105);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(628, 375);
            this.panelDesktop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(45, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "We are SIS4 working on the PBL project.";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.welcome.Location = new System.Drawing.Point(38, 33);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(284, 37);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to SPT!!!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.bannerAds1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 65);
            this.panel1.TabIndex = 2;
            // 
            // bannerAds1
            // 
            this.bannerAds1.ApplicationId = null;
            this.bannerAds1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.bannerAds1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bannerAds1.HeightAd = 0;
            this.bannerAds1.Location = new System.Drawing.Point(0, 0);
            this.bannerAds1.Margin = new System.Windows.Forms.Padding(0);
            this.bannerAds1.Name = "bannerAds1";
            this.bannerAds1.Padding = new System.Windows.Forms.Padding(2);
            this.bannerAds1.Size = new System.Drawing.Size(628, 65);
            this.bannerAds1.TabIndex = 1;
            this.bannerAds1.WidthAd = 0;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(176, 96);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(628, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(49, 72);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(49, 18);
            this.lblTitleChildForm.TabIndex = 4;
            this.lblTitleChildForm.Text = "Home";
            // 
            // TextBar
            // 
            this.TextBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.TextBar.Controls.Add(this.pictureBox1);
            this.TextBar.Controls.Add(this.lblTitleChildForm);
            this.TextBar.Controls.Add(this.IconCurrentChildForm);
            this.TextBar.Controls.Add(this.MinimizeButton);
            this.TextBar.Controls.Add(this.ExitButton);
            this.TextBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBar.Location = new System.Drawing.Point(176, 0);
            this.TextBar.Margin = new System.Windows.Forms.Padding(2);
            this.TextBar.Name = "TextBar";
            this.TextBar.Size = new System.Drawing.Size(628, 96);
            this.TextBar.TabIndex = 1;
            this.TextBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBar_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::spt_0._1.Properties.Resources.pbl;
            this.pictureBox1.Location = new System.Drawing.Point(574, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 40;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(3, 57);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.IconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconCurrentChildForm.TabIndex = 3;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 20;
            this.MinimizeButton.Location = new System.Drawing.Point(590, 5);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(16, 16);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 20;
            this.ExitButton.Location = new System.Drawing.Point(608, 5);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(16, 16);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.LogoBox.Controls.Add(this.MainLogo);
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBox.Location = new System.Drawing.Point(0, 0);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(176, 105);
            this.LogoBox.TabIndex = 1;
            // 
            // MainLogo
            // 
            this.MainLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.MainLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLogo.Image = global::spt_0._1.Properties.Resources.SPT_Logo1;
            this.MainLogo.Location = new System.Drawing.Point(0, 0);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(176, 105);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainLogo.TabIndex = 0;
            this.MainLogo.TabStop = false;
            this.MainLogo.Click += new System.EventHandler(this.MainLogo_Click);
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.LeftMenu.Controls.Add(this.iconButton1);
            this.LeftMenu.Controls.Add(this.SetButton);
            this.LeftMenu.Controls.Add(this.CheckButton);
            this.LeftMenu.Controls.Add(this.EncrtpyButton);
            this.LeftMenu.Controls.Add(this.ManualButton);
            this.LeftMenu.Controls.Add(this.LogoBox);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu.Margin = new System.Windows.Forms.Padding(2);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(176, 480);
            this.LeftMenu.TabIndex = 0;
            // 
            // SetButton
            // 
            this.SetButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SetButton.FlatAppearance.BorderSize = 0;
            this.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SetButton.ForeColor = System.Drawing.Color.White;
            this.SetButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SetButton.IconColor = System.Drawing.Color.White;
            this.SetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SetButton.IconSize = 36;
            this.SetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetButton.Location = new System.Drawing.Point(0, 420);
            this.SetButton.Margin = new System.Windows.Forms.Padding(2);
            this.SetButton.Name = "SetButton";
            this.SetButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SetButton.Size = new System.Drawing.Size(176, 60);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Setting";
            this.SetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CheckButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckButton.FlatAppearance.BorderSize = 0;
            this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CheckButton.ForeColor = System.Drawing.Color.White;
            this.CheckButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.CheckButton.IconColor = System.Drawing.Color.White;
            this.CheckButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CheckButton.IconSize = 36;
            this.CheckButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckButton.Location = new System.Drawing.Point(0, 225);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CheckButton.Size = new System.Drawing.Size(176, 60);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "Check Password";
            this.CheckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // EncrtpyButton
            // 
            this.EncrtpyButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EncrtpyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncrtpyButton.FlatAppearance.BorderSize = 0;
            this.EncrtpyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncrtpyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EncrtpyButton.ForeColor = System.Drawing.Color.White;
            this.EncrtpyButton.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.EncrtpyButton.IconColor = System.Drawing.Color.White;
            this.EncrtpyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EncrtpyButton.IconSize = 36;
            this.EncrtpyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncrtpyButton.Location = new System.Drawing.Point(0, 165);
            this.EncrtpyButton.Margin = new System.Windows.Forms.Padding(2);
            this.EncrtpyButton.Name = "EncrtpyButton";
            this.EncrtpyButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EncrtpyButton.Size = new System.Drawing.Size(176, 60);
            this.EncrtpyButton.TabIndex = 2;
            this.EncrtpyButton.Text = "Encryption";
            this.EncrtpyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EncrtpyButton.UseVisualStyleBackColor = true;
            this.EncrtpyButton.Click += new System.EventHandler(this.EncrtpyButton_Click);
            // 
            // ManualButton
            // 
            this.ManualButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ManualButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManualButton.FlatAppearance.BorderSize = 0;
            this.ManualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ManualButton.ForeColor = System.Drawing.Color.White;
            this.ManualButton.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.ManualButton.IconColor = System.Drawing.Color.White;
            this.ManualButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManualButton.IconSize = 36;
            this.ManualButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualButton.Location = new System.Drawing.Point(0, 105);
            this.ManualButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ManualButton.Size = new System.Drawing.Size(176, 60);
            this.ManualButton.TabIndex = 0;
            this.ManualButton.Text = "Manual";
            this.ManualButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 36;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 285);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(176, 60);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Practice";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(804, 480);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.TextBar);
            this.Controls.Add(this.LeftMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TextBar.ResumeLayout(false);
            this.TextBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.LogoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.LeftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TextBar;
        private AdsJumboWinForm.BannerAds bannerAds1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LogoBox;
        private System.Windows.Forms.PictureBox MainLogo;
        private FontAwesome.Sharp.IconButton ManualButton;
        private FontAwesome.Sharp.IconButton EncrtpyButton;
        private FontAwesome.Sharp.IconButton CheckButton;
        private FontAwesome.Sharp.IconButton SetButton;
        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

