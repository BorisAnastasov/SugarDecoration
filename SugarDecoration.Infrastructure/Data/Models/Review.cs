using Microsoft.AspNetCore.Identity;
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
        public Product Product { get; set; } = null!;

        [Required]
        public string CostumerId { get; set; } = null!;
        public IdentityUser Costumer { get; set; } = null!;

        public DateTime CreatedOn { get; set; }
    }
}
