using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class DataAccess
    {
        private SqlConnection con;

        private bool isConnected = false;
        public bool IsConnected { get => isConnected; }

        public void ConnectToDB(string serverName, string databaseName)
        {
            using (con = new SqlConnection())
            {
                con.ConnectionString = "server=" + serverName + "; database=" + databaseName + "; Integrated Security=True";
                con.Open();
                isConnected = true;
            }
        }

        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public SqlDataReader ExecuteSQLCommand(SqlCommand sqlCommand)
        {
            try
            {
                sqlCommand.Connection = con;
                return sqlCommand.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
