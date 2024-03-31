using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Cart item")]
	public class CartItem
	{
        [Key]
        [Comment("CartItem identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Cart identifier")]
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

        [Required]
        [Comment("Product identifier")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("Quantity of the product")]
        public int Quantity { get; set; }

        [Required]
        [Comment("Product price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
