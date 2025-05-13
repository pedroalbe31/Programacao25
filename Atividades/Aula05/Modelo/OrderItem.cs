﻿using System.Diagnostics.Contracts;

namespace Modelo
{
	public class OrderItem
	{
		public int Id { get; set; }
		public Product? Product { get; set; }
		public double Quantity { get; set; }
		public double PurchasePrice { get; set; }
		public bool Validate()
		{
			return true;
		}
		public OrderItem Retrieve()
		{
			return new OrderItem();
		}
		public void Save(OrderItem orderItem)
		{
		}
	}
}