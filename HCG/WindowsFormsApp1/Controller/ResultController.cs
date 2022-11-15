using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WindowsFormsApp1.DBConnect;   
namespace WindowsFormsApp1.Controller
{
    public class ResultController
    {
        Connect conn = new Connect();
        public ResultController()
        {

        }
        public DataSet getAll(string table_name)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Results";
                rs = conn.getData(sql, table_name, null);
                return rs;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
