namespace BuonAppetito.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public decimal TotalPrice => CalculateTotalPrice();
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public void AddToCart(CartItem item)
        {
            CartItems.Add(item);
        }
        public void RemoveFromCart(CartItem item)
        {
            CartItems.Remove(item);
        }
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in CartItems)
            {
                totalPrice += item.Quantity * item.RestaurantItem.Price;
            }
            return totalPrice;
        }
    }
}
