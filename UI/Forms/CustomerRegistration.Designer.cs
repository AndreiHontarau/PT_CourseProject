namespace UI
{
    partial class CustomerRegistration
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateTextBox = new System.Windows.Forms.TextBox();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.RegistrateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.InfoLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SurnameTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PatronymicTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BirthDateTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SexTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RegistrateButton, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.914592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(223, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(135, 17);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = "Enter customer info:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameTextBox.Location = new System.Drawing.Point(216, 91);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(150, 22);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Text = "First name";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameTextBox.Location = new System.Drawing.Point(216, 179);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(150, 22);
            this.SurnameTextBox.TabIndex = 6;
            this.SurnameTextBox.Text = "Surname";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PatronymicTextBox.Location = new System.Drawing.Point(216, 267);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(150, 22);
            this.PatronymicTextBox.TabIndex = 7;
            this.PatronymicTextBox.Text = "Patronymic";
            // 
            // BirthDateTextBox
            // 
            this.BirthDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthDateTextBox.Location = new System.Drawing.Point(216, 355);
            this.BirthDateTextBox.Name = "BirthDateTextBox";
            this.BirthDateTextBox.Size = new System.Drawing.Size(150, 22);
            this.BirthDateTextBox.TabIndex = 8;
            this.BirthDateTextBox.Text = "Birth date";
            // 
            // SexTextBox
            // 
            this.SexTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SexTextBox.Location = new System.Drawing.Point(216, 443);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(150, 22);
            this.SexTextBox.TabIndex = 9;
            this.SexTextBox.Text = "Sex";
            // 
            // RegistrateButton
            // 
            this.RegistrateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RegistrateButton.Location = new System.Drawing.Point(246, 531);
            this.RegistrateButton.Name = "RegistrateButton";
            this.RegistrateButton.Size = new System.Drawing.Size(90, 19);
            this.RegistrateButton.TabIndex = 11;
            this.RegistrateButton.Text = "Registrate";
            this.RegistrateButton.UseVisualStyleBackColor = true;
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRegistration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.TextBox BirthDateTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button RegistrateButton;
    }
}