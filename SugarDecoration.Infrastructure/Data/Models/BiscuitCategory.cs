using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Category;

namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Category for biscuit")]
	public class BiscuitCategory
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

		public IEnumerable<Biscuit> Cakes { get; set; }
					= new List<Biscuit>();
	}
}
