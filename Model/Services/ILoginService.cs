using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.UserTypeEnum;

namespace Model
{
    public interface ILoginService
    {
        UserType Login(string UserName, string Password);
    }
}
