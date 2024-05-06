using BuonAppetito.Models;
using Microsoft.EntityFrameworkCore;

public class BuonContext : DbContext
{
    public BuonContext(DbContextOptions<BuonContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
}
