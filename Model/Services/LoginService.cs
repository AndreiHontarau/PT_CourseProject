using System.Security.Authentication;
using static Model.UserRecord;

namespace Model
{
    public class LoginService : ILoginService
    {
        private readonly IUsersRepository _repository;

        public LoginService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public UserRole Login(string UserName, string Password)
        {
            UserRecord user = _repository.ReadUser(UserName);

            if (HashService.VerifyHashedPassword(user.Password, Password))
            {
                return user.Role;
            }
            else
            {
                throw new AuthenticationException("Wrong User name or Password");
            }
        }
    }
}
