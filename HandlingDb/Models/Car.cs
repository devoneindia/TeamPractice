using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("car_details")]
    public class Car
    {
        [Column("car_id")]
        [Key]
        public int CarId { get; set; }

        [MaxLength(100)]
        [Column("car_make")]
        public string? CarMake { get; set; }

        [MaxLength(100)]
        [Column("car_model")]
        public string? CarModel { get; set; }

        [MaxLength(50)]
        [Column("car_year")]
        public string? CarYear { get; set; }

        [MaxLength(50)]
        [Column("car_color")]
        public string? CarColor { get; set; }

        [MaxLength(17)]
        [Column("vin_number")]
        public string? VinNumber { get; set; }

        [MaxLength(100)]
        [Column("owner_name")]
        public string? OwnerName { get; set; }

        [MaxLength(50)]
        [Column("registration_number")]
        public string? RegistrationNumber { get; set; }

        [MaxLength(50)]
        [Column("insurance_provider")]
        public string? InsuranceProvider { get; set; }

        [MaxLength(50)]
        [Column("insurance_policy_number")]
        public string? InsurancePolicyNumber { get; set; }
    }
}
