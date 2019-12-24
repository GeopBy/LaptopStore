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
    public partial class FrmNhapHang : Form
    {
        BLLHoaDonNhap hoaDon = null;
        BLLNhaCungCap cungCap = null;
        BLLNhanVien nhanVien = null;
        BLLLaptop laptop = null;
        BLLChiTietHoaDonNhap chiTiet = null;
        BLLLoaiLaptop dbLoaiLaptop = null;

        DataSet dsHoaDon = null;
        DataTable dtLaptop = null;
        DataTable dtNhanVien = null;
        DataTable dtCungCap = null;
        DataTable dtChiTiet = null;
        DataTable dtLoaiLaptop = null;
        decimal TongTien;
        int[] MangMaHoaDon = new int[40];
        int[] MangMaSanPham = new int[40];
        int[] MangSoLuong = new int[40];
        decimal[] MangGiaNhap = new decimal[40];
        int rowSP;
        public FrmNhapHang()
        {
            InitializeComponent();
            hoaDon = new BLLHoaDonNhap();
            cungCap =new BLLNhaCungCap() ;
            nhanVien = new BLLNhanVien();
            laptop = new BLLLaptop();
            chiTiet = new BLLChiTietHoaDonNhap();
            dbLoaiLaptop = new BLLLoaiLaptop();
        }
        public void LoadChiTiet()
        {
            //khởi tạo biến kiểm tra =false

            BienKiemTra.ThemSP = false;

            dtChiTiet = new DataTable();
            dtChiTiet.Clear();
            dtChiTiet.Columns.Add("Mã HĐ");
            dtChiTiet.Columns.Add("Mã LT");
            dtChiTiet.Columns.Add("Số Lượng");
            dtChiTiet.Columns.Add("Giá Nhập");

            // gridChiTiet.DataSource = dtChiTiet;
        }
        public void LoadSanPham()
        {
            try
            {
                dtLoaiLaptop = new DataTable();
                dtLoaiLaptop.Clear();
                dtLoaiLaptop = dbLoaiLaptop.LayLoaiLT().Tables[0];
                (dgvLaptop.Columns["Loai"] as
                   DataGridViewComboBoxColumn).DataSource = dtLoaiLaptop;
                (dgvLaptop.Columns["Loai"] as
                   DataGridViewComboBoxColumn).DisplayMember = "TenLoaiLT";
                (dgvLaptop.Columns["Loai"] as
                  DataGridViewComboBoxColumn).ValueMember = "MaLoaiLT";

                dtLaptop = new DataTable();
                dtLaptop.Clear();
                dtLaptop = laptop.LayLaptop().Tables[0];
                dgvLaptop.DataSource = dtLaptop;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table . Lỗi rồi!!!");
            }
        }
        public void LoadNhanVien()
        {
            try
            {
                //đổ dữ liệu vào datatable NhanVien
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                dtNhanVien = nhanVien.LayNhanVien().Tables[0];

                //đưa vào List
                List<NhanVien> NhanViens = new List<NhanVien>();
                foreach (DataRow p in dtNhanVien.Rows)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = int.Parse(p["MaNV"].ToString());
                    nv.HoTenDem = p["TenLot"].ToString();
                    nv.TenNV = p["TenNV"].ToString();
                    nv.Nu = (bool)p["GioiTinh"];
                    nv.SoDienThoai = p["SDT"].ToString();
                    //lưu NhanVien vào list
                    NhanViens.Add(nv);
                }
                //hiển thị lên combobox
                cbNhanVien.DataSource = NhanViens;
                cbNhanVien.DisplayMember = "TenNV";
                cbNhanVien.ValueMember = "MaNV";

            }
            catch
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadNhaCungCap()
        {
            try
            {
                //đổ dữ liệu vào datatable NhaCungCap
               dtCungCap = new DataTable();
               dtCungCap.Clear();
               dtCungCap = cungCap.LayNCC().Tables[0];

                //đưa vào List
                List<NhaCungCap> NhaCungCaps = new List<NhaCungCap>();
                foreach (DataRow p in dtCungCap.Rows)
                {
                    NhaCungCap kh = new NhaCungCap();
                    kh.MaNhaCungCap = int.Parse(p["MaNCC"].ToString());
                    kh.TenNhaCungCap = p["TenNCC"].ToString();
                    kh.SoDienThoai = p["SDT"].ToString();
                    kh.DiaChi = p["DiaChi"].ToString();
                    //lưu
                    NhaCungCaps.Add(kh);
                }
                //hiển thị lên combobox
                cbMaNoiCungCap.DataSource = NhaCungCaps;
                cbMaNoiCungCap.DisplayMember = "tenNhaCungCap";
                cbMaNoiCungCap.ValueMember = "maNhaCungCap";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void LoadData()
        {

            try
            {
                //đổ dữ liệu vào GridSanPham
                LoadSanPham();
                //đổ dữ liệu vào cbNhanVien
                LoadNhanVien();
                //đổ dữ liệu vào cbKhachHang
                LoadNhaCungCap();
                //chuẩn bị đổ dữ liệu vào gridChiTiet
                LoadChiTiet();
                //hoá đơn
                this.txtMaHD.ResetText();
                dtNgayLap.Value = DateTime.Now;
                dtNgayNhan.Value = DateTime.Now;
                //khách hàng
                this.cbMaNoiCungCap.ResetText();
                this.txtTenNoiCungCap.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                //nhân viên
                this.txtTenNV.ResetText();
                this.chkNu.Checked = false;
                this.txtSDTNV.ResetText();
                this.cbNhanVien.ResetText();
                //reset số lượng
                numSoLuong.Value = 1;
                //xoá bảng GridChiTiet
                dtChiTiet.Clear();
                LvChiTiet.Items.Clear();
                //reset lại BienKiemTra.ThemSP
                BienKiemTra.ThemSP = false;
                //xoá trống txtTongTien, giảm giá
                this.txtTongTien.ResetText();

            }
            catch
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tạo thể hiện
            NhanVien nv = (NhanVien)cbNhanVien.SelectedItem;
            txtTenNV.Text = nv.HoTenDem.ToString() + " " + nv.TenNV.ToString();
            bool temp = nv.Nu;
            if (temp == true)
            {
                chkNu.Checked = true;
            }
            else
            {
                chkNu.Checked = false;
            }
            txtSDTNV.Text = nv.SoDienThoai.ToString();
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {

            BienKiemTra.thanhToan = false;
            LoadData();
        }

        private void cbMaNoiCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tạo thể hiện của lớp KhachHAng
            NhaCungCap kh = (NhaCungCap)cbMaNoiCungCap.SelectedItem;
            txtTenNoiCungCap.Text = kh.TenNhaCungCap.ToString();
            txtDiaChi.Text = kh.DiaChi.ToString();
            txtSDT.Text = kh.SoDienThoai.ToString();
        }

        private void dtNgayNhan_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayLap.Value < dtNgayNhan.Value)
            {
                MessageBox.Show("Ngày Lấy Hàng Phải Trước Hoặc Trong Ngày Lập HD",
                    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNgayNhan.Value = dtNgayLap.Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            string MaHD = null;
            string MaSP = null;
            decimal GiaNhap = 0;
            int SoLuong = 0;
            if (txtMaHD.Text.Length == 0)
            {
                MessageBox.Show("Mã Không Được Để Trống!!", "Thông Báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(txtGiaNhap.Text.Length==0)
            {

                MessageBox.Show("Giá nhập không được Để Trống!!", "Thông Báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MaHD = txtMaHD.Text;
                    MaSP = dgvLaptop.Rows[rowSP].Cells[0].Value.ToString();

                    SoLuong = int.Parse(numSoLuong.Value.ToString());

                    GiaNhap = int.Parse(txtGiaNhap.Text);

                    ListViewItem item = new ListViewItem(MaHD);
                    item.SubItems.Add(MaSP);
                    item.SubItems.Add(SoLuong.ToString());
                    item.SubItems.Add(GiaNhap.ToString());

                    LvChiTiet.Items.Add(item);
                    MangMaHoaDon[LvChiTiet.Items.Count - 1] = int.Parse(MaHD);
                    MangMaSanPham[LvChiTiet.Items.Count - 1] = int.Parse(MaSP);
                    MangGiaNhap[LvChiTiet.Items.Count - 1] = GiaNhap;
                    MangSoLuong[LvChiTiet.Items.Count - 1] = SoLuong;
                  
                }
                catch { }
            }
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSP = dgvLaptop.CurrentCell.RowIndex;
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            try
            {
                TongTien = 0;// sẽ tính lại từ đầu
                for (int i = 0; i < LvChiTiet.Items.Count; i++)
                    TongTien += MangGiaNhap[i];//tính tiền từng dich vu


                txtTongTien.Text = TongTien.ToString();
            }
            catch { }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bool kiemtra;
            string err = "";
            try
            {

                bool fHoaDon;
                fHoaDon = hoaDon.ThemHoaDonNhap(ref err, int.Parse(txtMaHD.Text),
                         int.Parse(cbNhanVien.SelectedValue.ToString()), int.Parse(cbMaNoiCungCap.SelectedValue.ToString()),
                    DateTime.Parse(dtNgayLap.Text), DateTime.Parse(dtNgayNhan.Text),
                   decimal.Parse(txtTongTien.Text));
                if (fHoaDon == true)
                {
                    try
                    {

                        for (int i = 0; i < LvChiTiet.Items.Count; i++)
                        {
                            if (chiTiet.ThemChiTietHoaDonNhap(ref err, MangMaHoaDon[i], MangMaSanPham[i], MangSoLuong[i], MangGiaNhap[i]))
                            {
                                kiemtra = true;
                            }
                            else
                            {
                                kiemtra = false;
                                hoaDon.XoaHoaDonNhap(ref err, int.Parse(txtMaHD.Text));
                                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;

                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Khi Thêm Chi Tiết Hoá Đơn!!:");
                    }
                    DialogResult traLoi;
                    traLoi = MessageBox.Show("Đã Thêm Hoá Đơn Thành Công! Hãy Tạo Hoá Đơn Mới", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (traLoi == DialogResult.OK)
                    {
                        for (int i = 0; i < LvChiTiet.Items.Count; i++)
                        {
                            MangMaHoaDon[i] = 0;
                            MangMaSanPham[i] = 0;
                            MangGiaNhap[i] = 0;
                        }
                        LvChiTiet.Items.Clear();
                        TaoHoaDonMoi();
                        LoadSanPham();



                    }
                    else
                    {
                        MessageBox.Show("Error: '" + err + "'", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }

            catch
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin Trên Hoá Đơn", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void TaoHoaDonMoi()
        {
            //hoá đơn
            this.txtMaHD.ResetText();
            dtNgayLap.Value = DateTime.Now;
            dtNgayNhan.Value = DateTime.Now;
            //khách hàng
            this.cbMaNoiCungCap.ResetText();
            this.txtTenNoiCungCap.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            //nhân viên
            this.txtTenNV.ResetText();
            this.chkNu.Checked = false;
            this.txtSDTNV.ResetText();
            this.cbNhanVien.ResetText();
            //reset số lượng
            numSoLuong.Value = 1;
            //xoá bảng GridChiTiet
            dtChiTiet.Clear();
            LvChiTiet.Items.Clear();
            //reset lại BienKiemTra.ThemSP
            BienKiemTra.ThemSP = false;
            //xoá trống txtTongTien, giảm giá
            this.txtTongTien.ResetText();
            txtGiaNhap.ResetText();
            txtGiaNhap.Focus();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoHoaDonMoi();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = LvChiTiet.SelectedItems[0].Index; i < LvChiTiet.Items.Count - 1; i++)
                {
                    MangMaHoaDon[i] = MangMaHoaDon[i + 1];
                    MangMaSanPham[i] = MangMaSanPham[i + 1];
                    MangGiaNhap[i] = MangGiaNhap[i + 1];
                }

                LvChiTiet.Items.Remove(LvChiTiet.SelectedItems[0]);    // xóa item đã chọn     

            }
            catch
            {

            }
        }
    }
}
