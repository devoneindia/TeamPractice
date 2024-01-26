using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    [Table("aki_order")] // Child table
    public class OnlineOrder
    {
        [Key]
        [Column("id")]
        public int OrderId { get; set; }

        [MaxLength(100)]
        [Column("name")]
        public string OrderName { get; set; }

        [ForeignKey("aki_product")]
        [Column("product_id")]
        public int ProductId { get; set; }

        [ForeignKey("aki_customer")]
        [Column("customer_id")]
        public int CustomerId { get; set; } = 0;

        [MaxLength(100)]
        [Column("order_date")]
        public DateTime OrderDate { get; set; }
        [MaxLength(100)]
        [Column("total_amount")]

        public virtual OnlineProduct Products { get; set; }
        public virtual OnlineCustomer customer { get; set; }
    }
}
