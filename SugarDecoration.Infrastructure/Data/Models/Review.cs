using Microsoft.AspNetCore.Identity;
using SugarDecoration.Infrastructure.Data.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SugarDecoration.Infrastructure.Constants.DataConstants.Review;


namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Review
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CommentMaxLength)]
        public string Comment { get; set; } = string.Empty;

        [Required]
        [Range(RatingMax, RatingMin)]
        public double Rating { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        public string CostumerId { get; set; } = null!;
        public ApplicationUser Costumer { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
