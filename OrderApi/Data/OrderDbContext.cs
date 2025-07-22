using Microsoft.EntityFrameworkCore;
using Shared.Model;

namespace OrderApi.Data
{
    public class OrderDbContext : DbContext 
    { 
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) 
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
