using Microsoft.AspNetCore.Identity;
using SugarDecoration.Infrastructure.Data.IdentityModels;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Cart
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string CostumerId { get; set; } = null!;
        public ApplicationUser Costumer { get; set; } = null!;

        public double TotalPrice { get; set; } = 0.00;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        public IEnumerable<CartProduct> CartProducts { get; set; } 
                = new List<CartProduct>();


    }
}
