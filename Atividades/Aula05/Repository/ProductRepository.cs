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
		public void Save(Product product)
		{
		}
	}
}