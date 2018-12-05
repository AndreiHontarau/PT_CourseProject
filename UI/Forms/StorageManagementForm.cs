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
    public partial class StorageManagementForm : Form, IStorageManagementView
    {
        private readonly ApplicationContext _context;
        public event Action AddMovie;
        public event Action DeleteMovie;
        public event Action AddCategory;
        public event Action Search;
        public event Action Exit;

        public string SearchRequest => tbSearchRequest.Text;

        public StorageManagementForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            AddMovie?.Invoke();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory?.Invoke();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMovie?.Invoke();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search?.Invoke();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
