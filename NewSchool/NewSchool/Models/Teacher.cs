using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewSchool.Models
{
    [Table("teacher")]
    public class Teacher
    {
        [Column("teacher_id")]
        [Key]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; } = string.Empty;
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
