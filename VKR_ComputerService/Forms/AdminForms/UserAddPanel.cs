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
	public partial class UserAddPanel : Form
	{
		private ServiceDbContext _dbContext;

		public UserAddPanel()
		{
			_dbContext = new ServiceDbContext();
			InitializeComponent();
		}

		private void AddUserButton_Click(object sender, EventArgs e)
		{
			if (_dbContext.ApplicationUsers.FirstOrDefault(p => p.Phone == PhoneTextBox.Text) != null)
			{
				MessageBox.Show("Пользователь с таким номером уже существует");
				return;
			}

			ApplicationUser applicationUser = new ApplicationUser
			{
				Secondname = SecondnameTextBox.Text,
				Name = NameTextBox.Text,
				Middlename = MiddlenameTextBox.Text,
				Phone = PhoneTextBox.Text,
				Password = PasswordTextBox.Text,
				RoleId = 2
			};

			_dbContext.ApplicationUsers.Add(applicationUser);

			_dbContext.SaveChanges();

			MessageBox.Show("Пользователь успешно добавлен");

			this.Close();
		}
	}
}
