using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class ApplicationUser
	{
		[Key]
		public int Id { get; set; }

		public string Secondname { get; set; }

		public string Name { get; set; }

		public string Middlename { get; set; }

		public string Phone { get; set; }

		public string Password { get; set; }

		public Role? Role { get; set; }

		public int RoleId { get; set; }

		public IList<Order>? Orders { get; set; }
	}
}
