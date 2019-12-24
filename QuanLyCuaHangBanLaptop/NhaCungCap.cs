using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanLaptop
{
    public class NhaCungCap
    {
        private int maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChi;
        private string soDienThoai;
        private string mail;
        public int MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set
            {
                maNhaCungCap = value;
            }
        }
        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
    }
}
