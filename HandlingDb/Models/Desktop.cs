using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("desktop")]
    public class Desktop
    {
        [Column("desktop_id")]
        [Key]
        public int Id { get; set; }
        [Column("brand")]
        public string Brand { get; set; } = string.Empty;
        [Column("processor")]
        public string Processor { get; set; } = string.Empty;
        [Column("ram")]
        public string Ram { get; set; } = string.Empty;
        [Column("rom")]
        public string Rom { get; set; } = string.Empty;
        [Column("graphics")]
        public string Graphics { get; set; } = string.Empty;
        [Column("ssd")]
        public string Ssd { get; set; } = string.Empty;
        [Column("os")]
        public string Os { get; set; } = string.Empty;
        [Column("os_version")]
        public string OsVersion { get; set; } = string.Empty;
        [Column("price")]
        public int Price { get; set; }
        [Column("manufacture_date")]
        public DateOnly ManufactureDate { get; set; }
    }
    
}
