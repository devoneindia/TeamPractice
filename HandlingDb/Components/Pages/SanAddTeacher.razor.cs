using HandlingDb.Models;
using HandlingDb.Contexts;
namespace HandlingDb.Components.Pages
{
    public partial class SanAddTeacher
    {
        public SanTeacher tcr { get; set; } = new SanTeacher();
        public List<SanTeacher>? teacher { get; set; }
        public void AddTeacher()
        {
            SanTeacher sanTeacher = new SanTeacher();
            sanTeacher.id = tcr.id;
            sanTeacher.TeacherName = tcr.TeacherName;
            sanTeacher.Class = tcr.Class;
            sanTeacher.Section = tcr.Section;
            sanTeacher.BloodGroup = tcr.BloodGroup;
            sanTeacher.Address = tcr.Address;
            using (TeamDbContext teamDbContext1 = new TeamDbContext())
            {
                teamDbContext1.sanTeachers.Add(sanTeacher);
                teamDbContext1.SaveChanges();
            }
        }
    }
}
