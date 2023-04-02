namespace QLPKT
{
    partial class add_invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.date_ngaylaphoadon = new System.Windows.Forms.DateTimePicker();
            this.nhapngay = new System.Windows.Forms.Label();
            this.nhapsotien = new System.Windows.Forms.Label();
            this.btn_themhoadon = new System.Windows.Forms.Button();
            this.btn_huy_themhoadon = new System.Windows.Forms.Button();
            this.tb_nhapSotien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // date_ngaylaphoadon
            // 
            this.date_ngaylaphoadon.Location = new System.Drawing.Point(213, 108);
            this.date_ngaylaphoadon.Margin = new System.Windows.Forms.Padding(2);
            this.date_ngaylaphoadon.Name = "date_ngaylaphoadon";
            this.date_ngaylaphoadon.Size = new System.Drawing.Size(151, 20);
            this.date_ngaylaphoadon.TabIndex = 12;
            // 
            // nhapngay
            // 
            this.nhapngay.AutoSize = true;
            this.nhapngay.Location = new System.Drawing.Point(101, 113);
            this.nhapngay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nhapngay.Name = "nhapngay";
            this.nhapngay.Size = new System.Drawing.Size(62, 13);
            this.nhapngay.TabIndex = 11;
            this.nhapngay.Text = "Nhập ngày:";
            // 
            // nhapsotien
            // 
            this.nhapsotien.AutoSize = true;
            this.nhapsotien.Location = new System.Drawing.Point(101, 67);
            this.nhapsotien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nhapsotien.Name = "nhapsotien";
            this.nhapsotien.Size = new System.Drawing.Size(70, 13);
            this.nhapsotien.TabIndex = 10;
            this.nhapsotien.Text = "Nhập số tiền:";
            // 
            // btn_themhoadon
            // 
            this.btn_themhoadon.Location = new System.Drawing.Point(255, 164);
            this.btn_themhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themhoadon.Name = "btn_themhoadon";
            this.btn_themhoadon.Size = new System.Drawing.Size(87, 19);
            this.btn_themhoadon.TabIndex = 9;
            this.btn_themhoadon.Text = "Thêm hóa đơn";
            this.btn_themhoadon.UseVisualStyleBackColor = true;
            this.btn_themhoadon.Click += new System.EventHandler(this.btn_themhoadon_Click);
            // 
            // btn_huy_themhoadon
            // 
            this.btn_huy_themhoadon.Location = new System.Drawing.Point(120, 164);
            this.btn_huy_themhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy_themhoadon.Name = "btn_huy_themhoadon";
            this.btn_huy_themhoadon.Size = new System.Drawing.Size(87, 19);
            this.btn_huy_themhoadon.TabIndex = 8;
            this.btn_huy_themhoadon.Text = "Hủy bỏ";
            this.btn_huy_themhoadon.UseVisualStyleBackColor = true;
            this.btn_huy_themhoadon.Click += new System.EventHandler(this.btn_huy_themhoadon_Click);
            // 
            // tb_nhapSotien
            // 
            this.tb_nhapSotien.Location = new System.Drawing.Point(213, 65);
            this.tb_nhapSotien.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nhapSotien.Name = "tb_nhapSotien";
            this.tb_nhapSotien.Size = new System.Drawing.Size(151, 20);
            this.tb_nhapSotien.TabIndex = 7;
            // 
            // add_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 203);
            this.Controls.Add(this.date_ngaylaphoadon);
            this.Controls.Add(this.nhapngay);
            this.Controls.Add(this.nhapsotien);
            this.Controls.Add(this.btn_themhoadon);
            this.Controls.Add(this.btn_huy_themhoadon);
            this.Controls.Add(this.tb_nhapSotien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_invoice";
            this.Text = "ThemHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_ngaylaphoadon;
        private System.Windows.Forms.Label nhapngay;
        private System.Windows.Forms.Label nhapsotien;
        private System.Windows.Forms.Button btn_themhoadon;
        private System.Windows.Forms.Button btn_huy_themhoadon;
        private System.Windows.Forms.TextBox tb_nhapSotien;
    }
}