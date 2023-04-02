using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKT
{
    public partial class sign_in : Form
    {

        public SqlConnection conn;
        public string gioitinh = "";
        /*
        public sign_in()
        {
            Function f = new Function();
            conn = f.connect();
            InitializeComponent();
            f.LoadDLCB("select * from CHUC_VU", comboBox2, "CV_TENCHUCVU", "CV_ID", conn);
        }
        */
        private string tagid, tagname, tagrole;
        public sign_in(string id, string name, string role)
        {
            InitializeComponent();
            Function f = new Function();
            conn = f.connect();
            this.tagid = id;
            this.tagname = name;
            this.tagrole = role;
            f.LoadDLCB("select * from CHUC_VU", comboBox2, "CV_TENCHUCVU", "CV_ID", conn);
        }

        private string role;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = comboBox1.SelectedItem.ToString();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                gioitinh = "Nam";
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                gioitinh = "Nữ";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Function f = new Function();
            f.Them(textBox1.Text, comboBox2.SelectedValue.ToString(), textBox3.Text, textBox5.Text, textBox7.Text, gioitinh, textBox9.Text, textBox11.Text, textBox22.Text, textBox21.Text, textBox14.Text, textBox19.Text, role, conn);
            thongtin_nv ttnv = new thongtin_nv(tagid, tagname, tagrole);
            ttnv.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            thongtin_nv ttnv = new thongtin_nv(tagid, tagname, tagrole);
            ttnv.Show();
            this.Hide();
        }

        
        
    }
}
