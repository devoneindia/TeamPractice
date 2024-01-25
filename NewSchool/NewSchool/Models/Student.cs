using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSchool.Models
{
    [Table("student")]
    public class Student
    {
        [Column("student_id")]
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string name { get; set; } = string.Empty;
        [Column("father_name")]
        public string FatherName { get; set; } = string.Empty;
        [Column("dob")]
        public DateOnly Dob { get; set; }
        [Column("class")]
        public string Class { get; set; } = string.Empty;
        [Column("section")]
        public string Section { get; set; } = string.Empty;
        [Column("blood_group")]
        public string BloodGroup { get; set; } = string.Empty;
        [Column("address")]
        public string Address { get; set; } = string.Empty;
        public virtual ICollection<Student>? Students { get; set; }

    }
}
