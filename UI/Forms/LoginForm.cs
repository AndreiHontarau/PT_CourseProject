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

        public void ShowError(string message)
        {
            epLogin.SetError(btnLogin, message);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUserName.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                epLogin.SetError(btnLogin, "Empty User name or Password");
            }
            else
            {
                epLogin.Clear();
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
