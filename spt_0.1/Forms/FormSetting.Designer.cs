﻿
namespace spt_0._1.Forms
{
    partial class FormSetting
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
            this.interstitialAd1 = new AdsJumboWinForm.InterstitialAd();
            this.SuspendLayout();
            // 
            // interstitialAd1
            // 
            this.interstitialAd1.ApplicationId = null;
            this.interstitialAd1.BackColor = System.Drawing.Color.Black;
            this.interstitialAd1.Location = new System.Drawing.Point(695, 74);
            this.interstitialAd1.Name = "interstitialAd1";
            this.interstitialAd1.Size = new System.Drawing.Size(50, 50);
            this.interstitialAd1.TabIndex = 0;
            this.interstitialAd1.Visible = false;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 504);
            this.Controls.Add(this.interstitialAd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private AdsJumboWinForm.InterstitialAd interstitialAd1;
    }
}