namespace UI
{
    partial class CustomerRegistrationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegistrationForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRegistrationData = new System.Windows.Forms.TableLayoutPanel();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.epRegistration = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpRegistrationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tlpRegistrationData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistrate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.730769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.730769F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpRegistrationData
            // 
            this.tlpRegistrationData.ColumnCount = 2;
            this.tlpRegistrationData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRegistrationData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRegistrationData.Controls.Add(this.tbPatronymic, 1, 2);
            this.tlpRegistrationData.Controls.Add(this.tbSurname, 1, 1);
            this.tlpRegistrationData.Controls.Add(this.lblSurname, 0, 1);
            this.tlpRegistrationData.Controls.Add(this.tbFirstName, 1, 0);
            this.tlpRegistrationData.Controls.Add(this.lblFirstName, 0, 0);
            this.tlpRegistrationData.Controls.Add(this.lblPatronymic, 0, 2);
            this.tlpRegistrationData.Controls.Add(this.lblAge, 0, 3);
            this.tlpRegistrationData.Controls.Add(this.tbAge, 1, 3);
            this.tlpRegistrationData.Controls.Add(this.rbtnMale, 1, 4);
            this.tlpRegistrationData.Controls.Add(this.rbtnFemale, 0, 4);
            this.tlpRegistrationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegistrationData.Location = new System.Drawing.Point(3, 40);
            this.tlpRegistrationData.Name = "tlpRegistrationData";
            this.tlpRegistrationData.RowCount = 5;
            this.tlpRegistrationData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRegistrationData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRegistrationData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRegistrationData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRegistrationData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpRegistrationData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRegistrationData.Size = new System.Drawing.Size(576, 472);
            this.tlpRegistrationData.TabIndex = 0;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(291, 191);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(100, 22);
            this.tbPatronymic.TabIndex = 6;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(291, 97);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 22);
            this.tbSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(216, 94);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(291, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(207, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name:";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(203, 188);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(82, 17);
            this.lblPatronymic.TabIndex = 3;
            this.lblPatronymic.Text = "Patronymic:";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(248, 282);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 17);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(291, 285);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 9;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(291, 379);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 21);
            this.rbtnMale.TabIndex = 10;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Checked = true;
            this.rbtnFemale.Location = new System.Drawing.Point(210, 379);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rbtnFemale.TabIndex = 11;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRegistrate.Location = new System.Drawing.Point(245, 518);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(92, 32);
            this.btnRegistrate.TabIndex = 1;
            this.btnRegistrate.Text = "Registrate";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(202, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(178, 37);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Enter customer information";
            // 
            // epRegistration
            // 
            this.epRegistration.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epRegistration.ContainerControl = this;
            // 
            // CustomerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer registration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpRegistrationData.ResumeLayout(false);
            this.tlpRegistrationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRegistration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpRegistrationData;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ErrorProvider epRegistration;
    }
}