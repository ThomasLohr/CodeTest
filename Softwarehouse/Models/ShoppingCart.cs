namespace Softwarehouse.Models
{
    public class ShoppingCart
    {
        public int CartId { get; set; }

        public string Name { get; set; }

        public int Items { get; set; }

        public  decimal TotalPrice { get; set; }
    } 
}
