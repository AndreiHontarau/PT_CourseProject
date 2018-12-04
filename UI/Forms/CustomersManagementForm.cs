using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomersManagementForm : Form
    {
        public CustomersManagementForm()
        {
            InitializeComponent();
        }

        private void RegistrateButton_Click(object sender, EventArgs e)
        {
            CustomerRegistration registration = new CustomerRegistration();
            registration.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure?", "Confirm delete of %customername%", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void ManageRentsButton_Click(object sender, EventArgs e)
        {
            RentsManagment rentsManagment = new RentsManagment();
            rentsManagment.ShowDialog();
        }
    }
}
