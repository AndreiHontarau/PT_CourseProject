using System;
using static Model.UserRecord;

namespace Presentation
{
    public interface IUserRegistrationView : IView
    {
        string userName { get; }
        string password { get; }
        UserRole userRole { get; }
        event EventHandler Registrate;

        void ShowError(string Massege);
    }
}
