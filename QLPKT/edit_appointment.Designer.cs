namespace QLPKT
{
    partial class edit_appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_appointment));
            this.time_H = new System.Windows.Forms.DateTimePicker();
            this.lbNameBN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_textIdBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_H = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tenBN = new System.Windows.Forms.Label();
            this.lb_mBN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editLichHen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // time_H
            // 
            this.time_H.CustomFormat = "hh:mm:ss tt";
            this.time_H.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_H.Location = new System.Drawing.Point(166, 194);
            this.time_H.Name = "time_H";
            this.time_H.ShowUpDown = true;
            this.time_H.Size = new System.Drawing.Size(85, 20);
            this.time_H.TabIndex = 120;
            // 
            // lbNameBN
            // 
            this.lbNameBN.AutoSize = true;
            this.lbNameBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameBN.Location = new System.Drawing.Point(163, 117);
            this.lbNameBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameBN.Name = "lbNameBN";
            this.lbNameBN.Size = new System.Drawing.Size(44, 16);
            this.lbNameBN.TabIndex = 117;
            this.lbNameBN.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 116;
            // 
            // lb_textIdBN
            // 
            this.lb_textIdBN.AutoSize = true;
            this.lb_textIdBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_textIdBN.Location = new System.Drawing.Point(163, 81);
            this.lb_textIdBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_textIdBN.Name = "lb_textIdBN";
            this.lb_textIdBN.Size = new System.Drawing.Size(20, 16);
            this.lb_textIdBN.TabIndex = 115;
            this.lb_textIdBN.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 114;
            this.label1.Text = "Sửa lịch hẹn";
            // 
            // date_H
            // 
            this.date_H.Location = new System.Drawing.Point(166, 155);
            this.date_H.Name = "date_H";
            this.date_H.Size = new System.Drawing.Size(200, 20);
            this.date_H.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "Ngày hẹn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Giờ hẹn:";
            // 
            // lb_tenBN
            // 
            this.lb_tenBN.AutoSize = true;
            this.lb_tenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenBN.Location = new System.Drawing.Point(42, 117);
            this.lb_tenBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tenBN.Name = "lb_tenBN";
            this.lb_tenBN.Size = new System.Drawing.Size(113, 16);
            this.lb_tenBN.TabIndex = 110;
            this.lb_tenBN.Text = "Tên bệnh nhân:";
            // 
            // lb_mBN
            // 
            this.lb_mBN.AutoSize = true;
            this.lb_mBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mBN.Location = new System.Drawing.Point(42, 81);
            this.lb_mBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mBN.Name = "lb_mBN";
            this.lb_mBN.Size = new System.Drawing.Size(107, 16);
            this.lb_mBN.TabIndex = 109;
            this.lb_mBN.Text = "Mã bệnh nhân:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(268, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 119;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editLichHen
            // 
            this.editLichHen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editLichHen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editLichHen.BackgroundImage")));
            this.editLichHen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editLichHen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLichHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLichHen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLichHen.ForeColor = System.Drawing.Color.Transparent;
            this.editLichHen.Location = new System.Drawing.Point(45, 280);
            this.editLichHen.Margin = new System.Windows.Forms.Padding(2);
            this.editLichHen.Name = "editLichHen";
            this.editLichHen.Size = new System.Drawing.Size(141, 40);
            this.editLichHen.TabIndex = 118;
            this.editLichHen.Text = "Sửa lịch hẹn";
            this.editLichHen.UseVisualStyleBackColor = false;
            this.editLichHen.Click += new System.EventHandler(this.editLichHen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 121;
            this.label6.Text = "Trạng thái:";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(166, 232);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(132, 20);
            this.status.TabIndex = 122;
            // 
            // edit_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 354);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.time_H);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editLichHen);
            this.Controls.Add(this.lbNameBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_textIdBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_H);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_tenBN);
            this.Controls.Add(this.lb_mBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_appointment";
            this.Load += new System.EventHandler(this.edit_appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker time_H;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editLichHen;
        private System.Windows.Forms.Label lbNameBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_textIdBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_H;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tenBN;
        private System.Windows.Forms.Label lb_mBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox status;
    }
}