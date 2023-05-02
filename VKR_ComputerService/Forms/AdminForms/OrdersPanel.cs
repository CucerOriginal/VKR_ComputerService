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
	public partial class OrdersPanel : Form
	{
		private ServiceDbContext _dbContext;

		private int _selectedOrderId;

		public OrdersPanel()
		{
			_dbContext = new ServiceDbContext();
			InitializeComponent();
		}

		private void OrdersPanel_Load(object sender, EventArgs e)
		{
			var orders = _dbContext.Orders
				.Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, b => b.Id, (p, b) => new {p.Id, b.Secondname, b.Name, b.Phone, p.CreatedData, p.StartData, p.AtWork, p.IsDone, p.ClientId, p.Note })
				.Join(_dbContext.Clients, p => p.ClientId, b => b.Id, (p, b) => new { p.Id, EmployeeSecondname = p.Secondname, EmployeeName = p.Name, EmployeePhone = p.Phone, p.Note, p.CreatedData, p.StartData, p.AtWork, p.IsDone, ClientSecondname = b.Secondname, ClientName = b.Name, ClientPhone = b.Phonenumber })
				.ToList();
			OrdersDataGridView.DataSource = orders;
		}

		private void OrdersDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				_selectedOrderId = (int)OrdersDataGridView.Rows[e.RowIndex].Cells[0].Value;
			}
			catch (Exception ex) { }

			var orderServices = _dbContext.ServiceOrderMap
				.Where(x => x.OrderId == _selectedOrderId)
				.Join(_dbContext.Services, a => a.ServiceId, b => b.Id, (a, b) => new { b.ServiceName, b.Cost })
				.ToList();
			
			OrderServicesDataGridView.DataSource = orderServices;
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			var orders = _dbContext.Orders
				.Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, b => b.Id, (p, b) => new { p.Id, b.Secondname, b.Name, b.Phone, p.CreatedData, p.StartData, p.AtWork, p.IsDone, p.ClientId, p.Note })
				.Join(_dbContext.Clients, p => p.ClientId, b => b.Id, (p, b) => new { p.Id, EmployeeSecondname = p.Secondname, EmployeeName = p.Name, EmployeePhone = p.Phone, p.Note, p.CreatedData, p.StartData, p.AtWork, p.IsDone, ClientSecondname = b.Secondname, ClientName = b.Name, ClientPhone = b.Phonenumber })
				.ToList();
			OrdersDataGridView.DataSource = orders;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var orders = _dbContext.Orders
				.Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, b => b.Id, (p, b) => new { p.Id, b.Secondname, b.Name, b.Phone, p.CreatedData, p.StartData, p.AtWork, p.IsDone, p.ClientId, p.Note })
				.Join(_dbContext.Clients, p => p.ClientId, b => b.Id, (p, b) => new { p.Id, EmployeeSecondname = p.Secondname, EmployeeName = p.Name, EmployeePhone = p.Phone, p.Note, p.CreatedData, p.StartData, p.AtWork, p.IsDone, ClientSecondname = b.Secondname, ClientName = b.Name, ClientPhone = b.Phonenumber })
				.Where(p=> p.EmployeeSecondname.Contains(SearchTextBox.Text) || p.EmployeeName.Contains(SearchTextBox.Text) || p.EmployeePhone.Contains(SearchTextBox.Text) || p.ClientSecondname.Contains(SearchTextBox.Text) || p.ClientName.Contains(SearchTextBox.Text) || p.ClientPhone.Contains(SearchTextBox.Text) || p.IsDone == IsDoneCheckBox.Checked && p.AtWork == AtWorkCheckBox.Checked)
				.ToList();
			OrdersDataGridView.DataSource = orders;
		}
	}
}
