﻿using System.Collections.Generic;

namespace Model
{
    public class MovieRegistrationService : IMovieRegistrationService
    {
        private readonly IMoviesRepository _repositoryMovies;
        private readonly ICategoriesRepository _repositoryCategories;
        private readonly IscreenshotsRepository _repositoryScreenshots;

        public MovieRegistrationService(IMoviesRepository repositoryMovies, ICategoriesRepository repositoryCategories, IscreenshotsRepository repositoryScreenshots)
        {
            _repositoryMovies = repositoryMovies;
            _repositoryCategories = repositoryCategories;
            _repositoryScreenshots = repositoryScreenshots;
        }

        public List<CategoryRecord> ReadCategories()
        {
            List<CategoryRecord> categories = new List<CategoryRecord>();

            categories = _repositoryCategories.ReadAllCategories();

            return categories;
        }

        public void Registrate(MovieRecord newMovie, MovieRecordExtended newMovieExtended, string screenshotPath)
        {
            _repositoryMovies.AddRecord(newMovie, newMovieExtended);
            _repositoryScreenshots.AddScreenshot(newMovie.MovieID, screenshotPath);
        }
    }
}
