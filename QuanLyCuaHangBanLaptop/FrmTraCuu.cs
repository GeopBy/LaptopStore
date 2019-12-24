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
    public partial class FrmTraCuu : Form
    {
        BLLTimKiemLaptop find = null;
        BLLLaptop dbLaptop = null;
        BLLLoaiLaptop dbLoaiLaptop = null;

        DataTable dtLaptop = null;
        DataTable dtLoaiLaptop = null;
        private object gridSanPham;

        public FrmTraCuu()
        {
            InitializeComponent();
            find = new BLLTimKiemLaptop();
            dbLaptop = new BLLLaptop();
            dbLoaiLaptop = new BLLLoaiLaptop();
        }
        void LoadData()
        {
            dtLoaiLaptop = new DataTable();
            dtLoaiLaptop.Clear();
            dtLoaiLaptop = dbLoaiLaptop.LayLoaiLT().Tables[0];
            cmbLoaiLT.Enabled = false;
            txtTen.Enabled = false;
            groupGia.Enabled = false;
            cmbLoaiLT.DataSource = dtLoaiLaptop;
            cmbLoaiLT.DisplayMember = "TenLoaiLT";
            cmbLoaiLT.ValueMember = "MaLoaiLT";
        }
        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmTraCuu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
        }

        private void radLoai_CheckedChanged(object sender, EventArgs e)
        {
            cmbLoaiLT.Enabled = true;
           
            groupGia.Enabled = false;
            BienKiemTra.temp = 0;
        }

        private void radTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            groupGia.Enabled = false;
            BienKiemTra.temp = 1;
        }

        private void radMucGia_CheckedChanged(object sender, EventArgs e)
        {

            groupGia.Enabled = true;
            BienKiemTra.temp = 2;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            cmbLoaiLT.ResetText();
            txtTen.ResetText();
            rad1.Checked = false;
            rad2.Checked = false;
            rad3.Checked = false;
            rad4.Checked = false;
            rad5.Checked = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtLoaiLaptop = new DataTable();
            dtLoaiLaptop.Clear();
            dtLoaiLaptop = dbLoaiLaptop.LayLoaiLT().Tables[0];
            (dgv.Columns["Loai"] as
               DataGridViewComboBoxColumn).DataSource = dtLoaiLaptop;
            (dgv.Columns["Loai"] as
               DataGridViewComboBoxColumn).DisplayMember = "TenLoaiLT";
            (dgv.Columns["Loai"] as
              DataGridViewComboBoxColumn).ValueMember = "MaLoaiLT";
            string err = "";
            if (BienKiemTra.temp == 0)
            {
                try
                {
                   

                    dtLaptop = new DataTable();
                    dtLaptop.Clear();
                    dtLaptop = find.TimKiemLaptopTheoLoai(cmbLoaiLT.Text).Tables[0];
                    dgv.DataSource = dtLaptop;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (BienKiemTra.temp == 1)
            {
                try
                {
                  

                    dtLaptop = new DataTable();
                    dtLaptop.Clear();
                    dtLaptop = find.TimKiemLaptopTheoTen(txtTen.Text).Tables[0];
                    dgv.DataSource = dtLaptop;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (BienKiemTra.temp == 2)
            {
                if (rad1.Checked == true)
                {

                    try
                    {


                        dtLaptop = new DataTable();
                        dtLaptop.Clear();
                        dtLaptop = find.TimKiemLaptopTheoGia1().Tables[0];
                        dgv.DataSource = dtLaptop;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                if (rad2.Checked == true)
                {

                    try
                    {


                        dtLaptop = new DataTable();
                        dtLaptop.Clear();
                        dtLaptop = find.TimKiemLaptopTheoGia2().Tables[0];
                        dgv.DataSource = dtLaptop;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else

                if (rad3.Checked == true)
                {

                    try
                    {


                        dtLaptop = new DataTable();
                        dtLaptop.Clear();
                        dtLaptop = find.TimKiemLaptopTheoGia3().Tables[0];
                        dgv.DataSource = dtLaptop;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else

                if (rad4.Checked == true)
                {

                    try
                    {


                        dtLaptop = new DataTable();
                        dtLaptop.Clear();
                        dtLaptop = find.TimKiemLaptopTheoGia4().Tables[0];
                        dgv.DataSource = dtLaptop;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }else

                if (rad5.Checked == true)
                {

                    try
                    {


                        dtLaptop = new DataTable();
                        dtLaptop.Clear();
                        dtLaptop = find.TimKiemLaptopTheoGia5().Tables[0];
                        dgv.DataSource = dtLaptop;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không Lấy Được Dữ Liệu!!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
