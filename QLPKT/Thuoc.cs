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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLPKT
{
    
    public partial class Thuoc : Form
    {
        SqlConnection conn;
        Function functions = new Function();
        private string id, name, role;
        public Thuoc(string id, string name, string role)
        {
            InitializeComponent();
            conn = functions.connect();
            functions.HienThiDG(dataGridView1,"select T_ID as 'ID', T_TEN as 'Tên thuốc', T_DVT as 'ĐVT', T_GIA as 'Giá' from THUOC", conn);
            this.id = id;
            this.name = name;
            this.role = role;
        }

        private string id_Thuoc, tenthuoc, dvt, gia;

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "") {
                string query = "update THUOC set T_TEN=N'" + textBox2.Text + "', T_DVT=N'" + textBox3.Text + "',T_GIA='" + textBox4.Text + "'  where T_ID='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                functions.HienThiDG(dataGridView1, "select T_ID as 'ID', T_TEN as 'Tên thuốc', T_DVT as 'ĐVT', T_GIA as 'Giá' from THUOC", conn);
            }
            else
            {
                MessageBox.Show("Chọn thuốc để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn xoá?", "Xác nhận xoá?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    string query = "delete from THUOC where T_ID='" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xoá thuốc!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.None);
                    functions.HienThiDG(dataGridView1, "select T_ID as 'ID', T_TEN as 'Tên thuốc', T_DVT as 'ĐVT', T_GIA as 'Giá' from THUOC", conn);
                }
            }
            else
            {
                MessageBox.Show("Chọn thuốc để xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string tk = timkiem.Text;
                string query = "select T_ID as 'ID', T_TEN as 'Tên thuốc', T_DVT as 'ĐVT', T_GIA as 'Giá' from THUOC where T_ID like '%"+tk+ "%' or T_TEN like '%" + tk + "%' or T_GIA like '%" + tk + "%' or T_DVT like '%" + tk + "%' ";
                functions.HienThiDG(dataGridView1, query, conn);
            }
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin_home adh = new admin_home(id, name, role);
            adh.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string sql = "select count(*) from THUOC where T_ID = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int haved = (int)cmd.ExecuteScalar();
                if (haved == 0)
                {
                    MessageBox.Show("Thêm thuốc thành công!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.None);
                    functions.ThemThuoc(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, conn);
                    functions.HienThiDG(dataGridView1, "select * from THUOC", conn);
                }
                else {
                    MessageBox.Show("ID thuốc đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                MessageBox.Show("Vui lòng nhập thông tin thuốc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            id_Thuoc = selectedRow.Cells[0].Value.ToString();
            tenthuoc = selectedRow.Cells[1].Value.ToString();
            dvt = selectedRow.Cells[2].Value.ToString();
            gia = selectedRow.Cells[3].Value.ToString();


            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
