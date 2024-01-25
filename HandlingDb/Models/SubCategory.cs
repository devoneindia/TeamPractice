using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandlingDb.Models
{
    [Table("sub_categories")]
    public class SubCategory
    {
        [Key]
        
        [Column("sub_category_id")]
        public int Id { get; set; }

        [ForeignKey("category")]
        [Column("category_id")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        [MaxLength(100)]
        [Column("sub_category_name")]
        public string? Name { get; set; }

       // public virtual ICollection<Products>? Items { get; set; }
    }
}
