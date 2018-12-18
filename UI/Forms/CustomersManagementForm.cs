using System;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class CustomersManagementForm : Form, ICustomersManagementView
    {
        private readonly ApplicationContext _context;

        public string SearchRequest => tbSewarchRequest.Text;

        public event EventHandler RegistrateCustomer;
        public event EventHandler DeleteCustomer;
        public event EventHandler ManageRents;
        public event EventHandler Search;
        public event EventHandler Exit;

        public CustomersManagementForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            RegistrateCustomer?.Invoke(sender, e);
            CustomerRegistration registration = new CustomerRegistration();
            registration.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer?.Invoke(sender, e);
        }

        private void btnManageRents_Click(object sender, EventArgs e)
        {
            ManageRents?.Invoke(sender, e);
            RentsManagment rentsManagment = new RentsManagment();
            rentsManagment.ShowDialog();
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
