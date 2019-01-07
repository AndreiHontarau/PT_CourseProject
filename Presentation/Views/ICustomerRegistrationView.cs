using System;

namespace Presentation
{
    public interface ICustomerRegistrationView : IView
    {
        string FirstName { get; }
        string Surname { get; }
        string Patronymic { get; }
        short Age { get; }
        bool Gender { get; }
        DateTime RegistrationDateTime { get; }

        event EventHandler Registrate;

        void ShowError(string massege);
    }
}
