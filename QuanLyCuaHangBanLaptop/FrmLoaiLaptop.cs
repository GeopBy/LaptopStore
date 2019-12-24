using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;

namespace QuanLyCuaHangBanLaptop
{
    public partial class FrmLoaiLaptop : Form
    {
        BLLLoaiLaptop dbLoaiLT = null;
        DataTable dtLoaiLT = null;
        bool them;
        public FrmLoaiLaptop()
        {
            InitializeComponent();
            dbLoaiLT = new BLLLoaiLaptop();
            dtLoaiLT = new DataTable();
        }
        void loadData()
        {
            try
            {
                dtLoaiLT = new DataTable();
                dtLoaiLT.Clear();
                dtLoaiLT = dbLoaiLT.LayLoaiLT().Tables[0];
                dgvLoaiLaptop.DataSource = dtLoaiLT;
                this.txtMaLoaiLaptop.ResetText();
                this.txtTenLoaiLaptop.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlLoaiLT.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table . Lỗi rồi!!!");
            }
        }

        private void FrmLoaiLaptop_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            this.txtMaLoaiLaptop.ResetText();
            this.txtTenLoaiLaptop.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlLoaiLT.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaLoaiLaptop.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiLaptop.CurrentCell.RowIndex;
            this.txtMaLoaiLaptop.Text = dgvLoaiLaptop.Rows[r].Cells[0].Value.ToString();
            this.txtTenLoaiLaptop.Text = dgvLoaiLaptop.Rows[r].Cells[1].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaLoaiLaptop.ResetText();
            this.txtTenLoaiLaptop.ResetText();

            // Không cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnlLoaiLT.Enabled = false;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            dgvLoaiLaptop_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvLoaiLaptop.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                int intMaLoaiLT=
                int.Parse(dgvLoaiLaptop.Rows[r].Cells[0].Value.ToString());
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
                    bool f = dbLoaiLT.XoaLoaiLT(ref err, intMaLoaiLT);
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
            // Đóng kết nối 
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Thêm dữ liệu 
            string err = "";
            if (them)
            {
                if (txtMaLoaiLaptop.TextLength == 0)
                {
                    MessageBox.Show("Mã Không Được Để Trống!!", "Thông Báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        int temp = dbLoaiLT.KiemTraTrungKhoa(ref err, int.Parse(txtMaLoaiLaptop.Text));
                        if (temp != 0)
                        {
                            MessageBox.Show("Mã Loại LT Này Đã Trùng!!!", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            // Lệnh Insert InTo 
                            bool f = dbLoaiLT.ThemLoaiLT(ref err, int.Parse(txtMaLoaiLaptop.Text), txtTenLoaiLaptop.Text);
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


                    bool f = dbLoaiLT.CapNhatLoaiLT(ref err,int.Parse(txtMaLoaiLaptop.Text), txtTenLoaiLaptop.Text);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            them = false;
            // Cho phép thao tác trên Panel 
            this.pnlLoaiLT.Enabled = true;

            // Thứ tự dòng hiện hành 
            int r = dgvLoaiLaptop.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaLoaiLaptop.Text =
            dgvLoaiLaptop.Rows[r].Cells[0].Value.ToString();
            this.txtTenLoaiLaptop.Text =
            dgvLoaiLaptop.Rows[r].Cells[1].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            txtMaLoaiLaptop.Enabled = false;
        }
    }
}
