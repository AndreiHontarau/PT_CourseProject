using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IUsersRepository
    {
        void AddRecord(UserRecord record);
        List<UserRecord> ReadAllUsers();
        UserRecord ReadUser(string userName);
    }
}
