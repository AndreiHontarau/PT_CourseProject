using System;
using System.Collections.Generic;
using  System.Data.SqlClient;
using System.Security.Authentication;

namespace Model
{
    public class UsersDBManager : DBManager, IUsersRepository
    {
        public void AddRecord(UserRecord record)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Users] (name, password, role)VALUES(@Name, @Password, @Role)", sqlConnection);

            command.Parameters.AddWithValue("Name", record.Name);
            command.Parameters.AddWithValue("Password", record.Password);
            command.Parameters.AddWithValue("Role", record.Role);

            command.ExecuteNonQuery();
        }

        public List<UserRecord> ReadAllUsers()
        {
            SqlCommand command = new SqlCommand("SELECT name, role FROM [Users]", sqlConnection);

            sqlReader = command.ExecuteReader();

            List<UserRecord> usersList = new List<UserRecord>();

            while (sqlReader.Read())
            {
                usersList.Add(new UserRecord(Convert.ToString(sqlReader["name"]), null,
                    (UserRecord.UserRole)Convert.ToInt32(sqlReader["role"])));
            }

            sqlReader.Close();

            return usersList;
        }

        public UserRecord ReadUser(string userName)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE name = '" + userName + "'", sqlConnection);
            sqlReader = command.ExecuteReader();
            if (!sqlReader.Read())
            {
                sqlReader.Close();
                throw new AuthenticationException("Wrong User name or Password");
            }

            UserRecord record = new UserRecord(Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["password"]),
                (UserRecord.UserRole)Convert.ToInt32(sqlReader["role"]));

            sqlReader.Close();

            return record;
        }

        public bool CheckForPresence(string userName)
        {
            bool IsPresent = false;

            SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM Users WHERE name = @Name", sqlConnection);
            command.Parameters.AddWithValue("Name", userName);
            IsPresent = (int)command.ExecuteScalar() == 0? false : true;

            return IsPresent;
        }

        public UserRecord ReadLastUser()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Users ORDER BY Id DESC", sqlConnection);

            sqlReader = command.ExecuteReader();
            sqlReader.Read();

            UserRecord record = new UserRecord(Convert.ToString(sqlReader["name"]), null,
                (UserRecord.UserRole)Convert.ToInt32(sqlReader["role"]));

            sqlReader.Close();

            return record;
        }

        public bool DeleteUser(string userName)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE name = @Name", sqlConnection);
            command.Parameters.AddWithValue("Name", userName);

            command.ExecuteNonQuery();

            return true;
        }

        public int GetAmountOfUsers()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT (*) FROM Users", sqlConnection);

            return (int)command.ExecuteScalar();
        }
    }
}
