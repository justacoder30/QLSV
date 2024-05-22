namespace QLSV
{
    partial class frmDSGV
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
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.magiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(1006, 13);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 28);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(898, 13);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(682, 13);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 26);
            this.txtTimKiem.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm:";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiaovien,
            this.hoten,
            this.gt,
            this.dienthoai,
            this.email,
            this.diachi,
            this.btnXoa});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 77);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiaoVien.MultiSelect = false;
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1225, 473);
            this.dgvGiaoVien.TabIndex = 9;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            this.dgvGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellDoubleClick);
            // 
            // magiaovien
            // 
            this.magiaovien.DataPropertyName = "magiaovien";
            this.magiaovien.HeaderText = "Mã giáo viên";
            this.magiaovien.MinimumWidth = 6;
            this.magiaovien.Name = "magiaovien";
            this.magiaovien.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ và Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // gt
            // 
            this.gt.DataPropertyName = "gt";
            this.gt.HeaderText = "Giới Tính";
            this.gt.MinimumWidth = 6;
            this.gt.Name = "gt";
            this.gt.ReadOnly = true;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện thoại";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ReadOnly = true;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
            // 
            // frmDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 550);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Name = "frmDSGV";
            this.Text = "Danh sách giáo viên";
            this.Load += new System.EventHandler(this.frmDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}