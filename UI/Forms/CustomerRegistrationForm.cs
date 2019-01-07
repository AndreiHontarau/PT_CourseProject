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
    public partial class CustomerRegistrationForm : Form, ICustomerRegistrationView
    {
        private readonly ApplicationContext _context;

        public string FirstName => tbFirstName.Text;
        public string Surname => tbSurname.Text;
        public string Patronymic => tbPatronymic.Text;
        public short Age => Int16.Parse(tbAge.Text);
        public bool Gender => GetGender();
        public DateTime RegistrationDateTime => DateTime.Now;

        public event EventHandler Registrate;

        public CustomerRegistrationForm(ApplicationContext context)
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
            Registrate.Invoke(sender, e);
            _context.MainForm.DialogResult = DialogResult.OK;
        }

        private bool GetGender()
        {
            if (rbtnFemale.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ShowError(string messege)
        {
            MessageBox.Show(messege, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
