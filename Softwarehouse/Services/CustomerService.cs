using Microsoft.AspNetCore.Mvc;
using Softwarehouse.Models;
using Softwarehouse.Repositorys;

namespace Softwarehouse.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRespository;

        public CustomerService(CustomerRepository customerRespository)
        {
            _customerRespository = customerRespository;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = _customerRespository.GetAllCustomers();
            return customers;
        }

        public Customer AddCustomer(Customer customer)
        {
            return _customerRespository.AddCustomer(customer);
        }
    }
}
