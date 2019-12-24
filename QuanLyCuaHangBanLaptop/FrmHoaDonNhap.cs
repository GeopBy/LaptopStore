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
    public partial class FrmHoaDonNhap : Form
    {
        BLLHoaDonNhap hd = null;
        DataTable dthd = null;
        public FrmHoaDonNhap()
        {
            InitializeComponent();
            hd = new BLLHoaDonNhap();
        }
        public void LoadData()
        {
            try
            {



                btnRefresh.Enabled = true;

                //khoá tìm kiếm


                dthd = new DataTable();
                dthd.Clear();
                dthd = hd.LayHoaDonNhap().Tables[0];
                dgv.DataSource = dthd;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
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
                    bool f = hd.XoaHoaDonNhap(ref err, strMaHopDong);
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                        LoadData();
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

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            BienKiemTra.theoMaHD = false;
            FrmChiTietHoaDonNhap frm = new FrmChiTietHoaDonNhap();
            frm.ShowDialog();
        }

        private void btnXemCTTheoMHD_Click(object sender, EventArgs e)
        {
            BienKiemTra.theoMaHD = true;
            if (dgv.RowCount <= 0)
            {
                MessageBox.Show("Không Có Dòng Nào Được Chọn", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Lấy thứ tự record hiện hành 
                int r = dgv.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 


                BienKiemTra.maHD = int.Parse(dgv.Rows[r].Cells[0].Value.ToString());
                FrmChiTietHoaDonNhap frm = new FrmChiTietHoaDonNhap();
                frm.ShowDialog();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
