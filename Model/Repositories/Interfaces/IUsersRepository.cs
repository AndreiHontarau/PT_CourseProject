using System.Collections.Generic;

namespace Model
{
    public interface IUsersRepository
    {
        void AddRecord(UserRecord record);
        List<UserRecord> ReadAllUsers();
        UserRecord ReadUser(string userName);
        UserRecord ReadLastUser();
        bool CheckForPresence(string userName);
        bool DeleteUser(string userName);
        int GetAmountOfUsers();
    }
}
