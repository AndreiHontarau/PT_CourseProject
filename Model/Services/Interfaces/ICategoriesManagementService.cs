using System.Collections.Generic;

namespace Model
{
    public interface ICategoriesManagementService
    {
        List<CategoryRecord> LoadTable();
        void AddCategory(string name, string code);
        void DeleteCategory(string name);
        void RenameCategory(string name, string newName, string newCode);
        CategoryRecord LoadLastCategory();
        CategoryRecord LoadCategory(string name);
    }
}
