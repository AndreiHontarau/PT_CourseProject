using System;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class CategoryRegistrationForm : Form, ICategoryRegistrationView
    {
        public string CategoryName{ get { return CategoryNameTextBox.Text; } }
        public string SymbolicCode { get { return null; } }

        public event EventHandler AddCategory;

        public CategoryRegistrationForm()
        {
            InitializeComponent();

            buttonAddCategory.Click += (sender, args) => Invoke(AddCategory);
        }
    }
}
