using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation
{
    public class RentRegistrationPresenter : Presenter<IRentRegistrationView>
    {
        private readonly IRentRegistrationService _servise;

        public RentRegistrationPresenter(IRentRegistrationView view, IRentRegistrationService service)
        {
            _view = view;
            _servise = service;
        }

        public override void Run()
        {
            _view.Show();
        }
    }
}
