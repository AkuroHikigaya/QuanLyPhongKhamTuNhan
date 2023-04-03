namespace QLPKT
{
    partial class edit_hd
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
            this.nhapsotien = new System.Windows.Forms.Label();
            this.tb_nhapSotien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nhapsotien
            // 
            this.nhapsotien.AutoSize = true;
            this.nhapsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapsotien.Location = new System.Drawing.Point(114, 64);
            this.nhapsotien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nhapsotien.Name = "nhapsotien";
            this.nhapsotien.Size = new System.Drawing.Size(115, 20);
            this.nhapsotien.TabIndex = 12;
            this.nhapsotien.Text = "Nhập số tiền:";
            // 
            // tb_nhapSotien
            // 
            this.tb_nhapSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nhapSotien.Location = new System.Drawing.Point(254, 61);
            this.tb_nhapSotien.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nhapSotien.Name = "tb_nhapSotien";
            this.tb_nhapSotien.Size = new System.Drawing.Size(205, 26);
            this.tb_nhapSotien.TabIndex = 11;
            // 
            // edit_hd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nhapsotien);
            this.Controls.Add(this.tb_nhapSotien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_hd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_hd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nhapsotien;
        private System.Windows.Forms.TextBox tb_nhapSotien;
    }
}