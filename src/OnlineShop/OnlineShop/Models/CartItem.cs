namespace OnlineShop.Models
{
	public class CartItem
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal UnitPrice { get; set; }
		public int Quantity { get; set; }

		public decimal Total => UnitPrice * Quantity;
	}
}
