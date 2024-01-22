using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandlingDb.Models
{
    [Table("student_register")]
    public class StudentRegister
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = string.Empty;
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

    }
}







