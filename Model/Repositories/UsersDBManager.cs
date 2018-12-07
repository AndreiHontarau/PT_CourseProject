using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using  System.Data.SqlClient;
using static Model.UserTypeEnum;

namespace Model
{
    public class UsersDBManager : DBManager, IUsersRepository
    {
        public void AddRecord(UserRecord record)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Users] (user_name, password, type)VALUES(@Name, @Password, @Type)", sqlConnection);

            command.Parameters.AddWithValue("Name", record.UserName);
            command.Parameters.AddWithValue("Password", record.Password);
            command.Parameters.AddWithValue("Type", record.Type);

            command.ExecuteNonQuery();
        }

        public List<UserRecord> ReadAllUsers()
        {
            SqlCommand command = new SqlCommand("SELECT user_name, type FROM [Users]", sqlConnection);

            sqlReader = command.ExecuteReader();

            List<UserRecord> usersList = new List<UserRecord>();

            while (sqlReader.Read())
            {
                usersList.Add(new UserRecord(Convert.ToString(sqlReader["user_name"]), Convert.ToString(sqlReader["password"]),
                    (UserType)Convert.ToInt32(sqlReader["type"])));
            }

            return usersList;
        }

        public UserRecord ReadUser(string userName)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE user_name = '" + userName + "'", sqlConnection);
            sqlReader = command.ExecuteReader();
            sqlReader.Read();

            UserRecord record = new UserRecord(Convert.ToString(sqlReader["user_name"]), Convert.ToString(sqlReader["password"]),
                (UserType)Convert.ToInt32(sqlReader["type"]));

            sqlReader?.Close();

            return record;
        }
    }
}
