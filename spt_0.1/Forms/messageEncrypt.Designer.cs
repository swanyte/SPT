namespace spt_0._1.Forms
{
    partial class messageEncrypt
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.barpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // barpanel
            // 
            this.barpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.barpanel.Controls.Add(this.MsgExitButton);
            this.barpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barpanel.Location = new System.Drawing.Point(0, 0);
            this.barpanel.Name = "barpanel";
            this.barpanel.Size = new System.Drawing.Size(320, 21);
            this.barpanel.TabIndex = 1;
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
            this.MsgExitButton.Location = new System.Drawing.Point(302, 0);
            this.MsgExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MsgExitButton.Name = "MsgExitButton";
            this.MsgExitButton.Size = new System.Drawing.Size(18, 21);
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
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Word file has been encrypted!";
            // 
            // ButtonYes
            // 
            this.ButtonYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(133)))), ((int)(((byte)(174)))));
            this.ButtonYes.FlatAppearance.BorderSize = 0;
            this.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonYes.ForeColor = System.Drawing.Color.White;
            this.ButtonYes.Location = new System.Drawing.Point(118, 113);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(75, 25);
            this.ButtonYes.TabIndex = 7;
            this.ButtonYes.Text = "Ok";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(318, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 151);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 2);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 2);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 2);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 149);
            this.panel6.TabIndex = 10;
            // 
            // messageEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(320, 172);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "messageEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "messageEncrypt";
            this.barpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barpanel;
        private FontAwesome.Sharp.IconButton MsgExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}