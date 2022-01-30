using System;
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
    public partial class Sign : Form
    {
        private Form sign2;

        public Sign()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextSign2Button_Click(object sender, EventArgs e)
        {
            sign2 = new Sign2();
            sign2.Show();
            this.Close();
        }
    }
}
