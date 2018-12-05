using System;

namespace Presentation
{
    public interface IStorageManagementView : IView
    {
        string SearchRequest { get; }

        event Action AddMovie;
        event Action DeleteMovie;
        event Action AddCategory;
        event Action Search;
        event Action Exit;
    }
}
