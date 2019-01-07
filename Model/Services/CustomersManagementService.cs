using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomersManagementService : ICustomersManagementService
    {
        private int AmountOfCustomers;
        private IMoviesRepository _moviesRepository;
        private ICustomersRepository _customersRepository;

        public CustomersManagementService(IMoviesRepository moviesRepository, ICustomersRepository customersRepository)
        {
            _moviesRepository = moviesRepository;
            _customersRepository = customersRepository;
            AmountOfCustomers = _customersRepository.GetAmountOfCustomers();
        }

        public List<CustomerRecord> LoadTable()
        {
            return _customersRepository.ReadAllCustomers();
        }

        public CustomerRecord LoadLastCustomer()
        {
            return _customersRepository.ReadLastCustomer();
        }

        public bool DeleteCustomer(string firstName, string surname, string patronymic)
        {
            return _customersRepository.DeleteCustomer(firstName, surname, patronymic);
        }

        public int GetAmountOfMovies()
        {
            return _moviesRepository.GetAmountOfMovies();
        }

        public int GetAmountOfCustomers()
        {
            return _customersRepository.GetAmountOfCustomers();
        }

        public bool CheckMovieRegistrationSuccess()
        {
            if (_customersRepository.GetAmountOfCustomers() == AmountOfCustomers + 1)
            {
                AmountOfCustomers++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
