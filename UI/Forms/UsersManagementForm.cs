﻿using System;
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
        public event Action DeleteUser;
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegistrateUser?.Invoke();
        }
    }
}
