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
	public partial class ClientAddPanel : Form
	{
		private ServiceDbContext _dbContext;

		public ClientAddPanel()
		{
			_dbContext = new ServiceDbContext();
			InitializeComponent();
		}

		private void AddClientButton_Click(object sender, EventArgs e)
		{
			if (_dbContext.Clients.FirstOrDefault(p => p.Phonenumber == PhoneTextBox.Text) != null)
			{
				MessageBox.Show("Клиент с таким номером уже существует");
				return;
			}

			var client = new Client
			{
				Secondname = SecondnameTextBox.Text,
				Name = NameTextBox.Text,
				Middlename = MiddlenameTextBox.Text,
				Phonenumber = PhoneTextBox.Text,
				BirthDay = DateOnly.FromDateTime(BirthdateTimePicker.Value)
			};

			_dbContext.Clients.Add(client);

			_dbContext.SaveChanges();

			MessageBox.Show("Клиент успешно добавлен");

			this.Close();
		}

		private void ClientAddPanel_Load(object sender, EventArgs e)
		{

		}
	}
}
