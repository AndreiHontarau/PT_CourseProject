using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presentation;
using static Model.UserTypeEnum;

namespace UI
{
    public partial class UserRegistrationForm : Form, IUserRegistrationView
    {
        private readonly ApplicationContext _context;
        public event Action Registrate;

        public string userName => tbUserName.Text;
        public string password => tbPassword.Text;
        public UserType userType => UserTypeSelection();

        private UserType UserTypeSelection()
        {
                if (rbtnManager.Checked)
                {
                    return UserType.Manager;
                }
                else if (rbtnReceptionist.Checked)
                {
                    return UserType.Receptionist;
                }
                else if (rbtnAdministrator.Checked)
                {
                    return UserType.Admin;
                }
                else
                {
                    throw new ArgumentNullException("You shold choose type of the user.");
                }
        }

        public void ShowError(string massege)
        {
            lblNotification.Text = massege;
            lblNotification.ForeColor = Color.Red;
        }

        public UserRegistrationForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {

            ShowDialog();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            lblNotification.Text = "Enter user information:";
            lblNotification.ForeColor = Color.Black;
            Registrate?.Invoke();
        }
    }
}
