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
    public class BLLChiTietChucVu
    {
        DAL db = null;
        public BLLChiTietChucVu()
        {
            db = new DAL();
        }
        public DataSet LayChiTietChucVu()
        {
            return db.ExecuteQueryDataSet("select * from ChiTietChucVu", CommandType.Text, null);
        }
        public bool XoaChiTietChucVu(ref string err, int maNV,int maCV)
        {
            return db.MyExecuteNonQuery("XoaChiTietChucVu", CommandType.StoredProcedure, ref err,
                new SqlParameter("@ID", maNV),new SqlParameter("@MaCV", maCV)
                 );
        }
    }
}
