namespace QLSV
{
    partial class frmLopHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbGiaoVien = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giáo Viên";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(179, 50);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(331, 24);
            this.cbbMonHoc.TabIndex = 2;
            // 
            // cbbGiaoVien
            // 
            this.cbbGiaoVien.FormattingEnabled = true;
            this.cbbGiaoVien.Location = new System.Drawing.Point(179, 89);
            this.cbbGiaoVien.Name = "cbbGiaoVien";
            this.cbbGiaoVien.Size = new System.Drawing.Size(331, 24);
            this.cbbGiaoVien.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(179, 137);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 27);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(350, 137);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 27);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 198);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbGiaoVien);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLopHoc";
            this.Text = "frmLopHoc";
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.ComboBox cbbGiaoVien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}