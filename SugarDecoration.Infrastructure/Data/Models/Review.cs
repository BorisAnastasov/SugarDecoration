using SugarDecoration.Infrastructure.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Review
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; } = string.Empty;

        [Required]
        public double Rating { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public IProduct Product { get; set; } = null!;

        public string CostumerId { get; set; } = null!;
    }
}
