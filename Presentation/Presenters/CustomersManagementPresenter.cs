using System;
using System.Collections.Generic;
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

            _view.UpdateTable += (object sender, EventArgs e) => LoadTable();
            _view.RegistrateCustomer += (object sender, EventArgs e) => RegistrateCustomer();
            _view.DeleteCustomer += (object sender, NameSurnamePatronymic e) => DeleteCustomer(e);
            _view.ManageRents += (object sender, NameSurnamePatronymic e) => ManageRents(e);
            _view.Search += (object sender, EventArgs e) => Search();
            _view.Exit += (object sender, EventArgs e) => Exit();
        }

        private void RegistrateCustomer()
        {
            _kernel.Get<CustomerRegistrationPresenter>().Run();
            if (_service.CheckMovieRegistrationSuccess())
            {
                _view.SetAmountOfCustomers(_service.GetAmountOfCustomers());
                LoadLastCustomer();
            }
        }

        private void LoadTable()
        {
            List<CustomerRecord> customers = _service.LoadTable();

            foreach (CustomerRecord customer in customers)
            {
                _view.DisplayRecord(customer);
            }

            _view.SetAmountOfMovies(_service.GetAmountOfMovies());
            _view.SetAmountOfCustomers(_service.GetAmountOfCustomers());
        }

        private void LoadLastCustomer()
        {
            CustomerRecord customer = _service.LoadLastCustomer();
            _view.DisplayRecord(customer);
        }

        private void DeleteCustomer(NameSurnamePatronymic args)
        {
            if (_service.DeleteCustomer(args.FirstName, args.Surname, args.Patronymic))
            {
                _view.ClearCustomers();
            }

            _view.SetAmountOfCustomers(_service.GetAmountOfCustomers());
        }

        private void ManageRents(NameSurnamePatronymic args)
        {

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
