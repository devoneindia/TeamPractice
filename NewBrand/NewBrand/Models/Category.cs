using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBrand.Models
{
    [Table("category_details")]
    public class Category
    {
        [Key]
        [Required]
        [MaxLength(5)]
        [Column("category_id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("category_name")]
        public string? ProductName { get; set; }

        [ForeignKey("SubCategory")]
        [MaxLength(100)]
        [Column("sub_category_id")]
        public int SubCategoryId { get; set; }
        public virtual SubCategory? SubCategory { get; set; }


        public virtual ICollection<PravProduct>? Products { get; }

        public virtual ICollection<SubCategory>? SubCategories { get; set; }

    }
}
