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
    public partial class lich_hen : Form
    {
        String ID_BN;
        String Name_BN;
        SqlConnection conn;
        Function functions = new Function();
        public lich_hen(String ID_BN, String Name_BN)
        {
            InitializeComponent();
            conn = functions.connect();
            this.ID_BN = ID_BN;
            this.Name_BN = Name_BN;
        }

        private void lich_hen_Load(object sender, EventArgs e)
        {
            lb_textIdBN.Text = ID_BN;
            lbNameBN.Text = Name_BN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addLichHen_Click(object sender, EventArgs e)
        {
            string LH_ID = "LH_" + new Random().Next(9999).ToString();
            SqlCommand lichhen = new SqlCommand("SELECT COUNT(*) FROM LICH_HEN WHERE LH_ID = @value", conn);
            lichhen.Parameters.AddWithValue("@value", LH_ID);
            int phieuKham = (int)lichhen.ExecuteScalar();
            while (phieuKham > 0)
            {
                LH_ID = "LH_" + new Random().Next(9999).ToString(); ;
                lichhen.Parameters.AddWithValue("@value", LH_ID);
                phieuKham = (int)lichhen.ExecuteScalar();
            }
            String query_ThemLichHen = "Insert into LICH_HEN values('" + LH_ID + "', '" + ID_BN + "', '" + date_H.Value.ToString("yyyy-MM-dd") + "', '" + time_H.Value + "', N'Chưa khám')";
            functions.compileSql(query_ThemLichHen, conn);
            MessageBox.Show("Đã thêm lịch hẹn !");
            this.Close();
        }
    }
}
