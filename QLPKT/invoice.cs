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
using static System.Net.Mime.MediaTypeNames;

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
            this.Opacity = 0.7;
            invoice.ShowDialog();
            this.Opacity = 1;
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
                functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_NGAYLAP 'Ngày lập', a.HD_TONGTIEN 'Tổng tiền', c.BN_NGAYSINH from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
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
            string tenBenhNhan = row.Cells[3].Value.ToString();
            string maBenhNhan = row.Cells[2].Value.ToString();
            //string ngaysinhBN = row.Cells["BN_NGAYSINH"].Value.ToString();
            DateTime ngaysinhBN = (DateTime)row.Cells["BN_NGAYSINH"].Value;
            string ngaysinhBNString = ngaysinhBN.ToString("dd-MM-yyyy");


            var w = pdfHoaDonDoc.DefaultPageSettings.PaperSize.Width;
            Pen blackpen = new Pen(Color.Black,1);
            var y = 20;

            //Hàng 1
            e.Graphics.DrawString("PHÒNG KHÁM TỬ VONG", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
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
            y += 50;

            //Hàng 4
            string text = "HÓA ĐƠN THU PHÍ";
            Font font = new Font("Courier New", 18, FontStyle.Bold);
            SizeF textSize = e.Graphics.MeasureString(text, font);
            e.Graphics.DrawString(text, new Font("Courier New", 20, FontStyle.Bold), Brushes.Black, (w - textSize.Width) / 2, y);
            y += 50;


            //Hàng 5
            e.Graphics.DrawString("Họ và tên:   " + tenBenhNhan, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Mã bệnh nhân:   " + maBenhNhan, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            y += 50;

            e.Graphics.DrawString("Ngày sinh:   " + ngaysinhBNString, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Giới tính: ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            y += 50;
            
            
            
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            conn = functions.connect();
            functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_NGAYLAP 'Ngày lập', a.HD_TONGTIEN 'Tổng tiền', c.BN_NGAYSINH from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
            hdDataTable.Columns["BN_NGAYSINH"].Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin_home adh = new admin_home(id, name, role);
            adh.Show();
            this.Hide();
        }
    }
}
