using System;

namespace Presentation
{
    public interface IUsersManagementView : IView
    {
        event Action RegistrateUser;
        event Action<string> DeleteUser;
        event Action UpdateTable;
        event Action Exit;

        void ClearTable();
        void DisplayRecord(string UserName, string UserType);
        void ClearUser();
    }
}
