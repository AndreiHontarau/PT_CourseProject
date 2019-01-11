using System;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class RentRegistrationForm : Form, IRentRegistrationView
    {
        public RentRegistrationForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
