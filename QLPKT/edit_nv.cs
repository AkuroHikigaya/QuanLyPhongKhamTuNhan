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
    public partial class edit_nv : Form
    {

        public SqlConnection conn;
        public void ketnoi()
        {
            string chuoiketnoi = "SERVER = DESKTOP-33H3AUS ; database = QLPKTN; Integrated Security = True; MultipleActiveResultSets = true";
            conn = new SqlConnection();
            conn.ConnectionString = chuoiketnoi;
            conn.Open();
        }
        public string gioitinh = "";

        
        public edit_nv()
        {
            ketnoi();
            InitializeComponent();
            Function f = new Function();
            f.LoadDLCB("select * from NHAN_VIEN", comboBox1, "ROLE", "ROLE", conn);
            f.LoadDLCB("select * from CHUC_VU", comboBox2, "CV_TENCHUCVU", "CV_ID", conn);
        }

        private string id, name, role;
        public edit_nv(string id, string name, string role)
        {
            this.id = id;
            this.name = name;
            this.role = role;
            ketnoi();
            InitializeComponent();
            Function f = new Function();
            f.LoadDLCB("select * from NHAN_VIEN", comboBox1, "ROLE", "ROLE", conn);
            f.LoadDLCB("select * from CHUC_VU", comboBox2, "CV_TENCHUCVU", "CV_ID", conn);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            thongtin_nv tt = new thongtin_nv(id, name, role);
            tt.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "update NHAN_VIEN set CV_ID=N'" + comboBox2.SelectedValue.ToString() + "', NV_TEN=N'" + textBox3.Text + "',NV_NGAYSINH='" + textBox5.Text + "',NV_EMAIL=N'" + textBox7.Text + "',NV_GIOITINH=N'" + gioitinh + "',  NV_SDT='" + textBox9.Text + "', NV_ANH='" + textBox11.Text + "', NV_TAIKHOAN='" + textBox22.Text + "', NV_MATKHAU=N'" + textBox21.Text + "', BS_BANGCAP=N'" + textBox14.Text + "', BS_CHUYENMON=N'" + textBox19.Text + "',ROLE=N'" + comboBox1.SelectedValue.ToString() + "'  where NV_ID='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Function f = new Function();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                gioitinh = "Nam";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                gioitinh = "Nữ";
            }
        }
        
    }
}
