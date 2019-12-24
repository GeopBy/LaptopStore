namespace QuanLyCuaHangBanLaptop
{
    partial class FrmLoaiLaptop
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlLoaiLT = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiLaptop = new System.Windows.Forms.TextBox();
            this.txtTenLoaiLaptop = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvLoaiLaptop = new System.Windows.Forms.DataGridView();
            this.colMaLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLoaiLT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiLaptop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(667, 346);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 42);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlLoaiLT
            // 
            this.pnlLoaiLT.Controls.Add(this.label2);
            this.pnlLoaiLT.Controls.Add(this.label1);
            this.pnlLoaiLT.Controls.Add(this.txtMaLoaiLaptop);
            this.pnlLoaiLT.Controls.Add(this.txtTenLoaiLaptop);
            this.pnlLoaiLT.Location = new System.Drawing.Point(1, 12);
            this.pnlLoaiLT.Name = "pnlLoaiLT";
            this.pnlLoaiLT.Size = new System.Drawing.Size(440, 136);
            this.pnlLoaiLT.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên loại Laptop:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã loại Laptop:";
            // 
            // txtMaLoaiLaptop
            // 
            this.txtMaLoaiLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiLaptop.Location = new System.Drawing.Point(185, 30);
            this.txtMaLoaiLaptop.Name = "txtMaLoaiLaptop";
            this.txtMaLoaiLaptop.Size = new System.Drawing.Size(225, 26);
            this.txtMaLoaiLaptop.TabIndex = 20;
            // 
            // txtTenLoaiLaptop
            // 
            this.txtTenLoaiLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiLaptop.Location = new System.Drawing.Point(185, 81);
            this.txtTenLoaiLaptop.Name = "txtTenLoaiLaptop";
            this.txtTenLoaiLaptop.Size = new System.Drawing.Size(225, 26);
            this.txtTenLoaiLaptop.TabIndex = 21;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(673, 265);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 42);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(673, 106);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 42);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(510, 106);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 42);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(673, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 42);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(679, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 42);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(510, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 42);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvLoaiLaptop
            // 
            this.dgvLoaiLaptop.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvLoaiLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiLaptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiSanPham,
            this.colTenLoaiSanPham});
            this.dgvLoaiLaptop.Location = new System.Drawing.Point(1, 175);
            this.dgvLoaiLaptop.Name = "dgvLoaiLaptop";
            this.dgvLoaiLaptop.Size = new System.Drawing.Size(646, 213);
            this.dgvLoaiLaptop.TabIndex = 37;
            this.dgvLoaiLaptop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiLaptop_CellClick);
            // 
            // colMaLoaiSanPham
            // 
            this.colMaLoaiSanPham.DataPropertyName = "MaLoaiLT";
            this.colMaLoaiSanPham.Frozen = true;
            this.colMaLoaiSanPham.HeaderText = "Mã loại Laptop";
            this.colMaLoaiSanPham.Name = "colMaLoaiSanPham";
            this.colMaLoaiSanPham.Width = 300;
            // 
            // colTenLoaiSanPham
            // 
            this.colTenLoaiSanPham.DataPropertyName = "TenLoaiLT";
            this.colTenLoaiSanPham.HeaderText = "Tên loại Laptop";
            this.colTenLoaiSanPham.Name = "colTenLoaiSanPham";
            this.colTenLoaiSanPham.Width = 300;
            // 
            // FrmLoaiLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(810, 405);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.pnlLoaiLT);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLoaiLaptop);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmLoaiLaptop";
            this.Text = "FrmLoaiLaptop";
            this.Load += new System.EventHandler(this.FrmLoaiLaptop_Load);
            this.pnlLoaiLT.ResumeLayout(false);
            this.pnlLoaiLT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiLaptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlLoaiLT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiLaptop;
        private System.Windows.Forms.TextBox txtTenLoaiLaptop;
        private System.Windows.Forms.DataGridView dgvLoaiLaptop;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiSanPham;
    }
}