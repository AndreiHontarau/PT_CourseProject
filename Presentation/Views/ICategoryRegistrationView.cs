using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ICategoryRegistrationView : IView
    {
        string CategoryName { get; }
        string SymbolicCode { get; }
        event EventHandler AddCategory;
    }
}
