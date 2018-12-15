using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ninject;
using static Model.UserTypeEnum;

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

            _view.Registrate += () => Registrate();
        }

        private void Registrate()
        {
            try
            {
                UserRecord newUser = new UserRecord(_view.userName, _view.password, _view.userType);
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
