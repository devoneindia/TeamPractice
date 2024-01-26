using HandlingDb.Contexts;
using HandlingDb.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace HandlingDb.Components.Pages
{
    public partial class PravCategoryPage
    {
       
        public List<PravCategory>? PravCategories { get; set; }

        public PravCategory PravCategoryValue { get; set; } = new PravCategory();
        protected async override Task OnInitializedAsync()
        {
            await GetEmployees();
        }

        private async Task GetEmployees()
        {
            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                PravCategories = await employeeDbContext.Categories.ToListAsync();
            }
        }

        public async Task AddCategory()
        {
            PravCategory newCategory = new PravCategory();
            newCategory.Id = PravCategoryValue.Id;
            newCategory.Name = PravCategoryValue.Name;
            //newUser.Name = RandomName(random.Next(5, 50));

            using (TeamDbContext employeeDbContext = new TeamDbContext())
            {
                employeeDbContext.Categories.Add(newCategory);
                employeeDbContext.SaveChanges();
            }
            await GetEmployees();
        }

        private Random random = new Random();

        private string? RandomName(char length)
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
