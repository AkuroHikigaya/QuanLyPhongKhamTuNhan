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
        public add_invoice(string idPhieuKham, DataGridView hdDataTable)
        {
            InitializeComponent();
            this.idPhieuKham = idPhieuKham;
            this.hdDataTable = hdDataTable;
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
            functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_TONGTIEN 'Tổng tiền' from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);

        }
    }
}
