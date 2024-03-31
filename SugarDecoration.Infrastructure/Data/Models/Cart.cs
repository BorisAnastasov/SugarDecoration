using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SugarDecoration.Infrastructure.Data.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Cart table")]
	public class Cart
	{
        [Key]
        [Comment("Cart identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Costumer identifier")]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        [Comment("Products total price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Comment("Date of creation of cart")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Last date of modification of cart")]
        public DateTime ModifiedOn { get; set; }

        public IEnumerable<CartItem> CartItems { get; set; } 
                = new List<CartItem>();


    }
}
