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
using Model;

namespace UI
{
    public partial class MovieRegistrationForm : Form, IMovieRegistrationView
    {
        private readonly ApplicationContext _context;
        private List<CategoryRecord> Categories;

        public event EventHandler Registrate;
        public event EventHandler UploadImage;
        public event EventHandler LoadCategories;

        public string Title => tbTitle.Text;
        public string Producer => tbProducer.Text;
        public short YearOfProduction => Int16.Parse(tbYear.Text);
        public string CategoryName => cbCategory.SelectedItem.ToString();
        public string Carrier => tbMediaType.Text;
        public short AmountOfCopies => Int16.Parse(tbAmountOfCopies.Text);
        public string Country => tbCountry.Text;
        public string ActorsList => tbActorsList.Text;
        public string Language => tbLanguage.Text;
        public string Description => rtbDescription.Text;
        public bool AgeRestriction => cbAgeRestriction.Checked;

        public MovieRegistrationForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void MovieRegistrationForm_Load(object sender, EventArgs e)
        {
            LoadCategories?.Invoke(sender, e);

            foreach (var category in Categories)
            {
                cbCategory.Items.Add(category.name);
            }
        }

        public void RecieveCategories(List<CategoryRecord> categories)
        {
            Categories = categories;
        }

        public void ShowError(string messege)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Registrate?.Invoke(sender, e);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            UploadImage?.Invoke(sender, e);
        }
    }
}
