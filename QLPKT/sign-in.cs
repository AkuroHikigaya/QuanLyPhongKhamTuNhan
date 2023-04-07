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
using System.IO;
using System.Collections;

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

        private string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox control
                pictureBox10.Image = Image.FromFile(dialog.FileName);
                pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;

                // Save the image to a folder in the project directory
                string projectPath = Application.StartupPath;
                string imagePath = projectPath + @"\ProFile_Images\"; // Change this to the subfolder path you want to use

                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                fileName = new Random().Next(9999).ToString() + "_" + Path.GetFileName(dialog.FileName) ;
                string filePath = imagePath + fileName;
                pictureBox10.Image.Save(filePath);
                textBox11.Text = fileName;
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox2.SelectedValue.ToString() != "" && textBox3.Text != "" && textBox5.Text != "" && textBox7.Text != "" && gioitinh != "" && textBox9.Text != "" && textBox22.Text != "" && textBox21.Text != "" && textBox14.Text != "" && textBox19.Text != ""  )
            {
                Function f = new Function();
                string sql = "select count(NV_ID) from NHAN_VIEN where NV_ID = '" + textBox1.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int have_nv = (int)cmd.ExecuteScalar();
                if (have_nv == 0)
                {
                    if (textBox1.Text.StartsWith("NV_"))
                    {
                    f.Them(textBox1.Text, comboBox2.SelectedValue.ToString(), textBox3.Text, textBox5.Text, textBox7.Text, gioitinh, textBox9.Text, textBox11.Text, textBox22.Text, textBox21.Text, textBox14.Text, textBox19.Text, role, conn);
                    thongtin_nv ttnv = new thongtin_nv(tagid, tagname, tagrole);
                    MessageBox.Show("Thêm nhân viên thành công !");
                    ttnv.Show();
                    this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Nhân viên id phải có định dạng bắt đầu là NV_(Số thứ tự ngẫu nhiên) !");
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            thongtin_nv ttnv = new thongtin_nv(tagid, tagname, tagrole);
            ttnv.Show();
            this.Hide();
        }

        
        
    }
}
