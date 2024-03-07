using SugarDecoration.Infrastructure.Data.Categories;
using SugarDecoration.Infrastructure.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Cake:IProduct
	{
		[Key]
        public int Id { get; set; }

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public double Price { get; set; }

		[Required]
		public string ImageUrl { get; set; } = string.Empty;

		[Required]
		[Range(1,5)]
        public int Layers { get; set; }

		[Required]
        public int Portions { get; set; }

		[Required]
        public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public CakeCategory Category { get; set; } = null!;

    }
}
