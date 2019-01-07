using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using  Presentation;
using Model;
using System.Linq;

namespace UI
{
    public partial class MovieRegistrationForm : Form, IMovieRegistrationView
    {
        private readonly ApplicationContext _context;
        private List<CategoryRecord> Categories;

        public event EventHandler Registrate;
        public event EventHandler LoadCategories;

        public string ScreenshotPath { get; private set; }
        public string PreviousMovieID => tbPreviousMovieID.Text;
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

            foreach (var category in Categories)
            {
                cmbCategory.Items.Add(category.name);
            }

            cmbCarrier.Items.Add("VHS");
            cmbCarrier.Items.Add("DVD");
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void MovieRegistrationForm_Load(object sender, EventArgs e)
        {
            LoadCategories?.Invoke(sender, e);
        }

        public void ShowError(string messege)
        {
            MessageBox.Show(messege, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            epRegistration.Clear();

            foreach (TableLayoutPanel panel in tlpMovieInfo.Controls.OfType<TableLayoutPanel>())
            {
                foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                {
                    if (String.IsNullOrEmpty(tb.Text))
                    {
                        epRegistration.SetError(tb, "This field should not be empty");
                        return;
                    }
                }

                foreach (ComboBox cmb in panel.Controls.OfType<ComboBox>())
                {
                    if (cmb.SelectedItem == null)
                    {
                        epRegistration.SetError(cmb, "This field should not be empty");
                        return;
                    }
                }

                if (String.IsNullOrEmpty(rtbDescription.Text))
                {
                    epRegistration.SetError(btnAdd, "Description can't be empty");
                    return;
                }
                else if (ScreenshotPath == null)
                {
                    epRegistration.SetError(btnUploadImage, "Upload screenshot to proceed");
                    return;
                }
            }

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
                ScreenshotPath = dialog.FileName;
                btnUploadImage.BackgroundImage = Image.FromFile(dialog.FileName);
                btnUploadImage.Dock = DockStyle.Fill;
                btnUploadImage.BackColor = Color.Transparent;
            }
        }
    }
}
