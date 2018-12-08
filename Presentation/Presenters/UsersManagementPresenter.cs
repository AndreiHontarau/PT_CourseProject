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
            _view.UpdateTable += () => LoadTable();
            _view.DeleteUser += (string userNsme) => DeleteUser(userNsme);
            _view.Exit += () => Exit();
        }

        private void RegistrateUser()
        {
            _kernel.Get<UserRegistrationPresenter>().Run();
            LoadUser();
        }

        private void LoadTable()
        {
            List<UserRecord> users = _service.LoadTable();

            foreach (UserRecord user in users)
            {
                _view.DisplayRecord(user.UserName, UserTypeEnum.UserTypeToStringDictionary[user.Type]);
            }
        }

        private void LoadUser()
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

        public void Run()
        {
            _view.Show();
        }
    }
}
