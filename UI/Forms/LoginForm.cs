using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form, Presentation.ILoginView
    {
        private readonly ApplicationContext _context;
        public event EventHandler Login;

        public string UserName => tbUserName.Text;
        public string Password => tbPassword.Text;

        public LoginForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void ShowError(string massage)
        {
            lblError.Text = massage;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (tbUserName.Text.Length == 0 || tbPassword.Text.Length == 0)
            {
                ShowError("Wrong User name or Password");
            }
            else
            {
                Login?.Invoke(sender, e);
            }
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
