using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandlingDb.Models
{
    [Table("san_teacher")]
    public class SanTeacher
    {
        [Column("teacher_id")]
        [Key]
        public int id { get; set; }
        [Column("teacher_name")]
        public string TeacherName { get; set; } = string.Empty;
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
