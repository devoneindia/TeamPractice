using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("categories")]
    public class Category
    {
        [Key]
        [Column("category_id")]
        public int Id { get; set; }

       
        [MaxLength(100)]
        [Column("category_name")]
        public string? Name { get; set; }

        public virtual ICollection<SubCategory>? SubCategories { get; set; }
    }
}
