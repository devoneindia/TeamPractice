using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommonPropertyPractice.Models
{
    [Table("sub_category_details")]
    public class SubCategory
    {
        [Key]
        [Column("sub_category_id")]
        public int SubCategoryId { get; set; }

        [MaxLength(100)]
        [Column("sub_category_name")]
        public string? SubCategoryName { get; set; }
    }
}
