using Microsoft.AspNetCore.Mvc;
using Softwarehouse.Models;
using Softwarehouse.Services;

namespace Softwarehouse.Controllers
{
    [Route("/ShoppingCart")]
    [ApiController]
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCartService _shoppingCartService;

        public ShoppingCartController(ShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        // POST: ShoppingCartController/Create
        [HttpPost()]
        public ActionResult<ShoppingCart> GetCart()
        {
            var shoppingcart = _shoppingCartService.GetCart();
            return Ok(shoppingcart);
            
        }
    }
}
