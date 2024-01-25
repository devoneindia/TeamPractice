using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [MaxLength(500)]
        [Column("name")]
        public string Name { get; set; }
        [MaxLength(500)]
        [Column("price")]
        public decimal Price { get; set; }

       
    }
}
