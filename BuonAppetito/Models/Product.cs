namespace BuonAppetito.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; } 
        public decimal Price { get; set; } 
        public string BrandName { get; set; }
        public ItemCategory Category { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
