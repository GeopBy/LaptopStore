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
    public partial class FrmChiTietHoaDonBan : Form
    {
        BLLChiTietHoaDonBan chiTiet = null;
        BLLHoaDonBan hoaDon = null;
        BLLLaptop Laptop = null;
        DataTable dtChiTiet = null;
        DataTable dtHoaDon = null;
        DataTable dtLaptop = null;
        public string soLuong = "";
        public int soLuongCo = 0;
        bool Them;
        public FrmChiTietHoaDonBan()
        {
            InitializeComponent();
            chiTiet = new BLLChiTietHoaDonBan();
            hoaDon = new BLLHoaDonBan();
            Laptop = new BLLLaptop();
        }
        public void LoadHoaDon()
        {
            try
            {
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                dtHoaDon = hoaDon.LayHoaDonBan().Tables[0];
                cbMaHDB.DataSource = dtHoaDon;
                cbMaHDB.DisplayMember = "MaHDB";
                cbMaHDB.ValueMember = "MaHDB";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadLaptop()
        {
            try
            {
                dtLaptop = new DataTable();
                dtLaptop.Clear();
                dtLaptop = Laptop.LayLaptop().Tables[0];
                cbMaLT.DataSource = dtLaptop;
                cbMaLT.DisplayMember = "TenLT";
                cbMaLT.ValueMember = "MaLT";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadData()
        {
            pnlChiTiet.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            try
            {
                if (BienKiemTra.theoMaHD == false)
                {
                    dtChiTiet = new DataTable();
                    dtChiTiet.Clear();
                    dtChiTiet = chiTiet.LayChiTietHoaDonBan().Tables[0];
                    gridChiTiet.DataSource = dtChiTiet;
                }
                else
                {
                    dtChiTiet = new DataTable();
                    dtChiTiet.Clear();
                    dtChiTiet = chiTiet.LayChiTietHoaDonTheoMa(BienKiemTra.maHD).Tables[0];
                    gridChiTiet.DataSource = dtChiTiet;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!" + ex.Message, "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            BienKiemTra.tuDongCapNhat = true;
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.txtGiaBan.Enabled = false;
            LoadHoaDon();
            LoadLaptop();
            Them = false;
            this.pnlChiTiet.Enabled = true;
            int r = gridChiTiet.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.cbMaHDB.SelectedValue =
             gridChiTiet.Rows[r].Cells[0].Value.ToString();
            this.cbMaLT.SelectedValue =
            gridChiTiet.Rows[r].Cells[1].Value.ToString();

            this.txtGiaBan.Text =
            gridChiTiet.Rows[r].Cells[3].Value.ToString();
            this.txtSoLuong.Text = soLuong =
            gridChiTiet.Rows[r].Cells[2].Value.ToString();


            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlChiTiet.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 

            this.btnRefresh.Enabled = false;
            this.btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                bool f = chiTiet.CapNhatChiTietHoaDonBan(ref err, int.Parse(cbMaHDB.SelectedValue.ToString()), int.Parse(cbMaLT.SelectedValue.ToString()),
                    int.Parse(txtSoLuong.Text), decimal.Parse(txtGiaBan.Text));
                if (f == true)
                {
                    LoadData();
                    MessageBox.Show("Đã Cập Nhật Lại Chi Tiết Hoá Đơn!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cập nhật lại số lượng tồn
                    int soLuongTon = soLuongCo - int.Parse(txtSoLuong.Text);
                    bool fSanPham = Laptop.CapNhatSoLuongTon(ref err, int.Parse(cbMaLT.SelectedValue.ToString()), soLuongTon);
                    //cập nhật lại giá hoá đơn bán
                    int maHD = int.Parse(cbMaHDB.SelectedValue.ToString());
                    decimal s = 0;
                    foreach (DataRow i in dtChiTiet.Rows)
                    {
                        if (i["MaHDB"].Equals(maHD))
                        {
                            s = s + decimal.Parse(i["GiaBan"].ToString());

                        }
                    }

                    bool fHoaDon = hoaDon.CapNhatGiaHoaDonBan(ref err, maHD,s);
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
            this.btnSua.Enabled = true;
            this.btnRefresh.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlChiTiet.Enabled = false;
            this.btnSua.Enabled = true;
            this.btnRefresh.Enabled = true;
            this.btnLuu.Enabled = false;
        }
        public int KiemTraSoLuongTon(int MaLT, int soLuongMua, int soLuongBanDau)
        {

            string err = "";
            try
            {
                //gọi hàm lấy số lượng tồn theo mã
                soLuongCo = Laptop.LaySoLuongTonTheoMa(ref err, MaLT) + soLuongBanDau;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (soLuongCo < soLuongMua)
                return 1;
            return 0;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            bool flag;

            string str = txtSoLuong.Text;
            if (str.Length == 0)
                str = "0";
            int MaLT = int.Parse(cbMaLT.SelectedValue.ToString());
            int soLuongHienTai = int.Parse(str);
            int temp = KiemTraSoLuongTon(MaLT, soLuongHienTai, int.Parse(soLuong));
            if (temp == 1)
            {
                //false nếu số luong mua lớn hơn số lượng tồn
                flag = false;

            }
            else
            {
                //true nếu ngược lại
                flag = true;

            }

            if (flag == false)
            {
                MessageBox.Show("Số Lượng Mua Không Được Lớn Hơn Số Lượng Tồn", "Thông Báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FrmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
