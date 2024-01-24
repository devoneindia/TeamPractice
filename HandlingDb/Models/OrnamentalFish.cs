using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("ornamental_fish")]
    public class OrnamentalFish
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Column("life_span")]
        public string LifeSpan { get; set; } = string.Empty;
        [Column("water")]
        public string Water { get; set; } = string.Empty;
        [Column("colour")]
        public string Colour { get; set; } = string.Empty;
        [Column("origin")]
        public string Origin { get; set; } = string.Empty;
        [Column("food")]
        public string Food { get; set; } = string.Empty;
        [Column("price_per_piece")]
        public string PricePerPiece { get; set; } = string.Empty;
        [Column("price_per_pair")]
        public string PricePerPair { get; set; } = string.Empty;
        [Column("packing_fee")]
        public string PackingFee { get; set; } = string.Empty;

    }
}
