namespace QuanLyCuaHangBanLaptop
{
    partial class FrmKiemTraHangTon
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
            this.gridSanPham = new System.Windows.Forms.DataGridView();
            this.btnBanHet = new System.Windows.Forms.Button();
            this.btnTonKho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSanPham
            // 
            this.gridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSanPham.Location = new System.Drawing.Point(14, 143);
            this.gridSanPham.Name = "gridSanPham";
            this.gridSanPham.Size = new System.Drawing.Size(747, 192);
            this.gridSanPham.TabIndex = 45;
            // 
            // btnBanHet
            // 
            this.btnBanHet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHet.Location = new System.Drawing.Point(423, 64);
            this.btnBanHet.Name = "btnBanHet";
            this.btnBanHet.Size = new System.Drawing.Size(200, 42);
            this.btnBanHet.TabIndex = 44;
            this.btnBanHet.Text = "Laptop bán hết";
            this.btnBanHet.UseVisualStyleBackColor = true;
            this.btnBanHet.Click += new System.EventHandler(this.btnBanHet_Click);
            // 
            // btnTonKho
            // 
            this.btnTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTonKho.Location = new System.Drawing.Point(89, 64);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Size = new System.Drawing.Size(211, 42);
            this.btnTonKho.TabIndex = 43;
            this.btnTonKho.Text = "Laptop còn hàng";
            this.btnTonKho.UseVisualStyleBackColor = true;
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);
            // 
            // FrmKiemTraHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 399);
            this.Controls.Add(this.gridSanPham);
            this.Controls.Add(this.btnBanHet);
            this.Controls.Add(this.btnTonKho);
            this.Name = "FrmKiemTraHangTon";
            this.Text = "FrmKiemTraHangTon";
            this.Load += new System.EventHandler(this.FrmKiemTraHangTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSanPham;
        private System.Windows.Forms.Button btnBanHet;
        private System.Windows.Forms.Button btnTonKho;
    }
}