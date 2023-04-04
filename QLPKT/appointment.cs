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

namespace QLPKT
{
    public partial class appointment : Form
    {

        Function functions = new Function();
        SqlConnection conn;
        public appointment()
        {
            InitializeComponent();
        }

        private string id, name, role;
        public appointment(string id, string name, string role)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.role = role;
        }

        private void appointment_Load(object sender, EventArgs e)
        {
            conn = functions.connect();
            functions.display(lhDataTable, "Select a.LH_ID 'Mã lịch hẹn', b.BN_ID 'Mã bệnh nhân', b.BN_Ten 'Tên bệnh nhân', a.LH_NGAYHEN 'Ngày hẹn', a.LH_GIOHEN 'Giờ hẹn', a.LH_TRANGTHAI 'Trạng thái' From LICH_HEN a, BENH_NHAN b Where a.BN_ID = b.BN_ID", conn);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin_home adm = new admin_home(id, name, role);
            adm.Show();
            this.Close();
        }

        private void btn_delHd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thao tác này sẽ xóa lịch hẹn của bệnh nhân\n Bạn vẫn muốn tiếp tục chứ ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                DataGridViewRow row = lhDataTable.SelectedRows[0];
                string idLH = row.Cells[0].Value.ToString();
                functions.compileSql("Delete LICH_HEN Where LH_ID = '" + idLH + "'", conn);
                MessageBox.Show("Đã xóa lịch hẹn");
                functions.display(lhDataTable, "Select a.LH_ID 'Mã lịch hẹn', b.BN_ID 'Mã bệnh nhân', b.BN_Ten 'Tên bệnh nhân', a.LH_NGAYHEN 'Ngày hẹn', a.LH_GIOHEN 'Giờ hẹn', a.LH_TRANGTHAI 'Trạng thái' From LICH_HEN a, BENH_NHAN b Where a.BN_ID = b.BN_ID", conn);
            }
        }

        private void btn_editLh_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = lhDataTable.SelectedRows[0];
            string idBN = row.Cells[1].Value.ToString();
            string nameBN = row.Cells[2].Value.ToString();
            edit_appointment ea = new edit_appointment(idBN, nameBN, lhDataTable);
            this.Opacity = 0.8;
            ea.ShowDialog();
            this.Opacity = 1;

        }
    }
}
