using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBrand.Models
{
    [Table("sub_category")]
    public class SubCategory
    {
        [Key]
        [Required]
        [Column("sub_category_id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("sub_category_name")]
        public string? SubCategoryName { get; set; }

        [ForeignKey("category_id")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }


        public ICollection<PravProduct>? Products { get; }
        public ICollection<Category>? Categories { get; }
    }
}
