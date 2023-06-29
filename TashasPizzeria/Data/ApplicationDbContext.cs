using Microsoft.EntityFrameworkCore;
using TashasPizzeria.Models;

namespace TashasPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            
        }
        
    }
}
