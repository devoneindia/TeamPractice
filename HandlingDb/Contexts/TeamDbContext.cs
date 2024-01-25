using HandlingDb.Models;
using Microsoft.EntityFrameworkCore;

namespace HandlingDb.Contexts
{
    public class TeamDbContext : DbContext
    {
        public DbSet<CricketerDetails> UserDeatils { get; set; }
        public DbSet<Customer> CustomerRecords { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<OrnamentalFish> fish {  get; set; }
        public DbSet<Desktop> desktopRecords { get; set; }
        public DbSet<Mobile> mobileRecords { get; set; }
        public DbSet<StudentRegister> data { get; set; }
        public DbSet<Bike> bikes { get; set; }
        public DbSet<CricketerDetails> cricketerData { get; set; }
        public DbSet<CricketerDetails> CricketerDeatils { get; set; }
        public DbSet<PravProducts> ProductsData { get; set; }
        public DbSet<PravSubCategory> Subcategories { get; set; }
        public DbSet<PravCategory> Categories { get; set; }
        
        public TeamDbContext()
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
            string dbConnString = configurationInstance["ConnectionStrings:DbTeam"] ?? "";
            optionsBuilder.UseNpgsql(dbConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
