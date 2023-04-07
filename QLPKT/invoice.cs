using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_NGAYLAP 'Ngày lập', a.HD_TONGTIEN 'Tổng tiền', c.BN_NGAYSINH, c.BN_GIOITINH from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
                hdDataTable.Columns["BN_NGAYSINH"].Visible = false;
                hdDataTable.Columns["BN_GIOITINH"].Visible = false;
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
            DateTime ngaysinhBN = (DateTime)row.Cells["BN_NGAYSINH"].Value;
            string ngaysinhBNString = ngaysinhBN.ToString("dd-MM-yyyy");
            string gioitinh = row.Cells["BN_GIOITINH"].Value.ToString();
            string tiendieutri = row.Cells[8].Value.ToString();
            var w = pdfHoaDonDoc.DefaultPageSettings.PaperSize.Width;
            var h = pdfHoaDonDoc.DefaultPageSettings.PaperSize.Height;
            Pen blackpen = new Pen(Color.Black, 1);
            var y = 20;

            //Hàng 1
            e.Graphics.DrawString("PHÒNG KHÁM TỬ VONG", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("ID HÓA ĐƠN: " + idHD, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, y));
            y += 25;
            //Hàng 2
            e.Graphics.DrawString("Khu 2, Đ. 3/2, P. Xuân Khánh, \nQ. Ninh Kiều, TP. CT", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, y));
            y += 50;
            //Gạch

            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
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

            //Hàng 6
            e.Graphics.DrawString("Ngày sinh:   " + ngaysinhBNString, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Giới tính: " + gioitinh, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            y += 50;

            //Bảng thuốc
            string query = "select e.T_TEN 'Tên thuốc', e.T_DVT 'Đơn vị tính', d.T_SOLUONG 'Số lượng', e.T_GIA 'Giá tiền' from BENH_NHAN a, PHIEU_KHAM b, HOA_DON c, CHITIET_HD d, THUOC e Where a.BN_ID = b.BN_ID AND b.PK_ID = c.PK_ID AND c.HD_ID = d.HD_ID AND d.T_ID = e.T_ID AND a.BN_ID = '"+ maBenhNhan + "'";
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            font = new Font("Courier New", 11, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 1);
            int tableWidth = table.Columns.Count * 150+10;
            int tableHeight = table.Rows.Count * 20+10;
            e.Graphics.DrawRectangle(pen, new Rectangle(90, y, tableWidth, tableHeight + 20));
            y += 5;
            int x = 100;
            foreach (DataColumn column in table.Columns)
            {
                e.Graphics.DrawString(column.ColumnName, font, brush, new Point(x, y));
                x += 170;
            }
            x = 100;
            y += 20;
            foreach (DataRow r in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    e.Graphics.DrawString(r[column].ToString(), font, brush, new Point(x, y));
                    x += 170;
                }
                x = 100;
                y += 20;
            }
            y += 50;
            //Tổng tiền
            query = "select SUM(e.T_GIA*d.T_SOLUONG) 'TongTien' from BENH_NHAN a, PHIEU_KHAM b, HOA_DON c, CHITIET_HD d, THUOC e Where a.BN_ID = b.BN_ID AND b.PK_ID = c.PK_ID AND c.HD_ID = d.HD_ID AND d.T_ID = e.T_ID AND a.BN_ID = '" + maBenhNhan + "'";
            table = new DataTable();
            command = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            e.Graphics.DrawString("Tổng tiền thuốc: " + table.Rows[0]["TongTien"], new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            y += 40;
            e.Graphics.DrawString("Tiền điều trị:   " + tiendieutri, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            y += 30;
            p1 = new Point(w/2, y);
            p2 = new Point(w-100, y);
            e.Graphics.DrawLine(blackpen, p1, p2);
            y += 30;
            int sum = Int32.Parse(tiendieutri) + Int32.Parse(table.Rows[0]["TongTien"].ToString());
            e.Graphics.DrawString("Tổng cộng:       " + sum, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            y += 100 ;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackpen, p1, p2);
            y += 50;
            e.Graphics.DrawString("Bệnh nhân", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Bác sĩ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2+100, y));
            y += 30;
            e.Graphics.DrawString("(Ký, ghi rõ họ, tên)", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(80, y));
            e.Graphics.DrawString("(Ký, ghi rõ họ, tên)", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 80, y));
            e.Graphics.DrawString("<Phòng khám tử vong>", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2-100, h-50));

        }

        private void invoice_Load(object sender, EventArgs e)
        {
            conn = functions.connect();
            functions.display(hdDataTable, "Select a.HD_ID 'Mã hóa đơn',  b.PK_ID 'Mã phiếu khám', c.BN_ID 'Mã bệnh nhân', c.BN_TEN 'Tên bệnh nhân', f.NV_ID 'Mã nhân viên', f.NV_TEN 'Tên nhân viên', l.LK_TEN 'Tên Loại', a.HD_NGAYLAP 'Ngày lập', a.HD_TONGTIEN 'Tổng tiền', c.BN_NGAYSINH, c.BN_GIOITINH from HOA_DON a, PHIEU_KHAM b, BENH_NHAN c, NHAN_VIEN f, LOAI_KHAM l WHERE a.PK_ID = b.PK_ID AND b.BN_ID = c.BN_ID AND b.NV_ID = f.NV_ID AND b.LK_ID = l.LK_ID", conn);
            hdDataTable.Columns["BN_NGAYSINH"].Visible = false;
            hdDataTable.Columns["BN_GIOITINH"].Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin_home adh = new admin_home(id, name, role);
            adh.Show();
            this.Hide();
        }
    }
}
