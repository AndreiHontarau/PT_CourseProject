using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICustomersManagementService
    {
        List<CustomerRecord> LoadTable();
        CustomerRecord LoadLastCustomer();
        bool DeleteCustomer(string firstName, string surname, string patronymic);
        int GetAmountOfMovies();
        int GetAmountOfCustomers();
        bool CheckMovieRegistrationSuccess();
    }
}
