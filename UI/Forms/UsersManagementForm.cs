using System;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class UsersManagementForm : Form, IUsersManagementView
    {
        private readonly ApplicationContext _context;

        public event EventHandler RegistrateUser;
        public event EventHandler<string> DeleteUser;
        public event EventHandler LoadTable;
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

            LoadTable?.Invoke(sender, e);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegistrateUser?.Invoke(sender, e);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagvUsers.SelectedRows)
            {
                DeleteUser?.Invoke(sender, row.Cells[0].Value.ToString());

                datagvUsers.Rows.RemoveAt(row.Index);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit?.Invoke(sender, e);
        }

        public void ClearTable()
        {
            datagvUsers.Rows.Clear();
        }

        public void DisplayRecord(string UserName, string UserType)
        {
            datagvUsers.Rows.Add(UserName, UserType);
        }
    }
}
