﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPKT
{
    public partial class statistical : Form
    {
        SqlConnection conn;
        Function functions = new Function();
        public statistical()
        {
            InitializeComponent();
            conn = functions.connect();
        }
        private string id, name, role;
        public statistical(string id, string name, string role)
        {
            InitializeComponent();
            conn = functions.connect();
            this.id = id;
            this.name = name;
            this.role = role;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SearchDoanhThu_Click(object sender, EventArgs e)
        {
            lb_tongHD.Text = "Tổng hóa đơn: ";
            lb_tongDT.Text = "Tổng doanh thu: ";

            string from = date_thongKeFrom.Value.ToString("MM/dd/yyyy");
            string to = date_thongKeTo.Value.ToString("MM/dd/yyyy");

            string queryThongKe = "SELECT HD_NGAYLAP 'Ngày',count(HD_ID) 'Số hóa đơn', Sum(convert(int,HD_TONGTIEN,0)) 'Doanh thu' FROM HOA_DON WHERE HD_NGAYLAP BETWEEN '" + from + "' AND '" + to + "' group by HD_NGAYLAP order by HD_NGAYLAP";
            functions.compileSql(queryThongKe, conn);
            functions.display(thkDataTable, queryThongKe, conn);
            int counthd = 0;
            int countdt = 0;
            int i = 0;
            while (thkDataTable.Rows[i].Cells["Ngày"].Value != null)
            {
                counthd += Int32.Parse(thkDataTable.Rows[i].Cells["Số hóa đơn"].Value.ToString());
                countdt += Int32.Parse(thkDataTable.Rows[i].Cells["Doanh thu"].Value.ToString());
                i++;
            }
            lb_tongHD.Text += counthd;
            lb_tongDT.Text += countdt.ToString("#,##0", new CultureInfo("vi-VN")) + " VNĐ";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admin_home adh = new admin_home(id, name, role);
            adh.Show();
            this.Hide();
        }
    }
}
