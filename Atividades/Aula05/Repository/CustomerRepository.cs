using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Repository
{
	public class CustomerRepository
	{
		public Customer Retrieve(int orderId)
		{
			return new Customer();
		}
		public void Save(Customer customer)
		{
		}
	}
}
