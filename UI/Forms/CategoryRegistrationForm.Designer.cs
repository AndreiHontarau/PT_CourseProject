namespace UI
{
    partial class CategoryRegistrationForm
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
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAddCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CategoryNameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategoryCodeTextBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 203);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddCategory.Location = new System.Drawing.Point(103, 177);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCategory.TabIndex = 0;
            this.buttonAddCategory.Text = "Add category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryNameTextBox.Location = new System.Drawing.Point(91, 3);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.CategoryNameTextBox.TabIndex = 1;
            this.CategoryNameTextBox.Text = "Category name";
            // 
            // CategoryCodeTextBox
            // 
            this.CategoryCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryCodeTextBox.Location = new System.Drawing.Point(91, 70);
            this.CategoryCodeTextBox.Name = "CategoryCodeTextBox";
            this.CategoryCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.CategoryCodeTextBox.TabIndex = 2;
            this.CategoryCodeTextBox.Text = "Category code";
            // 
            // CategoryRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 203);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CategoryRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryRegistration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox CategoryCodeTextBox;
    }
}