using System.Collections.Generic;

namespace Model
{
    public class MovieRegistrationService : IMovieRegistrationService
    {
        private IMoviesRepository _repositoryMovies;
        private ICategoriesRepository _repositoryCategories;

        public MovieRegistrationService(IMoviesRepository repositoryMovies, ICategoriesRepository repositoryCategories)
        {
            _repositoryMovies = repositoryMovies;
            _repositoryCategories = repositoryCategories;
        }

        public List<CategoryRecord> ReadCategories()
        {
            List<CategoryRecord> categories = new List<CategoryRecord>();

            categories = _repositoryCategories.ReadAllCategories();

            return categories;
        }

        public void Registrate(MovieRecord newMovie, MovieRecordExtended newMovieExtended)
        {
            _repositoryMovies.AddRecord(newMovie, newMovieExtended);
        }
    }
}
