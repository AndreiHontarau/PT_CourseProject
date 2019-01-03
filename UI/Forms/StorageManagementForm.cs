using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using Presentation;

namespace UI
{
    public partial class StorageManagementForm : Form, IStorageManagementView
    {
        private readonly ApplicationContext _context;

        public event EventHandler UpdateTable;
        public event EventHandler AddMovie;
        public event EventHandler<string> DeleteMovie;
        public event EventHandler AddCategory;
        public event EventHandler Search;
        public event EventHandler Exit;
        public event EventHandler<string> MovieSelected;

        public string SearchRequest => tbSearchRequest.Text;

        public StorageManagementForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void StorageManagementForm_Load(object sender, EventArgs e)
        {
            dgvMovies.ColumnCount = 7;

            dgvMovies.Columns[0].Name = "MovieID";
            dgvMovies.Columns[1].Name = "Category";
            dgvMovies.Columns[2].Name = "Title";
            dgvMovies.Columns[3].Name = "Year";
            dgvMovies.Columns[4].Name = "Producer";
            dgvMovies.Columns[5].Name = "Carrier";
            dgvMovies.Columns[6].Name = "Copies";

            UpdateTable?.Invoke(sender, e);
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
            pbScreenshot.Image = null;

            foreach (var row in dgvMovies.SelectedRows)
            {
                DeleteMovie?.Invoke(sender, (row as DataGridViewRow).Cells[0].Value.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search?.Invoke(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit?.Invoke(sender, e);
        }

        public void ClearMovies()
        {
            foreach (var row in dgvMovies.SelectedRows)
            {
                dgvMovies.Rows.RemoveAt((row as DataGridViewRow).Index);
            }
        }

        public void DisplayRecord(MovieRecord record)
        {
            dgvMovies.Rows.Add(record.MovieID, record.Category, record.Title, record.Year, record.Producer, record.Carrier, record.AmountOfCopies);
        }

        public void SetAmountOfMovies(int amount)
        {
            lblTotalAmountOfFilms.Text = amount.ToString();
        }

        public void DisplayScreenshot(string screenshotPath)
        {
            pbScreenshot.Image = Image.FromFile(screenshotPath);
        }

        public void DisplayExtendedInfo(MovieRecordExtended extendedRecord)
        {
            StringBuilder extendedInfo = new StringBuilder();

            extendedInfo.Append("   ");
            extendedInfo.Append(extendedRecord.Annotation);
            extendedInfo.Append('\n');
            extendedInfo.Append(extendedRecord.ActorsList);

            lblMovieInfo.Text = extendedInfo.ToString();
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                MovieSelected?.Invoke(sender, dgvMovies.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                pbScreenshot.Image = null;
            }
        }
    }
}
