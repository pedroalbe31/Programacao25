﻿namespace Modelo
{
	public class Product
	{
		public int Id { get; set; }
		public string? ProductName { get; set; }
		public string? Description{ get; set; }
		public double CurrentePrice { get; set; }
		public bool Validate()
		{
			return true;
		}
		public Product Retrieve()
		{
			return new Product();
		}
		public void Save(Product product)
		{
		}
	}
}
