using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace UI
{
    public partial class UsersManagementForm : Form, IUsersManagementView
    {
        private readonly ApplicationContext _context;

        public event Action RegistrateUser;
        public event Action<string> DeleteUser;
        public event Action UpdateTable;
        public event Action Exit;

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

            UpdateTable?.Invoke();
        }

        public void ClearTable()
        {
            datagvUsers.Rows.Clear();
        }

        public void ClearUser()
        {
            datagvUsers.Rows.RemoveAt(datagvUsers.SelectedRows[0].Index);
        }

        public void DisplayRecord(string UserName, string UserType)
        {
            datagvUsers.Rows.Add(UserName, UserType);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegistrateUser?.Invoke();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser?.Invoke(datagvUsers.Rows[datagvUsers.SelectedRows[0].Index].Cells[0].Value.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit?.Invoke();
        }
    }
}
