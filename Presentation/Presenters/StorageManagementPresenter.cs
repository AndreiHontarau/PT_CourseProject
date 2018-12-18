using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            _view.AddMovie += (object sender, EventArgs e) => AddMovie();
            _view.DeleteMovie += (object sender, EventArgs e) => DeleteMovie();
            _view.AddCategory += (object sender, EventArgs e) => AddCategory();
            _view.Search += (object sender, EventArgs e) => Search();
            _view.Exit += (object sender, EventArgs e) => Exit();
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

        public override void Run()
        {
            _view.Show();
        }
    }
}
