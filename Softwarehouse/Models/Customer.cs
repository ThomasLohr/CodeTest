namespace Softwarehouse.Models

{
    public class Customer
    {
        public List<Product> Product { get; set; } = new List<Product>();
        
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }

        public decimal DiscountPercentage { get; set; }

        public Customer(int customerId, string name, string email, string adress, decimal discountPercentage, List<Product> product)
        {

            CustomerId = customerId;
            Name = name;
            Email = email;
            Adress = adress;
            DiscountPercentage = discountPercentage;
            Product = product;
        }
        public Customer(int customerId, string name, string email, string adress, decimal discountPercentage)
        {

            CustomerId = customerId;
            Name = name;
            Email = email;
            Adress = adress;
            DiscountPercentage = discountPercentage;
        }
        public Customer()
        {

        }
    }
}
