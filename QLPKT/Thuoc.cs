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
        public Thuoc()
        {
            InitializeComponent();
            conn = functions.connect();
            functions.HienThiDG(dataGridView1,"select * from THUOC", conn);
        }

        private string id_Thuoc, tenthuoc, dvt, gia;

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "update THUOC set T_TEN=N'" + textBox2.Text + "', T_DVT=N'" + textBox3.Text + "',T_GIA='" + textBox4.Text + "'  where T_ID='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            functions.HienThiDG(dataGridView1, "select * from THUOC", conn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from THUOC where T_ID='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            functions.HienThiDG(dataGridView1, "select * from THUOC", conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            functions.ThemThuoc(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, conn);
            functions.HienThiDG(dataGridView1, "select * from THUOC", conn);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
