﻿namespace Modelo
{
	public class Customer
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? HomeAdress { get; set; }
		public string? WorkAdress{ get; set; }

		public static int InstanceCount = 0;
		public int ObjectCount = 0;

		public bool Validate()
		{
			return true;
		}
		public Customer Retrieve()
		{ 
			return new Customer();
		}
		public void Save(Customer customer)
		{
		}
	}
}