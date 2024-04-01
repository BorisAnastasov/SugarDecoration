using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Category;

namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Category for cake")]
    public class CakeCategory
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;
        
    }
}
