using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace QLPKT
{
    public partial class admin_home : Form
    {
        private string id, name, role;
        private object[] tagValue;
        
        public admin_home(string nv_id, string nv_name, string role)
        {
            InitializeComponent();
            Function f = new Function();
            this.id = nv_id;
            this.name = nv_name;
            this.role = role;
            lb_ten.Text = this.name;
            lb_role.Text = this.role;
            this.tagValue = new object[] { id, name, role };
            checkRole();
        }

        public void checkRole() {
            if (role == "Bác sĩ") {
                btn_toQLNV.Enabled = false;
                btn_toTK.Enabled = false;
                Function f = new Function();
                pictureBox1.BackgroundImage = f.makeGreyImage(pictureBox1);
                pictureBox4.BackgroundImage = f.makeGreyImage(pictureBox4);
            }
        }

       

        private void panel2_Click(object sender, EventArgs e)
        {
            invoice hd = new invoice(id, name, role);
            hd.Show();
            this.Hide();
        }

        private void label99_Click(object sender, EventArgs e)
        {
            invoice hd = new invoice(id, name, role);
            hd.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            patient_form bn = new patient_form(id, name, role);
            bn.Show();
            this.Hide();

        }

        private void btn_toApp_Click(object sender, EventArgs e)
        {
            patient_form bn = new patient_form(id, name, role);
            bn.Show();
            this.Hide();

        }
        private void btn_toTK_Click(object sender, EventArgs e)
        {
            statistical st = new statistical(id, name, role);
            st.Show();
            this.Hide();

        }


        private void btn_toQLNV_Click_1(object sender, EventArgs e)
        {
            thongtin_nv ttnv = new thongtin_nv(id, name, role);
            ttnv.Tag = tagValue;
            ttnv.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            thongtin_nv ttnv = new thongtin_nv(id, name, role);
            ttnv.Tag = tagValue;
            ttnv.Show();
            this.Hide();
        }
        

        private void btn_toQLNV_Click(object sender, EventArgs e)
        {
            thongtin_nv ttnv = new thongtin_nv(id, name, role);
            ttnv.Tag = tagValue;
            ttnv.Show();
            this.Hide();
        }

        private void lichhen_Click(object sender, EventArgs e)
        {
            appointment ap = new appointment(id, name, role);
            ap.Show();
            this.Close();
        }

        private void panelLichHen_click(object sender, EventArgs e)
        {
            appointment ap = new appointment(id, name, role);
            ap.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Thuoc f1 = new Thuoc(id, name, role);
            f1.Show();
            this.Close();
        }

        private void bttn_toQLT_Click(object sender, EventArgs e)
        {
            Thuoc f1 = new Thuoc(id, name, role);
            f1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void lb_logout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
