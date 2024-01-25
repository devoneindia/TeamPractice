using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandlingDb.Models
{
    [Table("fish_food")]
    public class FishFood
    {
        [Column("food_id")]
        [Key]
        public int FoodId { get; set; }
        [Column("food_name")]
        public string FoodName { get; set; } = string.Empty;
        [Column("food_price")]
        public string FoodPrice { get; set; } = string.Empty;
        public ICollection<FishFood>? fishFoods { get; set; }
    }
}
