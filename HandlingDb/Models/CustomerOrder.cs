using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("order_record")] // Child table
    public class CustomerOrder
    {
        [Key]
        [Column("order_id")]        
        public int OrderId { get; set; }

        [MaxLength(100)]
        [Column("order_name")]
        public string OrderName { get; set; }

        [ForeignKey("product")]
        [Column("product_id")]
        public int ProductId { get; set; }

        [ForeignKey("customer_record")]
        [Column("customer_id")]
        public int CustomerId { get; set; } = 0;
         
        [MaxLength(100)]
        [Column("order_date")]
        public DateTime OrderDate { get; set; }
        [MaxLength(100)]
        [Column("total_amount")]

        public Decimal TotalAmount  { get; set; }
        [MaxLength(100)]
        [Column("shipping_Address")]
        public string ShippingAderess { get; set; }
        [MaxLength(100)]
        [Column("payment_method")]
        public string PaymentMethod { get; set; }
        [MaxLength(100)]
        [Column("is_paid")]
        public bool IsPaid { get; set;}
        [MaxLength(100)]
        [Column("order_status")]
        public string OrderStatus { get; set;}
        [MaxLength(100)]
        [Column("tracking-number")]
        public string TrackingNumber { get; set;}

        public virtual Product Products { get; set; }
        public virtual Customer customer { get; set; }

    }
}
