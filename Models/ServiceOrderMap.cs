using System.ComponentModel.DataAnnotations;

namespace Models
{
	/// <summary>
	/// Поокладка между заказом и услугой.
	/// Если для одного заказа нужно будет выпонить несколько услуг.
	/// </summary>
	public class ServiceOrderMap
	{
		[Key]
		public int Id { get; set; }

		public int OrderId { get; set; }

		public int ServiceId { get; set; }
	}
}
