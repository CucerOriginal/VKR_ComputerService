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
	public partial class UsersPanel : Form
	{
		private ServiceDbContext _dbContext;

		public UsersPanel()
		{
			_dbContext = new ServiceDbContext();
			InitializeComponent();
		}

		private void UsersPanel_Load(object sender, EventArgs e)
		{
			ShowUsersOnDataGrid();
		}

		private void AddUserButton_Click(object sender, EventArgs e)
		{
			new UserAddPanel().ShowDialog();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			ShowUsersOnDataGrid();
		}

		private void ShowUsersOnDataGrid()
		{
			var users = _dbContext.ApplicationUsers
				.Join(_dbContext.Roles, a => a.RoleId, b => b.Id, (a, b) => new { a.Secondname, a.Name, a.Middlename, b.RoleName, a.Phone, a.Password })
				.ToList();

			UsersDataGridView.DataSource = users;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			var users = _dbContext.ApplicationUsers
				.Join(_dbContext.Roles, a => a.RoleId, b => b.Id, (a, b) => new { a.Secondname, a.Name, a.Middlename, b.RoleName, a.Phone, a.Password })
				.Where(p => p.Secondname.Contains(SearchTextBox.Text) || p.Name.Contains(SearchTextBox.Text) || p.Middlename.Contains(SearchTextBox.Text) || p.Phone.Contains(SearchTextBox.Text) || p.RoleName.Contains(SearchTextBox.Text))
				.ToList();

			UsersDataGridView.DataSource = users;
		}
	}
}
