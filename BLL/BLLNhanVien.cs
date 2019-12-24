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
    public class BLLNhanVien
    {
        DAL db = null;
        public BLLNhanVien()
        {
            db = new DAL();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("execute LoadNhanVien", CommandType.Text, null);
        }
        public bool ThemNhanVien(ref string err, int maNV, string CMND, string HoNV, string TenLot, string TenNV, bool GioiTinh,
            DateTime NgaySinh, string DiaChi, decimal Luong, string SDT,byte[] Hinh)
        {
            return db.MyExecuteNonQuery("ThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@CMND", CMND),
                new SqlParameter("@HoNV", HoNV),
                new SqlParameter("@TenLot", TenLot),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Luong", Luong),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@Hinh", Hinh));
        }
        public bool CapNhatNhanVien(ref string err, int maNV, string CMND, 
            string HoNV, string TenLot,
            string TenNV, bool GioiTinh,
            DateTime NgaySinh, string DiaChi,
            decimal Luong, string SDT, byte[] Hinh)
        {
            return db.MyExecuteNonQuery("CapNhatNhanVien", CommandType.StoredProcedure, ref err,
                  new SqlParameter("@MaNV", maNV),
                  new SqlParameter("@CMND", CMND),
                  new SqlParameter("@HoNV", HoNV),
                  new SqlParameter("@TenLot", TenLot),
                  new SqlParameter("@TenNV", TenNV),
                  new SqlParameter("@GioiTinh", GioiTinh),
                  new SqlParameter("@NgaySinh", NgaySinh),
                  new SqlParameter("@DiaChi", DiaChi),
                  new SqlParameter("@Luong", Luong),
                  new SqlParameter("@SDT", SDT),
                  new SqlParameter("@Hinh", Hinh));
        }
        public bool XoaNhanVien(ref string err, int maNV)
        {
            return db.MyExecuteNonQuery("XoaNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", maNV));
        }
        public int KiemTraTrungKhoa(ref string err, int maNV)
        {

            return db.MyExecuteScalar("select dbo.KiemTraNhanVien ('" + maNV + "')", CommandType.Text, ref err,
                new SqlParameter("@MaNV", maNV));
        }
    }
}
