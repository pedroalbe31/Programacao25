﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Repository
{
	internal class OrderItemData
	{
		public static List<Customer> Customers { get; set; } = [];
		public static List<Product> Products { get; set; } = [];
		public static List<Order> Orders { get; set; } = [];
		public static List<OrderItem> OrderItens { get; set; } = [];
		public static List<OrderItem> OrderItemName { get; set; } = [];
	}
}
