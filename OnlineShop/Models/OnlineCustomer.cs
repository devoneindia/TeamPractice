using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    [Table("aki_customer")] //Parent table
    public class OnlineCustomer
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("aki_product")]
        [Column("product_id")]
        public int ProductId { get; set; }
        [MaxLength(500)]
        [Column("email")]
        public string Email { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("phone")]
        public string Phone { get; set; } = string.Empty.ToString();
        [MaxLength(500)]
        [Column("addressLine1")]
        public virtual OnlineProduct Products { get; set; }
    }
}
