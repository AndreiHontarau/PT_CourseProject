using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class CategoryRegistrationForm : Form, ICategoryRegistrationView
    {
        public string CategoryName{ get { return CategoryNameTextBox.Text; } }
        public string SymbolicCode { get { return null; } }

        public event Action AddCategory;

        public CategoryRegistrationForm()
        {
            InitializeComponent();

            buttonAddCategory.Click += (sender, args) => Invoke(AddCategory);
        }

        private void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }
    }
}
