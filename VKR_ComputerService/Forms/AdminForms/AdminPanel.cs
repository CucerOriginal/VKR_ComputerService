using System;
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
    public partial class AdminPanel : Form
    {
        private ServiceDbContext _dbContext;

        public AdminPanel()
        {
            _dbContext = new ServiceDbContext();
            InitializeComponent();
            ShowOrdersOnDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ShowOrdersOnDataGrid();
        }

        private void UpdateOrderDataButton_Click(object sender, EventArgs e)
        {
            ShowOrdersOnDataGrid();
        }

        private void ShowOrdersOnDataGrid()
        {
            var ordersAtWork = _dbContext.Orders
                .Where(p => p.IsDone == false && p.AtWork == true)
                .Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, a => a.Id, (p, a) => new { a.Secondname, a.Name, a.Phone, p.CreatedData, p.StartData, p.AtWork, p.ClientId, p.Note })
                .Join(_dbContext.Clients, p => p.ClientId, a => a.Id, (p, a) => new { EmployeeSecondname = p.Secondname, EmployeeName = p.Name, EmployeePhone = p.Phone, p.Note, p.CreatedData, p.StartData, p.AtWork, ClientSecondname = a.Secondname, ClientName = a.Name, ClientPhone = a.Phonenumber })
                .ToList();
            OrdersAtWorkDataGridView.DataSource = ordersAtWork;
        }

        private void OrdersPanelOpenButton_Click(object sender, EventArgs e)
        {
            new OrdersPanel().ShowDialog();
        }

        private void UserPanelOpenButton_Click(object sender, EventArgs e)
        {
            new UsersPanel().ShowDialog();
        }

        private void CilentsPanelOpenButton_Click(object sender, EventArgs e)
        {
            new ClientsPanel().ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var ordersAtWork = _dbContext.Orders
                .Where(p => p.IsDone == false && p.AtWork == true)
                .Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, a => a.Id, (p, a) => new { a.Secondname, a.Name, a.Phone, p.CreatedData, p.StartData, p.AtWork, p.ClientId, p.Note })
                .Join(_dbContext.Clients, p => p.ClientId, a => a.Id, (p, a) => new { EmployeeSecondname = p.Secondname, EmployeeName = p.Name, EmployeePhone = p.Phone, p.Note, p.CreatedData, p.StartData, p.AtWork, ClientSecondname = a.Secondname, ClientName = a.Name, ClientPhone = a.Phonenumber })
                .Where(p => p.EmployeePhone.Contains(SearchTextBox.Text) || p.EmployeeSecondname.Contains(SearchTextBox.Text) || p.EmployeeName.Contains(SearchTextBox.Text) || p.ClientPhone.Contains(SearchTextBox.Text) || p.ClientSecondname.Contains(SearchTextBox.Text) || p.ClientName.Contains(SearchTextBox.Text))
                .ToList();
            OrdersAtWorkDataGridView.DataSource = ordersAtWork;
        }

        private void ServicePanelOpenButton_Click(object sender, EventArgs e)
        {
            new ServicePanel().ShowDialog();
        }

        private void OrdersPanelOpenButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
