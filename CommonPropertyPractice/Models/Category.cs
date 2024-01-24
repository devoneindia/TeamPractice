using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonPropertyPractice.Models
{
    [Table("category_details")]
    public class Category
    {
        [Key]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [MaxLength(100)]
        [Column("category_name")]
        public string? CategoryName { get; set; }
    }
}
