using System;
using System.Security.Authentication;
using Model;
using Ninject;
using static Model.UserTypeEnum;

namespace Presentation
{
    public class LoginPresenter : Presenter<ILoginView>
    {
        private readonly IKernel _kernel;
        private readonly ILoginView _view;
        private readonly ILoginService _service;

        public LoginPresenter(IKernel kernel, ILoginView view, ILoginService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Login += () => Login(_view.UserName, _view.Password);
        }

        /// <summary>
        /// Decides wich view to open next basing on login service's response
        /// </summary>
        /// <param name="UserName">User name</param>
        /// <param name="Password">Password</param>
        private void Login(string UserName, string Password)
        {
            try
            {
                if (_view.UserName == "" || _view.Password == "")
                {
                    throw new AuthenticationException("Wrong User name or Password");
                }

                switch (_service.Login(UserName, Password))
                {
                    case UserType.Admin:
                        _view.ShowError("Admin");
                        _kernel.Get<UsersManagementPresenter>().Run();
                        break;
                    case UserType.Manager:
                        _view.ShowError("Manager");
                        _kernel.Get<StorageManagementPresenter>().Run();
                        break;
                    case UserType.Receptionist:
                        _view.ShowError("Receptionist");
                        _kernel.Get<CustomersManagementPresenter>().Run();
                        break;
                    default:
                        break;
                }
            }
            catch (AuthenticationException e)
            {
                _view.ShowError(e.Message);
                return;
            }

            _view.Close();
        }

        public override void Run()
        {
            _view.Show();
        }
    }
}
