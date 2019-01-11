using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Model
{
    public class CategoriesDBManager : DBManager, ICategoriesRepository
    {
        public List<CategoryRecord> ReadAllCategories()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Categories]", sqlConnection);

            sqlReader = command.ExecuteReader();

            List<CategoryRecord> categoriesList = new List<CategoryRecord>();

            while (sqlReader.Read())
            {
                categoriesList.Add(new CategoryRecord(Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["symbolic_code"]),
                    Convert.ToInt16(sqlReader["amount_of_movies"])));
            }

            sqlReader.Close();

            return categoriesList;
        }

        public CategoryRecord LoadCategory(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Categories WHERE name = @Name", sqlConnection);

            command.Parameters.AddWithValue("Name", name);

            sqlReader = command.ExecuteReader();
            sqlReader.Read();

            CategoryRecord record = new CategoryRecord(Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["symbolic_code"]),
                Convert.ToInt16(sqlReader["amount_of_movies"]));

            sqlReader.Close();

            return record;
        }

        public CategoryRecord LoadLastCategory()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Categories ORDER BY Id DESC", sqlConnection);

            sqlReader = command.ExecuteReader();
            sqlReader.Read();

            CategoryRecord record = new CategoryRecord(Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["symbolic_code"]),
                Convert.ToInt16(sqlReader["amount_of_movies"]));

            sqlReader.Close();

            return record;
        }

        public void AddCategory(CategoryRecord newCategory)
        {
            SqlCommand insertCommand = new SqlCommand("INSERT INTO [Categories] (name, symbolic_code, amount_of_movies)" +
                                                "VALUES(@Name, @SymbolicCode, @AmountOfMovies)", sqlConnection);

            insertCommand.Parameters.AddWithValue("Name", newCategory.name);
            insertCommand.Parameters.AddWithValue("SymbolicCode", newCategory.symbolicCode);
            insertCommand.Parameters.AddWithValue("AmountOfMovies", newCategory.amountOfMovies);

            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                if(e.Message == SqlExceptionDataWouldBeTruncatedMessage)
                throw new SqlDataWouldBeTruncatedException();
            }
        }

        public void DeleteCategory(string name)
        {
            SqlCommand deleteCategory = new SqlCommand("DELETE FROM Categories WHERE name = @Name", sqlConnection);

            deleteCategory.Parameters.AddWithValue("Name", name);

            deleteCategory.ExecuteNonQuery();
        }

        public void RenameCategory(string categoryName, string newName, string newCode)
        {
            SqlCommand command = new SqlCommand("UPDATE Categories SET name = @NewName, symbolic_code = @NewCode WHERE name = @Name", sqlConnection);

            command.Parameters.AddWithValue("Name", categoryName);
            command.Parameters.AddWithValue("NewName", newName);
            command.Parameters.AddWithValue("NewCode", newCode);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                if (e.Message == SqlExceptionDataWouldBeTruncatedMessage)
                    throw new SqlDataWouldBeTruncatedException();
            }
        }

        public void IncreaseAmountOfMovies()
        {
            SqlCommand command = new SqlCommand("UPDATE Categories SET name = amount_of_movies + 1", sqlConnection);

            command.ExecuteNonQuery();
        }

        public int GetAmountOfCategories()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT (*) FROM Categories", sqlConnection);

            return (int)command.ExecuteScalar();
        }

        public bool CheckForPresence(string name)
        {
            bool IsPresent = false;

            SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM Categories WHERE name = @Name", sqlConnection);
            command.Parameters.AddWithValue("Name", name);
            IsPresent = (int)command.ExecuteScalar() == 0? false : true;

            return IsPresent;
        }
    }
}
