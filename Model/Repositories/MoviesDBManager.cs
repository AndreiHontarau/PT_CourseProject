using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Authentication;

namespace Model
{
    public class MoviesDBManager : DBManager, IMoviesRepository
    {
        public void AddRecord(MovieRecord movieRecord, MovieRecordExtended movieRecordExtended)
        {
            SqlCommand insertMovie = new SqlCommand("INSERT INTO [Movies] (category_id, title, producer, year, carrier, amount_of_copies)" +
                                                "VALUES(@CategoryID, @Title, @Producer, @Year, @Carrier, @AmountOfCopies)", sqlConnection);
            SqlCommand insertMovieExtended = new SqlCommand("INSERT INTO [MoviesExtended] (actors_list, country_made, age_restriction, language, annotation)" +
                                                 "VALUES(@ActorsList, @CountryMade, @AgeRestriction, @Language, @Annotation)", sqlConnection);

            insertMovie.Parameters.AddWithValue("CategoryID", movieRecord.CategoryID);
            insertMovie.Parameters.AddWithValue("Title", movieRecord.Title);
            insertMovie.Parameters.AddWithValue("Producer", movieRecord.Producer);
            insertMovie.Parameters.AddWithValue("Carrier", movieRecord.Carrier);
            insertMovie.Parameters.AddWithValue("AmountOfCopies", movieRecord.AmountOfCopies);

            insertMovieExtended.Parameters.AddWithValue("ActorsList", movieRecordExtended.ActorsList);
            insertMovieExtended.Parameters.AddWithValue("CountryMade", movieRecordExtended.CountryMade);
            insertMovieExtended.Parameters.AddWithValue("AgeRestriction", movieRecordExtended.AgeRestriction);
            insertMovieExtended.Parameters.AddWithValue("Language", movieRecordExtended.Language);
            insertMovieExtended.Parameters.AddWithValue("Annotation", movieRecordExtended.Annotation);

            insertMovie.ExecuteNonQuery();
            insertMovieExtended.ExecuteNonQuery();
        }

        public List<MovieRecord> ReadAllMovies()
        {
            SqlCommand command = new SqlCommand("SELECT movieID, category_id, title, year, producer, carrier, amount_of_copies FROM [Movies]", sqlConnection);

            sqlReader = command.ExecuteReader();

            List<MovieRecord> moviesList = new List<MovieRecord>();

            while (sqlReader.Read())
            {
                moviesList.Add(new MovieRecord(Convert.ToString(sqlReader["movieID"]), Convert.ToInt16(sqlReader["category_id"]), Convert.ToString(sqlReader["title"]),
                    Convert.ToInt16(sqlReader["year"]), Convert.ToString(sqlReader["producer"]), Convert.ToString(sqlReader["carrier"]), Convert.ToInt16(sqlReader["amount_of_copies"])));
            }

            sqlReader.Close();

            return moviesList;
        }

        public MovieRecord ReadMovie(string movieID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Movies WHERE movieID like @MovieID", sqlConnection);
            command.Parameters.AddWithValue("MovieID", movieID);

            sqlReader = command.ExecuteReader();
            if (!sqlReader.Read())
            {
                sqlReader.Close();
            }

            MovieRecord record = new MovieRecord(Convert.ToString(sqlReader["movieID"]), Convert.ToInt16(sqlReader["category_id"]), Convert.ToString(sqlReader["title"]),
                Convert.ToInt16(sqlReader["year"]), Convert.ToString(sqlReader["producer"]), Convert.ToString(sqlReader["carrier"]), Convert.ToInt16(sqlReader["amount_of_copies"]));

            sqlReader.Close();

            return record;
        }

        public MovieRecordExtended ReadMovieExtended(string movieID)
        {
            SqlCommand selectMovieExtendedID = new SqlCommand("SELECT extended_record_id FROM Movies WHERE movieID like @MovieID", sqlConnection);
            SqlCommand selectMovieExtended = new SqlCommand("SELECT * FROM MoviesExtended WHERE Id like @ID", sqlConnection);

            selectMovieExtendedID.Parameters.AddWithValue("MovieID", movieID);
            selectMovieExtended.Parameters.AddWithValue("ID", (int)selectMovieExtendedID.ExecuteScalar());

            sqlReader = selectMovieExtended.ExecuteReader();
            if (!sqlReader.Read())
            {
                sqlReader.Close();
            }

            MovieRecordExtended record = new MovieRecordExtended(Convert.ToString(sqlReader["actors_list"]), Convert.ToString(sqlReader["country_made"]),
                Convert.ToBoolean(sqlReader["age_restriction"]), Convert.ToString(sqlReader["language"]), Convert.ToString(sqlReader["annotation"]));

            sqlReader.Close();

            return record;
        }

        public bool CheckForPresence(string movieID)
        {
            bool IsPresent = false;

            SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM Movies WHERE movieID like @MovieID", sqlConnection);
            command.Parameters.AddWithValue("MovieID", movieID);
            IsPresent = (int)command.ExecuteScalar() == 0 ? false : true;

            return IsPresent;
        }

        public MovieRecord ReadLastMovie()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Movies ORDER BY Id DESC", sqlConnection);

            sqlReader = command.ExecuteReader();
            sqlReader.Read();

            MovieRecord record = new MovieRecord(Convert.ToString(sqlReader["movieID"]), Convert.ToInt16(sqlReader["category_id"]), Convert.ToString(sqlReader["title"]),
                Convert.ToInt16(sqlReader["year"]), Convert.ToString(sqlReader["producer"]), Convert.ToString(sqlReader["carrier"]), Convert.ToInt16(sqlReader["amount_of_copies"]));

            sqlReader.Close();

            return record;

        }

        public bool DeleteMovie(string movieID)
        {
            SqlCommand deleteMovie = new SqlCommand("DELETE FROM Movies WHERE movieID like @MovieID", sqlConnection);
            SqlCommand selectMovieExtendedID = new SqlCommand("SELECT extended_record_id FROM Movies WHERE movieID like @MovieID", sqlConnection);
            SqlCommand deleteMovieExtended = new SqlCommand("DELETE FROM MoviesExtended WHERE Id like @ID", sqlConnection);

            deleteMovie.Parameters.AddWithValue("MovieID", movieID);
            selectMovieExtendedID.Parameters.AddWithValue("MovieID", movieID);
            deleteMovieExtended.Parameters.AddWithValue("ID", (int)selectMovieExtendedID.ExecuteScalar());

            deleteMovie.ExecuteNonQuery();
            deleteMovieExtended.ExecuteNonQuery();

            return true;
        }

        public int GetAmountOfMovies()
        {
            SqlCommand command = new SqlCommand("SELECT COUNT (*) FROM Movies", sqlConnection);

            return (int)command.ExecuteScalar();
        }
    }
}
