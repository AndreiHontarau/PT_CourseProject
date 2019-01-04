using System.Collections.Generic;

namespace Model
{
    public interface IUsersRepository
    {
        void AddRecord(UserRecord record);
        List<UserRecord> ReadAllUsers();
        UserRecord ReadUser(string name);
        UserRecord ReadLastUser();
        bool CheckForPresence(string name);
        bool DeleteUser(string name);
        int GetAmountOfUsers();
    }
}
