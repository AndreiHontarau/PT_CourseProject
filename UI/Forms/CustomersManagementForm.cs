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
    public partial class CustomersManagementForm : Form, ICustomersManagementView
    {
        private readonly ApplicationContext _context;

        public string SearchRequest => tbSewarchRequest.Text;

        public event Action RegistrateCustomer;
        public event Action DeleteCustomer;
        public event Action ManageRents;
        public event Action Search;
        public event Action Exit;

        public CustomersManagementForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            RegistrateCustomer?.Invoke();
            CustomerRegistration registration = new CustomerRegistration();
            registration.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer?.Invoke();
        }

        private void btnManageRents_Click(object sender, EventArgs e)
        {
            ManageRents?.Invoke();
            RentsManagment rentsManagment = new RentsManagment();
            rentsManagment.ShowDialog();
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
