using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("item")]
    public class Item
    {
        [Key]
        [Column("item_id")]
        public int Id { get; set; }

        [Column("item_name")]
        public string? Name { get; set; }

        [Column("sub_category_id")]
        public int? SubCategoryId { get; set; }
        public virtual SubCategory? SubCategory { get; set; }
    }
}
