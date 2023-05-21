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
using VKR_ComputerService.Forms;

namespace VKR_ComputerService
{
    public partial class Login : Form
    {
        private ServiceDbContext _dbContext;

        public Login()
        {
            _dbContext = new ServiceDbContext();
            InitializeComponent();
        }

        private void LogOnButton_Click(object sender, EventArgs e)
        {
            var user = _dbContext.ApplicationUsers.FirstOrDefault(p => p.Phone == LoginTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Такого пользователя не существует");
                return;
            }

            if (user.Password != PasswordTextBox.Text)
            {
                MessageBox.Show("Неправильный пароль");
                return;
            }

            _ = user.RoleId == 1
                ? new MenuItem().ShowDialog()
                : new EmployeePanel(user.Id).ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
