using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanLaptop
{
    public class BienKiemTra
    {
       
        public static int temp;
        //dùng cho việc xác định xem đó là Thêm hay Sửa trong SanPham
        public static bool Them;
        //dùng để tính tổng tiền nhập cho HoaDonNhap
        public static double tongTien = 0;
        //dùng để kiểm tra xem SanPham đó đã dc thêm vào HoaDonBan chưa
        public static bool ThemSP = false;
        //dùng để tính tổng tiền bán cho HoaDonBan
        public static double tongTienBan = 0;
        //biến kiểm tra chi tiết HD. Lấy toàn bộ hay theo mã
        public static bool theoMaHD;
        //biến này dùng để lấy MaHDBan
        public static int maHD;
        //dùng để tự động cập nhật lại hoá đơn
        public static bool tuDongCapNhat;
        //dùng cho việc tra cứu sản phẩm
        public static bool traCuu = false;
        //dùng để xác nhận xem đã nhấn nút ThanhToan chưa, trước khi có thể in hoá đơn
        public static bool thanhToan = false;
        //tạo biến dùng để lấy maHdBan, sử dụng trong việc xuất HoaDon
        public static string maHDDungDeXuat;

        //tạo biến dùng để lấy TenTaiKhoan sau mỗi lần đăng nhập
        public static string tenTaiKhoan;
        public static string matKhau;

        public static string userName;
        public static string pass;
    }
}
