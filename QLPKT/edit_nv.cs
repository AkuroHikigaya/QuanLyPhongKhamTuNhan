using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLPKT
{
    public partial class edit_nv : Form
    {

        public SqlConnection conn;
        public void ketnoi()
        {
            Function f = new Function();
            conn = f.connect();
        }
        public string gioitinh = "";
        private string manv;
        private string tennv;
        private string ngaysinh;
        private string email;
        private string sdt;
        private string chucvu;
        private string taikhoan;
        private string matkhau;
        private string quyenhan;
        private string bangcap;
        private string chuyenmon;
        private string anh;


        private string id, name, role;

        public edit_nv(string manv, string tennv, string ngaysinh, string gioitinh, string email, string sdt, string taikhoan, string matkhau, string quyenhan, string bangcap, string chuyenmon, string chucvu, string anh, string id, string name, string role)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.role = role;
            // Lưu các giá trị vào các biến
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.email = email;
            this.sdt = sdt;
            this.chucvu = chucvu;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.quyenhan = quyenhan;
            this.bangcap = bangcap;
            this.chuyenmon = chuyenmon;
            this.anh = anh;


            Function f = new Function();
            conn = f.connect();
            f.LoadDLCB("select * from CHUC_VU", comboBox2, "CV_TENCHUCVU", "CV_ID", conn);
            // Hiển thị các giá trị lên các textbox tương ứng
            textBox1.Text = manv;
            textBox3.Text = tennv;
            textBox5.Text = ngaysinh;
            if (gioitinh == "Nam")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            textBox7.Text = email;
            textBox9.Text = sdt;
            comboBox1.SelectedItem = quyenhan;
            comboBox2.SelectedItem = chucvu;
            textBox22.Text = taikhoan;
            textBox21.Text = matkhau;
            textBox14.Text = bangcap;
            textBox19.Text = chuyenmon;

            pictureBox10.BackgroundImageLayout = ImageLayout.Center;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            string projectPath = Application.StartupPath;
            string imagePath = projectPath + @"\ProFile_Images\";
            if (anh != "")
            {
                
                string filePath = imagePath + anh;
                pictureBox10.Image = Image.FromFile(filePath);
            }
            else {
                string filePath = imagePath + "default.png";
                pictureBox10.Image = Image.FromFile(filePath);
            }
        }


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


        private string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox control
                pictureBox10.Image = Image.FromFile(dialog.FileName);
                pictureBox10.BackgroundImageLayout = ImageLayout.Center;
                pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

                // Save the image to a folder in the project directory
                string projectPath = Application.StartupPath;
                string imagePath = projectPath + @"\ProFile_Images\"; // Change this to the subfolder path you want to use

                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                fileName = new Random().Next(9999).ToString() + "_" + Path.GetFileName(dialog.FileName);
                string filePath = imagePath + fileName;
                pictureBox10.Image.Save(filePath);
                textBox11.Text = fileName;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "update NHAN_VIEN set CV_ID=N'" + comboBox2.SelectedValue.ToString() + "', NV_TEN=N'" + textBox3.Text + "',NV_NGAYSINH='" + textBox5.Text + "',NV_EMAIL=N'" + textBox7.Text + "',NV_GIOITINH=N'" + gioitinh + "',  NV_SDT='" + textBox9.Text + "', NV_ANH='" + textBox11.Text + "', NV_TAIKHOAN='" + textBox22.Text + "', NV_MATKHAU=N'" + textBox21.Text + "', BS_BANGCAP=N'" + textBox14.Text + "', BS_CHUYENMON=N'" + textBox19.Text + "',ROLE=N'" + comboBox1.SelectedItem.ToString() + "'  where NV_ID='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Function f = new Function();
            thongtin_nv tt = new thongtin_nv(id, name, role);
            tt.Show();
            this.Hide();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked)
            {
                return;
            }
            radioButton2.Checked = false;
            gioitinh = "Nam";

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
