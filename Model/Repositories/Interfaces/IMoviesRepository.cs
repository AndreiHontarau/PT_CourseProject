using System.Collections.Generic;

namespace Model
{
    public interface IMoviesRepository
    {
        void AddRecord(MovieRecord record, MovieRecordExtended movieRecordExtended);
        List<MovieRecord> ReadAllMovies();
        MovieRecord ReadMovie(string movieID);
        MovieRecordExtended ReadMovieExtended(string movieID);
        MovieRecord ReadLastMovie();
        bool CheckForPresence(string movieID);
        bool DeleteMovie(string movieID);
        int GetAmountOfMovies();
    }
}
