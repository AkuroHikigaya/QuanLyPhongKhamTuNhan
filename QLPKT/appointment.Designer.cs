namespace QLPKT
{
    partial class appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointment));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lhDataTable = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_delHd = new System.Windows.Forms.Button();
            this.btn_editLh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lhDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(908, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 109;
            this.label2.Text = "LỊCH HẸN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(965, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 110;
            this.label1.Text = "Quản lý";
            // 
            // lhDataTable
            // 
            this.lhDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lhDataTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lhDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lhDataTable.Location = new System.Drawing.Point(177, 114);
            this.lhDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.lhDataTable.Name = "lhDataTable";
            this.lhDataTable.ReadOnly = true;
            this.lhDataTable.RowHeadersWidth = 51;
            this.lhDataTable.RowTemplate.Height = 24;
            this.lhDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lhDataTable.Size = new System.Drawing.Size(889, 483);
            this.lhDataTable.TabIndex = 103;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1067, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 762);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // btn_delHd
            // 
            this.btn_delHd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delHd.BackgroundImage")));
            this.btn_delHd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delHd.ForeColor = System.Drawing.Color.White;
            this.btn_delHd.Location = new System.Drawing.Point(890, 625);
            this.btn_delHd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delHd.Name = "btn_delHd";
            this.btn_delHd.Size = new System.Drawing.Size(164, 45);
            this.btn_delHd.TabIndex = 105;
            this.btn_delHd.Text = "Xóa lịch hẹn";
            this.btn_delHd.UseVisualStyleBackColor = true;
            this.btn_delHd.Click += new System.EventHandler(this.btn_delHd_Click);
            // 
            // btn_editLh
            // 
            this.btn_editLh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editLh.BackgroundImage")));
            this.btn_editLh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editLh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editLh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editLh.ForeColor = System.Drawing.Color.White;
            this.btn_editLh.Location = new System.Drawing.Point(700, 625);
            this.btn_editLh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editLh.Name = "btn_editLh";
            this.btn_editLh.Size = new System.Drawing.Size(164, 45);
            this.btn_editLh.TabIndex = 104;
            this.btn_editLh.Text = "Sửa lịch hẹn";
            this.btn_editLh.UseVisualStyleBackColor = true;
            this.btn_editLh.Click += new System.EventHandler(this.btn_editLh_Click);
            // 
            // appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_delHd);
            this.Controls.Add(this.btn_editLh);
            this.Controls.Add(this.lhDataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appointment";
            this.Load += new System.EventHandler(this.appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lhDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_delHd;
        private System.Windows.Forms.Button btn_editLh;
        private System.Windows.Forms.DataGridView lhDataTable;
    }
}