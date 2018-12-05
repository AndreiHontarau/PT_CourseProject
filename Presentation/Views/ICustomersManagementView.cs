using System;

namespace Presentation
{
    public interface ICustomersManagementView : IView
    {
        string SearchRequest { get; }

        event Action RegistrateCustomer;
        event Action DeleteCustomer;
        event Action ManageRents;
        event Action Search;
        event Action Exit;
    }
}
