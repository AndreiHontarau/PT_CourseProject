using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            switch (this.UserNameTextBox.Text)
            {
                case "R":
                    CustomersManagementForm customersManagementForm = new CustomersManagementForm();
                    customersManagementForm.ShowDialog();
                    break;
                case "M":
                    StorageManagementForm storageManagementForm = new StorageManagementForm();
                    storageManagementForm.ShowDialog();
                    break;
                default:
                    break;
            }
            Close();
        }
    }
}
