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
    public partial class FormKhachHang : Form
    {
        BLLKhachHang kh = null;
        DataTable dtKh = null;
        bool Them;
        public FormKhachHang()
        {
            InitializeComponent();

            kh = new BLLKhachHang();
            dtKh = new DataTable();
        }
        void loaddata()
        {
            try
            {


                // Vận chuyển dữ liệu vào DataTable 

                dtKh = new DataTable();
                dtKh.Clear();
                dtKh = kh.LayKhachHang().Tables[0];
                // Đưa dữ liệu lên DataGridView  
                dgv.DataSource = dtKh;
                // Xóa trống các đối tượng trong Panel 
                this.txtMaKH.ResetText();
                this.txtTenKH.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                this.txtGhiChu.ResetText();
                this.rchTimKiem.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
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

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.txtGhiChu.ResetText();
            this.rchTimKiem.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel1.Enabled = false;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            dgv_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Thêm dữ liệu 
            string err = "";
            if (Them)
            {
                try
                {
                    int temp = kh.KiemTraTrungKhoa(ref err, int.Parse(txtMaKH.Text));
                    if (temp != 0)
                    {
                        MessageBox.Show("Mã Khách Hàng Này Đã Trùng!!!", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        // Lệnh Insert InTo 
                        bool f = kh.ThemKhachHang(ref err, int.Parse(txtMaKH.Text), txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
                        if (f)
                        {
                            // Load lại dữ liệu trên DataGridView 
                            loaddata();
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
            else // Sua du lieu
            {
                try
                {

                    // Lệnh Insert InTo 
                    bool f = kh.CapNhatKhachHang(ref err, int.Parse(txtMaKH.Text), txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        loaddata();
                        // Thông báo 
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không cập nhật được. Lỗi rồi!");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgv.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                int strMaHopDong =
                int.Parse(dgv.Rows[r].Cells[0].Value.ToString());
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
                    bool f = kh.XoaKhachHang(ref err, strMaHopDong);
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                        loaddata();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            this.panel1.Enabled = true;
            this.panel2.Enabled = true;
            // Thứ tự dòng hiện hành 
            int r = dgv.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaKH.Text =
            dgv.Rows[r].Cells[0].Value.ToString();
            this.txtTenKH.Text =
            dgv.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            dgv.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text =
            dgv.Rows[r].Cells[3].Value.ToString();
            this.txtGhiChu.Text =
            dgv.Rows[r].Cells[4].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;
            this.panel2.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;
            // Xóa trống các đối tượng trong Panel 
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.txtGhiChu.ResetText();
            this.rchTimKiem.ResetText();
            this.txtMaKH.Enabled = true;
            // cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;
            this.panel2.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
            this.txtMaKH.Focus();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgv.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaKH.Text =
            dgv.Rows[r].Cells[0].Value.ToString();
            this.txtTenKH.Text =
            dgv.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            dgv.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text =
            dgv.Rows[r].Cells[3].Value.ToString();
            this.txtGhiChu.Text =
            dgv.Rows[r].Cells[4].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dtKh = new DataTable();
                dtKh.Clear();
                dtKh = kh.TimKiemKhachHangTheoTen(rchTimKiem.Text).Tables[0];
                dgv.DataSource = dtKh;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
