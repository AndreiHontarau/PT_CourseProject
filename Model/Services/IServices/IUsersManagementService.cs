using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IUsersManagementService
    {
        List<UserRecord> LoadTable();
        UserRecord LoadLastUser();
        bool DeleteUser(string userName);
    }
}
