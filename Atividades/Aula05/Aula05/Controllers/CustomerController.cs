using Microsoft.AspNetCore.Mvc;
using Modelo;
using Repository;
using System.IO;

namespace Aula05.Controllers
{
	public class CustomerController : Controller
	{
		private readonly IWebHostEnvironment environment;

		private CustomerRepository _customerRepository;

		public CustomerController(
			IWebHostEnvironment environment
		)
		{
			_customerRepository = new CustomerRepository();
			this.environment = environment;
		}

		[HttpGet]
		public IActionResult Index()
		{
			List<Customer> customers = _customerRepository.RetrieveAll();

			return View(customers);
		}

		[HttpPost]
		public IActionResult Create(Customer c)
		{
			_customerRepository.Save(c);

			List<Customer> customers = _customerRepository.RetrieveAll();

			return View("Index", customers);

		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpGet]
		public IActionResult ExportDelimitatedFile()
		{
			string fileContent = string.Empty;

			foreach (Customer c in CustomerData.Customers)
			{
				fileContent += 
					@$"{c.Id};
						{c.Name};
						{c.HomeAdress!.Id};
						{c.HomeAdress.City};
						{c.HomeAdress.State};
						{c.HomeAdress.Country};
						{c.HomeAdress.StreetLine1};
						{c.HomeAdress.StreetLine2};
						{c.HomeAdress.PostalCode};
						{c.HomeAdress.AddressType}
						\n
					";
			}

			var path = Path.Combine(
				environment.WebRootPath,
				"TextFiles"
			);

			if(!System.IO.Directory.Exists(path))
				System.IO.Directory.CreateDirectory(path);


			var filepath = Path.Combine(
				path,
				"Delimitado.txt"
			);

			if (!System.IO.File.Exists(filepath))
			{
				using (StreamWriter sw = System.IO.File.CreateText(filepath))
				{
					sw.Write(fileContent);
				}
			}

			return View();
		}
	}
}