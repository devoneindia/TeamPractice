using HandlingDb.Contexts;
using HandlingDb.Models;
using Microsoft.EntityFrameworkCore;

namespace HandlingDb.Components.Pages
{
    public partial class PravSubCategoryPage
    {
        public List<PravSubCategory>? PravSubCategories { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await GetEmployees();
        }

        private async Task GetEmployees()
        {
            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                PravSubCategories = await employeeDbContext.Subcategories.ToListAsync();
            }
        }

        public async Task AddSubCategory()
        {
            PravSubCategory newSubCategory = new PravSubCategory();
            newSubCategory.Name = RandomName(random.Next(5, 50));

            int categoryId = -1;
            List<int> existingCategoryIds = new List<int>();
            using(TeamDbContext categoriesDbContext = new TeamDbContext())
            {
                existingCategoryIds = categoriesDbContext.Categories.Select(ct=>ct.Id).ToList();                
            }
            categoryId = existingCategoryIds[random.Next(1, existingCategoryIds.Count)];
            newSubCategory.CategoryId = categoryId;


            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                employeeDbContext.Subcategories.Add(newSubCategory);
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
