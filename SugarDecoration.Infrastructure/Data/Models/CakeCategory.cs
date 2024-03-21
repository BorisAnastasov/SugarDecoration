using SugarDecoration.Infrastructure.Data.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Infrastructure.Data.Models
{
    public class CakeCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
