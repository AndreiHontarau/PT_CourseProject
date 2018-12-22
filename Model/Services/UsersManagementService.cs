using System.Collections.Generic;

namespace Model
{
    public class UsersManagementService : IUsersManagementService
    {
        private IUsersRepository _repository;
        private int AmountOfUsers;

        public UsersManagementService(IUsersRepository repository)
        {
            _repository = repository;
            AmountOfUsers = _repository.GetAmountOfUsers();
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

        public bool CheckForPresence(string userName)
        {
            return _repository.CheckForPresence(userName);
        }

        private int GetAmountOfUsers()
        {
            return _repository.GetAmountOfUsers();
        }

        public bool CheckRegistrationSuccess()
        {
            if (_repository.GetAmountOfUsers() == AmountOfUsers + 1)
            {
                AmountOfUsers++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
