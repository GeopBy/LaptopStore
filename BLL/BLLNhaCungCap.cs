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
    public class BLLNhaCungCap
    {
        DAL db = null;
        public BLLNhaCungCap()
        {
            db = new DAL();
        }
        public DataSet LayNCC()
        {
            return db.ExecuteQueryDataSet("execute LoadNhaCungCap", CommandType.Text, null);
        }
        public bool ThemNCC(ref string err, int MaNCC, string TenNCC,string DiaChi,string SDT,string mail)
        {
            return db.MyExecuteNonQuery("ThemNCC", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@mail", mail));
        }
        public bool CapNhatNCC(ref string err, int MaNCC, string TenNCC, string DiaChi, string SDT, string mail)
        {
            return db.MyExecuteNonQuery("CapNhatNCC", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC),
                  new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@mail", mail));
        }
        public bool XoaNCC(ref string err, int MaNCC)
        {
            return db.MyExecuteNonQuery("XoaNCC", CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNCC", MaNCC));
        }
        public int KiemTraTrungKhoa(ref string err, int MaNCC)
        {
            return db.MyExecuteScalar("select dbo.KiemTraMaNCC('" + MaNCC + "')",
               CommandType.Text, ref err,
               new SqlParameter("@MaNCC", MaNCC));
        }
    }
}
