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
    public partial class ClientsPanel : Form
    {
        private ServiceDbContext _dbContext;

        private int _selectedClientId;

        public ClientsPanel()
        {
            _dbContext = new ServiceDbContext();
            InitializeComponent();
            ClientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ClientPanel_Load(object sender, EventArgs e)
        {
            ShowClientsOnDataGrid();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (_selectedClientId == 0)
            {
                MessageBox.Show("Клиент не выбран");
                return;
            }

            new OrderAddPanel(_selectedClientId).ShowDialog();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            new ClientAddPanel().ShowDialog();
        }

        private void ClientsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                _selectedClientId = (int)ClientsDataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception ex)
            {

            }
        }

        private void ShowClientsOnDataGrid()
        {
            var clients = _dbContext.Clients.ToArray();

            ClientsDataGridView.DataSource = clients;
            ClientsDataGridView.Columns[0].Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var clients = _dbContext.Clients
                .Where(p => p.Secondname.Contains(materialTextBoxSearch.Text) || p.Name.Contains(materialTextBoxSearch.Text) || p.Middlename.Contains(materialTextBoxSearch.Text) || p.Phonenumber.Contains(materialTextBoxSearch.Text))
                .ToArray();

            ClientsDataGridView.DataSource = clients;
            ClientsDataGridView.Columns[0].Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ShowClientsOnDataGrid();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (_selectedClientId == 0)
            {
                MessageBox.Show("Клиент не выбран");
                return;
            }

            new UserAddPanel(_selectedClientId).ShowDialog();
            _dbContext = new ServiceDbContext();

            ShowClientsOnDataGrid();
        }
    }
}
