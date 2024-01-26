using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandlingDb.Models
{
    [Table("san_student")]
    public class SanStudent
    {
        [Column("student_id")]
        [Key]
        public int Id { get; set; }
        [Column("student_name")]
        public string StudentName { get; set; } = string.Empty;
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
        [Column("class_id")]
        [ForeignKey("SanClass")]
        public int ClassId { get; set; }
        public virtual SanClass SanClass { get; set; }
    }
}
