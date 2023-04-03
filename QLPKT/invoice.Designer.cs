namespace QLPKT
{
    partial class invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_printHd = new System.Windows.Forms.Button();
            this.btn_delHd = new System.Windows.Forms.Button();
            this.btn_editHd = new System.Windows.Forms.Button();
            this.hdDataTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btn_printHd);
            this.panel1.Controls.Add(this.btn_delHd);
            this.panel1.Controls.Add(this.btn_editHd);
            this.panel1.Controls.Add(this.hdDataTable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 700);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1069, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(910, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 101;
            this.label2.Text = "HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(967, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "Quản lý";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 762);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // btn_printHd
            // 
            this.btn_printHd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_printHd.BackgroundImage")));
            this.btn_printHd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_printHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printHd.ForeColor = System.Drawing.Color.White;
            this.btn_printHd.Location = new System.Drawing.Point(803, 625);
            this.btn_printHd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_printHd.Name = "btn_printHd";
            this.btn_printHd.Size = new System.Drawing.Size(164, 45);
            this.btn_printHd.TabIndex = 11;
            this.btn_printHd.Text = "In hóa đơn";
            this.btn_printHd.UseVisualStyleBackColor = true;
            this.btn_printHd.Click += new System.EventHandler(this.btn_printHd_Click);
            // 
            // btn_delHd
            // 
            this.btn_delHd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delHd.BackgroundImage")));
            this.btn_delHd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delHd.ForeColor = System.Drawing.Color.White;
            this.btn_delHd.Location = new System.Drawing.Point(551, 625);
            this.btn_delHd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delHd.Name = "btn_delHd";
            this.btn_delHd.Size = new System.Drawing.Size(164, 45);
            this.btn_delHd.TabIndex = 10;
            this.btn_delHd.Text = "Xóa hóa đơn";
            this.btn_delHd.UseVisualStyleBackColor = true;
            this.btn_delHd.Click += new System.EventHandler(this.btn_delHd_Click);
            // 
            // btn_editHd
            // 
            this.btn_editHd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editHd.BackgroundImage")));
            this.btn_editHd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editHd.ForeColor = System.Drawing.Color.White;
            this.btn_editHd.Location = new System.Drawing.Point(287, 625);
            this.btn_editHd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editHd.Name = "btn_editHd";
            this.btn_editHd.Size = new System.Drawing.Size(164, 45);
            this.btn_editHd.TabIndex = 9;
            this.btn_editHd.Text = "Sửa hóa đơn";
            this.btn_editHd.UseVisualStyleBackColor = true;
            this.btn_editHd.Click += new System.EventHandler(this.btn_editHd_Click);
            // 
            // hdDataTable
            // 
            this.hdDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hdDataTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hdDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hdDataTable.Location = new System.Drawing.Point(179, 114);
            this.hdDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.hdDataTable.Name = "hdDataTable";
            this.hdDataTable.ReadOnly = true;
            this.hdDataTable.RowHeadersWidth = 51;
            this.hdDataTable.RowTemplate.Height = 24;
            this.hdDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hdDataTable.Size = new System.Drawing.Size(889, 483);
            this.hdDataTable.TabIndex = 8;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_printHd;
        private System.Windows.Forms.Button btn_delHd;
        private System.Windows.Forms.Button btn_editHd;
        private System.Windows.Forms.DataGridView hdDataTable;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}