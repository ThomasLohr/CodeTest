using Microsoft.AspNetCore.Mvc;
using Softwarehouse.Models;
using Softwarehouse.Repositorys;

namespace Softwarehouse.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return products;
        }
    }
}
