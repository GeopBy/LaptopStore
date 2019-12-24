namespace QuanLyCuaHangBanLaptop
{
    partial class FrmHoaDonNhap
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemCTTheoMHD = new System.Windows.Forms.Button();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLayHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriGiaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(668, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXemCTTheoMHD
            // 
            this.btnXemCTTheoMHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTTheoMHD.Location = new System.Drawing.Point(329, 37);
            this.btnXemCTTheoMHD.Name = "btnXemCTTheoMHD";
            this.btnXemCTTheoMHD.Size = new System.Drawing.Size(307, 37);
            this.btnXemCTTheoMHD.TabIndex = 8;
            this.btnXemCTTheoMHD.Text = "Xem Chi Tiết Theo Mã Hóa Đơn";
            this.btnXemCTTheoMHD.UseVisualStyleBackColor = true;
            this.btnXemCTTheoMHD.Click += new System.EventHandler(this.btnXemCTTheoMHD_Click);
            // 
            // btnXemCT
            // 
            this.btnXemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCT.Location = new System.Drawing.Point(147, 37);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(132, 37);
            this.btnXemCT.TabIndex = 7;
            this.btnXemCT.Text = "Xem Chi Tiết";
            this.btnXemCT.UseVisualStyleBackColor = true;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(0, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 37);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBan,
            this.MaKH,
            this.MaNV,
            this.NgayLapHD,
            this.NgayLayHang,
            this.TriGiaHD});
            this.dgv.Location = new System.Drawing.Point(-8, 100);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(773, 272);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // MaHDBan
            // 
            this.MaHDBan.DataPropertyName = "MaHDN";
            this.MaHDBan.HeaderText = "Mã HĐ Nhập";
            this.MaHDBan.Name = "MaHDBan";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaNCC";
            this.MaKH.HeaderText = "Mã NCC";
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày lập HD";
            this.NgayLapHD.Name = "NgayLapHD";
            // 
            // NgayLayHang
            // 
            this.NgayLayHang.DataPropertyName = "NgayNhanHang";
            this.NgayLayHang.HeaderText = "Ngày Nhận Hàng";
            this.NgayLayHang.Name = "NgayLayHang";
            // 
            // TriGiaHD
            // 
            this.TriGiaHD.DataPropertyName = "TongTien";
            this.TriGiaHD.HeaderText = "Trị Giá HĐ";
            this.TriGiaHD.Name = "TriGiaHD";
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 409);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemCTTheoMHD);
            this.Controls.Add(this.btnXemCT);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgv);
            this.Name = "FrmHoaDonNhap";
            this.Text = "FrmHoaDonNhap";
            this.Load += new System.EventHandler(this.FrmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXemCTTheoMHD;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLayHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriGiaHD;
    }
}