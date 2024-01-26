using HandlingDb.Models;
using HandlingDb.Contexts;
namespace HandlingDb.Components.Pages
{
    public partial class SanAddStudent
    {
        public SanStudent std { get; set; } = new SanStudent();
        public List<SanStudent>? students { get; set; }

        public void AddStudent()
        {
            SanStudent sanStudent = new SanStudent();
            sanStudent.Id = std.Id;
            sanStudent.StudentName = std.StudentName;
            sanStudent.FatherName = std.FatherName;
            sanStudent.Dob = std.Dob;
            sanStudent.Class = std.Class;
            sanStudent.Section = std.Section;
            sanStudent.BloodGroup = std.BloodGroup;
            sanStudent.Address = std.Address;
            using (TeamDbContext teamDbContext2 = new TeamDbContext())
            {
                teamDbContext2.sanStudents.Add(sanStudent);
                teamDbContext2.SaveChanges();
            }
        }
    }
}
