using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("aquarium_shop")]
    public class AquariumShop
    {
        [Column("shop_id")]
        [Key]
        public int Id { get; set; }
        [Column("shop_name")]
        public string ShopName { get; set; } = string.Empty;
        [Column("price_per_piece")]
        public string PricePerPiece { get; set; } = string.Empty;
        [Column("price_per_pair")]
        public string PricePerPair { get; set; } = string.Empty;
        [Column("packing_fee")]
        public string PackingFee { get; set; } = string.Empty;
        [Column("food_name")]
        public string FoodName { get; set; } = string.Empty;
        [Column("food_price")]
        public FishFood FishFood { get; set; }
        public string FoodPrice { get; set; } = string.Empty;
        public ICollection<OrnamentalFish>? ornamentalFish  { get; set; }
    }
}
