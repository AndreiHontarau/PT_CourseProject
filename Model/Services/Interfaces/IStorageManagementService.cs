using System.Collections.Generic;

namespace Model
{
    public interface IStorageManagementService
    {
        List<MovieRecord> LoadTable();
        MovieRecord LoadLastMovie();
        bool DeleteMovie(string userName);
        bool CheckForPresence(string userName);
        bool CheckMovieRegistrationSuccess();
    }
}
