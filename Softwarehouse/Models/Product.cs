namespace Softwarehouse.Models
{
    public class Product
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Product(int productId, string name, int quantity, decimal price)
        {
            ProductId = productId;
            Name = name;
            Quantity = quantity;
            Price = price;

        }
    }
}
