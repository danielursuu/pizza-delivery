using Microsoft.EntityFrameworkCore;

namespace PizzaDeliveryAPI.Data
{
    public class PizzaContext : DbContext
    {

        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {

        }

        public DbSet<Pizza> Pizza { get; set; }
    }
}
