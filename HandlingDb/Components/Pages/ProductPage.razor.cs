using HandlingDb.Contexts;
using HandlingDb.Models;

namespace HandlingDb.Components.Pages
{
    public partial class ProductPage
    {

        public Product ProductModel { get; set; } = new Product();

        public List<Product> ProductList { get; set; }

      // public ProductPage() { }

        public void HandleValidSubmit()
        {

            Console.WriteLine($"Name: {ProductModel.Name}," +
                        $" Price: {ProductModel.Price}");

        }
                private void SendProductToDatabase(Product product)
        {
            using (TeamDbContext teamDbContext = new TeamDbContext())
            {
                teamDbContext.ProductsTable.Add(product);
                teamDbContext.SaveChanges();
            }
        }
        public void AddProduct() {

            Product newProduct = new Product();
           newProduct.Name = ProductModel.Name;
           newProduct.Price = ProductModel.Price;
            SendProductToDatabase(newProduct);
            
            using(TeamDbContext teamDbContext = new TeamDbContext())
            {
                teamDbContext.ProductsTable.ToList();
            }


        }
    }
}
