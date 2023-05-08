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

		private ApplicationUser _userToChange;

		public UserAddPanel(int id) : this()
		{
			_userToChange = _dbContext.ApplicationUsers.FirstOrDefault(p => p.Id == id);

			SecondnameTextBox.Text = _userToChange.Secondname;
			NameTextBox.Text = _userToChange.Name;
			MiddlenameTextBox.Text = _userToChange.Middlename;
			PhoneTextBox.Text = _userToChange.Phone;
			PasswordTextBox.Text = _userToChange.Password;

			AddUserButton.Text = "Изменить";
		}

		public UserAddPanel()
		{
			_dbContext = new ServiceDbContext();
			InitializeComponent();
		}

		private void AddUserButton_Click(object sender, EventArgs e)
		{
			if (_userToChange != null)
			{
				ChangeUserData();

				MessageBox.Show("Данные успешно изменены");

				this.Close();

				return;
			}

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

		private void ChangeUserData()
		{
			_userToChange.Secondname = SecondnameTextBox.Text;
			_userToChange.Name = NameTextBox.Text;
			_userToChange.Middlename = MiddlenameTextBox.Text;
			_userToChange.Phone = PhoneTextBox.Text;
			_userToChange.Password = PasswordTextBox.Text;

			_dbContext.SaveChanges();
		}
	}
}
