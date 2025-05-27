﻿using Modelo;

namespace Repository
{
	public class CustomerRepository
	{
		public Customer Retrieve(int Id) //(buscar por ID)
		{
			foreach (Customer c in CustomerData.Customers)
				if (c.Id == Id)
					return c;

			return null!;
		}
		public List<Customer> RetriveByName(string name)  //(buscar por nome)
		{
			List<Customer> ret = new List<Customer>();

			foreach (Customer c in CustomerData.Customers) 

				if (c.Name!.ToLower().Contains(name.ToLower()))
					ret.Add(c);

			return ret;
		}

		public List<Customer> RetrieveAll()
		{
			return CustomerData.Customers;
		}

		public void Save(Customer customer)
		{
			customer.Id = Getcount() + 1;
			CustomerData.Customers.Add(customer);
		}

		public bool Delete(Customer customer)
		{
			 return CustomerData.Customers.Remove(customer);
		}

		public bool DeleteById(int id)
		{ 
			Customer customer = Retrieve(id);

			if (customer != null)
				 return Delete(customer);
			 return false;
		}

		public void Update(Customer newCustomer)
		{
			Customer oldCustomer = Retrieve(newCustomer.Id);
			oldCustomer.Name = newCustomer.Name;
			oldCustomer.WorkAdress = newCustomer.WorkAdress;
			oldCustomer.HomeAdress = newCustomer.HomeAdress;
		}

		public int Getcount()
		{
			return CustomerData.Customers.Count;
		}
	}
}
