using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation
{
    class CategoryRegistrationPresenter
    {
        private ICategoryRegistrationView view { get; set; }
        private IAddCategoryService service { get; set; }

        public CategoryRegistrationPresenter(ICategoryRegistrationView view, IAddCategoryService service)
        {
            this.view = view;
            this.service = service;

            view.AddCategory += () => AddCategory(view.CategoryName);
        }

        private void AddCategory(string categoryName)
        {
            CategoryRecord record = new CategoryRecord(categoryName, 0);
        }
    }
}
