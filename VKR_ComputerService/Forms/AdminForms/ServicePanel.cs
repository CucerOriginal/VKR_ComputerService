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
	public partial class ServicePanel : Form
	{
		private ServiceDbContext _dbContext;

		private int _selectedService;

		public ServicePanel()
		{
			_dbContext = new ServiceDbContext();
			InitializeComponent();
		}

		private void ServicePanel_Load(object sender, EventArgs e)
		{
			ShowServicesOnDataGrid();
		}

		private void ShowServicesOnDataGrid()
		{
			var services = _dbContext.Services
				.ToList();
			ServicesDataGridView.DataSource = services;

			ServicesDataGridView.Columns[0].Visible = false;
		}

		private void AddServiceButton_Click(object sender, EventArgs e)
		{
			if (_dbContext.Services.FirstOrDefault(p => p.ServiceName== AddServiceNameTextBox.Text) != null)
			{
				MessageBox.Show("Севрис с таким названием уже существует");
				return;
			}

			try
			{
				Convert.ToInt32(AddServiceCostTextBox.Text);
			}

			catch (Exception ex)
			{
				MessageBox.Show("Вы вели некорректное поле цены");
				return;
			}

			var servcice = new Service
			{
				ServiceName = AddServiceNameTextBox.Text,

				Cost = Convert.ToInt32(AddServiceCostTextBox.Text)
			};

			_dbContext.Services.Add(servcice);

			_dbContext.SaveChanges();

			MessageBox.Show("Сервич успешно добавлен");

			ShowServicesOnDataGrid();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			_dbContext.SaveChanges();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (_selectedService == 0)
			{
				MessageBox.Show("Услуга не выбрана");
				return;
			}

			var service = _dbContext.Services.FirstOrDefault(p => p.Id == _selectedService);

			if (service == null)
			{
				MessageBox.Show("Услуга с таким Id не существует");
				return;
			}

			_dbContext.Services.Remove(service);
			_dbContext.SaveChanges();

			MessageBox.Show("Услуга успешно удалена");

			ShowServicesOnDataGrid();
		}

		private void ServicesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				_selectedService = (int)ServicesDataGridView.Rows[e.RowIndex].Cells[0].Value;
			}
			catch (Exception ex)
			{

			}
		}
	}
}
