using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanLaptop
{
    public class KhachHang
    {
        private int maKH;
        private string hoTenKH;
        private string diaChi;
        private string soDienThoai;
        public int MaKH
        {
            get { return maKH; }
            set { maKH = value;}
        }
        public string HoTenKH
        {
            get { return hoTenKH; }
            set
            {
                hoTenKH = value;
            }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SDT
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
    }
}
