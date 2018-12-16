using System.Security.Authentication;
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
                return user.Type;
            }
            else
            {
                throw new AuthenticationException("Wrong User name or Password");
            }
        }
    }
}
