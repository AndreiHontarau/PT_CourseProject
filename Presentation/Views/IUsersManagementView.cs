using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IUsersManagementView : IView
    {
        event Action RegistrateUser;
        event Action DeleteUser;
        event Action Exit;
    }
}
