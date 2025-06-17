using Modelo;

namespace Repository
{
	public class OrderItem
	{
		public OrderItem Retrieve(int Id)
		{
			foreach (OrderItem p in OrderItemData.OrderItems)
				if (p.Id == Id)
					return p;

			return null!;
		}
		public List<OrderItem> RetriveByName(string name)  //(buscar por nome)
		{
			List<OrderItem> ret = new List<OrderItem>();

			foreach (OrderItem p in OrderItemData.OrderItems)

				if (p.OrderItemName!.ToLower().Contains(name.ToLower()))
					ret.Add(p);

			return ret;
		}
		public List<OrderItem> RetrieveAll()
		{
			return OrderItemData.OrderItems;
		}

		public void Save(OrderItem product)
		{
			product.Id = Getcount() + 1;
			OrderItemData.OrderItems.Add(product);
		}

		public bool Delete(OrderItem product)
		{
			return OrderItemData.OrderItems.Remove(product);
		}

		public bool DeleteById(int id)
		{
			OrderItem product = Retrieve(id);

			if (product != null)
				return Delete(product);
			return false;
		}

		public void Update(OrderItem newOrderItem)
		{
			OrderItem oldOrderItem = Retrieve(newOrderItem.Id);
			oldOrderItem.Id = newOrderItem.Id;

		}

		public int Getcount() => CustomerData.Orders.Count;
	}
}