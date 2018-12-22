using System;
using System.Collections.Generic;
namespace Model
{
    public class CategoriesManagementService : ICategoriesManagementService
    {
        private ICategoriesRepository _repository;

        public CategoriesManagementService(ICategoriesRepository repository)
        {
            _repository = repository;
        }

        public List<CategoryRecord> LoadTable()
        {
            return _repository.ReadAllCategories();
        }

        public CategoryRecord LoadCategory(string name)
        {
            return _repository.LoadCategory(name);
        }

        public void AddCategory(string name, string code)
        {
            if (_repository.CheckForPresence(name))
            {
                throw new ArgumentException("Category with this name is already exists.");
            }

            CategoryRecord record = new CategoryRecord(name, code, 0);
            _repository.AddCategory(record); 
        }

        public void DeleteCategory(string name)
        {
            _repository.DeleteCategory(name);
        }

        public CategoryRecord LoadLastCategory()
        {
            return _repository.LoadLastCategory();
        }

        public void RenameCategory(string name, string newName, string newCode)
        {
            if (_repository.CheckForPresence(newName))
            {
                //throw new;
            }

            _repository.RenameCategory(name, newName, newCode);
        }

    }
}
