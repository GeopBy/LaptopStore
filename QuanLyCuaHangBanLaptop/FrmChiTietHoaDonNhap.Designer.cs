namespace QuanLyCuaHangBanLaptop
{
    partial class FrmChiTietHoaDonNhap
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.cbMaLT = new System.Windows.Forms.ComboBox();
            this.cbMaHDN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridChiTiet = new System.Windows.Forms.DataGridView();
            this.MaHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(675, 307);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 42);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(675, 92);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 42);
            this.btnHuy.TabIndex = 56;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(675, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 42);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(675, 158);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 58);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.Controls.Add(this.cbMaLT);
            this.pnlChiTiet.Controls.Add(this.cbMaHDN);
            this.pnlChiTiet.Controls.Add(this.label3);
            this.pnlChiTiet.Controls.Add(this.label4);
            this.pnlChiTiet.Controls.Add(this.txtGiaNhap);
            this.pnlChiTiet.Controls.Add(this.txtSoLuong);
            this.pnlChiTiet.Controls.Add(this.label2);
            this.pnlChiTiet.Controls.Add(this.lab);
            this.pnlChiTiet.Location = new System.Drawing.Point(12, 4);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(496, 86);
            this.pnlChiTiet.TabIndex = 51;
            // 
            // cbMaLT
            // 
            this.cbMaLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLT.FormattingEnabled = true;
            this.cbMaLT.Location = new System.Drawing.Point(73, 55);
            this.cbMaLT.Name = "cbMaLT";
            this.cbMaLT.Size = new System.Drawing.Size(410, 28);
            this.cbMaLT.TabIndex = 37;
            // 
            // cbMaHDN
            // 
            this.cbMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaHDN.FormattingEnabled = true;
            this.cbMaHDN.Location = new System.Drawing.Point(73, 11);
            this.cbMaHDN.Name = "cbMaHDN";
            this.cbMaHDN.Size = new System.Drawing.Size(73, 28);
            this.cbMaHDN.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Giá nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Số lượng:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(361, 13);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(122, 26);
            this.txtGiaNhap.TabIndex = 32;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(245, 13);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(35, 26);
            this.txtSoLuong.TabIndex = 33;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Laptop";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(3, 15);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(74, 20);
            this.lab.TabIndex = 25;
            this.lab.Text = "Mã HĐN:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(675, 235);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 42);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridChiTiet
            // 
            this.gridChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDNhap,
            this.MaLT,
            this.GiaBan,
            this.colSoLuong});
            this.gridChiTiet.Location = new System.Drawing.Point(12, 96);
            this.gridChiTiet.Name = "gridChiTiet";
            this.gridChiTiet.Size = new System.Drawing.Size(657, 253);
            this.gridChiTiet.TabIndex = 52;
            // 
            // MaHDNhap
            // 
            this.MaHDNhap.DataPropertyName = "MaHDN";
            this.MaHDNhap.Frozen = true;
            this.MaHDNhap.HeaderText = "Mã HĐ nhập";
            this.MaHDNhap.Name = "MaHDNhap";
            // 
            // MaLT
            // 
            this.MaLT.DataPropertyName = "MaLT";
            this.MaLT.HeaderText = "Mã LT";
            this.MaLT.Name = "MaLT";
            this.MaLT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaNhap";
            this.GiaBan.HeaderText = "Giá";
            this.GiaBan.Name = "GiaBan";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // FrmChiTietHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 354);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.pnlChiTiet);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridChiTiet);
            this.Name = "FrmChiTietHoaDonNhap";
            this.Text = "FrmChiTietHoaDonNhap";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDonNhap_Load);
            this.pnlChiTiet.ResumeLayout(false);
            this.pnlChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.ComboBox cbMaLT;
        private System.Windows.Forms.ComboBox cbMaHDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gridChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}