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
    public partial class FormTabManual : Form
    {
        public FormTabManual()
        {
            InitializeComponent();

        }

        // 전역변수
        private List<Label> menws;
        private List<Color> menw_colors;

        //Form - Load Event
        private void TabTest_Load(object sender, EventArgs e)
        {
            menws = new List<Label>();
            menws.Add(btnEncryption);
            menws.Add(btnCheck);
            menws.Add(btnLog);
            menws.Add(btnSetting);

            menw_colors = new List<Color>();
            menw_colors.Add(Color.FromArgb(252, 133, 174));
            menw_colors.Add(Color.FromArgb(252, 133, 174));
            menw_colors.Add(Color.FromArgb(252, 133, 174));
            menw_colors.Add(Color.FromArgb(252, 133, 174));


            //시작 TabPage 설정
            tabMain.SelectedIndex = 0;
        }
        private void setMenuChange(int index)
        {
            if (tabMain.SelectedIndex != index)
            {
                menws[tabMain.SelectedIndex].ForeColor = Color.White;
                menws[index].ForeColor = menw_colors[index];
                selectBarPanel.BackColor = menw_colors[index];
                selectBarPanel.Location = new Point(menws[index].Location.X, 0);
                tabMain.SelectedIndex = index;
            }
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            setMenuChange(0);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            setMenuChange(1);
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            setMenuChange(2);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            setMenuChange(3);
        }
    }

}
