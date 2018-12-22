using System;

namespace Presentation
{
    public interface ICategoriesManagementView : IView
    {
        string NewCategoryName { get; }
        string NewCategoryCode { get; }
        event EventHandler AddCategory;
        event EventHandler<string> DeleteCategory;
        event EventHandler<RenameArgs> RenameCategory;
        event EventHandler LoadTable;

        void ShowError(string messege);
        void DisplayRecord(string Name, string Code, short AmountOfMovies);
    }

    public class RenameArgs : EventArgs
    {
        public string Categoryname { get; private set; }
        public string NewName { get; private set; }
        public string NewCode { get; private set; }

        public RenameArgs(string categoryname, string newName, string newCode)
        {
            Categoryname = categoryname;
            NewName = newName;
            NewCode = newCode;
        }
    }
}
