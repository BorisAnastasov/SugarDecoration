using SugarDecoration.Data.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Data
{
    public class Cake : IProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Layers { get; set; }

        [Required]
        public int Portion { get; set; }

        [Required]
        public string ImagePath { get; set; }
        public string? Ingredients { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public IEnumerable<CakeCategory> BiscuitCategories { get; set; }
                = new List<CakeCategory>();
    }
}
