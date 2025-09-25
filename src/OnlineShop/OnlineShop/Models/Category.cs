using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
	public class Category
	{
		public int Id { get; set; }

		[Required, StringLength(100)]
		public string Name { get; set; }

		// Navigation property
		public ICollection<Product> Products { get; set; } = new List<Product>();
	}
}
