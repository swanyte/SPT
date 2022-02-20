using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;


namespace spt_0._1.Forms
{
    public partial class Sign2 : Form
    {
        private Form sign;
        FirestoreDb db;

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
                string id = Sign.ID;
                string pw = Sign.PW;
                string platform = cloudPlatform.Text;
                string folder = folderName.Text;

                Join(id, pw, platform, folder);

                this.Close();
            }
            
        }

        void Join(string id, string pw, string plat, string fold)
        {
            DocumentReference DOC = db.Collection("Join").Document(id);
            Dictionary<string, object> data1 = new Dictionary<string, object>()
    {
        {"Id", id },
        {"Password", pw },
        {"Platorm", plat },
        {"Folder", fold },
    };
            DOC.SetAsync(data1);
        }


        private void Sign2_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"pbl-spt-firebase-adminsdk-1ohie-c9959871c2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("pbl-spt");
        }
    }
}
