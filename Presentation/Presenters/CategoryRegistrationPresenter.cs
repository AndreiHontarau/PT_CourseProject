using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation
{
    class CategoryRegistrationPresenter : Presenter<ICategoryRegistrationView>
    {
        private readonly ICategoryRegistrationView _view;
        private readonly IAddCategoryService _service;

        public CategoryRegistrationPresenter(ICategoryRegistrationView view, IAddCategoryService service)
        {
            _view = view;
            _service = service;

            view.AddCategory += (object sender, EventArgs e) => AddCategory(view.CategoryName);
        }


            private void AddCategory(string categoryName)
        {
            CategoryRecord record = new CategoryRecord(categoryName, 0);
        }

        public override void Run()
        {
            _view.Show();
        }
    }
}
