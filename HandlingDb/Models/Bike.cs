using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("bike")]
    public class Bike
    {
        [Column]
        [Key]
        public int Id { get; set; }
        [Column("brand")]
        public string Brand { get; set; } = string.Empty;
        [Column("model")]
        public string Model { get; set; } = string.Empty;
        [Column("manufacture_date")]
        public DateOnly ManufactureDate { get; set; }
        [Column("registration_date")]
        public DateOnly RegistrationDate { get; set; }
        [Column("cubic_cylinder")]
        public string CubicCylinder { get; set; } = string.Empty;
        [Column("chassis_number")]
        public string ChassisNumber { get; set; } = string.Empty;
        [Column("engine_number")]
        public string EngineNumber { get; set; } = string.Empty;
        [Column("wheel_size")]
        public int WheelSize { get; set; } 
        [Column("seat_capacity")]
        public string SeatCapacity { get; set; } = string.Empty;

    }
}
