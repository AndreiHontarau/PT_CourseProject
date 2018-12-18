using System;

namespace Presentation
{
    public interface ICustomersManagementView : IView
    {
        string SearchRequest { get; }

        event EventHandler RegistrateCustomer;
        event EventHandler DeleteCustomer;
        event EventHandler ManageRents;
        event EventHandler Search;
        event EventHandler Exit;
    }
}
