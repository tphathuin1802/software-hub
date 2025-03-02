using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SQLConnector
    {
        protected SqlConnection connection;
        protected string connectionString = "Server=THANHTRAN;database=CSDL_Lop10K;uid=sa;pwd=123456";
        public SQLConnector()
        {
            connection=new SqlConnection(connectionString);
        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection() 
        {
            if (connection.State == ConnectionState.Open) 
            { 
                connection.Close();
            }
        }
        public SqlDataReader Query(string sql)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public int NonQuery(string sql)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            int ret=command.ExecuteNonQuery();
            CloseConnection();
            return ret;//nếu ret>0 là thành công
        }
    }
}
