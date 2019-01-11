namespace UI
{
    partial class RentsManagmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentsManagmentForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lateness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerInfoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddRentButton = new System.Windows.Forms.Button();
            this.DeleteRentButton = new System.Windows.Forms.Button();
            this.PrintToExelButton = new System.Windows.Forms.Button();
            this.PrintToWordButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmID,
            this.FilmTitle,
            this.DateOfIssue,
            this.ReturnDate,
            this.Lateness,
            this.Price,
            this.Penalties,
            this.Total});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 264);
            this.dataGridView1.TabIndex = 2;
            // 
            // FilmID
            // 
            this.FilmID.HeaderText = "Film ID";
            this.FilmID.Name = "FilmID";
            this.FilmID.ReadOnly = true;
            // 
            // FilmTitle
            // 
            this.FilmTitle.HeaderText = "Film title";
            this.FilmTitle.Name = "FilmTitle";
            this.FilmTitle.ReadOnly = true;
            // 
            // DateOfIssue
            // 
            this.DateOfIssue.HeaderText = "Date of issue";
            this.DateOfIssue.Name = "DateOfIssue";
            this.DateOfIssue.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // Lateness
            // 
            this.Lateness.HeaderText = "Lateness";
            this.Lateness.Name = "Lateness";
            this.Lateness.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Penalties
            // 
            this.Penalties.HeaderText = "Penalties";
            this.Penalties.Name = "Penalties";
            this.Penalties.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.CustomerInfoLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 174);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // CustomerInfoLabel
            // 
            this.CustomerInfoLabel.AutoSize = true;
            this.CustomerInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.CustomerInfoLabel.Name = "CustomerInfoLabel";
            this.CustomerInfoLabel.Size = new System.Drawing.Size(91, 17);
            this.CustomerInfoLabel.TabIndex = 0;
            this.CustomerInfoLabel.Text = "CustomerInfo";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.AddRentButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DeleteRentButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.PrintToExelButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.PrintToWordButton, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(638, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(153, 168);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // AddRentButton
            // 
            this.AddRentButton.Location = new System.Drawing.Point(3, 3);
            this.AddRentButton.Name = "AddRentButton";
            this.AddRentButton.Size = new System.Drawing.Size(70, 23);
            this.AddRentButton.TabIndex = 0;
            this.AddRentButton.Text = "Add rent";
            this.AddRentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteRentButton
            // 
            this.DeleteRentButton.Location = new System.Drawing.Point(79, 3);
            this.DeleteRentButton.Name = "DeleteRentButton";
            this.DeleteRentButton.Size = new System.Drawing.Size(71, 23);
            this.DeleteRentButton.TabIndex = 1;
            this.DeleteRentButton.Text = "Delete rent";
            this.DeleteRentButton.UseVisualStyleBackColor = true;
            // 
            // PrintToExelButton
            // 
            this.PrintToExelButton.Location = new System.Drawing.Point(3, 87);
            this.PrintToExelButton.Name = "PrintToExelButton";
            this.PrintToExelButton.Size = new System.Drawing.Size(70, 68);
            this.PrintToExelButton.TabIndex = 2;
            this.PrintToExelButton.Text = "Print card to Exel";
            this.PrintToExelButton.UseVisualStyleBackColor = true;
            // 
            // PrintToWordButton
            // 
            this.PrintToWordButton.Location = new System.Drawing.Point(79, 87);
            this.PrintToWordButton.Name = "PrintToWordButton";
            this.PrintToWordButton.Size = new System.Drawing.Size(71, 68);
            this.PrintToWordButton.TabIndex = 3;
            this.PrintToWordButton.Text = "Print card to Word";
            this.PrintToWordButton.UseVisualStyleBackColor = true;
            // 
            // RentsManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentsManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Rental - Rents managment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lateness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label CustomerInfoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button AddRentButton;
        private System.Windows.Forms.Button DeleteRentButton;
        private System.Windows.Forms.Button PrintToExelButton;
        private System.Windows.Forms.Button PrintToWordButton;
    }
}