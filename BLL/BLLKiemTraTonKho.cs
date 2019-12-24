using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLKiemTraTonKho
    {
        DAL db = null;
        public BLLKiemTraTonKho()
        {
            db = new DAL();
        }
        public DataSet LaySanPhamTonKho()
        {
            return db.ExecuteQueryDataSet("LoadLaptopTonKho", CommandType.StoredProcedure, null);
        }
        public DataSet LaySanPhamBanHet()
        {
            return db.ExecuteQueryDataSet("LoadLaptopBanHet", CommandType.StoredProcedure, null);
        }
    }
}
