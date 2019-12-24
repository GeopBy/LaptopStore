namespace QuanLyCuaHangBanLaptop
{
    partial class FrmChiTietHoaDonBan
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
            this.gridChiTiet = new System.Windows.Forms.DataGridView();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaLT = new System.Windows.Forms.ComboBox();
            this.cbMaHDB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).BeginInit();
            this.pnlChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridChiTiet
            // 
            this.gridChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBan,
            this.MaLT,
            this.GiaBan,
            this.colSoLuong});
            this.gridChiTiet.Location = new System.Drawing.Point(12, 99);
            this.gridChiTiet.Name = "gridChiTiet";
            this.gridChiTiet.Size = new System.Drawing.Size(657, 253);
            this.gridChiTiet.TabIndex = 41;
            // 
            // MaHDBan
            // 
            this.MaHDBan.DataPropertyName = "MaHDB";
            this.MaHDBan.Frozen = true;
            this.MaHDBan.HeaderText = "Mã HĐ bán";
            this.MaHDBan.Name = "MaHDBan";
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
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá";
            this.GiaBan.Name = "GiaBan";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
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
            // cbMaHDB
            // 
            this.cbMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaHDB.FormattingEnabled = true;
            this.cbMaHDB.Location = new System.Drawing.Point(73, 11);
            this.cbMaHDB.Name = "cbMaHDB";
            this.cbMaHDB.Size = new System.Drawing.Size(73, 28);
            this.cbMaHDB.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Giá bán:";
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
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(361, 13);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(122, 26);
            this.txtGiaBan.TabIndex = 32;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(245, 13);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(35, 26);
            this.txtSoLuong.TabIndex = 33;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
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
            this.lab.Text = "Mã HĐB:";
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.Controls.Add(this.cbMaLT);
            this.pnlChiTiet.Controls.Add(this.cbMaHDB);
            this.pnlChiTiet.Controls.Add(this.label3);
            this.pnlChiTiet.Controls.Add(this.label4);
            this.pnlChiTiet.Controls.Add(this.txtGiaBan);
            this.pnlChiTiet.Controls.Add(this.txtSoLuong);
            this.pnlChiTiet.Controls.Add(this.label2);
            this.pnlChiTiet.Controls.Add(this.lab);
            this.pnlChiTiet.Location = new System.Drawing.Point(12, 7);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(496, 86);
            this.pnlChiTiet.TabIndex = 40;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(675, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 42);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(675, 95);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 42);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(675, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 42);
            this.btnLuu.TabIndex = 48;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(675, 238);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 42);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(675, 161);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 58);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmChiTietHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 367);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridChiTiet);
            this.Controls.Add(this.pnlChiTiet);
            this.Name = "FrmChiTietHoaDonBan";
            this.Text = "FrmChiTietHoaDonBan";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).EndInit();
            this.pnlChiTiet.ResumeLayout(false);
            this.pnlChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridChiTiet;
        private System.Windows.Forms.ComboBox cbMaLT;
        private System.Windows.Forms.ComboBox cbMaHDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}