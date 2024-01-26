using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using HandlingDb.Models;
using HandlingDb.Contexts;

namespace HandlingDb.Components.Pages
{
    public partial class SanSchool
    {
        public SanClass cls { get; set; } = new SanClass();
        
        public List<SanClass>? clss { get; set; }
        public void AddClass()
        {
            SanClass sanClass = new SanClass();
            sanClass.Id = cls.Id;
            sanClass.Class = cls.Class;
            sanClass.Students = cls.Students;
            sanClass.Teachers = cls.Teachers;
            using (TeamDbContext teamDbContext = new TeamDbContext())
            {
                teamDbContext.sanclasses.Add(sanClass);
                teamDbContext.SaveChanges();
            }
        }
        
       
    }
}
