namespace QLPKT
{
    partial class statistical
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
            this.btn_SearchDoanhThu = new System.Windows.Forms.Button();
            this.lb_tongDT = new System.Windows.Forms.Label();
            this.lb_tongHD = new System.Windows.Forms.Label();
            this.date_thongKeTo = new System.Windows.Forms.DateTimePicker();
            this.date_thongKeFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thkDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.thkDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SearchDoanhThu
            // 
            this.btn_SearchDoanhThu.Location = new System.Drawing.Point(746, 145);
            this.btn_SearchDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SearchDoanhThu.Name = "btn_SearchDoanhThu";
            this.btn_SearchDoanhThu.Size = new System.Drawing.Size(56, 19);
            this.btn_SearchDoanhThu.TabIndex = 15;
            this.btn_SearchDoanhThu.Text = "Tìm";
            this.btn_SearchDoanhThu.UseVisualStyleBackColor = true;
            this.btn_SearchDoanhThu.Click += new System.EventHandler(this.btn_SearchDoanhThu_Click);
            // 
            // lb_tongDT
            // 
            this.lb_tongDT.AutoSize = true;
            this.lb_tongDT.Location = new System.Drawing.Point(744, 542);
            this.lb_tongDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tongDT.Name = "lb_tongDT";
            this.lb_tongDT.Size = new System.Drawing.Size(89, 13);
            this.lb_tongDT.TabIndex = 14;
            this.lb_tongDT.Text = "Tổng doanh thu: ";
            // 
            // lb_tongHD
            // 
            this.lb_tongHD.AutoSize = true;
            this.lb_tongHD.Location = new System.Drawing.Point(522, 542);
            this.lb_tongHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tongHD.Name = "lb_tongHD";
            this.lb_tongHD.Size = new System.Drawing.Size(81, 13);
            this.lb_tongHD.TabIndex = 13;
            this.lb_tongHD.Text = "Tổng hóa đơn: ";
            // 
            // date_thongKeTo
            // 
            this.date_thongKeTo.Location = new System.Drawing.Point(556, 146);
            this.date_thongKeTo.Margin = new System.Windows.Forms.Padding(2);
            this.date_thongKeTo.Name = "date_thongKeTo";
            this.date_thongKeTo.Size = new System.Drawing.Size(151, 20);
            this.date_thongKeTo.TabIndex = 12;
            // 
            // date_thongKeFrom
            // 
            this.date_thongKeFrom.Location = new System.Drawing.Point(304, 147);
            this.date_thongKeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.date_thongKeFrom.Name = "date_thongKeFrom";
            this.date_thongKeFrom.Size = new System.Drawing.Size(151, 20);
            this.date_thongKeFrom.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ ngày:";
            // 
            // thkDataTable
            // 
            this.thkDataTable.BackgroundColor = System.Drawing.Color.White;
            this.thkDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thkDataTable.Location = new System.Drawing.Point(151, 188);
            this.thkDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.thkDataTable.Name = "thkDataTable";
            this.thkDataTable.RowHeadersWidth = 51;
            this.thkDataTable.RowTemplate.Height = 24;
            this.thkDataTable.Size = new System.Drawing.Size(799, 322);
            this.thkDataTable.TabIndex = 8;
            // 
            // statistical
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btn_SearchDoanhThu);
            this.Controls.Add(this.lb_tongDT);
            this.Controls.Add(this.lb_tongHD);
            this.Controls.Add(this.date_thongKeTo);
            this.Controls.Add(this.date_thongKeFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thkDataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statistical";
            this.Text = "statistical";
            ((System.ComponentModel.ISupportInitialize)(this.thkDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchDoanhThu;
        private System.Windows.Forms.Label lb_tongDT;
        private System.Windows.Forms.Label lb_tongHD;
        private System.Windows.Forms.DateTimePicker date_thongKeTo;
        private System.Windows.Forms.DateTimePicker date_thongKeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView thkDataTable;
    }
}