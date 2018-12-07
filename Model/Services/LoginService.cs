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
        private IUsersRepository _repository;

        public LoginService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public UserType Login(string UserName, string Password)
        {
            UserRecord user = _repository.ReadUser(UserName);

            if (HashService.VerifyHashedPassword(user.Password, Password))
            {
                return (UserType) user.Type;
            }
            else
            {
                throw new AuthenticationException("Wrong User name or Password");
            }
        }
    }
}
