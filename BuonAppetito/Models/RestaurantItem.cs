using System.ComponentModel.DataAnnotations;
using BuonAppetito.Models;

namespace BuonAppetito.Models
{
    public class RestaurantItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ItemCategory Category { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
