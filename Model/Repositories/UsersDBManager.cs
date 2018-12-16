using System;
using System.Collections.Generic;
using  System.Data.SqlClient;
using static Model.UserTypeEnum;
using System.Security.Authentication;

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
                usersList.Add(new UserRecord(Convert.ToString(sqlReader["user_name"]), null,
                    (UserType)Convert.ToInt32(sqlReader["type"])));
            }

            sqlReader.Close();

            return usersList;
        }

        public UserRecord ReadUser(string userName)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE user_name = '" + userName + "'", sqlConnection);
            sqlReader = command.ExecuteReader();
            if (!sqlReader.Read())
            {
                sqlReader.Close();
                throw new AuthenticationException("Wrong User name or Password");
            }

            UserRecord record = new UserRecord(Convert.ToString(sqlReader["user_name"]), Convert.ToString(sqlReader["password"]),
                (UserType)Convert.ToInt32(sqlReader["type"]));

            sqlReader.Close();

            return record;
        }

        public bool CheckForPresence(string userName)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE user_name = '" + userName + "'", sqlConnection);
            sqlReader = command.ExecuteReader();

            bool IsPresent = (bool)sqlReader?.Read();

            sqlReader.Close();

            return IsPresent;
        }

        public UserRecord ReadLastUser()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Users ORDER BY Id DESC", sqlConnection);

            sqlReader = command.ExecuteReader();
            sqlReader.Read();

            UserRecord record = new UserRecord(Convert.ToString(sqlReader["user_name"]), null,
                (UserType)Convert.ToInt32(sqlReader["type"]));

            sqlReader.Close();

            return record;

        }

        public bool DeleteUser(string userName)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE user_name ='" + userName + "'", sqlConnection);

            command.ExecuteNonQuery();

            return true;
        }
    }
}
