using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandlingDb.Models
{
    public class Product
    {
        
        [Table("product_record")]
        public class Prodeuct
        {
            [Column("id")]
            [Key]
            public int Id { get; set; }
            [MaxLength(100)]
            [Column("name")]
            public string ProductName { get; set; }
            [MaxLength(100)]
            [Column("price")]
            public decimal Price { get; set; }

        }
    }


}

