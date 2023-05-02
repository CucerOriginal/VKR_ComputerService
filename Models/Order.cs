using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	/// <summary>
	/// Заказ.
	/// </summary>
	public class Order
	{
		[Key]
		public int Id { get; set; }

		public DateTime CreatedData { get; set; }

		public DateTime StartData { get; set; }

		public DateTime EndData { get; set; }

		/// <summary>
		/// Примечание.
		/// </summary>
		public string Note { get; set; }

		/// <summary>
		/// Сделан ли заказ.
		/// </summary>
		public bool IsDone { get; set; }

		/// <summary>
		/// Показывет начали ли выполнять этот заказ.
		/// Если свойство IsDone = true, это поле принимает значение false.
		/// </summary>
		public bool AtWork { get; set; }

		/// <summary>
		/// Исполнитель заказа.
		/// </summary>
		public int ApplicationUserId { get; set; }

		/// <summary>
		/// Исполнитель заказа.
		/// </summary>
		public ApplicationUser? ApplicationUser { get; set; }

		public int ClientId { get; set; }

		public Client? Client { get; set; }

		public IList<ServiceOrderMap>? ServiceOrderMaps { get; set; }
	}
}
