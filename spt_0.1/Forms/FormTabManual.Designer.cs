﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabBack.SuspendLayout();
            this.tabMenuSelectBack.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabBack.Size = new System.Drawing.Size(554, 294);
            this.tabBack.TabIndex = 0;
            // 
            // tabMenuSelectBack
            // 
            this.tabMenuSelectBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.tabMenuSelectBack.Controls.Add(this.selectBarPanel);
            this.tabMenuSelectBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMenuSelectBack.Location = new System.Drawing.Point(0, 40);
            this.tabMenuSelectBack.Name = "tabMenuSelectBack";
            this.tabMenuSelectBack.Size = new System.Drawing.Size(554, 3);
            this.tabMenuSelectBack.TabIndex = 1;
            // 
            // selectBarPanel
            // 
            this.selectBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(199)))), ((int)(((byte)(247)))));
            this.selectBarPanel.Location = new System.Drawing.Point(0, 0);
            this.selectBarPanel.Name = "selectBarPanel";
            this.selectBarPanel.Size = new System.Drawing.Size(150, 3);
            this.selectBarPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(147)))), ((int)(((byte)(235)))));
            this.menuPanel.Controls.Add(this.btnSetting);
            this.menuPanel.Controls.Add(this.btnCheck);
            this.menuPanel.Controls.Add(this.btnEncryption);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(554, 40);
            this.menuPanel.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
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
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
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
            this.btnEncryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(199)))), ((int)(((byte)(247)))));
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
            this.tabMain.Location = new System.Drawing.Point(-2, 18);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(554, 274);
            this.tabMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(546, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "page1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "page2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "page3";
            // 
            // FormTabManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(578, 318);
            this.Controls.Add(this.tabBack);
            this.Name = "FormTabManual";
            this.Text = "FormTabManual";
            this.Load += new System.EventHandler(this.TabTest_Load);
            this.tabBack.ResumeLayout(false);
            this.tabMenuSelectBack.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}