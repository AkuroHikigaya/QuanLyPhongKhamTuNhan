﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLPKT
{
    public partial class thongtin_nv : Form
    {
        public SqlConnection conn;
        public thongtin_nv()
        {
            Function F = new Function();
            conn = F.connect();
            InitializeComponent();
            F.HienThiDG(dataGridView1, "select nv.nv_id as 'Mã NV' , cv.cv_tenchucvu as 'Chức vụ', nv.nv_ten as 'Họ tên' , FORMAT(nv.nv_ngaysinh, 'dd/MM/yyyy') as 'Ngày sinh', nv.nv_gioitinh as 'Giới tính', nv.nv_email as Email, nv.nv_sdt as SĐT,nv.bs_bangcap as 'Bằng cấp', nv.bs_chuyenmon as 'Chuyên môn', nv.nv_taikhoan as 'Tên đăng nhập', nv.nv_matkhau as 'Mật khẩu', nv.role as 'Vai trò',  nv.nv_anh as 'Link ảnh' from NHAN_VIEN nv, CHUC_VU cv where nv.cv_id = cv.cv_id; ", conn);
            dataGridView1.Columns["Link ảnh"].Visible = false;
            dataGridView1.Columns["Mật khẩu"].Visible = false;
            dataGridView1.Columns["Tên đăng nhập"].Visible = false;
        }

        private string id, name, role;
        public thongtin_nv(string id, string name, string role)
        {
            InitializeComponent();
            Function F = new Function();
            conn = F.connect();
            F.HienThiDG(dataGridView1, "select nv.nv_id as 'Mã NV' , cv.cv_tenchucvu as 'Chức vụ', nv.nv_ten as 'Họ tên' , FORMAT(nv.nv_ngaysinh, 'dd/MM/yyyy') as 'Ngày sinh', nv.nv_gioitinh as 'Giới tính', nv.nv_email as Email, nv.nv_sdt as SĐT,nv.bs_bangcap as 'Bằng cấp', nv.bs_chuyenmon as 'Chuyên môn', nv.nv_taikhoan as 'Tên đăng nhập', nv.nv_matkhau as 'Mật khẩu', nv.role as 'Vai trò',  nv.nv_anh as 'Link ảnh' from NHAN_VIEN nv, CHUC_VU cv where nv.cv_id = cv.cv_id; ", conn);

            dataGridView1.Columns["Link ảnh"].Visible = false;
            dataGridView1.Columns["Mật khẩu"].Visible = false;
            dataGridView1.Columns["Tên đăng nhập"].Visible = false;
            this.id = id;
            this.name = name;
            this.role = role;
        }


        private string manv, tennv, ngaysinh, gioitinh, email, sdt, chucvu, taikhoan, matkhau, quyenhan, bangcap, chuyenmon, anh;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            manv = selectedRow.Cells[0].Value.ToString();
            tennv = selectedRow.Cells[2].Value.ToString();
            ngaysinh = selectedRow.Cells[3].Value.ToString();
            gioitinh = selectedRow.Cells[4].Value.ToString();
            email = selectedRow.Cells[5].Value.ToString();
            sdt = selectedRow.Cells[6].Value.ToString();
            chucvu = selectedRow.Cells[1].Value.ToString();
            taikhoan = selectedRow.Cells[9].Value.ToString();
            matkhau = selectedRow.Cells[10].Value.ToString();
            quyenhan = selectedRow.Cells[11].Value.ToString();
            bangcap = selectedRow.Cells[7].Value.ToString();
            chuyenmon = selectedRow.Cells[8].Value.ToString();
            anh = selectedRow.Cells[12].Value.ToString();


            pn_overlay.Visible = false;
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            // Set the PictureBox control's BorderStyle property to None
            picb_avt.BorderStyle = BorderStyle.None;

            // Create a new GraphicsPath object with a rounded rectangle shape
            GraphicsPath path = new GraphicsPath();
            int borderRadius = 20; // Change this value to adjust the amount of rounding
            Rectangle bounds = new Rectangle(0, 0, picb_avt.Width, picb_avt.Height);
            path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            // Set the PictureBox control's Region property to a new Region object created from the GraphicsPath object
            picb_avt.Region = new Region(path);


            picb_avt.BackgroundImageLayout = ImageLayout.Center;
            picb_avt.SizeMode = PictureBoxSizeMode.StretchImage;


            string imagePath = Path.Combine("ProFile_Images", dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString());
            if (File.Exists(imagePath))
            {
                picb_avt.Image = Image.FromFile(imagePath);
            }
            else
            {
                picb_avt.Image = Image.FromFile(imagePath = Path.Combine("ProFile_Images", "default.png"));
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            admin_home adh = new admin_home(id, name, role);
            adh.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Function H = new Function();
                H.HienThiDG(dataGridView1, "select nv.nv_id as 'Mã NV', cv.cv_tenchucvu as 'Chức vụ', nv.nv_ten as 'Họ tên', FORMAT(nv.nv_ngaysinh, 'dd/MM/yyyy') as 'Ngày sinh', nv.nv_gioitinh as 'Giới tính', nv.nv_email as Email, nv.nv_sdt as SĐT, nv.bs_bangcap as 'Bằng cấp', nv.bs_chuyenmon as 'Chuyên môn', nv.nv_taikhoan as 'Tên đăng nhập', nv.nv_matkhau as 'Mật khẩu', nv.role as 'Vai trò', nv.nv_anh as 'Link ảnh' from NHAN_VIEN nv join CHUC_VU cv on cv.cv_id = nv.cv_id where nv.nv_ten like N'%" + textBox1.Text + "%' OR cv.cv_tenchucvu like N'%" + textBox1.Text + "%' OR nv.nv_gioitinh like N'%" + textBox1.Text + "%' OR nv.nv_sdt like N'%" + textBox1.Text + "%' ", conn);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            sign_in si = new sign_in(id, name, role);
            si.Tag = this.Tag;
            si.Show();
            this.Hide();

        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu từ dòng được chọn
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            manv = selectedRow.Cells[0].Value.ToString();
            tennv = selectedRow.Cells[2].Value.ToString();
            ngaysinh = selectedRow.Cells[3].Value.ToString();
            gioitinh = selectedRow.Cells[4].Value.ToString();
            email = selectedRow.Cells[5].Value.ToString();
            sdt = selectedRow.Cells[6].Value.ToString();
            chucvu = selectedRow.Cells[1].Value.ToString();
            taikhoan = selectedRow.Cells[9].Value.ToString();
            matkhau = selectedRow.Cells[10].Value.ToString();
            quyenhan = selectedRow.Cells[11].Value.ToString();
            bangcap = selectedRow.Cells[7].Value.ToString();
            chuyenmon = selectedRow.Cells[8].Value.ToString();
            anh = selectedRow.Cells[12].Value.ToString();


            // Mở form edit_nv
            edit_nv frm = new edit_nv(manv, tennv, ngaysinh, gioitinh, email, sdt, taikhoan, matkhau, quyenhan, bangcap, chuyenmon, chucvu, anh, id, name, role);
            frm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pn_overlay.Visible == false)
            {
                edit_nv frm = new edit_nv(manv, tennv, ngaysinh, gioitinh, email, sdt, taikhoan, matkhau, quyenhan, bangcap, chuyenmon, chucvu, anh, id, name, role);
                frm.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Chọn nhân viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pn_overlay.Visible == false)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = "delete from NHAN_VIEN where NV_ID='" + textBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    Function F = new Function();
                    F.HienThiDG(dataGridView1, "select nv.nv_id as 'Mã NV' , cv.cv_tenchucvu as 'Chức vụ', nv.nv_ten as 'Họ tên' , FORMAT(nv.nv_ngaysinh, 'dd/MM/yyyy') as 'Ngày sinh', nv.nv_gioitinh as 'Giới tính', nv.nv_email as Email, nv.nv_sdt as SĐT,nv.bs_bangcap as 'Bằng cấp', nv.bs_chuyenmon as 'Chuyên môn', nv.nv_taikhoan as 'Tên đăng nhập', nv.nv_matkhau as 'Mật khẩu', nv.role as 'Vai trò',  nv.nv_anh as 'Link ảnh' from NHAN_VIEN nv, CHUC_VU cv where nv.cv_id = cv.cv_id; ", conn);

                    dataGridView1.Columns["Link ảnh"].Visible = false;
                    dataGridView1.Columns["Mật khẩu"].Visible = false;
                    dataGridView1.Columns["Tên đăng nhập"].Visible = false;
                    pn_overlay.Visible = true;
                }                
            }
            else
            {
                MessageBox.Show("Chọn nhân viên để xoá!", "Xác nhận xoá?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        
    }
}
