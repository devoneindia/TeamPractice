using HandlingDb.Contexts;
using HandlingDb.Models;
using Microsoft.EntityFrameworkCore;

namespace HandlingDb.Components.Pages
{
    public partial class PravSubCategoryPage
    {
        public List<PravCategory> PravCategories { get; set; } 
            = new List<PravCategory>()
            { 
                new PravCategory() {
                    Id = 1,
                    Name = "MyDummyCategory",
                    SubCategories = new List<PravSubCategory>()
                } ,
                new PravCategory() {
                    Id = 2,
                    Name = "MyDummyCategory2",
                    SubCategories = new List<PravSubCategory>()
                }
            };
        public List<PravSubCategory>? PravSubCategories { get; set; }
        public PravSubCategory? PravSubCategoryValues { get; set; } = new PravSubCategory();
        protected async override Task OnInitializedAsync()
        {
            await GetEmployees();
        }

        private async Task GetEmployees()
        {
            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                PravSubCategories = await employeeDbContext.Subcategories.ToListAsync();
                PravCategories = await employeeDbContext.Categories.ToListAsync();
            }
        }

        public async Task AddSubCategory()
        {
            PravSubCategory newSubCategory = new PravSubCategory();
            newSubCategory.Name = PravSubCategoryValues.Name;
            //newSubCategory.CategoryId = selectedCategoryId;
            newSubCategory.CategoryId = PravSubCategoryValues.CategoryId;

            int categoryId = -1;
            List<int> existingCategoryIds = new List<int>();
            using (TeamDbContext categoriesDbContext = new TeamDbContext())
            {
                existingCategoryIds = categoriesDbContext.Categories.Select(ct => ct.Id).ToList();
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
        private void OnDropdownChange(Microsoft.AspNetCore.Components.ChangeEventArgs e)
        {
            PravSubCategoryValues.CategoryId = Convert.ToInt32(e.Value);
        }
    }
}
