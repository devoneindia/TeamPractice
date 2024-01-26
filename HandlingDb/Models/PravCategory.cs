using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("prav_categories")]
    public class PravCategory
    {
        [Key]
        [Column("category_id")]
        public int Id { get; set; } = 1001;

       
        [MaxLength(100)]
        [Column("category_name")]
        public string? Name { get; set; }

        public virtual ICollection<PravSubCategory>? SubCategories { get; set; }
    }
}
