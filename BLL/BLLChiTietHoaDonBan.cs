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
    public class BLLChiTietHoaDonBan
    {
        DAL db = null;
        public BLLChiTietHoaDonBan()
        {
            db = new DAL();
        }
        public DataSet LayChiTietHoaDonBan()
        {
            return db.ExecuteQueryDataSet("execute LoadChiTietHoaDonBan", CommandType.Text, null);
        }
        public DataSet LayChiTietHoaDonTheoMa(int maHD)
        {
            return db.ExecuteQueryDataSet("execute LayChiTietHoaDonBanTheoMa '" + maHD + "'", CommandType.Text, null);
        }
        public bool ThemChiTietHoaDonBan(ref string err, int maHoaDon, int MaLT, int soLuong, decimal giaBan)
        {
            return db.MyExecuteNonQuery("ThemChiTietHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", maHoaDon),
                new SqlParameter("@MaLT", MaLT),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@GiaBan", giaBan));
        }
        public bool CapNhatChiTietHoaDonBan(ref string err, int maHoaDon, int MaLT, int soLuong, decimal giaBan)
        {
            return db.MyExecuteNonQuery("CapNhatChiTietHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", maHoaDon),
                new SqlParameter("@MaLT", MaLT),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@GiaBan", giaBan));
        }
        public bool XoaChiTietHoaDonBan(ref string err, int maHoaDon, int MaLT)
        {
            return db.MyExecuteNonQuery("XoaChiTietHoaDonBan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHDB", maHoaDon),
                new SqlParameter("@MaLT", MaLT));
        }
    }
}
