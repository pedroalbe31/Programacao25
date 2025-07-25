﻿using Modelo;

namespace Aula05.ViewModels
{
	public class OrderViewModel
	{
		public List<Customer> Customers { get; set; } = [];

		public Customer? CustomerId { get; set; }
		public List<SelectedItem>? SelectedItems { get; set; }

	}
	public class SelectedItem 
	{
		public bool IsSelected { get; set; } = false;
		public OrderItem OrderItem { get; set; } = null!;
	}
}
