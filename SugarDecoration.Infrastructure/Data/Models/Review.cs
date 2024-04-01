using Microsoft.EntityFrameworkCore;
using SugarDecoration.Infrastructure.Data.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Review;


namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Review table for products")]
    public class Review
    {
        [Key]
        [Comment("Review identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(CommentMaxLength)]
        [Comment("Review comment")]
        public string Comment { get; set; } = string.Empty;

        [Required]
        //[Range(RatingMax, RatingMin)]
        [Comment("Review rating")]
        public double Rating { get; set; }

        [Required]
        [Comment("Product identifier")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("Costumer identifier")]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("Date of creation of review")]
        public DateTime CreatedOn { get; set; }
    }
}
