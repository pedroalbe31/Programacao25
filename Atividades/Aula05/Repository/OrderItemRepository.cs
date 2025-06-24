using Modelo;

namespace Repository
{
	public class OrderItemRepository
	{
		public OrderItem Retrieve(int Id)
		{
			foreach (OrderItem o in OrderItemData.OrderItens)
				if (o.Id == Id)
					return o;

			return null!;
		}
		public List<OrderItem> RetriveByName(string name)  //(buscar por nome)
		{
			List<OrderItem> ret = new List<OrderItem>();

			foreach (OrderItem o in OrderItemData.OrderItens)

				if (o.OrderItemName!.ToLower().Contains(name.ToLower()))
					ret.Add(o);

			return ret;
		}
		public List<OrderItem> RetrieveAll()
		{
			return OrderItemData.OrderItens;
		}

		public void Save(OrderItem product)
		{
			product.Id = Getcount() + 1;
			OrderItemData.OrderItens.Add(product);
		}

		public bool Delete(OrderItem product)
		{
			return OrderItemData.OrderItens.Remove(product);
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

		public int Getcount() => OrderItemData.Orders.Count;
	}
}