using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTimKiemLaptop
    {
        DAL db = null;
        public BLLTimKiemLaptop()
        {
            db = new DAL();
        }
        public DataSet TimKiemLaptopTheoLoai(string tenLoai)
        {
            return db.ExecuteQueryDataSet("execute TimKiemLaptopTheoLoai '" + tenLoai + "'", CommandType.Text,
               null);

        }
        public DataSet TimKiemLaptopTheoTen(string ten)
        {
            return db.ExecuteQueryDataSet("execute TimKiemLaptopTheoTen '" + ten + "'", CommandType.Text,
               null);

        }

        public DataSet TimKiemLaptopTheoGia1()
        {
            return db.ExecuteQueryDataSet("LoadLaptopGia1", CommandType.StoredProcedure, null);
        }

        public DataSet TimKiemLaptopTheoGia2()
        {
            return db.ExecuteQueryDataSet("LoadLaptopGia2", CommandType.StoredProcedure, null);
        }
        public DataSet TimKiemLaptopTheoGia3()
        {
            return db.ExecuteQueryDataSet("LoadLaptopGia3", CommandType.StoredProcedure, null);
        }
        public DataSet TimKiemLaptopTheoGia4()
        {
            return db.ExecuteQueryDataSet("LoadLaptopGia4", CommandType.StoredProcedure, null);
        }
        public DataSet TimKiemLaptopTheoGia5()
        {
            return db.ExecuteQueryDataSet("LoadLaptopGia5", CommandType.StoredProcedure, null);
        }
    }
}
