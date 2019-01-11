using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Model
{
    public class CustomersDBManager : DBManager, ICustomersRepository
    {
        private const string datetimeformat = "yyyy-MM-dd HH:mm:ss";

        public void AddRecord(CustomerRecord record)
        {
            SqlCommand insertCustomer = new SqlCommand("INSERT INTO [Customers] (first_name, surname, patronymic, age, gender, number_of_rents, creation_date)" +
                                                "VALUES(@FirstName, @Surname, @Patronymic, @Age, @Gender, @NumberOfRents, @CreationDate)", sqlConnection);

            insertCustomer.Parameters.AddWithValue("FirstName", record.FirstName);
            insertCustomer.Parameters.AddWithValue("Surname", record.Surname);
            insertCustomer.Parameters.AddWithValue("Patronymic", record.Patronymic);
            insertCustomer.Parameters.AddWithValue("Age", record.Age);
            insertCustomer.Parameters.AddWithValue("Gender", record.Gender);
            insertCustomer.Parameters.AddWithValue("NumberOfRents", record.NumberOfRents);
            insertCustomer.Parameters.AddWithValue("CreationDate", record.RegistrationDateTime.ToString(datetimeformat));

            try
            {
                insertCustomer.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                if (e.Message == SqlExceptionDataWouldBeTruncatedMessage)
                    throw new SqlDataWouldBeTruncatedException();
            }
        }

        public List<CustomerRecord> ReadAllCustomers()
        {
            SqlCommand command = new SqlCommand("SELECT first_name, surname, patronymic, age, gender, number_of_rents, creation_date FROM [Customers]", sqlConnection);

            sqlReader = command.ExecuteReader();

            List<CustomerRecord> customersList = new List<CustomerRecord>();

            while (sqlReader.Read())
            {
                customersList.Add(new CustomerRecord(Convert.ToString(sqlReader["first_name"]), Convert.ToString(sqlReader["surname"]), Convert.ToString(sqlReader["patronymic"]),
                    Convert.ToInt16(sqlReader["age"]), Convert.ToBoolean(sqlReader["gender"]), Convert.ToDateTime(sqlReader["creation_date"]), Convert.ToInt16(sqlReader["number_of_rents"])));
            }

            sqlReader.Close();

            return customersList;
        }

        public CustomerRecord ReadLastCustomer()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Customers ORDER BY Id DESC", sqlConnection);

            sqlReader = command.ExecuteReader();
            sqlReader.Read();

            CustomerRecord record = new CustomerRecord(Convert.ToString(sqlReader["first_name"]), Convert.ToString(sqlReader["surname"]), Convert.ToString(sqlReader["patronymic"]),
            Convert.ToInt16(sqlReader["age"]), Convert.ToBoolean(sqlReader["gender"]), Convert.ToDateTime(sqlReader["creation_date"]), Convert.ToInt16(sqlReader["number_of_rents"]));

            sqlReader.Close();

            return record;
        }

        public bool DeleteCustomer(string firstName, string surname, string patronymic)
        {
            SqlCommand deleteCustomer = new SqlCommand("DELETE FROM Customers WHERE (first_name = @FirstName AND surname = @Surname AND patronymic = @Patronymic)", sqlConnection);

            deleteCustomer.Parameters.AddWithValue("FirstName", firstName);
            deleteCustomer.Parameters.AddWithValue("Surname", surname);
            deleteCustomer.Parameters.AddWithValue("Patronymic", patronymic);

            deleteCustomer.ExecuteNonQuery();

            return true;
        }

        public int GetAmountOfCustomers()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT (*) FROM Customers", sqlConnection);

            return (int)command.ExecuteScalar();
        }
    }
}
