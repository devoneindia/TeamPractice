using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("customer_record")] //Parent table
    public class Customer
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        
        [ForeignKey("product")]
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
        public string AddressLine1 { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("addressLine2")]
        public string AddressLine2 { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("addressLine3")]
        public string AddressLine3 { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("addressLine4")]
        public string AddressLine4 { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("state")]
        public string State { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("pinCode")]
        public string PinCode { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("dateofbirth")]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [MaxLength(500)]
        [Column("subscriptionstatus")]
        public bool SubscriptionStatus { get; set; } = false;

        public virtual Product Products { get; set; }


    }
}