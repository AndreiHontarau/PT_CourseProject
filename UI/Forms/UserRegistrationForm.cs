using System;
using System.Drawing;
using System.Windows.Forms;
using Presentation;
using static Model.UserTypeEnum;
using System.ComponentModel;

namespace UI
{
    public partial class UserRegistrationForm : Form, IUserRegistrationView
    {
        private readonly ApplicationContext _context;
        public event EventHandler Registrate;

        public string userName => tbUserName.Text;
        public string password => tbPassword.Text;
        public UserType userType => UserTypeSelection();

        public UserRegistrationForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            tbPassword.Validating += ValidatePassword;
            tbUserName.Validating += ValidateUserName;
            rbtnManager.CheckedChanged += ValidateUserType;
            rbtnReceptionist.CheckedChanged += ValidateUserType;
            rbtnAdministrator.CheckedChanged += ValidateUserType;
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            Registrate.Invoke(sender, e);
        }

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

        private void ValidateUserType(object sender, EventArgs e)
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
