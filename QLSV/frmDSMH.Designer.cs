namespace QLSV
{
    partial class frmDSMH
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
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(953, 23);
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
            this.btnTimKiem.Location = new System.Drawing.Point(845, 23);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(629, 23);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(207, 26);
            this.txtTuKhoa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ khóa:";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 83);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(1170, 473);
            this.dgvMonHoc.TabIndex = 9;
            this.dgvMonHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellDoubleClick);
            // 
            // frmDSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 556);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label1);
            this.Name = "frmDSMH";
            this.Text = "frmDSMH";
            this.Load += new System.EventHandler(this.frmDSMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMonHoc;
    }
}