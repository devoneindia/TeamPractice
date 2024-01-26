using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("san_class")]
    public class SanClass
    {
        [Column("class_id")]
        [Key]
        public int Id { get; set; }
        [Column("class")]
        public string Class { get; set; } = string.Empty;
        public virtual ICollection<SanStudent> Students { get; set; }
        public virtual ICollection<SanTeacher> Teachers { get; set; }
    }
}
