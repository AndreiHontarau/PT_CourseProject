using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ninject;

namespace Presentation
{
    public class UsersManagementPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IUsersManagementView _view;
        private readonly IUsersManagementService _service;

        public UsersManagementPresenter(IKernel kernel, IUsersManagementView view, IUsersManagementService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.RegistrateUser += () => RegistrateUser();
        }

        private void RegistrateUser()
        {
            _kernel.Get<UserRegistrationPresenter>().Run();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
