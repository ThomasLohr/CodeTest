using Softwarehouse.Models;

namespace Softwarehouse.Repositorys
{
    public class CustomerRepository
    {
        private static List<Customer> _customerList;

        public CustomerRepository()
        {
            _customerList = new List<Customer>()
            {
                new Customer(1, "Anders", "678 56 London", "tijiw79503@offsala.com", 25m),
                new Customer(2, "Caroline", "678 54 New York", "pojom13282@safe-cart.com", 40m),
                new Customer(3, "Dave", "435 90 Copenhagen", "caloca9404@offsala.com", 30m)
            };
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerList;
        }
        public Customer AddCustomer(Customer customer)
        {
            _customerList.Add(customer);

            return customer;
        }
    }
}
