using System;
using Model;
using Ninject;
using static Model.UserTypeEnum;

namespace Presentation
{
    public class LoginPresenter : IPresenter
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

        private void Login(string UserName, string Password)
        {
            try
            {
                switch(_service.Login(UserName, Password))
                {
                    case UserType.Admin:
                        _view.ShowError("Admin");
                        //_kernel.Get<>().Run();
                        break;
                    case UserType.Manager:
                        _view.ShowError("Manager");
                        //_kernel.Get<>().Run();
                        break;
                    case UserType.Receptionist:
                        _view.ShowError("Reseptionist");
                        //_kernel.Get<>().Run();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                _view.ShowError(e.Message);
                return;
            }

            //_view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
