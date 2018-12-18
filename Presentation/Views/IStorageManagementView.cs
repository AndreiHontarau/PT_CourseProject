using System;

namespace Presentation
{
    public interface IStorageManagementView : IView
    {
        string SearchRequest { get; }

        event EventHandler AddMovie;
        event EventHandler DeleteMovie;
        event EventHandler AddCategory;
        event EventHandler Search;
        event EventHandler Exit;
    }
}
