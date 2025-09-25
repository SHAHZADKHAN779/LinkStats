using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public decimal Price { get; set; }

		public string? Description { get; set; }= string.Empty;

		// Foreign key for Category
		public int CategoryId { get; set; }

		public int Quantity { get; set; } = 0;
	}
}
