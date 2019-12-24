using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BLL;

namespace QuanLyCuaHangBanLaptop
{
    public partial class FrmLogin : Form
    {
        BLLDangNhap db = new BLLDangNhap();
         DataSet ds = new DataSet();
        
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Form frm = new FrmMain();
            if (db.CheckUserExist(int.Parse(txtTenDangNhap.Text), txtMatKhau.Text) == true)
            {
                MessageBox.Show("Dang nhap thanh cong", "Ket qua", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                frm.ShowDialog();
                this.Close();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Dang nhap khong thanh cong", "Ket qua", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.ResetText();
                txtMatKhau.ResetText();
                txtTenDangNhap.Focus();
            }

        }
    }
}
