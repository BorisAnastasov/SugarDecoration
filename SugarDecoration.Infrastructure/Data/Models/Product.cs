using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Constants.DataConstants.Product;


namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Product
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title {  get; set; } = string.Empty;

        [Required]
		public double Price { get; set; }

        [Range(RatingMax,RatingMin)]
        public double Rating { get; set; }

        [Required]
        [StringLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedOn { get; set; }

        public IEnumerable<Review> Reviews { get; set; }
                = new List<Review>();

        public IEnumerable<CartProduct> CartProducts { get; set; } 
                = new List<CartProduct>();
    }
}
