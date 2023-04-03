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
    public partial class phieu_kham : Form
    {
        SqlConnection conn;
        Function functions = new Function();
        String idPK;
        public phieu_kham(String idPK)
        {
            InitializeComponent();
            chitietPK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            chitietPK.ScrollBars = ScrollBars.None;
            chitietPK.RowCount = 1;
            conn = functions.connect();
            this.idPK = idPK;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phieu_kham_Load(object sender, EventArgs e)
        {
            functions.display(chitietPK, "Select a.BN_Ten 'Tên bệnh nhân', a.BN_BHYT 'Bảo hiểm y tế', a.BN_TenGiamHo 'Tên giám hộ', a.BN_CCCD 'Căn cước công dân', a.BN_NgaySinh 'Ngày sinh', a.BN_SDT 'Số điện thoại', b.PK_NGAYLAP 'Ngày lập' , a.BN_GIOITINH 'Giới tính', a.BN_DiaChi 'Địa chỉ' From BENH_NHAN a, PHIEU_KHAM b Where a.BN_ID = b.BN_ID AND b.PK_ID = '" + idPK + "'", conn);

        }
    }
}
