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
    public partial class StorageManagementForm : Form
    {
        public StorageManagementForm()
        {
            InitializeComponent();
        }

        private void AddFilmButton_Click(object sender, EventArgs e)
        {
            FilmRegistration filmRegistration = new FilmRegistration();
            filmRegistration.ShowDialog();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryRegistration categoryRegistration = new CategoryRegistration();
            categoryRegistration.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure?", "Confirm delete of %filmname%", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                
            }
            else
            {
                
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
