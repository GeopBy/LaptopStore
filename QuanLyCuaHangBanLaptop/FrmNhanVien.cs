using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLaptop
{
    public partial class FrmNhanVien : Form
    {
        BLLNhanVien dbNhanVien = null;
        DataTable dtNhanVien = null;
        bool them;
        public FrmNhanVien()
        {
            InitializeComponent();
            dbNhanVien = new BLLNhanVien();
        }
        void loadData()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = dbNhanVien.LayNhanVien().Tables[0];
                dgv.DataSource = dtNhanVien;

                this.txtMaNV.ResetText();
                this.txtCMND.ResetText();
                this.txtHoNV.ResetText();
                this.txtTenLot.ResetText();
                this.txtTenNV.ResetText();
                this.chkboxNu.ResetText();
                chkboxNu.ResetText();
                dtpickerNgaySinh.ResetText();
                this.txtLuong.ResetText();
                this.txtSDT.ResetText();
                this.ptBoxHinhNV.ResetText();
                this.txtDiaChi.ResetText();

                this.pnl.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.btnRefresh.Enabled = true;

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnThoat.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table . Lỗi rồi!!!");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaNV.ResetText();
            this.txtCMND.ResetText();
            this.txtHoNV.ResetText();
            this.txtTenLot.ResetText();
            this.txtTenNV.ResetText();
            chkboxNu.ResetText();
            dtpickerNgaySinh.ResetText();
            this.txtDiaChi.ResetText();
            this.txtLuong.ResetText();
            this.txtSDT.ResetText();
            this.ptBoxHinhNV.ResetText();

            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnl.Enabled = false;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            dgv_CellClick(null,null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            if (them)
            {
                if (txtMaNV.TextLength == 0)
                    MessageBox.Show("Mã Không Được Để Trống!!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        int temp =dbNhanVien.KiemTraTrungKhoa(ref err, int.Parse(txtMaNV.Text));
                        if (temp != 0)
                        {
                            MessageBox.Show("Mã này đã trùng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            MemoryStream ms = new MemoryStream();
                            ptBoxHinhNV.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] byt = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(byt, 0, Convert.ToInt32(ms.Length));


                            bool f = dbNhanVien.ThemNhanVien(ref err, int.Parse(txtMaNV.Text), txtCMND.Text, txtHoNV.Text
                                , txtTenLot.Text,
                                txtTenNV.Text, bool.Parse(chkboxNu.Checked.ToString()),
                                DateTime.Parse(dtpickerNgaySinh.Text), txtDiaChi.Text, decimal.Parse(txtLuong.Text), txtSDT.Text, byt);
                            if (f)
                            {
                                loadData();
                                MessageBox.Show("Đã thêm xong!");
                            }
                            else
                            {
                                MessageBox.Show("Đã thêm chưa xong!\n\r" + "Lỗi:" + err);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
            }
            else
            {
                try
                {
                    MemoryStream ms2 = new MemoryStream();
                    ptBoxHinhNV.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byt2 = new byte[ms2.Length];
                    ms2.Position = 0;
                    ms2.Read(byt2, 0, Convert.ToInt32(ms2.Length));
                    bool f =dbNhanVien.CapNhatNhanVien(ref err, int.Parse(txtMaNV.Text), txtCMND.Text,
                                                       txtHoNV.Text, txtTenLot.Text,
                                                        txtTenNV.Text, bool.Parse(chkboxNu.Checked.ToString()),
                                                        DateTime.Parse(dtpickerNgaySinh.Text), txtDiaChi.Text,
                                                        decimal.Parse(txtLuong.Text), txtSDT.Text, byt2);

                    if (f)
                    {
                        loadData();
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
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
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgv.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                int intMaNV =
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
                    bool f = dbNhanVien.XoaNhanVien(ref err, intMaNV);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            this.pnl.Enabled = true;

            int r = dgv.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgv.Rows[r].Cells[0].Value.ToString();
            this.txtCMND.Text = dgv.Rows[r].Cells[1].Value.ToString();
            this.txtHoNV.Text = dgv.Rows[r].Cells[2].Value.ToString();
            this.txtTenLot.Text = dgv.Rows[r].Cells[3].Value.ToString();
            this.txtTenNV.Text = dgv.Rows[r].Cells[4].Value.ToString();
            this.chkboxNu.Text = dgv.Rows[r].Cells[5].Value.ToString();
            if (this.chkboxNu.Text == "True")
            {
                this.chkboxNu.Checked = true;
            }
            else this.chkboxNu.Checked = false;
            this.dtpickerNgaySinh.Text = dgv.Rows[r].Cells[6].Value.ToString();
            
            this.txtDiaChi.Text = dgv.Rows[r].Cells[7].Value.ToString();
            this.txtLuong.Text = dgv.Rows[r].Cells[8].Value.ToString();
            this.txtSDT.Text = dgv.Rows[r].Cells[9].Value.ToString();
            var data = (Byte[])(dgv.Rows[r].Cells[10].Value);
            var stream = new MemoryStream(data);
            ptBoxHinhNV.Image = Image.FromStream(stream);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnl.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaNV.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            this.txtMaNV.Enabled = true;
            this.txtMaNV.ResetText();
            this.txtCMND.ResetText();
            this.txtHoNV.ResetText();
            this.txtTenLot.ResetText();
            this.txtTenNV.ResetText();
            chkboxNu.ResetText();
            dtpickerNgaySinh.ResetText();
            this.txtDiaChi.ResetText();
            this.txtLuong.ResetText();
            this.txtSDT.ResetText();
            this.ptBoxHinhNV.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnl.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaNV.Focus();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            this.txtMaNV.Text=dgv.Rows[r].Cells[0].Value.ToString();
            this.txtCMND.Text = dgv.Rows[r].Cells[1].Value.ToString();
            this.txtHoNV.Text = dgv.Rows[r].Cells[2].Value.ToString();
            this.txtTenLot.Text = dgv.Rows[r].Cells[3].Value.ToString();
            this.txtTenNV.Text = dgv.Rows[r].Cells[4].Value.ToString();
            this.chkboxNu.Text= dgv.Rows[r].Cells[5].Value.ToString();
            this.dtpickerNgaySinh.Text = dgv.Rows[r].Cells[6].Value.ToString();
            this.txtDiaChi.Text = dgv.Rows[r].Cells[7].Value.ToString();
            this.txtLuong.Text = dgv.Rows[r].Cells[8].Value.ToString();
            this.txtSDT.Text = dgv.Rows[r].Cells[9].Value.ToString();
            var data = (Byte[])(dgv.Rows[r].Cells[10].Value);
            var stream = new MemoryStream(data);
            ptBoxHinhNV.Image = Image.FromStream(stream);
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "D:\\QuanLyCuaHangBanLaptop\\hinhLaptop";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptBoxHinhNV.Image = Image.FromStream(open.OpenFile());
            }
        }
    }
}
