using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model.DBManagers
{
    class DBManager
    {
        protected SqlConnection sqlConnection;
        protected SqlDataReader sqlReader;

        public DBManager(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlReader = null;
        }
    }
}