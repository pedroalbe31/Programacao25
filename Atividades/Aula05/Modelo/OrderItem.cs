using System.Diagnostics.Contracts;

namespace Modelo
{
	public class OrderItem
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public Product? Product { get; set; }
		public double Quantity { get; set; }
		public double PurchasePrice { get; set; }
		public bool Validate()
		{
			bool isValid = true;

			isValid = (Id > 0) && 
					  (Name != null) &&
					  (Quantity > 0) &&
					  (PurchasePrice > 0) &&
					  Product != null;

			return isValid;
		}
		
	}
}