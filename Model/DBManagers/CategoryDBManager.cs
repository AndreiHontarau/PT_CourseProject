using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model.DBManagers
{
    class CategoryDBManager : DBManager
    {
        public CategoryDBManager(string connectionString) : base(connectionString)
        {

        }

        public void AddCategory(Records.CategoryRecord newCategory)
        {
            SqlCommand insertCommand = new SqlCommand("INSERT INTO [Categories] (name, symbolic_code, amount_of_movies)" +
                                                "VALUES(@Name, @SymbolicCode, @AmountOfMovies)", this.sqlConnection);

            insertCommand.Parameters.AddWithValue("Name", newCategory.name);
            insertCommand.Parameters.AddWithValue("SymbolicCode", newCategory.symbolicCode);
            insertCommand.Parameters.AddWithValue("AmountOfMovies", newCategory.amountOfMovies);

            insertCommand.ExecuteNonQueryAsync();
        }
    }
}
