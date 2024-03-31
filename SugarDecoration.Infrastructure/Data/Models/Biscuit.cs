using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
	[Comment("Biscuit table")]
	public class Biscuit
	{
		[Key]
		[Comment("Biscuit identifier")]
		public int Id { get; set; }

		[Required]
		[Comment("Biscuit quantity")]
		public int Quantity { get; set; }

		[Required]
		[Comment("Category identifier")]
		public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public BiscuitCategory Category { get; set; } = null!;

		[Required]
		[Comment("Product identifier")]
		public int ProductId { get; set; }

		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; } = null!;
    }
}
