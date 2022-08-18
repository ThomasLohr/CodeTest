using Softwarehouse.Models;
using Softwarehouse.Repositorys;

namespace Softwarehouse.Services
{
    public class ShoppingCartService
    {
        private readonly ShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(ShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }
        public ShoppingCart GetCart()
        {
            return _shoppingCartRepository.GetCart();

        }
    }
}
