using Models;
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
	public partial class OrderAddPanel : Form
	{
		private ServiceDbContext _dbContext;

		private List<Service> _servicesArray = new List<Service>();

		private int _clientId;
		private int _selectedEmployee;
		private int _selectedService;

		public OrderAddPanel(int clientId)
		{
			_dbContext = new ServiceDbContext();

			_clientId = clientId;
			InitializeComponent();
		}

		private void OrderAddPanel_Load(object sender, EventArgs e)
		{
			NoteTextBox.AutoSize = false;
			NoteTextBox.Size = new Size(200, 200);

			var employees = _dbContext.ApplicationUsers
				.Join(_dbContext.Roles, a => a.RoleId, b => b.Id, (a, b) => new { a.Id, a.Secondname, a.Name, a.Middlename, b.RoleName, a.Phone })
				.Where(x => x.RoleName != "Admin")
				.ToList();

			EmployeeDataGridView.DataSource = employees;

			var service = _dbContext.Services.ToList();

			ServicesDataGridView.DataSource = service;
		}

		private void AddOrderButton_Click(object sender, EventArgs e)
		{
			if (_selectedEmployee == 0)
			{
				MessageBox.Show("Исполнитель не выбран");
				return;
			}

			if (_servicesArray.Count == 0)
			{
				MessageBox.Show("Услуги не выбраны");
				return;
			}

			var order = new Order
			{
				CreatedData = DateTime.UtcNow,
				Note = NoteTextBox.Text,
				ApplicationUserId = _selectedEmployee,
				ClientId = _clientId,
			};

			_dbContext.Orders.Add(order);

			_dbContext.SaveChanges();

			foreach (var service in _servicesArray)
			{
				var serviceOrderMap = new ServiceOrderMap
				{
					OrderId = order.Id,
					ServiceId = service.Id,
				};

				_dbContext.ServiceOrderMap.Add(serviceOrderMap);
			}

			_dbContext.SaveChanges();

			MessageBox.Show("Заказ добавлен");

			this.Close();
		}

		private void EmployeeDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				_selectedEmployee = (int)EmployeeDataGridView.Rows[e.RowIndex].Cells[0].Value;
			}
			catch (Exception ex)
			{

			}
		}

		private void ServicesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			_selectedService = (int)ServicesDataGridView.Rows[e.RowIndex].Cells[0].Value;
		}

		private void AddServiceToOrderButton_Click(object sender, EventArgs e)
		{
			if (_selectedService == 0)
			{
				MessageBox.Show("Выберите сервис");
				return;
			}

			var service = _dbContext.Services.FirstOrDefault(x => x.Id == _selectedService);

			if (service == null)
			{
				MessageBox.Show("Сервис не найден");
				return;
			}

			_servicesArray.Add(service);

			AddedServicesToOrderDataGridView.DataSource = null;
			AddedServicesToOrderDataGridView.DataSource = _servicesArray;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var employees = _dbContext.ApplicationUsers
				.Join(_dbContext.Roles, a => a.RoleId, b => b.Id, (a, b) => new { a.Id, a.Secondname, a.Name, a.Middlename, b.RoleName, a.Phone, a.Password })
				.Where(p=> p.Secondname.Contains(SearchTextBox.Text) || p.Name.Contains(SearchTextBox.Text) || p.Middlename.Contains(SearchTextBox.Text) || p.Phone.Contains(SearchTextBox.Text) || p.RoleName.Contains(SearchTextBox.Text))
				.ToList();

			EmployeeDataGridView.DataSource = employees;
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			var employees = _dbContext.ApplicationUsers
				.Join(_dbContext.Roles, a => a.RoleId, b => b.Id, (a, b) => new { a.Id, a.Secondname, a.Name, a.Middlename, b.RoleName, a.Phone, a.Password })
				.ToList();

			EmployeeDataGridView.DataSource = employees;
		}
	}
}
