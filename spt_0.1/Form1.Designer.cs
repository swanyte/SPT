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
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.SetButton = new FontAwesome.Sharp.IconButton();
            this.CheckButton = new FontAwesome.Sharp.IconButton();
            this.EncrtpyButton = new FontAwesome.Sharp.IconButton();
            this.ManualButton = new FontAwesome.Sharp.IconButton();
            this.LogoBox = new System.Windows.Forms.Panel();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.TextBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.LeftMenu.SuspendLayout();
            this.LogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.TextBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.LeftMenu.Controls.Add(this.SetButton);
            this.LeftMenu.Controls.Add(this.CheckButton);
            this.LeftMenu.Controls.Add(this.EncrtpyButton);
            this.LeftMenu.Controls.Add(this.ManualButton);
            this.LeftMenu.Controls.Add(this.LogoBox);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu.Margin = new System.Windows.Forms.Padding(2);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(210, 441);
            this.LeftMenu.TabIndex = 0;
            // 
            // SetButton
            // 
            this.SetButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SetButton.FlatAppearance.BorderSize = 0;
            this.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.SetButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SetButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.SetButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SetButton.IconSize = 36;
            this.SetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetButton.Location = new System.Drawing.Point(0, 381);
            this.SetButton.Margin = new System.Windows.Forms.Padding(2);
            this.SetButton.Name = "SetButton";
            this.SetButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SetButton.Size = new System.Drawing.Size(210, 60);
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
            this.CheckButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.CheckButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.CheckButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.CheckButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CheckButton.IconSize = 36;
            this.CheckButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckButton.Location = new System.Drawing.Point(0, 237);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CheckButton.Size = new System.Drawing.Size(210, 60);
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
            this.EncrtpyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.EncrtpyButton.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.EncrtpyButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.EncrtpyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EncrtpyButton.IconSize = 36;
            this.EncrtpyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncrtpyButton.Location = new System.Drawing.Point(0, 177);
            this.EncrtpyButton.Margin = new System.Windows.Forms.Padding(2);
            this.EncrtpyButton.Name = "EncrtpyButton";
            this.EncrtpyButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EncrtpyButton.Size = new System.Drawing.Size(210, 60);
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
            this.ManualButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.ManualButton.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.ManualButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.ManualButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ManualButton.IconSize = 36;
            this.ManualButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManualButton.Location = new System.Drawing.Point(0, 117);
            this.ManualButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ManualButton.Size = new System.Drawing.Size(210, 60);
            this.ManualButton.TabIndex = 0;
            this.ManualButton.Text = "Manual";
            this.ManualButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.LogoBox.Controls.Add(this.MainLogo);
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBox.Location = new System.Drawing.Point(0, 0);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(210, 117);
            this.LogoBox.TabIndex = 1;
            // 
            // MainLogo
            // 
            this.MainLogo.Image = global::spt_0._1.Properties.Resources.SPT_Logo;
            this.MainLogo.Location = new System.Drawing.Point(0, 0);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(210, 117);
            this.MainLogo.TabIndex = 0;
            this.MainLogo.TabStop = false;
            this.MainLogo.Click += new System.EventHandler(this.MainLogo_Click);
            // 
            // TextBar
            // 
            this.TextBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.TextBar.Controls.Add(this.lblTitleChildForm);
            this.TextBar.Controls.Add(this.IconCurrentChildForm);
            this.TextBar.Controls.Add(this.MinimizeButton);
            this.TextBar.Controls.Add(this.MaximizeButton);
            this.TextBar.Controls.Add(this.ExitButton);
            this.TextBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBar.Location = new System.Drawing.Point(210, 0);
            this.TextBar.Margin = new System.Windows.Forms.Padding(2);
            this.TextBar.Name = "TextBar";
            this.TextBar.Size = new System.Drawing.Size(594, 75);
            this.TextBar.TabIndex = 1;
            this.TextBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(42, 46);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(41, 15);
            this.lblTitleChildForm.TabIndex = 4;
            this.lblTitleChildForm.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 36;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(3, 36);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(36, 36);
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
            this.MinimizeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 20;
            this.MinimizeButton.Location = new System.Drawing.Point(540, 3);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(16, 16);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 20;
            this.MaximizeButton.Location = new System.Drawing.Point(558, 3);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(16, 16);
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ExitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 20;
            this.ExitButton.Location = new System.Drawing.Point(576, 3);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(16, 16);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(210, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(594, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.panelDesktop.Controls.Add(this.welcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(210, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(594, 357);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.welcome.Location = new System.Drawing.Point(38, 33);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(284, 37);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to SPT!!!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.TextBar);
            this.Controls.Add(this.LeftMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LeftMenu.ResumeLayout(false);
            this.LogoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.TextBar.ResumeLayout(false);
            this.TextBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenu;
        private FontAwesome.Sharp.IconButton ManualButton;
        private System.Windows.Forms.Panel LogoBox;
        private FontAwesome.Sharp.IconButton SetButton;
        private FontAwesome.Sharp.IconButton CheckButton;
        private FontAwesome.Sharp.IconButton EncrtpyButton;
        private System.Windows.Forms.Panel TextBar;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton ExitButton;
		private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
		private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label welcome;
    }
}

