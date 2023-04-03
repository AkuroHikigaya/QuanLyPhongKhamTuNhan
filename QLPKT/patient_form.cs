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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPKT
{
    public partial class patient_form : Form
    {
        Function functions = new Function();
        SqlConnection conn;
        public patient_form()
        {
            InitializeComponent();
        }

        private string id, name, role;
        public patient_form(string id, string name, string role)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.role = role;
        }

        private void patient_form_Load(object sender, EventArgs e)
        {
            tb_nvId.Text = id;
            conn = functions.connect();
            functions.display(bnDataTable, "Select a.BN_ID 'Mã bệnh nhân', a.BN_Ten 'Tên bệnh nhân', a.BN_NgaySinh 'Ngày sinh', a.BN_SDT 'Số điện thoại', a.BN_GioiTinh 'Giới tính', a.BN_DiaChi 'Địa chỉ', b.PK_TRIEUCHUNG 'Triệu chứng', b.PK_ID  From BENH_NHAN a, PHIEU_KHAM b Where a.BN_ID = b.BN_ID", conn);
            bnDataTable.Columns["PK_ID"].Visible = false;
            functions.getDataComboBox(cb_lkId, "Select distinct * from LOAI_KHAM", "LK_ID", "LK_Ten", conn);
        }

        private void bnDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            functions.upData(tb_bnId, tb_bnTen, date_bnNgaysinh, tb_bnDiachi, tb_bnSdt, tb_bnCccd, tb_bnBHYT, tb_bnGiamho, male, female, tb_pkTrieuchung, cb_lkId, dt_pkNgaylap, tb_nvId, bnDataTable, e, conn);
        }

        //Thêm Bệnh Nhân
        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            if(tb_bnId.Text != "" && tb_bnTen.Text != "" && tb_bnCccd.Text != "")
            {
                String BN_ID = tb_bnId.Text;
                String BN_Ten = tb_bnTen.Text;
                String BN_BHYT = tb_bnBHYT.Text;
                String GiamHo = tb_bnGiamho.Text;
                String CanCuoc = tb_bnCccd.Text;
                String Sdt = tb_bnSdt.Text;
                String NgaySinh = date_bnNgaysinh.Value.ToString("yyyy-MM-dd");
                String DiaChi = tb_bnDiachi.Text;
                String NV_ID = tb_nvId.Text;
                String LK_ID = cb_lkId.SelectedValue.ToString();
                String NgayLap = dt_pkNgaylap.Value.ToString("yyyy-MM-dd");
                String TrieuChung = tb_pkTrieuchung.Text;
                String query_ThemBenhNhan;
                int rowCount;
                int have_nv;

                SqlCommand checkNV = new SqlCommand("SELECT COUNT(*) FROM NHAN_VIEN WHERE NV_ID = @value", conn);
                checkNV.Parameters.AddWithValue("@value", NV_ID);

                have_nv = (int)checkNV.ExecuteScalar();
                if (have_nv > 0) 
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM BENH_NHAN WHERE BN_ID = @value", conn);
                    sqlCommand.Parameters.AddWithValue("@value", BN_ID);

                    rowCount = (int)sqlCommand.ExecuteScalar();

                    if (rowCount > 0)
                    {
                        DialogResult result = MessageBox.Show("Bệnh nhân đã có trong danh sách\n Bạn có muốn tiếp tục không ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            functions.addPhieuKham(BN_ID, NV_ID, LK_ID, NgayLap, TrieuChung, conn);
                            functions.display(bnDataTable, "Select a.BN_ID 'Mã bệnh nhân', a.BN_Ten 'Tên bệnh nhân', a.BN_NgaySinh 'Ngày sinh', a.BN_SDT 'Số điện thoại', a.BN_GioiTinh 'Giới tính', a.BN_DiaChi 'Địa chỉ', b.PK_TRIEUCHUNG 'Triệu chứng', b.PK_ID  From BENH_NHAN a, PHIEU_KHAM b Where a.BN_ID = b.BN_ID", conn);

                        }
                    }
                    else
                    {
                        if (male.Checked)
                        {
                            query_ThemBenhNhan = "Insert into BENH_NHAN values('" + BN_ID + "', N'" + BN_Ten + "', '" + BN_BHYT + "', N'" + GiamHo + "', '" + CanCuoc + "', '" + NgaySinh + "', '" + Sdt + "', 'Nam', N'" + DiaChi + "')";
                        }
                        else
                        {
                            query_ThemBenhNhan = "Insert into BENH_NHAN values('" + BN_ID + "', N'" + BN_Ten + "', '" + BN_BHYT + "', N'" + GiamHo + "', '" + CanCuoc + "', '" + NgaySinh + "', '" + Sdt + "', N'Nữ', N'" + DiaChi + "')";
                        }
                        functions.compileSql(query_ThemBenhNhan, conn);
                        functions.addPhieuKham(BN_ID, NV_ID, LK_ID, NgayLap, TrieuChung, conn);
                        MessageBox.Show("Đã thêm bệnh nhân");
                        functions.display(bnDataTable, "Select a.BN_ID 'Mã bệnh nhân', a.BN_Ten 'Tên bệnh nhân', a.BN_NgaySinh 'Ngày sinh', a.BN_SDT 'Số điện thoại', a.BN_GioiTinh 'Giới tính', a.BN_DiaChi 'Địa chỉ', b.PK_TRIEUCHUNG 'Triệu chứng', b.PK_ID  From BENH_NHAN a, PHIEU_KHAM b Where a.BN_ID = b.BN_ID", conn);

                    }
                }
                else
                {
                    MessageBox.Show("Thông tin nhân viên không chính xác !");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            }
        }

        //Xóa bệnh nhân

        private void btnXoaBenhNhan_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM PHIEU_KHAM WHERE BN_ID = @value", conn);
            sqlCommand.Parameters.AddWithValue("@value", tb_bnId.Text);

            int rowCount = (int)sqlCommand.ExecuteScalar();

            if (rowCount > 1)
            {
                DataGridViewRow row = bnDataTable.SelectedRows[0];
                string idPhieuKham = row.Cells["PK_ID"].Value.ToString();
                functions.compileSql("Delete PHIEU_KHAM where PK_ID = '" + idPhieuKham + "'", conn);
                MessageBox.Show("Đã xóa thành công");
            }
            else
            {
                DialogResult result = MessageBox.Show("Thao tác này sẽ xóa bệnh nhân và tất cả thông tin liên quan\n Bạn vẫn muốn tiếp tục chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    functions.compileSql("Delete BENH_NHAN where BN_ID = '" + tb_bnId.Text + "'", conn);
                    functions.compileSql("Delete PHIEU_KHAM where BN_ID = '" + tb_bnId.Text + "'", conn);
                    MessageBox.Show("Đã xóa thành công");
                }
            }

            functions.display(bnDataTable, "Select a.BN_ID 'Mã bệnh nhân', a.BN_Ten 'Tên bệnh nhân', a.BN_NgaySinh 'Ngày sinh', a.BN_SDT 'Số điện thoại', a.BN_GioiTinh 'Giới tính', a.BN_DiaChi 'Địa chỉ', b.PK_TRIEUCHUNG 'Triệu chứng', b.PK_ID  From BENH_NHAN a, PHIEU_KHAM b Where a.BN_ID = b.BN_ID", conn);
        }

        //Sửa bệnh nhân
        private void btnSuaBenhNhan_Click(object sender, EventArgs e)
        {
            String query_SuaBenhNhan;
            DialogResult result = MessageBox.Show("Thao tác này sẽ thay đổi giá trị của bệnh nhân\n Bạn vẫn muốn tiếp tục chứ ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = bnDataTable.SelectedRows[0];
                string idPhieuKham = row.Cells["PK_ID"].Value.ToString();
                functions.compileSql("UPDATE PHIEU_KHAM SET NV_ID = '" + tb_nvId.Text + "', LK_ID = '" + cb_lkId.SelectedValue.ToString() + "', PK_NGAYLAP ='" + dt_pkNgaylap.Value.ToString("yyyy-MM-dd") + "', PK_TRIEUCHUNG = N'" + tb_pkTrieuchung.Text + "' WHERE PK_ID = '" + idPhieuKham + "'", conn);

                if (male.Checked)
                {
                    query_SuaBenhNhan = "UPDATE BENH_NHAN SET BN_ID = '" + tb_bnId.Text + "', BN_TEN = N'" + tb_bnTen.Text + "', BN_BHYT = '" + tb_bnBHYT.Text + "', BN_TENGIAMHO = N'" + tb_bnGiamho.Text + "', BN_CCCD = '" + tb_bnCccd.Text + "', BN_NGAYSINH = '" + date_bnNgaysinh.Value.ToString("yyyy-MM-dd") + "', BN_SDT = '" + tb_bnSdt.Text + "', BN_GIOITINH = 'Nam', BN_DIACHI = N'" + tb_bnDiachi.Text + "' WHERE BN_ID = '" + tb_bnId.Text + "'";
                }
                else
                {
                    query_SuaBenhNhan = "UPDATE BENH_NHAN SET BN_ID = '" + tb_bnId.Text + "', BN_TEN = N'" + tb_bnTen.Text + "', BN_BHYT = '" + tb_bnBHYT.Text + "', BN_TENGIAMHO = N'" + tb_bnGiamho.Text + "', BN_CCCD = '" + tb_bnCccd.Text + "', BN_NGAYSINH = '" + date_bnNgaysinh.Value.ToString("yyyy-MM-dd") + "', BN_SDT = '" + tb_bnSdt.Text + "', BN_GIOITINH = N'Nữ', BN_DIACHI = N'" + tb_bnDiachi.Text + "' WHERE BN_ID = '" + tb_bnId.Text + "'";
                }
                functions.compileSql(query_SuaBenhNhan, conn);
                MessageBox.Show("Chỉnh sửa thành công");
                functions.display(bnDataTable, "Select a.BN_ID 'Mã bệnh nhân', a.BN_Ten 'Tên bệnh nhân', a.BN_NgaySinh 'Ngày sinh', a.BN_SDT 'Số điện thoại', a.BN_GioiTinh 'Giới tính', a.BN_DiaChi 'Địa chỉ', b.PK_TRIEUCHUNG 'Triệu chứng', b.PK_ID  From BENH_NHAN a, PHIEU_KHAM b Where a.BN_ID = b.BN_ID", conn);

            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = bnDataTable.SelectedRows[0];
            string idPhieuKham = row.Cells["PK_ID"].Value.ToString();
            add_invoice hd = new add_invoice(idPhieuKham);
            hd.Show();
        }

        private void bnDataTable_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = bnDataTable.SelectedRows[0];
            string idPhieuKham = row.Cells["PK_ID"].Value.ToString();
            phieu_kham pk = new phieu_kham(idPhieuKham);
            pk.Show();
        }

        private void BN_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    functions.display(bnDataTable, "SELECT a.BN_ID 'Mã bệnh nhân', a.BN_Ten 'Tên bệnh nhân', a.BN_NgaySinh 'Ngày sinh', a.BN_SDT 'Số điện thoại', a.BN_GioiTinh 'Giới tính', a.BN_DiaChi 'Địa chỉ', b.PK_TRIEUCHUNG 'Triệu chứng', b.PK_ID FROM BENH_NHAN a, PHIEU_KHAM b WHERE a.BN_ID = b.BN_ID AND (a.BN_ID LIKE '%" + tb_search.Text + "%' OR a.BN_Ten LIKE N'%" + tb_search.Text + "%' OR a.BN_NgaySinh LIKE '%" + tb_search.Text + "%' OR a.BN_SDT LIKE '%" + tb_search.Text + "%' OR a.BN_GioiTinh LIKE N'%"+ tb_search.Text + "%' OR a.BN_DiaChi LIKE N'%" + tb_search.Text + "%' OR b.PK_TRIEUCHUNG LIKE N'%" + tb_search.Text + "%')", conn);
            }
        }
        private void addLichHen_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = bnDataTable.SelectedRows[0];
            string id_BN = row.Cells[0].Value.ToString();
            string name_BN = row.Cells[1].Value.ToString();
            lich_hen lh = new lich_hen(id_BN, name_BN);
            lh.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin_home adm = new admin_home(id, name, role);
            adm.Show();
            this.Hide();
        }
    }

}
