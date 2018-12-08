using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsersManagementService : IUsersManagementService
    {
        private IUsersRepository _repository;

        public UsersManagementService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public List<UserRecord> LoadTable()
        {
            return _repository.ReadAllUsers();
        }

        public UserRecord LoadLastUser()
        {
            return _repository.ReadLastUser();
        }

        public bool DeleteUser(string userName)
        {
            return _repository.DeleteUser(userName);
        }
    }
}
