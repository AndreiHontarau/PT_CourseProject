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

        public DBManager(string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Study\Programming\C#\VideoRental\Model\VideoRentalDB.mdf;Integrated Security=True")
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlReader = null;

            sqlConnection.Open();
        }
    }
}