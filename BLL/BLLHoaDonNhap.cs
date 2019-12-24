using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLHoaDonNhap
    {
        DAL db = null;
        public BLLHoaDonNhap()
        {
            db = new DAL();
        }
        public DataSet LayHoaDonNhap()
        {
            return db.ExecuteQueryDataSet("execute LoadHoaDonNhap", CommandType.Text, null);
        }
        public bool ThemHoaDonNhap(ref string err, int maHoaDon, int MaNV, int MaNCC, DateTime ngayLapHD, DateTime NgayNhanHang,
            decimal TongTien)
        {
            return db.MyExecuteNonQuery("ThemHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", maHoaDon),
                 new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@NgayLapHD", ngayLapHD),
                new SqlParameter("@NgayNhanHang", NgayNhanHang),
                new SqlParameter("@TongTien", TongTien));
        }
        public bool CapNhatHoaDonNhap(ref string err, int maHoaDon, int MaNV, int MaNCC, DateTime ngayLapHD, DateTime NgayNhanHang,
           decimal TongTien)
        {
            return db.MyExecuteNonQuery("CapNhatHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", maHoaDon),
                 new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@NgayLapHD", ngayLapHD),
                new SqlParameter("@NgayNhanHang", NgayNhanHang),
                new SqlParameter("@TongTien", TongTien));
        }
        public bool CapNhatGiaHoaDonNhap(ref string err, int maHoaDon, decimal TongTien)
        {
            return db.MyExecuteNonQuery("CapNhatGiaHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", maHoaDon),
                new SqlParameter("@TongTien", TongTien));
        }
        public bool XoaHoaDonNhap(ref string err, int maHoaDon)
        {
            return db.MyExecuteNonQuery("XoaHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", maHoaDon));
        }
        public int KiemTraTrungKhoa(ref string err, int maHoaDonNhap)
        {
            return db.MyExecuteScalar("select dbo.KiemTraHoaDonNhap('" + maHoaDonNhap + "')", CommandType.Text, ref err,
                new SqlParameter("@MaHDN", maHoaDonNhap));
        }
    }
}
