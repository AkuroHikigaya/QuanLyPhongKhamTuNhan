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
    public partial class edit_invoice : Form
    {
        SqlConnection conn;
        Function functions = new Function();
        DataGridView hdDataTable;
        public edit_invoice(DataGridView hdDataTable,string idBN, string idNV, string ngaylap, string tien)
        {
            InitializeComponent();
            lb_idBN.Text = idBN;
            lb_idNV.Text = idNV;
            date_HD.Text = ngaylap;
            money.Text = tien;
            this.hdDataTable = hdDataTable;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsuaHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = hdDataTable.SelectedRows[0];
            string idHD = row.Cells[0].Value.ToString();
            functions.compileSql("Update HOA_DON Set HD_NGAYLAP = '"+ date_HD.Value.ToString("yyyy-MM-dd") +"', HD_TONGTIEN = '"+ money.Text + "' Where HD_ID = '"+ idHD + "'", conn);
            MessageBox.Show("Sửa thành công");
            functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_NGAYLAP 'Ngày lập', a.HD_TONGTIEN 'Tổng tiền' from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
            this.Close();
        }

        private void edit_invoice_Load(object sender, EventArgs e)
        {
            conn = functions.connect();
        }
    }
}
