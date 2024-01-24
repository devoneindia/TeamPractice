using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("cricketer_details")]
    public class CricketerDetails
    {
        [Key]
        [Column("player_id")]
        public int Id { get; set; }

        [MaxLength(100)]
        [Column("player_name")]
        public string? Name { get; set; }
        [MaxLength(4)]
        [Column("player_number")]
        public string Number { get; set; }
        [Column("gender")]
        public bool Gender { get; set; }
        [MaxLength(2)]
        [Column("age")]
        public string Age { get; set; }
        [MaxLength(50)]
        [Column("city")]
        public string City { get; set; }
        [MaxLength(50)]
        [Column("nation")]
        public string Nation { get; set; }
        [MaxLength(10)]
        [Column("mobile")]
        public string MobileNumber { get; set; }
        [MaxLength(100)]
        [Column("address")]
        public string Address { get; set; }
        [MaxLength(100)]
        [Column("address2")]
        public string Address2 { get; set; }
        [MaxLength(100)]
        [Column("address3")]
        public string Address3 { get; set; }
        [MaxLength(100)]
        [Column("address4")]
        public string Address4 { get; set; }
    }
 }
