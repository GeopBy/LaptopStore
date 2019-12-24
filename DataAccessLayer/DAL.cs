using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class DAL
    {
        //string strConnect = @"Data Source=DESKTOP-DL4CD8J\SQLEXPRESS;Initial Catalog=DBMS_CuaHangBanLaptop;Integrated Security=True";
        
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        public DAL()
        {
            FileStream fs = new FileStream("D:\\temp.dat", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Unicode);

            string a = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            string[] temp = a.Split('/');
            string server = temp[0];
            string user = temp[1];
          
            string strConnect;
            if (user != "\r\n")
            {
                string pass = temp[2];
                strConnect = "Server=" + server + ";Database=DBMS_CuaHangBanLaptop;User Id=" + user + ";Password = " + pass + "; ";
                conn = new SqlConnection(strConnect);
                cmd = conn.CreateCommand();
            }
            else
            {
               
                strConnect = "Server=" + server + ";Database=DBMS_CuaHangBanLaptop;Trusted_Connection=True;";
                conn = new SqlConnection(strConnect);
                cmd = conn.CreateCommand();
            }
          
         
        }
        public DataSet ExecuteQueryDataSet(string sqlString, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = sqlString;
            cmd.CommandType = ct;
            if (p != null)
            {
                foreach (SqlParameter i in p)
                    cmd.Parameters.Add(i);
            }

            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public int MyExecuteScalar(string sqlString, CommandType ct, ref string err, params SqlParameter[] p)
        {
            int temp = 0;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = sqlString;
            cmd.CommandType = ct;
            foreach (SqlParameter i in p)
            {
                cmd.Parameters.Add(i);
            }
            try
            {
                temp = (int)cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                err = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return temp;
        }
        public int CheckUserLogin(CommandType type,
                   string comdText)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            int result = -1;
            //
            cmd.CommandType = type;
            cmd.CommandText = comdText;
            try
            {
                // Aggregate Function
                result = (int)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {

            }
            finally
            {
                conn.Close();
            }
            //
            return result;
        }
    }
}
