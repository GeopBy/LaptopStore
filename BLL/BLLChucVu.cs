using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLChucVu
    {
        DAL db = null;
        public BLLChucVu()
        {
            db = new DAL();
        }
        public DataSet LayChucVu()
        {
            return db.ExecuteQueryDataSet("select * from ChucVu", CommandType.Text, null);
        }
    }
}
