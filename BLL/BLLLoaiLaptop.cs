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
    public class BLLLoaiLaptop
    {
        DAL db = null;
        public BLLLoaiLaptop()
        {
            db = new DAL();
        }
        public DataSet LayLoaiLT()
        {
            return db.ExecuteQueryDataSet("execute LoadLoaiLaptop", CommandType.Text, null);
        }
        public bool ThemLoaiLT(ref string err, int maLoai, string tenLoai)
        {
            return db.MyExecuteNonQuery("ThemLoaiLT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiLT", maLoai),
                new SqlParameter("@TenLoaiLT", tenLoai));
        }
        public bool CapNhatLoaiLT(ref string err, int maLoai, string tenLoai)
        {
            return db.MyExecuteNonQuery("CapNhatLoaiLT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiLT", maLoai),
                new SqlParameter("@TenLoaiLT", tenLoai));
        }
        public bool XoaLoaiLT(ref string err, int maLoai)
        {
            return db.MyExecuteNonQuery("XoaLoaiLT", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaLoaiLT", maLoai));
        }
        public int KiemTraTrungKhoa(ref string err, int MaLoaiLT)
        {
            return db.MyExecuteScalar("select dbo.KiemTraMaLoaiLT('" +MaLoaiLT+ "')",
               CommandType.Text, ref err,
               new SqlParameter("@MaLoaiLT",MaLoaiLT));
        }
    }
}
