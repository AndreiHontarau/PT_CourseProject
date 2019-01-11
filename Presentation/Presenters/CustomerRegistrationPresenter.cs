using System;
using Model;
using Ninject;

namespace Presentation
{
    public class CustomerRegistrationPresenter : Presenter<ICustomerRegistrationView>
    {
        private readonly IKernel _kernel;
        private readonly ICustomerRegistrationView _view;
        private readonly ICustomerRegistrationService _service;

        public CustomerRegistrationPresenter(IKernel kernel, ICustomerRegistrationView view, ICustomerRegistrationService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Registrate += (object sender, EventArgs e) => Registrate();

        }

        private void Registrate()
        {
            try
            {
                CustomerRecord newCustomerRecord = new CustomerRecord(_view.FirstName, _view.Surname, _view.Patronymic,
                    _view.Age, _view.Gender, _view.RegistrationDateTime);
                _service.Registrate(newCustomerRecord);
                _view.Close();
            }
            catch (FormatException e)
            {
                _view.ShowError("\"Age\" field contains invalid data");
            }
            catch (SqlDataWouldBeTruncatedException e)
            {
                    _view.ShowError("One of the field's value is too long.");
            }
        }

        override public void Run()
        {
            _view.Show();
        }
    }
}
