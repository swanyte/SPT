using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace spt_0._1
{
    public partial class Loading : Form
    {
        Random random = new Random();
        [DllImport("GDi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottonRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public Loading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ProgressBar.Value = 0;
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value == 100)
            {
                timer1.Enabled = false;
                Forms.Login login_form = new Forms.Login();
                login_form.Show();
                this.Hide();
            }
            else
            {
                if (ProgressBar.Value < 90)
                {
                    ProgressBar.Value += random.Next(1, 5);
                }
                else
                {
                    ProgressBar.Value += 1;
                }
                ProgressBar.Text = ProgressBar.Value.ToString() + "%";

            }



        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
