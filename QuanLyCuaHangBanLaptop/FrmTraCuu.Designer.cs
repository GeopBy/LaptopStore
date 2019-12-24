namespace QuanLyCuaHangBanLaptop
{
    partial class FrmTraCuu
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKho = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVitinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radLoai = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.colMaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupGia = new System.Windows.Forms.GroupBox();
            this.radMucGia = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.radTen = new System.Windows.Forms.RadioButton();
            this.cmbLoaiLT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupGia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLT,
            this.TenLT,
            this.Loai,
            this.DonGia,
            this.SoLuongCon,
            this.Hinh,
            this.GhiChu});
            this.dgv.Location = new System.Drawing.Point(30, 225);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(879, 186);
            this.dgv.TabIndex = 45;
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
            // SoLuongCon
            // 
            this.SoLuongCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoLuongCon.DataPropertyName = "SoLuongCon";
            this.SoLuongCon.HeaderText = "Số Lượng Còn";
            this.SoLuongCon.Name = "SoLuongCon";
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
            // colMaKho
            // 
            this.colMaKho.DataPropertyName = "MaKho";
            this.colMaKho.HeaderText = "Mã kho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaKho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            // 
            // colDonVitinh
            // 
            this.colDonVitinh.DataPropertyName = "DonViTinh";
            this.colDonVitinh.HeaderText = "Đơn vị tính";
            this.colDonVitinh.Name = "colDonVitinh";
            this.colDonVitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDonVitinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TenSP";
            this.colTenSanPham.HeaderText = "Tên SP";
            this.colTenSanPham.Name = "colTenSanPham";
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad1.Location = new System.Drawing.Point(6, 19);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(87, 23);
            this.rad1.TabIndex = 6;
            this.rad1.TabStop = true;
            this.rad1.Text = "Dưới 10tr";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad5.Location = new System.Drawing.Point(194, 48);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(110, 23);
            this.rad5.TabIndex = 10;
            this.rad5.TabStop = true;
            this.rad5.Text = "Lớn Hơn 50tr";
            this.rad5.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad2.Location = new System.Drawing.Point(4, 48);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(107, 23);
            this.rad2.TabIndex = 7;
            this.rad2.TabStop = true;
            this.rad2.Text = "10tr đến 20tr";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad4.Location = new System.Drawing.Point(194, 19);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(107, 23);
            this.rad4.TabIndex = 9;
            this.rad4.TabStop = true;
            this.rad4.Text = "30tr đến 50tr";
            this.rad4.UseVisualStyleBackColor = true;
            this.rad4.CheckedChanged += new System.EventHandler(this.rad4_CheckedChanged);
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSP";
            this.colMaSanPham.Frozen = true;
            this.colMaSanPham.HeaderText = "Mã SP";
            this.colMaSanPham.Name = "colMaSanPham";
            // 
            // radLoai
            // 
            this.radLoai.AutoSize = true;
            this.radLoai.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radLoai.ForeColor = System.Drawing.Color.Black;
            this.radLoai.Location = new System.Drawing.Point(48, 10);
            this.radLoai.Name = "radLoai";
            this.radLoai.Size = new System.Drawing.Size(146, 26);
            this.radLoai.TabIndex = 0;
            this.radLoai.TabStop = true;
            this.radLoai.Text = "Tìm Theo Loại";
            this.radLoai.UseVisualStyleBackColor = true;
            this.radLoai.CheckedChanged += new System.EventHandler(this.radLoai_CheckedChanged);
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad3.Location = new System.Drawing.Point(4, 77);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(107, 23);
            this.rad3.TabIndex = 8;
            this.rad3.TabStop = true;
            this.rad3.Text = "20tr đến 30tr";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MaLoai";
            this.colMaLoai.HeaderText = "Mã loại";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(284, 101);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 42);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(48, 98);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 42);
            this.btnTim.TabIndex = 45;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupGia
            // 
            this.groupGia.Controls.Add(this.rad1);
            this.groupGia.Controls.Add(this.rad5);
            this.groupGia.Controls.Add(this.rad2);
            this.groupGia.Controls.Add(this.rad4);
            this.groupGia.Controls.Add(this.rad3);
            this.groupGia.Location = new System.Drawing.Point(519, 43);
            this.groupGia.Name = "groupGia";
            this.groupGia.Size = new System.Drawing.Size(335, 117);
            this.groupGia.TabIndex = 11;
            this.groupGia.TabStop = false;
            this.groupGia.Text = "Theo mức giá";
            // 
            // radMucGia
            // 
            this.radMucGia.AutoSize = true;
            this.radMucGia.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radMucGia.ForeColor = System.Drawing.Color.Black;
            this.radMucGia.Location = new System.Drawing.Point(523, 10);
            this.radMucGia.Name = "radMucGia";
            this.radMucGia.Size = new System.Drawing.Size(181, 26);
            this.radMucGia.TabIndex = 2;
            this.radMucGia.TabStop = true;
            this.radMucGia.Text = "Tìm Theo Mức Giá";
            this.radMucGia.UseVisualStyleBackColor = true;
            this.radMucGia.CheckedChanged += new System.EventHandler(this.radMucGia_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLoaiLT);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.radTen);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.groupGia);
            this.panel1.Controls.Add(this.radMucGia);
            this.panel1.Controls.Add(this.radLoai);
            this.panel1.Location = new System.Drawing.Point(30, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 159);
            this.panel1.TabIndex = 46;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(284, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(229, 26);
            this.txtTen.TabIndex = 48;
            // 
            // radTen
            // 
            this.radTen.AutoSize = true;
            this.radTen.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radTen.ForeColor = System.Drawing.Color.Black;
            this.radTen.Location = new System.Drawing.Point(284, 10);
            this.radTen.Name = "radTen";
            this.radTen.Size = new System.Drawing.Size(146, 26);
            this.radTen.TabIndex = 47;
            this.radTen.TabStop = true;
            this.radTen.Text = "Tìm Theo Tên:";
            this.radTen.UseVisualStyleBackColor = true;
            this.radTen.CheckedChanged += new System.EventHandler(this.radTen_CheckedChanged);
            // 
            // cmbLoaiLT
            // 
            this.cmbLoaiLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiLT.FormattingEnabled = true;
            this.cmbLoaiLT.Location = new System.Drawing.Point(48, 57);
            this.cmbLoaiLT.Name = "cmbLoaiLT";
            this.cmbLoaiLT.Size = new System.Drawing.Size(121, 28);
            this.cmbLoaiLT.TabIndex = 49;
            // 
            // FrmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Name = "FrmTraCuu";
            this.Text = "FrmTraCuu";
            this.Load += new System.EventHandler(this.FrmTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupGia.ResumeLayout(false);
            this.groupGia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLT;
        private System.Windows.Forms.DataGridViewComboBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDonVitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.RadioButton radLoai;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaLoai;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupGia;
        private System.Windows.Forms.RadioButton radMucGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.RadioButton radTen;
        private System.Windows.Forms.ComboBox cmbLoaiLT;
    }
}