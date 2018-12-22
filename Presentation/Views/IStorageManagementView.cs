using System;
using Model;

namespace Presentation
{
    public interface IStorageManagementView : IView
    {
        string SearchRequest { get; }

        event EventHandler UpdateTable;
        event EventHandler AddMovie;
        event EventHandler<string> DeleteMovie;
        event EventHandler AddCategory;
        event EventHandler Search;
        event EventHandler Exit;

        void ClearMovies();
        void DisplayRecord(MovieRecord record);
    }
}
