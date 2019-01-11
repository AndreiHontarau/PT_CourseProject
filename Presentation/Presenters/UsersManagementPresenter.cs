using System;
using System.Collections.Generic;
using Model;
using Ninject;

namespace Presentation
{
    public class UsersManagementPresenter : Presenter<IUsersManagementView>
    {
        private readonly IUsersManagementService _service;

        public UsersManagementPresenter(IKernel kernel, IUsersManagementView view, IUsersManagementService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.RegistrateUser += (object sender, EventArgs e) => RegistrateUser();
            _view.LoadTable += (object sender, EventArgs e) => LoadTable();
            _view.DeleteUser += (object sender, string userName) => DeleteUser(userName);
            _view.Exit += (object sender, EventArgs e) => Exit();
        }

        private void RegistrateUser()
        {
            _kernel.Get<UserRegistrationPresenter>().Run();
            if (_service.CheckRegistrationSuccess())
            {
                LoadLastUser();
            }
        }

        private void LoadTable()
        {
            List<UserRecord> users = _service.LoadTable();

            foreach (UserRecord user in users)
            {
                _view.DisplayRecord(user.Name, user.ToString());
            }
        }

        private void LoadLastUser()
        {
            UserRecord user = _service.LoadLastUser();
            _view.DisplayRecord(user.Name, user.ToString());
        }

        private void DeleteUser(string userName)
        {
            _service.DeleteUser(userName);
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
