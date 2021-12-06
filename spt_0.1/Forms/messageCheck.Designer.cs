namespace spt_0._1.Forms
{
    partial class messageCheck
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
            this.barpanel = new System.Windows.Forms.Panel();
            this.MsgExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.barpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barpanel
            // 
            this.barpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.barpanel.Controls.Add(this.MsgExitButton);
            this.barpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barpanel.Location = new System.Drawing.Point(0, 0);
            this.barpanel.Margin = new System.Windows.Forms.Padding(4);
            this.barpanel.Name = "barpanel";
            this.barpanel.Size = new System.Drawing.Size(646, 32);
            this.barpanel.TabIndex = 2;
            // 
            // MsgExitButton
            // 
            this.MsgExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MsgExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MsgExitButton.FlatAppearance.BorderSize = 0;
            this.MsgExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgExitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.MsgExitButton.IconColor = System.Drawing.Color.White;
            this.MsgExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgExitButton.IconSize = 18;
            this.MsgExitButton.Location = new System.Drawing.Point(619, 0);
            this.MsgExitButton.Name = "MsgExitButton";
            this.MsgExitButton.Size = new System.Drawing.Size(27, 32);
            this.MsgExitButton.TabIndex = 5;
            this.MsgExitButton.UseVisualStyleBackColor = true;
            this.MsgExitButton.Click += new System.EventHandler(this.MsgExitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(55, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "The word file has been opened automatically!";
            // 
            // ButtonYes
            // 
            this.ButtonYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(133)))), ((int)(((byte)(174)))));
            this.ButtonYes.FlatAppearance.BorderSize = 0;
            this.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonYes.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.Location = new System.Drawing.Point(260, 170);
            this.ButtonYes.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(112, 38);
            this.ButtonYes.TabIndex = 8;
            this.ButtonYes.Text = "Ok";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // messageCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(646, 258);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messageCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "messageCheck";
            this.barpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barpanel;
        private FontAwesome.Sharp.IconButton MsgExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonYes;
    }
}