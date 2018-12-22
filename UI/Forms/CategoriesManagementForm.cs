using System;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class CategoriesManagementForm : Form, ICategoriesManagementView
    {
        public string NewCategoryName { get { return tbCategoryName.Text; } }
        public string NewCategoryCode { get { return tbSymbolicCode.Text; } }

        public event EventHandler AddCategory;
        public event EventHandler<string> DeleteCategory;
        public event EventHandler<RenameArgs> RenameCategory;
        public event EventHandler LoadTable;

        public CategoriesManagementForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
        }

        private void CategoriesManagementForm_Load(object sender, EventArgs e)
        {
            dgvCategories.ColumnCount = 3;
            dgvCategories.Columns[0].Name = "Category name";
            dgvCategories.Columns[1].Name = "Category code";
            dgvCategories.Columns[2].Name = "Amount of movies";

            LoadTable?.Invoke(sender, e);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory?.Invoke(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var row in dgvCategories.SelectedRows)
            {
                DeleteCategory?.Invoke(sender, (row as DataGridViewRow).Cells[0].Value.ToString());

                dgvCategories.Rows.RemoveAt((row as DataGridViewRow).Index);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            RenameCategory?.Invoke(sender, new RenameArgs(dgvCategories.SelectedRows[0].Cells[0].Value.ToString(), tbNewName.Text, tbNewCode.Text));

            dgvCategories.SelectedRows[0].Cells[0].Value = tbNewName.Text;
            dgvCategories.SelectedRows[0].Cells[1].Value = tbNewCode.Text;
        }

        public void DisplayRecord(string Name, string Code, short AmountOfMovies)
        {
            dgvCategories.Rows.Add(Name, Code, AmountOfMovies);
        }

        public void ShowError(string messege)
        {
            MessageBox.Show(messege, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
