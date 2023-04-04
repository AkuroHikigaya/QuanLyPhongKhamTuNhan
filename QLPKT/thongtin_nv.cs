using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            label16.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            string imagePath = Path.Combine("ProFile_Images", dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString());
            if (File.Exists(imagePath))
            {
                picb_avt.Image = Image.FromFile(imagePath);
            }
            else
            {
                picb_avt.Image = Image.FromFile(imagePath = Path.Combine("ProFile_Images", "default.png"));
            }
            picb_avt.BackgroundImageLayout = ImageLayout.Stretch;


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
                //S
                H.HienThiDG(dataGridView1, "select nv.nv_id as 'Mã NV' , cv.cv_tenchucvu as 'Chức vụ', nv.nv_ten as 'Họ tên' , FORMAT(nv.nv_ngaysinh, 'dd/MM/yyyy') as 'Ngày sinh', nv.nv_gioitinh as 'Giới tính', nv.nv_email as Email, nv.nv_sdt as SĐT,nv.bs_bangcap as 'Bằng cấp', nv.bs_chuyenmon as 'Chuyên môn', nv.nv_taikhoan as 'Tên đăng nhập', nv.nv_matkhau as 'Mật khẩu', nv.role as 'Vai trò',  nv.nv_anh as 'Link ảnh' from NHAN_VIEN where NV_TEN like N'%" + textBox1.Text + "%' OR 'Chức vụ' like N'%" + textBox1.Text + "%' OR 'Giới tính' like N'%" + textBox1.Text + "%' OR 'SĐT' like N'%" + textBox1.Text + "%' ", conn);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            sign_in si = new sign_in(id, name, role);
            si.Tag = this.Tag;
            si.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_nv edit = new edit_nv(id, name, role);
            edit.Tag = this.Tag;
            edit.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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
}
