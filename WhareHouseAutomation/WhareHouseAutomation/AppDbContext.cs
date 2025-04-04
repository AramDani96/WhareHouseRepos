using Microsoft.EntityFrameworkCore;
using WhareHouseAutomation.Models;

namespace WhareHouseAutomation
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Inbound> Inbounds { get; set; }
        public DbSet<Outbound> Outbounds { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ProductsDataBase;Integrated Security=True;Encrypt=False");
        }
    }
}
