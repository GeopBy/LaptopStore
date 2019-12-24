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
   public class BLLDangNhap
    {
        DAL db;
        public BLLDangNhap()
        {
            db = new DAL();
        }
        public DataSet LayDangNhap(int ID)
        {
            return db.ExecuteQueryDataSet("select * from TaiKhoan where ID like '%" + ID + "%'", CommandType.Text);
        }
        public bool CheckUserExist(int ID, string matkhau)
        {
            bool f = false;
            string commandText = "Select Count(*) From TaiKhoan " +
                "Where ID='" + ID + "' and Pass='" + matkhau + "'";
            try
            {
                int result = db.CheckUserLogin(CommandType.Text,
                    commandText);
                if (result > 0)
                    f = true;
            }
            catch (SqlException)
            {
                f = false;
            }
            return f;
        }
    }
}
