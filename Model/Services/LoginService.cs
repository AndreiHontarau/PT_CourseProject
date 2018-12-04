using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using static Model.UserTypeEnum;

namespace Model
{
    public class LoginService : ILoginService
    {
        public UserType Login(string UserName, string Password)
        {
            switch (UserName)
            {
                case "R":
                    return UserType.Receptionist;
                case "M":
                    return UserType.Manager;
                case "A":
                    return UserType.Admin;
                default:
                    throw new AuthenticationException("Wrong User name or Password");
            }
        }
    }
}
