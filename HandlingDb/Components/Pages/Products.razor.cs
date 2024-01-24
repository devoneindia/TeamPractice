using HandlingDb.Contexts;
using HandlingDb.Models;
using Microsoft.EntityFrameworkCore;

namespace HandlingDb.Components.Pages
{
    public partial class Products
    {
        public List<Category>? Categories { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await GetEmployees();
        }

        private async Task GetEmployees()
        {
            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                Categories = await employeeDbContext.categories.ToListAsync();
            }
        }

        public async Task AddProducts()
        {
            Category newUser = new Category();
            newUser.Name = RandomName(random.Next(5, 50));
            //newUser.SubCategoryId =  Have to map the subcategoryId
            //newUser.SubCategoryId = random.Next(100000000, 999999999);
             using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                employeeDbContext.categories.Add(newUser);
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
