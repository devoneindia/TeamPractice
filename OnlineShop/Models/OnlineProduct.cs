﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    [Table("aki_product")] //Master table
    public class OnlineProduct
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [MaxLength(500)]
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        [Column("price")]
        public decimal Price { get; set; } = decimal.Zero;
    }
}
