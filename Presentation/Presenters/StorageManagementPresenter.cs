using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model;

namespace Presentation
{
    public class StorageManagementPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IStorageManagementView _view;
        private readonly IStorageManagementService _service;

        public StorageManagementPresenter(IKernel kernel, IStorageManagementView view, IStorageManagementService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.AddMovie += () => AddMovie();
            _view.DeleteMovie += () => DeleteMovie();
            _view.AddCategory += () => AddCategory();
            _view.Search += () => Search();
            _view.Exit += () => Exit();
        }

        private void AddMovie()
        {
            //FilmRegistration filmRegistration = new FilmRegistration();
            //filmRegistration.ShowDialog();
        }

        private void DeleteMovie()
        {
            //_view.DialogResult confirmation = MessageBox.Show("Are you sure?", "Confirm delete of %filmname%", MessageBoxButtons.YesNo);

            //if (confirmation == DialogResult.Yes)
            //{

            //}
            //else
            //{

            //}
        }

        private void AddCategory()
        {
            //CategoryRegistrationForm categoryRegistration = new CategoryRegistrationForm();
            //categoryRegistration.ShowDialog();
        }

        private void Search()
        {

        }

        private void Exit()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
