using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKR_ComputerService.DbContextData
{
	public class ServiceDbContext : DbContext
	{
		public ServiceDbContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ComputerService;Username=postgres;Password=postgres");
		}

		public DbSet<ApplicationUser>? ApplicationUsers { get; set; }

		public DbSet<Client> Clients { get; set; }

		public DbSet<Order>? Orders { get; set; }

		public DbSet<Role>? Roles { get; set; }

		public DbSet<Service>? Services { get; set; }

		public DbSet<ServiceOrderMap>? ServiceOrderMap { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ApplicationUser>().HasData(
				new ApplicationUser { Id = 1, Secondname = "Петров", Name = "Сергей", Middlename = "Дмитриевич", Phone = "+79452341354", Password = "Admin", RoleId = 1 },
				new ApplicationUser { Id = 2, Secondname = "Иванов", Name = "Александр", Middlename = "Петрович", Phone = "+79876543210", Password = "User", RoleId = 2 },
				new ApplicationUser { Id = 3, Secondname = "Сидоров", Name = "Денис", Middlename = "Игоревич", Phone = "+79213546870", Password = "User", RoleId = 2 },
				new ApplicationUser { Id = 4, Secondname = "Кузнецов", Name = "Владимир", Middlename = "Алексеевич", Phone = "+79123456789", Password = "User", RoleId = 2 },
				new ApplicationUser { Id = 5, Secondname = "Смирнова", Name = "Анна", Middlename = "Владимировна", Phone = "+79998887766", Password = "User", RoleId = 2 },
				new ApplicationUser { Id = 6, Secondname = "Николаев", Name = "Дмитрий", Middlename = "Сергеевич", Phone = "+79034561209", Password = "User", RoleId = 2 }
				);

			modelBuilder.Entity<Client>().HasData(
				new Client { Id = 1, Secondname = "Смирнова", Name = "Дмитрий", Middlename = "Дмитриевич", BirthDay = new DateOnly(1999, 12, 1), Phonenumber = "+79034331119" },
				new Client { Id = 2, Secondname = "Иванов", Name = "Петр", Middlename = "Андреевич", BirthDay = new DateOnly(1987, 5, 12), Phonenumber = "+79211551010" },
				new Client { Id = 3, Secondname = "Петров", Name = "Андрей", Middlename = "Сергеевич", BirthDay = new DateOnly(1995, 8, 22), Phonenumber = "+79055557788" },
				new Client { Id = 4, Secondname = "Сидорова", Name = "Ольга", Middlename = "Александровна", BirthDay = new DateOnly(1983, 10, 5), Phonenumber = "+79234561234" },
				new Client { Id = 5, Secondname = "Кузнецов", Name = "Андрей", Middlename = "Владимирович", BirthDay = new DateOnly(2001, 2, 28), Phonenumber = "+79111223344" }
				);

			modelBuilder.Entity<Order>().HasData(
				new Order { Id = 1, CreatedData = DateTime.UtcNow, StartData = DateTime.UtcNow.AddDays(1), EndData = DateTime.UtcNow.AddDays(1).AddHours(1), Note = "Не забудь все болты закрутить" , ApplicationUserId = 2, ClientId = 1, IsDone = true, AtWork = false},
				new Order { Id = 2, CreatedData = DateTime.UtcNow, StartData = DateTime.UtcNow.AddDays(2), EndData = DateTime.UtcNow.AddDays(2).AddHours(1), Note = "Оплатить заказ до начала работ", ApplicationUserId = 2, ClientId = 1 , IsDone = true, AtWork = false },
				new Order { Id = 3, CreatedData = DateTime.UtcNow, StartData = DateTime.UtcNow.AddDays(5), EndData = DateTime.UtcNow.AddDays(5).AddHours(1), Note = "Необходимо привезти дополнительный инструмент", ApplicationUserId =  2, ClientId = 1, IsDone = false, AtWork = true },
				new Order { Id = 4, CreatedData = DateTime.UtcNow, StartData = DateTime.UtcNow.AddDays(10), EndData = DateTime.UtcNow.AddDays(10).AddHours(1), Note = "Предоставить отчет о проделанной работе", ApplicationUserId = 4, ClientId = 3, IsDone = false, AtWork = true },
				new Order { Id = 5, CreatedData = DateTime.UtcNow, StartData = DateTime.UtcNow.AddDays(3), EndData = DateTime.UtcNow.AddDays(3).AddHours(1), Note = "Уточнить детали заказа у клиента", ApplicationUserId = 5, ClientId = 4, IsDone = false, AtWork = false }
				);

			modelBuilder.Entity<Role>().HasData(
				new Role { Id = 1, RoleName = "Admin" },
				new Role { Id = 2, RoleName = "Employee" }
				);

			modelBuilder.Entity<Service>().HasData(
				new Service { Id = 1, ServiceName = "Замена термопасты", Cost = 1000 },
				new Service { Id = 2, ServiceName = "Установить антивирус", Cost = 500 },
				new Service { Id = 3, ServiceName = "Установка Windows", Cost = 3000 },
				new Service { Id = 4, ServiceName = "Ремонт материнской платы", Cost = 5000 },
				new Service { Id = 5, ServiceName = "Настройка сети", Cost = 1500 },
				new Service { Id = 6, ServiceName = "Восстановление данных", Cost = 2000 },
				new Service { Id = 7, ServiceName = "Установка Офисных программ", Cost = 800 },
				new Service { Id = 8, ServiceName = "Замена жесткого диска", Cost = 2500 },
				new Service { Id = 9, ServiceName = "Очистка от вирусов", Cost = 1200 },
				new Service { Id = 10, ServiceName = "Установка драйверов", Cost = 600 },
				new Service { Id = 11, ServiceName = "Чистка ноутбука от пыли", Cost = 1500 },
				new Service { Id = 12, ServiceName = "Установка дополнительной оперативной памяти", Cost = 2000 },
				new Service { Id = 13, ServiceName = "Настройка BIOS", Cost = 1000 },
				new Service { Id = 14, ServiceName = "Установка и настройка программы для видеомонтажа", Cost = 3000 }
				);

			modelBuilder.Entity<ServiceOrderMap>().HasData(
				new ServiceOrderMap { Id = 1, ServiceId = 1, OrderId = 1 },
				new ServiceOrderMap { Id = 2, ServiceId = 2, OrderId = 1 },
				new ServiceOrderMap { Id = 3, ServiceId = 3, OrderId = 1 },
				new ServiceOrderMap { Id = 4, ServiceId = 1, OrderId = 2 },
				new ServiceOrderMap { Id = 5, ServiceId = 2, OrderId = 3 },
				new ServiceOrderMap { Id = 6, ServiceId = 1, OrderId = 3 }
				);
		}
	}
}
