using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Model;

namespace Presentation
{
    public class CustomersManagementPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICustomersManagementView _view;
        private readonly ICustomersManagementService _service;

        public CustomersManagementPresenter(IKernel kernel, ICustomersManagementView view, ICustomersManagementService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.RegistrateCustomer += () => RegistrateCustomer();
            _view.DeleteCustomer += () => DeleteCustomer();
            _view.ManageRents += () => ManageRents();
            _view.Search += () => Search();
            _view.Exit += () => Exit();
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

        public void Run()
        {
            _view.Show();
        }
    }
}
