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
    public partial class FormSetting : Form
    {
        private Form loginForm;


        public FormSetting()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm = new Login();
            loginForm.Show();
            this.Owner.Close();
            
        }
    }
}
