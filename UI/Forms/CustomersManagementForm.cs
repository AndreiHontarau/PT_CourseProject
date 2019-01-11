using System;
using System.Windows.Forms;
using Presentation;
using Model;

namespace UI
{
    public partial class CustomersManagementForm : Form, ICustomersManagementView
    {
        private readonly ApplicationContext _context;

        public string SearchRequest => tbSewarchRequest.Text;

        public event EventHandler UpdateTable;
        public event EventHandler RegistrateCustomer;
        public event EventHandler<NameSurnamePatronymic> DeleteCustomer;
        public event EventHandler<NameSurnamePatronymic> ManageRents;
        public event EventHandler Search;
        public event EventHandler Exit;

        private void CustomersManagementForm_Load(object sender, EventArgs e)
        {
            dgvCustomers.ColumnCount = 6;

            dgvCustomers.Columns[0].Name = "First name";
            dgvCustomers.Columns[1].Name = "Last name";
            dgvCustomers.Columns[2].Name = "Patronymic";
            dgvCustomers.Columns[3].Name = "Age";
            dgvCustomers.Columns[4].Name = "Gender";
            dgvCustomers.Columns[5].Name = "Number of rents";

            UpdateTable?.Invoke(sender, e);
        }

        public CustomersManagementForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            RegistrateCustomer?.Invoke(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomers.SelectedRows)
            {
                DeleteCustomer?.Invoke(sender,
                    new NameSurnamePatronymic(row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString()));
            }
        }

        private void btnManageRents_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count != 0)
            {
                ManageRents?.Invoke(sender, new NameSurnamePatronymic(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString(),
                    dgvCustomers.SelectedRows[0].Cells[1].Value.ToString(), dgvCustomers.SelectedRows[0].Cells[2].Value.ToString()));
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

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void DisplayRecord(CustomerRecord record)
        {
            dgvCustomers.Rows.Add(record.FirstName, record.Surname, record.Patronymic, record.Age, record.GetGenderToChar(), record.NumberOfRents);
        }

        public void ClearCustomers()
        {
            foreach (var row in dgvCustomers.SelectedRows)
            {
                dgvCustomers.Rows.RemoveAt((row as DataGridViewRow).Index);
            }
        }

        public void SetAmountOfMovies(int amount)
        {
            lblTotalAmountOfMovies.Text = amount.ToString();
        }

        public void SetAmountOfCustomers(int amount)
        {
            lblTotalAmountOfCustomers.Text = amount.ToString();
        }
    }
}
