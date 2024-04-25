using Microsoft.EntityFrameworkCore;

namespace CSIT_Project.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<DeliveryDriver> DeliveryDrives { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
