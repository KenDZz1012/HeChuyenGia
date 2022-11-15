using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WindowsFormsApp1.DBConnect;
namespace WindowsFormsApp1.Controller
{
    public class QuestionController
    {
        Connect conn = new Connect();
        public QuestionController()
        {

        }
        public DataSet getAll(string table_name)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Questions";
                rs = conn.getData(sql, table_name, null);
                return rs;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataSet getById(string table_name, List<SqlParameter> data)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select top 1 from tbl_Questions where QuestionId = @Id";
                rs = conn.getData(sql, table_name, data);
                return rs;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
