using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            conn = functions.connect();
        }

        private string id, name, role;
        public invoice(string id, string name, string role)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.role = role;
        }

        private void btn_editHd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = hdDataTable.SelectedRows[0];
            string idBN = row.Cells[2].Value.ToString();
            string idNV = row.Cells[4].Value.ToString();
            string ngaylap = row.Cells[7].Value.ToString();
            string tien = row.Cells[8].Value.ToString();
            edit_invoice invoice = new edit_invoice(hdDataTable,idBN, idNV, ngaylap, tien);
            invoice.Show();
        }

        private void btn_delHd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thao tác này sẽ xóa vĩnh viễn hóa đơn \n Bạn vẫn muốn tiếp tục chứ ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                DataGridViewRow row = hdDataTable.SelectedRows[0];
                string idHD = row.Cells[0].Value.ToString();
                functions.compileSql("Delete HOA_DON Where HD_ID = '"+ idHD + "'", conn);
                MessageBox.Show("Đã xóa hóa đơn");
                functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_NGAYLAP 'Ngày lập', a.HD_TONGTIEN 'Tổng tiền' from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
            }
        }

        private void btn_printHd_Click(object sender, EventArgs e)
        {
            pdfHoaDon.Document = pdfHoaDonDoc;
            pdfHoaDon.ShowDialog();
        }

        private void pdfHoaDonDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow row = hdDataTable.SelectedRows[0];
            string idHD = row.Cells[0].Value.ToString();
            string ten = "Name";
            string sdt = "SDT";

            var w = pdfHoaDonDoc.DefaultPageSettings.PaperSize.Width;
            Pen blackpen = new Pen(Color.Black,1);
            var y = 20;

            //Hàng 1
            e.Graphics.DrawString("PHÒNG KHÁM TAI ƯƠNG", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("ID HÓA ĐƠN: "+ idHD, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2 + 200, y));
            y += 25;
            //Hàng 2
            e.Graphics.DrawString("Khu 2, Đ. 3/2, P. Xuân Khánh, \nQ. Ninh Kiều, TP. CT", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, y));
            y += 50;
            //Gạch
            
            Point p1 = new Point(10, y);
            Point p2 = new Point(w-10, y);
            e.Graphics.DrawLine(blackpen, p1, p2);

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            conn = functions.connect();
            functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_NGAYLAP 'Ngày lập', a.HD_TONGTIEN 'Tổng tiền' from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin_home adh = new admin_home(id, name, role);
            adh.Show();
            this.Hide();
        }
    }
}
