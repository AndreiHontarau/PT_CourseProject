using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Model
{
    public class UserRecord : Record
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public UserTypeEnum.UserType Type { get; private set; }

        public UserRecord(string userName, string password, UserTypeEnum.UserType userType)
        {
            UserName = userName;
            Password = password;
            Type = userType;
        }
    }
}
