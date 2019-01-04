using System;
using System.Drawing;
using System.Windows.Forms;
using Presentation;
using static Model.UserRecord;
using System.ComponentModel;

namespace UI
{
    public partial class UserRegistrationForm : Form, IUserRegistrationView
    {
        private readonly ApplicationContext _context;

        public event EventHandler Registrate;

        public string userName => tbUserName.Text;
        public string password => tbPassword.Text;
        public UserRole userRole => UserRoleSelection();

        public UserRegistrationForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            tbPassword.Validating += ValidatePassword;
            tbUserName.Validating += ValidateUserName;
            rbtnManager.CheckedChanged += ValidateUserRole;
            rbtnReceptionist.CheckedChanged += ValidateUserRole;
            rbtnAdministrator.CheckedChanged += ValidateUserRole;
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUserName.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                epRegistration.SetError(btnRegistrate, "User name or Password is empty");
            }
            else
            {
                Registrate.Invoke(sender, e);
            }
        }

        private UserRole UserRoleSelection()
        {
                if (rbtnManager.Checked)
                {
                    return UserRole.Manager;
                }
                else if (rbtnReceptionist.Checked)
                {
                    return UserRole.Receptionist;
                }
                else if (rbtnAdministrator.Checked)
                {
                    return UserRole.Admin;
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

        private void ValidateUserRole(object sender, EventArgs e)
        {
            if (!rbtnManager.Checked && !rbtnReceptionist.Checked && !rbtnAdministrator.Checked)
            {
                btnRegistrate.Enabled = false;
            }
            else
            {
                btnRegistrate.Enabled = true;
            }
        }

        private void ValidatePassword(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                epPassword.SetError(tbPassword, "Enter password");
                btnRegistrate.Enabled = false;
            }
            else
            {
                epPassword.Clear();
                btnRegistrate.Enabled = true;
            }
        }

        private void ValidateUserName(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbUserName.Text))
            {
                epUserName.SetError(tbUserName, "Enter name");
                btnRegistrate.Enabled = false;
            }
            else
            {
                epUserName.Clear();
                btnRegistrate.Enabled = true;
            }
        }
    }
}
