using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandlingDb.Models
{
    [Table("prav_sub_categories")]
    public class PravSubCategory
    {
        [Key]
        
        [Column("sub_category_id")]
        public int Id { get; set; }

        [MaxLength(100)]
        [Column("sub_category_name")]
        public string? Name { get; set; }

        [ForeignKey("Category")]
        [Column("category_id")]
        public int CategoryId { get; set; }

        public virtual PravCategory? Category { get; set; }

       

        public virtual ICollection<PravProducts>? Products { get; set; }
    }
}
