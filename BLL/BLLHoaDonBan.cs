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
    public class BLLHoaDonBan
    {
        DAL db = null;
        public BLLHoaDonBan()
        {
            db = new DAL();
        }
        public DataSet LayHoaDonBan()
        {
            return db.ExecuteQueryDataSet("execute LoadHoaDonBan", CommandType.Text, null);
        }
        public bool ThemHoaDonBan(ref string err, int maHoaDon, int maKH, int maNV, DateTime ngayLapHD, DateTime ngayLayHang,
            decimal TongTien)
        {
            return db.MyExecuteNonQuery("ThemHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", maHoaDon),
                 new SqlParameter("@MaKH", maKH),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@NgayLapHD", ngayLapHD),
                new SqlParameter("@NgayLayHang", ngayLayHang),
                new SqlParameter("@TongTien", TongTien));
        }
        public bool CapNhatHoaDonBan(ref string err, int maHoaDon, int maKH, int maNV, DateTime ngayLapHD, DateTime NgayLayHang,
           decimal TongTien)
        {
            return db.MyExecuteNonQuery("CapNhatHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", maHoaDon),
                 new SqlParameter("@MaKH", maKH),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@NgayLapHD", ngayLapHD),
                new SqlParameter("@NgayLayHang", NgayLayHang),
                new SqlParameter("@TongTien", TongTien));
        }
        public bool CapNhatGiaHoaDonBan(ref string err, int maHoaDon, decimal TongTien)
        {
            return db.MyExecuteNonQuery("CapNhatGiaHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", maHoaDon),
                new SqlParameter("@TongTien", TongTien));
        }
        public bool XoaHoaDonBan(ref string err, int maHoaDon)
        {
            return db.MyExecuteNonQuery("XoaHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", maHoaDon));
        }
        public int KiemTraTrungKhoa(ref string err, int maHoaDonBan)
        {
            return db.MyExecuteScalar("select dbo.KiemTraHoaDonBan('" + maHoaDonBan + "')", CommandType.Text, ref err,
                new SqlParameter("@MaHDB", maHoaDonBan));
        }
    }
}
