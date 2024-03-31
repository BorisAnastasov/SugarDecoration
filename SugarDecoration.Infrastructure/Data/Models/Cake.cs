using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SugarDecoration.Infrastructure.Constants.DataConstants.Cake;


namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Cake table")]
    public class Cake
	{
		[Key]
		[Comment("Cake identifier")]
        public int Id { get; set; }

		[Required]
		[Range(LayersMin,LayersMax)]
		[Comment("Cake layers")]
        public int Layers { get; set; }

		[Required]
		[StringLength(FormMaxLength)]
		[Comment("Cake form")]
        public string Form { get; set; } = string.Empty;

        [Required]
		[Range(PortionsMax,PortionsMin)]
        [Comment("Cake portions")]
        public int Portions { get; set; }

		[Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public CakeCategory Category { get; set; } = null!;

		[Required]
        [Comment("Product identifier")]
        public int ProductId { get; set; }

		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; } = null!;
    }
}
