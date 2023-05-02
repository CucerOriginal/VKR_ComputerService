using System.ComponentModel.DataAnnotations;

namespace Models
{
	/// <summary>
	/// Услуга.
	/// </summary>
	public class Service
	{
		[Key]
		public int Id { get; set; }

		public string ServiceName { get; set; }

		public float Cost { get; set; }
	}
}
