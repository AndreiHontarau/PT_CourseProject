using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Model
{
    public class DBManager
    {
        protected SqlConnection sqlConnection;
        protected SqlDataReader sqlReader;

        public DBManager()
        {
            string connectionString = GetConnectionString();
            sqlConnection = new SqlConnection(connectionString);
            sqlReader = null;

            sqlConnection.Open();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["databaseLocation"].ConnectionString;
        }
    }
}