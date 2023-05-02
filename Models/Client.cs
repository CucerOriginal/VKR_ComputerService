using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Client
	{
		[Key]
		public int Id { get; set; }

		public string Secondname { get; set; }

		public string Name { get; set; }

		public string Middlename { get; set; }

		public string Phonenumber { get; set; }

		public DateOnly BirthDay { get; set; }

		public IList<Order> Orders { get; set; }
	}
}
