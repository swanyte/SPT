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


namespace spt_0._1.Forms
{
    public partial class FormCheck : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "test"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "root"; //계정 비밀번호
        string _connectionAddress = "";
        public string file_path = "";
        string select_path = "";


        public FormCheck()
        {
            InitializeComponent();
            this.AutoSize = false;

            //MySQL 연결을 위한 주소 형식
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);


        }
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }



        private void FormCheck_Load(object sender, EventArgs e)
        {

        }


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
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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



        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            selectTable();
        }
    }
}
