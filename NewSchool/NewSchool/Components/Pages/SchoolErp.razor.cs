using NewSchool.Contexts;
using NewSchool.Models;
using Microsoft.EntityFrameworkCore;
namespace NewSchool.Components.Pages
{
    public partial class SchoolErp
    {
        public List<Teacher>? Teachers { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await GetTeachers();
        }

        private async Task GetTeachers()
        {
            using (SchoolDbContext schoolDbContext = new SchoolDbContext())
            {
                Teachers = await schoolDbContext.Teachers.ToListAsync();
            }
        }

        public async Task AddTeacher()
        {
            Teacher  newUser = new Teacher();
            newUser.name = RandomName(random.Next(5, 10));
            newUser.Class = RandomName(random.Next(1,7));
            newUser.Section = RandomName(random.Next(1, 3));
            newUser.BloodGroup = RandomName(random.Next(1, 3));
            newUser.Address = RandomName(random.Next(8, 20 ));
            using (SchoolDbContext schoolDbContext = new SchoolDbContext())
            {
                schoolDbContext.Teachers.Add(newUser);
                schoolDbContext.SaveChanges();
            }
            await GetTeachers();
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
