using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.UserRecord;

namespace Model
{
    public interface ILoginService
    {
        UserRole Login(string UserName, string Password);
    }
}
