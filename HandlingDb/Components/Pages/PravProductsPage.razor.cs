using HandlingDb.Contexts;
using HandlingDb.Models;
using Microsoft.EntityFrameworkCore;

namespace HandlingDb.Components.Pages
{
    public partial class PravProductsPage
    {
        public List<PravProducts>? PravProducts { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await GetEmployees();
        }

        private async Task GetEmployees()
        {
            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                PravProducts = await employeeDbContext.ProductsData.ToListAsync();
            }
        }

        public async Task AddProducts()
        {
            PravProducts newUser = new PravProducts();
            newUser.Name = RandomName(random.Next(5, 50));
            //newUser.SubCategoryId = 
           
            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                employeeDbContext.ProductsData.Add(newUser);
                employeeDbContext.SaveChanges();
            }
            await GetEmployees();
        }

        private Random random = new Random();

        private string? RandomName(int length)
        {
            string alphabetArray = @"ABCDEFGHIJKLMNOPQRSTUVEWXZabcdefghijklmnopqrstuvewxz";
            string newWord = string.Empty;
            for (int i = 0; i < length; i++)
            {
                newWord = newWord + alphabetArray[random.Next(0, alphabetArray.Length - 1)];
            }
            return newWord;
        }
    }
}
