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
    public partial class FrmKiemTraHangTon : Form
    {
        BLLKiemTraTonKho TonKho = null;
        BLLLaptop dbLaptop = null;
        DataTable dtLaptop = null;
        public FrmKiemTraHangTon()
        {
            InitializeComponent();
            TonKho = new BLLKiemTraTonKho();
            dbLaptop = new BLLLaptop();
        }
        void LoadDataTon()
        {
            try
            {
                dtLaptop = new DataTable();
                dtLaptop.Clear();
                dtLaptop = TonKho.LaySanPhamTonKho().Tables[0];
                gridSanPham.DataSource = dtLaptop;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void LoadDataBanHet()
        {
            try
            {
                dtLaptop = new DataTable();
                dtLaptop.Clear();
                dtLaptop = TonKho.LaySanPhamBanHet().Tables[0];
                gridSanPham.DataSource = dtLaptop;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmKiemTraHangTon_Load(object sender, EventArgs e)
        {
            LoadDataTon();
        }

        private void btnBanHet_Click(object sender, EventArgs e)
        {
            btnTonKho.Enabled = true;
            btnBanHet.Enabled = false;

            LoadDataBanHet();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            LoadDataTon();
        }
    }
}
