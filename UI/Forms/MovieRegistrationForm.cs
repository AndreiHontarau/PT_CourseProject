using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Presentation;

namespace UI
{
    public partial class MovieRegistrationForm : Form, IMovieRegistrationView
    {
        public MovieRegistrationForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            ShowDialog();
        }
    }
}
