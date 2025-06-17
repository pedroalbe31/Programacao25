using Modelo;

namespace Repository
{
	public class OrderRepository
	{
		public Order Retrieve(int Id) //(buscar por ID)
		{
			foreach (Order o in CustomerData.Orders)
				if (o.Id == Id)
					return o;

			return null!;
		}
		public List<Order> RetriveByName(string name)  //(buscar por nome)
		{
			List<Order> ret = [];

			foreach (Order o in CustomerData.Orders)

				if (o.Customer!.Name!.ToLower().Contains(name.ToLower()))
					ret.Add(o);

			return ret;
		}

		public List<Order> RetrieveAll()
		{
			return CustomerData.Orders;
		}

		public void Save(Customer order)
		{
			order.Id = Getcount() + 1;
			CustomerData.Customers.Add(order);
		}

		public bool Delete(Order order)
		{
			return CustomerData.Orders.Remove(order);
		}

		public bool DeleteById(int id)
		{
			Order order = Retrieve(id);

			if (order != null)
				return Delete(order);
			return false;
		}

		public void Update(Order newOrder)
		{
			Order oldOrder= Retrieve(newOrder.Id);
			oldOrder.Id = newOrder.Id;
			oldOrder.Customer = newOrder.Customer;
			oldOrder.OrderDate= newOrder.OrderDate;
			oldOrder.ShippingAddress = newOrder.ShippingAddress;
			oldOrder.OrderItems = newOrder.OrderItems;


		}

		public int Getcount() => CustomerData.Orders.Count;
	}
}