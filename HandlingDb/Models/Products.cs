using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("products")]
    public class Products
    {
        [Key]
        [Column("product_id")]
        public int Id { get; set; }

        [Column("product_name")]
        public string? Name { get; set; }

        [Column("sub_category_id")]
        public int? SubCategoryId { get; set; }
        public virtual SubCategory? SubCategory { get; set; }
    }
}
