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
using System.IO;

namespace QuanLyCuaHangBanLaptop
{
    public partial class FrmLaptop : Form
    {
        BLLLaptop dbLaptop = null;
        BLLLoaiLaptop dbLoaiLaptop = null;
        DataTable dtLaptop = null;
        DataTable dtLoaiLaptop = null;
        bool them;
       
        public FrmLaptop()
        {
            InitializeComponent();
            dbLaptop = new BLLLaptop();
            dbLoaiLaptop = new BLLLoaiLaptop();
        }
        void loadData()
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
                dtLaptop = dbLaptop.LayLaptop().Tables[0];
                dgvLaptop.DataSource = dtLaptop;

                this.txtMaLaptop.ResetText();
                this.txtTenLaptop.ResetText();
                this.cmbLoaiLT.ResetText();
                this.ptBoxHinhLaptop.ResetText();

                this.txtDonGia.ResetText();
                this.txtSoLuongCon.ResetText();
                this.txtxGhiChu.ResetText();

                this.pnlLT.Enabled = false;
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

        private void FrmLaptop_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

            int r = dgvLaptop.CurrentCell.RowIndex;
            this.txtMaLaptop.Text =
                dgvLaptop.Rows[r].Cells[0].Value.ToString();
            this.txtTenLaptop.Text =
                dgvLaptop.Rows[r].Cells[1].Value.ToString();
            this.cmbLoaiLT.Text =
                dgvLaptop.Rows[r].Cells[2].Value.ToString();
            this.cmbLoaiLT.DataSource = dtLoaiLaptop;
            this.cmbLoaiLT.DisplayMember = "TenLoaiLT";
            this.cmbLoaiLT.ValueMember = "MaLoaiLT";
            this.txtDonGia.Text =
                dgvLaptop.Rows[r].Cells[3].Value.ToString();
            this.txtSoLuongCon.Text =
                dgvLaptop.Rows[r].Cells[4].Value.ToString();
            
            var data = (Byte[])(dgvLaptop.Rows[r].Cells[5].Value);
            var stream = new MemoryStream(data);
            ptBoxHinhLaptop.Image = Image.FromStream(stream);
            this.txtxGhiChu.Text =
                dgvLaptop.Rows[r].Cells[6].Value.ToString();
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaLaptop.ResetText();
            this.txtTenLaptop.ResetText();
            this.cmbLoaiLT.ResetText();
            this.ptBoxHinhLaptop.ResetText();

            this.txtDonGia.ResetText();
            this.txtSoLuongCon.ResetText();
            this.txtxGhiChu.ResetText();

            this.pnlLT.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnThoat.Enabled = true;
            dgvLaptop_CellClick(null, null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them=true;
            this.txtMaLaptop.Enabled = true;
            this.pnlLT.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.btnSua.Enabled = false;
            this.txtMaLaptop.Focus();
          

            this.txtMaLaptop.ResetText();
            this.txtTenLaptop.ResetText();
            this.cmbLoaiLT.ResetText();
            this.ptBoxHinhLaptop.ResetText();

            this.txtDonGia.ResetText();
            this.txtSoLuongCon.ResetText();
            this.txtxGhiChu.ResetText();
            this.cmbLoaiLT.DataSource = dtLoaiLaptop;
            this.cmbLoaiLT.DisplayMember = "TenLoaiLT";
            this.cmbLoaiLT.ValueMember = "MaLoaiLT";
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "D:\\QuanLyCuaHangBanLaptop\\hinhLaptop";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptBoxHinhLaptop.Image = Image.FromStream(open.OpenFile());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            if (them)
            {
                if (txtMaLaptop.TextLength == 0)
                    MessageBox.Show("Mã Không Được Để Trống!!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        int temp = dbLaptop.KiemTraTrungKhoa(ref err, int.Parse(txtMaLaptop.Text));
                        if (temp != 0)
                        {
                            MessageBox.Show("Mã này đã trùng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            MemoryStream ms = new MemoryStream();
                            ptBoxHinhLaptop.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] byt = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(byt, 0, Convert.ToInt32(ms.Length));

                            //bool f = dbLaptop.ThemLaptop(ref err, int.Parse(txtMaLaptop.Text), txtTenLaptop.Text, int.Parse(cmbLoaiLT.Text)
                            //    , decimal.Parse(txtDonGia.Text),
                            //    int.Parse(txtSoLuongCon.Text), byt, txtxGhiChu.Text);
                            bool f = dbLaptop.ThemLaptop(ref err, int.Parse(txtMaLaptop.Text), txtTenLaptop.Text, 
                                int.Parse(cmbLoaiLT.SelectedValue.ToString())
                            , decimal.Parse(txtDonGia.Text),
                            int.Parse(txtSoLuongCon.Text), byt, txtxGhiChu.Text);
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
                    ptBoxHinhLaptop.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byt2 = new byte[ms2.Length];
                    ms2.Position = 0;
                    ms2.Read(byt2, 0, Convert.ToInt32(ms2.Length));
                    bool f = dbLaptop.CapNhatLaptop(ref err, int.Parse(txtMaLaptop.Text), txtTenLaptop.Text, int.Parse(cmbLoaiLT.SelectedValue.ToString()),
                        decimal.Parse(txtDonGia.Text),
                           int.Parse(txtSoLuongCon.Text), byt2,txtxGhiChu.Text);

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
                catch(SqlException)
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
                int r = dgvLaptop.CurrentCell.RowIndex;
                int intMaLaptop =int.Parse(dgvLaptop.Rows[r].Cells[0].Value.ToString());
                DialogResult traLoi;
                traLoi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string err = "";
                if (traLoi == DialogResult.Yes)
                {
                    bool f = dbLaptop.XoaLaptop(ref err, intMaLaptop);
                    if (f)
                    {
                        loadData();
                        MessageBox.Show("Đã xóa xong!");
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
            this.pnlLT.Enabled = true;
            int r = dgvLaptop.CurrentCell.RowIndex;
            this.txtMaLaptop.Text =
                dgvLaptop.Rows[r].Cells[0].Value.ToString();
            this.txtTenLaptop.Text =
                dgvLaptop.Rows[r].Cells[1].Value.ToString();
            this.cmbLoaiLT.Text =
                dgvLaptop.Rows[r].Cells[2].Value.ToString();
            this.txtDonGia.Text =
                dgvLaptop.Rows[r].Cells[3].Value.ToString();
            this.txtSoLuongCon.Text =
                dgvLaptop.Rows[r].Cells[4].Value.ToString();
            var data = (Byte[])(dgvLaptop.Rows[r].Cells[5].Value);
            var stream = new MemoryStream(data);
            ptBoxHinhLaptop.Image = Image.FromStream(stream);

            this.txtxGhiChu.Text =
                dgvLaptop.Rows[r].Cells[6].Value.ToString();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlLT.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            this.txtMaLaptop.Enabled = false;
           
        }
    }
}


