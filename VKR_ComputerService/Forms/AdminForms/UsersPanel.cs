﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKR_ComputerService.DbContextData;

namespace VKR_ComputerService.Forms.AdminForms
{
    public partial class UsersPanel : Form
    {
        private ServiceDbContext _dbContext;

        int _selectedUserId;

        public UsersPanel()
        {
            _dbContext = new ServiceDbContext();
            InitializeComponent();
            UsersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UsersPanel_Load(object sender, EventArgs e)
        {
            ShowUsersOnDataGrid();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            new UserAddPanel().ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ShowUsersOnDataGrid();
        }

        private void ShowUsersOnDataGrid()
        {
            var users = _dbContext.ApplicationUsers
                .Join(_dbContext.Roles, a => a.RoleId, b => b.Id, (a, b) => new { a.Id, a.Secondname, a.Name, a.Middlename, b.RoleName, a.Phone, a.Password })
                .ToList();

            UsersDataGridView.DataSource = users;
            UsersDataGridView.Columns[0].Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var users = _dbContext.ApplicationUsers
                .Join(_dbContext.Roles, a => a.RoleId, b => b.Id, (a, b) => new { a.Id, a.Secondname, a.Name, a.Middlename, b.RoleName, a.Phone, a.Password })
                .Where(p => p.Secondname.Contains(materialTextBoxSearch.Text) || p.Name.Contains(materialTextBoxSearch.Text) || p.Middlename.Contains(materialTextBoxSearch.Text) || p.Phone.Contains(materialTextBoxSearch.Text) || p.RoleName.Contains(materialTextBoxSearch.Text))
                .ToList();

            UsersDataGridView.DataSource = users;
            UsersDataGridView.Columns[0].Visible = false;
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }

            var user = _dbContext.ApplicationUsers.FirstOrDefault(p => p.Id == _selectedUserId);

            if (user == null)
            {
                MessageBox.Show("Пользователя с таким Id не существует");
                return;
            }

            _dbContext.ApplicationUsers.Remove(user);
            _dbContext.SaveChanges();

            MessageBox.Show("Пользователь успешно удалена");

            ShowUsersOnDataGrid();
        }

        private void UsersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                _selectedUserId = (int)UsersDataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == 0)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }

            new UserAddPanel(_selectedUserId).ShowDialog();
            _dbContext = new ServiceDbContext();

            ShowUsersOnDataGrid();
        }
    }
}
