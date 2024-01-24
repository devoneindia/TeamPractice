using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSchool.Models
{
    [Table("school")]
    public class School
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("student_record")]
        public string StudentRecord { get; set; } = string.Empty;
        [Column("student_id")]
        [ForeignKey("student-record")]
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
    }
}
