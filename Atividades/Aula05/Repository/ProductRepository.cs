using Modelo;

namespace Repository
{
	public class ProductRepository
	{
		public Product Retrieve(int Id)
		{
			foreach (Product p in ProductData.Products)
				if (p.Id == Id)
					return p;

			return null!;
		}
		public List<Product> RetriveByName(string name)  //(buscar por nome)
		{
			List<Product> ret = new List<Product>();

			foreach (Product p in ProductData.Products)

				if (p.ProductName!.ToLower().Contains(name.ToLower()))
					ret.Add(p);

			return ret;
		}
		public List<Product> RetrieveAll()
		{
			return ProductData.Products;
		}

		public void Save(Product product)
		{
			product.Id = Getcount() + 1;
			ProductData.Products.Add(product);
		}

		public bool Delete(Product product)
		{
			return ProductData.Products.Remove(product);
		}

		public bool DeleteById(int id)
		{
			Product product = Retrieve(id);

			if (product != null)
				return Delete(product);
			return false;
		}

		public void Update(Product newProduct)
		{
			Product oldProduct= Retrieve(newProduct.Id);
			oldProduct.Id = newProduct.Id;

		}

		public int Getcount() => CustomerData.Orders.Count;
	}
}