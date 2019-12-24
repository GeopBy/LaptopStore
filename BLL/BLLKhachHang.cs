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
    public class BLLKhachHang
    {
        DAL db = null;
        public BLLKhachHang()
        {
            db = new DAL();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("execute LoadKhachHang", CommandType.Text, null);
        }
        public bool ThemKhachHang(ref string err, int maKH, string tenKH, string diaChi, string SDT, string ghiChu)
        {
            return db.MyExecuteNonQuery("ThemKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", maKH),
                new SqlParameter("@TenKH", tenKH),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@GhiChu", ghiChu));
        }
        public bool CapNhatKhachHang(ref string err, int maKH, string tenKH, string diaChi, string SDT, string ghiChu)
        {
            return db.MyExecuteNonQuery("CapNhatKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", maKH),
                new SqlParameter("@TenKH", tenKH),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@GhiChu", ghiChu));
        }
        public bool XoaKhachHang(ref string err, int maKH)
        {
            return db.MyExecuteNonQuery("XoaKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", maKH));
        }
        public int KiemTraTrungKhoa(ref string err, int maKH)
        {

            return db.MyExecuteScalar("select dbo.KiemTraKhachHang ('" + maKH + "')", CommandType.Text, ref err,
                new SqlParameter("@MaKH", maKH));
        }
        public DataSet TimKiemKhachHangTheoTen(string tenKH)
        {
            return db.ExecuteQueryDataSet("execute TimKiemKhachHangTheoTen N'" + tenKH + "'", CommandType.Text, null);
        }
    }
}
