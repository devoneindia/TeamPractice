using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Contexts
{
    public class ShopDbContext : DbContext
    {
        public DbSet<OnlineCustomer> OnlineCustomerTable { get; set; }
        public DbSet<OnlineOrder> OnlineOrderTable { get; set; }
        public DbSet<OnlineProduct> OnlineProductTable { get; set; }
        public ShopDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configurationInstance = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.FullName ?? ".")
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.local.json", optional: true)
                .Build();
            string dbConnString = configurationInstance["ConnectionStrings:DbShop"] ?? "";
            optionsBuilder.UseNpgsql(dbConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
