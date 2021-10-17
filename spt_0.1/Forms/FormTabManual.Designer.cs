
namespace spt_0._1.Forms
{
    partial class FormTabManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabManual));
            this.tabBack = new System.Windows.Forms.Panel();
            this.tabMenuSelectBack = new System.Windows.Forms.Panel();
            this.selectBarPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Label();
            this.btnEncryption = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabBack.SuspendLayout();
            this.tabMenuSelectBack.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBack
            // 
            this.tabBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.tabBack.Controls.Add(this.tabMenuSelectBack);
            this.tabBack.Controls.Add(this.menuPanel);
            this.tabBack.Controls.Add(this.tabMain);
            this.tabBack.Location = new System.Drawing.Point(12, 12);
            this.tabBack.Name = "tabBack";
            this.tabBack.Size = new System.Drawing.Size(604, 312);
            this.tabBack.TabIndex = 0;
            // 
            // tabMenuSelectBack
            // 
            this.tabMenuSelectBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(144)))), ((int)(((byte)(147)))));
            this.tabMenuSelectBack.Controls.Add(this.selectBarPanel);
            this.tabMenuSelectBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMenuSelectBack.Location = new System.Drawing.Point(0, 40);
            this.tabMenuSelectBack.Name = "tabMenuSelectBack";
            this.tabMenuSelectBack.Size = new System.Drawing.Size(604, 3);
            this.tabMenuSelectBack.TabIndex = 1;
            // 
            // selectBarPanel
            // 
            this.selectBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.selectBarPanel.Location = new System.Drawing.Point(0, 0);
            this.selectBarPanel.Name = "selectBarPanel";
            this.selectBarPanel.Size = new System.Drawing.Size(150, 3);
            this.selectBarPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(151)))), ((int)(((byte)(89)))));
            this.menuPanel.Controls.Add(this.btnSetting);
            this.menuPanel.Controls.Add(this.btnCheck);
            this.menuPanel.Controls.Add(this.btnEncryption);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(604, 40);
            this.menuPanel.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(300, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(150, 40);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(150, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 40);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnEncryption
            // 
            this.btnEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEncryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(183)))), ((int)(((byte)(182)))));
            this.btnEncryption.Location = new System.Drawing.Point(0, 0);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(150, 40);
            this.btnEncryption.TabIndex = 0;
            this.btnEncryption.Text = "Encryption";
            this.btnEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Location = new System.Drawing.Point(-4, 18);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(612, 296);
            this.tabMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(219)))), ((int)(((byte)(218)))));
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(231)))));
            this.tabPage2.Controls.Add(this.axWindowsMediaPlayer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.tabPage3.Controls.Add(this.axWindowsMediaPlayer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(604, 270);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 9);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(442, 237);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(8, 9);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(442, 237);
            this.axWindowsMediaPlayer2.TabIndex = 1;
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(8, 9);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(442, 237);
            this.axWindowsMediaPlayer3.TabIndex = 1;
            // 
            // FormTabManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 336);
            this.Controls.Add(this.tabBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTabManual";
            this.Text = "FormTabManual";
            this.Load += new System.EventHandler(this.TabTest_Load);
            this.tabBack.ResumeLayout(false);
            this.tabMenuSelectBack.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabBack;
        private System.Windows.Forms.Panel tabMenuSelectBack;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel selectBarPanel;
        private System.Windows.Forms.Label btnEncryption;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label btnSetting;
        private System.Windows.Forms.Label btnCheck;
        private System.Windows.Forms.TabPage tabPage3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
    }
}