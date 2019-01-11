using System.Data.SqlClient;
using System.Configuration;

namespace Model
{
    public class DBManager
    {
        protected SqlConnection sqlConnection;
        protected SqlDataReader sqlReader;
        protected const string SqlExceptionDataWouldBeTruncatedMessage = "String or binary data would be truncated. The statement has been terminated.";

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