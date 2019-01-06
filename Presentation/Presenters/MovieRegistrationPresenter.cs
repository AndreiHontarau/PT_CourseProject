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
        }

        public void Registrate()
        {
            try
            {
                MovieRecord newMovie = new MovieRecord(_view.CategoryName, _view.Title, _view.YearOfProduction, _view.Producer, _view.Carrier, _view.AmountOfCopies);
                MovieRecordExtended newMovieExtended = new MovieRecordExtended(_view.ActorsList, _view.Country, _view.AgeRestriction, _view.Language, _view.Description, _view.PreviousMovieID);
                _service.Registrate(newMovie, newMovieExtended, _view.ScreenshotPath);
                _view.Close();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                if (e.Message == SqlExceptionDataWouldBeTruncatedMessage)
                {
                    _view.ShowError("One of the field's value is too long.");
                }
                else
                {
                    throw e;
                }
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
