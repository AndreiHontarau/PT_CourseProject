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
        public short YearOfProduction => GetYear();
        public string CategoryName => cmbCategory.SelectedItem.ToString();
        public string Carrier => cmbCarrier.SelectedItem.ToString();
        public short AmountOfCopies => GetCopies();
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
                cmbCategory.Items.Add(category.name);
            }

            cmbCarrier.Items.Add("VHS");
            cmbCarrier.Items.Add("DVD");
        }

        public short GetYear()
        {
            try
            {
               return Int16.Parse(tbYear.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
            
        }

        public short GetCopies()
        {
            try
            {
                return Int16.Parse(tbAmountOfCopies.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
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
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Upload screenlist";
            dialog.Filter = "Screenlist(*.PNG;*.JPG)|*.PNG;*.JPG";

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                btnUploadImage.BackgroundImage = Image.FromFile(dialog.FileName);
                btnUploadImage.Dock = DockStyle.Fill;
                btnUploadImage.BackColor = Color.Transparent;
            }

            UploadImage?.Invoke(sender, e);
        }
    }
}
