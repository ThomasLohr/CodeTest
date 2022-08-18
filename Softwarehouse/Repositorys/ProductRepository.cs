using Softwarehouse.Models;

namespace Softwarehouse.Repositorys
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> productList = new List<Product>()
            {
            new Product(1,"Wine", 10,  25.22m ),
            new Product(2,"Soda", 3, 40.22m ),
            new Product(3,"Cornflakes", 5, 30.22m )
            };
            return productList;
        }



    }
}
