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
    public partial class FrmNhaCungCap : Form
    {
        DataTable dtNCC = null;
        BLLNhaCungCap dbNCC=null;
        bool them;

        public FrmNhaCungCap()
        {
            InitializeComponent();
            dbNCC = new BLLNhaCungCap();
            dtNCC = new DataTable();
        }
        void loadData()
        {
            try
            {
                dtNCC = new DataTable();
                dtNCC.Clear();
                dtNCC = dbNCC.LayNCC().Tables[0];
                dgvNCC.DataSource = dtNCC;
                this.txtMaNCC.ResetText();
                this.txtTenNCC.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                this.txtMail.ResetText();

                this.pnl.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.btnRefresh.Enabled = true;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnThoat.Enabled = true;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table . Lỗi rồi!!!");
            }
        }

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            this.txtMaNCC.Enabled = true;
            this.txtMaNCC.ResetText();
            this.txtTenNCC.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.txtMail.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnl.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaNCC.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNCC.CurrentCell.RowIndex;
            this.txtMaNCC.Text = dgvNCC.Rows[r].Cells[0].Value.ToString();
            this.txtTenNCC.Text = dgvNCC.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text= dgvNCC.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text= dgvNCC.Rows[r].Cells[3].Value.ToString();
            this.txtMail.Text= dgvNCC.Rows[r].Cells[4].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaNCC.ResetText();
            this.txtTenNCC.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.txtMail.ResetText();

            // Không cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnl.Enabled = false;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            dgvNhaCC_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            them = false;
            // Cho phép thao tác trên Panel 
            this.pnl.Enabled = true;

            // Thứ tự dòng hiện hành 
            int r = dgvNCC.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNCC.Text =
            dgvNCC.Rows[r].Cells[0].Value.ToString();
            this.txtTenNCC.Text =
            dgvNCC.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            dgvNCC.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text =
            dgvNCC.Rows[r].Cells[3].Value.ToString();
            this.txtMail.Text =
            dgvNCC.Rows[r].Cells[4].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            txtMaNCC.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Thêm dữ liệu 
            string err = "";
            if (them)
            {
                if (txtMaNCC.TextLength == 0)
                {
                    MessageBox.Show("Mã Không Được Để Trống!!", "Thông Báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        int temp = dbNCC.KiemTraTrungKhoa(ref err, int.Parse(txtMaNCC.Text));
                        if (temp != 0)
                        {
                            MessageBox.Show("Mã NCC Này Đã Trùng!!!", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            // Lệnh Insert InTo 
                            bool f = dbNCC.ThemNCC(ref err, int.Parse(txtMaNCC.Text), txtTenNCC.Text,txtDiaChi.Text,
                                txtSDT.Text,txtMail.Text);
                            if (f)
                            {
                                // Load lại dữ liệu trên DataGridView 
                                loadData();
                                // Thông báo 
                                MessageBox.Show("Đã thêm xong!");
                            }
                            else
                            {
                                MessageBox.Show("Đã thêm chưa xong!\n\r" + "Lỗi:" + err);
                            }
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
            }
            else // Sua du lieu
            {

                try
                {


                    bool f = dbNCC.CapNhatNCC(ref err, int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiaChi.Text,
                                txtSDT.Text, txtMail.Text);
                    if (f == true)
                    {
                        loadData();
                        MessageBox.Show("Đã Cập Nhật Lại!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: '" + err + "'", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvNCC.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                int intMaNCC =
                int.Parse(dgvNCC.Rows[r].Cells[0].Value.ToString());
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                string err = "";
                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = dbNCC.XoaNCC(ref err, intMaNCC);
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
    }
}
