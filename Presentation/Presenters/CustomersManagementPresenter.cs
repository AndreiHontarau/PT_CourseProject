using System;
using Ninject;
using Model;

namespace Presentation
{
    public class CustomersManagementPresenter : Presenter<ICustomersManagementView>
    {
        private readonly IKernel _kernel;
        private readonly ICustomersManagementView _view;
        private readonly ICustomersManagementService _service;

        public CustomersManagementPresenter(IKernel kernel, ICustomersManagementView view, ICustomersManagementService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.RegistrateCustomer += (object sender, EventArgs e) => RegistrateCustomer();
            _view.DeleteCustomer += (object sender, EventArgs e) => DeleteCustomer();
            _view.ManageRents += (object sender, EventArgs e) => ManageRents();
            _view.Search += (object sender, EventArgs e) => Search();
            _view.Exit += (object sender, EventArgs e) => Exit();
        }

        private void RegistrateCustomer()
        {

        }

        private void DeleteCustomer()
        {

        }

        private void RegistrateCategory()
        {

        }

        private void ManageRents()
        {

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
