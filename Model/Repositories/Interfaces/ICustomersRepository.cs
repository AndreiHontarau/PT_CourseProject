using System.Collections.Generic;

namespace Model
{
    public interface ICustomersRepository
    {
        void AddRecord(CustomerRecord record);
        List<CustomerRecord> ReadAllCustomers();
        CustomerRecord ReadLastCustomer();
        bool DeleteCustomer(string firstName, string surname, string patronymic);
        int GetAmountOfCustomers();
    }
}
