using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WindowsFormsApp1.DBConnect
{
    public class Connect
    {
        String conn_str = @"Data Source=KENDZ\SQLEXPRESS;Initial Catalog=HCG;User ID=sa; Password = 123456";
        SqlConnection conn = null;

        public Connect()
        {
            conn = new SqlConnection(conn_str);
        }
        public int CountData(String sql, List<SqlParameter> data)
        {
            int rs = 0;
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(conn_str);
                }
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (data != null)
                {
                    cmd.Parameters.AddRange(data.ToArray());
                }
                rs = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rs;
        }

        public DataSet getData(String sql, string table_name, List<SqlParameter> data)
        {
            if (conn == null)
            {
                conn = new SqlConnection(conn_str);
            }
            DataSet rs = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                if (data != null)
                {
                    da.SelectCommand.Parameters.AddRange(data.ToArray());
                }
                da.Fill(rs, table_name);
            }
            catch (Exception ex)
            {
                throw;
            }

            return rs;
        }
    }
}
