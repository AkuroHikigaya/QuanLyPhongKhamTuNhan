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
    public partial class add_invoice : Form
    {
        private string idPhieuKham;
        private DataGridView hdDataTable;
        Function functions = new Function();
        SqlConnection conn;
        public add_invoice(string idPhieuKham)
        {
            InitializeComponent();
            this.idPhieuKham = idPhieuKham;
        }

        private void btn_huy_themhoadon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            conn = functions.connect();
            functions.addHoaDon(idPhieuKham, tb_nhapSotien.Text, date_ngaylaphoadon.Value.ToString("yyyy-MM-dd"), conn);
            this.Close();
            MessageBox.Show("Đã thêm hóa đơn");
        }
    }
}
