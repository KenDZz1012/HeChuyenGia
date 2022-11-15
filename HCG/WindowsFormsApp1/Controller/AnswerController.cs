using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WindowsFormsApp1.DBConnect;

namespace WindowsFormsApp1.Controller
{
    public class AnswerController
    {
        Connect conn = new Connect();
        public AnswerController()
        {

        }
        public DataSet getAll(string table_name)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Answers";
                rs = conn.getData(sql, table_name, null);
                return rs;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataSet getByQuestionId(string table_name, List<SqlParameter> data)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Answers where CurrentQuestion = @Id";
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
