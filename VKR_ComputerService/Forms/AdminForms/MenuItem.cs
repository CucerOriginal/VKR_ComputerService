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
using VKR_ComputerService.Forms.AdminForms;

namespace VKR_ComputerService.Forms
{
    public partial class MenuItem : Form
    {
        private ServiceDbContext _dbContext;

        public MenuItem()
        {
            _dbContext = new ServiceDbContext();
            InitializeComponent();
            OrdersAtWorkDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowOrdersOnDataGrid();
            Customize_Design();
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
                .Where(p => p.EmployeePhone.Contains(materialTextSearch.Text) || p.EmployeeSecondname.Contains(materialTextSearch.Text) || p.EmployeeName.Contains(materialTextSearch.Text) || p.ClientPhone.Contains(materialTextSearch.Text) || p.ClientSecondname.Contains(materialTextSearch.Text) || p.ClientName.Contains(materialTextSearch.Text))
                .ToList();
            OrdersAtWorkDataGridView.DataSource = ordersAtWork;
        }

        private void ServicePanelOpenButton_Click(object sender, EventArgs e)
        {
            new ServicePanel().ShowDialog();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Design
        private void Customize_Design()
        {
            panelClient.Visible = false;
            panelOrders.Visible = false;
            panelServices.Visible = false;
            panelUsers.Visible = false;
        }
        #endregion

        #region PanelMethod
        private void HideSubMenu()
        {
            if (panelClient.Visible == true)
                panelClient.Visible = false;
            if (panelOrders.Visible == true)
                panelOrders.Visible = false;
            if (panelServices.Visible == true)
                panelServices.Visible = false;
            if (panelUsers.Visible == true)
                panelUsers.Visible = false;
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region Panel
        private void Orders_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelOrders);
        }

        private void ShowOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new OrdersPanel());
            HideSubMenu();
        }

        private void ShowUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new UsersPanel());
            HideSubMenu();
        }

        private void ShowClients_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientsPanel());
            HideSubMenu();
        }

        private void ShowServices_Click(object sender, EventArgs e)
        {
            openChildForm(new ServicePanel());
            HideSubMenu();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelUsers);
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelClient);
        }

        private void Services_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelServices);
        }
        #endregion
    }
}
