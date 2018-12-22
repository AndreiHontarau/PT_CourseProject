namespace UI
{
    partial class MovieRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieRegistrationForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbProducer = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbAgeRestriction = new System.Windows.Forms.CheckBox();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.tbActorsList = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbAmountOfCopies = new System.Windows.Forms.TextBox();
            this.tbMediaType = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbProducer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InfoLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.cbAgeRestriction, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbLanguage, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.tbActorsList, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbCountry, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbAmountOfCopies, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbMediaType, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbCategory, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.330277F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbYear
            // 
            this.tbYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbYear.Location = new System.Drawing.Point(122, 177);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(150, 22);
            this.tbYear.TabIndex = 5;
            this.tbYear.Text = "Year of poduction";
            // 
            // tbProducer
            // 
            this.tbProducer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbProducer.Location = new System.Drawing.Point(122, 119);
            this.tbProducer.Name = "tbProducer";
            this.tbProducer.Size = new System.Drawing.Size(150, 22);
            this.tbProducer.TabIndex = 4;
            this.tbProducer.Text = "Producer";
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(124, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(145, 17);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Enter film information:";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTitle.Location = new System.Drawing.Point(122, 61);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(150, 22);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.Text = "Title";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(157, 669);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add film";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbAgeRestriction
            // 
            this.cbAgeRestriction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAgeRestriction.AutoSize = true;
            this.cbAgeRestriction.Location = new System.Drawing.Point(117, 583);
            this.cbAgeRestriction.Name = "cbAgeRestriction";
            this.cbAgeRestriction.Size = new System.Drawing.Size(159, 21);
            this.cbAgeRestriction.TabIndex = 0;
            this.cbAgeRestriction.Text = "Age restriction (18+)";
            this.cbAgeRestriction.UseVisualStyleBackColor = true;
            // 
            // tbLanguage
            // 
            this.tbLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLanguage.Location = new System.Drawing.Point(122, 525);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(150, 22);
            this.tbLanguage.TabIndex = 10;
            this.tbLanguage.Text = "Language";
            // 
            // tbActorsList
            // 
            this.tbActorsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbActorsList.Location = new System.Drawing.Point(122, 467);
            this.tbActorsList.Name = "tbActorsList";
            this.tbActorsList.Size = new System.Drawing.Size(150, 22);
            this.tbActorsList.TabIndex = 7;
            this.tbActorsList.Text = "Actors list";
            // 
            // tbCountry
            // 
            this.tbCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCountry.Location = new System.Drawing.Point(122, 409);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(150, 22);
            this.tbCountry.TabIndex = 6;
            this.tbCountry.Text = "Country";
            // 
            // tbAmountOfCopies
            // 
            this.tbAmountOfCopies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAmountOfCopies.Location = new System.Drawing.Point(122, 351);
            this.tbAmountOfCopies.Name = "tbAmountOfCopies";
            this.tbAmountOfCopies.Size = new System.Drawing.Size(150, 22);
            this.tbAmountOfCopies.TabIndex = 9;
            this.tbAmountOfCopies.Text = "Amount of copies";
            // 
            // tbMediaType
            // 
            this.tbMediaType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMediaType.Location = new System.Drawing.Point(122, 293);
            this.tbMediaType.Name = "tbMediaType";
            this.tbMediaType.Size = new System.Drawing.Size(150, 22);
            this.tbMediaType.TabIndex = 8;
            this.tbMediaType.Text = "Media type";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(122, 235);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 24);
            this.cbCategory.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 708);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rtbDescription, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnUploadImage, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.11681F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.88319F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 702);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Location = new System.Drawing.Point(3, 418);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(388, 281);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "Description";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.Image")));
            this.btnUploadImage.Location = new System.Drawing.Point(152, 162);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(90, 90);
            this.btnUploadImage.TabIndex = 1;
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // MovieRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieRegistrationForm";
            this.Text = "Movie registration";
            this.Load += new System.EventHandler(this.MovieRegistrationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.TextBox tbAmountOfCopies;
        private System.Windows.Forms.TextBox tbMediaType;
        private System.Windows.Forms.TextBox tbActorsList;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbProducer;
        private System.Windows.Forms.CheckBox cbAgeRestriction;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}