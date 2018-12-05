using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form, Presentation.ILoginView
    {
        private readonly ApplicationContext _context;
        public event Action Login;

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
            Login?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
