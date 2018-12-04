using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ILoginView : IView
    {
        string UserName { get; }
        string Password { get; }
        event Action Login;
        void ShowError(string message);
    }
}
