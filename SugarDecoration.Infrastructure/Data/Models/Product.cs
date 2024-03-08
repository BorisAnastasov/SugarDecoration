using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Product
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title {  get; set; } = string.Empty;

        [Required]
		public double Price { get; set; }
        public double Rating { get; set; }

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedOn { get; set; }
	}
}
