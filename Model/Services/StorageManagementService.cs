using System.Collections.Generic;

namespace Model
{
    public class StorageManagementService : IStorageManagementService
    {
        private IMoviesRepository _moviesRepository;
        private ICategoriesRepository _categoriesRepository;
        private IscreenshotsRepository _screenshotsRepository;
        private int AmountOfMovies;

        public StorageManagementService(IMoviesRepository moviesRepository, ICategoriesRepository categoriesRepository, IscreenshotsRepository screenshotsRepository)
        {
            _moviesRepository = moviesRepository;
            _categoriesRepository = categoriesRepository;
            _screenshotsRepository = screenshotsRepository;
            AmountOfMovies = _moviesRepository.GetAmountOfMovies();
        }

        public List<MovieRecord> LoadTable()
        {
            return _moviesRepository.ReadAllMovies();
        }

        public MovieRecord LoadLastMovie()
        {
            return _moviesRepository.ReadLastMovie();
        }

        public MovieRecordExtended LoadFullMovieInfo(string movieID)
        {
            MovieRecordExtended movieRecordExtended = _moviesRepository.ReadMovieExtended(movieID);

            movieRecordExtended.ScreenshotPath = _screenshotsRepository.GetScreenshot(movieID);

            return movieRecordExtended;
        }

        public bool DeleteMovie(string movieID)
        {
            _screenshotsRepository.DeleteScreenshot(movieID);

            return _moviesRepository.DeleteMovie(movieID);
        }

        public bool CheckForPresence(string movieID)
        {
            return _moviesRepository.CheckForPresence(movieID);
        }

        public int GetAmountOfMovies()
        {
            return _moviesRepository.GetAmountOfMovies();
        }

        public bool CheckMovieRegistrationSuccess()
        {
            if (_moviesRepository.GetAmountOfMovies() == AmountOfMovies + 1)
            {
                AmountOfMovies++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
