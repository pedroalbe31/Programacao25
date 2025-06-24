﻿using System.Xml;
using Aula05.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Modelo;

namespace Aula05.Controllers
{
	public class OrderController : Controller
	{
		private readonly IWebHostEnvironment environment;
		private readonly OrderRepository _orderRepository;
		private readonly CustomerRepository _customerRepository;
		private readonly ProductRepository _productRepository;

		public OrderController(IWebHostEnvironment environment)
		{
			this.environment = environment;
			_orderRepository = new OrderRepository();
			_customerRepository = new CustomerRepository();
			_productRepository = new ProductRepository();
		}
		
		[HttpGet]
		public IActionResult Index()
		{
			return View(_orderRepository.RetrieveAll());
		}

		[HttpGet]
		public IActionResult Create()
		{
			OrderViewModel viewModel = new ();
			viewModel.Customers = _customerRepository.RetrieveAll();

			var products = _productRepository.RetrieveAll();
			List<SelectedItem> Items = [];
			foreach (var product in products)
			{
				Items.Add(new SelectedItem()
				{
					OrderItem = new() {
						Product = product
					}
				});
			}

			viewModel.SelectedItems = Items;

			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Create(OrderViewModel model)
		{
			Order order = new Order();
			order.Customer = _customerRepository.RetrieveAll(model.CustomerId.Value);
			order.OrderData = DateTime.Now;

			foreach (var item in model.SelectedItems!)
			{
				if (item.IsSelected)
				{
					order.OrderItems.Add(
						new OrderItem()
						{
							Id = count,
							Product = _productRepository.Retrieve(item.OrderItem.Product!.Id),
							Quantity = item.OrderItem.Quantity,
							PurchasePrice = item.OrderItem.PurchasePrice
						}
						);


					count++;
				}
			}


			_orderRepository.Save(order);

			return RedirectToAction("Index");
		}
	}
}
