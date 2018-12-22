using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
