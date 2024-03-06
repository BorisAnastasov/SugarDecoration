using SugarDecoration.Data.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Data
{
    public class Biscuit : IProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public string ImagePath { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        public string? Ingredients { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public IEnumerable<BiscuitCategory> BiscuitCategories { get; set; }
                = new List<BiscuitCategory>();
    }
}
