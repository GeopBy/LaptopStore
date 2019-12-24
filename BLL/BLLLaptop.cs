using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer;
namespace BLL
{
    public class BLLLaptop
    {
        DAL db = null;
        public BLLLaptop()
        {
            db = new DAL();
        }
        public DataSet LayLaptop()
        {
            return db.ExecuteQueryDataSet("execute LoadLaptop", CommandType.Text, null);
        }
        public bool ThemLaptop(ref string err, int MaLT, string TenLT, int Loai, decimal DonGia,
            int soLuongCon, byte[] Hinh, string GhiChu)
        {
            return db.MyExecuteNonQuery("ThemLT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLT", MaLT),
                new SqlParameter("@TenLT", TenLT),
                new SqlParameter("@Loai", Loai),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@SoLuongCon", soLuongCon),
                new SqlParameter("@Hinh", Hinh),
                new SqlParameter("@GhiChu", GhiChu));
        }
        public bool CapNhatLaptop(ref string err, int MaLT, string TenLT, int Loai, decimal  DonGia,
           int soLuongCon,byte[] Hinh, string GhiChu)
        {
            return db.MyExecuteNonQuery("CapNhatLT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLT", MaLT),
                new SqlParameter("@TenLT", TenLT),
                new SqlParameter("@Loai", Loai),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@SoLuongCon", soLuongCon),
                new SqlParameter("@Hinh", Hinh),
                new SqlParameter("@GhiChu", GhiChu));
        }
        public bool XoaLaptop(ref string err, int maLT)
        {
            return db.MyExecuteNonQuery("XoaLT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLT", maLT));
        }
        public int KiemTraTrungKhoa(ref string err, int maLT)
        {
            return db.MyExecuteScalar("select dbo.KiemTraLT ('" + maLT + "')",
               CommandType.Text, ref err,
               new SqlParameter("@MaLT", maLT));
        }
        public bool CapNhatSoLuongTon(ref string err, int maLT, int soLuongCon)
        {
            return db.MyExecuteNonQuery("CapNhatSoLuongTon", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLT", maLT),
                new SqlParameter("@SoLuongCon", soLuongCon));
        }
        public int LaySoLuongTonTheoMa(ref string err, int maLT)
        {
            return db.MyExecuteScalar("select SoLuongCon from Laptop where MaLT='" + maLT + "'", CommandType.Text, ref err,
                new SqlParameter("@MaLT", maLT));
        }
        public decimal LayGiaLaptopTheoMa(ref string err,int maLT)
        {
            return db.MyExecuteScalar("select DonGia from Laptop where MaLT='" + maLT + "'", CommandType.Text, ref err,
                new SqlParameter("@MaLT", maLT));
        }
    }
}
