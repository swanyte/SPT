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
using Office = Microsoft.Office.Core;
using Google.Cloud.Firestore; // 파이어베이스 연동


namespace spt_0._1.Forms
{
    public partial class FormEncrypt : Form
    {

        private Form messageEncrypt;
        FirestoreDb db; // 디비 선언


        public string qpwd;

        /*
        string _server = ""; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "test"; //DB 이름
        string _id = "sis4"; //계정 아이디
        string _pw = "sis4"; //계정 비밀번호
        string _connectionAddress = "";
        */
        public string file_path = "";
        //string insert_path = "";


        public FormEncrypt()
        {
            InitializeComponent();
            this.AutoSize = false;

            //MySQL 연결을 위한 주소 형식
            //_connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};SSL Mode=None", _server, _port, _database, _id, _pw);

        }
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormEncrypt_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"pbl-spt-firebase-adminsdk-1ohie-c9959871c2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("pbl-spt");
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            String file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                textBox1.Text = file_path;
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                GeneratePW(13, rnd);

                file_path = textBox1.Text;

                var wordApp = new Word.Application();
                wordApp.Visible = true;
                wordApp.Documents.Open(file_path);
                Word.Document doc = wordApp.ActiveDocument;

                doc.Password = qpwd;
                doc.Save();
                wordApp.Quit();

                AddFile(file_path, qpwd);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            //MessageBox.Show("완료");
            messageEncrypt = new Forms.messageEncrypt();
            messageEncrypt.ShowDialog();

        }


        private void GeneratePW(int length, Random random)
        {
            //throw new NotImplementedException();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }

            qpwd = result.ToString();
            MessageBox.Show(qpwd);
            //textBox1.Text = qpwd;

        }

        private void AddFile(string path, string pw)
        {
            string id = Login.ID;
            DocumentReference DOC = db.Collection("Join").Document(id).Collection("File").Document();
            Dictionary<string, object> data1 = new Dictionary<string, object>()
    {
        {"Path", path },
        {"Password", pw },
    };
            DOC.SetAsync(data1);
            MessageBox.Show(path);
        }

        /*
        private void insertDB()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    file_path = textBox1.Text;
                    insert_path = file_path.Replace("\\", "/");


                    string insertQuery = string.Format("insert into test values( '{0}', '{1}')", insert_path, qpwd);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        //richTextBox1.Text = table["file_pwd"].ToString();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}