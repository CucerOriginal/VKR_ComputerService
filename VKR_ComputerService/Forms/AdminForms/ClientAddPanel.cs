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

        private Client _clientToChange;

        public ClientAddPanel()
        {
            _dbContext = new ServiceDbContext();
            InitializeComponent();
        }

        public ClientAddPanel(int id) : this()
        {
            _clientToChange = _dbContext.Clients.FirstOrDefault(p => p.Id == id);

            SecondnameTextBox.Text = _clientToChange.Secondname;
            NameTextBox.Text = _clientToChange.Name;
            MiddlenameTextBox.Text = _clientToChange.Middlename;
            PhoneTextBox.Text = _clientToChange.Phonenumber;
            BirthdateTimePicker.Value = new DateTime(_clientToChange.BirthDay.Year, _clientToChange.BirthDay.Month, _clientToChange.BirthDay.Day);

            materialButtonAddClient.Text = "Изменить";
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (_clientToChange != null)
            {
                ChangeClientData();

                MessageBox.Show("Данные успешно изменены");

                this.Close();

                return;
            }

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

        private void ChangeClientData()
        {
            _clientToChange.Secondname = SecondnameTextBox.Text;
            _clientToChange.Name = NameTextBox.Text;
            _clientToChange.Middlename = MiddlenameTextBox.Text;
            _clientToChange.Phonenumber = PhoneTextBox.Text;
            _clientToChange.BirthDay = DateOnly.FromDateTime(BirthdateTimePicker.Value);

            _dbContext.SaveChanges();
        }

        private void ClientAddPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
