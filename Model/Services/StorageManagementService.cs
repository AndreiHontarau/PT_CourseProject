using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StorageManagementService : IStorageManagementService
    {
        private IMoviesRepository _moviesRepository;
        private ICategoriesRepository _categoriesRepository;
        private int AmountOfMovies;
        private int AmountOfCategories;

        public StorageManagementService(IMoviesRepository moviesRepository, ICategoriesRepository categoriesRepository)
        {
            _moviesRepository = moviesRepository;
            _categoriesRepository = categoriesRepository;
            AmountOfMovies = _moviesRepository.GetAmountOfMovies();
            AmountOfCategories = _categoriesRepository.GetAmountOfCategories();
        }

        public List<MovieRecord> LoadTable()
        {
            return _moviesRepository.ReadAllMovies();
        }

        public MovieRecord LoadLastMovie()
        {
            return _moviesRepository.ReadLastMovie();
        }

        public bool DeleteMovie(string movieID)
        {
            return _moviesRepository.DeleteMovie(movieID);
        }

        public bool CheckForPresence(string movieID)
        {
            return _moviesRepository.CheckForPresence(movieID);
        }

        private int GetAmountOfMovies()
        {
            return _moviesRepository.GetAmountOfMovies();
        }

        private int GetAmountOfCategories()
        {
            return _categoriesRepository.GetAmountOfCategories();
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


        public bool CheckCategoryRegistrationSuccess()
        {
            if (_categoriesRepository.GetAmountOfCategories() == AmountOfCategories + 1)
            {
                AmountOfCategories++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
