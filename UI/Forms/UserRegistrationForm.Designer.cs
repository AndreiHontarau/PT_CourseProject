namespace UI
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnRegistrate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnManager = new System.Windows.Forms.RadioButton();
            this.rbtnReceptionist = new System.Windows.Forms.RadioButton();
            this.rbtnAdministrator = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNotification, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistrate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPassword.Location = new System.Drawing.Point(341, 183);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(120, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password";
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUserName.Location = new System.Drawing.Point(338, 93);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(126, 22);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "User name";
            // 
            // lblNotification
            // 
            this.lblNotification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(325, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(152, 17);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "Enter user information:";
            // 
            // btnRegistrate
            // 
            this.btnRegistrate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrate.Location = new System.Drawing.Point(341, 410);
            this.btnRegistrate.Name = "btnRegistrate";
            this.btnRegistrate.Size = new System.Drawing.Size(120, 40);
            this.btnRegistrate.TabIndex = 0;
            this.btnRegistrate.Text = "Registrate";
            this.btnRegistrate.UseVisualStyleBackColor = true;
            this.btnRegistrate.Click += new System.EventHandler(this.btnRegistrate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.rbtnManager, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnReceptionist, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnAdministrator, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 273);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(796, 84);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // rbtnManager
            // 
            this.rbtnManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtnManager.AutoSize = true;
            this.rbtnManager.Location = new System.Drawing.Point(90, 3);
            this.rbtnManager.Name = "rbtnManager";
            this.rbtnManager.Size = new System.Drawing.Size(85, 78);
            this.rbtnManager.TabIndex = 1;
            this.rbtnManager.TabStop = true;
            this.rbtnManager.Text = "Manager";
            this.rbtnManager.UseVisualStyleBackColor = true;
            // 
            // rbtnReceptionist
            // 
            this.rbtnReceptionist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtnReceptionist.AutoSize = true;
            this.rbtnReceptionist.Location = new System.Drawing.Point(344, 3);
            this.rbtnReceptionist.Name = "rbtnReceptionist";
            this.rbtnReceptionist.Size = new System.Drawing.Size(107, 78);
            this.rbtnReceptionist.TabIndex = 2;
            this.rbtnReceptionist.TabStop = true;
            this.rbtnReceptionist.Text = "Receptionist";
            this.rbtnReceptionist.UseVisualStyleBackColor = true;
            // 
            // rbtnAdministrator
            // 
            this.rbtnAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtnAdministrator.AutoSize = true;
            this.rbtnAdministrator.Location = new System.Drawing.Point(607, 3);
            this.rbtnAdministrator.Name = "rbtnAdministrator";
            this.rbtnAdministrator.Size = new System.Drawing.Size(112, 78);
            this.rbtnAdministrator.TabIndex = 3;
            this.rbtnAdministrator.TabStop = true;
            this.rbtnAdministrator.Text = "Administrator";
            this.rbtnAdministrator.UseVisualStyleBackColor = true;
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New user registration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRegistrate;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbtnManager;
        private System.Windows.Forms.RadioButton rbtnReceptionist;
        private System.Windows.Forms.RadioButton rbtnAdministrator;
    }
}