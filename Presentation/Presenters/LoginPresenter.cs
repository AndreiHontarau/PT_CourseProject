using System;
using System.Security.Authentication;
using Model;
using Ninject;
using static Model.UserRecord;

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

            _view.Login += (object sender, EventArgs e) => Login(_view.UserName, _view.Password);
        }

        /// <summary>
        /// Decides wich view to open next basing on LoginService's response
        /// </summary>
        /// <param name="UserName">User name</param>
        /// <param name="Password">Password</param>
        private void Login(string UserName, string Password)
        {
            try
            {
                switch (_service.Login(UserName, Password))
                {
                    case UserRole.Admin:
                        _kernel.Get<UsersManagementPresenter>().Run();
                        break;
                    case UserRole.Manager:
                        _kernel.Get<StorageManagementPresenter>().Run();
                        break;
                    case UserRole.Receptionist:
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
