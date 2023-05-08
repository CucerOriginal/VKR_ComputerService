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

namespace VKR_ComputerService.Forms
{
	public partial class EmployeePanel : Form
	{
		private ServiceDbContext _dbContext;

		private int _selectedOrderId;

		private int _userId;

		public EmployeePanel(int userId)
		{
			_userId = userId;
			_dbContext = new ServiceDbContext();
			InitializeComponent();
		}

		private void EmployeePanel_Load(object sender, EventArgs e)
		{
			ShowOrdersOnDataGrid();
		}

		private void ShowOrdersOnDataGrid()
		{
			var ordersInPlan = _dbContext.Orders
				.Where(p=> p.ApplicationUserId == _userId)
				.Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, b => b.Id, (p, b) => new { p.Id, p.CreatedData, p.StartData, p.AtWork, p.IsDone, p.ClientId, p.Note })
				.Join(_dbContext.Clients, p => p.ClientId, b => b.Id, (p, b) => new { p.Id, p.Note, p.CreatedData, p.StartData, p.AtWork, p.IsDone, ClientSecondname = b.Secondname, ClientName = b.Name, ClientPhone = b.Phonenumber })
				.Where(p => p.IsDone == false && p.AtWork == false)
				.ToList();

			OrdersInPlanDataGridView.DataSource = ordersInPlan;

			var ordersAtWork = _dbContext.Orders
				.Where(p => p.ApplicationUserId == _userId)
				.Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, b => b.Id, (p, b) => new { p.Id, p.CreatedData, p.StartData, p.AtWork, p.IsDone, p.ClientId, p.Note })
				.Join(_dbContext.Clients, p => p.ClientId, b => b.Id, (p, b) => new { p.Id, p.Note, p.CreatedData, p.StartData, p.AtWork, p.IsDone, ClientSecondname = b.Secondname, ClientName = b.Name, ClientPhone = b.Phonenumber })
				.Where(p => p.IsDone == false && p.AtWork == true)
				.ToList();

			OrdersAtWorkDataGridView.DataSource = ordersAtWork;

			var ordersIsDone = _dbContext.Orders
				.Where(p => p.ApplicationUserId == _userId)
				.Join(_dbContext.ApplicationUsers, p => p.ApplicationUserId, b => b.Id, (p, b) => new { p.Id, p.CreatedData, p.StartData, p.EndData, p.AtWork, p.IsDone, p.ClientId, p.Note })
				.Join(_dbContext.Clients, p => p.ClientId, b => b.Id, (p, b) => new { p.Id, p.Note, p.CreatedData, p.StartData, p.EndData, p.AtWork, p.IsDone, ClientSecondname = b.Secondname, ClientName = b.Name, ClientPhone = b.Phonenumber })
				.Where(p => p.IsDone == true && p.AtWork == false)
				.ToList();

			OrdersIsDoneDataGridView.DataSource = ordersIsDone;
		}

		private void OrdersInPlanDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				_selectedOrderId = (int)OrdersInPlanDataGridView.Rows[e.RowIndex].Cells[0].Value;
			}
			catch (Exception ex) { }

			var orderServices = _dbContext.ServiceOrderMap
				.Where(x => x.OrderId == _selectedOrderId)
				.Join(_dbContext.Services, a => a.ServiceId, b => b.Id, (a, b) => new { b.ServiceName, b.Cost })
				.ToList();

			OrderServicesDataGridView.DataSource = orderServices;
		}

		private void MoveToAtWorkButton_Click(object sender, EventArgs e)
		{
			if (_selectedOrderId == 0)
			{
				MessageBox.Show("Выберите заказ");
				return;
			}

			var order = _dbContext.Orders
				.FirstOrDefault(p=> p.Id == _selectedOrderId);

			if (order == null)
			{
				MessageBox.Show("Заказ с таким id не найден");
				return;
			}

			order.AtWork = true;
			order.StartData = DateTime.UtcNow;
			order.IsDone = false;

			_dbContext.SaveChanges();

			ShowOrdersOnDataGrid();
		}

		private void MoveToPlanButton_Click(object sender, EventArgs e)
		{
			if (_selectedOrderId == 0)
			{
				MessageBox.Show("Выберите заказ");
				return;
			}

			var order = _dbContext.Orders
				.FirstOrDefault(p => p.Id == _selectedOrderId);

			if (order == null)
			{
				MessageBox.Show("Заказ с таким id не найден");
				return;
			}

			order.AtWork = false;
			order.IsDone = false;

			_dbContext.SaveChanges();

			ShowOrdersOnDataGrid();
		}

		private void OrdersAtWorkDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				_selectedOrderId = (int)OrdersAtWorkDataGridView.Rows[e.RowIndex].Cells[0].Value;
			}
			catch (Exception ex) { }

			var orderServices = _dbContext.ServiceOrderMap
				.Where(x => x.OrderId == _selectedOrderId)
				.Join(_dbContext.Services, a => a.ServiceId, b => b.Id, (a, b) => new { b.ServiceName, b.Cost })
				.ToList();

			OrderServicesDataGridView.DataSource = orderServices;
		}

		private void MoveToDoneButton_Click(object sender, EventArgs e)
		{
			if (_selectedOrderId == 0)
			{
				MessageBox.Show("Выберите заказ");
				return;
			}

			var order = _dbContext.Orders
				.FirstOrDefault(p => p.Id == _selectedOrderId);

			if (order == null)
			{
				MessageBox.Show("Заказ с таким id не найден");
				return;
			}

			order.AtWork = false;
			order.EndData = DateTime.UtcNow;
			order.IsDone = true;

			_dbContext.SaveChanges();

			ShowOrdersOnDataGrid();
		}

		private void OrdersIsDoneDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				_selectedOrderId = (int)OrdersIsDoneDataGridView.Rows[e.RowIndex].Cells[0].Value;
			}
			catch (Exception ex) { }

			var orderServices = _dbContext.ServiceOrderMap
				.Where(x => x.OrderId == _selectedOrderId)
				.Join(_dbContext.Services, a => a.ServiceId, b => b.Id, (a, b) => new { b.ServiceName, b.Cost })
				.ToList();

			OrderServicesDataGridView.DataSource = orderServices;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
