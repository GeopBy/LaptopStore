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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void lblGioiThieu_Click(object sender, EventArgs e)
        {

        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            lblGioiThieu.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG BÁN LAPTOP\nSinh viên thực hiện:\n Nguyễn Dương Văn Khoa\n Nguyễn Thị Yến Nhi";
        }
    }
}
