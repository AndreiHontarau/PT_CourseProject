using System;
using Model;

namespace Presentation
{
    public interface ICustomersManagementView : IView
    {
        string SearchRequest { get; }

        event EventHandler UpdateTable;
        event EventHandler RegistrateCustomer;
        event EventHandler<NameSurnamePatronymic> DeleteCustomer;
        event EventHandler<NameSurnamePatronymic> ManageRents;
        event EventHandler Search;
        event EventHandler Exit;

        void DisplayRecord(CustomerRecord record);
        void ClearCustomers();
        void SetAmountOfMovies(int amount);
        void SetAmountOfCustomers(int amount);
    }

    public class NameSurnamePatronymic : EventArgs
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }

        public NameSurnamePatronymic(string firstName, string surname, string patronymic)
        {
            FirstName = firstName;
            Surname = surname;
            Patronymic = patronymic;
        }
    }
}
