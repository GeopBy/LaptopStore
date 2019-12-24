using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLaptop
{
    public partial class FrmKetNoi : Form
    {
        public FrmKetNoi()
        {
            InitializeComponent();
        }

        private void FrmKetNoi_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            cbServer.DataSource = table;
            cbServer.DisplayMember = "ServerName";
        }

        private void chkXacThuc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXacThuc.Checked == true)
            {
                txtTenDangNhap.Enabled = true;
                txtMatKhau.Enabled = true;
            }
            else
            {
                txtTenDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string strConnect = "";
            if (!chkXacThuc.Checked)
                strConnect = "Server=" + cbServer.Text + ";Database=DBMS_CuaHangBanLaptop;Trusted_Connection=True;";
            else
                strConnect = "Server=" + cbServer.Text + ";Database=DBMS_CuaHangBanLaptop;User Id=" + txtTenDangNhap.Text + ";Password = " + txtMatKhau.Text + "; ";
            SqlConnection sqlcon = new SqlConnection(strConnect);
            try
            {
                sqlcon.Open();
                QuanLyCuaHangBanLaptop.Properties.Settings.Default.strConnect= strConnect;
                QuanLyCuaHangBanLaptop.Properties.Settings.Default.Save();
                
               
                ConnectDB.sqlcon.Open();
                ConnectDB.sqlcon.Close();
                FileStream fs = new FileStream("D:\\temp.dat", FileMode.Create);//Tạo file mới tên là test.txt            
                StreamWriter wt = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 

                // Ghi và đóng file
                if (!chkXacThuc.Checked)
                {
                    wt.WriteLine(cbServer.Text.Trim() + "/");
                }
                else
                {
                    wt.WriteLine(cbServer.Text.Trim() + "/" + txtTenDangNhap.Text.Trim() + "/" + txtMatKhau.Text.Trim() + "/");
                   
                }
                wt.Flush();
                wt.Close();
                fs.Close();
                MessageBox.Show("Kết nối thành công");
                Form Frm = new FrmLogin();
                Frm.ShowDialog();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối không thành công, xin kiểm tra lại!");
                sqlcon.Close();
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
