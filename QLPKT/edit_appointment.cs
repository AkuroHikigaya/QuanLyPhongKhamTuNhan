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
    public partial class edit_appointment : Form
    {
        private string idBN;
        private string nameBN;
        private DataGridView lhDataTable;
        Function functions = new Function();
        SqlConnection conn;
        public edit_appointment(string idBN, string nameBN, DataGridView lhDataTable)
        {
            InitializeComponent();
            conn = functions.connect();
            this.idBN = idBN;
            this.nameBN = nameBN;
            this.lhDataTable = lhDataTable;
        }


        private void edit_appointment_Load(object sender, EventArgs e)
        {
            lb_textIdBN.Text = idBN;
            lbNameBN.Text = nameBN;
        }

        private void editLichHen_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = lhDataTable.SelectedRows[0];
            string idLH = row.Cells[0].Value.ToString();
            String query_editLH = "Update LICH_HEN Set LH_NGAYHEN = '"+ date_H.Value.ToString("yyyy-MM-dd") + "', LH_GIOHEN = '"+time_H.Value+"', LH_TRANGTHAI = '"+status.Text+"' Where LH_ID = '"+ idLH + "'";
            functions.compileSql(query_editLH, conn);
            MessageBox.Show("Đã sửa thành công !");
            functions.display(lhDataTable, "Select a.LH_ID 'Mã lịch hẹn', b.BN_ID 'Mã bệnh nhân', b.BN_Ten 'Tên bệnh nhân', a.LH_NGAYHEN 'Ngày hẹn', a.LH_GIOHEN 'Giờ hẹn', a.LH_TRANGTHAI 'Trạng thái' From LICH_HEN a, BENH_NHAN b Where a.BN_ID = b.BN_ID", conn);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
