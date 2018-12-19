using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class UsersManagementForm : Form, IUsersManagementView
    {
        private readonly ApplicationContext _context;

        public event EventHandler RegistrateUser;
        public event EventHandler<string> DeleteUser;
        public event EventHandler UpdateTable;
        public event EventHandler Exit;

        public UsersManagementForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void UsersManagementForm_Load(object sender, EventArgs e)
        {
            datagvUsers.ColumnCount = 2;
            datagvUsers.Columns[0].Name = "User name";
            datagvUsers.Columns[1].Name = "User type";

            UpdateTable?.Invoke(sender, e);
        }

        public void ClearTable()
        {
            datagvUsers.Rows.Clear();
        }

        public void ClearUsers()
        {
            foreach (var row in datagvUsers.SelectedRows)
            {
                datagvUsers.Rows.RemoveAt((row as DataGridViewRow).Index);
            }
        }

        public void DisplayRecord(string UserName, string UserType)
        {
            datagvUsers.Rows.Add(UserName, UserType);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegistrateUser?.Invoke(sender, e);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (var row in datagvUsers.SelectedRows)
            {
                DeleteUser?.Invoke(sender, (row as DataGridViewRow).Cells[0].Value.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit?.Invoke(sender, e);
        }
    }
}
