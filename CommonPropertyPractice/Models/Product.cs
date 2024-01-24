using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonPropertyPractice.Models
{
    [Table("product_details")]
    public class Product
    {
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }

        [MaxLength(100)]
        [Column("product_name")]
        public string? ProductName { get; set; }

        [MaxLength(100)]
        [Column("product_description")]
        public string? ProductDescription { get; set;}

        [MaxLength(100)]
        [Column("product_category")]
        public string? ProductCategory { get; set;}

        [MaxLength(100)]
        [Column("product_price")]
        public string? ProductPrice { get;set;}

        [Column("product_status")]
        public bool? ProductStatus { get; set; } = true;
    }
}
