using Microsoft.AspNetCore.Mvc;
using Softwarehouse.Models;
using Softwarehouse.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Softwarehouse.Controllers
{
    [Route("/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }
        
        [HttpPost()]
        public ActionResult<Customer> AddCustomer(Customer customer)
        {

             return _customerService.AddCustomer(customer);
        }
    }
}
     
      
