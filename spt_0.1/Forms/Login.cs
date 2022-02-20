using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore; // 파이어베이스 연동

namespace spt_0._1.Forms
{
    public partial class Login : Form
    {

        private Form sign1;
        private Form form1;

        FirestoreDb db; // 디비 선언

        public static string ID;


        public Login()
        {
            InitializeComponent();
        }
        
        //public string ID { get; set; }

        private void openButton_Click(object sender, EventArgs e)
        {
            sign1 = new Forms.Sign();
            sign1.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string id = comID.Text;
            string pw = comPW.Text;

            form1 = new MainForm();
            if (!String.IsNullOrWhiteSpace(id) && !String.IsNullOrWhiteSpace(pw))
            {                
                
            }
            else
            {
                MessageBox.Show("Please enter your Company ID and password");
            }
            ID = id;
            LoginManagement(id, pw);
            
        }

        private async void LoginManagement(string id, string pw)
        {
            bool idCheck = await FindId(id, pw);
            if (idCheck) //id, pass 일치
            {
                MessageBox.Show("로그인 되었습니다.");
                form1.Show();
                this.Close();
            }
            else if (!idCheck) //id, pass 일치하지 않음
            {
                MessageBox.Show("로그인에 실패하였습니다.");
            }
        }

        async Task<bool> FindId(string id, string pw)
        {
            Query qref = db.Collection("Join").WhereEqualTo("Id", id).WhereEqualTo("Password", pw);
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"pbl-spt-firebase-adminsdk-1ohie-c9959871c2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("pbl-spt");
        }
                

    }
}
