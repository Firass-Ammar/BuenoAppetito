using BuonAppetito.Models;
using BuonAppetito;

namespace BuonAppetito.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RestaurantItemId { get; set; }
        public RestaurantItem RestaurantItem { get; set; }
    }
}
