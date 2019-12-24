namespace QuanLyCuaHangBanLaptop
{
    partial class FrmBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.LvChiTiet = new System.Windows.Forms.ListView();
            this.MaHDBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaSP1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaBan1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThanhTien = new System.Windows.Forms.Button();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLaptop = new System.Windows.Forms.DataGridView();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnTaoMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(356, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 301);
            this.panel1.TabIndex = 128;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(4, 243);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(105, 42);
            this.btnThanhToan.TabIndex = 69;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.Location = new System.Drawing.Point(6, 162);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(105, 64);
            this.btnTaoMoi.TabIndex = 68;
            this.btnTaoMoi.Text = "Tạo HĐ mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(4, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 42);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 42);
            this.btnThem.TabIndex = 65;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(6, 16);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(103, 20);
            this.numSoLuong.TabIndex = 64;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Số lượng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(99, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(122, 20);
            this.txtMaHD.TabIndex = 43;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(596, 422);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(154, 20);
            this.txtTongTien.TabIndex = 130;
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Enabled = false;
            this.chkNu.Location = new System.Drawing.Point(664, 77);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(15, 14);
            this.chkNu.TabIndex = 27;
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // LvChiTiet
            // 
            this.LvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHDBan,
            this.MaSP1,
            this.SoLuong,
            this.GiaBan1});
            this.LvChiTiet.Location = new System.Drawing.Point(476, 153);
            this.LvChiTiet.Name = "LvChiTiet";
            this.LvChiTiet.Size = new System.Drawing.Size(384, 250);
            this.LvChiTiet.TabIndex = 132;
            this.LvChiTiet.UseCompatibleStateImageBehavior = false;
            this.LvChiTiet.View = System.Windows.Forms.View.Details;
            // 
            // MaHDBan
            // 
            this.MaHDBan.Text = "Mã HĐ";
            // 
            // MaSP1
            // 
            this.MaSP1.Text = "Mã LT";
            this.MaSP1.Width = 94;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.Width = 123;
            // 
            // GiaBan1
            // 
            this.GiaBan1.Text = "Giá bán";
            this.GiaBan1.Width = 103;
            // 
            // btnThanhTien
            // 
            this.btnThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhTien.Location = new System.Drawing.Point(492, 409);
            this.btnThanhTien.Name = "btnThanhTien";
            this.btnThanhTien.Size = new System.Drawing.Size(88, 34);
            this.btnThanhTien.TabIndex = 133;
            this.btnThanhTien.Text = "Thành tiền";
            this.btnThanhTien.UseVisualStyleBackColor = true;
            this.btnThanhTien.Click += new System.EventHandler(this.btnThanhTien_Click);
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(733, 71);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(122, 20);
            this.txtSDTNV.TabIndex = 48;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(401, 18);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(178, 21);
            this.cbKhachHang.TabIndex = 28;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.chkNu);
            this.groupBox1.Controls.Add(this.txtSDTNV);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.cbNhanVien);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.dtNgayNhan);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(1, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 140);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(664, 45);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(191, 20);
            this.txtTenNV.TabIndex = 47;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(664, 18);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(193, 21);
            this.cbNhanVien.TabIndex = 29;
            this.cbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbNhanVien_SelectedIndexChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(401, 106);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(278, 20);
            this.txtDiaChi.TabIndex = 46;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Location = new System.Drawing.Point(99, 52);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(198, 20);
            this.dtNgayLap.TabIndex = 30;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(401, 78);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(122, 20);
            this.txtSDT.TabIndex = 45;
            // 
            // dtNgayNhan
            // 
            this.dtNgayNhan.Location = new System.Drawing.Point(99, 78);
            this.dtNgayNhan.Name = "dtNgayNhan";
            this.dtNgayNhan.Size = new System.Drawing.Size(198, 20);
            this.dtNgayNhan.TabIndex = 31;
            this.dtNgayNhan.ValueChanged += new System.EventHandler(this.dtNgayNhan_ValueChanged);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(401, 51);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(122, 20);
            this.txtTenKhachHang.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã HĐ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ngày lập:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày nhận:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(685, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mã KH:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nữ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tên KH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tên NV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "SĐT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Mã NV:";
            // 
            // dgvLaptop
            // 
            this.dgvLaptop.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLT,
            this.TenLT,
            this.Loai,
            this.DonGia,
            this.dataGridViewTextBoxColumn1,
            this.Hinh,
            this.GhiChu});
            this.dgvLaptop.Location = new System.Drawing.Point(1, 153);
            this.dgvLaptop.Name = "dgvLaptop";
            this.dgvLaptop.Size = new System.Drawing.Size(355, 301);
            this.dgvLaptop.TabIndex = 134;
            this.dgvLaptop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaptop_CellClick);
            // 
            // MaLT
            // 
            this.MaLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaLT.DataPropertyName = "MaLT";
            this.MaLT.HeaderText = "Mã Laptop";
            this.MaLT.Name = "MaLT";
            this.MaLT.Width = 83;
            // 
            // TenLT
            // 
            this.TenLT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenLT.DataPropertyName = "TenLT";
            this.TenLT.HeaderText = "Tên Laptop";
            this.TenLT.Name = "TenLT";
            this.TenLT.Width = 87;
            // 
            // Loai
            // 
            this.Loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            this.Loai.Width = 39;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 71;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SoLuongCon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Lượng Còn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Hinh
            // 
            this.Hinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình";
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 54;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 70;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 460);
            this.Controls.Add(this.dgvLaptop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.LvChiTiet);
            this.Controls.Add(this.btnThanhTien);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.ListView LvChiTiet;
        private System.Windows.Forms.ColumnHeader MaHDBan;
        private System.Windows.Forms.ColumnHeader MaSP1;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader GiaBan1;
        private System.Windows.Forms.Button btnThanhTien;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtNgayNhan;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvLaptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLT;
        private System.Windows.Forms.DataGridViewComboBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}