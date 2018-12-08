namespace Model
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private IUsersRepository _repository;

        public UserRegistrationService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public void Registrate(UserRecord newUser)
        {
            string encryptedPassword = HashService.HashPassword(newUser.Password);

            UserRecord record = new UserRecord(newUser.UserName, encryptedPassword, newUser.Type);
            _repository.AddRecord(record);
        }
    }
}
