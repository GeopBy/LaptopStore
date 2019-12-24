using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanLaptop
{
    public class NhanVien
    {
        private int maNV;
        private string hoTenDem;
        private string tenNV;
        private bool nu;
        private string soDienThoai;
        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoTenDem
        {
            get { return hoTenDem; }
            set { hoTenDem = value; }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public bool Nu
        {
            get { return nu; }
            set { nu = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
    }

}
