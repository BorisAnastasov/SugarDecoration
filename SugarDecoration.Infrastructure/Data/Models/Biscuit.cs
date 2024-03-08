using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Biscuit
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public BiscuitCategory Category { get; set; } = null!;
    }
}
