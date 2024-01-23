using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("order_record")]
    public class CustomerOrder
    {
        [Column("order_id")]
        [Key]
        public string OrderId { get; set; }
        [MaxLength(100)]
        [Column("order_name")]
        public string CustomerName { get; set; }
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

    }
}
