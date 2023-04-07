namespace QLPKT
{
    partial class edit_invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_invoice));
            this.label13 = new System.Windows.Forms.Label();
            this.maNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_HD = new System.Windows.Forms.DateTimePicker();
            this.money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsuaHoaDon = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_idBN = new System.Windows.Forms.Label();
            this.lb_idNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Mã bệnh nhân:";
            // 
            // maNV
            // 
            this.maNV.AutoSize = true;
            this.maNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maNV.Location = new System.Drawing.Point(40, 120);
            this.maNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maNV.Name = "maNV";
            this.maNV.Size = new System.Drawing.Size(102, 16);
            this.maNV.TabIndex = 26;
            this.maNV.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ngày lập:";
            // 
            // date_HD
            // 
            this.date_HD.Location = new System.Drawing.Point(157, 162);
            this.date_HD.Name = "date_HD";
            this.date_HD.Size = new System.Drawing.Size(213, 20);
            this.date_HD.TabIndex = 29;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(157, 203);
            this.money.Margin = new System.Windows.Forms.Padding(2);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(213, 20);
            this.money.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tổng tiền:";
            // 
            // btnsuaHoaDon
            // 
            this.btnsuaHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsuaHoaDon.BackgroundImage")));
            this.btnsuaHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuaHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuaHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuaHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnsuaHoaDon.Location = new System.Drawing.Point(43, 248);
            this.btnsuaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnsuaHoaDon.Name = "btnsuaHoaDon";
            this.btnsuaHoaDon.Size = new System.Drawing.Size(141, 40);
            this.btnsuaHoaDon.TabIndex = 42;
            this.btnsuaHoaDon.Text = "Sửa hóa đơn";
            this.btnsuaHoaDon.UseVisualStyleBackColor = true;
            this.btnsuaHoaDon.Click += new System.EventHandler(this.btnsuaHoaDon_Click);
            // 
            // cancel
            // 
            this.cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel.BackgroundImage")));
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(247, 248);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(110, 40);
            this.cancel.TabIndex = 41;
            this.cancel.Text = "Hủy";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(116, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 33);
            this.label3.TabIndex = 103;
            this.label3.Text = "Sửa hóa đơn";
            // 
            // lb_idBN
            // 
            this.lb_idBN.AutoSize = true;
            this.lb_idBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idBN.Location = new System.Drawing.Point(154, 80);
            this.lb_idBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_idBN.Name = "lb_idBN";
            this.lb_idBN.Size = new System.Drawing.Size(91, 16);
            this.lb_idBN.TabIndex = 104;
            this.lb_idBN.Text = "Mã bệnh nhân";
            // 
            // lb_idNV
            // 
            this.lb_idNV.AutoSize = true;
            this.lb_idNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idNV.Location = new System.Drawing.Point(154, 120);
            this.lb_idNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_idNV.Name = "lb_idNV";
            this.lb_idNV.Size = new System.Drawing.Size(86, 16);
            this.lb_idNV.TabIndex = 105;
            this.lb_idNV.Text = "Mã nhân viên";
            // 
            // edit_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 308);
            this.Controls.Add(this.lb_idNV);
            this.Controls.Add(this.lb_idBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsuaHoaDon);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.money);
            this.Controls.Add(this.date_HD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_invoice";
            this.Load += new System.EventHandler(this.edit_invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label maNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_HD;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsuaHoaDon;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_idBN;
        private System.Windows.Forms.Label lb_idNV;
    }
}