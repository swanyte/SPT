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
    public partial class Sign : Form
    {
        public static string ID;
        public static String PW;


        private Form sign2;
        FirestoreDb db;

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
            string id = comID.Text;
            string pw = password1.Text;

            Management(id, pw);                
        }

        
        private async void Management(string id, string pw)
        {
            bool idCheck = await FindId(id);
            if (idCheck) 
            {
                MessageBox.Show("해당 아이디가 존재합니다.");
            } //id가 이미 있으므로 회원가입 X
            else if (!idCheck)
            {
                if (password1.Text == password2.Text && password1.Text != "")
                {
                    ID = comID.Text;
                    PW = password1.Text;
                    sign2 = new Sign2();
                    sign2.Show();
                    this.Close();
                }
            }

        }
        

                
        async Task<bool> FindId(string id)
        {
            Query qref = db.Collection("Join").WhereEqualTo("Id", id);
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                if (docsnap.Exists)
                {
                    return true;
                }
            }
            return false;
        }
        
       

        private void Sign_Load_1(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"pbl-spt-firebase-adminsdk-1ohie-c9959871c2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("pbl-spt");
        }
    }
}
