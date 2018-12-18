using System;
using static Model.UserTypeEnum;

namespace Presentation
{
    public interface IUserRegistrationView : IView
    {
        string userName { get; }
        string password { get; }
        UserType userType { get; }
        event EventHandler Registrate;

        void ShowError(string Massege);
    }
}
