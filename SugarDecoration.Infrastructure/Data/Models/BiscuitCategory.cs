using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Constants.DataConstants.Category;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class BiscuitCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;
    }
}
