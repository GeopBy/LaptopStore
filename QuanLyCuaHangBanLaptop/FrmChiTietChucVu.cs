using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLaptop
{
    public partial class FrmChiTietChucVu : Form
    {
        BLLNhanVien dbNhanVien = null;
        BLLChucVu dbChucVu = null;
        BLLChiTietChucVu dbCTChucVu = null;
        DataTable dtCTChucVu = null;
        DataTable dtNhanVien = null;
        DataTable dtChucVu = null;
        bool Them;
        public FrmChiTietChucVu()
        {
            InitializeComponent();
            dbNhanVien = new BLLNhanVien();
            dbChucVu = new BLLChucVu();
            dbCTChucVu = new BLLChiTietChucVu();
        }
        void loadData()
        {
            try
            {
                dtChucVu = new DataTable();
                dtChucVu.Clear();
                dtChucVu = dbChucVu.LayChucVu().Tables[0];
                (dgv.Columns["colChucVu"] as
                 DataGridViewComboBoxColumn).DataSource = dtChucVu;
                (dgv.Columns["colChucVu"] as
                   DataGridViewComboBoxColumn).DisplayMember = "TenChucVu";
                (dgv.Columns["colChucVu"] as
                  DataGridViewComboBoxColumn).ValueMember = "MaChucVu";
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNhanVien.LayNhanVien().Tables[0];
                (dgv.Columns["colNhanVien"] as
                 DataGridViewComboBoxColumn).DataSource = dtNhanVien;
                (dgv.Columns["colNhanVien"] as
                   DataGridViewComboBoxColumn).DisplayMember = "TenNV";
                (dgv.Columns["colNhanVien"] as
                  DataGridViewComboBoxColumn).ValueMember = "MaNV";
                dtCTChucVu = new DataTable();
                dtCTChucVu.Clear();
                dtCTChucVu = dbCTChucVu.LayChiTietChucVu().Tables[0];
                dgv.DataSource = dtCTChucVu;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table . Lỗi rồi!!!");
            }
        }

        private void FrmChiTietChucVu_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            this.cmbNhanVien.Text = dgv.Rows[r].Cells[0].ToString();
            this.cmbChucVu.Text = dgv.Rows[r].Cells[1].ToString();
            cmbNhanVien.DataSource = dtNhanVien;
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";

           cmbChucVu.DataSource = dtChucVu;
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnThoat.Enabled = true;
            dgv_CellClick(null, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnSua.Enabled = false;
            cmbNhanVien.DataSource = dtNhanVien;
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";

            cmbChucVu.DataSource = dtChucVu;
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            int r = dgv.CurrentCell.RowIndex;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.cmbNhanVien.Text = dgv.Rows[r].Cells[0].ToString();
            this.cmbChucVu.Text = dgv.Rows[r].Cells[1].ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgv.CurrentCell.RowIndex;
                int intNV =
               int.Parse(dgv.Rows[r].Cells[0].Value.ToString());
                int intCV =
               int.Parse(dgv.Rows[r].Cells[1].Value.ToString());
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                string err = "";
                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = dbCTChucVu.XoaChiTietChucVu(ref err, intNV, intCV);
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                        loadData();
                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
                    }
                }

                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
