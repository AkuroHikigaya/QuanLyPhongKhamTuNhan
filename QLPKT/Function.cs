using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;


namespace QLPKT
{
    class Function
    {
        SqlConnection conn = new SqlConnection();
        public SqlConnection connect()
        {
            SqlConnection conn;
            conn = new SqlConnection("server = DESKTOP-33H3AUS; database = QLPK; Integrated Security = True");
            conn.Open();
            return conn;
        }

        public bool checkSql(string sql) {
            SqlCommand cmd = new SqlCommand(sql,conn);
            int x = (int)cmd.ExecuteScalar();
            if (x > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
        
        public SqlDataReader getData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void HienThiDG(DataGridView dg, string cautruyvan, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cautruyvan, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "nv");
            dg.DataSource = dataSet;
            dg.DataMember = "nv";
        }

        public void LoadDLCB(String cautruyvan, ComboBox cb, string hienthi, string giatri, SqlConnection conn)
        {
            SqlCommand comd = new SqlCommand(cautruyvan, conn);
            SqlDataReader read = comd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource = table;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
        }

        public void Them(string NV_ID, string CV_ID, string NV_TEN, string NV_NGAYSINH, string NV_EMAIL, string NV_GIOITINH, string NV_SDT, string NV_ANH, string NV_TAIKHOAN, string NV_MATKHAU, string BS_BANGCAP, string BS_CHUYENMON, string ROLE, SqlConnection conn)
        {
            string query = "insert into NHAN_VIEN values('" + NV_ID + "','" + CV_ID + "',N'" + NV_TEN + "','" + NV_NGAYSINH + "','" + NV_EMAIL + "',N'" + NV_GIOITINH + "','" + NV_SDT + "','" + NV_ANH + "','" + NV_TAIKHOAN + "','" + NV_MATKHAU + "',N'" + BS_BANGCAP + "',N'" + BS_CHUYENMON + "',N'" + ROLE + "')";
            MessageBox.Show(query);
            
                SqlCommand comd = new SqlCommand(query, conn);
                comd.ExecuteNonQuery();
        }

        public Image makeGreyImage(PictureBox pb)
        {
            // Đọc hình ảnh từ PictureBox
            Bitmap originalImage = new Bitmap(pb.BackgroundImage);

            // Tạo một đối tượng ImageAttributes
            ImageAttributes grayAttributes = new ImageAttributes();

            // Thiết lập ma trận màu xám
            ColorMatrix grayMatrix = new ColorMatrix(
                new float[][]
                {
            new float[] {0.299f, 0.299f, 0.299f, 0, 0},
            new float[] {0.587f, 0.587f, 0.587f, 0, 0},
            new float[] {0.114f, 0.114f, 0.114f, 0, 0},
            new float[] {0,      0,      0,      1, 0},
            new float[] {0,      0,      0,      0, 1}
                });

            // Thiết lập thuộc tính ColorMatrix cho đối tượng ImageAttributes
            grayAttributes.SetColorMatrix(grayMatrix);

            // Vẽ lại hình ảnh với đối tượng ImageAttributes đã thiết lập
            Graphics g = Graphics.FromImage(originalImage);
            g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, grayAttributes);
            g.Dispose();

            // Gán hình ảnh đã chuyển đổi vào PictureBox
            return originalImage;
        }

        //Lấy dữ liệu đưa lên combobox
        public void getDataComboBox(ComboBox combobox, String query, String value, String name, SqlConnection conn)
        {
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            combobox.DataSource = dataTable;
            combobox.DisplayMember = name;
            combobox.ValueMember = value;
        }

