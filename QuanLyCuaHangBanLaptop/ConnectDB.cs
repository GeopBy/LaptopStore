using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanLaptop
{
    static class ConnectDB
    {
        public static SqlConnection sqlcon = new SqlConnection(QuanLyCuaHangBanLaptop.Properties.Settings.Default.strConnect);

        public static DataTable getData(string sql)
        {
            var dt = new DataTable();
            var da = new SqlDataAdapter(sql, sqlcon);
            sqlcon.Open();
            da.Fill(dt);
            sqlcon.Close();
            return dt;
        }

    }
}
