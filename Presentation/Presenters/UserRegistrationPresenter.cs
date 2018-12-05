using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ninject;

namespace Presentation
{
    public class UserRegistrationPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IUserRegistrationView _view;
        private readonly IUserRegistrationService _service;

        public UserRegistrationPresenter(IKernel kernel, IUserRegistrationView view, IUserRegistrationService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