        //Lấy dữ liệu từ bảng đưa lên form
        public void upData(TextBox BN_ID, TextBox BN_Ten, DateTimePicker BN_NgaySinh, TextBox BN_DiaChi, TextBox BN_SDT, TextBox BN_CCCD, TextBox BN_BHYT, TextBox BN_GiamHo, RadioButton male, RadioButton female, TextBox PK_TrieuChung, ComboBox PK_LoaiKham, DateTimePicker PK_NgayLap, TextBox NV_Id, DataGridView table, DataGridViewCellEventArgs dataGrid, SqlConnection conn)
        {
            BN_ID.Text = table.Rows[dataGrid.RowIndex].Cells[0].Value.ToString();
            BN_Ten.Text = table.Rows[dataGrid.RowIndex].Cells[1].Value.ToString();
            BN_NgaySinh.Text = table.Rows[dataGrid.RowIndex].Cells[2].Value.ToString();
            BN_SDT.Text = table.Rows[dataGrid.RowIndex].Cells[3].Value.ToString();
            if (table.Rows[dataGrid.RowIndex].Cells[4].Value.ToString() == "Nam")
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }
            BN_DiaChi.Text = table.Rows[dataGrid.RowIndex].Cells[5].Value.ToString();
            PK_TrieuChung.Text = table.Rows[dataGrid.RowIndex].Cells[6].Value.ToString();

            SqlCommand command = new SqlCommand("Select * From BENH_NHAN a, PHIEU_KHAM b Where a.BN_ID = b.BN_ID AND a.BN_ID='" + BN_ID.Text + "'", conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                BN_CCCD.Text = reader.GetValue(4).ToString();
                BN_BHYT.Text = reader.GetValue(2).ToString();
                BN_GiamHo.Text = reader.GetValue(3).ToString();
                PK_NgayLap.Text = reader.GetValue(13).ToString();
                NV_Id.Text = reader.GetValue(11).ToString();
                SqlCommand command2 = new SqlCommand("Select * From LOAI_KHAM Where LK_ID = '" + reader.GetValue(12).ToString() + "'", conn);
                reader.Close();
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read())
                {
                    PK_LoaiKham.Text = reader2.GetValue(1).ToString();
                }
                reader2.Close();
            }
            reader.Close();

        }

        public void display(DataGridView dataGrid, string query, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "temp");
            dataGrid.DataSource = dataSet;
            dataGrid.DataMember = "temp";
        }

        public void displayToMessageBox(string query, SqlConnection conn)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, conn));
            adapter.Fill(dataTable);
            string value = dataTable.Rows[0].Field<string>(0);
            MessageBox.Show(dataTable.Rows[0].Table + "");
        }

        public void compileSql(string query, SqlConnection conn)
        {
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
        }

        public void addPhieuKham(String BN_ID, String NV_ID, String LK_ID, String NgayLap, String TrieuChung, SqlConnection conn)
        {
            //Khởi tạo phiếu khám
            string PK_ID = "PK_" + new Random().Next(9999).ToString();
            SqlCommand phieukham = new SqlCommand("SELECT COUNT(*) FROM PHIEU_KHAM WHERE PK_ID = @value", conn);
            phieukham.Parameters.AddWithValue("@value", PK_ID);
            int phieuKham = (int)phieukham.ExecuteScalar();
            while (phieuKham > 0)
            {
                PK_ID = "PK_" + new Random().Next(9999).ToString(); ;
                phieukham.Parameters.AddWithValue("@value", PK_ID);
                phieuKham = (int)phieukham.ExecuteScalar();
            }
            String query_ThemPhieuKham = "Insert into PHIEU_KHAM values('" + PK_ID + "', '" + BN_ID + "', '" + NV_ID + "', '" + LK_ID + "', '" + NgayLap + "', N'" + TrieuChung + "')";
            compileSql(query_ThemPhieuKham, conn);

        }

        public void addHoaDon(String PK_ID, String HD_TongTien, String HD_NgayLap, SqlConnection conn)
        {
            //Khởi tạo phiếu khám
            string HD_ID = "HD_" + new Random().Next(9999).ToString();
            SqlCommand hoadon = new SqlCommand("SELECT COUNT(*) FROM HOA_DON WHERE HD_ID = @value", conn);
            hoadon.Parameters.AddWithValue("@value", HD_ID);
            int count = (int)hoadon.ExecuteScalar();
            while (count > 0)
            {
                HD_ID = "HD_" + new Random().Next(9999).ToString();
                hoadon.Parameters.AddWithValue("@value", HD_ID);
                count = (int)hoadon.ExecuteScalar();
            }
            String query_ThemHoaDon = "Insert into HOA_DON values('" + HD_ID + "', '" + PK_ID + "', '" + HD_TongTien + "', '" + HD_NgayLap + "')";
            compileSql(query_ThemHoaDon, conn);
        }
    }
}
