using HandlingDb.Components.Pages;
using HandlingDb.Models;
using Microsoft.EntityFrameworkCore;


namespace HandlingDb.Contexts
{
    public class TeamDbContext : DbContext
    {
        public DbSet<SanClass> sanclasses { get; set; }
        public DbSet<SanStudent> sanStudents  { get; set; }
        public DbSet<SanTeacher> sanTeachers  { get; set; }
        public DbSet<CricketerDetails> UserDeatils { get; set; }
        public DbSet<AquariumShop>  shops { get; set; }
        public DbSet<FishFood> fishFoods { get; set; }
        public DbSet<Customer> CustomerRecords { get; set; }
        public DbSet<Product> ProductsTable { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<OrnamentalFish> fish {  get; set; }
        public DbSet<Desktop> desktopRecords { get; set; }
        public DbSet<Mobile> mobileRecords { get; set; }
        public DbSet<StudentRegister> data { get; set; }
        public DbSet<Bike> bikes { get; set; }
        public DbSet<CricketerDetails> cricketerData { get; set; }
        //public DbSet<ProductItems> productsData { get; set; }
        public DbSet<CricketerDetails> CricketerDeatils { get; set; }
       
        public DbSet<SubCategory> subcategories { get; set; }
        public DbSet<Category> categories { get; set; }
        
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
            string dbConnString = configurationInstance["ConnectionStrings:Db"] ?? "";
            optionsBuilder.UseNpgsql(dbConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
