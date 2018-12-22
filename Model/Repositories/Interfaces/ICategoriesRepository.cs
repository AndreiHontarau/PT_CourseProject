using System.Collections.Generic;

namespace Model
{
    public interface ICategoriesRepository
    {
        void AddCategory(CategoryRecord newCategory);
        void DeleteCategory(string categoryName);
        void RenameCategory(string categoryName, string newName, string newCode);
        List<CategoryRecord> ReadAllCategories();
        CategoryRecord LoadCategory(string name);
        CategoryRecord LoadLastCategory();
        bool CheckForPresence(string name);
        int GetAmountOfCategories();
    }
}
