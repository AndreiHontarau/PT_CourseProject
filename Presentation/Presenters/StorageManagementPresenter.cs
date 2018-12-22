using System;
using System.Collections.Generic;
using Ninject;
using Model;

namespace Presentation
{
    public class StorageManagementPresenter : Presenter<IStorageManagementView>
    {
        private readonly IKernel _kernel;
        private readonly IStorageManagementView _view;
        private readonly IStorageManagementService _service;

        public StorageManagementPresenter(IKernel kernel, IStorageManagementView view, IStorageManagementService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.UpdateTable += (object sendr, EventArgs e) => LoadTable();
            _view.AddMovie += (object sender, EventArgs e) => AddMovie();
            _view.DeleteMovie += (object sender, string title) => DeleteMovie(title);
            _view.AddCategory += (object sender, EventArgs e) => AddCategory();
            _view.Search += (object sender, EventArgs e) => Search();
            _view.Exit += (object sender, EventArgs e) => Exit();
        }

        private void AddMovie()
        {
            _kernel.Get<MovieRegistrationPresenter>().Run();
            if (_service.CheckMovieRegistrationSuccess())
            {
                LoadLastMovie();
            }
        }

        private void LoadTable()
        {
            List<MovieRecord> movies = _service.LoadTable();

            foreach (MovieRecord movie in movies)
            {
                _view.DisplayRecord(movie);
            }
        }

        private void LoadLastMovie()
        {
            MovieRecord movie = _service.LoadLastMovie();
            _view.DisplayRecord(movie);
        }

        private void DeleteMovie(string movieID)
        {
            if (_service.DeleteMovie(movieID))
            {
                _view.ClearMovies();
            }
        }

        private void AddCategory()
        {
            _kernel.Get<CategoriesManagementPresenter>().Run();
        }

        private void Search()
        {

        }

        private void Exit()
        {
            _kernel.Get<LoginPresenter>().Run();
            _view.Close();
        }

        public override void Run()
        {
            _view.Show();
        }
    }
}
