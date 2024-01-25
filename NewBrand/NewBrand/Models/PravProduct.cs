using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace NewBrand.Models
{
    [Table("product_details")]
    public class PravProduct
    {
        [Key]
        [Required]
        [MaxLength(5)]
        [Column("product_id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("product_name")]
        public string? ProductName { get; set; }

        [Required]
        [MaxLength(5)]
        [Column("product_price")]
        public Decimal? ProductPrice { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("product_description")]
        public string? ProductDescription { get; set; }

        //[ForeignKey("Category")]
        [Required]
        [MaxLength(5)]
        [Column("category_id")]
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        [ForeignKey("SubCategory")]
        [Required]
        [MaxLength(100)]
        [Column("sub_category_id")]
        public int SubCategoryId { get; set;}
        public virtual SubCategory? SubCategory { get; set; }
    }
}
