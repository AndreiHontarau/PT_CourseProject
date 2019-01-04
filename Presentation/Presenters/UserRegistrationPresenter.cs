using System;
using Model;
using Ninject;

namespace Presentation
{
    public class UserRegistrationPresenter : Presenter<IUserRegistrationView>
    {
        private readonly IKernel _kernel;
        private readonly IUserRegistrationView _view;
        private readonly IUserRegistrationService _service;

        public UserRegistrationPresenter(IKernel kernel, IUserRegistrationView view, IUserRegistrationService service)
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
                UserRecord newUser = new UserRecord(_view.userName, _view.password, _view.userRole);
                _service.Registrate(newUser);
                _view.Close();
            }
            catch (ArgumentNullException e)
            {
                _view.ShowError(e.Message);
            }
            catch(ArgumentException e)
            {
                _view.ShowError(e.Message);
            }
        }

        public override void Run()
        {
            _view.Show();
        }
    }
}
