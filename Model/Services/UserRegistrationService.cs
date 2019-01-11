﻿using System;

namespace Model
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly IUsersRepository _repository;

        public UserRegistrationService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public void Registrate(UserRecord newUser)
        {
            if (_repository.CheckForPresence(newUser.Name))
            {
                throw new ArgumentException("User with this name is already exists.");
            }

            string encryptedPassword = HashService.HashPassword(newUser.Password);

            UserRecord record = new UserRecord(newUser.Name, encryptedPassword, newUser.Role);
            _repository.AddRecord(record);
        }
    }
}
