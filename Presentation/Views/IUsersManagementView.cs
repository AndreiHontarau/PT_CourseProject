using System;

namespace Presentation
{
    public interface IUsersManagementView : IView
    {
        event EventHandler RegistrateUser;
        event EventHandler<string> DeleteUser;
        event EventHandler LoadTable;
        event EventHandler Exit;

        void ClearTable();
        void DisplayRecord(string UserName, string UserType);
    }
}
