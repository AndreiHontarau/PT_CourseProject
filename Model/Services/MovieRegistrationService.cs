using System.Collections.Generic;

namespace Model
{
    public class MovieRegistrationService : IMovieRegistrationService
    {
        private IMoviesRepository _repositoryMovies;
        private ICategoriesRepository _repositoryCategories;
        private IscreenshotsRepository _screenshotsRepository;

        public MovieRegistrationService(IMoviesRepository repositoryMovies, ICategoriesRepository repositoryCategories, IscreenshotsRepository screenshotsRepository)
        {
            _repositoryMovies = repositoryMovies;
            _repositoryCategories = repositoryCategories;
            _screenshotsRepository = screenshotsRepository;
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
