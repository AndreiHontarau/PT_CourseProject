using System;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class StorageManagementForm : Form, IStorageManagementView
    {
        private readonly ApplicationContext _context;
        public event EventHandler AddMovie;
        public event EventHandler DeleteMovie;
        public event EventHandler AddCategory;
        public event EventHandler Search;
        public event EventHandler Exit;

        public string SearchRequest => tbSearchRequest.Text;

        public StorageManagementForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            AddMovie?.Invoke(sender, e);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory?.Invoke(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMovie?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search?.Invoke(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit?.Invoke(sender, e);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
