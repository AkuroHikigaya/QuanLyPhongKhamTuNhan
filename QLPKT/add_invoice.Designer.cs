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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_invoice));
            this.tb_nhapSotien = new System.Windows.Forms.TextBox();
            this.btn_huy_themhoadon = new System.Windows.Forms.Button();
            this.btn_themhoadon = new System.Windows.Forms.Button();
            this.nhapsotien = new System.Windows.Forms.Label();
            this.nhapngay = new System.Windows.Forms.Label();
            this.date_ngaylaphoadon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nhapSotien
            // 
            this.tb_nhapSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nhapSotien.Location = new System.Drawing.Point(181, 62);
            this.tb_nhapSotien.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nhapSotien.Name = "tb_nhapSotien";
            this.tb_nhapSotien.Size = new System.Drawing.Size(205, 26);
            this.tb_nhapSotien.TabIndex = 7;
            // 
            // btn_huy_themhoadon
            // 
            this.btn_huy_themhoadon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_huy_themhoadon.BackgroundImage")));
            this.btn_huy_themhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_huy_themhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huy_themhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huy_themhoadon.Font = new System.Drawing.Font("UTM BryantLG", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy_themhoadon.ForeColor = System.Drawing.Color.White;
            this.btn_huy_themhoadon.Location = new System.Drawing.Point(266, 165);
            this.btn_huy_themhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy_themhoadon.Name = "btn_huy_themhoadon";
            this.btn_huy_themhoadon.Size = new System.Drawing.Size(120, 40);
            this.btn_huy_themhoadon.TabIndex = 8;
            this.btn_huy_themhoadon.Text = "Hủy bỏ";
            this.btn_huy_themhoadon.UseVisualStyleBackColor = true;
            this.btn_huy_themhoadon.Click += new System.EventHandler(this.btn_huy_themhoadon_Click);
            // 
            // btn_themhoadon
            // 
            this.btn_themhoadon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_themhoadon.BackgroundImage")));
            this.btn_themhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_themhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themhoadon.Font = new System.Drawing.Font("UTM BryantLG", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themhoadon.ForeColor = System.Drawing.Color.White;
            this.btn_themhoadon.Location = new System.Drawing.Point(77, 165);
            this.btn_themhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themhoadon.Name = "btn_themhoadon";
            this.btn_themhoadon.Size = new System.Drawing.Size(120, 40);
            this.btn_themhoadon.TabIndex = 9;
            this.btn_themhoadon.Text = "Thêm hóa đơn";
            this.btn_themhoadon.UseVisualStyleBackColor = true;
            this.btn_themhoadon.Click += new System.EventHandler(this.btn_themhoadon_Click);
            // 
            // nhapsotien
            // 
            this.nhapsotien.AutoSize = true;
            this.nhapsotien.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapsotien.Location = new System.Drawing.Point(73, 69);
            this.nhapsotien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nhapsotien.Name = "nhapsotien";
            this.nhapsotien.Size = new System.Drawing.Size(104, 19);
            this.nhapsotien.TabIndex = 10;
            this.nhapsotien.Text = "Nhập số tiền:";
            // 
            // nhapngay
            // 
            this.nhapngay.AutoSize = true;
            this.nhapngay.Font = new System.Drawing.Font("UTM BryantLG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapngay.Location = new System.Drawing.Point(73, 109);
            this.nhapngay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nhapngay.Name = "nhapngay";
            this.nhapngay.Size = new System.Drawing.Size(89, 19);
            this.nhapngay.TabIndex = 11;
            this.nhapngay.Text = "Nhập ngày:";
            // 
            // date_ngaylaphoadon
            // 
            this.date_ngaylaphoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaylaphoadon.Location = new System.Drawing.Point(181, 103);
            this.date_ngaylaphoadon.Margin = new System.Windows.Forms.Padding(2);
            this.date_ngaylaphoadon.Name = "date_ngaylaphoadon";
            this.date_ngaylaphoadon.Size = new System.Drawing.Size(205, 26);
            this.date_ngaylaphoadon.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM BryantLG", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thêm hoá đơn";
            // 
            // add_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 225);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.TextBox tb_nhapSotien;
        private System.Windows.Forms.Button btn_huy_themhoadon;
        private System.Windows.Forms.Button btn_themhoadon;
        private System.Windows.Forms.Label nhapsotien;
        private System.Windows.Forms.Label nhapngay;
        private System.Windows.Forms.DateTimePicker date_ngaylaphoadon;
        private System.Windows.Forms.Label label1;
    }
}