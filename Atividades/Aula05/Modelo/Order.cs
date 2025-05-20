namespace Modelo
{
	public class Order
	{
		#region Atributos
		public int Id { get; set; }
		public Customer? Customer { get; set; }
		public DateTime OrderDate { get; set; }
		public Address? ShippingAddress { get; set; }
		public List<OrderItem>? OrderItems { get; set; }
		#endregion

		public Order()
		{
			OrderDate = DateTime.Now;
			OrderItems = new List<OrderItem>();
		}

		public Order(int orderId, Address address) : this()
		{
			this.Id = orderId;
		}

		public bool Validate()
		{
			bool isValid = true;

			isValid = (this.Id > 0);

			return isValid;
		}
	}
}
