using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("prav_product_details")]
    public class PravProducts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }


        public int? SubCategoryId { get; set; }
        public virtual PravSubCategory? SubCategory { get; set; }
    }
}
