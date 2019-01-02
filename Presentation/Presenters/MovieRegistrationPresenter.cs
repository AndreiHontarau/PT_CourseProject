using System;
using Model;
using Ninject;

namespace Presentation
{
    public class MovieRegistrationPresenter : Presenter<IMovieRegistrationView>
    {
        private readonly IKernel _kernel;
        private readonly IMovieRegistrationView _view;
        private readonly IMovieRegistrationService _service;

        public MovieRegistrationPresenter(IKernel kernel, IMovieRegistrationView view, IMovieRegistrationService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Registrate += (object sender, EventArgs e) => Registrate();
            _view.LoadCategories += (object sender, EventArgs e) => LoadCategories();
            _view.UploadImage += (object sender, EventArgs e) => UploadImage();
        }

        private void UploadImage()
        {
            
        }

        public void Registrate()
        {
            try
            {
                MovieRecord newMovie = new MovieRecord(_view.CategoryName, _view.Title, _view.YearOfProduction, _view.Producer, _view.Carrier, _view.AmountOfCopies);
                MovieRecordExtended newMovieExtended = new MovieRecordExtended(_view.ActorsList, _view.Country, _view.AgeRestriction, _view.Language, _view.Description);
                _service.Registrate(newMovie, newMovieExtended);
                _view.Close();
            }
            catch (ArgumentNullException e)
            {
                _view.ShowError(e.Message);
            }
            catch (ArgumentException e)
            {
                _view.ShowError(e.Message);
            }
        }

        public void LoadCategories()
        {
            _view.RecieveCategories(_service.ReadCategories());
        }

        override public void Run()
        {
            _view.Show();
        }
    }
}
