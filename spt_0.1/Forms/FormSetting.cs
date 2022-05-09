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
    public partial class FormSetting : Form
    {
        private Form loginForm;
        FirestoreDb db;


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

        private void FormSetting_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"pbl-spt-firebase-adminsdk-1ohie-c9959871c2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("pbl-spt");

            FindInfo();
        }
        async void FindInfo()
        {
            Query qref = db.Collection("Join").WhereEqualTo("Id", Login.ID);
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                FirebaseProperty fp = docsnap.ConvertTo<FirebaseProperty>();

                if (docsnap.Exists)
                {
                    IdLabel.Text = fp.Id;
                    PlatformLabel.Text = fp.Platform;
                    FolderLabel.Text = fp.Folder;
                    MessageBox.Show(fp.Folder);


                }
            }
        }


    }
}
