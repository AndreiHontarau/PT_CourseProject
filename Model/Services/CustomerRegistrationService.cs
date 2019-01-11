﻿namespace Model
{
    public class CustomerRegistrationService : ICustomerRegistrationService
    {
        private readonly ICustomersRepository _repository;

        public CustomerRegistrationService(ICustomersRepository repository)
        {
            _repository = repository;
        }

        public void Registrate(CustomerRecord newRecord)
        {
            _repository.AddRecord(newRecord);
        }
    }
}
