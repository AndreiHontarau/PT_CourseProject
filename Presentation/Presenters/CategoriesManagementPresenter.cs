using System;
using System.Collections.Generic;
using Model;

namespace Presentation
{
    public class CategoriesManagementPresenter : Presenter<ICategoriesManagementView>
    {
        private readonly ICategoriesManagementService _service;

        public CategoriesManagementPresenter(ICategoriesManagementView view, ICategoriesManagementService service)
        {
            _view = view;
            _service = service;

            _view.AddCategory += (object sender, EventArgs e) => AddCategory(_view.NewCategoryName, _view.NewCategoryCode);
            _view.DeleteCategory += (object sender, string name) => DeleteCategory(name);
            _view.RenameCategory += (object sender, RenameArgs args) => RenameCategory(args);
            _view.LoadTable += (object sender, EventArgs e) => LoadTable();
        }

        public void LoadTable()
        {
            try
            {
                List<CategoryRecord> categories = _service.LoadTable();
            
                foreach (CategoryRecord category in categories)
                {
                    _view.DisplayRecord(category.name, category.symbolicCode, category.amountOfMovies);
                }
            }
            catch (SqlDataWouldBeTruncatedException e)
            {
                _view.ShowError("One of the field's value is too long.");
            }
        }

        private void AddCategory(string categoryName, string categorySymbolicCode)
        {
            try
            {
                _service.AddCategory(categoryName, categorySymbolicCode);
                LoadLastCategory();
            }
            catch (SqlDataWouldBeTruncatedException e)
            {
                _view.ShowError("One of the field's value is too long.");
            }
            catch (ArgumentException e)
            {
                _view.ShowError(e.Message);
            }
        }

        public void DeleteCategory(string name)
        {
            _service.DeleteCategory(name);
        }

        public void RenameCategory(RenameArgs args)
        {
            try
            {
                _service.RenameCategory(args.Categoryname, args.NewName, args.NewCode);
            }
            catch (SqlDataWouldBeTruncatedException e)
            {
                _view.ShowError("One of the field's value is too long.");
            }
        }

        private void LoadLastCategory()
        {
            CategoryRecord category = _service.LoadLastCategory();
            _view.DisplayRecord(category.name, category.symbolicCode, category.amountOfMovies);
        }

        public override void Run()
        {
            _view.Show();
        }
    }
}
