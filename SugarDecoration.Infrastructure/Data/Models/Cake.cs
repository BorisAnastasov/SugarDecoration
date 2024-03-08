using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Cake
	{
		[Key]
        public int Id { get; set; }

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
