using Microsoft.EntityFrameworkCore;
using OrderDelivery.Domain;

namespace OrderDelivery.DAL
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
