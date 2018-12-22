using System.Collections.Generic;

namespace Model
{
    public interface IUsersManagementService
    {
        List<UserRecord> LoadTable();
        UserRecord LoadLastUser();
        bool DeleteUser(string userName);
        bool CheckForPresence(string userName);
        bool CheckRegistrationSuccess();
    }
}
