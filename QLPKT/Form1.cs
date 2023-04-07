using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLPKT
{
    public partial class Form1 : Form
    {

        public SqlConnection conn;
        public void connect()
        {
            //string connstring = "server = DESKTOP-33H3AUS; database = QLPK; Integrated Security = True";
            //conn = new SqlConnection();
            //conn.ConnectionString = connstring;
            Function f = new Function();
            conn = f.connect();
        }

        public Form1()
        {
            InitializeComponent();
            connect();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login() {
            Function f = new Function();
            f.connect();
            string us = tb_username.Text;
            string pw = tb_password.Text;
            if (us != "" && pw != "")
            {
                string sql = "select nv_id, nv_ten, role from NHAN_VIEN where nv_taikhoan = @us and nv_matkhau = @pw";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@us", us);
                command.Parameters.AddWithValue("@pw", pw);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    string role = reader.GetString(2);
                    if (role == "Admin" || role == "Bác sĩ")
                    {
                        admin_home adm = new admin_home(id, name, role);
                        adm.Show();
                        this.Hide();
                    }
                    else
                    {
                        //Chuyen trang chu o day
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
            else {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void enterLogin(KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            enterLogin(e);
        }

        private void tb_password_KeyDown_1(object sender, KeyEventArgs e)
        {
            enterLogin(e);

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            if (tb_username.Text != "")
            {
                lb_hint_us.Text = "";
            }
            else {
                lb_hint_us.Text = "Nhập tên tài khoản";
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_password.Text != "")
            {
                lb_hint_pw.Text = "";
            }
            else
            {
                lb_hint_pw.Text = "Nhập tên tài khoản";
            }
        }



        private Boolean pwshow = false;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pwshow)
            {
                pictureBox5.BackgroundImage = Properties.Resources.eye_show;
                pwshow = false;
                tb_password.PasswordChar = '*';

            }
            else {
                pictureBox5.BackgroundImage = Properties.Resources.eye_hide;
                pwshow = true;
                tb_password.PasswordChar = '\0';
            }
        }

    }
}
