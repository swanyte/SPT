using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Word = Microsoft.Office.Interop.Word;
using Google.Cloud.Firestore; // 파이어베이스 연동
using Microsoft.Office.Interop.Word;

namespace spt_0._1.Forms
{    
    public partial class FormCheck : Form
    {
        private Form messageCheck;
        FirestoreDb db; // 디비 선언


        /*
        string _server = ""; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "test"; //DB 이름
        string _id = "sis4"; //계정 아이디
        string _pw = "sis4"; //계정 비밀번호
        string _connectionAddress = "";
        */
        public string file_path = "";
        public string select_path = "";
        public string sel_pwd = "0";

        

        public FormCheck()
        {
            InitializeComponent();
            this.AutoSize = false;

            //MySQL 연결을 위한 주소 형식
            //_connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};SSL Mode=None", _server, _port, _database, _id, _pw);


        }
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }



        private void FormCheck_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"pbl-spt-firebase-adminsdk-1ohie-c9959871c2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("pbl-spt");
        }

        /*
        private void selectTable()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    file_path = textBox1.Text;
                    select_path = file_path.Replace("\\", "/");
                    textBox1.Text = select_path;


                    string selectQuery = string.Format("SELECT * FROM test WHERE file_path='{0}'", select_path);

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);

                    MySqlDataReader table = command.ExecuteReader();

                    //listView1.Items.Clear();

                    while (table.Read())
                    {
                        //ListViewItem item = new ListViewItem();

                        //item.SubItems.Add(table["file_path"].ToString());
                        //item.SubItems.Add(table["file_pwd"].ToString());

                        //listView1.Items.Add(item);
                        richTextBox1.Text = table["file_pwd"].ToString();
                        sel_pwd = richTextBox1.Text;
                    }


                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        */


        async void selectTable()
        {
            
            file_path = textBox1.Text;
            string id = Login.ID;
            
            Query qref = db.Collection("Join").Document(id).Collection("File").WhereEqualTo("Path", file_path);
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                FirebaseProperty fp = docsnap.ConvertTo<FirebaseProperty>();
                if (docsnap.Exists)
                {
                    richTextBox1.Text = fp.Password;
                    sel_pwd = fp.Password;
                }
            }
            if (sel_pwd == "0")
            {
                richTextBox1.Text = "It's not encrypted.";
            }

            else
            {
                var WordApp = new Word.Application();
                WordApp.Visible = true;
                WordApp.Documents.Open(file_path, ReadOnly: false, PasswordDocument: sel_pwd);
                Word.Document doc = WordApp.ActiveDocument;

                Microsoft.Office.Interop.Word.Application objWord;
                objWord = (Microsoft.Office.Interop.Word.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");
                for (int i = 0; i < objWord.Windows.Count; i++)
                {
                    object a = i + 1;
                    Window objWin = objWord.Windows.get_Item(ref a);
                    MessageBox.Show(objWin.Caption + objWord.Windows.Count);
                }

                messageCheck = new Forms.messageCheck();
                messageCheck.ShowDialog();


                

            }



        }

        /*
        async Task<bool> FindFile(string id, string pass)
        {
            Query qref = db.Collection("Join").WhereEqualTo("Id", id).WhereEqualTo("Pass", pass);
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
        */

        private void openButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Login.ID);
            textBox1.Clear();
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                textBox1.Text = file_path;
            }
        }



        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            selectTable();

            
        }
    }

}
