using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Repository
{
	internal class ProductData
	{
		public static List<Product> Products { get; set; } = [];
		public static List<Product> Description { get; set; } = [];
		public static List<Product> CurrentPrice { get; set; } = [];
	}
}
