﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spt_0._1.Forms
{
    public partial class Sign2 : Form
    {
        private Form sign;

        public Sign2()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            sign = new Sign();
            sign.Show();
            this.Close();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Close();
            }
            
        }
    }
}
