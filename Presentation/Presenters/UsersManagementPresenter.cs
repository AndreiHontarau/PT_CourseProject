using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ninject;

namespace Presentation
{
    public class UsersManagementPresenter : Presenter<IUsersManagementView>
    {
        private readonly IKernel _kernel;
        private readonly IUsersManagementView _view;
        private readonly IUsersManagementService _service;

        public UsersManagementPresenter(IKernel kernel, IUsersManagementView view, IUsersManagementService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.RegistrateUser += (object sender, EventArgs e) => RegistrateUser();
            _view.UpdateTable += (object sender, EventArgs e) => LoadTable();
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
                _view.DisplayRecord(user.UserName, UserTypeEnum.UserTypeToStringDictionary[user.Type]);
            }
        }

        private void LoadLastUser()
        {
            UserRecord user = _service.LoadLastUser();
            _view.DisplayRecord(user.UserName, UserTypeEnum.UserTypeToStringDictionary[user.Type]);
        }

        private void DeleteUser(string userName)
        {
            if (_service.DeleteUser(userName))
            {
                _view.ClearUser();
            }
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
