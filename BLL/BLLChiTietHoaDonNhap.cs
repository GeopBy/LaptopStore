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
    public class BLLChiTietHoaDonNhap
    {
        DAL db = null;
        public BLLChiTietHoaDonNhap()
        {
            db = new DAL();
        }
        public DataSet LayChiTietHoaDonNhap()
        {
            return db.ExecuteQueryDataSet("execute LoadChiTietHoaDonNhap", CommandType.Text, null);
        }
        public DataSet LayChiTietHoaDonTheoMa(int maHD)
        {
            return db.ExecuteQueryDataSet("execute LayChiTietHoaDonNhapTheoMa '" + maHD + "'", CommandType.Text, null);
        }
        public bool ThemChiTietHoaDonNhap(ref string err, int maHoaDon, int MaLT, int soLuong, decimal giaNhap)
        {
            return db.MyExecuteNonQuery("ThemChiTietHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", maHoaDon),
                new SqlParameter("@MaLT", MaLT),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@GiaNhap", giaNhap));
        }
        public bool CapNhatChiTietHoaDonNhap(ref string err, int maHoaDon, int MaLT, int soLuong, decimal giaNhap)
        {
            return db.MyExecuteNonQuery("CapNhatChiTietHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", maHoaDon),
                new SqlParameter("@MaLT", MaLT),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@GiaNhap", giaNhap));
        }
        public bool XoaChiTietHoaDonNhap(ref string err, int maHoaDon, int MaLT)
        {
            return db.MyExecuteNonQuery("XoaChiTietHoaDonNhap", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDN", maHoaDon),
                new SqlParameter("@MaLT", MaLT));
        }
    }
}
