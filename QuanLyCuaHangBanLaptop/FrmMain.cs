using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLaptop
{
    public partial class FrmMain : Form
    {
       
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void loaiLaptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoaiLaptop frm = new FrmLoaiLaptop();
            frm.ShowDialog();
        }

        private void laptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLaptop frm = new FrmLaptop();
            frm.ShowDialog();
        }

        private void nhaCungCâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frm = new FrmNhaCungCap();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.ShowDialog();
        }

        private void chiTiêtHoaĐơnBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDonBan frm = new FrmChiTietHoaDonBan();
            frm.ShowDialog();
        }




        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang frm = new FormKhachHang();
            frm.ShowDialog();
        }

        private void kiêmTraHangTônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKiemTraHangTon frm = new FrmKiemTraHangTon();
            frm.ShowDialog();
        }

        private void traCưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraCuu frm = new FrmTraCuu();
            frm.ShowDialog();
        }

        private void hoaĐơnBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonBan frm = new FrmHoaDonBan();
            frm.ShowDialog();
        }

        private void hoaĐơnNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhap frm = new FrmHoaDonNhap();
            frm.ShowDialog();
        }

        private void frmBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanHang frm = new FrmBanHang();
            frm.ShowDialog();
        }

        private void nhâpHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhapHang frm = new FrmNhapHang();
            frm.ShowDialog();
        }

        private void thôngTinPhânMêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm=new FrmAbout();
            frm.ShowDialog();
        }

        private void traCưuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTraCuu();
            frm.ShowDialog();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmBanHang();
            frm.ShowDialog();
        }

        private void nhâpHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmNhapHang();
            frm.ShowDialog();
        }

        private void kiêmTraHangTônToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmKiemTraHangTon();
            frm.ShowDialog();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chiTiêtChưcVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmChiTietChucVu();
            frm.ShowDialog();
        }
    }
}
