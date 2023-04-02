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
    public partial class invoice : Form
    {
        SqlConnection conn;
        Function functions = new Function();
        public invoice()
        {
            InitializeComponent();
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_TONGTIEN 'Tổng tiền' from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
        }
    }
}
